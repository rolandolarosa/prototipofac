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

namespace EfideFactoring.Formula.Reportes
{
    public partial class frmRpt_Ahorros : FormulaBase.frmMntDato
    {
        public frmRpt_Ahorros()
        {
            InitializeComponent();
        }

        private void frmRpt_Ahorros_Load(object sender, EventArgs e)
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

        private void LlenarCombos()
        {
            try
            {
                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_ConcentracionPasiva", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 3);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtRpt_ConcentracionPasiva");
                    con.Close();
                }

                cboFechaProceso.DataSource = dsDatos.Tables[0];
                cboFechaProceso.DisplayMember = "FechaProceso";
                cboFechaProceso.ValueMember = "FechaProceso";

                cboFechaProceso.SelectedValue = "Hoy";

                cboMoneda.Items.Add("S/");
                cboMoneda.Items.Add("US$");

                cboMoneda.SelectedIndex = 0;
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
                int Mon = cboMoneda.SelectedIndex == 0 ? 1 : 2;
                DateTime FechaProceso = cboFechaProceso.SelectedValue.Equals("Hoy") ? DateTime.Now : Convert.ToDateTime(cboFechaProceso.SelectedValue.ToString());
                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_Ahorros", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@FechaProceso", FechaProceso);
                    cmd1.Parameters.AddWithValue("@ValorMonedaId", Mon);
                    cmd1.Parameters.AddWithValue("@Usuario", General.General.GetCodigoUsuario);
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtAhorros");
                    con.Close();
                }

                Crystal.CrRpt_Ahorros ocrLoteLiquidacion = new Crystal.CrRpt_Ahorros();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsDatos);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("strFecha", FechaProceso.Date.ToString("dd/MM/yyyy"));
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetCodigoUsuario);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}