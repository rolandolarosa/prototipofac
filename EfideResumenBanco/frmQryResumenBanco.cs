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
using EfideFactoringDA;

namespace EfideResumenBanco
{
    public partial class frmQryResumenBanco : EfideFactoring.FormulaBase.frmMntDato
    {
        public frmQryResumenBanco()
        {
            InitializeComponent();
        }

        private void frmQryResumenBanco_Load(object sender, EventArgs e)
        {
            try
            {
                TimeTick.Start();
                TimeTick.Enabled = true;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
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
                DataSet ds = new ResumenBancoBL().ProcesarResumenBanco(1);
                dgvDatos.DataSource = ds.Tables[0];

                decimal CountSol = 0;
                decimal CountDol = 0;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    CountSol = CountSol + (dr["valorMonedaID"].ToString().Equals("1") ? Convert.ToDecimal(dr["Total"].ToString()) : 0);
                    CountDol = CountDol + (dr["valorMonedaID"].ToString().Equals("2") ? Convert.ToDecimal(dr["Total"].ToString()) : 0);
                }

                lblTotalSol.Text = CountSol.ToString("N2");
                lblTotalDol.Text = CountDol.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimeTick_Tick(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
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
                TimeTick.Stop();
                TimeTick.Enabled = false;
                this.Dispose();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDatos.RowCount > 0)
                {
                    EfideFactoring.Formula.Registros.frmMntLote ofrm = new EfideFactoring.Formula.Registros.frmMntLote();
                    ofrm._IdFinancieraPar = dgvDatos.CurrentRow.Cells["FinancieraID"].Value.ToString();
                    ofrm._IdFinanciera_Dsc = dgvDatos.CurrentRow.Cells["emprRazonSocial"].Value.ToString();
                    ofrm._IdMoneda_tt = dgvDatos.CurrentRow.Cells["valorMonedaID"].Value.ToString().Equals("1") ? "00036": "00037";
                    ofrm._IdMoneda_tt_Dsc = dgvDatos.CurrentRow.Cells["Moneda"].Value.ToString();
                    ofrm.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}