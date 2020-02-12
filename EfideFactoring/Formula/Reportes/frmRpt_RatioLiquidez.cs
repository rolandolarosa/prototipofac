using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Reportes
{
    public partial class frmRpt_RatioLiquidez :FormulaBase.frmMntDato
    {
        public frmRpt_RatioLiquidez()
        {
            InitializeComponent();
        }

        private void frmRpt_RatioLiquidez_Load(object sender, EventArgs e)
        {
            try
            {
                lblFecha.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
                lblFecha1.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

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
                DataSet dsDol = new DataSet();

                ds = new ReporteBL().ProcesarReporteRatioLiquidez(1, General.General.GetCodigoUsuario, ValorMonedaId:1);
                dgvRatioLiquidezSol.DataSource = ds.Tables[0];

                dsDol = new ReporteBL().ProcesarReporteRatioLiquidez(1, General.General.GetCodigoUsuario, ValorMonedaId: 2);
                dgvRatioLiquidezDol.DataSource = dsDol.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRatioLiquidezSol_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvRatioLiquidezSol.Rows[e.RowIndex];

                if (row.Cells["ConceptoId"].Value.Equals(0))
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    row.DefaultCellStyle.Font = new Font(dgvRatioLiquidezSol.DefaultCellStyle.Font, FontStyle.Bold);
                }

                if (row.Cells["ConceptoId"].Value.Equals(1))
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    row.DefaultCellStyle.Font = new Font(dgvRatioLiquidezSol.DefaultCellStyle.Font, FontStyle.Bold);
                }

                if (row.Cells["ConceptoId"].Value.Equals(2))
                {
                    row.DefaultCellStyle.Format = "N2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRatioLiquidezDol_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvRatioLiquidezDol.Rows[e.RowIndex];

                if (row.Cells["ConceptoId_1"].Value.Equals(0))
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    row.DefaultCellStyle.Font = new Font(dgvRatioLiquidezDol.DefaultCellStyle.Font, FontStyle.Bold);
                }

                if (row.Cells["ConceptoId_1"].Value.Equals(1))
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    row.DefaultCellStyle.Font = new Font(dgvRatioLiquidezDol.DefaultCellStyle.Font, FontStyle.Bold);
                }

                if (row.Cells["ConceptoId_1"].Value.Equals(2))
                {
                    row.DefaultCellStyle.Format = "N2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRatioLiquidezSol_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvRatioLiquidezSol.CurrentRow.Cells["ConceptoId"].Value.ToString().Equals("3")) // Inversiones
                {
                    FrmRpt_FlujoCajaDet ofrm = new FrmRpt_FlujoCajaDet();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = "Fondos Disponibles-COOPAC y Emp Sistema Financiero Nacional";
                    ofrm._ConceptoId = 17;
                    ofrm._Columna = "Per1";
                    ofrm._ValorMonedaId = 1;
                    ofrm.ShowDialog();
                }
                else if (dgvRatioLiquidezSol.CurrentRow.Cells["ConceptoId"].Value.ToString().Equals("5")) // Cobranzas
                {
                    FrmRpt_FlujoCajaDet ofrm = new FrmRpt_FlujoCajaDet();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = "Cobranzas";
                    ofrm._ConceptoId = 15;
                    ofrm._Columna = "Per1";
                    ofrm._ValorMonedaId = 1;
                    ofrm.ShowDialog();
                }
                else if (dgvRatioLiquidezSol.CurrentRow.Cells["ConceptoId"].Value.ToString().Equals("6")) // Requerimiento Comercial
                {
                    FrmRpt_FlujoCajaDet ofrm = new FrmRpt_FlujoCajaDet();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = "Desembolsos";
                    ofrm._ConceptoId = 9;
                    ofrm._Columna = "Per1";
                    ofrm._ValorMonedaId = 1;
                    ofrm.ShowDialog();
                }
                else if (dgvRatioLiquidezSol.CurrentRow.Cells["ConceptoId"].Value.ToString().Equals("10")) // DPF
                {
                    FrmRpt_FlujoCajaDet ofrm = new FrmRpt_FlujoCajaDet();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = "Obligaciones por Cuentas de Plazo";
                    ofrm._ConceptoId = 16;
                    ofrm._Columna = "Per1";
                    ofrm._ValorMonedaId = 1;
                    ofrm.ShowDialog();
                }
                else if (dgvRatioLiquidezSol.CurrentRow.Cells["ConceptoId"].Value.ToString().Equals("11")) // Adeudos
                {
                    FrmRpt_FlujoCajaDet ofrm = new FrmRpt_FlujoCajaDet();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = "ADEUDOS y Obligaciones Financieras del país";
                    ofrm._ConceptoId = 18;
                    ofrm._Columna = "Per1";
                    ofrm._ValorMonedaId = 1;
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRatioLiquidezDol_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvRatioLiquidezDol.CurrentRow.Cells["ConceptoId_1"].Value.ToString().Equals("3")) // Inversiones
                {
                    FrmRpt_FlujoCajaDet ofrm = new FrmRpt_FlujoCajaDet();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = "Fondos Disponibles-COOPAC y Emp Sistema Financiero Nacional";
                    ofrm._ConceptoId = 17;
                    ofrm._Columna = "Per1";
                    ofrm._ValorMonedaId = 2;
                    ofrm.ShowDialog();
                }
                else if (dgvRatioLiquidezDol.CurrentRow.Cells["ConceptoId_1"].Value.ToString().Equals("5")) // Cobranzas
                {
                    FrmRpt_FlujoCajaDet ofrm = new FrmRpt_FlujoCajaDet();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = "Cobranzas";
                    ofrm._ConceptoId = 15;
                    ofrm._Columna = "Per1";
                    ofrm._ValorMonedaId = 2;
                    ofrm.ShowDialog();
                }
                else if (dgvRatioLiquidezDol.CurrentRow.Cells["ConceptoId_1"].Value.ToString().Equals("6")) // Requerimiento Comercial
                {
                    FrmRpt_FlujoCajaDet ofrm = new FrmRpt_FlujoCajaDet();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = "Desembolsos";
                    ofrm._ConceptoId = 9;
                    ofrm._Columna = "Per1";
                    ofrm._ValorMonedaId = 2;
                    ofrm.ShowDialog();
                }
                else if (dgvRatioLiquidezDol.CurrentRow.Cells["ConceptoId_1"].Value.ToString().Equals("10")) // DPF
                {
                    FrmRpt_FlujoCajaDet ofrm = new FrmRpt_FlujoCajaDet();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = "Obligaciones por Cuentas de Plazo";
                    ofrm._ConceptoId = 16;
                    ofrm._Columna = "Per1";
                    ofrm._ValorMonedaId = 2;
                    ofrm.ShowDialog();
                }
                else if (dgvRatioLiquidezDol.CurrentRow.Cells["ConceptoId_1"].Value.ToString().Equals("11")) // Adeudos
                {
                    FrmRpt_FlujoCajaDet ofrm = new FrmRpt_FlujoCajaDet();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = "ADEUDOS y Obligaciones Financieras del país";
                    ofrm._ConceptoId = 18;
                    ofrm._Columna = "Per1";
                    ofrm._ValorMonedaId = 2;
                    ofrm.ShowDialog();
                }
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

        private void btnExportarRatio_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();

                ds = new ReporteBL().ProcesarReporteRatioLiquidez(3, General.General.GetCodigoUsuario, ValorMonedaId:1);
                General.msgHelper.ExportToExcel(ds.Tables[0], FlgRatioLiquidez:1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarRatioDol_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataSet dsDol = new DataSet();

                ds = new ReporteBL().ProcesarReporteRatioLiquidez(3, General.General.GetCodigoUsuario, ValorMonedaId: 2);
                General.msgHelper.ExportToExcel(ds.Tables[0], FlgRatioLiquidez: 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}