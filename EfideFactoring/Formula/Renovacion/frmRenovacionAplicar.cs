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

namespace EfideFactoring.Formula.Renovacion
{
    public partial class frmRenovacionAplicar : FormulaBase.frmMntDato
    {
        BindingList<RenovacionDetBE> LstRenovacionDet = new BindingList<RenovacionDetBE>();
        TableBaseBL TableBaseBL = new TableBaseBL();
        RenovacionBL RenovacionBL = new RenovacionBL();
        RenovacionDetBL RenovacionDetBL = new RenovacionDetBL();
        CobranzaBL CobranzaBL = new CobranzaBL();
        private BindingList<RenovacionPagoBE> LstRenovacionPago = new BindingList<RenovacionPagoBE>();
        private string TipoRenovacion = string.Empty;
        String IdsocioB = null;

        public frmRenovacionAplicar()
        {
            InitializeComponent();
        }

        private void frmRenovacionAplicar_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoDeposito.SelectedIndex = 0;
                LlenarCombos();
                txtIdRenovacion.Text = Codigo;
                CargarDatos();

                dgvDepositos.ReadOnly = false;
                
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
                String Table_Id = "00035"; //Moneda
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdMoneda_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                //TableBaseBE.Table_Parent_Id = "00047";
                //General.General.LlenarCombobox(cboIdOperacion_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
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
                DataSet dsRenovacion = new DataSet();
                RenovacionBE RenovacionBE = new RenovacionBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    gSesionID = General.General.gSesionID,
                    gPlazaID = General.General.gPlazaID,
                    gFechaOp = General.General.gFechaOp,
                    IdRenovacion = txtIdRenovacion.Text.Trim()
                };

                dsRenovacion = RenovacionBL.ProcesarRenovacion(RenovacionBE);

