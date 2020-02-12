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
    public partial class frmRpt_CobranzaPagadora : FormulaBase.frmMntDato
    {
        public frmRpt_CobranzaPagadora()
        {
            InitializeComponent();
        }

        private void frmRpt_CobranzaPagadora_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                string IdPagadora = txtIdPagadora.Text;
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_Cobranza", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@IdSocio", IdPagadora);
                    cmd1.Parameters.AddWithValue("@FechaCorte", dtInicio.Value);
                    cmd1.Parameters.AddWithValue("@Opcion", 2);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtCobranzaSocio");
                    con.Close();
                }

                Crystal.crRptCobranzaPagadoraAll ocrLoteLiquidacion = new Crystal.crRptCobranzaPagadoraAll();
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

        private void btnBuscarPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaPagadora ofrmBusquedaPagadora = new Formula.Consulta.frmBusquedaPagadora();
                ofrmBusquedaPagadora.ShowDialog();

                DataSet dsPagadora = new DataSet();
                PagadoraBE PagadoraBE = new PagadoraBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = ofrmBusquedaPagadora.CodigoPagadora.ToString()
                };

                dsPagadora = new PagadoraBL().ProcesarPagadora(PagadoraBE);

                if (dsPagadora.Tables[0].Rows.Count > 0)
                {
                    txtIdPagadora.Text = dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString();
                    txtDescripcion.Text = dsPagadora.Tables[0].Rows[0]["vcPagadora"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdPagadora.Clear();
                txtDescripcion.Clear();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}