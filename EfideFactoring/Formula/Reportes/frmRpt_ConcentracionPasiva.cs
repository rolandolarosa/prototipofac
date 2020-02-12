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
    public partial class frmRpt_ConcentracionPasiva : FormulaBase.frmMntDato
    {
        public int _OpcionRpt = 1; // 1 = Reporte Interno; 2 = Reporte Externo
        public frmRpt_ConcentracionPasiva()
        {
            InitializeComponent();
        }

        private void frmRpt_ConcentracionPasiva_Load(object sender, EventArgs e)
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
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_ConcentracionPasiva", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@FechaProceso", FechaProceso);
                    cmd1.Parameters.AddWithValue("@Opcion", _OpcionRpt);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtRpt_ConcentracionPasiva");
                    con.Close();
                }

                if (_OpcionRpt == 1)
                {
                    Crystal.crRpt_ConcentracionPasiva ocrLoteLiquidacion = new Crystal.crRpt_ConcentracionPasiva();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsDatos);
                    ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    ocrLoteLiquidacion.SetParameterValue("FechaProceso", FechaProceso.Date);
                    ocrLoteLiquidacion.SetParameterValue("OpcionRpt", _OpcionRpt);
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
                else
                {
                    Crystal.crRpt_ConcentracionPasiva ocrLoteLiquidacion = new Crystal.crRpt_ConcentracionPasiva();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsDatos);
                    ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    ocrLoteLiquidacion.SetParameterValue("FechaProceso", FechaProceso.Date);
                    ocrLoteLiquidacion.SetParameterValue("OpcionRpt", _OpcionRpt);
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}