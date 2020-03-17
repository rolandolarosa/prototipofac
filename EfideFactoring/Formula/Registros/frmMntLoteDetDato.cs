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
using System.IO;

namespace EfideFactoring.Formula.Registros
{
    public partial class frmMntLoteDetDato : FormulaBase.frmMntDato
    {
        DetaLoteBL DetaLoteBL = new DetaLoteBL();
        TableBaseBL TableBaseBL = new TableBaseBL();
        SocioLineaPagadoraBL SocioLineaPagadoraBL = new SocioLineaPagadoraBL();
        SocioLineaPagDocBL SocioLineaPagDocBL = new SocioLineaPagDocBL();
        SocioLineaPagRetencionBL SocioLineaPagRetencionBL = new SocioLineaPagRetencionBL();
        SocioLineaPagPlazoBL SocioLineaPagPlazoBL = new SocioLineaPagPlazoBL();
        public List<DetaLoteBE> LstDetalle = new List<DetaLoteBE>();
        public string IdSocio = string.Empty;
        public string IdLinea = string.Empty;
        public string cItem = string.Empty;
        public decimal FondoGarantia = 0;
        public decimal TasaActiva = 0;
        public decimal TasaSobreGiro = 0;
        public string IsChange = "0";
        public int iCuota = 0;
        public decimal nTotalCuota = 0;
        private string FlgImportePago = "0";
        private int DiasExceder = 0;
        private byte[] ByteImageDoc = null;
        private int flgIsLoad = 0;
        string IdImageDoc = string.Empty;

        public frmMntLoteDetDato()
        {
            InitializeComponent();
        }

