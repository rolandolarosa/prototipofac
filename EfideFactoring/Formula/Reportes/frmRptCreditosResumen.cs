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
    public partial class frmRptCreditosResumen : FormulaBase.frmMntDato
    {
        public frmRptCreditosResumen()
        {
            InitializeComponent();
        }

        private void frmRptCreditosResumen_Load(object sender, EventArgs e)
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
                DataSet dsResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_CreditosResumen", con);
                    cmd1.CommandTimeout = 0;
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.Parameters.AddWithValue("@gFechaOp", General.General.gFechaOp);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsResumen, "dtResumen");
                    con.Close();
                }

                Crystal.crRpt_CreditosResumenAll ocrLoteLiquidacion = new Crystal.crRpt_CreditosResumenAll();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsResumen);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("gFechaOp", General.General.gFechaOp);
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
    }
}