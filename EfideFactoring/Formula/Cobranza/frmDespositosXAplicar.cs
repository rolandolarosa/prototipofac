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

namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmDespositosXAplicar : DevComponents.DotNetBar.OfficeForm
    {
        public BindingList<CobranzaPagoBE> LstTmpCobranzaPago = new BindingList<CobranzaPagoBE>();
        public BindingList<RenovacionPagoBE> LstTmpRenovacionPago = new BindingList<RenovacionPagoBE>();
        public string _IdPagadora = string.Empty;
        public string _IdSocio = string.Empty;
        public decimal _Saldo = 0;
        public int _pvalorMonedaID = 0;
        public string _valorMonedaID = string.Empty;
        public string _socioBancoID = string.Empty;
        public string _ctasBancariaID = string.Empty;
        public string _ctasBanNumCta = string.Empty;
        public string _IdTipoAbono_tt = string.Empty;
        public string _IdTipoAbono_tt_Dsc = string.Empty;
        public string _IdOperacion_tt = string.Empty;
        public string _IdOperacion_tt_Dsc = string.Empty;
        public string _FlgOrigen = "C"; //Cobranza
        public int _Opcion = 1;
        public frmDespositosXAplicar()
        {
            InitializeComponent();
        }

        private void frmDespositosXAplicar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                DepositosSABE IEntity = new DepositosSABE()
                {
                    OPCION = _Opcion,
                    USUARIO = General.General.GetUsuario,
                    IdPagadora = _IdPagadora,
                    IdSocio = _IdSocio,
                    valorMonedaID = _pvalorMonedaID
                };
                dgvDepositosxAplicar.DataSource = new DepositosSBL().ProcesarDepositosSA(IEntity).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDepositosxAplicar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepositosxAplicar.RowCount > 0)
            {
                _Saldo = string.IsNullOrEmpty(dgvDepositosxAplicar.CurrentRow.Cells["Saldo"].Value.ToString()) ? 0 : Convert.ToDecimal(dgvDepositosxAplicar.CurrentRow.Cells["Saldo"].Value.ToString());
                _valorMonedaID = string.IsNullOrEmpty(dgvDepositosxAplicar.CurrentRow.Cells["valorMonedaID"].Value.ToString()) ? string.Empty : dgvDepositosxAplicar.CurrentRow.Cells["valorMonedaID"].Value.ToString();
                _socioBancoID = string.IsNullOrEmpty(dgvDepositosxAplicar.CurrentRow.Cells["socioBancoID"].Value.ToString()) ? string.Empty : dgvDepositosxAplicar.CurrentRow.Cells["socioBancoID"].Value.ToString();
                _ctasBancariaID = string.IsNullOrEmpty(dgvDepositosxAplicar.CurrentRow.Cells["ctasBancariaID"].Value.ToString()) ? string.Empty : dgvDepositosxAplicar.CurrentRow.Cells["ctasBancariaID"].Value.ToString();
                _ctasBanNumCta = string.IsNullOrEmpty(dgvDepositosxAplicar.CurrentRow.Cells["ctasBanNumCta"].Value.ToString()) ? string.Empty : dgvDepositosxAplicar.CurrentRow.Cells["ctasBanNumCta"].Value.ToString();
                _IdTipoAbono_tt = string.IsNullOrEmpty(dgvDepositosxAplicar.CurrentRow.Cells["IdTipoAbono_tt"].Value.ToString()) ? string.Empty : dgvDepositosxAplicar.CurrentRow.Cells["IdTipoAbono_tt"].Value.ToString();
                _IdTipoAbono_tt_Dsc = string.IsNullOrEmpty(dgvDepositosxAplicar.CurrentRow.Cells["IdTipoAbono_tt_Dsc"].Value.ToString()) ? string.Empty : dgvDepositosxAplicar.CurrentRow.Cells["IdTipoAbono_tt_Dsc"].Value.ToString();
                _IdOperacion_tt = string.IsNullOrEmpty(dgvDepositosxAplicar.CurrentRow.Cells["IdOperacion_tt"].Value.ToString()) ? string.Empty : dgvDepositosxAplicar.CurrentRow.Cells["IdOperacion_tt"].Value.ToString();
                _IdOperacion_tt_Dsc = string.IsNullOrEmpty(dgvDepositosxAplicar.CurrentRow.Cells["IdOperacion_tt_Dsc"].Value.ToString()) ? string.Empty : dgvDepositosxAplicar.CurrentRow.Cells["IdOperacion_tt_Dsc"].Value.ToString();
                //_valorTipoMpagoID = string.IsNullOrEmpty(dgvDepositosxAplicar.CurrentRow.Cells["valorTipoMpagoID"].Value.ToString()) ? string.Empty : dgvDepositosxAplicar.CurrentRow.Cells["valorTipoMpagoID"].Value.ToString();
                this.Dispose();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvDepositosxAplicar.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CheckSel"];
                    if (chk.Value.ToString() == "1")
                    {
                        if (_FlgOrigen.Equals("C"))
                        {
                            CobranzaPagoBE oEntity = new CobranzaPagoBE()
                            {
                                ctasBancariaID = row.Cells["ctasBancariaID"].Value.ToString(),
                                ctasBanNumCta = row.Cells["ctasBanNumCta"].Value.ToString(),
                                IdOperacion_tt = row.Cells["IdOperacion_tt"].Value.ToString(),
                                IdOperacion_tt_Dsc = row.Cells["IdOperacion_tt_Dsc"].Value.ToString(),
                                nTotal = Convert.ToDecimal(row.Cells["Saldo"].Value),
                                IdTipoAbono_tt = row.Cells["IdTipoAbono_tt"].Value.ToString(),
                                IdTipoAbono_tt_Dsc = row.Cells["IdTipoAbono_tt_Dsc"].Value.ToString(),
                                socioBancoID = row.Cells["socioBancoID"].Value.ToString(),
                                jSaldo = Convert.ToDecimal(row.Cells["Saldo"].Value),
                                jImporte = Convert.ToDecimal(row.Cells["sbImporte"].Value)
                            };
                            LstTmpCobranzaPago.Add(oEntity);
                        }
                        else //Renovación
                        {
                            RenovacionPagoBE oEntity = new RenovacionPagoBE()
                            {
                                ctasBancariaID = row.Cells["ctasBancariaID"].Value.ToString(),
                                ctasBanNumCta = row.Cells["ctasBanNumCta"].Value.ToString(),
                                IdOperacion_tt = row.Cells["IdOperacion_tt"].Value.ToString(),
                                IdOperacion_tt_Dsc = row.Cells["IdOperacion_tt_Dsc"].Value.ToString(),
                                nTotal = Convert.ToDecimal(row.Cells["Saldo"].Value),
                                IdTipoAbono_tt = row.Cells["IdTipoAbono_tt"].Value.ToString(),
                                IdTipoAbono_tt_Dsc = row.Cells["IdTipoAbono_tt_Dsc"].Value.ToString(),
                                socioBancoID = row.Cells["socioBancoID"].Value.ToString(),
                                jSaldo = Convert.ToDecimal(row.Cells["Saldo"].Value),
                                jImporte = Convert.ToDecimal(row.Cells["sbImporte"].Value)
                            };
                            LstTmpRenovacionPago.Add(oEntity);
                        }
                    }
                }

                if (_FlgOrigen.Equals("C"))
                {
                    if (LstTmpCobranzaPago.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar al menos un deposito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    if (LstTmpRenovacionPago.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar al menos un deposito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDepositosxAplicar_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvDepositosxAplicar.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}