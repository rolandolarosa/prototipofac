using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfideFactoringBE;
using EfideFactoringBL;
using System.Data.SqlClient;
using System.Configuration;
using CrystalDecisions.Shared;

namespace EfideFactoringPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Iniciando");
                GenerarPDF();
                Close();
                Dispose();
            }
            catch (Exception ex)
            {
                Close();
                Dispose();
            }
        }

        private void GenerarPDF()
        {
            string idloteerror = string.Empty;
            try
            {
                LoteBE oEntity = new LoteBE();
                oEntity.OPCION = 31;
                oEntity.USUARIO = "Ejecutable";
                DataSet ds = new DataSet();
                ds = new LoteBL().ProcesarLote(oEntity);

               
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        DataSet dsLotes = new DataSet(); 
                        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                        {
                            SqlCommand cmd1 = new SqlCommand("Rpt_Lote_Cab", con);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.AddWithValue("@IdLote", dr["IdLote"].ToString());
                            SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                            daCab.Fill(dsLotes, "Rpt_Lote_Cab");    

                            SqlCommand cmd2 = new SqlCommand("Rpt_Lote_Det", con);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@IdLote", dr["IdLote"].ToString());
                            SqlDataAdapter daDet = new SqlDataAdapter(cmd2);
                            daDet.Fill(dsLotes, "Rpt_Lote_Det");

                            con.Close();
                        }

                        EfideFactoring.Formula.Crystal.crRegLiquidacion ocrLoteLiquidacion = new EfideFactoring.Formula.Crystal.crRegLiquidacion();
                        ocrLoteLiquidacion.SetDataSource(dsLotes);
                        ocrLoteLiquidacion.SetParameterValue("usuario", dr["Usuario"].ToString().Trim()); //General.General.GetUsuario);
                        ocrLoteLiquidacion.SetParameterValue("moneda", dsLotes.Tables[0].Rows[0]["IdMoneda_Dsc"].ToString());
                        idloteerror = dr["IdLote"].ToString().Trim();
                        ocrLoteLiquidacion.ExportToDisk(ExportFormatType.PortableDocFormat, ConfigurationManager.AppSettings["RutaArchivoLiquidacionLote"].ToString() + dr["IdLote"].ToString().Trim() + ".pdf");

                        LoteBE oEntity1 = new LoteBE();
                        oEntity1.OPCION = 32;
                        oEntity1.USUARIO = "Ejecutable";
                        oEntity1.IdLote = dr["IdLote"].ToString().Trim();
                        new LoteBL().ProcesarLote(oEntity1);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(idloteerror);
                //MessageBox.Show(ex.Message);
                throw ex;
            }
        }
    }
}
