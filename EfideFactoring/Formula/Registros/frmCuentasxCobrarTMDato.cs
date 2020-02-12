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

namespace EfideFactoring.Formula.Registros
{
    public partial class frmCuentasxCobrarTMDato : FormulaBase.frmMntDato
    {
        public string _IdLote = string.Empty;
        public string _IdSocio = string.Empty;
        public string _IdSocioDsc = string.Empty;
        public string _Table_IdMoneda = string.Empty;
        private CuentasxCobrarTMBL CuentasxCobrarTMBL = new CuentasxCobrarTMBL();
        private TableBaseBL TableBaseBL = new TableBaseBL();
        public frmCuentasxCobrarTMDato()
        {
            InitializeComponent();
        }

        private void frmCuentasxCobrarTMDato_Load(object sender, EventArgs e)
        {
            rbtCxc.Checked = true;
            LlenarCombos();
            dtcxcFecEmision.Value = DateTime.Today;
            cbovalorFormaPagoID.SelectedValue = "1";
            cbovalorTipoDesemID.SelectedValue = "2";
            txtIdSocio.Text = _IdSocio;
            txtIdSocio_Dsc.Text = _IdSocioDsc;
            cboIdMoneda_tt.SelectedValue = _Table_IdMoneda;
            cboIdMoneda_tt.Enabled = false;
        }

        private void LlenarCombos()
        {
            try
            {
                LlenarTipoCuenta();
                String Table_Id = "00070";
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                General.General.LlenarCombobox(cbovalorFormaPagoID, "Table_Name", "Table_Value", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00074";
                General.General.LlenarCombobox(cbovalorTipoDesemID, "Table_Name", "Table_Value", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00035"; //Moneda
                cboIdMoneda_tt.DataSource = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                cboIdMoneda_tt.DisplayMember = "Table_Name";
                cboIdMoneda_tt.ValueMember = "Table_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarTipoCuenta()
        {
            try
            {
                CuentasxCobrarTMBE CuentasxCobrarTMBE = new CuentasxCobrarTMBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    IdMoneda_tt = _Table_IdMoneda,
                    Tipo = rbtCxc.Checked ? "001" : "002",
                    OPCION = 5,
                };
                General.General.LlenarCombobox(cbotipCxcID, "tipCxcNombre", "tipCxcID", CuentasxCobrarTMBL.ProcesarCuentasxCobrarTM(CuentasxCobrarTMBE).Tables[0]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CuentasxCobrarTMBE CuentasxCobrarTMBE = new CuentasxCobrarTMBE()
            {
                USUARIO = General.General.GetCodigoUsuario,
                gPlazaID = General.General.gPlazaID,
                gFechaOp = General.General.gFechaOp,
                OPCION = 2,
                ctaCobrarID = txtctaCobrarID.Text,
                clienteID = _IdSocio,
                tipCxcID = cbotipCxcID.SelectedValue.ToString(),
                referenciaID = _IdLote,
                cxcImpComis = 0,  //'String.IsNullOrEmpty(txtcxcImpComis.Text.Trim()) ? 0 : Convert.ToDecimal(txtcxcImpComis.Text),
                cxcImpComp = String.IsNullOrEmpty(txtcxcImpComis.Text.Trim()) ? 0 : Convert.ToDecimal(txtcxcImpComis.Text),
                cxcNumCuotas = 1,
                cxcPeriodicidad = String.IsNullOrEmpty(txtcxcPeriodicidad.Text.Trim()) ? 0 : int.Parse(txtcxcPeriodicidad.Text),
                cxcFecEmision = dtcxcFecEmision.Value,
                cxcFecInicio = dtcxcFecEmision.Value,
                valorFormaPagoID = String.IsNullOrEmpty(cbovalorFormaPagoID.SelectedValue.ToString()) ? 0 : Convert.ToDecimal(cbovalorFormaPagoID.SelectedValue.ToString()),
                cxcImporteDesc = String.IsNullOrEmpty(txtcxcImporteDesc.Text.Trim()) ? 0 : Convert.ToDecimal(txtcxcImporteDesc.Text),
                valorTipoDesemID = String.IsNullOrEmpty(cbovalorTipoDesemID.SelectedValue.ToString()) ? 0 : Convert.ToDecimal(cbovalorTipoDesemID.SelectedValue.ToString()),
                numOperacion = txtnumOperacion.Text,
                cxcDiaPagoFijo = 0, //String.IsNullOrEmpty(txtcxcDiaPagoFijo.Text.Trim()) ? 0 : int.Parse(txtcxcDiaPagoFijo.Text),
                cxcGlosa = txtcxcGlosa.Text,
                Tipo = rbtCxc.Checked ? "001" : "002",
            };

            DataSet dsCuentasxCobrarTM = new DataSet();
            dsCuentasxCobrarTM = CuentasxCobrarTMBL.ProcesarCuentasxCobrarTM(CuentasxCobrarTMBE);

            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void rbtCxc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarTipoCuenta(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnCxp_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarTipoCuenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}