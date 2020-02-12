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

namespace EfideFactoring.Formula.Registros
{
    public partial class frmMntLiquidacionLinea : FormulaBase.frmMntDato
    {
        public string _IdSocio = string.Empty;
        public string _IdSocio_Dsc = string.Empty;
        public string _Table_IdMoneda = string.Empty;
        public string _Table_IdMonedaDsc = string.Empty;
        public string _IdLote = string.Empty;
        public string _IdEstado_tt = string.Empty;
        private CuentasxCobrarTMBL CuentasxCobrarTMBL = new CuentasxCobrarTMBL();
        private LoteBL LoteBL = new LoteBL();
        private DetaLoteBL DetaLoteBL = new DetaLoteBL();

        public frmMntLiquidacionLinea()
        {
            InitializeComponent();
        }

        private void frmMntLiquidacionLinea_Load(object sender, EventArgs e)
        {
            txtIdLote.Text = _IdLote;
            txtMoneda.Text = _Table_IdMonedaDsc;

            // Datos del Lote
            DataSet dsDetaLote = new DataSet();
            DetaLoteBE oDetaLoteBE = new DetaLoteBE()
            {
                OPCION = 6,
                USUARIO = General.General.GetUsuario,
                IdLote = _IdLote
            };
            dsDetaLote = DetaLoteBL.ProcesarDetaLote(oDetaLoteBE);

            if (dsDetaLote.Tables[0].Rows.Count > 0)
            {
                txtnvNominal.Text = string.IsNullOrEmpty(dsDetaLote.Tables[0].Rows[0]["nvNominal"].ToString()) ? "0.00" : Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nvNominal"]).ToString("N2");
                txtnNotaCredito.Text = string.IsNullOrEmpty(dsDetaLote.Tables[0].Rows[0]["nNotaCredito"].ToString()) ? "0.00" : Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nNotaCredito"]).ToString("N2");
                txtnvRetencion.Text = string.IsNullOrEmpty(dsDetaLote.Tables[0].Rows[0]["nvRetencion"].ToString()) ? "0.00" : Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nvRetencion"]).ToString("N2");
                txtDescuento.Text = string.IsNullOrEmpty(dsDetaLote.Tables[0].Rows[0]["Descuento"].ToString()) ? "0.00" : Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["Descuento"]).ToString("N2");
                txtnvFondoGarantia.Text = string.IsNullOrEmpty(dsDetaLote.Tables[0].Rows[0]["nvFondoGarantia"].ToString()) ? "0.00" : Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nvFondoGarantia"]).ToString("N2");
                txtnValorNegociable.Text = string.IsNullOrEmpty(dsDetaLote.Tables[0].Rows[0]["nValorNegociable"].ToString()) ? "0.00" : Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nValorNegociable"]).ToString("N2");
                txtInteresDescuento.Text = string.IsNullOrEmpty(dsDetaLote.Tables[0].Rows[0]["nInteresAdelantado"].ToString()) ? "0.00" : Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nInteresAdelantado"]).ToString("N2");
                txtnvImporteNeto.Text = string.IsNullOrEmpty(dsDetaLote.Tables[0].Rows[0]["nvImporteNeto"].ToString()) ? "0.00" : Convert.ToDecimal(dsDetaLote.Tables[0].Rows[0]["nvImporteNeto"]).ToString("N2");
            }

            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                // Cargar CxC
                DataSet ds = new DataSet();
                CuentasxCobrarTMBE CuentasxCobrarTMBE = new CuentasxCobrarTMBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdLote = _IdLote,
                    clienteID = _IdSocio,
                    IdMoneda_tt = _Table_IdMoneda
                };

                ds = CuentasxCobrarTMBL.ProcesarCuentasxCobrarTM(CuentasxCobrarTMBE);
                dgvCuentasxCobrarTM.DataSource = ds.Tables[0];

                // Cargar CxP
                DataSet dsCxP = new DataSet();
                CuentasxCobrarTMBE.OPCION = 4;


                dsCxP = CuentasxCobrarTMBL.ProcesarCuentasxCobrarTM(CuentasxCobrarTMBE);
                dgvCuentasxPagarTM.DataSource = dsCxP.Tables[0];

