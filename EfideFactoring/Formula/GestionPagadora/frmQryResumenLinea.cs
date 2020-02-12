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

namespace EfideFactoring.Formula.GestionPagadora
{
    public partial class frmQryResumenLinea : FormulaBase.frmMntDato
    {
        public frmQryResumenLinea()
        {
            InitializeComponent();
        }

        private void frmQryResumenLinea_Load(object sender, EventArgs e)
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
                PagadoraLineaBE IEntity = new PagadoraLineaBE();
                IEntity.OPCION = 5;
                DataSet ds = new PagadoraLineaBL().ProcesarPagadoraLinea(IEntity);
                dgvEstado.DataSource = ds.Tables[0];

                decimal AcImporte = 0;
                decimal AcUtilizado = 0;
                decimal AcSaldo = 0;

                foreach (DataGridViewRow row in dgvEstado.Rows)
                {
                    AcImporte = AcImporte + (!string.IsNullOrEmpty(row.Cells["Linea"].Value.ToString()) ? Convert.ToDecimal(row.Cells["Linea"].Value) : 0);
                    AcUtilizado = AcUtilizado + (!string.IsNullOrEmpty(row.Cells["Utilizado"].Value.ToString()) ? Convert.ToDecimal(row.Cells["Utilizado"].Value) : 0);
                    AcSaldo = AcSaldo + (!string.IsNullOrEmpty(row.Cells["Saldo"].Value.ToString()) ? Convert.ToDecimal(row.Cells["Saldo"].Value) : 0);
                }

                lblTotalImporte.Text = AcImporte.ToString("N0");
                lblTotalUtilizado.Text = AcUtilizado.ToString("N0");
                lblTotalSaldo.Text = AcSaldo.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}