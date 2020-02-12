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
    public partial class frmRpt_TableroControlGestionNuevos : FormulaBase.frmMntDato
    {
        public frmRpt_TableroControlGestionNuevos()
        {
            InitializeComponent();
        }

        private void frmRpt_TableroControlGestionNuevos_Load(object sender, EventArgs e)
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
                CargarReporte();
                FormatearGrilla();
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
                ds = new GestionComercialBL().Procesar_Rpt_TableroControlGestionNuevos(1, string.Empty);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblFecha.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha1.Text = Convert.ToDateTime(ds.Tables[0].Rows[1]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha2.Text = Convert.ToDateTime(ds.Tables[0].Rows[2]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha3.Text = Convert.ToDateTime(ds.Tables[0].Rows[3]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha4.Text = Convert.ToDateTime(ds.Tables[0].Rows[4]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha5.Text = Convert.ToDateTime(ds.Tables[0].Rows[5]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha6.Text = Convert.ToDateTime(ds.Tables[0].Rows[6]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha7.Text = Convert.ToDateTime(ds.Tables[0].Rows[7]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha8.Text = Convert.ToDateTime(ds.Tables[0].Rows[8]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha9.Text = Convert.ToDateTime(ds.Tables[0].Rows[9]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha10.Text = Convert.ToDateTime(ds.Tables[0].Rows[10]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha11.Text = Convert.ToDateTime(ds.Tables[0].Rows[11]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha12.Text = Convert.ToDateTime(ds.Tables[0].Rows[12]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha13.Text = Convert.ToDateTime(ds.Tables[0].Rows[13]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha14.Text = Convert.ToDateTime(ds.Tables[0].Rows[14]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha15.Text = Convert.ToDateTime(ds.Tables[0].Rows[15]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha16.Text = Convert.ToDateTime(ds.Tables[0].Rows[16]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha17.Text = Convert.ToDateTime(ds.Tables[0].Rows[17]["FechaDate"]).ToString("dd/MM/yy");
                    lblFecha18.Text = ds.Tables[0].Rows.Count >= 19 ? Convert.ToDateTime(ds.Tables[0].Rows[18]["FechaDate"]).ToString("dd/MM/yy") : string.Empty;
                    lblFecha19.Text = ds.Tables[0].Rows.Count >= 20 ? Convert.ToDateTime(ds.Tables[0].Rows[19]["FechaDate"]).ToString("dd/MM/yy") : string.Empty;
                    lblFecha20.Text = ds.Tables[0].Rows.Count >= 21 ? Convert.ToDateTime(ds.Tables[0].Rows[20]["FechaDate"]).ToString("dd/MM/yy") : string.Empty;
                    lblFecha21.Text = ds.Tables[0].Rows.Count >= 22 ? Convert.ToDateTime(ds.Tables[0].Rows[21]["FechaDate"]).ToString("dd/MM/yy") : string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarReporte()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = new GestionComercialBL().Procesar_Rpt_TableroControlGestionNuevos(2, cboEjecutivo.SelectedValue.ToString());

                dgvControlNuevos.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrilla()
        {
            try
            {
                foreach (DataGridViewRow row in dgvControlNuevos.Rows)
                {
                    if (row.Cells["Clasificacion"].Value.ToString().Trim().Equals("TOTAL") || row.Cells["Clasificacion"].Value.ToString().Trim().Equals("%"))
                    {
                        //row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                        //row.DefaultCellStyle.Font = new Font(dgvControlNuevos.DefaultCellStyle.Font, FontStyle.Bold);
                    }
                }
                dgvControlNuevos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvControlNuevos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvControlNuevos.RowCount > 0)
                {
                    if (dgvControlNuevos.CurrentRow.Cells["Clasificacion"].Value.ToString().Equals("Nro. Operaciones Desembolsadas")
                       || dgvControlNuevos.CurrentRow.Cells["Clasificacion"].Value.ToString().Equals("Importe Desembolsados en S/")
                       || dgvControlNuevos.CurrentRow.Cells["Clasificacion"].Value.ToString().Equals("Nro. Operaciones Proyectadas")
                       || dgvControlNuevos.CurrentRow.Cells["Clasificacion"].Value.ToString().Equals("Importe desembolso Proyectado")
                       || dgvControlNuevos.CurrentRow.Cells["Clasificacion"].Value.ToString().Trim().Equals("TOTAL")
                       || dgvControlNuevos.CurrentRow.Cells["Clasificacion"].Value.ToString().Trim().Equals("%"))
                    {
                        return;
                    }

                    if (dgvControlNuevos.Columns[e.ColumnIndex].Name.ToString().Equals("MetaAcu") || dgvControlNuevos.Columns[e.ColumnIndex].Name.ToString().Equals("RealAcu"))
                    {
                        return;
                    }

                    frmRpt_ControlDiarioNuevosDetalle ofrm = new frmRpt_ControlDiarioNuevosDetalle();
                    ofrm.ColumnName = dgvControlNuevos.Columns[e.ColumnIndex].Name.ToString();
                    ofrm.Clasificacion = dgvControlNuevos.CurrentRow.Cells["Clasificacion"].Value.ToString();
                    ofrm.IdGestor = cboEjecutivo.SelectedValue.ToString();
                    ofrm.Origen = "TableroNuevos";
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