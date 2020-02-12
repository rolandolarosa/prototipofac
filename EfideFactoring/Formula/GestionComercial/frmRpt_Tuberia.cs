using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBL;

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmRpt_Tuberia : FormulaBase.frmMntDato
    {
        public string IdTipoGestor_tt = string.Empty;
        public frmRpt_Tuberia()
        {
            InitializeComponent();
        }

        private void frmRpt_Tuberia_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();

                if (General.General.GetCodigoUsuario.Trim().Equals("ADMIN") || General.General.GetCodigoUsuario.Trim().Equals("MLOLI") || General.General.GetCodigoUsuario.Trim().Equals("CSERPA"))
                {
                    cboEjecutivo.Enabled = true;
                }
                else
                {
                    cboEjecutivo.Enabled = false;
                    cboEjecutivo.SelectedValue = General.General.GetIdGestor;
                }

                CargarDatos();
                Totalizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
                Totalizar();
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
                cboEjecutivo.SelectedValue = string.Empty;
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
                DataSet dsGestor = new GestionComercialBL().ProcesarGestionComercial(0, 0, "", "", 0, 3);
                General.General.LlenarCombobox(cboEjecutivo, "nombreCompleto", "gestorID", dsGestor.Tables[0], true);
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
                DataSet ds = new DataSet();
                ds = new GestionComercialBL().Procesar_Rpt_Tuberia(cboEjecutivo.SelectedValue.ToString(), IdTipoGestor_tt, 1);
                dgvTuberia.DataSource = ds.Tables[0];
                lblRegistros.Text = dgvTuberia.Rows.Count  + " registro(s)";
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
                decimal Total = 0;
                foreach (DataGridViewRow Row in dgvTuberia.Rows)
                {
                    Total = Total + (string.IsNullOrEmpty(Row.Cells["Importe"].Value.ToString()) ? 0 : (Row.Cells["IdMoneda_tt"].Value.ToString().Equals("00037") ? Convert.ToDecimal(Row.Cells["TipoCambio"].Value) * Convert.ToDecimal(Row.Cells["Importe"].Value) : Convert.ToDecimal(Row.Cells["Importe"].Value)));
                }
                txtTotal.Text = Total.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}