                foreach (DataGridViewRow row in dgvCuentasxPagarTM.Rows)
                {
                    if (row.Cells["FlgBloqueo"].Value.ToString().Equals("1"))
                    {
                        row.Cells["CheckSel"].ReadOnly = true;
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }

                //Gasto Notatial
                CuentasxCobrarTMBE.OPCION = 6;
                dgvGN.DataSource = CuentasxCobrarTMBL.ProcesarCuentasxCobrarTM(CuentasxCobrarTMBE).Tables[0];

                if (_Table_IdMoneda == "00036"){ //Soles
                    dgvCuentasxCobrarTM.Columns["TotalCalculado"].HeaderText = "Total S/.";
                    dgvCuentasxPagarTM.Columns["TotalCalculadoCXP"].HeaderText = "Total S/.";
                    dgvGN.Columns["TotalCalculadoGN"].HeaderText = "Total S/.";
                }
                else
                {
                    dgvCuentasxCobrarTM.Columns["TotalCalculado"].HeaderText = "Total US$";
                    dgvCuentasxPagarTM.Columns["TotalCalculadoCXP"].HeaderText = "Total US$";
                    dgvGN.Columns["TotalCalculadoGN"].HeaderText = "Total US$";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarDeuda_Click(object sender, EventArgs e)
        {
            frmCuentasxCobrarTMDato ofrmCuentasxCobrarTMDato = new frmCuentasxCobrarTMDato();
            ofrmCuentasxCobrarTMDato._IdLote = txtIdLote.Text;
            ofrmCuentasxCobrarTMDato._IdSocio = _IdSocio;
            ofrmCuentasxCobrarTMDato._IdSocioDsc = _IdSocio_Dsc;
            ofrmCuentasxCobrarTMDato._Table_IdMoneda = _Table_IdMoneda;
            ofrmCuentasxCobrarTMDato.ShowDialog();
            CargarDatos();
        }

        private void btnEnviarAprobacion_Click(object sender, EventArgs e)
        {
            try
            {
                //if (Convert.ToDecimal(txtDesembolso.Text) == 0)
                //{
                //    MessageBox.Show("No se puede enviar aprobación, verificar el desembolso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                if (!ValidarDatos()) { return; }

                GrabarDatos();

                LoteBE oLoteBE = new LoteBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetCodigoUsuario,
                    gFechaOp = General.General.gFechaOp,
                    IdLote = _IdLote,
                    IdEstado_tt = "00059", //Enviado a Aprobación
                };
                LoteBL.ProcesarLote(oLoteBE);
                _IdEstado_tt = "00059"; //Enviado a Aprobación
                MessageBox.Show("Se envió el lote a aprobación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCuentasxCobrarTM_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvCuentasxCobrarTM.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCuentasxCobrarTM_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TotalizarCuentasxCobrar();
                TotalizarDesembolso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalizarCuentasxCobrar()
        {
            try
            {
                Decimal AccxcImpComis = 0;
                foreach (DataGridViewRow row in dgvCuentasxCobrarTM.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value.ToString() == "1")
                    {
                        decimal ImporteLiquidarCXC = string.IsNullOrEmpty(row.Cells["ImporteLiquidarCXC"].Value.ToString()) ? 0 : (Decimal)row.Cells["ImporteLiquidarCXC"].Value;
                        AccxcImpComis = AccxcImpComis + ImporteLiquidarCXC;
                    }
                }
                txtTotalCxC.Text = AccxcImpComis.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCuentasxPagarTM_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvCuentasxPagarTM.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCuentasxPagarTM_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TotalizarCuentasxPagar();
                TotalizarDesembolso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalizarCuentasxPagar()
        {
            try
            {
                Decimal AccxpImpComis = 0;
                foreach (DataGridViewRow row in dgvCuentasxPagarTM.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value.ToString() == "1")
                    {
                        decimal ImporteLiquidarCxp = string.IsNullOrEmpty(row.Cells["ImporteLiquidarCXP"].Value.ToString()) ? 0 : (Decimal)row.Cells["ImporteLiquidarCXP"].Value;
                        AccxpImpComis = AccxpImpComis + ImporteLiquidarCxp;
                    }
                }
                txtTotalCxP.Text = AccxpImpComis.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGN_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvGN.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TotalizarGN();
                TotalizarDesembolso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalizarGN()
        {
            try
            {
                Decimal AccxcImpComis = 0;
                foreach (DataGridViewRow row in dgvGN.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value.ToString() == "1")
                    {
                        decimal ImporteLiquidarGN = string.IsNullOrEmpty(row.Cells["ImporteLiquidarGN"].Value.ToString()) ? 0 : (Decimal)row.Cells["ImporteLiquidarGN"].Value;
                        AccxcImpComis = AccxcImpComis + ImporteLiquidarGN;
                    }
                }
                txtTotalGN.Text = AccxcImpComis.ToString("N2");
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
                if (Convert.ToDecimal(txtDesembolso.Text) < 0 )
                {
                    MessageBox.Show("No se puede liquidar, verificar el desembolso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!ValidarDatos()) { return; }
                
                GrabarDatos();

                // Se genera la liquidacion temporal
                LoteBE IEntity = new LoteBE(){
                    OPCION = 19,
                    USUARIO = General.General.GetCodigoUsuario,
                    gFechaOp = General.General.gFechaOp,
                    IdLote = txtIdLote.Text.Trim(),
                };
                new LoteBL().ProcesarLote(IEntity);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTotal()
        {
            try
            {
                TotalizarCuentasxCobrar();
                TotalizarCuentasxPagar();
                TotalizarGN();

                TotalizarDesembolso();
                Double nTotal = String.IsNullOrEmpty(txtDesembolso.Text) ? 0 : Convert.ToDouble(txtDesembolso.Text);
                Double nDesembolso = General.General.Redondeo(nTotal);
                Double nAjuste = 0;

                if (nDesembolso > nTotal)
                {
                    nAjuste = nDesembolso - nTotal;
                }
                else
                {
                    nAjuste = nTotal - nDesembolso;
                }

                LoteBE oLoteBE = new LoteBE()
                {
                    OPCION = 10,
                    USUARIO = General.General.GetUsuario,
                    IdLote = txtIdLote.Text,
                    nTotal = Convert.ToDecimal(nTotal),
                    nAjuste = Convert.ToDecimal(nAjuste),
                    nDesembolso = Convert.ToDecimal(nDesembolso),
                };
                LoteBL.ProcesarLote(oLoteBE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GrabarDatos()
        {
            try
            {
                ActualizarTotal();
                DataSet ds = new DataSet();
                CuentasxCobrarTMBE CuentasxCobrarTMBE = new CuentasxCobrarTMBE()
                {
                    OPCION = 7,
                    USUARIO = General.General.GetUsuario,
                    IdLote = _IdLote
                };
                CuentasxCobrarTMBL.ProcesarCuentasxCobrarTM(CuentasxCobrarTMBE);

                // Cuentas por Cobrar
                foreach (DataGridViewRow row in dgvCuentasxCobrarTM.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value.ToString() == "1")
                    {
                        CuentasxCobrarTMBE.OPCION = 8;
                        CuentasxCobrarTMBE.ctaCobrarID = row.Cells["ctaCobrarID"].Value.ToString();
                        CuentasxCobrarTMBE.Tipo = "cxc";
                        CuentasxCobrarTMBE.valorMonedaID = Convert.ToDecimal(row.Cells["valorMonedaID"].Value);
                        CuentasxCobrarTMBE.Monto = Convert.ToDecimal(row.Cells["ImporteLiquidarCXC"].Value);
                        CuentasxCobrarTMBL.ProcesarCuentasxCobrarTM(CuentasxCobrarTMBE);
                    }
                }

                // Cuentas por Pagar
                foreach (DataGridViewRow row in dgvCuentasxPagarTM.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value.ToString() == "1")
                    {
                        CuentasxCobrarTMBE.OPCION = 8;
                        CuentasxCobrarTMBE.ctaCobrarID = row.Cells["ctaPagarID"].Value.ToString();
                        CuentasxCobrarTMBE.Tipo = "cxp";
                        CuentasxCobrarTMBE.valorMonedaID = Convert.ToDecimal(row.Cells["valorMonedaIDCxp"].Value);
                        CuentasxCobrarTMBE.Monto = Convert.ToDecimal(row.Cells["ImporteLiquidarCXP"].Value);
                        CuentasxCobrarTMBL.ProcesarCuentasxCobrarTM(CuentasxCobrarTMBE);
                    }
                }

                // Gastos Notariales
                foreach (DataGridViewRow row in dgvGN.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value.ToString() == "1")
                    {
                        CuentasxCobrarTMBE.OPCION = 8;
                        CuentasxCobrarTMBE.ctaCobrarID = row.Cells["ctaCobrarIDGN"].Value.ToString();
                        CuentasxCobrarTMBE.Tipo = "cxc";
                        CuentasxCobrarTMBE.valorMonedaID = Convert.ToDecimal(row.Cells["valorMonedaIDGN"].Value);
                        CuentasxCobrarTMBE.Monto = Convert.ToDecimal(row.Cells["ImporteLiquidarGN"].Value);
                        CuentasxCobrarTMBL.ProcesarCuentasxCobrarTM(CuentasxCobrarTMBE);
                    }
                }
                ActualizarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            bool IsResult = true;
            try
            {
                Decimal SaldoCxc = 0;
                Decimal MontoLiquidarCxc = 0;
                foreach (DataGridViewRow row in dgvCuentasxCobrarTM.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value.ToString() == "1")
                    {
                        SaldoCxc = string.IsNullOrEmpty(row.Cells["TotalCalculado"].Value.ToString()) ? 0 : (Decimal)row.Cells["TotalCalculado"].Value;
                        MontoLiquidarCxc = string.IsNullOrEmpty(row.Cells["ImporteLiquidarCXC"].Value.ToString())? 0 : (Decimal)row.Cells["ImporteLiquidarCXC"].Value;

                        if (MontoLiquidarCxc == 0 || MontoLiquidarCxc > SaldoCxc)
                        {
                            MessageBox.Show("Revisar la información en las cuentas por cobrar, el monto no puede ser 0 ni mayor al saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            IsResult = false;
                            return IsResult;
                        }
                    }
                }

                Decimal SaldoCxp = 0;
                Decimal MontoLiquidaCxp = 0;
                foreach (DataGridViewRow row in dgvCuentasxPagarTM.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value.ToString() == "1")
                    {
                        SaldoCxp = string.IsNullOrEmpty(row.Cells["TotalCalculadoCXP"].Value.ToString()) ? 0 : (Decimal)row.Cells["TotalCalculadoCXP"].Value;
                        MontoLiquidaCxp = string.IsNullOrEmpty(row.Cells["ImporteLiquidarCXP"].Value.ToString()) ? 0 : (Decimal)row.Cells["ImporteLiquidarCXP"].Value;

                        if (MontoLiquidaCxp == 0 || MontoLiquidaCxp > SaldoCxp)
                        {
                            MessageBox.Show("Revisar la información en las cuentas por pagar, el monto no puede ser 0 ni mayor al saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            IsResult = false;
                            return IsResult;
                        }
                    }
                }

                Decimal SaldoGN = 0;
                Decimal MontoLiquidaGN = 0;
                foreach (DataGridViewRow row in dgvGN.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value.ToString() == "1")
                    {
                        SaldoGN = string.IsNullOrEmpty(row.Cells["TotalCalculadoGN"].Value.ToString()) ? 0 : (Decimal)row.Cells["TotalCalculadoGN"].Value;
                        MontoLiquidaGN = string.IsNullOrEmpty(row.Cells["ImporteLiquidarGN"].Value.ToString()) ? 0 : (Decimal)row.Cells["ImporteLiquidarGN"].Value;

                        if (MontoLiquidaGN == 0 || MontoLiquidaGN > SaldoGN)
                        {
                            MessageBox.Show("Revisar la información de los gastos notariales, el monto no puede ser 0 ni mayor al saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            IsResult = false;
                            return IsResult;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IsResult;
        }  

        private void TotalizarDesembolso()
        {
            try
            {
                //txtDesembolso = txtnvImporteNeto - txtTotalCxC - txtTotalGN + txtTotalCxP
                decimal ImporteNeto = string.IsNullOrEmpty(txtnvImporteNeto.Text) ? 0 : Convert.ToDecimal(txtnvImporteNeto.Text);
                decimal TotalCxC = string.IsNullOrEmpty(txtTotalCxC.Text) ? 0 : Convert.ToDecimal(txtTotalCxC.Text);
                decimal TotalGN = string.IsNullOrEmpty(txtTotalGN.Text) ? 0 : Convert.ToDecimal(txtTotalGN.Text);
                decimal TotalCxP = string.IsNullOrEmpty(txtTotalCxP.Text) ? 0 : Convert.ToDecimal(txtTotalCxP.Text);

                txtDesembolso.Text = (ImporteNeto + TotalCxP - TotalCxC - TotalGN).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCuentasxCobrarTM_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TotalizarCuentasxCobrar();
                TotalizarDesembolso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCuentasxPagarTM_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TotalizarCuentasxPagar();
                TotalizarDesembolso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGN_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TotalizarGN();
                TotalizarDesembolso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkAllCxC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ChkAllCxC.Checked)
                {
                    foreach (DataGridViewRow row in dgvCuentasxCobrarTM.Rows)
                    {
                        row.Cells["chkcxc"].Value = "1";
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvCuentasxCobrarTM.Rows)
                    {
                        row.Cells["chkcxc"].Value = "0";
                    }
                }
                TotalizarCuentasxCobrar();
                TotalizarDesembolso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkAllCxP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ChkAllCxP.Checked)
                {
                    foreach (DataGridViewRow row in dgvCuentasxPagarTM.Rows)
                    {
                        if (!row.Cells["FlgBloqueo"].Value.ToString().Equals("1"))
                        {
                            row.Cells["CheckSel"].Value = "1";
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvCuentasxPagarTM.Rows)
                    {
                        if (!row.Cells["FlgBloqueo"].Value.ToString().Equals("1"))
                        {
                            row.Cells["CheckSel"].Value = "0";
                        }
                    }
                }
                TotalizarCuentasxPagar();
                TotalizarDesembolso();
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

        private void dgvCuentasxPagarTM_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvCuentasxPagarTM.Rows)
                {
                    if (row.Cells["FlgBloqueo"].Value.ToString().Equals("1"))
                    {
                        row.Cells["CheckSel"].ReadOnly = true;
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