        private void frmMntLoteDetDato_Load(object sender, EventArgs e)
        {
            try
            {
                rbtnDobleEndoso.Checked = true;
                rbtnPDF.Checked = true;
                txtImportePago.Clear();
                if (Operacion.Equals("N") && IsChange.Equals("0"))
                {
                    LlenarCombos();
                    //CargarGiradorOriginal();
                    dtsdRecepcion.Value = General.General.gFechaOp;
                    dtsdVencimiento.Value = General.General.gFechaOp;
                }
                else if (Operacion.Equals("M"))
                {
                    LlenarCombos();
                    CargarDatos();
                    rbtnDobleEndoso.Checked = true;
                }

                //this.dtsdRecepcion.Enabled = false;
                ByteImageDoc = null;
                pictureBox1.Image = null;
                this.Width = 1236; /* * Centrar el formulario */ 
                int boundWidth = Screen.PrimaryScreen.Bounds.Width; 
                int boundHeight = Screen.PrimaryScreen.Bounds.Height; 
                int x = boundWidth - this.Width; 
                int y = boundHeight - (this.Height - 200); 
                this.Location = new Point(x / 2, y / 2);
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
                if (dtsdRecepcion.Value.Date > General.General.gFechaOp.Date)
                {
                    MessageBox.Show("La fecha de recepción no puede ser mayor a la fecha de operación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(cboIdPagadora.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar una Pagadora", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(cboIdDocumento.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtcNumDoc.Text))
                {
                    MessageBox.Show("Se debe ingresar un Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (cboiPlazo.SelectedValue == null)
                {
                    MessageBox.Show("Se debe ingresar un Plazo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (int.Parse(cboiPlazo.SelectedValue.ToString()) == 0)
                {
                    MessageBox.Show("Plazo debe ser mayo a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DateTime dtVencimiento = dtsdVencimiento.Value;
                DateTime dtPlazoMaximo = dtVencimiento.AddDays((int.Parse(cboiPlazo.SelectedValue.ToString()) + DiasExceder));
                if (dtsdVencimiento.Value > dtPlazoMaximo)
                {
                    MessageBox.Show("La fecha de pago no puede exceder los " + DiasExceder + " días", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (cbonvRetencion.SelectedValue == null && FlgImportePago.Equals("0"))
                {
                    MessageBox.Show("Se debe seleccionar una retención", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (FlgImportePago.Equals("1"))
                {
                    if (Convert.ToDecimal(txtnvNominal.Text) < Convert.ToDecimal(txtImportePago.Text))
                    {
                        MessageBox.Show("El importe de pago no puede ser mayor al importe nominal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                String Table_Id = System.Configuration.ConfigurationManager.AppSettings["ValidarImagen"].ToString();
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Id = Table_Id
                };

                //Validacion para imagen obligatoria
                DataTable dt = new DataTable();
                dt = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Table_Value"].ToString().Equals("1"))
                    {
                        if (ByteImageDoc == null)
                        {
                            MessageBox.Show("Debe agregar la imagen del documento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }

                LstDetalle.Clear();

                iCuota = 1;
                if (!string.IsNullOrEmpty(txtNroCuota.Text))
                {
                    iCuota = Convert.ToInt32(txtNroCuota.Text);
                }

                if (iCuota > 1)
                {
                    nTotalCuota = string.IsNullOrEmpty(lblTotal.Text) ? 0 : Convert.ToDecimal(lblTotal.Text);
                    decimal nTotalValorNominal = string.IsNullOrEmpty(txtnvNominal.Text) ? 0 : Convert.ToDecimal(txtnvNominal.Text);
                    // validar q el monto nominal sea el mismo al total de cuotas
                    
                    if (nTotalCuota != nTotalValorNominal)
                    {
                        MessageBox.Show("La suma total de las cuotas debe ser igual al importe de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (iCuota == 1)
                {

                    DetaLoteBE DetaLoteBE = new DetaLoteBE();
                    DetaLoteBE.USUARIO = General.General.GetCodigoUsuario;
                    DetaLoteBE.OPCION = 2;
                    DetaLoteBE.IdLote = Codigo;
                    DetaLoteBE.cItem = cItem;
                    DetaLoteBE.IdPagadora = cboIdPagadora.SelectedValue.ToString();
                    DetaLoteBE.IdPagadora_Dsc = cboIdPagadora.Text.ToString();
                    DetaLoteBE.IdDocumento = cboIdDocumento.SelectedValue.ToString();
                    DetaLoteBE.IdSocio_Beneficiario = txtRazonSocialSocio.Text;
                    DetaLoteBE.IdSocio_BeneficiarioRuc = txtIdSocio_BeneficiarioRuc.Text.Trim();
                    DetaLoteBE.cNumDoc = txtcNumDoc.Text;
                    DetaLoteBE.vDocumento = cboIdDocumento.Text.ToString() + '-' + txtcNumDoc.Text.Trim();  // DetaLoteBE.cNumDoc;
                    DetaLoteBE.sdRecepcion = dtsdRecepcion.Value;
                    DetaLoteBE.iPlazo = int.Parse(cboiPlazo.SelectedValue.ToString());
                    DetaLoteBE.sdVencimiento = dtsdVencimiento.Value;
                    DetaLoteBE.nvNominal = String.IsNullOrEmpty(txtnvNominal.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvNominal.Text);
                    DetaLoteBE.cNotaCredito = txtcNotaCredito.Text;
                    DetaLoteBE.nNotaCredito = String.IsNullOrEmpty(txtnNotaCredito.Text.Trim()) ? 0 : Convert.ToDecimal(txtnNotaCredito.Text);
                    DetaLoteBE.nPorRetencion = (cbonvRetencion.SelectedValue.ToString() == "System.Data.DataRowView" || cbonvRetencion.SelectedValue.ToString().Equals(string.Empty)) ? 0 : decimal.Parse(cbonvRetencion.SelectedValue.ToString());
                    DetaLoteBE.nvRetencion = String.IsNullOrEmpty(txtnvRetencion.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvRetencion.Text);
                    DetaLoteBE.Descuento = String.IsNullOrEmpty(txtDescuento.Text.Trim()) ? 0 : Convert.ToDecimal(txtDescuento.Text);
                    DetaLoteBE.nvNegociable = String.IsNullOrEmpty(txtValorNegociable.Text.Trim()) ? 0 : Convert.ToDecimal(txtValorNegociable.Text);
                    DetaLoteBE.nFondoGarantia = FondoGarantia;
                    DetaLoteBE.nTazaActiva = TasaActiva;
                    DetaLoteBE.nTasaSobregiro = TasaSobreGiro;
                    DetaLoteBE.bNoRequiereProtesto = CheckNoRequiereProtesto.Checked == true ? true : false;
                    DetaLoteBE.ImageDoc = ByteImageDoc;
                    DetaLoteBE.IdImageDoc = IdImageDoc;
                    LstDetalle.Add(DetaLoteBE);
                    IsChange = "1";
                }
                else
                {
                    foreach (DataGridViewRow row in dgvCuotas.Rows)
                    {
                        DetaLoteBE DetaLoteBE = new DetaLoteBE();
                        DetaLoteBE.USUARIO = General.General.GetCodigoUsuario;
                        DetaLoteBE.OPCION = 2;
                        DetaLoteBE.IdLote = Codigo;
                        DetaLoteBE.cItem = cItem;
                        DetaLoteBE.IdPagadora = cboIdPagadora.SelectedValue.ToString();
                        DetaLoteBE.IdPagadora_Dsc = cboIdPagadora.Text.ToString();
                        DetaLoteBE.IdDocumento = cboIdDocumento.SelectedValue.ToString();
                        DetaLoteBE.IdSocio_Beneficiario = txtRazonSocialSocio.Text;
                        DetaLoteBE.IdSocio_BeneficiarioRuc = txtIdSocio_BeneficiarioRuc.Text.Trim();
                        DetaLoteBE.cNumDoc = txtcNumDoc.Text.Trim() + "_" + row.Cells["NroCuota"].Value.ToString();
                        DetaLoteBE.vDocumento = cboIdDocumento.Text.ToString() + '-' + txtcNumDoc.Text.Trim();  // DetaLoteBE.cNumDoc;
                        DetaLoteBE.sdRecepcion = dtsdRecepcion.Value;
                        DetaLoteBE.iPlazo = int.Parse(cboiPlazo.SelectedValue.ToString());
                        DetaLoteBE.sdVencimiento = Convert.ToDateTime(row.Cells["FechaVnc"].Value.ToString());
                        DetaLoteBE.nvNominal = Convert.ToDecimal(row.Cells["Importe"].Value.ToString()); //String.IsNullOrEmpty(txtnvNominal.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvNominal.Text);
                        DetaLoteBE.cNotaCredito = txtcNotaCredito.Text;
                        DetaLoteBE.nNotaCredito = String.IsNullOrEmpty(txtnNotaCredito.Text.Trim()) ? 0 : Convert.ToDecimal(txtnNotaCredito.Text);
                        DetaLoteBE.nPorRetencion = (cbonvRetencion.SelectedValue.ToString() == "System.Data.DataRowView" || cbonvRetencion.SelectedValue.ToString().Equals(string.Empty)) ? 0 : decimal.Parse(cbonvRetencion.SelectedValue.ToString());
                        DetaLoteBE.nvRetencion = String.IsNullOrEmpty(txtnvRetencion.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvRetencion.Text);
                        DetaLoteBE.Descuento = String.IsNullOrEmpty(txtDescuento.Text.Trim()) ? 0 : Convert.ToDecimal(txtDescuento.Text);
                        DetaLoteBE.nvNegociable = Convert.ToDecimal(row.Cells["Importe"].Value.ToString()); //String.IsNullOrEmpty(txtValorNegociable.Text.Trim()) ? 0 : Convert.ToDecimal(txtValorNegociable.Text);
                        DetaLoteBE.nFondoGarantia = FondoGarantia;
                        DetaLoteBE.nTazaActiva = TasaActiva;
                        DetaLoteBE.nTasaSobregiro = TasaSobreGiro;
                        DetaLoteBE.bNoRequiereProtesto = CheckNoRequiereProtesto.Checked == true ? true : false;
                        DetaLoteBE.ImageDoc = ByteImageDoc;
                        DetaLoteBE.IdImageDoc = IdImageDoc;
                        LstDetalle.Add(DetaLoteBE);
                        IsChange = "1";
                    }
                }
                
                // Limpiar txt
                txtcNumDoc.Clear();
                txtnvNominal.Clear();
                txtcNotaCredito.Clear();
                txtnNotaCredito.Clear();
                txtnvRetencion.Clear();
                txtDescuento.Clear();
                txtValorNegociable.Clear();

                txtcNumDoc.Focus();
                this.Close() ;

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
                DataSet dsDetaLote = new DataSet();
                DetaLoteBE DetaLoteBE = new DetaLoteBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLote = Codigo,
                    cItem = iCuota > 1 ? "" : cItem
                };
                
                dsDetaLote = DetaLoteBL.ProcesarDetaLote(DetaLoteBE);

                if (iCuota > 1)
                {
                    if (dsDetaLote.Tables[0].Rows.Count > 0)
                    {
                        cboIdPagadora.SelectedValue = dsDetaLote.Tables[0].Rows[0]["IdPagadora"].ToString();
                        cboIdDocumento.SelectedValue = dsDetaLote.Tables[0].Rows[0]["IdDocumento"].ToString();
                        txtcNumDoc.Text = dsDetaLote.Tables[0].Rows[0]["cNumDoc"].ToString();
                        dtsdRecepcion.Value = DateTime.Parse(dsDetaLote.Tables[0].Rows[0]["sdRecepcion"].ToString());
                        cboiPlazo.SelectedValue = dsDetaLote.Tables[0].Rows[0]["iPlazo"].ToString();
                        if (cboiPlazo.SelectedValue == null) { cboiPlazo.SelectedIndex = 0; }
                        dtsdVencimiento.Value = DateTime.Parse(dsDetaLote.Tables[0].Rows[0]["sdVencimiento"].ToString());
                        txtnvNominal.Text = nTotalCuota.ToString("N2");
                        txtcNotaCredito.Text = dsDetaLote.Tables[0].Rows[0]["cNotaCredito"].ToString();
                        txtnNotaCredito.Text = Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nNotaCredito"]).ToString("N2");
                        cbonvRetencion.SelectedValue = Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nPorRetencion"]).ToString("N0");
                        txtnvRetencion.Text = Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nvRetencion"]).ToString("N2");
                        txtDescuento.Text = Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["Descuento"]).ToString("N2");
                        txtRazonSocialSocio.Text = dsDetaLote.Tables[0].Rows[0]["IdSocio_Beneficiario"].ToString();
                        txtIdSocio_BeneficiarioRuc.Text = dsDetaLote.Tables[0].Rows[0]["IdSocio_BeneficiarioRuc"].ToString();
                        CheckNoRequiereProtesto.CheckValue = dsDetaLote.Tables[0].Rows[0]["bNoRequiereProtesto"];
                        txtImportePago.Text = (Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nvNominal"]) - Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["Descuento"])).ToString("N2");
                        flgIsLoad = 1;
                        txtNroCuota.Text = iCuota.ToString();
                        lblTotal.Text = nTotalCuota.ToString("N2");

                        //Imagen
                        if (!string.IsNullOrEmpty(dsDetaLote.Tables[0].Rows[0]["IdImageDoc"].ToString()))
                        {
                            if (dsDetaLote.Tables[0].Rows[0]["IdImageDoc"].ToString().Contains(".pdf"))
                            {
                                rbtnPDF.Checked = true;
                                rbtnImagen.Checked = false;
                                txtFileName.Text = System.Configuration.ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "/" + dsDetaLote.Tables[0].Rows[0]["IdImageDoc"].ToString();
                                return;
                            }
                            else
                            {
                                rbtnPDF.Checked = false;
                                rbtnImagen.Checked = true;
                            }
                            string ImageName = dsDetaLote.Tables[0].Rows[0]["IdImageDoc"].ToString();
                            var files = Directory.GetFiles(System.Configuration.ConfigurationManager.AppSettings["RutaImageFisical"].ToString(), dsDetaLote.Tables[0].Rows[0]["IdImageDoc"].ToString());
                            pictureBox1.Image = Image.FromFile(System.Configuration.ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "/" + ImageName);
                            ImageConverter imgCon = new ImageConverter();
                            ByteImageDoc = (byte[])imgCon.ConvertTo(pictureBox1.Image, typeof(byte[]));
                        }

                        //Llenar cuotas
                        foreach (DataRow dr in dsDetaLote.Tables[0].Rows)
                        {
                            int rowId = dgvCuotas.Rows.Add();

                            // Grab the new row!
                            DataGridViewRow drCuota = dgvCuotas.Rows[rowId];

                            drCuota.Cells[0].Value = rowId;
                            drCuota.Cells[1].Value = dr["sdVencimiento"].ToString();
                            drCuota.Cells[2].Value = dr["nvNegociable"].ToString();
                        }
                    }
                }
                else
                {
                    if (dsDetaLote.Tables[0].Rows.Count > 0)
                    {
                        cboIdPagadora.SelectedValue = dsDetaLote.Tables[0].Rows[0]["IdPagadora"].ToString();
                        cboIdDocumento.SelectedValue = dsDetaLote.Tables[0].Rows[0]["IdDocumento"].ToString();
                        txtcNumDoc.Text = dsDetaLote.Tables[0].Rows[0]["cNumDoc"].ToString();
                        dtsdRecepcion.Value = DateTime.Parse(dsDetaLote.Tables[0].Rows[0]["sdRecepcion"].ToString());
                        cboiPlazo.SelectedValue = dsDetaLote.Tables[0].Rows[0]["iPlazo"].ToString();
                        if (cboiPlazo.SelectedValue == null) { cboiPlazo.SelectedIndex = 0; }
                        dtsdVencimiento.Value = DateTime.Parse(dsDetaLote.Tables[0].Rows[0]["sdVencimiento"].ToString());
                        txtnvNominal.Text = Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nvNominal"]).ToString("N2");
                        txtcNotaCredito.Text = dsDetaLote.Tables[0].Rows[0]["cNotaCredito"].ToString();
                        txtnNotaCredito.Text = Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nNotaCredito"]).ToString("N2");
                        cbonvRetencion.SelectedValue = Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nPorRetencion"]).ToString("N0");
                        txtnvRetencion.Text = Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nvRetencion"]).ToString("N2");
                        txtDescuento.Text = Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["Descuento"]).ToString("N2");
                        txtRazonSocialSocio.Text = dsDetaLote.Tables[0].Rows[0]["IdSocio_Beneficiario"].ToString();
                        txtIdSocio_BeneficiarioRuc.Text = dsDetaLote.Tables[0].Rows[0]["IdSocio_BeneficiarioRuc"].ToString();
                        CheckNoRequiereProtesto.CheckValue = dsDetaLote.Tables[0].Rows[0]["bNoRequiereProtesto"];
                        txtImportePago.Text = (Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nvNominal"]) - Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["Descuento"])).ToString("N2");

                        //Imagen
                        if (!string.IsNullOrEmpty(dsDetaLote.Tables[0].Rows[0]["IdImageDoc"].ToString()))
                        {
                            if (dsDetaLote.Tables[0].Rows[0]["IdImageDoc"].ToString().Contains(".pdf"))
                            {
                                rbtnPDF.Checked = true;
                                rbtnImagen.Checked = false;
                                txtFileName.Text = System.Configuration.ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "/" + dsDetaLote.Tables[0].Rows[0]["IdImageDoc"].ToString();
                                return;
                            }
                            else
                            {
                                rbtnPDF.Checked = false;
                                rbtnImagen.Checked = true;
                            }
                            string ImageName = dsDetaLote.Tables[0].Rows[0]["IdImageDoc"].ToString();
                            var files = Directory.GetFiles(System.Configuration.ConfigurationManager.AppSettings["RutaImageFisical"].ToString(), dsDetaLote.Tables[0].Rows[0]["IdImageDoc"].ToString());
                            pictureBox1.Image = Image.FromFile(System.Configuration.ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "/" + ImageName);
                            ImageConverter imgCon = new ImageConverter();
                            ByteImageDoc = (byte[])imgCon.ConvertTo(pictureBox1.Image, typeof(byte[]));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este .... no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

                int swop = 0;
                if (Operacion.Equals("N"))
                    swop=5;
                 else
                    swop =1;

               SocioLineaPagadoraBE SocioLineaPagadoraBE = new SocioLineaPagadoraBE()
               {
                        OPCION = swop ,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdLinea = IdLinea.Trim(),
                };

                General.General.LlenarCombobox(cboIdPagadora, "IdPagadora_Dsc", "IdPagadora", SocioLineaPagadoraBL.ProcesarSocioLineaPagadora(SocioLineaPagadoraBE).Tables[0]);
                cboIdPagadora_SelectedIndexChanged(new object(), new EventArgs());

                String Table_Id = "00060";
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                DataTable dt = new DataTable();
                dt = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                DataRow dr;
                dr = dt.NewRow();
                dr["Table_Name"] = "--Sin Retención--";
                dr["Table_Value"] = "0";
                dt.Rows.InsertAt(dr, 0);
                cbonvRetencion.DataSource = dt;
                cbonvRetencion.DisplayMember = "Table_Name";
                cbonvRetencion.ValueMember = "Table_Value";

                DataSet ds = new DataSet();
                TableBaseBE.Table_Id = "00129"; //Dias maximos a exceder a partir del plazo
                TableBaseBE.Table_Parent_Id = "";
                ds = TableBaseBL.ProcesarTableBase(TableBaseBE);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DiasExceder = int.Parse(ds.Tables[0].Rows[0]["Table_Value"].ToString());
                }

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void CargarGiradorOriginal()
         {
             try
             {
                TercerCasoSocioBE oEntity = new TercerCasoSocioBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdSocio = IdSocio,
                };

                DataSet ds = new DataSet();
                ds = new TercerCasoSocioBL().ProcesarTercerCasoSocio(oEntity);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    txtRazonSocialSocio.Text = ds.Tables[0].Rows[0]["RazonSocial"].ToString();
                    txtIdSocio_BeneficiarioRuc.Text = ds.Tables[0].Rows[0]["Ruc"].ToString();
                }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void LlenarCuotas()
         {
             try
             {
                 if (!string.IsNullOrEmpty(txtNroCuota.Text) && !string.IsNullOrEmpty(txtnvNominal.Text))
                 {
                     int CantCuota = Convert.ToInt32(txtNroCuota.Text);
                     decimal ValorNegociable = Convert.ToDecimal(txtnvNominal.Text);

                     if (CantCuota > 1 && ValorNegociable > 0)
                     {
                         dgvCuotas.Rows.Clear();
                         decimal ValorCuota = ValorNegociable / CantCuota;

                         for (int i = 1; i <= CantCuota; i++)
                         {
                             //DataGridViewRow dr = new DataGridViewRow();
                             int rowId = dgvCuotas.Rows.Add();

                             // Grab the new row!
                             DataGridViewRow dr = dgvCuotas.Rows[rowId];

                             dr.Cells[0].Value = i;
                             dr.Cells[1].Value = dtsdRecepcion.Value.AddMonths(i).Date;
                             dr.Cells[2].Value = ValorCuota;
                             //dgvCuotas.Rows.Add(dr);
                         }
                     }

                     TotalizarCuotas();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void TotalizarCuotas()
         {
             try
             {
                 decimal TotalCuotas = 0;
                 foreach (DataGridViewRow row in dgvCuotas.Rows)
                 {
                     TotalCuotas = TotalCuotas + Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
                 }

                 lblTotal.Text = TotalCuotas.ToString("N2");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void txtnvNominal_KeyPress(object sender, KeyPressEventArgs e)
         {
             General.General.Validar_Decimal(e, txtnvNominal.Text);
         }

         private void txtnNotaCredito_KeyPress(object sender, KeyPressEventArgs e)
         {
             General.General.Validar_Decimal(e, txtnNotaCredito.Text);
         }

         private void txtnPorRetencion_KeyPress(object sender, KeyPressEventArgs e)
         {
             //General.General.Validar_Decimal(e, txtnPorRetencion.Text);
         }

         private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
         {
             General.General.Validar_Decimal(e, txtDescuento.Text);
         }

         private void cboIdPagadora_SelectedIndexChanged(object sender, EventArgs e)
         {
             try
             {
                SocioLineaPagDocBE SocioLineaPagDocBE = new SocioLineaPagDocBE()
                {
                    OPCION =  1,
                    USUARIO = General.General.GetUsuario,
                    IdLinea = IdLinea.Trim(),
                    IdPagadora = cboIdPagadora.SelectedValue.ToString(),
                };

                General.General.LlenarCombobox(cboIdDocumento, "vDocumento", "IdDocumento", SocioLineaPagDocBL.ProcesarSocioLineaPagDoc(SocioLineaPagDocBE).Tables[0]);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void cboIdDocumento_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (cboIdDocumento.SelectedValue.ToString() == "System.Data.DataRowView")
             {
                 return;
             }

            FondoGarantia = 0;
            TasaActiva = 0;
            TasaSobreGiro = 0;
            cboiPlazo.DataSource = null;
            /* NO REQUIERE EL CHECK DE TITULO VALOR EN EL DOCUMENTO - 20180404 BP
            lblBeneficiario.Visible = false;
            txtRazonSocialSocio.Visible = false;
            btnBusquedaSocio.Visible = false;
             */
            txtnNotaCredito.Enabled = true;
            txtcNotaCredito.Enabled = true;
            cbonvRetencion.Enabled = true;
            txtDescuento.Enabled = true;

            //if (cboIdDocumento.SelectedValue.ToString() == "00002")  //LETRA
            // {
            //     txtnNotaCredito.Enabled = false;
            //     txtcNotaCredito.Enabled = false;
            //     cbonvRetencion.SelectedIndex = -1;
            //     cbonvRetencion.Enabled = false;
            //     txtDescuento.Enabled = false;

            // }
            // else
            // {
            //     txtnNotaCredito.Enabled = true;
            //     txtcNotaCredito.Enabled = true;
            //     cbonvRetencion.Enabled = true;
            //     txtDescuento.Enabled = true;
            // }


            if (!string.IsNullOrEmpty(cboIdDocumento.SelectedValue.ToString()))
            {
                // Documentos
                DataSet dsDoc = new DataSet();
                Boolean bInteres = false;
                SocioLineaPagDocBE SocioLineaPagDocBE = new SocioLineaPagDocBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdLinea = IdLinea.Trim(),
                    IdPagadora = cboIdPagadora.SelectedValue.ToString(),
                    IdDocumento = cboIdDocumento.SelectedValue.ToString()
                };
                dsDoc = SocioLineaPagDocBL.ProcesarSocioLineaPagDoc(SocioLineaPagDocBE);
                if (dsDoc.Tables[0].Rows.Count > 0)
                {
                    bInteres = Boolean.Parse(dsDoc.Tables[0].Rows[0]["bInteres"].ToString());
                    FlgImportePago = dsDoc.Tables[0].Rows[0]["FlgImportePago"].ToString();
                    FondoGarantia = decimal.Parse(dsDoc.Tables[0].Rows[0]["nFondoGarantia"].ToString());

                    labelX9.Text = "Total N. Credito";
                    txtnNotaCredito.Visible = true;
                    txtImportePago.Visible = false;
                    labelX8.Visible = true;
                    txtcNotaCredito.Visible = true;
                    cbonvRetencion.Visible = true;
                    labelX10.Visible = true;
                    txtnvRetencion.Visible = true;
                    labelX11.Visible = true;
                    txtDescuento.Enabled = true;
                    txtImportePago.Clear();

                    if (bInteres)
                    {
                        /* NO REQUIERE EL CHECK DE TITULO VALOR EN EL DOCUMENTO - 20180404 BP
                        lblBeneficiario.Visible = true;
                        txtRazonSocialSocio.Visible = true;
                        btnBusquedaSocio.Visible = true;
                        */
                        labelX14.Visible = true;
                        CheckNoRequiereProtesto.Visible = true;
                        txtnNotaCredito.Enabled = false;
                        txtcNotaCredito.Enabled = false;
                        cbonvRetencion.Enabled = false;
                        txtDescuento.Enabled = false;
                    }

                    if (FlgImportePago == "1") 
                    {
                        labelX8.Visible = false;
                        txtcNotaCredito.Visible = false;
                        cbonvRetencion.Visible = false;
                        labelX10.Visible = false;
                        txtnvRetencion.Visible = false;
                        labelX11.Visible = false;
                        txtDescuento.Enabled = false;
                        labelX9.Text = "Importe de Pago";
                        txtnNotaCredito.Visible = false;
                        txtImportePago.Visible = true;
                    }
                }

                // Plazos
                DataSet dsTasa = new DataSet();
                SocioLineaPagPlazoBE SocioLineaPagPlazoBE = new SocioLineaPagPlazoBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetUsuario,
                    IdLinea = IdLinea.Trim(),
                    IdPagadora = cboIdPagadora.SelectedValue.ToString(),
                    IdDocumento = cboIdDocumento.SelectedValue.ToString()
                };
                dsTasa = SocioLineaPagPlazoBL.ProcesarSocioLineaPagPlazo(SocioLineaPagPlazoBE);
                if (dsTasa.Tables[0].Rows.Count > 0)
                {
                    cboiPlazo.DataSource = dsTasa.Tables[0];
                    cboiPlazo.DisplayMember = "Descripcion";
                    cboiPlazo.ValueMember = "nPlazo";
                    cboiPlazo_SelectedIndexChanged(new object(), new EventArgs());
                }
            }

            //DataTable dt = new DataTable();
            //SocioLineaPagRetencionBE SocioLineaPagRetencionBE = new SocioLineaPagRetencionBE()
            //{
            //    OPCION = 5,
            //    USUARIO = General.General.GetUsuario,
            //    IdLinea = IdLinea.Trim(),
            //    IdPagadora = cboIdPagadora.SelectedValue.ToString(),
            //    IdDocumento = cboIdDocumento.SelectedValue.ToString()
            //};
            //dt = SocioLineaPagRetencionBL.ProcesarSocioLineaPagRetencion(SocioLineaPagRetencionBE).Tables[0];
            //DataRow dr;
            //dr = dt.NewRow();
            //dr["nRetencion_Dsc"] = "--Sin Retención--";
            //dr["nRetencion"] = 0;
            //dt.Rows.InsertAt(dr, 0);
            //cbonvRetencion.DataSource = dt;
            //cbonvRetencion.DisplayMember = "nRetencion_Dsc";
            //cbonvRetencion.ValueMember = "nRetencion";
         }

         private void txtnvNominal_TextChanged(object sender, EventArgs e)
         {
             if (!string.IsNullOrEmpty(txtnvNominal.Text.Trim()))
             {
                 Decimal Valor = Decimal.Parse(txtnvNominal.Text);

                 if (FlgImportePago.Equals("0"))
                 {
                     if (cbonvRetencion.SelectedValue == null)
                     {
                         return;
                     }

                     if (!string.IsNullOrEmpty(cbonvRetencion.SelectedValue.ToString()) && cbonvRetencion.SelectedValue.ToString() != "System.Data.DataRowView")
                     {
                         Decimal Detraccion = Convert.ToDecimal(cbonvRetencion.SelectedValue.ToString());

                         if (Detraccion >= 100)
                         {
                             MessageBox.Show("El valor debe ser menor a 100", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                             return;
                         }

                         Decimal ValorNominal = string.IsNullOrEmpty(txtnvNominal.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvNominal.Text.Trim());
                         Decimal MontoNotaCredito = string.IsNullOrEmpty(txtnNotaCredito.Text.Trim()) ? 0 : Convert.ToDecimal(txtnNotaCredito.Text.Trim());
                         Decimal Cal = ValorNominal - MontoNotaCredito;
                         Decimal Resultado = Detraccion > 0 ? (Cal * Detraccion) / 100 : 0;
                         Decimal Descuento = string.IsNullOrEmpty(txtDescuento.Text.Trim()) ? 0 : Convert.ToDecimal(txtDescuento.Text.Trim());
                         txtValorNegociable.Text = (ValorNominal - MontoNotaCredito - Resultado - Descuento).ToString("N2");
                         txtnvRetencion.Text = Resultado.ToString("N2");
                     }
                 }
                 else
                 {
                     Decimal Descuento = string.IsNullOrEmpty(txtDescuento.Text.Trim()) ? 0 : Convert.ToDecimal(txtDescuento.Text.Trim());
                     txtImportePago.Text = "0.00";
                     //txtImportePago.Text = (Valor - Descuento).ToString("N2");
                 }
             }
         }

         private void cbonvRetencion_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (cbonvRetencion.SelectedValue.ToString() == "System.Data.DataRowView")
             {
                 return;
             }

             Decimal Detraccion = string.IsNullOrEmpty(cbonvRetencion.SelectedValue.ToString()) ? 0 : Convert.ToDecimal(cbonvRetencion.SelectedValue.ToString());

             if (Detraccion >= 100)
             {
                 MessageBox.Show("El valor debe ser menor a 100", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

             Decimal ValorNominal = string.IsNullOrEmpty(txtnvNominal.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvNominal.Text.Trim());
             Decimal MontoNotaCredito = string.IsNullOrEmpty(txtnNotaCredito.Text.Trim()) ? 0 : Convert.ToDecimal(txtnNotaCredito.Text.Trim());
             Decimal Cal = ValorNominal - MontoNotaCredito;
             Decimal Resultado = Detraccion > 0 ? (Cal * Detraccion) / 100 : 0;
             Decimal Descuento = string.IsNullOrEmpty(txtDescuento.Text.Trim()) ? 0 : Convert.ToDecimal(txtDescuento.Text.Trim());
             txtValorNegociable.Text = (ValorNominal - MontoNotaCredito - Resultado - Descuento).ToString("N2");
             txtnvRetencion.Text = Resultado.ToString("N2");
             
         }

         private void txtDescuento_TextChanged(object sender, EventArgs e)
         {
             Decimal ValorNominal = string.IsNullOrEmpty(txtnvNominal.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvNominal.Text.Trim());
             Decimal Detraccion = string.IsNullOrEmpty(txtnvRetencion.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvRetencion.Text.Trim());
             Decimal Descuento = string.IsNullOrEmpty(txtDescuento.Text.Trim()) ? 0 : Convert.ToDecimal(txtDescuento.Text.Trim());
             Decimal MontoNotaCredito = string.IsNullOrEmpty(txtnNotaCredito.Text.Trim()) ? 0 : Convert.ToDecimal(txtnNotaCredito.Text.Trim());

             txtValorNegociable.Text = (ValorNominal - MontoNotaCredito - Detraccion - Descuento).ToString("N2");
         }

         private void txtnNotaCredito_TextChanged(object sender, EventArgs e)
         {
             if (!string.IsNullOrEmpty(txtnvNominal.Text.Trim()))
             {
                 //if (FlgImportePago.Equals("0"))
                 //{
                Decimal ValorNominal = string.IsNullOrEmpty(txtnvNominal.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvNominal.Text.Trim());
                Decimal Detraccion = string.IsNullOrEmpty(txtnvRetencion.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvRetencion.Text.Trim());
                Decimal Descuento = string.IsNullOrEmpty(txtDescuento.Text.Trim()) ? 0 : Convert.ToDecimal(txtDescuento.Text.Trim());
                Decimal MontoNotaCredito = string.IsNullOrEmpty(txtnNotaCredito.Text.Trim()) ? 0 : Convert.ToDecimal(txtnNotaCredito.Text.Trim());

                txtValorNegociable.Text = (ValorNominal - MontoNotaCredito - Detraccion - Descuento).ToString("N2");
                 //}
                 //else
                 //{
                 //    Decimal ValorNominal = string.IsNullOrEmpty(txtnvNominal.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvNominal.Text.Trim());
                 //    Decimal ImporteTotal = string.IsNullOrEmpty(txtImportePago.Text.Trim()) ? 0 : Convert.ToDecimal(txtImportePago.Text.Trim());
                 //    Decimal Descuento = (ValorNominal - ImporteTotal);
                 //    txtDescuento.Text = Descuento.ToString("N2");
                 //    txtValorNegociable.Text = (ValorNominal - Descuento).ToString("N2");
                 //}
             }
         }

         private void cboiPlazo_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (cboiPlazo.SelectedValue == null)
             {
                 return;
             }

             if (cboiPlazo.SelectedValue.ToString().Equals("System.Data.DataRowView"))
             {
                 return;
             }

             if (cboiPlazo.SelectedValue.ToString() != "System.Data.DataRowView" && !string.IsNullOrEmpty(cboiPlazo.SelectedValue.ToString()))
             {
                DateTime dtFechaEmision = dtsdRecepcion.Value;
                int Dias = int.Parse(cboiPlazo.SelectedValue.ToString());
                dtsdVencimiento.Value = dtFechaEmision.AddDays(Dias);

                TasaActiva = 0;
                TasaSobreGiro = 0;
                DataSet dsTasa = new DataSet();
                SocioLineaPagPlazoBE SocioLineaPagPlazoBE = new SocioLineaPagPlazoBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetUsuario,
                    IdLinea = IdLinea.Trim(),
                    IdPagadora = cboIdPagadora.SelectedValue.ToString(),
                    IdDocumento = cboIdDocumento.SelectedValue.ToString(),
                    IdItem = cboiPlazo.SelectedValue.ToString()
                };
                dsTasa = SocioLineaPagPlazoBL.ProcesarSocioLineaPagPlazo(SocioLineaPagPlazoBE);
                if (dsTasa.Tables[0].Rows.Count > 0)
                {
                    TasaActiva = Decimal.Parse(dsTasa.Tables[0].Rows[0]["nTasa"].ToString());
                    TasaSobreGiro = Decimal.Parse(dsTasa.Tables[0].Rows[0]["nTasaSobregiro"].ToString());
                }
             }
         }

         private void btnBusquedaSocio_Click(object sender, EventArgs e)
         {
             try
             {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio._Opcion = rbtnDobleEndoso.Checked? 7 : 8;
                ofrmBusquedaSocio.bDesactivarBotones = rbtnDobleEndoso.Checked ? false : true;
                ofrmBusquedaSocio.CodSocio = IdSocio;
                ofrmBusquedaSocio.ShowDialog();
                if (!string.IsNullOrEmpty(ofrmBusquedaSocio.RazorSocialSocio.Trim()))
                {
                    txtRazonSocialSocio.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
                    txtIdSocio_BeneficiarioRuc.Text = ofrmBusquedaSocio.RUCSocio.Trim();
                }
                
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void txtImportePago_KeyPress(object sender, KeyPressEventArgs e)
         {
             General.General.Validar_Decimal(e, txtImportePago.Text);
         }

         private void txtImportePago_TextChanged(object sender, EventArgs e)
         {
             try
             {
                 if (!FlgImportePago.Equals("0"))
                 {
                     Decimal ValorNominal = string.IsNullOrEmpty(txtnvNominal.Text.Trim()) ? 0 : Convert.ToDecimal(txtnvNominal.Text.Trim());
                     Decimal ImporteTotal = string.IsNullOrEmpty(txtImportePago.Text.Trim()) ? 0 : Convert.ToDecimal(txtImportePago.Text.Trim());
                     Decimal Descuento = (ValorNominal - ImporteTotal);
                     txtDescuento.Text = Descuento.ToString("N2");
                     txtValorNegociable.Text = (ValorNominal - Descuento).ToString("N2");
                 }
             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void btnAgregarImagen_Click(object sender, EventArgs e)
         {
             try
             {
                 openFileDialog1.InitialDirectory = @"C:\";
                 //openFileDialog1.Filter = "Files(*.jpg; *.jpeg)|*.jpg; *.jpeg | Pdf Files|*.pdf";
                 openFileDialog1.Filter = "Files(*.jpg; *.jpeg)|*.jpg; *.jpeg";
                 openFileDialog1.FilterIndex = 2;
                 openFileDialog1.RestoreDirectory = true;
                 openFileDialog1.FileName = "";

                 if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                 {
                     if (System.IO.Path.GetExtension(openFileDialog1.FileName) == ".pdf")
                     {
                         IdImageDoc = ".pdf";
                         ByteImageDoc = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                     }
                     else
                     {
                         IdImageDoc = ".png";
                         pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                         ByteImageDoc = get_image(openFileDialog1.FileName);
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void btnEliminarImagen_Click(object sender, EventArgs e)
         {
             try
             {
                 pictureBox1.Image = null;
                 ByteImageDoc = null;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private byte[] get_image(string filePath)
         {
             byte[] photo = null;
             try
             {
                 FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                 BinaryReader reader = new BinaryReader(stream);
                 photo = reader.ReadBytes((int)stream.Length);
                 reader.Close();
                 stream.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             return photo;
         }

         private void grpDato_Click(object sender, EventArgs e)
         {

         }

         private void btnExaminar_Click(object sender, EventArgs e)
         {
             try
             {
                 openFileDialog1.InitialDirectory = @"C:\";
                 openFileDialog1.Filter = "Files(Pdf Files|*.pdf";
                 openFileDialog1.FilterIndex = 1;
                 openFileDialog1.RestoreDirectory = true;
                 openFileDialog1.FileName = "";

                 if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                 {
                     if (System.IO.Path.GetExtension(openFileDialog1.FileName) == ".pdf")
                     {
                         IdImageDoc = ".pdf";
                         ByteImageDoc = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                         txtFileName.Text = openFileDialog1.FileName;
                     }
                     else
                     {
                         IdImageDoc = ".png";
                         pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                         ByteImageDoc = get_image(openFileDialog1.FileName);
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void btnLimpiar_Click(object sender, EventArgs e)
         {
             try
             {
                 IdImageDoc = "";
                 ByteImageDoc = null;
                 txtFileName.Text = string.Empty;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void rbtnPDF_CheckedChanged(object sender, EventArgs e)
         {
             try
             {
                 IdImageDoc = "";
                 ByteImageDoc = null;
                 txtFileName.Text = string.Empty;

                 if (rbtnPDF.Checked)
                 {
                     grpPDF.Enabled = true;
                     grpIMAGEN.Enabled = false;
                 }
                 else
                 {
                     grpPDF.Enabled = false;
                     grpIMAGEN.Enabled = true;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void rbtnImagen_CheckedChanged(object sender, EventArgs e)
         {
             try
             {
                 IdImageDoc = "";
                 ByteImageDoc = null;
                 txtFileName.Text = string.Empty;

                 if (rbtnImagen.Checked)
                 {
                     grpPDF.Enabled = false;
                     grpIMAGEN.Enabled = true;
                 }
                 else
                 {
                    grpPDF.Enabled = true;
                     grpIMAGEN.Enabled = false;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void txtNroCuota_TextChanged(object sender, EventArgs e)
         {
             if (flgIsLoad == 0)
             {
                 LlenarCuotas();
             }
             else
             {
                 flgIsLoad = 0;
             }
         }

         private void txtNroCuota_KeyPress(object sender, KeyPressEventArgs e)
         {
             General.General.Validar_Enteros(e);
         }
    }
}