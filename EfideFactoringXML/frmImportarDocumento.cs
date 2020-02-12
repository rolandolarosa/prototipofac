using EfideFactoring.General;
using EfideFactoringBE;
using EfideFactoringBL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace EfideFactoringXML
{
    public partial class frmImportarDocumento : EfideFactoring.FormulaBase.frmMntDato
    {
        List<FEXMLBE> LstEntityFE = new List<FEXMLBE>();
        int OrigenLote = 0;
        string IdLinea = string.Empty;
        string IdMoneda_tt = string.Empty;
        decimal IdFormaDesembolso = 0;
        string _IdSocio_Beneficiario = string.Empty;
        string _IdSocio_BeneficiarioRuc = string.Empty;
        bool IsError = false;
        OleDbConnection cnExcel;

        public frmImportarDocumento()
        {
            InitializeComponent();

            try
            {
                //GeneralXML.FechaOperacion = DateTime.Now;
                //GeneralXML.CodUsuario = "ADMIN";

                lblUsuario.Text = "Usuario: " + GeneralXML.CodUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmImportarDocumento_Load(object sender, EventArgs e)
        {
            try
            {
                txtFecha.Text = GeneralXML.FechaOperacion.ToString("d");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarXML_Click(object sender, EventArgs e)
        {
            try
            {
                IsError = false;
                txtFecha.Text = GeneralXML.FechaOperacion.ToString("d");   
                string Directorio = ConfigurationManager.AppSettings["RutaDirectorioFEXML"].ToString() + txtCarpetaXML.Text.ToString();
                List<string> LstFiles = Directory.GetFiles(Directorio).Where(f => System.IO.Path.GetExtension(f).ToUpper().Equals(".XML")).ToList();

                LstEntityFE = new List<FEXMLBE>();

                int Contador = 0;
                foreach (string File_Path in LstFiles)
                {
                    if (!IsError)
                    {
                        LectorXML(File_Path, Contador);
                    }
                }

                dgvFEDetalle.DataSource = LstEntityFE.ToList();
                lblnroRegistros.Text = LstEntityFE.Count() + " registro(s)";
                OrigenLote = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LectorXML(String file_path, int Contador)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(file_path);
                XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
                nsmgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
                nsmgr.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
                nsmgr.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");

                XmlNode node = xmlDoc.SelectSingleNode("/tns:Invoice/cbc:UBLVersionID", nsmgr); //Version
                string Version = node.InnerText.ToString();

                string strRucSocio = string.Empty; //RUC Socio
                string strRucPagadora = string.Empty; //RUC Pagadora
                string strFechaEmision = xmlDoc.SelectSingleNode("/tns:Invoice/cbc:IssueDate", nsmgr).InnerText; //Fecha de Emision
                string strNroDoc = xmlDoc.SelectSingleNode("/tns:Invoice/cac:Signature/cbc:ID", nsmgr).InnerText; //Serie y número
                string strMoneda = xmlDoc.SelectSingleNode("/tns:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount//@currencyID", nsmgr).InnerText; //Moneda
                string strImpuesto = xmlDoc.SelectSingleNode("/tns:Invoice/cac:TaxTotal/cbc:TaxAmount", nsmgr).InnerText; //Impuesto
                string strMonto = xmlDoc.SelectSingleNode("/tns:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount", nsmgr).InnerText; //Monto

                if (Version.Equals("2.0"))
                {
                    strRucSocio = xmlDoc.SelectSingleNode("/tns:Invoice/cac:AccountingSupplierParty//cbc:CustomerAssignedAccountID", nsmgr).InnerText; //RUC Socio
                    strRucPagadora = xmlDoc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty//cbc:CustomerAssignedAccountID", nsmgr).InnerText; //RUC Pagadora
                }
                else if (Version.Equals("2.1"))
                {
                    strRucSocio = xmlDoc.SelectSingleNode("/tns:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID", nsmgr).InnerText; //RUC Socio
                    strRucPagadora = xmlDoc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID", nsmgr).InnerText; //RUC Pagadora
                }
                else
                {
                    MessageBox.Show("Versión del XML no soportada - " + Version, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Contador == 0)
                {
                    if (!ObtenerLinea(strRucSocio, strMoneda))
                    {
                        Contador = 1;
                        IdLinea = string.Empty;
                        IdMoneda_tt = string.Empty;
                        txtIdSocio.Clear();
                        txtIdSocio_Dsc.Clear();
                        txtIdLinea_Dsc.Clear();
                        txtIdMoneda_tt_Dsc.Clear();
                        txtFecha.Clear();
                        txtIdTipoLinea_tt_Dsc.Clear();
                        txtCarpetaXML.Clear();
                        IdFormaDesembolso = 0;
                        MessageBox.Show("No se encontro ninguna linea del socio, por favor verifique.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IsError = true;
                        return;
                    }
                }

                string IdPagadora = string.Empty;
                string IdPagadora_Dsc = string.Empty;
                PagadoraBE oEntityPag = new PagadoraBE()
                {
                    OPCION = 1,
                    vcRuc = strRucPagadora
                };
                DataSet dsPag = new PagadoraBL().ProcesarPagadora(oEntityPag);

                if (dsPag.Tables[0].Rows.Count > 0)
                {
                    IdPagadora = dsPag.Tables[0].Rows[0]["IdPagadora"].ToString();
                    IdPagadora_Dsc = dsPag.Tables[0].Rows[0]["vcPagadora"].ToString();
                }

                DocumentoBE oEntityDoc = new DocumentoBE()
                {
                    OPCION = 4,
                    IdDocumento = "00010"
                };
                DataSet dsDoc = new DocumentoBL().ProcesarDocumento(oEntityDoc);

                string IdDocumento_Dsc = string.Empty;
                if (dsDoc.Tables[0].Rows.Count > 0)
                {
                    IdDocumento_Dsc = dsDoc.Tables[0].Rows[0]["cAbreviatura"].ToString();
                }

                SocioLineaPagDocBE oEntityPagDoc = new SocioLineaPagDocBE();
                oEntityPagDoc.OPCION = 1;
                oEntityPagDoc.IdLinea = IdLinea;
                oEntityPagDoc.IdPagadora = IdPagadora;
                oEntityPagDoc.IdDocumento = "00010"; // Factura Electronica
                DataSet dsPagDoc = new SocioLineaPagDocBL().ProcesarSocioLineaPagDoc(oEntityPagDoc);

                string IdTipoConfirmacion_Dsc = string.Empty;
                if (dsPagDoc.Tables[0].Rows.Count > 0)
                {
                    IdTipoConfirmacion_Dsc = dsPagDoc.Tables[0].Rows[0]["IdTipoConfirmacion_Dsc"].ToString();
                }

                FEXMLBE IEntity = new FEXMLBE()
                {
                    IdPagadora = IdPagadora,
                    IdPagadora_Dsc = IdPagadora_Dsc,
                    RUC = strRucPagadora,
                    IdDocumento = "00010", // Factura Electronica
                    IdDocumento_Dsc = IdDocumento_Dsc,
                    IdTipoConfirmacion_Dsc = IdTipoConfirmacion_Dsc,
                    cNumDoc = strNroDoc,
                    nvNominal = Convert.ToDecimal(strMonto),
                    nvNegociable = 0,
                    Mensaje = string.Empty,
                    IdSocio_BeneficiarioRuc = _IdSocio_BeneficiarioRuc
                };
                LstEntityFE.Add(IEntity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ObtenerLinea(string RucSocio, string Moneda)
        {
            bool bResult = false;
            try
            {
                Moneda = Moneda.Equals("PEN") ? "00036" : Moneda;
                Moneda = Moneda.Equals("USD") ? "00037" : Moneda;

                SocioLineaBE IEnitty = new SocioLineaBE()
                {
                    OPCION = 12,
                    RUCSocio = RucSocio,
                    IdMoneda_tt = Moneda
                };
                DataSet ds = new DataSet();
                ds = new SocioLineaBL().ProcesarSocioLinea(IEnitty);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtIdSocio.Text = ds.Tables[0].Rows[0]["IdSocio"].ToString();
                    txtIdSocio_Dsc.Text = ds.Tables[0].Rows[0]["IdSocio_Dsc"].ToString();
                    IdLinea = ds.Tables[0].Rows[0]["IdLinea"].ToString();
                    txtIdLinea_Dsc.Text = ds.Tables[0].Rows[0]["IdLinea_Dsc"].ToString();
                    txtIdMoneda_tt_Dsc.Text = ds.Tables[0].Rows[0]["IdMoneda_tt_Dsc"].ToString();
                    IdMoneda_tt = ds.Tables[0].Rows[0]["IdMoneda_tt"].ToString();
                    txtIdTipoLinea_tt_Dsc.Text = ds.Tables[0].Rows[0]["IdTipoLinea_tt_Dsc"].ToString();
                    IdFormaDesembolso = Convert.ToDecimal(ds.Tables[0].Rows[0]["IdFormaDesembolso"].ToString());
                    CargarGiradorOriginal();
                    bResult = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bResult;
        }

        private void CargarGiradorOriginal()
        {
            try
            {
                TercerCasoSocioBE oEntity = new TercerCasoSocioBE()
                {
                    OPCION = 4,
                    USUARIO = GeneralXML.CodUsuario,
                    IdSocio = txtIdSocio.Text,
                };

                DataSet ds = new DataSet();
                ds = new TercerCasoSocioBL().ProcesarTercerCasoSocio(oEntity);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    _IdSocio_Beneficiario = ds.Tables[0].Rows[0]["RazonSocial"].ToString();
                    _IdSocio_BeneficiarioRuc = ds.Tables[0].Rows[0]["Ruc"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (LstEntityFE.Count == 0)
                {
                    MessageBox.Show("No hay documentos para enviar a operaciones, por favor verifique.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int Index = 0;
                bool IsProcesar = true;
                List<DetaLoteBE> LstDetaLote = new List<DetaLoteBE>();
                foreach (FEXMLBE oEntityFE in LstEntityFE)
                {
                    ImportacionLoteBE oEntity = new ImportacionLoteBE()
                    {
                        RucPagadora = oEntityFE.RUC,
                        IdSocio = txtIdSocio.Text.Trim(),
                        IdLinea = IdLinea,
                        IdDocumento = oEntityFE.IdDocumento,
                        IdMoneda_tt = IdMoneda_tt,
                        cNumDoc = oEntityFE.cNumDoc
                    };
                    DataSet ds = new DataSet();
                    ds = new ImportacionLoteBL().ProcesarImportacionLote(oEntity);
                    if (!ds.Tables[0].Rows[0]["Result"].Equals("OK"))
                    {
                        IsProcesar = false;
                        LstEntityFE[Index].Mensaje = ds.Tables[0].Rows[0]["MsgResult"].ToString();
                        Index++;
                        continue;
                    }
                    else
                    {
                        if (oEntityFE.nvNegociable == 0)
                        {
                            LstEntityFE[Index].Mensaje = "El importe de pago no puede ser 0.";
                            IsProcesar = false;
                            Index++;
                            continue;
                        }

                        if (oEntityFE.sdVencimiento == DateTime.MinValue)
                        {
                            LstEntityFE[Index].Mensaje = "Ingresar la fecha de vencimiento válida.";
                            IsProcesar = false;
                            Index++;
                            continue;
                        }

                        if (oEntityFE.sdVencimiento <= GeneralXML.FechaOperacion)
                        {
                            LstEntityFE[Index].Mensaje = "Fecha de vencimiento no puede ser menor a la fecha de recepción.";
                            IsProcesar = false;
                            Index++;
                            continue;
                        }

                        LstEntityFE[Index].Mensaje = "OK";

                        TimeSpan ts = Convert.ToDateTime(oEntityFE.sdVencimiento) - GeneralXML.FechaOperacion;
                        DetaLoteBE oEntityDetLote = new DetaLoteBE();
                        oEntityDetLote.USUARIO = GeneralXML.CodUsuario;
                        oEntityDetLote.OPCION = 2;
                        oEntityDetLote.IdLote = string.Empty;
                        oEntityDetLote.cItem = "";
                        oEntityDetLote.IdPagadora = oEntityFE.IdPagadora;
                        oEntityDetLote.IdDocumento = oEntityFE.IdDocumento;
                        oEntityDetLote.cNumDoc = oEntityFE.cNumDoc;
                        oEntityDetLote.sdRecepcion = GeneralXML.FechaOperacion;
                        oEntityDetLote.iPlazo = ts.Days;
                        oEntityDetLote.sdVencimiento = Convert.ToDateTime(oEntityFE.sdVencimiento);
                        oEntityDetLote.nvNominal = Convert.ToDecimal(oEntityFE.nvNegociable);
                        oEntityDetLote.cNotaCredito = string.Empty;
                        oEntityDetLote.nNotaCredito = 0;
                        oEntityDetLote.nPorRetencion = 0;
                        oEntityDetLote.nvRetencion = 0;
                        oEntityDetLote.Descuento = 0;
                        oEntityDetLote.dtRenovacion = DateTime.MinValue;
                        oEntityDetLote.IdSocio_Beneficiario = string.Empty; //_IdSocio_Beneficiario;
                        oEntityDetLote.IdSocio_BeneficiarioRuc = oEntityFE.IdSocio_BeneficiarioRuc; //_IdSocio_BeneficiarioRuc;
                        LstDetaLote.Add(oEntityDetLote);

                        Index++;
                    }
                }

                if (IsProcesar)
                {
                    LoteBE LoteBE = new LoteBE()
                    {
                        USUARIO = GeneralXML.CodUsuario,
                        OPCION = 2,
                        IdLote = string.Empty,
                        IdSocio = txtIdSocio.Text,
                        sdDesembolso =  GeneralXML.FechaOperacion,
                        IdLinea = IdLinea,
                        IdMoneda_tt = IdMoneda_tt,
                        nImporte = LstDetaLote.Sum(f => f.nvNominal),
                        sdAprobacion = DateTime.MinValue,
                        nDesembolso = 0,
                        IdOperacion_tt = "00080", // Email*******
                        IdFormaDesembolso = IdFormaDesembolso,
                        jComunCuentaID = string.Empty,
                        jImporteAho = LstDetaLote.Sum(f => f.nvNominal)
                    };
                    string Result = new LoteBL().ProcesarLote(LoteBE, LstDetaLote);

                    if (!string.IsNullOrEmpty(Result))
                    {
                        DetaLoteBE oEntity = new DetaLoteBE();
                        oEntity.OPCION = 11;
                        oEntity.USUARIO = GeneralXML.CodUsuario;
                        oEntity.IdLote = Result;
                        oEntity.IdSocio_Beneficiario = txtCarpetaXML.Text.ToString();
                        oEntity.iPlazo = OrigenLote;
                        DataSet ds = new DetaLoteBL().ProcesarDetaLote(oEntity);

                        if (OrigenLote == 0)
                        {
                            DetaLoteBE oEntityCorrelativo = new DetaLoteBE();
                            oEntityCorrelativo.OPCION = 12;
                            oEntityCorrelativo.USUARIO = GeneralXML.CodUsuario;
                            DataSet dsCorr = new DetaLoteBL().ProcesarDetaLote(oEntityCorrelativo);

                            string Directorio = ConfigurationManager.AppSettings["RutaDirectorioFEXML"].ToString() + txtCarpetaXML.Text.ToString() + "\\RM-IA-" + DateTime.Now.ToString("ddMMyyyy") + "-" + dsCorr.Tables[0].Rows[0]["Correlativo"].ToString() + "-FTPLA$OVM";
                            ExportToExcel(ds.Tables[0], Directorio, "Hoja1");
                        }

                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IdLinea = string.Empty;
                        IdMoneda_tt = string.Empty;
                        txtIdSocio.Clear();
                        txtIdSocio_Dsc.Clear();
                        txtIdLinea_Dsc.Clear();
                        txtIdMoneda_tt_Dsc.Clear();
                        txtFecha.Clear();
                        txtIdTipoLinea_tt_Dsc.Clear();
                        txtCarpetaXML.Clear();
                        LstDetaLote = new List<DetaLoteBE>();
                        LstEntityFE = new List<FEXMLBE>();
                        dgvFEDetalle.DataSource = LstEntityFE.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al procesar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                dgvFEDetalle.DataSource = LstEntityFE.ToList();
                GridFormating();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridFormating()
        {
            try
            {
                foreach (DataGridViewRow row in dgvFEDetalle.Rows)
                {
                    if (!row.Cells["Mensaje"].Value.ToString().Equals("OK"))
                    {
                        row.Cells["Mensaje"].Style.BackColor = Color.Red;
                        row.Cells["Mensaje"].Style.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFEDetalle_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridFormating();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string srutaArchivo = string.Empty;
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Archivos de Excel (*.xls) |*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                srutaArchivo = openFileDialog1.FileName;

                try
                {
                    msgHelper.Wait("Cargando registros, espere un momento ...");
                    cnExcel = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + srutaArchivo + ";Extended Properties='Excel 12.0 Xml;HDR=YES';");

                    if (cnExcel.State == ConnectionState.Closed)
                    {
                        cnExcel.Open();
                    }

                    if (!System.IO.File.Exists(srutaArchivo))
                    {
                        MessageBox.Show("No se encontró el Libro: " + srutaArchivo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //daExcel = new OleDbDataAdapter("Select N_Cartera, CodClasifCar, NomClasifCar, DireccionClasifCar, " + "CodDeudorCar, '0' & TipoIdentidad as TipoIdentidad, NroIdentidad, APELLIDOSYNOMBRES, DIRECCION, DISTRITO, " + _();
                    //"PROVINCIA, DEPARTAMENTO, CODPOSTAL, TELFDOM, TELFMOV, EmpLaboral, EmpDireccion, " + "EmpDistrito, TelfLab, Sexo, Fch_nacimiento, N_Operacion, Fec_Emis, Cap_Orig, Sal_Cap, " + "InteresMor, InteresComp, Honorarios, Gastos, Pagos, Deuda_Total, IIf (Moneda='S','001',IIf (Moneda='D','002',Moneda)) as Moneda , Fec_Venc, " + 
                    //"Fec_Jud, Conyugue, ANombre, ADireccion, ADistrito, Atelefono, AEmpLaboral, AEmpDireccion, " + "AEmpDistrito, AEmpTelefono, Fecha_Asig, Tipo_Cart, Producto_Orig_Deuda, LoginGA, Oficina " + "From [Data$A1:AV20000] ", cnExcel);

                    OleDbDataAdapter daExcel = new OleDbDataAdapter("Select * " +
                    "From [Carga$A1:Q20000] ", cnExcel);

                    DataTable dtTable = new DataTable();
                    daExcel.Fill(dtTable);

                    //Valida que no se repita el numero de documento en la carga de datos
                    foreach (DataRow row in dtTable.Rows)
                    {
                        if (!string.IsNullOrEmpty(row["RUCPAGADORA"].ToString().Trim()))
                        {
                            string IdDocumento = row["TIPODOCUMENTO"].ToString();
                            string cNumDoc = row["NroDOCUMENTO"].ToString();
                            string RucPagadora = row["RUCPAGADORA"].ToString();

                            //Buscar en el datatable
                            DataRow[] drResult = dtTable.Select("TIPODOCUMENTO = '" + IdDocumento + "' and NroDOCUMENTO = '" + cNumDoc + "' and RUCPAGADORA = '" + RucPagadora + "'");

                            if (drResult.Length > 1)
                            {
                                MessageBox.Show("El documento " + cNumDoc + " de la pagadora " + RucPagadora + " se está duplicando en la importación de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                msgHelper.Wait();
                                return;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    int Contador = 0;
                    foreach (DataRow row in dtTable.Rows)
                    {
                        if (!string.IsNullOrEmpty(row["RUCPAGADORA"].ToString().Trim()))
                        {
                            if (Contador == 0)
                            {
                                if (!ObtenerLinea(row["RUCSOCIO"].ToString(), row["TIPOMONEDA"].ToString()))
                                {
                                    IdLinea = string.Empty;
                                    IdMoneda_tt = string.Empty;
                                    txtIdSocio.Clear();
                                    txtIdSocio_Dsc.Clear();
                                    txtIdLinea_Dsc.Clear();
                                    txtIdMoneda_tt_Dsc.Clear();
                                    txtFecha.Clear();
                                    txtIdTipoLinea_tt_Dsc.Clear();
                                    txtCarpetaXML.Clear();
                                    IdFormaDesembolso = 0;
                                    MessageBox.Show("No se encontro ninguna linea del socio, por favor verifique.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    IsError = true;
                                    return;
                                }
                            }

                            string IdPagadora = string.Empty;
                            string IdPagadora_Dsc = string.Empty;
                            PagadoraBE oEntityPag = new PagadoraBE()
                            {
                                OPCION = 1,
                                vcRuc = row["RUCPAGADORA"].ToString().Trim()
                            };
                            DataSet dsPag = new PagadoraBL().ProcesarPagadora(oEntityPag);

                            if (dsPag.Tables[0].Rows.Count > 0)
                            {
                                IdPagadora = dsPag.Tables[0].Rows[0]["IdPagadora"].ToString();
                                IdPagadora_Dsc = dsPag.Tables[0].Rows[0]["vcPagadora"].ToString();
                            }

                            DocumentoBE oEntityDoc = new DocumentoBE()
                            {
                                OPCION = 4,
                                IdDocumento = row["TIPODOCUMENTO"].ToString()
                            };
                            DataSet dsDoc = new DocumentoBL().ProcesarDocumento(oEntityDoc);

                            string IdDocumento_Dsc = string.Empty;
                            if (dsDoc.Tables[0].Rows.Count > 0)
                            {
                                IdDocumento_Dsc = dsDoc.Tables[0].Rows[0]["cAbreviatura"].ToString();
                            }

                            SocioLineaPagDocBE oEntityPagDoc = new SocioLineaPagDocBE();
                            oEntityPagDoc.OPCION = 1;
                            oEntityPagDoc.IdLinea = IdLinea;
                            oEntityPagDoc.IdPagadora = IdPagadora;
                            oEntityPagDoc.IdDocumento = row["TIPODOCUMENTO"].ToString();
                            DataSet dsPagDoc = new SocioLineaPagDocBL().ProcesarSocioLineaPagDoc(oEntityPagDoc);

                            string IdTipoConfirmacion_Dsc = string.Empty;
                            if (dsPagDoc.Tables[0].Rows.Count > 0)
                            {
                                IdTipoConfirmacion_Dsc = dsPagDoc.Tables[0].Rows[0]["IdTipoConfirmacion_Dsc"].ToString();
                            }

                            FEXMLBE IEntity = new FEXMLBE()
                            {
                                IdPagadora = IdPagadora,
                                IdPagadora_Dsc = IdPagadora_Dsc,
                                RUC = row["RUCPAGADORA"].ToString().Trim(),
                                IdDocumento = row["TIPODOCUMENTO"].ToString(),
                                IdDocumento_Dsc = IdDocumento_Dsc,
                                cNumDoc = row["NroDOCUMENTO"].ToString(),
                                sdVencimiento = Convert.ToDateTime(row["FECHAPAGO"]),
                                nvNominal = Convert.ToDecimal(row["IMPORTENETODEPAGO"]),
                                nvNegociable = Convert.ToDecimal(row["IMPORTENETODEPAGO"]),
                                IdTipoConfirmacion_Dsc = IdTipoConfirmacion_Dsc,
                                IdSocio_BeneficiarioRuc = _IdSocio_BeneficiarioRuc,
                                Mensaje = string.Empty
                            };
                            LstEntityFE.Add(IEntity);
                            Contador++;
                        }
                    }

                    dgvFEDetalle.DataSource = LstEntityFE.ToList();
                    lblnroRegistros.Text = LstEntityFE.Count() + " registro(s)";
                    OrigenLote = 1;
                    cnExcel.Close();
                    //btnImportar.Enabled = false;
                    msgHelper.Wait();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cnExcel.Close();
                    msgHelper.Wait();
                }
            }
        }

        public static void ExportToExcel(DataTable dataTable, string ExcelFilePath = null, string nombreHoja = "")
        {
            try
            {
                //DataTable dataTable = ConvertToDataTable(data);
                int ColumnsCount;

                if (dataTable == null || (ColumnsCount = dataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();

                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;
                Worksheet.Name = nombreHoja;

                //object[,] HeaderFixed = new object[4, 4];
                //HeaderFixed[0, 0] = "Institución"; HeaderFixed[0, 3] = "EFIDE";
                //HeaderFixed[1, 0] = "Estado Financiero"; HeaderFixed[1, 3] = nombreReporte;
                //HeaderFixed[2, 0] = "Año"; HeaderFixed[2, 3] = anio;
                //HeaderFixed[3, 0] = "Mes"; HeaderFixed[3, 3] = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mes);

                //Microsoft.Office.Interop.Excel.Range HeaderRangeFixed = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[4, 4]));
                //HeaderRangeFixed.Value = HeaderFixed;
                //HeaderRangeFixed.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                //HeaderRangeFixed.Cells.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                //HeaderRangeFixed.Font.Bold = true;
                //HeaderRangeFixed.Cells.Font.Name = "Arial";
                //HeaderRangeFixed.Cells.Font.Size = 10;
                //HeaderRangeFixed.Cells.Width = 17;

                object[] Header = new object[ColumnsCount];

                // column headings               
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = dataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                HeaderRange.Font.Bold = true;
                HeaderRange.Cells.Font.Name = "Arial";
                HeaderRange.Cells.Font.Size = 8;
                foreach (Microsoft.Office.Interop.Excel.Range cell in HeaderRange.Cells)
                {
                    cell.BorderAround2();
                }

                // DataCells
                int RowsCount = dataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = dataTable.Rows[j][i].ToString().Trim();

                Microsoft.Office.Interop.Excel.Range BodyRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount]));
                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).NumberFormat = "@";
                BodyRange.Value = Cells;
                //BodyRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //BodyRange.Font.Bold = true;
                BodyRange.Cells.Font.Name = "Arial";
                BodyRange.Cells.Font.Size = 8;

                BodyRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                BodyRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

                //foreach (Microsoft.Office.Interop.Excel.Range cell in BodyRange.Cells)
                //{
                //    cell.BorderAround2();
                //}

                Worksheet.Rows.RowHeight = 13;

                // check fielpath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        //Worksheet.SaveAs(AppSettings.RutaReporteFenacrep + ExcelFilePath);
                        Worksheet.SaveAs(ExcelFilePath);
                        Excel.Quit();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Archivo excel no se ha podido generar, Error: " + ex.Message);
                    }
                }
                else// no filepath is given
                {
                    Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
    }
}