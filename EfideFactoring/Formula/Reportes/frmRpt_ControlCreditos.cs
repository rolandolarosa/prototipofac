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
using System.Data.SqlClient;
using System.Configuration;

namespace EfideFactoring.Formula.Reportes
{
    public partial class frmRpt_ControlCreditos : FormulaBase.frmMntDato
    {
        private decimal nLimiteIndividual = 0;
        private decimal nLimiteRiesgo = 0;
        private DataTable dt = new DataTable();
        public frmRpt_ControlCreditos()
        {
            InitializeComponent();
        }

        private void frmRpt_ControlCreditos_Load(object sender, EventArgs e)
        {
            try
            {
                chkRiesgoUnico.Checked = true;
                LlenarCombos();
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
                IndicadorMensualBE oEntity = new IndicadorMensualBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.dtActualizacion = cboFechaProceso.SelectedValue.Equals("Hoy") ? DateTime.MinValue : Convert.ToDateTime(cboFechaProceso.SelectedValue.ToString());
                ds = new IndicadorMensualBL().ProcesarIndicadorMensual(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtdtActualizacion.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["dtActualizacion"].ToString()).ToString("d");
                    txtnImporte.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"].ToString()).ToString("N0");
                    txtnLimiteIndividual.Text = ((Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"]) * Convert.ToDecimal(ds.Tables[0].Rows[0]["nLimiteIndividual"])) / 100).ToString("N0");
                    txtnLimiteRiesgo.Text = ((Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"]) * Convert.ToDecimal(ds.Tables[0].Rows[0]["nLimiteRiesgo"])) / 100).ToString("N0");
                    txtLiminte15.Text = ((Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"]) * 15) / 100).ToString("N0");
                    txtLiminte20.Text = ((Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"]) * 20) / 100).ToString("N0");
                    lblnLimiteIndividual.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["nLimiteIndividual"]).ToString("N0") + "%";
                    lblnLimiteRiesgo.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["nLimiteRiesgo"]).ToString("N0") + "%";
                    txtTipoCambio.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["TipoCambio"]).ToString();
                    nLimiteIndividual = Convert.ToDecimal(ds.Tables[0].Rows[0]["nLimiteIndividual"]);
                    nLimiteRiesgo = Convert.ToDecimal(ds.Tables[0].Rows[0]["nLimiteRiesgo"]);
                }
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
                DataSet ds = new DataSet();
                IndicadorMensualBE oEntity = new IndicadorMensualBE();
                oEntity.OPCION = 4;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                ds = new IndicadorMensualBL().ProcesarIndicadorMensual(oEntity);

                cboFechaProceso.DataSource = ds.Tables[0];
                cboFechaProceso.DisplayMember = "FechaProceso";
                cboFechaProceso.ValueMember = "FechaProceso";

                cboFechaProceso.SelectedValue = "Hoy";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatoGrid()
        {
            try
            {
                foreach (DataGridViewRow row in dgvControlCreditos.Rows)
                {
                    if (row.Cells["codCliente"].Value.ToString().Trim().Length == 5)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Blue;
                    }

                    if (!string.IsNullOrEmpty(row.Cells["CredExedido"].Value.ToString()))
                    {
                        if (Convert.ToDecimal(row.Cells["CredExedido"].Value) > 0)
                            row.DefaultCellStyle.ForeColor = Color.Red;

                        //if (row.Cells["Tipo"].Value.ToString().Equals("I"))
                        //{
                        //    if (Convert.ToDecimal(row.Cells["CredExedidoPrj"].Value) > nLimiteIndividual)
                        //        row.DefaultCellStyle.ForeColor = Color.Red;
                        //}
                        //else
                        //{
                        //    if (Convert.ToDecimal(row.Cells["CredExedidoPrj"].Value) > nLimiteRiesgo)
                        //        row.DefaultCellStyle.ForeColor = Color.Red;
                        //}   
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Totalizar()
        {
            try
            {
                decimal TotalSol = 0;
                decimal TotalDol = 0;
                decimal Total = 0;

                foreach (DataGridViewRow row in dgvControlCreditos.Rows)
                {
                    TotalSol = TotalSol + (string.IsNullOrEmpty(row.Cells["CredMontoSol"].Value.ToString()) ? 0 : Convert.ToDecimal(row.Cells["CredMontoSol"].Value.ToString()));
                    TotalDol = TotalDol + (string.IsNullOrEmpty(row.Cells["CredMontoDol"].Value.ToString()) ? 0 : Convert.ToDecimal(row.Cells["CredMontoDol"].Value.ToString()));
                    Total = Total + (string.IsNullOrEmpty(row.Cells["CredMonto"].Value.ToString()) ? 0 : Convert.ToDecimal(row.Cells["CredMonto"].Value.ToString()));
                }

                lblTotalSol.Text = TotalSol.ToString("N0");
                lblTotalDol.Text = TotalDol.ToString("N0");
                lblTotal.Text = Total.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboFechaProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboFechaProceso.SelectedIndex != 0)
                {
                    CargarDatos();
                }
                else if (cboFechaProceso.SelectedValue.ToString().Equals("Hoy"))
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime FechaProceso = cboFechaProceso.SelectedValue.Equals("Hoy") ? DateTime.Now : Convert.ToDateTime(cboFechaProceso.SelectedValue.ToString());
                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_ControlCreditos", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@RazonSocial", txtRazonSocial.Text);
                    cmd1.Parameters.AddWithValue("@FechaProceso", FechaProceso.Date);
                    cmd1.Parameters.AddWithValue("@Opcion", chkRiesgoUnico.Checked ? 1 : 3);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtDatos");
                    con.Close();
                }

                dt = dsDatos.Tables[0];
                dgvControlCreditos.DataSource = dt;
                FormatoGrid();
                Totalizar();
                lblRegistros.Text = dgvControlCreditos.Rows.Count + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvControlCreditos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DateTime FechaProceso = cboFechaProceso.SelectedValue.Equals("Hoy") ? DateTime.Now : Convert.ToDateTime(cboFechaProceso.SelectedValue.ToString());
                if (dgvControlCreditos.Rows.Count > 0)
                {
                    frmRpt_ControlCreditosDet ofrm = new frmRpt_ControlCreditosDet();
                    ofrm.Codigo = dgvControlCreditos.CurrentRow.Cells["codCliente"].Value.ToString();
                    ofrm._Opcion = chkRiesgoUnico.Checked ? 2 : 4;
                    ofrm._dtFechaProceso = FechaProceso;
                    ofrm._Entidad = dgvControlCreditos.CurrentRow.Cells["razonSocial"].Value.ToString();
                    ofrm._IdGrupo = dgvControlCreditos.CurrentRow.Cells["Tipo"].Value.ToString().Equals("G") ? dgvControlCreditos.CurrentRow.Cells["codCliente"].Value.ToString().Trim() : string.Empty;
                    ofrm._vcGrupo = dgvControlCreditos.CurrentRow.Cells["Tipo"].Value.ToString().Equals("G") ? dgvControlCreditos.CurrentRow.Cells["razonSocial"].Value.ToString().Trim() : string.Empty;
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvControlCreditos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                FormatoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRazonSocial_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    dt.DefaultView.RowFilter = string.Format("razonSocial LIKE '%{0}%'", txtRazonSocial.Text);
                }

                lblRegistros.Text = dgvControlCreditos.Rows.Count + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}