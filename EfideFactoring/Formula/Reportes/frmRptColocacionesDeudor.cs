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
    public partial class frmRptColocacionesDeudor : FormulaBase.frmMntDato
    {
        public frmRptColocacionesDeudor()
        {
            InitializeComponent();
        }

        private void frmRptColocacionesDeudor_Load(object sender, EventArgs e)
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
                string Flg_RptMonedaLinea = "1";
                TableBaseBE oEntity = new TableBaseBE();
                oEntity.OPCION = 1;
                oEntity.Table_Id = ConfigurationManager.AppSettings["TT_RptCCDMonedaLinea"].ToString();
                DataSet ds = new TableBaseBL().ProcesarTableBase(oEntity);

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Flg_RptMonedaLinea = ds.Tables[0].Rows[0]["Table_Value"].ToString();
                    }
                }

                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_CreditosVigentesxProducto", con);
                    cmd1.CommandTimeout = 0;
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.Parameters.AddWithValue("@gFechaOp", General.General.gFechaOp);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "dsCreditosVigentes");
                    con.Close();
                }

                Crystal.crRpt_CreditosVigentesxProductoX ocrLoteLiquidacion = new Crystal.crRpt_CreditosVigentesxProductoX();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("Flg_RptMonedaLinea", Flg_RptMonedaLinea);
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