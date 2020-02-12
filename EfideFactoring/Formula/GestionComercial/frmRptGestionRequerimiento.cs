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
    public partial class frmRptGestionRequerimiento : FormulaBase.frmMntDato
    {
        public frmRptGestionRequerimiento()
        {
            InitializeComponent();
        }

        private void frmRptGestionRequerimiento_Load(object sender, EventArgs e)
        {
            try
            {
                dtFechaInicio.MinDate = DateTime.Now;
                dtFechaInicio.Value = DateTime.Now;
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
                lblDia1.Text = dtFechaInicio.Value.ToString("dd/MM/yyyy");
                lblDia2.Text = dtFechaInicio.Value.AddDays(1).ToString("dd/MM/yyyy");
                lblDia3.Text = dtFechaInicio.Value.AddDays(2).ToString("dd/MM/yyyy");
                lblDia4.Text = dtFechaInicio.Value.AddDays(3).ToString("dd/MM/yyyy");
                lblDia5.Text = dtFechaInicio.Value.AddDays(4).ToString("dd/MM/yyyy");
                lblDia6.Text = dtFechaInicio.Value.AddDays(5).ToString("dd/MM/yyyy");
                lblDia7.Text = dtFechaInicio.Value.AddDays(6).ToString("dd/MM/yyyy");
                lblDia8.Text = dtFechaInicio.Value.AddDays(7).ToString("dd/MM/yyyy");

                DataSet ds = new DataSet();
                ds = new GestionComercialBL().ProcesarGestionComercial(9, string.Empty, dtFechaInicio.Value);
                dgvRequerimientos.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRequerimientos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvRequerimientos.Rows[e.RowIndex];

                if (row.Cells["IdGestor"].Value.Equals("0"))
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    row.DefaultCellStyle.Font = new Font(dgvRequerimientos.DefaultCellStyle.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRequerimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Dia8
                DateTime dtFechaPeriodo = DateTime.Now;
                string NombreColumna = dgvRequerimientos.Columns[e.ColumnIndex].Name.Substring(0, 4);

                switch (NombreColumna)
                {
                    case "Dia2":
                        {
                            dtFechaPeriodo = dtFechaInicio.Value.AddDays(1);
                            break;
                        }
                    case "Dia3":
                        {
                            dtFechaPeriodo = dtFechaInicio.Value.AddDays(2);
                            break;
                        }
                    case "Dia4":
                        {
                            dtFechaPeriodo = dtFechaInicio.Value.AddDays(3);
                            break;
                        }
                    case "Dia5":
                        {
                            dtFechaPeriodo = dtFechaInicio.Value.AddDays(4);
                            break;
                        }
                    case "Dia6":
                        {
                            dtFechaPeriodo = dtFechaInicio.Value.AddDays(5);
                            break;
                        }
                    case "Dia7":
                        {
                            dtFechaPeriodo = dtFechaInicio.Value.AddDays(6);
                            break;
                        }
                    case "Dia8":
                        {
                            dtFechaPeriodo = dtFechaInicio.Value.AddDays(7);
                            break;
                        }
                    default:
                        break;
                }

                frmCompromiso ofrm = new frmCompromiso();
                ofrm._OPCION = 4;
                ofrm._IdGestor = dgvRequerimientos.CurrentRow.Cells["IdGestor"].Value.ToString();
                ofrm._NombreGestor = dgvRequerimientos.CurrentRow.Cells["IdGestor_Dsc"].Value.ToString();
                ofrm._IdMoneda_tt = dgvRequerimientos.Columns[e.ColumnIndex].Name.Contains("Sol") ? "00036" : "00037";
                ofrm._FechaFin = dtFechaPeriodo;
                ofrm.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtFechaInicio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtFechaFinal.Value = dtFechaInicio.Value.AddDays(7);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}