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
    public partial class frmGestionPagadora : DevComponents.DotNetBar.OfficeForm
    {
        public frmGestionPagadora()
        {
            InitializeComponent();
        }

        private void frmGestionPagadora_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
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
                GestionPagadoraBE oEntity = new GestionPagadoraBE();
                oEntity.OPCION = 2;
                oEntity.IdGestor = cboEjecutivo.SelectedValue.ToString();
                oEntity.vcPagadora = txtvcPagadora.Text.Trim();
                oEntity.IdEstadoLinea_tt = cboIdEstadoLinea_tt.SelectedValue.ToString();
                DataSet ds = new DataSet();
                ds = new GestionPagadoraBL().ProcesarGestionPagadora(oEntity);
                dgvGestionPagadora.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count + " registro(s)";
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

                String Table_Id = "00030"; //Estado de Lineas
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                DataTable dt = new DataTable();
                dt = new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0];

                DataRow dr;
                dr = dt.NewRow();
                dr["Table_Name"] = "Activa";
                dr["Table_Id"] = "00031";
                dt.Rows.InsertAt(dr, 0);
                DataRow dr1;
                dr1 = dt.NewRow();
                dr1["Table_Name"] = "Inactiva";
                dr1["Table_Id"] = "00451";
                dt.Rows.InsertAt(dr1, 1);
                DataRow dr2;
                dr2 = dt.NewRow();
                dr2["Table_Name"] = "Anulada";
                dr2["Table_Id"] = "00034";
                dt.Rows.InsertAt(dr2, 6);

                //cboIdEstadoLinea_tt.Items.Add({Table_Name = "xx", }

                General.General.LlenarCombobox(cboIdEstadoLinea_tt, "Table_Name", "Table_Id", dt);
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
                txtvcPagadora.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGestionPagadora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;
                if (dgvGestionPagadora.Columns[e.ColumnIndex].Name == "btnDetalle")
                {
                    frmGestionPagadoraDetalle ofrm = new frmGestionPagadoraDetalle();
                    ofrm.Codigo = dgvGestionPagadora.CurrentRow.Cells["IdPagadora"].Value.ToString();
                    ofrm._IdPagadoraDsc = dgvGestionPagadora.CurrentRow.Cells["vcPagadora"].Value.ToString();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdEstadoLinea_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void line8_Click(object sender, EventArgs e)
        {

        }

        private void dgvGestionPagadora_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvGestionPagadora.Rows[e.RowIndex];// get you required index
                // check the cell value under your specific column and then you can toggle your colors

                if (row.Cells["Situacion"].Value.ToString().Equals("Inactiva")
                    || row.Cells["Situacion"].Value.ToString().Equals("Bloqueo Definitivo")
                    || row.Cells["Situacion"].Value.ToString().Equals("Bloqueo Alerta Sentinel")
                    || row.Cells["Situacion"].Value.ToString().Equals("Bloqueo Revisión")
                    || row.Cells["Situacion"].Value.ToString().Equals("Anulada"))
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }

                if (row.Cells["Situacion"].Value.ToString().Equals("Bloqueo Temporal"))
                {
                    row.DefaultCellStyle.ForeColor = Color.Blue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResumenLineaPag_Click(object sender, EventArgs e)
        {
            try
            {
                frmQryResumenLinea ofrm = new frmQryResumenLinea();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResumenXSector_Click(object sender, EventArgs e)
        {
            try
            {
                frmQryResumenSector ofrm = new frmQryResumenSector();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}