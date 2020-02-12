using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;
using System.Data.SqlClient;
using System.Configuration;
using CrystalDecisions.Shared;
using EfideFactoring.General;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml.XPath;

namespace EfideFactoring.Formula.Registros
{
    public partial class frmMntLoteDato : FormulaBase.frmMntDato
    {
        LoteBL LoteBL = new LoteBL();
        TableBaseBL TableBaseBL = new TableBaseBL();
        SocioLineaBL SocioLineaBL = new SocioLineaBL();
        DetaLoteBL DetaLoteBL = new DetaLoteBL();
        public BindingList<DetaLoteBE> LstDetaLote = new BindingList<DetaLoteBE>();
        public BindingList<DetaLoteBE> LstDetaLoteTmp = new BindingList<DetaLoteBE>();
        public string Fase = "1";
        OleDbConnection cnExcel;
        string _IdSocio_Beneficiario = string.Empty;
        string _IdSocio_BeneficiarioRuc = string.Empty;
        //string ImageDoc = string.Empty;
        int _iCuota = 0;
        decimal _nTotalCuota = 0;

        public frmMntLoteDato()
        {
            InitializeComponent();
        }

        private void frmMntLoteDato_Load(object sender, EventArgs e)
        {
            try
            {
                btnActualizarFechaDesembolso.Visible = false;
                btnBusCtaAhorro.Visible = true;
                LlenarCombos();
                if (Operacion.Equals("N"))
                {
                    /* Evaluar - Llenar datos por defecto si es necesario....*/
                    dtsdDesembolso.Value = Convert.ToDateTime(General.General.gFechaOp);
                }
                else if (Operacion.Equals("M"))
                {
                    btnBusquedaSocio.Enabled = false;
                    btnEditarLote.Enabled = true;
                    cboIdLinea.Enabled = false;
                    txtIdLote.Text = Codigo;
                    CargarDatos();
                    CargarDetalle();
                }

                if (Fase == "0")
                {
                    btnLiquidar.Visible = false;
                    btnImprimirLote.Visible = false;
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
                if (string.IsNullOrEmpty(dtsdDesembolso.Text))
                {
                    MessageBox.Show("Ingresar una fecha de desembolso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string dtDesembolso = dtsdDesembolso.Value.ToString().Substring(0, 10);
                string dtNow = General.General.gFechaOp.ToString().Substring(0, 10);
                
                if (DateTime.Parse(dtDesembolso.ToString()) < DateTime.Parse(dtNow.ToString()))
                {
                    MessageBox.Show("La fecha de desembolso no puede ser menor que el día actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtIdSocio.Text.Trim() ))
                {
                    MessageBox.Show("Se debe ingresar un Socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (cboIdLinea.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar una Linea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (cboIdMoneda_tt.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar una Moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtnImporte.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar un Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Convert.ToDecimal(txtnImporte.Text) == 0)
                {
                    MessageBox.Show("Importe debe ser mayo a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Convert.ToDecimal(cboIdFormaDesembolso_tt.SelectedValue) == 101 && txtNumeroCuenta.Text.Trim() == "")
                {
                    MessageBox.Show("Se debe seleccionar una cuenta de ahorros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                LoteBE LoteBE = new LoteBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdLote = txtIdLote.Text,
                    IdSocio = txtIdSocio.Text,
                    sdDesembolso = dtsdDesembolso.Value,
                    IdLinea = cboIdLinea.SelectedValue.ToString(),
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    nImporte = String.IsNullOrEmpty(txtnImporte.Text.Trim()) ? 0 : Convert.ToDecimal(txtnImporte.Text),
                    sdAprobacion = DateTime.MinValue,
                    nDesembolso = 0,
                    IdOperacion_tt = cboIdOperacion_tt.SelectedValue.ToString(),
                    IdFormaDesembolso = Convert.ToDecimal(cboIdFormaDesembolso_tt.SelectedValue.ToString()),
                    jComunCuentaID = txtNumeroCuenta.Text,
                    jImporteAho = String.IsNullOrEmpty(txtnImporte.Text.Trim()) ? 0 : Convert.ToDecimal(txtnImporte.Text),
                    iCuota = _iCuota,
                    nTotalCuota = _nTotalCuota,
                };

                DataSet dsLote = new DataSet();
                dsLote = LoteBL.ProcesarLote(LoteBE);

                if (dsLote.Tables[0].Rows.Count > 0)
                {
                    /*
                    DetaLoteBE oDetaLoteBE = new DetaLoteBE
                    {
                        USUARIO = General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdLote = dsLote.Tables[0].Rows[0]["IdLote"].ToString(),
                    };
                    DetaLoteBL.ProcesarDetaLote(oDetaLoteBE);   

                    // Agregar el detalle
                    foreach (var DetaLoteBE in LstDetaLote)
                    {
                        DetaLoteBE.USUARIO = General.General.GetCodigoUsuario;
                        DetaLoteBE.OPCION = 2;
                        DetaLoteBE.IdLote = dsLote.Tables[0].Rows[0]["IdLote"].ToString();
                        DetaLoteBL.ProcesarDetaLote(DetaLoteBE);
                    }
                    */


                    //Actualiza el saldo el transito de la linea 
                    LoteBE.OPCION = 11;
                    LoteBL.ProcesarLote(LoteBE);
                }

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos()
        {
            try
            {
                string IdEstado_tt = string.Empty;
                string FlgActualizarFecha = string.Empty;
                DataSet dsLote = new DataSet();
                LoteBE LoteBE = new LoteBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLote = txtIdLote.Text,
                };
                
                dsLote = LoteBL.ProcesarLote(LoteBE);
                
                if (dsLote.Tables[0].Rows.Count > 0)
                {
                    FlgActualizarFecha = dsLote.Tables[0].Rows[0]["FlgActualizarFecha"].ToString();
                    int iNumRenovaciones = int.Parse(dsLote.Tables[0].Rows[0]["iNumRenovaciones"].ToString());

                    if (iNumRenovaciones > 0)
                    {
                        MessageBox.Show("Generado desde renovación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Dispose();
                        return;
                    }
                    
                    if (FlgActualizarFecha.Equals("1"))
                    {
                        btnActualizarFechaDesembolso.Visible = true;
                    }

                    txtIdSocio.Text = dsLote.Tables[0].Rows[0]["IdSocio"].ToString();
                    txtRazonSocialSocio.Text = dsLote.Tables[0].Rows[0]["IdSocio_Dsc"].ToString();
                    dtsdDesembolso.Value = DateTime.Parse(dsLote.Tables[0].Rows[0]["sdDesembolso"].ToString());
                    LlenarLineas();
                    cboIdLinea.SelectedValue = dsLote.Tables[0].Rows[0]["IdLinea"].ToString();
                    cboIdMoneda_tt.SelectedValue = dsLote.Tables[0].Rows[0]["IdMoneda_tt"].ToString();
                    txtnImporte.Text = Convert.ToDecimal(dsLote.Tables[0].Rows[0]["nImporte"]).ToString("N2");
                    cboIdOperacion_tt.SelectedValue = dsLote.Tables[0].Rows[0]["IdOperacion_tt"].ToString();
                    cboIdFormaDesembolso_tt.SelectedValue = dsLote.Tables[0].Rows[0]["IdFormaDesembolso"].ToString();
                    IdEstado_tt = dsLote.Tables[0].Rows[0]["IdEstado_tt"].ToString();
                    _iCuota = string.IsNullOrEmpty(dsLote.Tables[0].Rows[0]["iCuota"].ToString()) ? 0 : Convert.ToInt32(dsLote.Tables[0].Rows[0]["iCuota"]);
                    _nTotalCuota = string.IsNullOrEmpty(dsLote.Tables[0].Rows[0]["nTotalCuota"].ToString()) ? 0 : Convert.ToDecimal(dsLote.Tables[0].Rows[0]["nTotalCuota"]);
                    if (IdEstado_tt == "00077" || IdEstado_tt == "00088" || IdEstado_tt == "00078" || IdEstado_tt == "00059" || IdEstado_tt == "00091") { btnLiquidar.Enabled = false; btnAceptar.Enabled = false; btnAgregar.Enabled = false; btnImportar.Enabled = false; btnEditarLote.Enabled = false; btnEliminar.Enabled = false; } // Aprobado, Desembolsado, Anulado, Por Aprobar, Cobrado
                    //if (IdEstado_tt == "00058") { btnImprimirLote.Enabled = false; }
                }
                else
                {
                    MessageBox.Show("Este .... no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCombos()
        {
            try
            {
                String Table_Id = "00079"; //Solicitud Operación
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdOperacion_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtnImporte.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtIdLote.Text))
                {
                    if (!ValidarLote()) { return; }  
                }  

                frmMntLoteDetDato ofrmMntLoteDetDato = new frmMntLoteDetDato();
                ofrmMntLoteDetDato.Operacion = "N";
                ofrmMntLoteDetDato.Codigo = txtIdLote.Text.Trim();
                ofrmMntLoteDetDato.IdSocio = txtIdSocio.Text.Trim();
                ofrmMntLoteDetDato.IdLinea = cboIdLinea.SelectedValue.ToString();
                ofrmMntLoteDetDato.ShowDialog();
                _iCuota = ofrmMntLoteDetDato.iCuota;
                _nTotalCuota = ofrmMntLoteDetDato.nTotalCuota;

                do
                {
                    if (ofrmMntLoteDetDato.LstDetalle.Count > 0)
                    {
                        if(string.IsNullOrEmpty(txtIdLote.Text))
                        {
                            if (!GuardarLote()) { MessageBox.Show("No se pudo guargar el lote, verifique la información.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                        }
  
                        foreach (var item in LstDetaLote)
                        {
                            if (item.IdPagadora == ofrmMntLoteDetDato.LstDetalle[0].IdPagadora && item.IdDocumento == ofrmMntLoteDetDato.LstDetalle[0].IdDocumento && item.cNumDoc == ofrmMntLoteDetDato.LstDetalle[0].cNumDoc)
                            {
                                MessageBox.Show("El número de documento ya existe, ingrese otro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }

                        if (ofrmMntLoteDetDato.iCuota > 1)
                        {
                            //Con cuotas add 20190620
                            foreach (var item in ofrmMntLoteDetDato.LstDetalle)
                            {
                                item.USUARIO = General.General.GetCodigoUsuario;
                                item.OPCION = 2;
                                item.IdLote = txtIdLote.Text;
                                DataSet ds = DetaLoteBL.ProcesarDetaLote(item);

                                item.cItem = ds.Tables[0].Rows[0]["cItem"].ToString();

                                if (item.ImageDoc != null)
                                {
                                    string Filename = txtIdLote.Text.Trim() + item.cItem.Trim() + item.IdImageDoc;
                                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//" + txtIdLote.Text.Trim() + "//";
                                    if (!Directory.Exists(filepath))
                                        System.IO.Directory.CreateDirectory(filepath);

                                    var fs = new BinaryWriter(new FileStream(filepath + Filename, FileMode.Append, FileAccess.Write));
                                    fs.Write(item.ImageDoc);
                                    fs.Close();
                                    item.IdImageDoc = txtIdLote.Text.Trim() + "/" + Filename;

                                    DetaLoteBE DetaLoteBEImage = new DetaLoteBE();
                                    DetaLoteBEImage.USUARIO = General.General.GetCodigoUsuario;
                                    DetaLoteBEImage.OPCION = 10;
                                    DetaLoteBEImage.IdLote = txtIdLote.Text.Trim();
                                    DetaLoteBEImage.cItem = item.cItem;
                                    DetaLoteBEImage.IdImageDoc = txtIdLote.Text.Trim() + "/" + Filename;
                                    DetaLoteBL.ProcesarDetaLote(DetaLoteBEImage);
                                }

                                LstDetaLote.Add(item);
                            }

                            dgvDetalleLote.DataSource = LstDetaLote;
                            dgvDetalleLote.Refresh();   
                            Totalizar();
                            ofrmMntLoteDetDato.ShowDialog();
                        }
                        else 
                        {
                            //Sin cuotas
                            ofrmMntLoteDetDato.LstDetalle[0].USUARIO = General.General.GetCodigoUsuario;
                            ofrmMntLoteDetDato.LstDetalle[0].OPCION = 2;
                            ofrmMntLoteDetDato.LstDetalle[0].IdLote = txtIdLote.Text;
                            DataSet ds = DetaLoteBL.ProcesarDetaLote(ofrmMntLoteDetDato.LstDetalle[0]);

                            ofrmMntLoteDetDato.LstDetalle[0].cItem = ds.Tables[0].Rows[0]["cItem"].ToString();

                            if (ofrmMntLoteDetDato.LstDetalle[0].ImageDoc != null)
                            {
                                string Filename = txtIdLote.Text.Trim() + ofrmMntLoteDetDato.LstDetalle[0].cItem.Trim() + ofrmMntLoteDetDato.LstDetalle[0].IdImageDoc;
                                string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//" + txtIdLote.Text.Trim() + "//";
                                if (!Directory.Exists(filepath))
                                    System.IO.Directory.CreateDirectory(filepath);

                                var fs = new BinaryWriter(new FileStream(filepath + Filename, FileMode.Append, FileAccess.Write));
                                fs.Write(ofrmMntLoteDetDato.LstDetalle[0].ImageDoc);
                                fs.Close();
                                ofrmMntLoteDetDato.LstDetalle[0].IdImageDoc = txtIdLote.Text.Trim() + "/" + Filename;

                                DetaLoteBE DetaLoteBEImage = new DetaLoteBE();
                                DetaLoteBEImage.USUARIO = General.General.GetCodigoUsuario;
                                DetaLoteBEImage.OPCION = 10;
                                DetaLoteBEImage.IdLote = txtIdLote.Text.Trim();
                                DetaLoteBEImage.cItem = ofrmMntLoteDetDato.LstDetalle[0].cItem;
                                DetaLoteBEImage.IdImageDoc = txtIdLote.Text.Trim() + "/" + Filename;
                                DetaLoteBL.ProcesarDetaLote(DetaLoteBEImage);
                            }

                            LstDetaLote.Add(ofrmMntLoteDetDato.LstDetalle[0]);
                            dgvDetalleLote.DataSource = LstDetaLote;
                            dgvDetalleLote.Refresh();
                            Totalizar();
                            ofrmMntLoteDetDato.ShowDialog();
                        }
                    }
                } while (ofrmMntLoteDetDato.DialogResult == DialogResult.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusquedaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio.ShowDialog();
                txtIdSocio.Text = ofrmBusquedaSocio.CodSocio.Trim();
                txtRucSocio.Text = ofrmBusquedaSocio.RUCSocio.Trim();
                txtRazonSocialSocio.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
                LlenarLineas();
                CargarGiradorOriginal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarLineas()
        {
            SocioLineaBE SocioLineaBE = new SocioLineaBE()
            {
                OPCION = 4,
                USUARIO = General.General.GetUsuario,
                IdSocio = txtIdSocio.Text.Trim()
            };

            General.General.LlenarCombobox(cboIdLinea, "Descripcion", "IdLinea", SocioLineaBL.ProcesarSocioLinea(SocioLineaBE).Tables[0]); 
        }

        private void CargarGiradorOriginal()
        {
            try
            {
                TercerCasoSocioBE oEntity = new TercerCasoSocioBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
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

        private void cboIdLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboIdLinea.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    btnAgregar.Enabled = true;
                    btnImportar.Enabled = true;

                    String Table_Id = "00035"; //Moneda
                    TableBaseBE TableBaseBE = new TableBaseBE()
                    {
                        OPCION = 1,
                        USUARIO = General.General.GetCodigoUsuario,
                        Table_Parent_Id = Table_Id
                    };

                    cboIdMoneda_tt.DataSource = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                    cboIdMoneda_tt.DisplayMember = "Table_Name";
                    cboIdMoneda_tt.ValueMember = "Table_Id";

                    SocioLineaBE SocioLineaBE = new SocioLineaBE()
                    {
                        OPCION = 5,
                        USUARIO = General.General.GetUsuario,
                        IdLinea = cboIdLinea.SelectedValue.ToString(),
                        IdSocio = txtIdSocio.Text.Trim()
                    };

                    DataSet ds = SocioLineaBL.ProcesarSocioLinea(SocioLineaBE);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        cboIdMoneda_tt.SelectedValue = ds.Tables[0].Rows[0]["IdMoneda_tt"].ToString();
                        txtTipoLinea.Text = ds.Tables[0].Rows[0]["IdTipoLinea_tt_Dsc"].ToString();
                        txtLineaCredito.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"].ToString()).ToString("N2");
                        txtLineaUtilizada.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["nUtilizado"].ToString()).ToString("N2");
                        txtDesembolso.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["nTransito"].ToString()).ToString("N2"); ;
                        txtSaldoDisponible.Text = (Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"].ToString()) - Convert.ToDecimal(ds.Tables[0].Rows[0]["nUtilizado"].ToString()) - Convert.ToDecimal(txtDesembolso.Text)).ToString("N2");
                    }
                    else
                    {
                        cboIdMoneda_tt.DataSource = null;
                        txtTipoLinea.Clear();
                        txtLineaCredito.Clear();
                        txtLineaUtilizada.Clear();
                        txtDesembolso.Clear();
                        txtSaldoDisponible.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDetalle()
        {
            try
            {
                LstDetaLote = new BindingList<DetaLoteBE>();
                DataSet dsDetaLote = new DataSet();
                DetaLoteBE DetaLoteBE = new DetaLoteBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLote = txtIdLote.Text.Trim(),
                };

                DataSet ds = new DataSet();
                ds = DetaLoteBL.ProcesarDetaLote(DetaLoteBE);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DetaLoteBE oDetaLoteBE = new DetaLoteBE();
                        oDetaLoteBE.IdLote = txtIdLote.Text.Trim();
                        oDetaLoteBE.cItem = ds.Tables[0].Rows[i]["cItem"].ToString();
                        oDetaLoteBE.IdPagadora = ds.Tables[0].Rows[i]["IdPagadora"].ToString();
                        oDetaLoteBE.IdPagadora_Dsc = ds.Tables[0].Rows[i]["IdPagadora_Dsc"].ToString();
                        oDetaLoteBE.IdDocumento = ds.Tables[0].Rows[i]["IdDocumento"].ToString();
                        oDetaLoteBE.cNumDoc = ds.Tables[0].Rows[i]["cNumDoc"].ToString();
                        oDetaLoteBE.vDocumento = ds.Tables[0].Rows[i]["vDocumento"].ToString();
                        oDetaLoteBE.IdSocio_Beneficiario = ds.Tables[0].Rows[i]["IdSocio_Beneficiario"].ToString();
                        oDetaLoteBE.IdSocio_BeneficiarioRuc = ds.Tables[0].Rows[i]["IdSocio_BeneficiarioRuc"].ToString();
                        oDetaLoteBE.sdRecepcion = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["sdRecepcion"].ToString()) ? DateTime.Parse(ds.Tables[0].Rows[i]["sdRecepcion"].ToString()) : DateTime.MinValue;
                        oDetaLoteBE.iPlazo =  !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["iPlazo"].ToString()) ? int.Parse(ds.Tables[0].Rows[i]["iPlazo"].ToString()) : 0;
                        oDetaLoteBE.sdVencimiento =  !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["sdVencimiento"].ToString()) ? DateTime.Parse(ds.Tables[0].Rows[i]["sdVencimiento"].ToString()) : DateTime.MinValue;
                        oDetaLoteBE.nvNominal =  !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["sdRecepcion"].ToString()) ? Decimal.Parse(ds.Tables[0].Rows[i]["nvNominal"].ToString()): 0;
                        oDetaLoteBE.cNotaCredito =  ds.Tables[0].Rows[i]["cNotaCredito"].ToString();
                        oDetaLoteBE.nNotaCredito = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["nNotaCredito"].ToString()) ? Decimal.Parse(ds.Tables[0].Rows[i]["nNotaCredito"].ToString()) : 0;
                        oDetaLoteBE.nPorRetencion = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["nPorRetencion"].ToString()) ? Decimal.Parse(ds.Tables[0].Rows[i]["nPorRetencion"].ToString()) : 0;
                        oDetaLoteBE.nvRetencion = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["nvRetencion"].ToString()) ? Decimal.Parse(ds.Tables[0].Rows[i]["nvRetencion"].ToString()) : 0;
                        oDetaLoteBE.Descuento = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["Descuento"].ToString()) ? Decimal.Parse(ds.Tables[0].Rows[i]["Descuento"].ToString()) : 0;
                        oDetaLoteBE.nvNegociable = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["nvNegociable"].ToString()) ? Decimal.Parse(ds.Tables[0].Rows[i]["nvNegociable"].ToString()) : 0;
                        oDetaLoteBE.bNoRequiereProtesto = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["bNoRequiereProtesto"].ToString()) ? bool.Parse(ds.Tables[0].Rows[i]["bNoRequiereProtesto"].ToString()) : false;
                        LstDetaLote.Add(oDetaLoteBE);
                    }
                }

                dgvDetalleLote.DataSource = LstDetaLote;
                Totalizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleLote.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Está Ud. seguro de eliminar la Pagadora " + dgvDetalleLote.CurrentRow.Cells["IdPagadora_Dsc"].Value.ToString().Trim() + " - " + dgvDetalleLote.CurrentRow.Cells["vDocumento"].Value.ToString().Trim() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int index = dgvDetalleLote.CurrentRow.Index;
                    DetaLoteBE DetaLoteBE = new DetaLoteBE();
                    DetaLoteBE.USUARIO = General.General.GetCodigoUsuario;
                    DetaLoteBE.OPCION = 3;
                    DetaLoteBE.IdLote = txtIdLote.Text.Trim();
                    DetaLoteBE.cItem = dgvDetalleLote.CurrentRow.Cells["cItem"].Value.ToString().Trim();
                    DetaLoteBL.ProcesarDetaLote(DetaLoteBE);

                    LstDetaLote.RemoveAt(index);
                    dgvDetalleLote.DataSource = LstDetaLote;

                    Totalizar();
                }
            }
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(dtsdDesembolso.Text))
                {
                    MessageBox.Show("Ingresar una fecha de desembolso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string dtDesembolso = dtsdDesembolso.Value.ToString().Substring(0, 10);
                string dtNow = General.General.gFechaOp.ToString().Substring(0, 10);


                if (DateTime.Parse(dtDesembolso.ToString()) < DateTime.Parse(dtNow.ToString()))
                {
                    MessageBox.Show("La fecha de desembolso no puede ser menor que el día actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtIdSocio.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar un Socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (cboIdLinea.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar una Linea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (cboIdMoneda_tt.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar una Moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (cboIdFormaDesembolso_tt.SelectedValue.ToString().Equals("0") || cboIdFormaDesembolso_tt.SelectedIndex == -1)
                {
                    cboIdFormaDesembolso_tt.Focus();
                    MessageBox.Show("Debe seleccionar una forma de Desembolso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (cboIdOperacion_tt.SelectedValue.ToString().Equals("") || cboIdOperacion_tt.SelectedIndex == -1)
                {
                    cboIdOperacion_tt.Focus();
                    MessageBox.Show("Debe seleccionar la fuente de la solicitud de la operación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtnImporte.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar un Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //if (Convert.ToDecimal(txtnImporte.Text) == 0)
                //{
                //    MessageBox.Show("Importe debe ser mayo a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                 if (Convert.ToDecimal(cboIdFormaDesembolso_tt.SelectedValue) == 101 && txtNumeroCuenta.Text.Trim() == "")
                {
                    MessageBox.Show("Se debe seleccionar una cuenta de ahorros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                Decimal AcVnominal = 0;
                foreach (var item in LstDetaLote)
                {
                    AcVnominal += item.nvNominal;
                }

                if (AcVnominal != Convert.ToDecimal(txtnImporte.Text))
                {
                    MessageBox.Show("El Importe debe ser igual al total del valor Nominal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (GuardarCambios())
                {
                    btnBusquedaSocio.Enabled = false;
                    btnEditarLote.Enabled = true;
                    cboIdLinea.Enabled = false;
                    frmMntLiquidacionLinea ofrmMntLiquidacionLinea = new frmMntLiquidacionLinea();
                    ofrmMntLiquidacionLinea._IdLote = txtIdLote.Text;
                    ofrmMntLiquidacionLinea._IdSocio = txtIdSocio.Text;
                    ofrmMntLiquidacionLinea._IdSocio_Dsc = txtRazonSocialSocio.Text;
                    ofrmMntLiquidacionLinea._Table_IdMoneda = cboIdMoneda_tt.SelectedValue.ToString();
                    ofrmMntLiquidacionLinea._Table_IdMonedaDsc = cboIdMoneda_tt.Text;
                    ofrmMntLiquidacionLinea.ShowDialog();
                    if (ofrmMntLiquidacionLinea._IdEstado_tt == "00059") { btnLiquidar.Enabled = false; btnAceptar.Enabled = false; btnAgregar.Enabled = false; btnEditarLote.Enabled = false; btnEliminar.Enabled = false; } //Enviado a Aprobación
                };

                String strIdLote = txtIdLote.Text.Trim();
                DataSet dsLotes = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("Rpt_Lote_Cab", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@IdLote", strIdLote);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsLotes, "Rpt_Lote_Cab");

                    SqlCommand cmd2 = new SqlCommand("Rpt_Lote_Det", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@IdLote", strIdLote);
                    SqlDataAdapter daDet = new SqlDataAdapter(cmd2);
                    daDet.Fill(dsLotes, "Rpt_Lote_Det");

                    con.Close();
                }

                Crystal.crRegLiquidacion ocrLoteLiquidacion = new Crystal.crRegLiquidacion();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsLotes);
                ocrLoteLiquidacion.SetParameterValue("usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("moneda", dsLotes.Tables[0].Rows[0]["IdMoneda_Dsc"].ToString());
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarLote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dgvDetalleLote.CurrentRow.Cells["cItem"].Value.ToString()))
            {
                MessageBox.Show("Este item no se puede editar porque aun no a sido grabado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int index = dgvDetalleLote.CurrentRow.Index;
            frmMntLoteDetDato ofrmMntLoteDetDato = new frmMntLoteDetDato();
            ofrmMntLoteDetDato.Operacion = "M";
            ofrmMntLoteDetDato.Codigo = txtIdLote.Text.Trim();
            ofrmMntLoteDetDato.IdSocio = txtIdSocio.Text.Trim();
            ofrmMntLoteDetDato.IdLinea = cboIdLinea.SelectedValue.ToString();
            ofrmMntLoteDetDato.cItem = dgvDetalleLote.CurrentRow.Cells["cItem"].Value.ToString();
            ofrmMntLoteDetDato.iCuota = _iCuota;
            ofrmMntLoteDetDato.nTotalCuota = _nTotalCuota;
            ofrmMntLoteDetDato.ShowDialog();

            if (ofrmMntLoteDetDato.IsChange.Equals("1"))
            {
                LstDetaLote.RemoveAt(index);
                LstDetaLote.Add(ofrmMntLoteDetDato.LstDetalle[0]);
                dgvDetalleLote.DataSource = LstDetaLote;
                dgvDetalleLote.Refresh();

                // Guardando cambios
                if (ofrmMntLoteDetDato.LstDetalle[0].ImageDoc != null)
                {
                    string Filename = txtIdLote.Text.Trim() + ofrmMntLoteDetDato.LstDetalle[0].cItem.Trim() + ofrmMntLoteDetDato.LstDetalle[0].IdImageDoc;
                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//" + txtIdLote.Text.Trim() + "//";
                    if (!Directory.Exists(filepath))
                        System.IO.Directory.CreateDirectory(filepath);

                    var fs = new BinaryWriter(new FileStream(filepath + Filename, FileMode.Append, FileAccess.Write));
                    fs.Write(ofrmMntLoteDetDato.LstDetalle[0].ImageDoc);
                    fs.Close();
                    ofrmMntLoteDetDato.LstDetalle[0].IdImageDoc = txtIdLote.Text.Trim() + "/" + Filename; 
                }

                ofrmMntLoteDetDato.LstDetalle[0].USUARIO = General.General.GetCodigoUsuario;
                ofrmMntLoteDetDato.LstDetalle[0].OPCION = 2;
                ofrmMntLoteDetDato.LstDetalle[0].IdLote = txtIdLote.Text.Trim();
                DetaLoteBL.ProcesarDetaLote(ofrmMntLoteDetDato.LstDetalle[0]);
                Totalizar();
            }
        }

        private bool GuardarCambios(bool MsgSucces = true)
        {
            try
            {
                LoteBE LoteBE = new LoteBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdLote = txtIdLote.Text,
                    IdSocio = txtIdSocio.Text,
                    sdDesembolso = dtsdDesembolso.Value,
                    IdLinea = cboIdLinea.SelectedValue.ToString(),
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    nImporte = String.IsNullOrEmpty(txtnImporte.Text.Trim()) ? 0 : Convert.ToDecimal(txtnImporte.Text),
                    sdAprobacion = DateTime.MinValue,
                    nDesembolso = 0,
                    IdOperacion_tt = cboIdOperacion_tt.SelectedValue.ToString(),
                    IdFormaDesembolso = Convert.ToDecimal(cboIdFormaDesembolso_tt.SelectedValue.ToString()),
                    jComunCuentaID = txtNumeroCuenta.Text,
                    jImporteAho = String.IsNullOrEmpty(txtnImporte.Text.Trim()) ? 0 : Convert.ToDecimal(txtnImporte.Text)
            
                };

                DataSet dsLote = new DataSet();
                dsLote = LoteBL.ProcesarLote(LoteBE);

                if (dsLote.Tables[0].Rows.Count > 0)
                {
                    txtIdLote.Text = dsLote.Tables[0].Rows[0]["IdLote"].ToString();

                    DetaLoteBE oDetaLoteBE = new DetaLoteBE
                    {
                        USUARIO = General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdLote = dsLote.Tables[0].Rows[0]["IdLote"].ToString(),
                    };
                    DetaLoteBL.ProcesarDetaLote(oDetaLoteBE);

                    // Agregar el detalle
                    foreach (var DetaLoteBE in LstDetaLote)
                    {
                        DetaLoteBE.USUARIO = General.General.GetCodigoUsuario;
                        DetaLoteBE.OPCION = 2;
                        DetaLoteBE.IdLote = dsLote.Tables[0].Rows[0]["IdLote"].ToString();
                        DetaLoteBL.ProcesarDetaLote(DetaLoteBE);
                    }
                    LoteBE.USUARIO = General.General.GetCodigoUsuario;
                    LoteBE.OPCION = 11;
                    LoteBE.IdLote = txtIdLote.Text;
                    LoteBL.ProcesarLote(LoteBE);
                }

                if (MsgSucces)
                {
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        private bool ValidarLote()
        {
            try
            {
                if (string.IsNullOrEmpty(dtsdDesembolso.Text))
                {
                    MessageBox.Show("Ingresar una fecha de desembolso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                string dtDesembolso = dtsdDesembolso.Value.ToString().Substring(0, 10);
                string dtNow = General.General.gFechaOp.ToString().Substring(0, 10);

                if (DateTime.Parse(dtDesembolso.ToString()) < DateTime.Parse(dtNow.ToString()))
                {
                    MessageBox.Show("La fecha de desembolso no puede ser menor que el día actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (string.IsNullOrEmpty(txtIdSocio.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar un Socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cboIdLinea.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar una Linea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cboIdMoneda_tt.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar una Moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (string.IsNullOrEmpty(txtnImporte.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar un Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (Convert.ToDecimal(txtnImporte.Text) == 0)
                {
                    MessageBox.Show("Importe debe ser mayo a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        private bool GuardarLote()
        {
            try
            {
                LoteBE LoteBE = new LoteBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdLote = txtIdLote.Text,
                    IdSocio = txtIdSocio.Text,
                    sdDesembolso = dtsdDesembolso.Value,
                    IdLinea = cboIdLinea.SelectedValue.ToString(),
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    nImporte = String.IsNullOrEmpty(txtnImporte.Text.Trim()) ? 0 : Convert.ToDecimal(txtnImporte.Text),
                    sdAprobacion = DateTime.MinValue,
                    nDesembolso = 0,
                    IdOperacion_tt = cboIdOperacion_tt.SelectedValue.ToString(),
                    IdFormaDesembolso = Convert.ToDecimal(cboIdFormaDesembolso_tt.SelectedValue.ToString()),
                    iCuota = _iCuota,
                    nTotalCuota = _nTotalCuota
                };

                DataSet dsLote = new DataSet();
                dsLote = LoteBL.ProcesarLote(LoteBE);

                if (dsLote.Tables[0].Rows.Count > 0)
                {
                    txtIdLote.Text = dsLote.Tables[0].Rows[0]["IdLote"].ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        private void Totalizar()
        {
            Decimal AcVnominal = 0;
            Decimal Importe = string.IsNullOrEmpty(txtnImporte.Text) ? 0 : Convert.ToDecimal(txtnImporte.Text);
            foreach (var item in LstDetaLote)
            {
                AcVnominal += item.nvNominal;
            }
            txtTotalIngresado.Text = AcVnominal.ToString("N2");
            txtDiferencia.Text = (Importe - AcVnominal).ToString("N2");
        }

        private void ObtenerEjecutivo()
        {
            try
            {
                SocioBE oEntity = new SocioBE();
                oEntity.OPCION = 10;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.CodSocio = txtIdSocio.Text.Trim();
                DataSet ds = new SocioBL().ProcesarSocio(oEntity);

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lblEjecutivo.Text = "Ejecutivo: " + ds.Tables[0].Rows[0]["NombreEjecutivo"].ToString().Trim();
                    }
                    else
                    {
                        lblEjecutivo.Text = "Ejecutivo: No Configurado";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnImporte_TextChanged(object sender, EventArgs e)
        {
            Totalizar();
        }

        private void txtIdSocio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int CountItem = 0;
                string varCodigo = string.Empty;
                LoteBE LoteBE = new LoteBE()
                {
                    OPCION = 7,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdSocio = txtIdSocio.Text.Trim()
                };
                DataTable dt = LoteBL.ProcesarLote(LoteBE).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    CountItem = 1;
                    varCodigo = dt.Rows[0]["varCodigo"].ToString();
                }

                DataRow dr;
                dr = dt.NewRow();
                dr["varDescripcion"] = "--Seleccionar--";
                dr["varCodigo"] = 0;
                dt.Rows.InsertAt(dr, 0);

                cboIdFormaDesembolso_tt.DataSource = dt;
                cboIdFormaDesembolso_tt.DisplayMember = "varDescripcion";
                cboIdFormaDesembolso_tt.ValueMember = "varCodigo";

                if (CountItem > 0)
                {
                    cboIdFormaDesembolso_tt.SelectedValue = varCodigo;
                }

                ObtenerEjecutivo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdFormaDesembolso_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIdFormaDesembolso_tt.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                txtBanco.Visible = false;
                txtNumeroCuenta.Visible = false;
                btnBusCtaAhorro.Visible = false;
                if (Convert.ToDecimal(cboIdFormaDesembolso_tt.SelectedValue.ToString()) == 1 && cboIdMoneda_tt.SelectedValue != null) // MODIFICADO 1
                {
                    LoteBE LoteBE = new LoteBE()
                    {
                        OPCION = 8,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdSocio = txtIdSocio.Text.Trim(),
                        IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString()
                    };
                    DataSet ds = LoteBL.ProcesarLote(LoteBE);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtBanco.Text = ds.Tables[0].Rows[0]["ent_emprRazonSocial"].ToString();
                        txtNumeroCuenta.Text = ds.Tables[0].Rows[0]["ctasBanNumCta"].ToString();
                        txtBanco.Visible = true;
                        txtNumeroCuenta.Visible = true;
                    }
                    btnBusCtaAhorro.Visible = false;
                }
                else if (Convert.ToDecimal(cboIdFormaDesembolso_tt.SelectedValue.ToString()) == 101 && cboIdMoneda_tt.SelectedValue != null) // MODIFICADO 1
                {
                    btnBusCtaAhorro.Visible = true;
                    txtBanco.Visible = true;
                    txtNumeroCuenta.Visible = true;
                }
            }
        }

        private void btnImprimirLote_Click(object sender, EventArgs e)
        {
            try
            {
                String strIdLote = txtIdLote.Text.Trim();
                if (string.IsNullOrEmpty(strIdLote))
                {
                    if (string.IsNullOrEmpty(dtsdDesembolso.Text))
                    {
                        MessageBox.Show("Ingresar una fecha de desembolso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    string dtDesembolso = dtsdDesembolso.Value.ToString().Substring(0, 10);
                    string dtNow = General.General.gFechaOp.ToString().Substring(0, 10);


                    if (DateTime.Parse(dtDesembolso.ToString()) < DateTime.Parse(dtNow.ToString()))
                    {
                        MessageBox.Show("La fecha de desembolso no puede ser menor que el día actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (string.IsNullOrEmpty(txtIdSocio.Text.Trim()))
                    {
                        MessageBox.Show("Se debe ingresar un Socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (cboIdLinea.SelectedIndex == -1)
                    {
                        MessageBox.Show("Se debe seleccionar una Linea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (cboIdMoneda_tt.SelectedIndex == -1)
                    {
                        MessageBox.Show("Se debe seleccionar una Moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (cboIdFormaDesembolso_tt.SelectedValue.ToString().Equals("0") || cboIdFormaDesembolso_tt.SelectedIndex == -1)
                    {
                        cboIdFormaDesembolso_tt.Focus();
                        MessageBox.Show("Debe seleccionar una forma de Desembolso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (cboIdOperacion_tt.SelectedValue.ToString().Equals("") || cboIdOperacion_tt.SelectedIndex == -1)
                    {
                        cboIdOperacion_tt.Focus();
                        MessageBox.Show("Debe seleccionar la fuente de la solicitud de la operación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (string.IsNullOrEmpty(txtnImporte.Text.Trim()))
                    {
                        MessageBox.Show("Se debe ingresar un Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (Convert.ToDecimal(txtnImporte.Text) == 0)
                    {
                        MessageBox.Show("Importe debe ser mayo a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Decimal AcVnominal = 0;
                    foreach (var item in LstDetaLote)
                    {
                        AcVnominal += item.nvNominal;
                    }

                    if (AcVnominal != Convert.ToDecimal(txtnImporte.Text))
                    {
                        MessageBox.Show("El Importe debe ser igual al total del valor Nominal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (!GuardarCambios())
                    {
                        MessageBox.Show("Verefique los datos, no se pudo guardar el lote correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    strIdLote = txtIdLote.Text.Trim();
                }

                DataSet dsLotes = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("Rpt_Lote_Cab", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@IdLote", strIdLote);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsLotes, "Rpt_Lote_Cab");

                    SqlCommand cmd2 = new SqlCommand("Rpt_Lote_Det", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@IdLote", strIdLote);
                    SqlDataAdapter daDet = new SqlDataAdapter(cmd2);
                    daDet.Fill(dsLotes, "Rpt_Lote_Det");

                    con.Close();
                }

                Crystal.crRegLiquidacion ocrLoteLiquidacion = new Crystal.crRegLiquidacion();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsLotes);
                ocrLoteLiquidacion.SetParameterValue("usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("moneda", dsLotes.Tables[0].Rows[0]["IdMoneda_Dsc"].ToString());
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdLote.Text))
            {
                if (!ValidarLote()) { return; }
            } 
            string srutaArchivo = string.Empty;
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Archivos de Excel (*.xls) |*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            LstDetaLoteTmp = new BindingList<DetaLoteBE>();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK ){
                srutaArchivo = openFileDialog1.FileName;

                try {
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

                    //Validar los datos
                    bool IsCorrecto = true;
                    foreach (DataRow row in dtTable.Rows)
                    {
                        if (!string.IsNullOrEmpty(row["RUCPAGADORA"].ToString().Trim()))
                        {
                            ImportacionLoteBE oEntity = new ImportacionLoteBE()
                            {
                                RucPagadora = row["RUCPAGADORA"].ToString(),
                                IdSocio = txtIdSocio.Text.Trim(),
                                IdLinea = cboIdLinea.SelectedValue.ToString(),
                                IdDocumento = row["TIPODOCUMENTO"].ToString(),
                                IdMoneda_tt = row["TIPOMONEDA"].ToString(),
                                cNumDoc = row["NroDOCUMENTO"].ToString(),
                                RucGiradorOriginal = row["RUCGIRADORORIGINAL"].ToString(),
                            };
                            DataSet ds = new DataSet();
                            //Valida que no exista el numero de documento en la base de datos
                            ds = new ImportacionLoteBL().ProcesarImportacionLote(oEntity);
                            if (!ds.Tables[0].Rows[0]["Result"].Equals("OK"))
                            {
                                IsCorrecto = false;
                                MessageBox.Show("No se pudieron subir los lotes :" + ds.Tables[0].Rows[0]["MsgResult"].ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            else
                            {
                                // Si es correcto agregamos el lote al temporal
                                TimeSpan ts = Convert.ToDateTime(row["FECHAPAGO"].ToString()) - Convert.ToDateTime(row["FECHAEMISION"].ToString());
                                DetaLoteBE oEntityDetLote = new DetaLoteBE();
                                oEntityDetLote.IdLote = txtIdLote.Text;
                                oEntityDetLote.cItem = "";
                                oEntityDetLote.IdPagadora = ds.Tables[0].Rows[0]["IdPagadora"].ToString();
                                oEntityDetLote.IdPagadora_Dsc = ds.Tables[0].Rows[0]["IdPagadora_Dsc"].ToString();
                                oEntityDetLote.vDocumento = row["DOCUMENTO"].ToString() + " - " + row["NroDOCUMENTO"].ToString();
                                oEntityDetLote.IdDocumento = row["TIPODOCUMENTO"].ToString();
                                oEntityDetLote.cNumDoc = row["NroDOCUMENTO"].ToString();
                                oEntityDetLote.sdRecepcion = General.General.gFechaOp;
                                oEntityDetLote.iPlazo = ts.Days;
                                oEntityDetLote.sdVencimiento = Convert.ToDateTime(row["FECHAPAGO"].ToString());
                                
                                //Comentado por nuevo cambio de plantilla 20180918
                                //oEntityDetLote.nvNominal = String.IsNullOrEmpty(row["VALORNOMINAL"].ToString()) ? 0 : Convert.ToDecimal(row["VALORNOMINAL"].ToString());
                                oEntityDetLote.nvNominal = String.IsNullOrEmpty(row["IMPORTENETODEPAGO"].ToString()) ? 0 : Convert.ToDecimal(row["IMPORTENETODEPAGO"].ToString());

                                oEntityDetLote.cNotaCredito = string.Empty;
                                oEntityDetLote.nNotaCredito = 0;
                                oEntityDetLote.nPorRetencion = 0;
                                oEntityDetLote.nvRetencion = 0;
                                oEntityDetLote.Descuento = 0;

                                /* Comentado por nuevo cambio de plantilla 20180918
                                oEntityDetLote.cNotaCredito = row["NroNCREDITO"].ToString();
                                oEntityDetLote.nNotaCredito = String.IsNullOrEmpty(row["MONTONCREDITO"].ToString()) ? 0 : Convert.ToDecimal(row["MONTONCREDITO"].ToString());
                                oEntityDetLote.nPorRetencion = String.IsNullOrEmpty(row["RETENCION"].ToString()) ? 0 : Convert.ToDecimal(row["RETENCION"].ToString());
                                oEntityDetLote.nvRetencion = String.IsNullOrEmpty(row["MONTORETENCION"].ToString()) ? 0 : Convert.ToDecimal(row["MONTORETENCION"].ToString());
                                oEntityDetLote.Descuento = String.IsNullOrEmpty(row["DESCUENTO"].ToString()) ? 0 : Convert.ToDecimal(row["DESCUENTO"].ToString());
                                 */
                                oEntityDetLote.dtRenovacion = DateTime.MinValue;

                                if (string.IsNullOrEmpty(row["RUCGIRADORORIGINAL"].ToString()))
                                {
                                    oEntityDetLote.IdSocio_Beneficiario = _IdSocio_Beneficiario;
                                    oEntityDetLote.IdSocio_BeneficiarioRuc = _IdSocio_BeneficiarioRuc;
                                }
                                else
                                {
                                    oEntityDetLote.IdSocio_BeneficiarioRuc = row["RUCGIRADORORIGINAL"].ToString();

                                    //Obtener la razon social
                                    DataSet dsSocio = new DataSet();
                                    SocioBE oEntitySocio = new SocioBE();
                                    oEntitySocio.OPCION = 11;
                                    oEntitySocio.USUARIO = General.General.GetUsuario;
                                    oEntitySocio.RazonSocial = row["RUCGIRADORORIGINAL"].ToString();
                                    dsSocio = new SocioBL().ProcesarSocio(oEntitySocio);
                                    if (dsSocio.Tables.Count > 0)
                                    {
                                        if (dsSocio.Tables[0].Rows.Count > 0)
                                        {
                                            oEntityDetLote.IdSocio_Beneficiario = dsSocio.Tables[0].Rows[0]["RazonSocial"].ToString();
                                        }
                                    }
                                }
                                LstDetaLoteTmp.Add(oEntityDetLote);
                            }
                        }
                    }

                    //Si es correcto cargamos los lotes al temporal
                    if (IsCorrecto)
                    {
                        if(string.IsNullOrEmpty(txtIdLote.Text))
                        {
                            if (!GuardarLote()) { MessageBox.Show("No se pudo guargar el lote, verifique la información.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                        }  

                        foreach (DetaLoteBE item in LstDetaLoteTmp)
                        {
                            item.USUARIO = General.General.GetCodigoUsuario;
                            item.OPCION = 2;
                            item.IdLote = txtIdLote.Text;
                            DataSet ds = DetaLoteBL.ProcesarDetaLote(item);
                            item.cItem = ds.Tables[0].Rows[0]["cItem"].ToString();
                            LstDetaLote.Add(item);
                        }

                        dgvDetalleLote.DataSource = LstDetaLote;
                        dgvDetalleLote.Refresh();
                        Totalizar();
                    }
 
                    cnExcel.Close();
                    btnImportar.Enabled = false;
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

        private void btnBusCtaAhorro_Click(object sender, EventArgs e)
        {

            try
            {
                Decimal valTipoMonID = 1;
                if (Convert.ToString(cboIdMoneda_tt.SelectedValue).Trim() == "00036")
                {
                    valTipoMonID = 1;
                }
                else if (Convert.ToString(cboIdMoneda_tt.SelectedValue).Trim() == "00037")
                {
                    valTipoMonID = 2;
                }

                Formula.Consulta.frmBusquedaCtaAhorros fBCta = new Formula.Consulta.frmBusquedaCtaAhorros(2,1,1,txtIdSocio.Text.Trim(),null,valTipoMonID);
                fBCta.ShowDialog();

                txtBanco.Text = fBCta.fbcsProdNombre;
                txtNumeroCuenta.Text = fBCta.fbcsNumCuentaID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargoDocumento_Click(object sender, EventArgs e)
        {

            try
            {
                String strIdLote = txtIdLote.Text.Trim();
                DataSet dsLotes = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("Rpt_LoteCargoDoc_Cab", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@IdLote", strIdLote);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsLotes, "dtLoteCargoCab");

                    SqlCommand cmd2 = new SqlCommand("Rpt_LoteCargoDoc_Det", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@IdLote", strIdLote);
                    SqlDataAdapter daDet = new SqlDataAdapter(cmd2);
                    daDet.Fill(dsLotes, "dtLoteCargoDet");

                    con.Close();
                }

                Crystal.crRptCargoDocumento ocrRptCargoDocumento = new Crystal.crRptCargoDocumento();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrRptCargoDocumento;
                ocrRptCargoDocumento.SetDataSource(dsLotes);
                //ocrRptCesionCobranza.SetParameterValue("usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnFormatoCesionCobranza_Click(object sender, EventArgs e)
        {

            try
            {
                String strIdLote = txtIdLote.Text.Trim();
                DataSet dsLotes = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("Rpt_LoteCargoDoc_Cab", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@IdLote", strIdLote);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsLotes, "dtLoteCargoCab");

                    SqlCommand cmd2 = new SqlCommand("Rpt_LoteCargoDoc_Det", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@IdLote", strIdLote);
                    SqlDataAdapter daDet = new SqlDataAdapter(cmd2);
                    daDet.Fill(dsLotes, "dtLoteCargoDet");

                    con.Close();
                }

                Crystal.crRptCesionCobranza ocrRptCesionCobranza = new Crystal.crRptCesionCobranza();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrRptCesionCobranza;
                ocrRptCesionCobranza.SetDataSource(dsLotes);
                //ocrRptCesionCobranza.SetParameterValue("usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarFechaDesembolso_Click(object sender, EventArgs e)
        {
            try
            {
                LoteBE oEntity = new LoteBE()
                {
                    OPCION = 30,
                    USUARIO = General.General.GetUsuario,
                    IdLote = txtIdLote.Text,
                    gFechaOp = General.General.GetFechaGlobal
                };
                new LoteBL().ProcesarLote(oEntity);
                CargarDatos();
                CargarDetalle();
                GuardarCambios(false);
                MessageBox.Show("Se actualizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlantilla_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.FileName = "CargaMasiva";
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx |All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string MyFileName = System.Configuration.ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "Plantillas//Plantilla_DocumentosFactoring.xlsx";
                    string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    var filePath = Path.Combine(execPath, MyFileName);
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook book = app.Workbooks.Open(filePath);
                    book.SaveAs(saveFileDialog.FileName); //Save
                    book.Close();

                    MessageBox.Show("Se guardó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarXML_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdLote.Text))
            {
                if (!ValidarLote()) { return; }
            } 

            string srutaArchivo = string.Empty;
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Archivos de Excel (*.XML) |*.XML";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            LstDetaLoteTmp = new BindingList<DetaLoteBE>();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                srutaArchivo = openFileDialog1.FileName;
                LectorXML(srutaArchivo);
            }
        }

        private void LectorXML(String file_path)
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

                /*string strFechaEmision = xmlDoc.SelectSingleNode("/tns:Invoice/cbc:IssueDate", nsmgr).InnerText; //Fecha de Emision
                string strNroDoc = xmlDoc.SelectSingleNode("/tns:Invoice/cac:Signature/cbc:ID", nsmgr).InnerText; //Serie y número
                string strRucSocio = xmlDoc.SelectSingleNode("/tns:Invoice/cac:AccountingSupplierParty//cbc:CustomerAssignedAccountID", nsmgr).InnerText; //RUC Socio
                string strRucPagadora = xmlDoc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty//cbc:CustomerAssignedAccountID", nsmgr).InnerText; //RUC Pagadora
                string strMoneda = xmlDoc.SelectSingleNode("/tns:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount//@currencyID", nsmgr).InnerText; //Moneda
                string strImpuesto = xmlDoc.SelectSingleNode("/tns:Invoice/cac:TaxTotal/cbc:TaxAmount", nsmgr).InnerText; //Impuesto
                string strMonto = xmlDoc.SelectSingleNode("/tns:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount", nsmgr).InnerText; //Monto*/

                if (!txtRucSocio.Text.Equals(strRucSocio))
                {
                    MessageBox.Show("El socio no concuerda con el de la Factura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Validar datos de la factura
                ImportacionLoteBE oEntity = new ImportacionLoteBE()
                {
                    RucPagadora = strRucPagadora,
                    IdSocio = txtIdSocio.Text.Trim(),
                    IdLinea = cboIdLinea.SelectedValue.ToString(),
                    IdDocumento = "00010", // Factura Electronica
                    IdMoneda_tt = strMoneda.Equals("PEN") ? "00036" : "00037",
                    cNumDoc = strNroDoc
                };
                DataSet ds = new DataSet();
                ds = new ImportacionLoteBL().ProcesarImportacionLote(oEntity);
                if (!ds.Tables[0].Rows[0]["Result"].Equals("OK"))
                {
                    MessageBox.Show("No se pudo subir el XML: " + ds.Tables[0].Rows[0]["MsgResult"].ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //TimeSpan ts = Convert.ToDateTime(row["FECHAPAGO"].ToString()) - Convert.ToDateTime(row["FECHAEMISION"].ToString());
                    int nPlazo = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["nPlazo"].ToString()) ? 1 : Convert.ToInt32(ds.Tables[0].Rows[0]["nPlazo"].ToString());
                    DetaLoteBE oEntityDetLote = new DetaLoteBE();
                    oEntityDetLote.IdLote = txtIdLote.Text;
                    oEntityDetLote.cItem = "";
                    oEntityDetLote.IdPagadora = ds.Tables[0].Rows[0]["IdPagadora"].ToString();
                    oEntityDetLote.IdPagadora_Dsc = ds.Tables[0].Rows[0]["IdPagadora_Dsc"].ToString();
                    oEntityDetLote.vDocumento = ds.Tables[0].Rows[0]["IdDocumento_Dsc"].ToString() + " - " + strNroDoc;
                    oEntityDetLote.IdDocumento = "00010";
                    oEntityDetLote.cNumDoc = strNroDoc;
                    oEntityDetLote.sdRecepcion = General.General.gFechaOp;
                    oEntityDetLote.iPlazo = nPlazo;
                    oEntityDetLote.sdVencimiento = DateTime.Now.AddDays(nPlazo);
                    oEntityDetLote.nvNominal = String.IsNullOrEmpty(strMonto) ? 0 : Convert.ToDecimal(strMonto);
                    oEntityDetLote.cNotaCredito = string.Empty;
                    oEntityDetLote.nNotaCredito = 0;
                    oEntityDetLote.nPorRetencion = 0;
                    oEntityDetLote.nvRetencion = 0;
                    oEntityDetLote.Descuento = 0;
                    oEntityDetLote.dtRenovacion = DateTime.MinValue;
                    oEntityDetLote.IdSocio_Beneficiario = _IdSocio_Beneficiario;
                    oEntityDetLote.IdSocio_BeneficiarioRuc = _IdSocio_BeneficiarioRuc;
                    LstDetaLoteTmp.Add(oEntityDetLote);

                    if (string.IsNullOrEmpty(txtIdLote.Text))
                    {
                        if (!GuardarLote()) { MessageBox.Show("No se pudo guargar el lote, verifique la información.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                    }

                    foreach (DetaLoteBE item in LstDetaLoteTmp)
                    {
                        item.USUARIO = General.General.GetCodigoUsuario;
                        item.OPCION = 2;
                        item.IdLote = txtIdLote.Text;
                        DataSet dsLote = DetaLoteBL.ProcesarDetaLote(item);
                        item.cItem = dsLote.Tables[0].Rows[0]["cItem"].ToString();
                        LstDetaLote.Add(item);
                    }

                    dgvDetalleLote.DataSource = LstDetaLote;
                    dgvDetalleLote.Refresh();
                    Totalizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}