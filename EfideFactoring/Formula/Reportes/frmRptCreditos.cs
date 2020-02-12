using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Reportes
{
    public partial class frmRptCreditos : EfideFactoring.FormulaBase.frmMntDato
    {
        PrestamoRepBL oPrestamoRepBL = new PrestamoRepBL();
        public frmRptCreditos()
        {
            InitializeComponent();
        }

        private void frmRptPrestamos_Load(object sender, EventArgs e)
        {
            cboEstatus.SelectedIndex = 0;
            cboMonedaID.SelectedIndex = 0;
            cboTipoPersona.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int intMoneda = 0;
            string strTipoPer = "";
            int intEstatus = 0;
            int intTasa = 0;

            switch (cboEstatus.SelectedIndex)
            {
                case 1:
                    intEstatus = 5; //Generado
                    break;
                case 2:
                    intEstatus = 6; //Desembolsado
                    break;
                case 3:
                    intEstatus = 7; //Cancelado
                    break;
                default:
                    intEstatus = 0; //Todos
                    break;
            }

            switch (cboMonedaID.SelectedIndex)
            {
                case 1:
                    intMoneda = 1; //Soles
                    break;
                case 2:
                    intMoneda = 2; //Dolares
                    break;
                default:
                    intMoneda = 0; //Todos
                    break;
            }

            switch (cboTipoPersona.SelectedIndex)
            {
                case 1:
                    strTipoPer = "PN"; //PN
                    break;
                case 2:
                    strTipoPer = "PJ"; //PN
                    break;
                default:
                    strTipoPer = ""; //Todos
                    break;
            }

            try
            {
                string strSubTitulo = "";
                intEstatus = chkVigente.Checked? 1 : 0;
                intTasa = chkTasa.Checked ? 1 : 0;
                DataSet ds = new DataSet();
                PrestamoRepBE oPrestamoRepBE = new PrestamoRepBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    dtFecRegIni = dtInicio.Value,
                    dtFecRegFin = dtFin.Value,
                    MonedaID = intMoneda,
                    TipPerID = strTipoPer,
                    ClienteID = txtIdSocio.Text.Trim(),
                    IdPagadora = txtIdPagadora.Text.Trim(),
                    EstatusID = intEstatus,
                    bTasa = intTasa
                };


                if (intEstatus==1)
                    strSubTitulo="Lo vigente a la fecha";
                else
                    strSubTitulo= "Del " + dtInicio.Text + " al " + dtFin.Text ;

                ds = oPrestamoRepBL.ReporteSocio(oPrestamoRepBE);

                //Crystal.crRptPrestamoSocio ocrRptPrestamoSocio = new Crystal.crRptPrestamoSocio();
                Crystal.crRptPrestamoAll ocrRptPrestamoSocio = new Crystal.crRptPrestamoAll();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ocrRptPrestamoSocio.SetDataSource(ds.Tables[0]);
                
                ocrRptPrestamoSocio.SetParameterValue("usuario", General.General.GetUsuario);
                ocrRptPrestamoSocio.SetParameterValue("subtitulo", strSubTitulo);

                //ocrRptPrestamoSocio.SetParameterValue("TipoPersona",   cboTipoPersona.SelectedItem.ToString() );
                //ocrRptPrestamoSocio.SetParameterValue("FechaRegistro", dtInicio.Text + " al " + dtFin.Text);
                //ocrRptPrestamoSocio.SetParameterValue("Moneda", cboMonedaID.SelectedItem.ToString() ) ;
                //ocrRptPrestamoSocio.SetParameterValue("Estatus", cboEstatus.SelectedItem.ToString() );

                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrRptPrestamoSocio;
                ofrmVisorLoteLiquidacion.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //try
            //{
            //    String strIdLote = txtIdLote.Text.Trim();
            //    DataSet dsLotes = new DataSet();
            //    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
            //    {
            //        SqlCommand cmd1 = new SqlCommand("Rpt_Lote_Cab", con);
            //        cmd1.CommandType = CommandType.StoredProcedure;
            //        cmd1.Parameters.AddWithValue("@IdLote", strIdLote);
            //        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
            //        daCab.Fill(dsLotes, "Rpt_Lote_Cab");

            //        SqlCommand cmd2 = new SqlCommand("Rpt_Lote_Det", con);
            //        cmd2.CommandType = CommandType.StoredProcedure;
            //        cmd2.Parameters.AddWithValue("@IdLote", strIdLote);
            //        SqlDataAdapter daDet = new SqlDataAdapter(cmd2);
            //        daDet.Fill(dsLotes, "Rpt_Lote_Det");

            //        con.Close();
            //    }

            //    Crystal.crRegLiquidacion ocrLoteLiquidacion = new Crystal.crRegLiquidacion();
            //    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
            //    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
            //    ocrLoteLiquidacion.SetDataSource(dsLotes);
            //    ocrLoteLiquidacion.SetParameterValue("usuario", General.General.GetUsuario);
            //    ofrmVisorLoteLiquidacion.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }

        private void btnBusquedaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio._Opcion = 13;
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

        private void btnLimpiarPagadora_Click(object sender, EventArgs e)
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

        private void chkVigente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVigente.Checked)
            {
                dtInicio.Enabled = false;
                dtFin.Enabled = false;
                //dtInicio.ResetText();
                //dtFin.ResetText();
            }
            else
            {
                dtInicio.Enabled = true;
                dtFin.Enabled = true;
            }
        }
    }
}
