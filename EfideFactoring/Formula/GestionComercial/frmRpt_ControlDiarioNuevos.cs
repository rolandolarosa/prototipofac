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

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmRpt_ControlDiarioNuevos : FormulaBase.frmMntDato
    {
        public frmRpt_ControlDiarioNuevos()
        {
            InitializeComponent();
        }

        private void frmRpt_ControlDiarioNuevos_Load(object sender, EventArgs e)
        {
            try
            {
                lblDiario.Text = "DIARIO " + DateTime.Now.Date.ToString("d");
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
                DataSet ds = new DataSet();
                ds = new GestionComercialBL().Procesar_Rpt_ControlDiario(1, string.Empty, string.Empty);

                dgvDatos.DataSource = ds.Tables[0];
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
                    frmRpt_ControlDiarioNuevosDetalle ofrm = new frmRpt_ControlDiarioNuevosDetalle();
                    ofrm.Codigo = dgvDatos.CurrentRow.Cells["IdGestor"].Value.ToString();
                    ofrm.ColumnName = dgvDatos.Columns[e.ColumnIndex].Name.ToString();

                    if (ofrm.ColumnName.Equals("TotalLlamadas") || ofrm.ColumnName.Equals("TotalProceso"))
                    {
                        return;
                    }
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