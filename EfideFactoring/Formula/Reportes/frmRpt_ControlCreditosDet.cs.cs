using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.Configuration;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Reportes
{
    public partial class frmRpt_ControlCreditosDet : FormulaBase.frmMntDato
    {
        public DateTime _dtFechaProceso;
        public string _Entidad;
        public int _Opcion = 2;
        public string _vcGrupo = string.Empty;
        public string _IdGrupo = string.Empty;
        public frmRpt_ControlCreditosDet()
        {
            InitializeComponent();
        }

        private void frmRpt_ControlCreditosDet_Load(object sender, EventArgs e)
        {
            try
            {  
                lblEntidad.Text = _Entidad;
                LlenarCombo();
                CargarDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCombo()
        {
            try
            {
                DataGridViewComboBoxColumn cboColumn = dgvDatos.Columns["IdGrupo"] as DataGridViewComboBoxColumn;
                DataTable dt = new DataTable();

                if (!string.IsNullOrEmpty(_IdGrupo))
                {
                    dt.Columns.Add("IdGrupo");
                    dt.Columns.Add("vcGrupo");

                    DataRow dr;
                    dr = dt.NewRow();
                    dr["IdGrupo"] = "";
                    dr["vcGrupo"] = "--Sin Asignar--";
                    dt.Rows.InsertAt(dr, 0);

                    DataRow dr1;
                    dr1 = dt.NewRow();
                    dr1["IdGrupo"] = _IdGrupo;
                    dr1["vcGrupo"] = _vcGrupo;
                    dt.Rows.InsertAt(dr1, 1);
                }
                else
                {
                    SocioGrupoBE oEntity = new SocioGrupoBE();
                    oEntity.OPCION = 1;
                    oEntity.USUARIO = General.General.GetCodigoUsuario;
                    dt = new SocioGrupoBL().ProcesarSocioGrupo(oEntity).Tables[0];

                    DataRow dr;
                    dr = dt.NewRow();
                    dr["IdGrupo"] = "";
                    dr["vcGrupo"] = "--Sin Asignar--";
                    dt.Rows.InsertAt(dr, 0);

                    //dgvDatos.Columns["IdGrupo"].Visible = false;
                    //dgvDatos.Columns["btnActualizar"].Visible = false;
                }

                cboColumn.DataSource = dt;
                cboColumn.DisplayMember = "vcGrupo";
                cboColumn.ValueMember = "IdGrupo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDetalle()
        {
            try
            {
                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_ControlCreditos", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@IdReferencia", Codigo);
                    cmd1.Parameters.AddWithValue("@FechaProceso", _dtFechaProceso);
                    cmd1.Parameters.AddWithValue("@Opcion", _Opcion);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtDatos");
                    con.Close();
                }

                dgvDatos.DataSource = dsDatos.Tables[0];

                decimal TotalVigente = 0;
                decimal TotalVenc = 0;
                decimal TotalSol = 0;

                foreach (DataGridViewRow Row in dgvDatos.Rows)
                {
                    TotalVigente = TotalVigente + Convert.ToDecimal(Row.Cells["CredMontoVigente"].Value);
                    TotalVenc = TotalVenc + Convert.ToDecimal(Row.Cells["CredMontoVencido"].Value);
                    TotalSol = TotalSol + Convert.ToDecimal(Row.Cells["CredMonto"].Value);
                }

                lblTotalVigente.Text = TotalVigente.ToString("N0");
                lblTotalVencido.Text = TotalVenc.ToString("N0");
                lblTotal.Text = TotalSol.ToString("N0");
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
                if (dgvDatos.Columns[e.ColumnIndex].Name != "IdGrupo" || dgvDatos.Columns[e.ColumnIndex].Name != "btnActualizar")
                {
                    Consulta.frmQryCuotaCredito ofrm = new Consulta.frmQryCuotaCredito();
                    ofrm.Codigo = dgvDatos.CurrentRow.Cells["creditoID"].Value.ToString();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvDatos.Columns[e.ColumnIndex].Name == "btnActualizar")
                {
                    dialogResult = MessageBox.Show("¿Seguro de guardar los cambios?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                        {
                            SqlCommand cmd1 = new SqlCommand("dbo.Rpt_ControlCreditos", con);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.AddWithValue("@IdReferencia", dgvDatos.CurrentRow.Cells["IdGrupo"].Value.ToString());
                            cmd1.Parameters.AddWithValue("@creditoID", dgvDatos.CurrentRow.Cells["creditoID"].Value.ToString());
                            cmd1.Parameters.AddWithValue("@Usuario", General.General.GetCodigoUsuario);
                            cmd1.Parameters.AddWithValue("@Opcion", 5);
                            cmd1.CommandTimeout = 0;
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Se guardó Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}