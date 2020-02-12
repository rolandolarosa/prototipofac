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
    public partial class frmRptMovimientoColocaciones : FormulaBase.frmMntDato
    {
        public frmRptMovimientoColocaciones()
        {
            InitializeComponent();
        }

        private void frmRptMovimientoColocaciones_Load(object sender, EventArgs e)
        {
            try
            {
                dtFechaCorte.Value = General.General.gFechaOp;
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
                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_CreditosDesembolsados", con);
                    cmd1.CommandTimeout = 0;
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.Parameters.AddWithValue("@FechaFin", General.General.gFechaOp);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "dtCreditosDes");
                    con.Close();
                }

                Crystal.crRpt_CreditosDesembolsados ocrLoteLiquidacion = new Crystal.crRpt_CreditosDesembolsados();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                //ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                //ocrLoteLiquidacion.SetParameterValue("Ejecutivo", cboEjecutivo.Text.ToString());
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
                General.msgHelper.Wait();
            }
            catch (Exception ex)
            {
                General.msgHelper.Wait();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarCorte_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_CreditosDesembolsados", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 2);
                    cmd1.Parameters.AddWithValue("@FechaFin", dtFechaCorte.Value);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "dsCreditosVigentes");
                    con.Close();
                }
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}