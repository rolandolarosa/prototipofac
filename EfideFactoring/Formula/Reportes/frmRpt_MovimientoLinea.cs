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
    public partial class frmRpt_MovimientoLinea : FormulaBase.frmMntDato
    {
        public frmRpt_MovimientoLinea()
        {
            InitializeComponent();
        }

        private void frmRpt_MovimientoLinea_Load(object sender, EventArgs e)
        {
            try
            {
                dtInicio.Value = DateTime.Now.AddMonths(-1);
                dtFin.Value = DateTime.Now;
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
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_MovimientoLinea", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@dtInicio", dtInicio.Value);
                    cmd1.Parameters.AddWithValue("@dtFin", dtFin.Value);
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtLineaMovimiento");
                    con.Close();
                }

                Crystal.crRpt_MovimientoLinea ocrLoteLiquidacion = new Crystal.crRpt_MovimientoLinea();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsDatos);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("dtInicio", dtInicio.Value);
                ocrLoteLiquidacion.SetParameterValue("dtFin", dtFin.Value);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}