                if (dsRenovacion.Tables[0].Rows.Count > 0)
                {
                    string IdEstado_tt = dsRenovacion.Tables[0].Rows[0]["IdEstado_tt"].ToString();
                    cboIdMoneda_tt.SelectedValue = dsRenovacion.Tables[0].Rows[0]["IdMoneda_tt"].ToString();
                    txtdtRenovacion.Text = dsRenovacion.Tables[0].Rows[0]["dtRenovacion"].ToString();
                    txtIdEntidad.Text = dsRenovacion.Tables[0].Rows[0]["Entidad_Id"].ToString();
                    txtIdEntidad_Dsc.Text = dsRenovacion.Tables[0].Rows[0]["Entidad"].ToString();
                    TipoRenovacion = dsRenovacion.Tables[0].Rows[0]["TipoRenovacion"].ToString();

                    if (TipoRenovacion == "S")
                    {
                        @IdsocioB = txtIdEntidad.Text.Trim();
                        cboTipoDeposito.Enabled = true;
                    }
                    else
                    {
                        cboTipoDeposito.Enabled = false;
                    }

                    DataSet dsDet = new DataSet();
                    RenovacionDetBE RenovacionDetBE = new RenovacionDetBE()
                    {
                        OPCION = 1,
                        USUARIO = General.General.GetCodigoUsuario,
                        gSesionID = General.General.gSesionID,
                        gPlazaID = General.General.gPlazaID,
                        gFechaOp = General.General.gFechaOp,
                        IdRenovacion = txtIdRenovacion.Text,
                    };
                    dsDet = RenovacionDetBL.ProcesarRenovacionDet(RenovacionDetBE);
                    if (dsDet.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < dsDet.Tables[0].Rows.Count; i++)
                        {
                            RenovacionDetBE oRenovacionDetBE = new RenovacionDetBE()
                            {
                                IdRenovacion = dsDet.Tables[0].Rows[i]["IdRenovacion"].ToString(),
                                IdEntidad = dsDet.Tables[0].Rows[i]["IdEntidad"].ToString(),
                                IdEntidad_Dsc = dsDet.Tables[0].Rows[i]["IdEntidad_Dsc"].ToString(),
                                IdLote = dsDet.Tables[0].Rows[i]["IdLote"].ToString(),
                                cItem = dsDet.Tables[0].Rows[i]["cItem"].ToString(),
                                IdDocumento = dsDet.Tables[0].Rows[i]["IdDocumento"].ToString(),
                                cNumDoc = dsDet.Tables[0].Rows[i]["cNumDoc"].ToString(),
                                IdPagadora = dsDet.Tables[0].Rows[i]["IdPagadora"].ToString(),
                                IdSocio = dsDet.Tables[0].Rows[i]["IdSocio"].ToString(),
                                sdVencimiento = !string.IsNullOrEmpty(dsDet.Tables[0].Rows[i]["sdVencimiento"].ToString()) ? DateTime.Parse(dsDet.Tables[0].Rows[i]["sdVencimiento"].ToString()) : DateTime.MinValue,
                                iVencimiento = int.Parse(dsDet.Tables[0].Rows[i]["iVencimiento"].ToString()),
                                nvNominal = Decimal.Parse(dsDet.Tables[0].Rows[i]["nvNominal"].ToString()),
                                nPorAmortizacion = Decimal.Parse(dsDet.Tables[0].Rows[i]["nPorAmortizacion"].ToString()),
                                nvImporteAm = Decimal.Parse(dsDet.Tables[0].Rows[i]["nvImporteAm"].ToString()),
                                nvImporteN = !string.IsNullOrEmpty(dsDet.Tables[0].Rows[i]["nvImporteN"].ToString()) ? decimal.Parse(dsDet.Tables[0].Rows[i]["nvImporteN"].ToString()) : 0,
                                iPlazoVencimientoN = int.Parse(dsDet.Tables[0].Rows[i]["iPlazoVencimientoN"].ToString()),
                                sdVencimientoN = !string.IsNullOrEmpty(dsDet.Tables[0].Rows[i]["sdVencimientoN"].ToString()) ? DateTime.Parse(dsDet.Tables[0].Rows[i]["sdVencimientoN"].ToString()) : DateTime.MinValue,
                                nPorTEA = !string.IsNullOrEmpty(dsDet.Tables[0].Rows[i]["nPorTEA"].ToString()) ? decimal.Parse(dsDet.Tables[0].Rows[i]["nPorTEA"].ToString()) : 0,
                                nGastosAdm = !string.IsNullOrEmpty(dsDet.Tables[0].Rows[i]["nGastosAdm"].ToString()) ? decimal.Parse(dsDet.Tables[0].Rows[i]["nGastosAdm"].ToString()) : 0,
                                nGastosReno = !string.IsNullOrEmpty(dsDet.Tables[0].Rows[i]["nGastosReno"].ToString()) ? decimal.Parse(dsDet.Tables[0].Rows[i]["nGastosReno"].ToString()) : 0,
                                nInteresVencidos = Double.Parse(dsDet.Tables[0].Rows[i]["nInteresVencidos"].ToString()),
                                nInteresReno = Double.Parse(dsDet.Tables[0].Rows[i]["nInteresReno"].ToString()),
                                nImporte = !string.IsNullOrEmpty(dsDet.Tables[0].Rows[i]["nImporte"].ToString()) ? decimal.Parse(dsDet.Tables[0].Rows[i]["nImporte"].ToString()) : 0,
                                IdEstado_tt = dsDet.Tables[0].Rows[i]["IdEstado_tt"].ToString(),
                            };
                            LstRenovacionDet.Add(oRenovacionDetBE);
                        }
                        dgvRenovacionDet.DataSource = LstRenovacionDet;
                        Totalizar();
                    }

                    DataSet dsRenovacionPago = new DataSet();
                    RenovacionPagoBE oRenovacionPagoBE = new RenovacionPagoBE()
                    {
                        OPCION = 1,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdRenovacion = txtIdRenovacion.Text,
                    };
                    dsRenovacionPago = new RenovacionPagoBL().ProcesarRenovacionPago(oRenovacionPagoBE);

                    foreach (DataRow row in dsRenovacionPago.Tables[0].Rows)
                    {
                        RenovacionPagoBE oEntity = new RenovacionPagoBE()
                        {
                            IdRenovacion = row["IdRenovacion"].ToString(),
                            socioBancoID = row["socioBancoID"].ToString(),
                            ctasBancariaID = row["ctasBancariaID"].ToString(),
                            ctasBanNumCta = row["ctasBanNumCta"].ToString(),
                            nTotal = decimal.Parse(row["nTotal"].ToString()),
                            IdOperacion_tt = row["IdOperacion_tt"].ToString(),
                            IdOperacion_tt_Dsc = row["IdOperacion_tt_Dsc"].ToString(),
                            IdTipoAbono_tt = row["IdTipoAbono_tt"].ToString(),
                            IdTipoAbono_tt_Dsc = row["IdTipoAbono_tt_Dsc"].ToString(),
                        };
                        LstRenovacionPago.Add(oEntity);
                        dgvDepositos.DataSource = LstRenovacionPago;
                    }
                    TotalizarDepositos();
                    if (IdEstado_tt != "00111") //Aprobado
                    {
                        btnBuscarPagadora.Enabled = false;
                        btnDepositosXAplicar.Enabled = false;
                        btnQuitarDepositos.Enabled = false;
                        btnAceptar.Enabled = false;
                    }

