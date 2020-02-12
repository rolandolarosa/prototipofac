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
    public partial class frmRpt_SocioEstado : FormulaBase.frmMntDato
    {
        public frmRpt_SocioEstado()
        {
            InitializeComponent();
        }

        private void frmRpt_SocioEstado_Load(object sender, EventArgs e)
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
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_SocioEstado", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@FechaInicio", dtInicio.Value);
                    cmd1.Parameters.AddWithValue("@FechaFin", dtFin.Value);
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtRpt_SocioEstado");
                    con.Close();
                }

                Crystal.crRpt_SocioEstado ocrLoteLiquidacion = new Crystal.crRpt_SocioEstado();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsDatos);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("FechaInicio", dtInicio.Value);
                ocrLoteLiquidacion.SetParameterValue("FechaFin", dtFin.Value);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}