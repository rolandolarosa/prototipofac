using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EfideFactoring.Formula.Reportes
{
    public partial class frmRptCobranza : EfideFactoring.FormulaBase.frmMntDato
    {
        public frmRptCobranza()
        {
            InitializeComponent();
        }

        private void btnBusquedaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio.ShowDialog();
                txtIdSocio.Text = ofrmBusquedaSocio.CodSocio.Trim();
                txtRazonSocialSocio.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdSocio.Clear();
            txtRazonSocialSocio.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                string IdSocio = txtIdSocio.Text;
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_Cobranza", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@IdSocio", IdSocio);
                    cmd1.Parameters.AddWithValue("@FechaCorte", dtInicio.Value);
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtCobranzaSocio");
                    con.Close();
                }

                Crystal.crRptCobranzaSocioAll ocrLoteLiquidacion = new Crystal.crRptCobranzaSocioAll();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsDatos);
                ocrLoteLiquidacion.SetParameterValue("usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("FechaCorte", dtInicio.Value);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
