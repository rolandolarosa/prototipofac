using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmMntCobranzaPagadoraDato : FormulaBase.frmMntDato
    {
        private CobranzaBL CobranzaBL = new CobranzaBL();
        private TableBaseBL TableBaseBL = new TableBaseBL();
        private PagadoraBL PagadoraBL = new PagadoraBL();
        private CobranzaDetalleBL CobranzaDetalleBL = new CobranzaDetalleBL();
        private DetaLoteBL DetaLoteBL = new DetaLoteBL();
        private BindingList<CobranzaDetalleBE> LstCobranzaDetalle = new BindingList<CobranzaDetalleBE>();
        private BindingList<CobranzaPagoBE> LstCobranzaPago = new BindingList<CobranzaPagoBE>();
        private Decimal PrjLimiteVal = 0;
        #region Eventos
        public frmMntCobranzaPagadoraDato()
        {
            InitializeComponent();
        }
        private void frmMntCobranzaPagadoraDato_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoDeposito.SelectedIndex = 0;
                dgvDepositos.ReadOnly = false;
                nTotal.ReadOnly = false;
                ctasBancariaID.ReadOnly = true;
                jSaldo.ReadOnly = true;
                jImporte.ReadOnly = true;
                ctasBanNumCta.ReadOnly = true;
                IdTipoAbono_tt_Dsc.ReadOnly = true;
                IdOperacion_tt_Dsc.ReadOnly = true;


                LlenarCombos();
                if (Operacion.Equals("N"))
                {
                    txtStatus.Text = "A";
                    //dtRegistro.Value = DateTime.Now;
                    dtRegistro.Value = General.General.gFechaOp;
                    //txtdtRegistro.Text = General.General.gFechaOp.ToString().Substring(0,10);
                }
                else if (Operacion.Equals("M"))
                {
                    txtIdCobranza.Text = Codigo;
                    cboIdMoneda_tt.Enabled = false;
                    txtIdPagadora.Enabled = false;
                    txtDescripcion.ReadOnly = true;
                    //dtRegistro.Enabled = false;
                    txtDatosAdicionales.ReadOnly = true;
                    btnBuscarPagadora.Enabled = false;
                    LlenarCombos();
                    CargarDatos();
                }
                else if (Operacion.Equals("C"))
                {
                    txtIdCobranza.Text = Codigo;
                    cboIdMoneda_tt.Enabled = false;
                    txtIdPagadora.Enabled = false;
                    txtDescripcion.ReadOnly = true;
                    dtRegistro.Enabled = false;
                    txtDatosAdicionales.ReadOnly = true;
                    btnBuscarPagadora.Enabled = false;
                    btnDepositosXAplicar.Enabled = false;
                    btnAgregarDet.Visible = false;
                    btnQuitarDet.Visible = false;
                    btnAceptar.Visible = false;
                    btnDepositosXAplicar.Visible = false;
                    btnQuitarDepositos.Visible = false;
                    dgvDocumentos.ReadOnly = true;
                    LlenarCombos();
                    CargarDatos();
                }

                TableBaseBE oEntity = new TableBaseBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.Table_Id = "01175"; //Porcentaje Validacion Cobranzas
                DataSet ds = new TableBaseBL().ProcesarTableBase(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    PrjLimiteVal = decimal.Parse(ds.Tables[0].Rows[0]["Table_Value"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaPagadora ofrmBusquedaPagadora = new Formula.Consulta.frmBusquedaPagadora();
                ofrmBusquedaPagadora.ShowDialog();

                DataSet dsPagadora = new DataSet();
                PagadoraBE PagadoraBE = new PagadoraBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = ofrmBusquedaPagadora.CodigoPagadora.ToString()
                };

                dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);

                if (dsPagadora.Tables[0].Rows.Count > 0)
                {
                    txtIdPagadora.Text = dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString();
                    txtDescripcion.Text = dsPagadora.Tables[0].Rows[0]["vcPagadora"].ToString();
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
                // Obtener la variable general de validación
                TableBaseBE oEntityTable = new TableBaseBE();
                oEntityTable.OPCION = 1;
                oEntityTable.USUARIO = General.General.GetUsuario;
                oEntityTable.Table_Id = "01175"; //Porcentaje Validacion Cobranzas
                DataSet ds = new TableBaseBL().ProcesarTableBase(oEntityTable);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    PrjLimiteVal = decimal.Parse(ds.Tables[0].Rows[0]["Table_Value"].ToString());
                }

                TotalizarDepositos();
                TotalizarImporteDoc();
                Decimal Total = string.IsNullOrEmpty(lblSaltoXAplicar.Text) ? 0 : Convert.ToDecimal(lblSaltoXAplicar.Text);
                Decimal AcImporteTotal = string.IsNullOrEmpty(txtTotalImp.Text) ? 0 : Convert.ToDecimal(txtTotalImp.Text);
  
                //Validacion, el monto a cancelar no debe ser menor igual del 90%
                Decimal AcnvImporte = 0;
                Decimal AcMontoCobrar = 0;
                Decimal nMontoCobrar = 0;
                Decimal nDifCobrada = 0;

                bool IsError = false;
                foreach (DataGridViewRow row in dgvDocumentos.Rows)
                {
                    AcnvImporte = AcnvImporte + (Decimal)row.Cells["nvImporte"].Value;
                    AcMontoCobrar = AcMontoCobrar + (Decimal)row.Cells["nvMontoCobrar"].Value;

                    nMontoCobrar = (Decimal)row.Cells["nvMontoCobrar"].Value;
                    nDifCobrada = (Decimal)row.Cells["DifCobrada"].Value;
                    nDifCobrada = Math.Abs(nDifCobrada);
                    
                    //if (PrjLimiteVal > 0)
                    //{
                        //if (((AcnvImporte / AcMontoCobrar) * 100) < PrjLimiteVal && ((AcnvImporte / AcMontoCobrar) * 100) > 100)
                        //{
                        //    IsError = true;
                        //    break;
                        //}

                        // Modif 20190708
                    if (((nDifCobrada / nMontoCobrar) * 100) > PrjLimiteVal)
                    {
                        IsError = true;
                        break;
                    }
                    //}
                }

                // VALIDACION A NIVEL GLOBAL YA NO VA 20190712
                /*
                decimal SaldoAplicar = string.IsNullOrEmpty(lblSaltoXAplicar.Text) ? 0 : Convert.ToDecimal(lblSaltoXAplicar.Text.ToString());

                if (PrjLimiteVal > 0 && SaldoAplicar > 0)
                {
                    if (((AcMontoCobrar / SaldoAplicar) * 100) < PrjLimiteVal)
                    {
                        MessageBox.Show("El importe a pagar es menor al " + PrjLimiteVal.ToString() + "% de lo permitido, por favor verifique.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }*/

                //if (AcImporteTotal != Total)
                //{
                //    MessageBox.Show("La distribución del depósito debe ser igual que el importe del depósito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}
                if (IsError)
                {
                    MessageBox.Show("El importe a cancelar excede el " + PrjLimiteVal.ToString() + "% de lo permitido, por favor verifique.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("El importe a cancelar es mayor al 10% de lo permitido, por favor verifique.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (dtRegistro.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Se debe ingresar una fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Comentado por Rq. 20181012 para los previos se puede crear cobranzas con fecha futura pero al confirmar validar que la fecha sea igual al del día
                //if (dtRegistro.Value > DateTime.Now)
                //{
                //    MessageBox.Show("La fecha de cancelación no puede ser mayor a la fecha actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                //if (dtRegistro.Value.Date < DateTime.Now.Date)
                //{
                //    MessageBox.Show("La fecha de cancelación no puede ser menor a la fecha actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                CobranzaBE CobranzaBE = new CobranzaBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdCobranza = txtIdCobranza.Text,
                    dtValuta = dtRegistro.Value,
                    dtRegistro = General.General.gFechaOp, //dtRegistro.Value,
                    IdTipoCobranza_tt = "00055", //Cobranza por Pagadora
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    nTotal = String.IsNullOrEmpty(txtTotalImp.Text.Trim()) ? 0 : Convert.ToDecimal(txtTotalImp.Text),
                    DatosAdicionales = txtDatosAdicionales.Text
                };

                DataSet dsCobranza = new DataSet();
                dsCobranza = CobranzaBL.ProcesarCobranza(CobranzaBE);

                if (dsCobranza.Tables[0].Rows.Count > 0)
                {

                    this.txtIdCobranza.Text = dsCobranza.Tables[0].Rows[0]["IdCobranza"].ToString();

                    /* Elimina si existe una Cobranza */
                    CobranzaDetalleBE oCobranzaDetBE = new CobranzaDetalleBE()
                    {
                        USUARIO = General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdCobranza = dsCobranza.Tables[0].Rows[0]["IdCobranza"].ToString(),
                        sdFechaOp = General.General.gFechaOp
                    };
                    CobranzaDetalleBL.ProcesarCobranzaDetalle(oCobranzaDetBE);

                    /* Documentos */
                    foreach (var item in LstCobranzaDetalle)
                    {
                        item.USUARIO = General.General.GetCodigoUsuario;
                        item.OPCION = 2;
                        item.IdPagadora = txtIdPagadora.Text;
                        item.IdCobranza = dsCobranza.Tables[0].Rows[0]["IdCobranza"].ToString();
                        item.nvImporte = item.nvImporte;
                        item.sdFechaOp = General.General.gFechaOp;
                        item.IdLote = item.IdLote;
                        item.cItem = item.cItem;
                        CobranzaDetalleBL.ProcesarCobranzaDetalle(item);
                    }

                    /* Depositos */
                    CobranzaPagoBE CobranzaPagoBE = new CobranzaPagoBE()
                    {
                        USUARIO = General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdCobranza = dsCobranza.Tables[0].Rows[0]["IdCobranza"].ToString(),
                    };
                    new CobranzaPagoBL().ProcesarCobranzaPago(CobranzaPagoBE);

                    foreach (CobranzaPagoBE oEntity in LstCobranzaPago)
                    {
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.OPCION = 2;
                        oEntity.IdCobranza = dsCobranza.Tables[0].Rows[0]["IdCobranza"].ToString();
                        new CobranzaPagoBL().ProcesarCobranzaPago(oEntity);
                    }

                    /* PEGAR EN CONFIRMACION DE COBRANZA */
                    /* Inserta cobranza en Core Bancario */

                    ////foreach (var item in LstCobranzaDetalle)
                    ////{
                    ////    item.USUARIO = General.General.GetCodigoUsuario;
                    ////    item.OPCION = 5;
                    ////    item.IdPagadora = txtIdPagadora.Text;
                    ////    item.IdCobranza = dsCobranza.Tables[0].Rows[0]["IdCobranza"].ToString();
                    ////    item.nvImporte = item.nvImporte;
                    ////    item.sdFechaOp = General.General.gFechaOp;
                    ////    item.gSesionID = General.General.gSesionID;
                    ////    item.gPlazaID = General.General.gPlazaID;
                    ////    item.valorMonedaID = iMonedaID;
                    ////    item.IdSocio = item.IdSocio;
                    ////    item.socioBancoID = this.socioBancoID;
                    ////    item.ctasBancariaID = cboCtasBancariasID.SelectedValue.ToString();
                    ////    item.IdLote = item.IdLote;
                    ////    item.cItem = item.cItem;                        
                    ////    CobranzaDetalleBL.ProcesarCobranzaDetalle(item);
                    ////}

                }

                this.btnImprimir.PerformClick();
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdMoneda_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarDet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboIdMoneda_tt.SelectedValue.ToString().Trim()))
            {
                MessageBox.Show("Debe seleccionar una modena.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboIdMoneda_tt.Focus();
                return;
            }

            frmCobranzaPagadoraDocumentos ofrmCobranzaPagadoraDocumentos = new frmCobranzaPagadoraDocumentos();
            ofrmCobranzaPagadoraDocumentos.Tipo = "P";
            ofrmCobranzaPagadoraDocumentos.IdEntidad = txtIdPagadora.Text;
            ofrmCobranzaPagadoraDocumentos.NombreEntidad = txtDescripcion.Text;
            ofrmCobranzaPagadoraDocumentos.IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString();
            ofrmCobranzaPagadoraDocumentos.ShowDialog();

            DataSet dsDetaLote = new DataSet();
            foreach (var item in ofrmCobranzaPagadoraDocumentos.LstEntidadTmpLote)
            {
                DetaLoteBE DetaLoteBE = new DetaLoteBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = txtIdPagadora.Text,
                    IdSocio = string.IsNullOrEmpty(item.IdEntidadSel) ? "xxxx" : item.IdEntidadSel,
                    IdDocumento = item.CodDocumento,
                    cNumDoc = item.NumDocumento,
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    IdLote = item.IdLote,
                    cItem = item.cItem
                };
                dsDetaLote = DetaLoteBL.ProcesarDetaLote(DetaLoteBE);

                if (dsDetaLote.Tables[0].Rows.Count > 0)
                {
                    CobranzaDetalleBE oCobranzaDetalleBE = new CobranzaDetalleBE()
                    {
                        IdLote = dsDetaLote.Tables[0].Rows[0]["IdLote"].ToString(),
                        cItem = dsDetaLote.Tables[0].Rows[0]["Item"].ToString(),
                        IdDocumento = dsDetaLote.Tables[0].Rows[0]["IdDocumento"].ToString(),
                        IdSocio = dsDetaLote.Tables[0].Rows[0]["IdSocio"].ToString(),
                        IdSocio_Dsc = dsDetaLote.Tables[0].Rows[0]["IdSocio_Dsc"].ToString(),
                        vDocumento = dsDetaLote.Tables[0].Rows[0]["vDocumento"].ToString(),
                        cNumDoc = dsDetaLote.Tables[0].Rows[0]["cNumDoc"].ToString(),
                        sdRecepcion = DateTime.Parse(dsDetaLote.Tables[0].Rows[0]["sdRecepcion"].ToString()),
                        nvNominal = Decimal.Parse(dsDetaLote.Tables[0].Rows[0]["nvNominal"].ToString()),
                        nvNegociable = Decimal.Parse(dsDetaLote.Tables[0].Rows[0]["nvNegociable"].ToString()),
                        nvMontoCobrar = Decimal.Parse(dsDetaLote.Tables[0].Rows[0]["nvMontoCobrar"].ToString()),
                        nvImporte = Decimal.Parse(dsDetaLote.Tables[0].Rows[0]["nvMontoCobrar"].ToString()),
                        sdVencimiento = DateTime.Parse(dsDetaLote.Tables[0].Rows[0]["sdVencimiento"].ToString()),
                        nTazaActiva = decimal.Parse(dsDetaLote.Tables[0].Rows[0]["nTazaActiva"].ToString()),
                        nPorFondoGarantia = decimal.Parse(dsDetaLote.Tables[0].Rows[0]["nPorFondoGarantia"].ToString()),
                        nDias = Convert.ToInt32((DateTime.Parse(dsDetaLote.Tables[0].Rows[0]["sdVencimiento"].ToString()) - DateTime.Parse(dsDetaLote.Tables[0].Rows[0]["sdRecepcion"].ToString())).TotalDays),
                        DifCobrada = 0,
                        DiasMora = 0,
                        Interes = 0,
                        Garantia = decimal.Parse(dsDetaLote.Tables[0].Rows[0]["nFondoGarantia"].ToString()) * - 1,
                    };

                    // Validar
                    bool IsVal = true;
                    foreach (var oCobranzaDet in LstCobranzaDetalle)
                    {
                        if (oCobranzaDet.IdSocio == oCobranzaDetalleBE.IdSocio && oCobranzaDet.IdDocumento == oCobranzaDetalleBE.IdDocumento && oCobranzaDet.cNumDoc == oCobranzaDetalleBE.cNumDoc)
                        {
                            IsVal = false;
                            MessageBox.Show("El documento " + oCobranzaDet.cNumDoc.Trim() + " ya existe, seleccione otro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    if (IsVal) { LstCobranzaDetalle.Add(oCobranzaDetalleBE); }
                } 
            }
            dgvDocumentos.DataSource = LstCobranzaDetalle;
            
            Decimal AcnvImporte = 0;
            int Index = 0;
            foreach (DataGridViewRow row in dgvDocumentos.Rows)
            {
                dgvDocumentos_CellEndEdit(new object(), new DataGridViewCellEventArgs(14, Index));
                AcnvImporte += (Decimal)row.Cells["nvImporte"].Value;
                Index += 1;
            }
            txtTotalImp.Text = AcnvImporte.ToString("N2");
        }

        private void btnQuitarDet_Click(object sender, EventArgs e)
        {
            if (dgvDocumentos.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Está Ud. seguro de eliminar el Socio " + dgvDocumentos.CurrentRow.Cells["IdSocio_Dsc"].Value.ToString().Trim() + " - " + dgvDocumentos.CurrentRow.Cells["vDocumento"].Value.ToString().Trim() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int index = dgvDocumentos.CurrentRow.Index;
                    LstCobranzaDetalle.RemoveAt(index);
                    dgvDocumentos.DataSource = LstCobranzaDetalle;
                    TotalizarImporteDoc();
                }
            }
        }

        private void txtIdPagadora_TextChanged(object sender, EventArgs e)
        {
            btnAgregarDet.Enabled = false;

            if (txtIdPagadora.Text.Trim().Length > 0)
            {
                btnAgregarDet.Enabled = true;
            }
        }

        private void txtnTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtnTotal.Text);
        }

        private void btnDepositosXAplicar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cboIdMoneda_tt.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un tipo de moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int iMonedaID = cboIdMoneda_tt.SelectedValue.Equals("00036") ? 1 : 2;
            List<CobranzaPagoBE> lstRetBus = new List<CobranzaPagoBE>();
            if (cboTipoDeposito.SelectedIndex == 0)
            {
                frmDespositosXAplicar ofrmDespositosXAplicar = new frmDespositosXAplicar();
                ofrmDespositosXAplicar._IdPagadora = txtIdPagadora.Text;
                ofrmDespositosXAplicar._Opcion = 3;
                ofrmDespositosXAplicar._pvalorMonedaID = iMonedaID;
                ofrmDespositosXAplicar.ShowDialog();
                if (ofrmDespositosXAplicar.LstTmpCobranzaPago != null && ofrmDespositosXAplicar.LstTmpCobranzaPago.Count() > 0)
                {
                    lstRetBus = ofrmDespositosXAplicar.LstTmpCobranzaPago.ToList();
                }
            }
            else
            {
                EfideFactoring.Formula.Consulta.frmBusquedaCtaAhorros frmBusAho = new EfideFactoring.Formula.Consulta.frmBusquedaCtaAhorros(2, 1, 1, null, null, iMonedaID);
                frmBusAho.ShowDialog();
                if (frmBusAho.fbcsNumCuentaID != null && frmBusAho.fbcsNumCuentaID.Trim().Length >= 15)
                {
                    CobranzaPagoBE oEntity = new CobranzaPagoBE()
                    {
                        ctasBancariaID = frmBusAho.fbcsNumCuentaID,
                        ctasBanNumCta = frmBusAho.fbcsProdNombre,
                        IdOperacion_tt = "00157",
                        IdOperacion_tt_Dsc = "Cuenta de Ahorro",
                        nTotal = Convert.ToDecimal(0),
                        IdTipoAbono_tt = "00158",
                        IdTipoAbono_tt_Dsc = "Ahorros",
                        socioBancoID = frmBusAho.fbcsNumCuentaID,
                        jSaldo = frmBusAho.fbcsSaldoTotal,
                        jImporte = frmBusAho.fbcsSaldoTotal,
                    };
                    lstRetBus.Add(oEntity);
                }
            }
            bool bExiste = false;
            foreach (CobranzaPagoBE oCobranzaPagoTmpBE in lstRetBus)
            {
                bExiste = false;
                foreach (CobranzaPagoBE oCobranzaPagoBE in LstCobranzaPago)
                {
                    if (oCobranzaPagoTmpBE.socioBancoID == oCobranzaPagoBE.socioBancoID)
                    {
                        bExiste = true;
                        break;
                    }
                }

                if (!bExiste)
                {
                    LstCobranzaPago.Add(oCobranzaPagoTmpBE);
                    dgvDepositos.DataSource = LstCobranzaPago;
                    dgvDepositos.Refresh();
                }
            }

            TotalizarDepositos();
            TotalizarImporteDoc();
            //if (string.IsNullOrEmpty(cboIdMoneda_tt.SelectedValue.ToString()))
            //{
            //    MessageBox.Show("Debe seleccionar un tipo de moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //int iMonedaID = cboIdMoneda_tt.SelectedValue.Equals("00036") ? 1 : 2;
            //frmDespositosXAplicar ofrmDespositosXAplicar = new frmDespositosXAplicar();
            //ofrmDespositosXAplicar._IdPagadora = txtIdPagadora.Text;
            //ofrmDespositosXAplicar._Opcion = 1;
            //ofrmDespositosXAplicar._pvalorMonedaID = iMonedaID;
            //ofrmDespositosXAplicar.ShowDialog();

            //bool bExiste = false;
            //foreach (CobranzaPagoBE oCobranzaPagoTmpBE in ofrmDespositosXAplicar.LstTmpCobranzaPago)
            //{
            //    bExiste = false;
            //    foreach (CobranzaPagoBE oCobranzaPagoBE in LstCobranzaPago)
            //    {
            //        if (oCobranzaPagoTmpBE.socioBancoID == oCobranzaPagoBE.socioBancoID)
            //        {
            //            bExiste = true;
            //            break;
            //        }
            //    }

            //    if (!bExiste)
            //    {
            //        LstCobranzaPago.Add(oCobranzaPagoTmpBE);
            //        dgvDepositos.DataSource = LstCobranzaPago;
            //        dgvDepositos.Refresh();
            //    }
            //}
            //TotalizarDepositos();
            ////txtSaltoXAplicar.Text = ofrmDespositosXAplicar._Saldo.ToString("N2");
            ////txtnTotal.Text = ofrmDespositosXAplicar._Saldo.ToString("N2");
            ////cboIdMoneda_tt.SelectedValue = ofrmDespositosXAplicar._valorMonedaID.ToString() == "1" ? "00036" : "00037";
            ////txtIdMoneda_tt.Text = cboIdMoneda_tt.Text;
            ////if (!string.IsNullOrEmpty(ofrmDespositosXAplicar._ctasBancariaID.ToString())) 
            ////{ 
            ////    cboIdOperacion_tt.SelectedValue = "00048"; 
            ////    cboCtasBancariasID.Enabled = false; 
            ////    cboIdTipoAbono_tt.Enabled = false; 
            ////} else
            ////{ 
            ////    cboIdOperacion_tt.SelectedValue = "00049"; 
            ////    cboIdTipoAbono_tt.Enabled = true; 
            ////}
            ////cboIdMoneda_tt_SelectedIndexChanged(null, null);
            ////cboCtasBancariasID.SelectedValue = ofrmDespositosXAplicar._ctasBancariasID.ToString();
            ////txtCtasBancariasID.Text = cboCtasBancariasID.Text;
            ////string TipoAbono = ofrmDespositosXAplicar._valorTipoMpagoID.ToString();
            ////string Table_TipoAbono = string.Empty;
            ////if (TipoAbono.Equals("1"))
            ////{
            ////    Table_TipoAbono = "00052"; //Transferencia
            ////}
            ////else if (TipoAbono.Equals("2"))
            ////{
            ////    Table_TipoAbono = "00051"; //Efectivo
            ////}
            ////else if (TipoAbono.Equals("3"))
            ////{
            ////    Table_TipoAbono = "00053"; //Cheque
            ////}
            ////cboIdTipoAbono_tt.SelectedValue = Table_TipoAbono;
            ////txtIdTipoAbono_tt.Text = cboIdTipoAbono_tt.Text;
            ////this.socioBancoID = ofrmDespositosXAplicar._socioBancoID;
            ////txtIdOperacion_tt.Text = cboIdOperacion_tt.Text;
        }

        private void btnQuitarDepositos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepositos.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Está Ud. seguro de eliminar el deposito de " + dgvDepositos.CurrentRow.Cells["nTotal"].Value.ToString().Trim() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int index = dgvDepositos.CurrentRow.Index;
                        LstCobranzaPago.RemoveAt(index);
                        dgvDepositos.DataSource = LstCobranzaPago;
                        TotalizarDepositos();
                        TotalizarImporteDoc();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocumentos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TotalizarImporteDoc();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalizarImporteDoc()
        {
            try
            {
                Decimal AcnvImporte = 0;
                foreach (DataGridViewRow row in dgvDocumentos.Rows)
                {
                    AcnvImporte = AcnvImporte + (Decimal)row.Cells["nvImporte"].Value;
                }
                txtTotalImp.Text = AcnvImporte.ToString("N2");
                decimal SaldoAplicar = string.IsNullOrEmpty(lblSaltoXAplicar.Text)? 0 : Convert.ToDecimal(lblSaltoXAplicar.Text.ToString());
                lblDiferencia.Text = (SaldoAplicar - AcnvImporte).ToString("N2");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalizarDepositos()
        {
            try
            {
                Decimal AcDeposito = 0;
                foreach (DataGridViewRow row in dgvDepositos.Rows)
                {
                    
                    decimal Deposito = string.IsNullOrEmpty(row.Cells["nTotal"].Value.ToString()) ? 0 : (Decimal)row.Cells["nTotal"].Value;
                    AcDeposito = AcDeposito + Deposito;
                    
                }
                lblSaltoXAplicar.Text = AcDeposito.ToString("N2");
                decimal ImporteTotal = string.IsNullOrEmpty(txtnTotal.Text) ? 0 : Convert.ToDecimal(txtnTotal.Text.ToString());
                lblDiferencia.Text = (AcDeposito - ImporteTotal).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos
        private void CargarDatos()
        {
            try
            {
                DataSet dsCobranza = new DataSet();
                CobranzaBE CobranzaBE = new CobranzaBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdCobranza = txtIdCobranza.Text,
                };
                
                dsCobranza = CobranzaBL.ProcesarCobranza(CobranzaBE);

                if (dsCobranza.Tables[0].Rows.Count > 0)
                {
                    txtIdPagadora.Text = dsCobranza.Tables[0].Rows[0]["IdPagadora"].ToString();
                    txtDescripcion.Text = dsCobranza.Tables[0].Rows[0]["IdPagadora_Dsc"].ToString();
                    //dtRegistro.Value = Convert.ToDateTime(dsCobranza.Tables[0].Rows[0]["dtRegistro"].ToString());
                    dtRegistro.Value = Convert.ToDateTime(dsCobranza.Tables[0].Rows[0]["dtValuta"].ToString());
                    cboIdMoneda_tt.SelectedValue = dsCobranza.Tables[0].Rows[0]["IdMoneda_tt"].ToString();
                    cboIdMoneda_tt_SelectedIndexChanged(new object(), new EventArgs());
                    txtnTotal.Text = Convert.ToDecimal(dsCobranza.Tables[0].Rows[0]["nTotal"]).ToString("N2");
                    txtDatosAdicionales.Text = dsCobranza.Tables[0].Rows[0]["DatosAdicionales"].ToString();
                    lblSaltoXAplicar.Text = Convert.ToDecimal(dsCobranza.Tables[0].Rows[0]["nTotal"]).ToString("N2");
                    lblDiferencia.Text = (Convert.ToDecimal(dsCobranza.Tables[0].Rows[0]["nTotal"]) - Convert.ToDecimal(dsCobranza.Tables[0].Rows[0]["nTotal"])).ToString("N2");
                    txtStatus.Text = dsCobranza.Tables[0].Rows[0]["Status"].ToString();

                    if (dsCobranza.Tables[0].Rows[0]["Status"].ToString() == "C")
                    {
                        btnDepositosXAplicar.Enabled = false;
                        btnQuitarDepositos.Enabled = false;
                        btnAgregarDet.Enabled = false;
                        btnQuitarDet.Enabled = false;
                        btnAceptar.Enabled = false;
                        dtRegistro.Enabled = false;
                    }

                    DataSet dsDetaLote = new DataSet();
                    CobranzaDetalleBE oCobranzaDetalleBE = new CobranzaDetalleBE()
                    {
                        OPCION = 1,
                        USUARIO = General.General.GetCodigoUsuario,
                        sdFechaOp = General.General.gFechaOp,
                        gSesionID = General.General.gSesionID,
                        gPlazaID = General.General.gPlazaID,
                        IdCobranza = txtIdCobranza.Text,
                    };
                    dsDetaLote = CobranzaDetalleBL.ProcesarCobranzaDetalle(oCobranzaDetalleBE);
                    if (dsDetaLote.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < dsDetaLote.Tables[0].Rows.Count; i++)
                        {
                            CobranzaDetalleBE oCobranzadetBE = new CobranzaDetalleBE()
                            {
                                IdLote = dsDetaLote.Tables[0].Rows[i]["IdLote"].ToString(),
                                IdDocumento = dsDetaLote.Tables[0].Rows[i]["IdDocumento"].ToString(),
                                cItem = dsDetaLote.Tables[0].Rows[i]["cItem"].ToString(),
                                IdSocio = dsDetaLote.Tables[0].Rows[i]["IdSocio"].ToString(),
                                IdSocio_Dsc = dsDetaLote.Tables[0].Rows[i]["IdSocio_Dsc"].ToString(),
                                vDocumento = dsDetaLote.Tables[0].Rows[i]["vDocumento"].ToString(),
                                cNumDoc = dsDetaLote.Tables[0].Rows[i]["cNumDoc"].ToString(),
                                nvNominal = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["nvNominal"].ToString()),
                                IdPagadora = dsDetaLote.Tables[0].Rows[i]["IdPagadora"].ToString(),
                                IdPagadora_Dsc = dsDetaLote.Tables[0].Rows[i]["IdPagadora_Dsc"].ToString(),
                                nvImporte = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["nvImporte"].ToString()),
                                nvNegociable = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["nvNegociable"].ToString()),
                                nvMontoCobrar = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["nvMontoCobrar"].ToString()),
                                sdRecepcion = DateTime.Parse(dsDetaLote.Tables[0].Rows[i]["sdRecepcion"].ToString()),
                                sdVencimiento = DateTime.Parse(dsDetaLote.Tables[0].Rows[i]["sdVencimiento"].ToString()),
                                nTazaActiva = decimal.Parse(dsDetaLote.Tables[0].Rows[i]["nTazaActiva"].ToString()),
                                nPorFondoGarantia = decimal.Parse(dsDetaLote.Tables[0].Rows[i]["nPorFondoGarantia"].ToString()),
                                nDias = Convert.ToInt32((DateTime.Parse(dsDetaLote.Tables[0].Rows[i]["sdVencimiento"].ToString()) - DateTime.Parse(dsDetaLote.Tables[0].Rows[i]["sdRecepcion"].ToString())).TotalDays),
                                DifCobrada = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["DifCobrada"].ToString()),
                                DiasMora = int.Parse(dsDetaLote.Tables[0].Rows[i]["DiasMora"].ToString()),
                                Interes = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["Interes"].ToString()),
                                Garantia = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["Garantia"].ToString()),
                            };
                            LstCobranzaDetalle.Add(oCobranzadetBE);
                        }
                        dgvDocumentos.DataSource = LstCobranzaDetalle;
                        TotalizarImporteDoc();
                    }

                    DataSet dsCobranzaPago = new DataSet();
                    CobranzaPagoBE oCobranzaPagoBE = new CobranzaPagoBE()
                    {
                        OPCION = 1,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdCobranza = txtIdCobranza.Text,
                    };
                    dsCobranzaPago = new CobranzaPagoBL().ProcesarCobranzaPago(oCobranzaPagoBE);

                    foreach (DataRow row in dsCobranzaPago.Tables[0].Rows)
                    {
                        CobranzaPagoBE oEntity = new CobranzaPagoBE()
                        {
                            IdCobranza = row["IdCobranza"].ToString(),
                            socioBancoID = row["socioBancoID"].ToString(),
                            ctasBancariaID = row["ctasBancariaID"].ToString(),
                            ctasBanNumCta = row["ctasBanNumCta"].ToString(),
                            jImporte = decimal.Parse(row["jImporte"].ToString()),
                            jSaldo = decimal.Parse(row["jSaldo"].ToString()),
                            nTotal = decimal.Parse(row["nTotal"].ToString()),
                            IdOperacion_tt = row["IdOperacion_tt"].ToString(),
                            IdOperacion_tt_Dsc = row["IdOperacion_tt_Dsc"].ToString(),
                            IdTipoAbono_tt = row["IdTipoAbono_tt"].ToString(),
                            IdTipoAbono_tt_Dsc = row["IdTipoAbono_tt_Dsc"].ToString(),
                        };
                        LstCobranzaPago.Add(oEntity);
                        dgvDepositos.DataSource = LstCobranzaPago;
                    }

                    TotalizarDepositos();
                    TotalizarImporteDoc();
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
                String Table_Id = "00035";
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdMoneda_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                String strIdCobranza = txtIdCobranza.Text.Trim();
                if (string.IsNullOrEmpty(strIdCobranza))
                {
                    if (!GrabarCobranza()) { return; };
                    strIdCobranza = txtIdCobranza.Text.Trim();
                }
                DataSet dsCobranza = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("Rpt_CobranzaP_Cab", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@IdCobranza", strIdCobranza);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsCobranza, "Rpt_CobranzaP_Cab");

                    SqlCommand cmd2 = new SqlCommand("Rpt_CobranzaP_Det", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@IdCobranza", strIdCobranza);
                    SqlDataAdapter daDet = new SqlDataAdapter(cmd2);
                    daDet.Fill(dsCobranza, "Rpt_CobranzaP_Det");

                    SqlCommand cmd3 = new SqlCommand("Rpt_CobranzaPago", con);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@IdCobranza", strIdCobranza);
                    SqlDataAdapter daDet2 = new SqlDataAdapter(cmd3);
                    daDet2.Fill(dsCobranza, "Rpt_CobranzaPago");

                    con.Close();
                }

                if (txtStatus.Text.Equals("C"))
                {
                    Crystal.crRptCobranzaPagadora ocrLoteLiquidacion = new Crystal.crRptCobranzaPagadora();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsCobranza);
                    ocrLoteLiquidacion.SetParameterValue("FechaCancelacion", dtRegistro.Value.ToString("d"));
                    ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
                else
                {
                    Crystal.crRptCobranzaPagadoraPrevio ocrLoteLiquidacion = new Crystal.crRptCobranzaPagadoraPrevio();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsCobranza);
                    ocrLoteLiquidacion.SetParameterValue("FechaCancelacion", dtRegistro.Value.ToString("d"));
                    ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GrabarCobranza()
        {
            bool bResult = false;
            try
            {
                TotalizarImporteDoc();
                Decimal Total = string.IsNullOrEmpty(lblSaltoXAplicar.Text) ? 0 : Convert.ToDecimal(lblSaltoXAplicar.Text);
                Decimal AcImporteTotal = string.IsNullOrEmpty(txtTotalImp.Text) ? 0 : Convert.ToDecimal(txtTotalImp.Text);

                if (AcImporteTotal != Total)
                {
                    MessageBox.Show("La distribución del depósito debe ser igual que el importe del depósito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (dtRegistro.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Se debe ingresar una fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                CobranzaBE CobranzaBE = new CobranzaBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdCobranza = txtIdCobranza.Text,
                    dtRegistro = General.General.gFechaOp, //dtRegistro.Value,
                    dtValuta = dtRegistro.Value,
                    IdTipoCobranza_tt = "00055", //Cobranza por Pagadora
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    nTotal = String.IsNullOrEmpty(txtnTotal.Text.Trim()) ? 0 : Convert.ToDecimal(txtnTotal.Text),
                    DatosAdicionales = txtDatosAdicionales.Text,
                };

                DataSet dsCobranza = new DataSet();
                dsCobranza = CobranzaBL.ProcesarCobranza(CobranzaBE);

                if (dsCobranza.Tables[0].Rows.Count > 0)
                {
                    this.txtIdCobranza.Text = dsCobranza.Tables[0].Rows[0]["IdCobranza"].ToString();

                    /* Elimina si existe una Cobranza */
                    CobranzaDetalleBE oCobranzaDetBE = new CobranzaDetalleBE()
                    {
                        USUARIO = General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdCobranza = dsCobranza.Tables[0].Rows[0]["IdCobranza"].ToString(),
                        sdFechaOp = General.General.gFechaOp
                    };
                    CobranzaDetalleBL.ProcesarCobranzaDetalle(oCobranzaDetBE);

                    /* Documentos */
                    foreach (var item in LstCobranzaDetalle)
                    {
                        item.USUARIO = General.General.GetCodigoUsuario;
                        item.OPCION = 2;
                        item.IdPagadora = txtIdPagadora.Text;
                        item.IdCobranza = dsCobranza.Tables[0].Rows[0]["IdCobranza"].ToString();
                        item.nvImporte = item.nvImporte;
                        item.sdFechaOp = General.General.gFechaOp;
                        item.IdLote = item.IdLote;
                        item.cItem = item.cItem;
                        CobranzaDetalleBL.ProcesarCobranzaDetalle(item);
                    }

                    /* Depositos */
                    CobranzaPagoBE CobranzaPagoBE = new CobranzaPagoBE()
                    {
                        USUARIO = General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdCobranza = dsCobranza.Tables[0].Rows[0]["IdCobranza"].ToString(),
                    };
                    new CobranzaPagoBL().ProcesarCobranzaPago(CobranzaPagoBE);

                    foreach (CobranzaPagoBE oEntity in LstCobranzaPago)
                    {
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.OPCION = 2;
                        oEntity.IdCobranza = dsCobranza.Tables[0].Rows[0]["IdCobranza"].ToString();
                        new CobranzaPagoBL().ProcesarCobranzaPago(oEntity);
                    }
                    bResult =  true;
                }
            }
            catch (Exception ex)
            {
                bResult = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bResult;
        }


        private void dgvDocumentos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DateTime dtCobranza = DateTime.Parse(txtdtRegistro.Text);
                DateTime dtCobranza = dtRegistro.Value;
                DateTime dtVencimiento = DateTime.Parse(dgvDocumentos.Rows[e.RowIndex].Cells["sdVencimiento"].Value.ToString());
                decimal VMontoCobrar = string.IsNullOrEmpty(dgvDocumentos.Rows[e.RowIndex].Cells["nvMontoCobrar"].Value.ToString()) ? 0 : decimal.Parse(dgvDocumentos.Rows[e.RowIndex].Cells["nvMontoCobrar"].Value.ToString());
                decimal VNegociable = string.IsNullOrEmpty(dgvDocumentos.Rows[e.RowIndex].Cells["nvNegociable"].Value.ToString()) ? 0 : decimal.Parse(dgvDocumentos.Rows[e.RowIndex].Cells["nvNegociable"].Value.ToString());
                decimal VnvNominal = string.IsNullOrEmpty(dgvDocumentos.Rows[e.RowIndex].Cells["nvNominal"].Value.ToString()) ? 0 : decimal.Parse(dgvDocumentos.Rows[e.RowIndex].Cells["nvNominal"].Value.ToString());
                decimal VImporte = string.IsNullOrEmpty(dgvDocumentos.Rows[e.RowIndex].Cells["nvImporte"].Value.ToString()) ? 0 : decimal.Parse(dgvDocumentos.Rows[e.RowIndex].Cells["nvImporte"].Value.ToString());
                decimal VPorFG = string.IsNullOrEmpty(dgvDocumentos.Rows[e.RowIndex].Cells["nPorFondoGarantia"].Value.ToString()) ? 0 : decimal.Parse(dgvDocumentos.Rows[e.RowIndex].Cells["nPorFondoGarantia"].Value.ToString());
                decimal Tasa = string.IsNullOrEmpty(dgvDocumentos.Rows[e.RowIndex].Cells["nTazaActiva"].Value.ToString()) ? 0 : decimal.Parse(dgvDocumentos.Rows[e.RowIndex].Cells["nTazaActiva"].Value.ToString());
                TimeSpan ts = dtCobranza.Date - dtVencimiento.Date;
                decimal DiasMora  = ts.Days;
                int nDias = string.IsNullOrEmpty(dgvDocumentos.Rows[e.RowIndex].Cells["nDias"].Value.ToString()) ? 0 : int.Parse(dgvDocumentos.Rows[e.RowIndex].Cells["nDias"].Value.ToString());
                dgvDocumentos.Rows[e.RowIndex].Cells["DifCobrada"].Value = VMontoCobrar - VImporte;
                dgvDocumentos.Rows[e.RowIndex].Cells["DiasMora"].Value = DiasMora;
                //dgvDocumentos.Rows[e.RowIndex].Cells["Garantia"].Value = (VnvNominal * (VPorFG /100))*-1;

                if (DiasMora > 0)
                {
                    // Interes vencido
                    double Interes100 = Convert.ToDouble((Tasa / 100) + 1);
                    double Dias360 = Convert.ToDouble(DiasMora / 360);
                    double Interes = ((Math.Pow(Interes100, Dias360)) - 1) * Convert.ToDouble(VNegociable);
                    dgvDocumentos.Rows[e.RowIndex].Cells["Interes"].Value = Math.Round(Convert.ToDecimal(Interes),2);
                }

                else if (DiasMora < 0)
                {
                    // Interes adelantado
                    double Interes100 = Convert.ToDouble(1+(Tasa / 100));
                    double Dias360 = Convert.ToDouble(Math.Abs(DiasMora) / 360);

                    double Interes = (1 - (1 / (Math.Pow(Interes100, Dias360)))) * Convert.ToDouble(VNegociable) * (-1);
                    dgvDocumentos.Rows[e.RowIndex].Cells["Interes"].Value = Math.Round(Convert.ToDecimal(Interes),2);
                }
                else
                {
                    dgvDocumentos.Rows[e.RowIndex].Cells["Interes"].Value = Convert.ToDecimal(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvDocumentos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                if (e.Control is TextBox)
                {
                    if (object.ReferenceEquals(dgvDocumentos.CurrentCell.ValueType, typeof(System.Decimal)))
                    {
                        TextBox txt = e.Control as TextBox;
                        txt.KeyPress += nvImporte_KeyPress;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void nvImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void dtRegistro_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dtCobranza = dtRegistro.Value;
                foreach (DataGridViewRow row in dgvDocumentos.Rows)
                {
                    dgvDocumentos_CellEndEdit(new object(), new DataGridViewCellEventArgs(1, row.Index));
                    /*
                    DateTime dtVencimiento = DateTime.Parse(row.Cells["sdVencimiento"].Value.ToString());
                    decimal VMontoCobrar = string.IsNullOrEmpty(row.Cells["nvMontoCobrar"].Value.ToString()) ? 0 : decimal.Parse(row.Cells["nvMontoCobrar"].Value.ToString());
                    decimal VNegociable = string.IsNullOrEmpty(row.Cells["nvNegociable"].Value.ToString()) ? 0 : decimal.Parse(row.Cells["nvNegociable"].Value.ToString());
                    decimal VnvNominal = string.IsNullOrEmpty(row.Cells["nvNominal"].Value.ToString()) ? 0 : decimal.Parse(row.Cells["nvNominal"].Value.ToString());
                    decimal VImporte = string.IsNullOrEmpty(row.Cells["nvImporte"].Value.ToString()) ? 0 : decimal.Parse(row.Cells["nvImporte"].Value.ToString());
                    decimal VPorFG = string.IsNullOrEmpty(row.Cells["nPorFondoGarantia"].Value.ToString()) ? 0 : decimal.Parse(row.Cells["nPorFondoGarantia"].Value.ToString());
                    decimal Tasa = string.IsNullOrEmpty(row.Cells["nTazaActiva"].Value.ToString()) ? 0 : decimal.Parse(row.Cells["nTazaActiva"].Value.ToString());
                    TimeSpan ts = dtCobranza.Date - dtVencimiento.Date;
                    decimal DiasMora = ts.Days;
                    int nDias = string.IsNullOrEmpty(row.Cells["nDias"].Value.ToString()) ? 0 : int.Parse(row.Cells["nDias"].Value.ToString());
                    row.Cells["DifCobrada"].Value = VMontoCobrar - VImporte;
                    row.Cells["DiasMora"].Value = DiasMora;

                    if (DiasMora > 0)
                    {
                        // Interes vencido
                        double Interes100 = Convert.ToDouble((Tasa / 100) + 1);
                        double Dias360 = Convert.ToDouble(DiasMora / 360);
                        double Interes = ((Math.Pow(Interes100, Dias360)) - 1) * Convert.ToDouble(VNegociable);
                        row.Cells["Interes"].Value = Math.Round(Convert.ToDecimal(Interes), 2);
                    }

                    else if (DiasMora < 0)
                    {
                        // Interes adelantado
                        double Interes100 = Convert.ToDouble(1 + (Tasa / 100));
                        double Dias360 = Convert.ToDouble(Math.Abs(DiasMora) / 360);
                        double Interes = (1 - (1 / (Math.Pow(Interes100, Dias360)))) * Convert.ToDouble(VNegociable) * (-1);
                        row.Cells["Interes"].Value = Math.Round(Convert.ToDecimal(Interes), 2);
                    }
                    else
                    {
                        row.Cells["Interes"].Value = Convert.ToDecimal(0);
                    }
                     * */
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvDepositos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    Decimal? resDepos = null;
                    try
                    {
                        resDepos = Convert.ToDecimal(dgvDepositos[e.ColumnIndex, e.RowIndex].Value);
                    }
                    catch
                    {

                        dgvDepositos[e.ColumnIndex, e.RowIndex].Value = dgvDepositos[6, e.RowIndex].Value;
                    }

                    if (Convert.ToDecimal(dgvDepositos[6, e.RowIndex].Value) < Convert.ToDecimal(dgvDepositos[e.ColumnIndex, e.RowIndex].Value))
                    {
                        dgvDepositos[e.ColumnIndex, e.RowIndex].Value = dgvDepositos[6, e.RowIndex].Value;
                    }
                    TotalizarDepositos();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
 
        }

        private void cboTipoDeposito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}