                    if (IdEstado_tt == "00112") //Renovado
                    {
                        btnImprimir.Visible = true;
                    }

                    
                }
                else
                {
                    MessageBox.Show("Este Grupo no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Totalizar()
        {
            try
            {
                Decimal AcVnominal = 0;
                foreach (var item in LstRenovacionDet)
                {
                    AcVnominal += item.nImporte;
                }
                txtTotal.Text = AcVnominal.ToString("N2");
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
                if (string.IsNullOrEmpty(lblSaltoXAplicar.Text))
                {
                    MessageBox.Show("Debe seleccionar un depósito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Decimal Total = string.IsNullOrEmpty(lblSaltoXAplicar.Text) ? 0 : Convert.ToDecimal(lblSaltoXAplicar.Text);
                Decimal AcImporteTotal = string.IsNullOrEmpty(txtTotal.Text) ? 0 : Convert.ToDecimal(txtTotal.Text);
                if (AcImporteTotal != Total)
                {
                    MessageBox.Show("La distribución del depósito debe ser igual que el importe del depósito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                /* Grabar Depositos */
                RenovacionPagoBE RenovacionPagoBE = new RenovacionPagoBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 3,
                    IdRenovacion = txtdtRenovacion.Text,
                };
                new RenovacionPagoBL().ProcesarRenovacionPago(RenovacionPagoBE);

                foreach (RenovacionPagoBE oEntity in LstRenovacionPago)
                {
                    oEntity.USUARIO = General.General.GetCodigoUsuario;
                    oEntity.OPCION = 2;
                    oEntity.IdRenovacion = txtIdRenovacion.Text;
                    new RenovacionPagoBL().ProcesarRenovacionPago(oEntity);
                }
                //General.General.gFechaOp

                RenovacionBE RenovacionBE = new RenovacionBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    gSesionID = General.General.gSesionID,
                    gPlazaID = General.General.gPlazaID,
                    gFechaOp = General.General.gFechaOp,
                    OPCION = 4,
                    IdRenovacion = txtIdRenovacion.Text,
                };

                DataSet dsRenovacion = new DataSet();
                dsRenovacion = RenovacionBL.ProcesarRenovacion(RenovacionBE);

                Imprimir();
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Imprimir()
        {
            try
            {
                DataSet dsRenovacion = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("Rpt_Renovacion", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.Parameters.AddWithValue("@IdRenovacion", txtIdRenovacion.Text.Trim());
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsRenovacion, "Renovacion");

                    SqlCommand cmd2 = new SqlCommand("Rpt_Renovacion", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@Opcion", 2);
                    cmd2.Parameters.AddWithValue("@IdRenovacion", txtIdRenovacion.Text.Trim());
                    SqlDataAdapter daCab2 = new SqlDataAdapter(cmd2);
                    daCab2.Fill(dsRenovacion, "RenovacionDet1");

                    SqlCommand cmd3 = new SqlCommand("Rpt_Renovacion", con);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@Opcion", 3);
                    cmd3.Parameters.AddWithValue("@IdRenovacion", txtIdRenovacion.Text.Trim());
                    SqlDataAdapter daCab3 = new SqlDataAdapter(cmd3);
                    daCab3.Fill(dsRenovacion, "RenovacionDet2");
                    con.Close();

                    SqlCommand cmd4 = new SqlCommand("Rpt_Renovacion", con);
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@Opcion", 4);
                    cmd4.Parameters.AddWithValue("@IdRenovacion", txtIdRenovacion.Text.Trim());
                    SqlDataAdapter daCab4 = new SqlDataAdapter(cmd4);
                    daCab4.Fill(dsRenovacion, "RenovacionPago");
                    con.Close();
                }

                Crystal.crRptRenovacion ocrRptRenovacion = new Crystal.crRptRenovacion();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrRptRenovacion;
                ocrRptRenovacion.SetDataSource(dsRenovacion);
                ocrRptRenovacion.SetParameterValue("usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.Show();

                //Fondo Garantía
                DataSet dsRenovacionFG = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("Rpt_Renovacion", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.Parameters.AddWithValue("@IdRenovacion", txtIdRenovacion.Text.Trim());
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsRenovacionFG, "Renovacion");

                    SqlCommand cmd4 = new SqlCommand("Rpt_Renovacion", con);
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@Opcion", 5);
                    cmd4.Parameters.AddWithValue("@IdRenovacion", txtIdRenovacion.Text.Trim());
                    SqlDataAdapter daCab4 = new SqlDataAdapter(cmd4);
                    daCab4.Fill(dsRenovacionFG, "RenovacionFG");
                    con.Close();
                }

                if (dsRenovacionFG.Tables["RenovacionFG"].Rows.Count > 0)
                {
                    Crystal.crRptRenovacionFG ocrRptRenovacionFG = new Crystal.crRptRenovacionFG();
                    Reportes.frmVisorLoteLiquidacion ofrm = new Reportes.frmVisorLoteLiquidacion();
                    ofrm.crvVisorLoteLiq.ReportSource = ocrRptRenovacionFG;
                    ocrRptRenovacionFG.SetDataSource(dsRenovacionFG);
                    ocrRptRenovacionFG.SetParameterValue("Usuario", General.General.GetUsuario);
                    ofrm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDepositosXAplicar_Click_1(object sender, EventArgs e)
        {
            try
            {
                 if (string.IsNullOrEmpty(cboIdMoneda_tt.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un tipo de moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int iMonedaID = cboIdMoneda_tt.SelectedValue.Equals("00036") ? 1 : 2;
            BindingList<RenovacionPagoBE> lstRetBus = new BindingList<RenovacionPagoBE>();
            if (cboTipoDeposito.SelectedIndex == 0)
            {
                Formula.Cobranza.frmDespositosXAplicar ofrmDespositosXAplicar = new Formula.Cobranza.frmDespositosXAplicar();
                ofrmDespositosXAplicar._IdPagadora = txtIdEntidad.Text;
                ofrmDespositosXAplicar._IdSocio = txtIdEntidad.Text;
                ofrmDespositosXAplicar._Opcion = TipoRenovacion.Equals("P")? 1 : 2;
                ofrmDespositosXAplicar._pvalorMonedaID = iMonedaID;
                ofrmDespositosXAplicar._FlgOrigen = "R";
                ofrmDespositosXAplicar.ShowDialog();
                if (ofrmDespositosXAplicar.LstTmpRenovacionPago != null && ofrmDespositosXAplicar.LstTmpRenovacionPago.Count > 0)
                {
                    lstRetBus = ofrmDespositosXAplicar.LstTmpRenovacionPago;
                }
            }
            else
            {
                EfideFactoring.Formula.Consulta.frmBusquedaCtaAhorros frmBusAho = new EfideFactoring.Formula.Consulta.frmBusquedaCtaAhorros(2, 1, 1,@IdsocioB, null, iMonedaID);
                frmBusAho.ShowDialog();
                if (frmBusAho.fbcsNumCuentaID != null && frmBusAho.fbcsNumCuentaID.Trim().Length >= 15)
                {
                    RenovacionPagoBE oEntity = new RenovacionPagoBE()
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
            foreach (RenovacionPagoBE oRenovacionPagoTmpBE in lstRetBus)
            {
                bExiste = false;
                foreach (RenovacionPagoBE ooRenovacionPagoBE in LstRenovacionPago)
                {
                    if (oRenovacionPagoTmpBE.socioBancoID == ooRenovacionPagoBE.socioBancoID)
                    {
                        bExiste = true;
                        break;
                    }
                }

                if (!bExiste)
                {
                    LstRenovacionPago.Add(oRenovacionPagoTmpBE);
                    dgvDepositos.DataSource = LstRenovacionPago;
                    dgvDepositos.Refresh();
                }
            }

            TotalizarDepositos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                decimal ImporteTotal = string.IsNullOrEmpty(txtTotal.Text) ? 0 : Convert.ToDecimal(txtTotal.Text.ToString());
                lblDiferencia.Text = (AcDeposito - ImporteTotal).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        LstRenovacionPago.RemoveAt(index);
                        dgvDepositos.DataSource = LstRenovacionPago;
                        TotalizarDepositos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDepositos_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {

                Totalizar();
                TotalizarDepositos();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}