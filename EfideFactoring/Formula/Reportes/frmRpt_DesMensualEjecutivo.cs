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

namespace EfideFactoring.Formula.Reportes
{
    public partial class frmRpt_DesMensualEjecutivo : FormulaBase.frmMntDato
    {
        public frmRpt_DesMensualEjecutivo()
        {
            InitializeComponent();
        }

        private void btnDesembolsosSoles_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesMensualEjecutivo", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Anio", DateTime.Now.Year.ToString());
                    cmd1.Parameters.AddWithValue("@valorMonedaID", 1);
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtRpt_DesMensualEjecutivo");
                    con.Close();
                }

                Crystal.crRpt_DesMensualEjecutivo ocrLoteLiquidacion = new Crystal.crRpt_DesMensualEjecutivo();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsDatos);
                //ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("Titulo", "DESEMBOLSOS MENSUAL POR EJECUTIVO (TEAprom, Plazoprom) SOLES");
                //ocrLoteLiquidacion.SetParameterValue("FechaFin", dtFin.Value);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesembolsosDolares_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesMensualEjecutivo", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Anio", DateTime.Now.Year.ToString());
                    cmd1.Parameters.AddWithValue("@valorMonedaID", 2);
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtRpt_DesMensualEjecutivo");
                    con.Close();
                }

                Crystal.crRpt_DesMensualEjecutivo ocrLoteLiquidacion = new Crystal.crRpt_DesMensualEjecutivo();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsDatos);
                //ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("Titulo", "DESEMBOLSOS MENSUAL POR EJECUTIVO (TEAprom, Plazoprom) DOLARES");
                //ocrLoteLiquidacion.SetParameterValue("FechaFin", dtFin.Value);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesemMensualEjec_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesMensualEjecutivo", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Anio", DateTime.Now.Year.ToString());
                    cmd1.Parameters.AddWithValue("@valorMonedaID", 2);
                    cmd1.Parameters.AddWithValue("@Opcion", 2);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtRpt_DesMensualEjecutivo");
                    con.Close();
                }

                Crystal.crRpt_DesMensualEjecutivo ocrLoteLiquidacion = new Crystal.crRpt_DesMensualEjecutivo();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsDatos);
                //ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("Titulo", "DESEMBOLSOS MENSUAL POR EJECUTIVO EN SOLES");
                //ocrLoteLiquidacion.SetParameterValue("FechaFin", dtFin.Value);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesMenSector_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesMensualEjecutivo", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Anio", DateTime.Now.Year.ToString());
                    cmd1.Parameters.AddWithValue("@valorMonedaID", 2);
                    cmd1.Parameters.AddWithValue("@Opcion", 3);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtRpt_DesMensualEjecutivo");
                    con.Close();
                }

                Crystal.crRpt_DesMensualSector ocrLoteLiquidacion = new Crystal.crRpt_DesMensualSector();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsDatos);
                //ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("Titulo", "DESEMBOLSOS MENSUALES POR SECTOR S/.");
                //ocrLoteLiquidacion.SetParameterValue("FechaFin", dtFin.Value);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}