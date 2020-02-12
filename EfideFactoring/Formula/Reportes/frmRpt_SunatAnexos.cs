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
    public partial class frmRpt_SunatAnexos : FormulaBase.frmMntDato
    {
        public frmRpt_SunatAnexos()
        {
            InitializeComponent();
        }

        private void btnAnexo1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtAnio.Text.Trim()) || TxtAnio.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Se debe ingresar un año correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_SunatAnexos", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Anio", TxtAnio.Text);
                    cmd1.Parameters.AddWithValue("@Usuario", General.General.GetCodigoUsuario);
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtAnexo1");
                    con.Close();
                }

                Crystal.crRpt_Anexo1 ocrLoteLiquidacion = new Crystal.crRpt_Anexo1();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsDatos);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnexo2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtAnio.Text.Trim()) || TxtAnio.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Se debe ingresar un año correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_SunatAnexos", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Anio", TxtAnio.Text);
                    cmd1.Parameters.AddWithValue("@Usuario", General.General.GetCodigoUsuario);
                    cmd1.Parameters.AddWithValue("@Opcion", 2);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtAnexo2");
                    con.Close();
                }

                Crystal.crRpt_Anexo2 ocrLoteLiquidacion = new Crystal.crRpt_Anexo2();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsDatos);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnexo3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtAnio.Text.Trim()) || TxtAnio.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Se debe ingresar un año correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_SunatAnexos", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Anio", TxtAnio.Text);
                    cmd1.Parameters.AddWithValue("@Usuario", General.General.GetCodigoUsuario);
                    cmd1.Parameters.AddWithValue("@Opcion", 3);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtAnexo3");
                    con.Close();
                }

                Crystal.crRpt_Anexo3 ocrLoteLiquidacion = new Crystal.crRpt_Anexo3();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsDatos);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateFileTxt(DataTable dt, string NameFile)
        {
            string fullPath = ConfigurationManager.AppSettings["RutaUnidad"].ToString() + @"\SUNAT\" + NameFile + ".txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fullPath, false, Encoding.Default))
            {
                foreach (DataRow dtItem in dt.Rows)
                {
                    file.WriteLine(dtItem["Trama"].ToString(), Encoding.Default);
                }
            }
        }

        private void btnGenerarA1txt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtAnio.Text.Trim()) || TxtAnio.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Se debe ingresar un año correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_SunatAnexos", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Anio", TxtAnio.Text);
                    cmd1.Parameters.AddWithValue("@Usuario", General.General.GetCodigoUsuario);
                    cmd1.Parameters.AddWithValue("@Opcion", 4);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtAnexo1");
                    con.Close();
                }

                generateFileTxt(dsDatos.Tables[0], "SUNATANEXO1" + DateTime.Now.ToString("yyyyMMddhhss"));
                MessageBox.Show("Se generó correctamente en la unidad Z:\\SUNAT\\", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarA2txt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtAnio.Text.Trim()) || TxtAnio.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Se debe ingresar un año correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_SunatAnexos", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Anio", TxtAnio.Text);
                    cmd1.Parameters.AddWithValue("@Usuario", General.General.GetCodigoUsuario);
                    cmd1.Parameters.AddWithValue("@Opcion", 5);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtAnexo1");
                    con.Close();
                }

                generateFileTxt(dsDatos.Tables[0], "SUNATANEXO2" + DateTime.Now.ToString("yyyyMMddhhss"));
                MessageBox.Show("Se generó correctamente en la unidad Z:\\SUNAT\\", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarA3txt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtAnio.Text.Trim()) || TxtAnio.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Se debe ingresar un año correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_SunatAnexos", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Anio", TxtAnio.Text);
                    cmd1.Parameters.AddWithValue("@Usuario", General.General.GetCodigoUsuario);
                    cmd1.Parameters.AddWithValue("@Opcion", 6);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtAnexo1");
                    con.Close();
                }

                generateFileTxt(dsDatos.Tables[0], "SUNATANEXO3" + DateTime.Now.ToString("yyyyMMddhhss"));
                MessageBox.Show("Se generó correctamente en la unidad Z:\\SUNAT\\", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}