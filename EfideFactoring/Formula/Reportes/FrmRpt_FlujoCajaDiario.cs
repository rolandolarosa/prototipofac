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
    public partial class FrmRpt_FlujoCajaDiario : FormulaBase.frmMntDato
    {
        public int _FlgSBS = 0;
        public int _ValorMonedaId = 1;
        public FrmRpt_FlujoCajaDiario()
        {
            InitializeComponent();
        }

        private void FrmRpt_FlujoCajaDiario_Load(object sender, EventArgs e)
        {
            try
            {
                if (_ValorMonedaId == 2)
                {
                    lblTitulo.Text = "FLUJO DE CAJA DIARIO EN DOLARES";
                }

                lblPar1.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblPar2.Text = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy");
                lblPar3.Text = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy");
                lblPar4.Text = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy");
                lblPar5.Text = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy");
                lblPar6.Text = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy");
                lblPar7.Text = DateTime.Now.AddDays(6).ToString("dd/MM/yyyy");
                lblPar8.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
                lblPar9.Text = DateTime.Now.AddDays(8).ToString("dd/MM/yyyy");
                lblPar10.Text = DateTime.Now.AddDays(9).ToString("dd/MM/yyyy");
                lblPar11.Text = DateTime.Now.AddDays(10).ToString("dd/MM/yyyy");
                lblPar12.Text = DateTime.Now.AddDays(11).ToString("dd/MM/yyyy");
                lblPar13.Text = DateTime.Now.AddDays(12).ToString("dd/MM/yyyy");
                lblPar14.Text = DateTime.Now.AddDays(13).ToString("dd/MM/yyyy");
                lblPar15.Text = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");

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
                DataSet dsActualizacion = new DataSet();

                ds = new ReporteBL().ProcesarReporte(6, General.General.GetCodigoUsuario, ValorMonedaId: _ValorMonedaId, FlgSBS: _FlgSBS);
                dgvFlujoCaja.DataSource = ds.Tables[0];

                dsActualizacion = new ReporteBL().ProcesarReporte(5, General.General.GetCodigoUsuario);
                lblUltimaActualizacion.Text = Convert.ToDateTime(dsActualizacion.Tables[0].Rows[0]["FechaActualizacion"].ToString()).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFlujoCaja_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                //FormatearGrilla();
                DataGridViewRow row = dgvFlujoCaja.Rows[e.RowIndex];

                if (row.Cells["ConceptoId"].Value.Equals(0)) // Aprobado
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    row.DefaultCellStyle.Font = new Font(dgvFlujoCaja.DefaultCellStyle.Font, FontStyle.Bold);
                }

                for (int i = 1; i <= 15; i++)
                {
                    if (!string.IsNullOrEmpty(row.Cells["Per" + i.ToString()].Value.ToString())) // Aprobado
                    {
                        if (decimal.Parse(row.Cells["Per" + i.ToString()].Value.ToString()) < 0)
                        {
                            row.Cells["Per" + i.ToString()].Style.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFlujoCaja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFlujoCaja.CurrentRow.Cells["ConceptoId"].Value.ToString().Equals("12"))
                {
                    Movimiento.frmMntMovimiento ofrm = new Movimiento.frmMntMovimiento();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = dgvFlujoCaja.CurrentRow.Cells["Concepto"].Value.ToString();
                    ofrm._ConceptoId = int.Parse(dgvFlujoCaja.CurrentRow.Cells["ConceptoId"].Value.ToString());
                    ofrm._Columna = dgvFlujoCaja.Columns[e.ColumnIndex].Name;
                    ofrm._ValorMonedaId = _ValorMonedaId;
                    ofrm.ShowDialog();
                    CargarDatos();
                }
                else if (dgvFlujoCaja.CurrentRow.Cells["ConceptoId"].Value.ToString().Equals("13"))
                {
                    Movimiento.frmMntMovimientoEgreso ofrm = new Movimiento.frmMntMovimientoEgreso();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = dgvFlujoCaja.CurrentRow.Cells["Concepto"].Value.ToString();
                    ofrm._ConceptoId = int.Parse(dgvFlujoCaja.CurrentRow.Cells["ConceptoId"].Value.ToString());
                    ofrm._Columna = dgvFlujoCaja.Columns[e.ColumnIndex].Name;
                    ofrm._ValorMonedaId = _ValorMonedaId;
                    ofrm._IdTipo_tt = "2";
                    ofrm.ShowDialog();
                    CargarDatos();
                }
                else if (dgvFlujoCaja.CurrentRow.Cells["ConceptoId"].Value.ToString().Equals("14"))
                {
                    Movimiento.frmMntMovimientoEgreso ofrm = new Movimiento.frmMntMovimientoEgreso();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = dgvFlujoCaja.CurrentRow.Cells["Concepto"].Value.ToString();
                    ofrm._ConceptoId = int.Parse(dgvFlujoCaja.CurrentRow.Cells["ConceptoId"].Value.ToString());
                    ofrm._Columna = dgvFlujoCaja.Columns[e.ColumnIndex].Name;
                    ofrm._ValorMonedaId = _ValorMonedaId;
                    ofrm._IdTipo_tt = "3";
                    ofrm.ShowDialog();
                    CargarDatos();
                }
                else if (dgvFlujoCaja.CurrentRow.Cells["ConceptoId"].Value.ToString().Equals("7") || dgvFlujoCaja.CurrentRow.Cells["ConceptoId"].Value.ToString().Equals("11"))
                {
                    return;
                }
                else
                {
                    FrmRpt_FlujoCajaDet ofrm = new FrmRpt_FlujoCajaDet();
                    ofrm._Opcion = 7;
                    ofrm._Concepto = dgvFlujoCaja.CurrentRow.Cells["Concepto"].Value.ToString();
                    ofrm._ConceptoId = int.Parse(dgvFlujoCaja.CurrentRow.Cells["ConceptoId"].Value.ToString());
                    ofrm._Columna = dgvFlujoCaja.Columns[e.ColumnIndex].Name;
                    ofrm._FlgSBS = _FlgSBS;
                    ofrm._ValorMonedaId = _ValorMonedaId;
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                General.msgHelper.Wait("Procesando, espere un momento ...");
                new ReporteBL().ProcesarReporte(4, General.General.GetCodigoUsuario);
                CargarDatos();
                General.msgHelper.Wait();
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                General.msgHelper.Wait();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}