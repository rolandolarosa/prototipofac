using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBL;
using EfideFactoringBE;

namespace EfideFactoring.Formula.GestionPagadora
{
    public partial class frmQryResumenSector : FormulaBase.frmMntDato
    {
        public frmQryResumenSector()
        {
            InitializeComponent();
        }

        private void frmQryResumenSector_Load(object sender, EventArgs e)
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
                IEntity.OPCION = 6;
                DataSet dsSector = new PagadoraLineaBL().ProcesarPagadoraLinea(IEntity);
                dgvSector.DataSource = dsSector.Tables[0];

                decimal AcImporte = 0;
                decimal AcUtilizado = 0;
                decimal AcSaldo = 0;

                foreach (DataGridViewRow row in dgvSector.Rows)
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