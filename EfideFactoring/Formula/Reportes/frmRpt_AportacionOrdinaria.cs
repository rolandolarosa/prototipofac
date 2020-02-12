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
    public partial class frmRpt_AportacionOrdinaria : FormulaBase.frmMntDato
    {
        public frmRpt_AportacionOrdinaria()
        {
            InitializeComponent();
        }

        private void frmRpt_AportacionOrdinaria_Load(object sender, EventArgs e)
        {
            try
            {
                dtFechaCorte.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_AportacionOrdinaria", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@FechaCorte", dtFechaCorte.Value);
                    cmd1.Parameters.AddWithValue("@Opcion", ChkFlgCtas.Checked ? 1 : 2);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtAportacionOrdinaria");
                    con.Close();
                }

                if (ChkFlgCtas.Checked)
                {
                    Crystal.crRpt_AportacionOrdinaria ocrLoteLiquidacion = new Crystal.crRpt_AportacionOrdinaria();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsDatos);
                    ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    ocrLoteLiquidacion.SetParameterValue("FechaCorte", dtFechaCorte.Value.Date);
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
                else
                {
                    Crystal.crRpt_AportacionOrdinariaF2 ocrLoteLiquidacion = new Crystal.crRpt_AportacionOrdinariaF2();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsDatos);
                    ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    ocrLoteLiquidacion.SetParameterValue("FechaCorte", dtFechaCorte.Value.Date);
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