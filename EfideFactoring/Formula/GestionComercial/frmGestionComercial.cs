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
using EfideFactoring.General;
using System.Data.SqlClient;
using System.Configuration;

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmGestionComercial : DevComponents.DotNetBar.OfficeForm
    {
        public bool _bPermitir = false;
        public bool _bGestor = false;
        DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public frmGestionComercial()
        {
            InitializeComponent();
        }

        private void frmGestionComercial_Load(object sender, EventArgs e)
        {
            try
            {
                txtAño.Text = General.General.gFechaOp.Year.ToString();
                btnBuscar.Focus();
                LlenarCombos();

                if (_bPermitir)
                {
                    cboEjecutivo.Enabled = true;
                }
                else
                {
                    cboEjecutivo.SelectedValue = General.General.GetIdGestor;
                    dgvReporte.Columns["Gestor"].Visible = false;
                }
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
                if (string.IsNullOrEmpty(cboMes.SelectedValue.ToString()))
                {
                    MessageBox.Show("Debe seleccionar un mes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboMes.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cboEjecutivo.SelectedValue.ToString()))
                {
                    dgvReporte.Columns["Gestor"].Visible = true;
                }
                else
                {
                    dgvReporte.Columns["Gestor"].Visible = false;
                }

                ds = new GestionComercialBL().ProcesarGestionComercial(int.Parse(txtAño.Text), int.Parse(cboMes.SelectedValue.ToString()), cboEjecutivo.SelectedValue.ToString(), "", Convert.ToDecimal(txtTipCam.Text), 1);
                dt = ds.Tables[0];
                dgvReporte.DataSource = dt;
                lblRegistros.Text = dgvReporte.Rows.Count + " registro(s)";

                Decimal dTeorico = 0;
                Decimal dReal = 0; 
                Decimal dDesembolso = 0;
                Decimal dDiferencia = 0;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dTeorico += Convert.ToDecimal(dr["PendCob"].ToString());
                    dReal += Convert.ToDecimal(dr["CobReal"].ToString());
                    dDesembolso += Convert.ToDecimal(dr["nDesembolso"].ToString());
                    dDiferencia += Convert.ToDecimal(dr["nDesembolso"].ToString()) - Convert.ToDecimal(dr["CobReal"].ToString());  
                }

                txtTeorica.Text = dTeorico.ToString("N2");
                txtReal.Text = dReal.ToString("N2");
                txtDesembolso.Text = dDesembolso.ToString("N2");
                txtDiferencia.Text = dDiferencia.ToString("N2");

                if (dDiferencia < 0)
                {
                    txtDiferencia.ForeColor = System.Drawing.Color.Red;
                }

                DataSet dsMeta = new GestionComercialBL().ProcesarGestionComercial(int.Parse(txtAño.Text), int.Parse(cboMes.SelectedValue.ToString()), cboEjecutivo.SelectedValue.ToString(), "", Convert.ToDecimal(txtTipCam.Text), 5);

                if (dsMeta.Tables[0].Rows.Count > 0)
                {
                    txtMeta.Text = string.IsNullOrEmpty(dsMeta.Tables[0].Rows[0]["Meta"].ToString()) ? "0.00" : Convert.ToDecimal(dsMeta.Tables[0].Rows[0]["Meta"]).ToString("N2");
                    txtDiasHabiles.Text = dsMeta.Tables[0].Rows[0]["DiasHabiles"].ToString();
                }

                //
                DataSet dsResumenToday = new GestionComercialBL().ProcesarGestionComercial(int.Parse(txtAño.Text), int.Parse(cboMes.SelectedValue.ToString()), cboEjecutivo.SelectedValue.ToString(), "", Convert.ToDecimal(txtTipCam.Text), 8);

                if (dsResumenToday.Tables[0].Rows.Count > 0)
                {
                    txtTeoricaToday.Text = string.IsNullOrEmpty(dsResumenToday.Tables[0].Rows[0]["nTeorico"].ToString()) ? "0.00" : (Convert.ToDecimal(dsResumenToday.Tables[0].Rows[0]["nTeorico"]) - Convert.ToDecimal(dsResumenToday.Tables[0].Rows[0]["nReal"])).ToString("N2");
                    txtRealToday.Text = string.IsNullOrEmpty(dsResumenToday.Tables[0].Rows[0]["nReal"].ToString()) ? "0.00" : Convert.ToDecimal(dsResumenToday.Tables[0].Rows[0]["nReal"]).ToString("N2");
                    txtDesembolsoToday.Text = string.IsNullOrEmpty(dsResumenToday.Tables[0].Rows[0]["nDesembolso"].ToString()) ? "0.00" : Convert.ToDecimal(dsResumenToday.Tables[0].Rows[0]["nDesembolso"]).ToString("N2");
                    txtDiferenciaToday.Text = (Convert.ToDecimal(txtDesembolsoToday.Text) - Convert.ToDecimal(txtRealToday.Text)).ToString("N2");
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
                String Table_Id = "00213"; //MESES
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                cboMes.DataSource = new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0];
                cboMes.DisplayMember = "Table_Name";
                cboMes.ValueMember = "Table_Value";

                cboMes.SelectedValue = DateTime.Now.Month.ToString().PadLeft(2, '0');

                DataSet dsMesCurso = new GestionComercialBL().ProcesarGestionComercial(0, 0, "", "", 0, 6);
                
                if (dsMesCurso.Tables[0].Rows.Count > 0)
                {
                    txtAño.Text = dsMesCurso.Tables[0].Rows[0]["Year"].ToString();
                    cboMes.SelectedValue = dsMesCurso.Tables[0].Rows[0]["Mes"].ToString();
                }

                DataSet dsGestor = new GestionComercialBL().ProcesarGestionComercial(0, 0, "", "", 0, 3);
                General.General.LlenarCombobox(cboEjecutivo, "nombreCompleto", "gestorID", dsGestor.Tables[0], true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;
                if (dgvReporte.Columns[e.ColumnIndex].Name == "btnDetalle")
                {
                    frmGestionComercialDetalle ofrm = new frmGestionComercialDetalle();
                    ofrm.Clasificacion = dgvReporte.CurrentRow.Cells["Clasificacion"].Value.ToString();
                    ofrm.Codigo = dgvReporte.CurrentRow.Cells["IdSocio"].Value.ToString();
                    ofrm._NombreSocio = dgvReporte.CurrentRow.Cells["vcSocio"].Value.ToString();
                    ofrm._NombreGestor = cboEjecutivo.Text;
                    ofrm._IdGestor = cboEjecutivo.SelectedValue.ToString();
                    ofrm._Annio = int.Parse(txtAño.Text);
                    ofrm._Mes = int.Parse(cboMes.SelectedValue.ToString());
                    ofrm._TipCam = Convert.ToDecimal(txtTipCam.Text);
                    ofrm.ShowDialog();
                    //btnBuscar.PerformClick();
                    //txtfilter_KeyUp(null, null);
                    /** Agregado para posicionar el cursor en la fila editada de la grilla */
                    //dgvReporte.Rows[e.RowIndex].Selected = true;
                    //dgvReporte.FirstDisplayedScrollingRowIndex = e.RowIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReporteAvance_Click(object sender, EventArgs e)
        {
            try
            {
                CargarReporteAvanceSemanal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarReporteAvanceSemanal()
        {
            try
            {
                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_GestionAvanceSemanal", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@IdGestor", cboEjecutivo.SelectedValue.ToString());
                    cmd1.Parameters.AddWithValue("@Mes", cboMes.SelectedValue.ToString());
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "dtSemana");

                    SqlCommand cmd2 = new SqlCommand("dbo.Rpt_GestionAvanceSemanal", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@IdGestor", cboEjecutivo.SelectedValue.ToString());
                    cmd2.Parameters.AddWithValue("@Mes", cboMes.SelectedValue.ToString());
                    cmd2.Parameters.AddWithValue("@Opcion", 2);
                    SqlDataAdapter daDet = new SqlDataAdapter(cmd2);
                    daDet.Fill(dsGestionAvance, "dtSemanaResumen");

                    con.Close();
                }

                Crystal.crRptAvanceSemanal ocrLoteLiquidacion = new Crystal.crRptAvanceSemanal();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("Ejecutivo", cboEjecutivo.Text.ToString());
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReporteAvanceFecha_Click(object sender, EventArgs e)
        {
            try
            {
                frmRptAvanceGestion ofrm = new frmRptAvanceGestion();
                ofrm._bPermitir = _bPermitir;
                ofrm._bGestor = _bGestor;
                ofrm._Mes = cboMes.SelectedValue.ToString();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestionAvanceNuevos_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_AvanceGestionNuevos", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Annio", txtAño.Text);
                    cmd1.Parameters.AddWithValue("@Mes", cboMes.SelectedValue.ToString());
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "dtAvanceGestionNuevos");
                    con.Close();
                }

                Crystal.Rpt_AvanceGestionNuevos ocrLoteLiquidacion = new Crystal.Rpt_AvanceGestionNuevos();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                //ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                //ocrLoteLiquidacion.SetParameterValue("Ejecutivo", cboEjecutivo.Text.ToString());
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRptAvanceGestionGestor_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesembolsoXGestor", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Annio", txtAño.Text);
                    cmd1.Parameters.AddWithValue("@Mes", cboMes.SelectedValue.ToString());
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "dtRpt_DesembolsoXGestor");
                    con.Close();
                }

                DateTime dt1 = DateTime.Now;
                DateTime dt2 = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (DateTime.Now.AddMonths(1).Month.ToString()) + "-01");
                dt2 = dt2.AddDays(-1);
                int dias = (dt2 - dt1).Days;

                Crystal.Rpt_DesembolsoXGestor ocrLoteLiquidacion = new Crystal.Rpt_DesembolsoXGestor();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("DiasCierre", dias.ToString());
                //ocrLoteLiquidacion.SetParameterValue("Ejecutivo", cboEjecutivo.Text.ToString());
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSocioNuevos_Click(object sender, EventArgs e)
        {
            try
            {
                frmQrySociosNuevos ofrm = new frmQrySociosNuevos();
                ofrm._Annio = txtAño.Text;
                ofrm._Mes = cboMes.SelectedValue.ToString();
                ofrm._MesText = cboMes.Text.ToString();
                ofrm._IdGestor = cboEjecutivo.SelectedValue.ToString();
                ofrm._IdGestor_Dsc = cboEjecutivo.Text.ToString();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSociosRecuperados_Click(object sender, EventArgs e)
        {
            try
            {
                frmQrySociosRecuperados ofrm = new frmQrySociosRecuperados();
                ofrm._Annio = txtAño.Text;
                ofrm._Mes = cboMes.SelectedValue.ToString();
                ofrm._MesText = cboMes.Text.ToString();
                ofrm._IdGestor = cboEjecutivo.SelectedValue.ToString();
                ofrm._IdGestor_Dsc = cboEjecutivo.Text.ToString();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPagadorasNuevas_Click(object sender, EventArgs e)
        {
            try
            {
                frmQryPagadoraNuevos ofrm = new frmQryPagadoraNuevos();
                ofrm._Annio = txtAño.Text;
                ofrm._Mes = cboMes.SelectedValue.ToString();
                ofrm._MesText = cboMes.Text.ToString();
                ofrm._IdGestor = cboEjecutivo.SelectedValue.ToString();
                ofrm._IdGestor_Dsc = cboEjecutivo.Text.ToString();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReporte_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvReporte.Rows[e.RowIndex];// get you required index
                // check the cell value under your specific column and then you can toggle your colors

                row.DefaultCellStyle.ForeColor = Color.FromName(row.Cells["ColorRows"].Value.ToString());

                row.Cells["Clasificacion"].Style.ForeColor = Color.FromName(row.Cells["ColorRow"].Value.ToString());
                //row.DefaultCellStyle.ForeColor = Color.FromName(row.Cells["ColorRow"].Value.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtfilter_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    dt.DefaultView.RowFilter = string.Format("vcSocio LIKE '%{0}%'", txtfilter.Text);
                }

                lblRegistros.Text = dgvReporte.Rows.Count + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAvanceFecha_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_ResumenAvanceDesembolsoXGestor", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Annio", txtAño.Text);
                    cmd1.Parameters.AddWithValue("@Mes", cboMes.SelectedValue.ToString());
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "dtAvanceGestor");
                    con.Close();
                }
                
                DateTime dt1 = DateTime.Now;
                DateTime dt2 = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (DateTime.Now.AddMonths(1).Month.ToString()) + "-01");
                dt2 = dt2.AddDays(-1);
                int dias = (dt2 - dt1).Days;

                Crystal.crRpt_ResumenAvanceDesembolsoXGestor ocrLoteLiquidacion = new Crystal.crRpt_ResumenAvanceDesembolsoXGestor();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("DiasCierre", dias.ToString());
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSociosRevolvieron_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_ListaSociosRevolvieron", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "dtSociosRevolvieron");
                    con.Close();
                }

                Crystal.crRpt_ListaSociosRevolvieron ocrLoteLiquidacion = new Crystal.crRpt_ListaSociosRevolvieron();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesembolsoXEjecutivo_Qry", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "Report1");
                    con.Close();
                }

                Crystal.crRpt_DesembolsoXEjecutivo_1 ocrLoteLiquidacion = new Crystal.crRpt_DesembolsoXEjecutivo_1();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAvanceRendimiento_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesembolsoXEjecutivo_Qry", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 2);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "Report2");
                    con.Close();
                }

                Crystal.crRpt_DesembolsoXEjecutivo_2 ocrLoteLiquidacion = new Crystal.crRpt_DesembolsoXEjecutivo_2();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnalisisMensual_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesembolsoXEjecutivo_Qry", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 3);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "Report3");
                    con.Close();
                }

                Crystal.crRpt_DesembolsoXEjecutivo_3 ocrLoteLiquidacion = new Crystal.crRpt_DesembolsoXEjecutivo_3();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoProspecto_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionComercial.frmCarteraCandidatoDato ofrmCarteraCandidatoDato = new Formula.GestionComercial.frmCarteraCandidatoDato();
                ofrmCarteraCandidatoDato.Operacion = "N";
                ofrmCarteraCandidatoDato._OrigenGestion = 1;
                ofrmCarteraCandidatoDato.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}