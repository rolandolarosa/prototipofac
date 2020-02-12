using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;
using System.Data.SqlClient;
using System.Configuration;

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmRptAvanceGestion : DevComponents.DotNetBar.OfficeForm
    {
        public bool _bPermitir = false;
        public bool _bGestor = false;
        public string _Mes = string.Empty;
        public frmRptAvanceGestion()
        {
            InitializeComponent();
        }

        private void frmRptAvanceGestion_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                ValidarPermisos(ref _bPermitir);

                if (_bPermitir)
                {
                    cboEjecutivo.Enabled = true;
                }
                else
                {
                    cboEjecutivo.SelectedValue = General.General.GetIdGestor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCombos()
        {
            try
            {
                DataSet dsGestor = new GestionComercialBL().ProcesarGestionComercial(0, 0, "", "", 0, 3);

                DataTable dt = new DataTable();
                dt = dsGestor.Tables[0];

                DataRow dr;
                dr = dt.NewRow();
                dr["nombreCompleto"] = "<<Todos>>";
                dr["gestorID"] = "";
                dt.Rows.InsertAt(dr, 0);

                DataRow dr1;
                dr1 = dt.NewRow();
                dr1["nombreCompleto"] = "<<Equipo Nuevos>>";
                dr1["gestorID"] = "EquipoNuevos";
                dt.Rows.InsertAt(dr1, 1);

                DataRow dr2;
                dr2 = dt.NewRow();
                dr2["nombreCompleto"] = "<<Equipo Mnt>>";
                dr2["gestorID"] = "EquipoMnt";
                dt.Rows.InsertAt(dr2, 2);

                cboEjecutivo.DataSource = dt;
                cboEjecutivo.DisplayMember = "nombreCompleto";
                cboEjecutivo.ValueMember = "gestorID";

                //General.General.LlenarCombobox(cboEjecutivo, "nombreCompleto", "gestorID", dsGestor.Tables[0], true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new GestionComercialBL().ProcesarGestionComercialRpt(DateTime.MinValue, DateTime.MinValue, cboEjecutivo.SelectedValue.ToString(), _Mes, 2);
                dgvReporteSol.DataSource = ds.Tables[0];
                dgvReporteDol.DataSource = ds.Tables[1];

                Decimal dTeoricoSol = 0;
                Decimal dTeoricoDol = 0;
                Decimal dRealSol = 0;
                Decimal dRealDol = 0;
                Decimal dDesembolsoSol = 0;
                Decimal dDesembolsoDol = 0;
                Decimal dTEAPendSol = 0;
                Decimal dTEARealSol = 0;
                Decimal dTEADesemSol = 0;
                Decimal dTEAPendDol = 0;
                Decimal dTEARealDol = 0;
                Decimal dTEADesemDol = 0;
                Decimal dPlazoPendSol = 0;
                Decimal dPlazoRealSol = 0;
                Decimal dPlazoDesemSol = 0;
                Decimal dPlazoPendDol = 0;
                Decimal dPlazoRealDol = 0;
                Decimal dPlazoDesemDol = 0;

                int countSol = 0;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dTeoricoSol += Convert.ToDecimal(dr["PendCob"].ToString());
                    dTEAPendSol += Convert.ToDecimal(dr["PendCobTasa"].ToString());
                    dRealSol += Convert.ToDecimal(dr["CobReal"].ToString());
                    dTEARealSol += Convert.ToDecimal(dr["CobRealTasa"].ToString());
                    dDesembolsoSol += Convert.ToDecimal(dr["nDesembolso"].ToString());
                    dTEADesemSol += Convert.ToDecimal(dr["nDesembolsoTasa"].ToString());
                    dPlazoPendSol += Convert.ToDecimal(dr["PendCobPlazo"].ToString());
                    dPlazoRealSol += Convert.ToDecimal(dr["CobRealPlazo"].ToString());
                    dPlazoDesemSol += Convert.ToDecimal(dr["nDesembolsoPlazo"].ToString());
                    countSol++;
                }

                int countDol = 0;
                foreach (DataRow dr in ds.Tables[1].Rows)
                {
                    dTeoricoDol += Convert.ToDecimal(dr["PendCob"].ToString());
                    dTEAPendDol += Convert.ToDecimal(dr["PendCobTasa"].ToString());
                    dRealDol += Convert.ToDecimal(dr["CobReal"].ToString());
                    dTEARealDol += Convert.ToDecimal(dr["CobRealTasa"].ToString());
                    dDesembolsoDol += Convert.ToDecimal(dr["nDesembolso"].ToString());
                    dTEADesemDol += Convert.ToDecimal(dr["nDesembolsoTasa"].ToString());
                    dPlazoPendDol += Convert.ToDecimal(dr["PendCobPlazo"].ToString());
                    dPlazoRealDol += Convert.ToDecimal(dr["CobRealPlazo"].ToString());
                    dPlazoDesemDol += Convert.ToDecimal(dr["nDesembolsoPlazo"].ToString());
                    countDol++;
                }

                //Resumen en soles
                txtCobranzaTeorica.Text = Convert.ToDecimal(ds.Tables[2].Rows[0]["nTeorico"]).ToString("N2");
                txtCobranzaEfectiva.Text = Convert.ToDecimal(ds.Tables[2].Rows[0]["nReal"]).ToString("N2");
                txtDesembolsoRealizado.Text = Convert.ToDecimal(ds.Tables[2].Rows[0]["nDesembolso"]).ToString("N2");

                //Consolidado en soles
                txtMetaEjecutivo.Text = Convert.ToDecimal(ds.Tables[3].Rows[0]["TotalMeta"]).ToString("N2");
                txtColocadoEjecutivo.Text = Convert.ToDecimal(ds.Tables[3].Rows[0]["TotalnDesembolso"]).ToString("N2");
                txtNroDocEjecutivo.Text = Convert.ToDecimal(ds.Tables[3].Rows[0]["NroDoc"]).ToString("N2");
                txtDiferenciaEjecutivo.Text = Convert.ToDecimal(Convert.ToDecimal(txtMetaEjecutivo.Text) - Convert.ToDecimal(txtColocadoEjecutivo.Text)).ToString("N2");

                txtMeta.Text = Convert.ToDecimal(ds.Tables[4].Rows[0]["TotalMeta"]).ToString("N2");
                txtColocado.Text = Convert.ToDecimal(ds.Tables[4].Rows[0]["TotalnDesembolso"]).ToString("N2");
                txtNroDoc.Text = Convert.ToDecimal(ds.Tables[4].Rows[0]["NroDoc"]).ToString("N2");
                txtDiferencia.Text = Convert.ToDecimal(Convert.ToDecimal(txtMeta.Text) - Convert.ToDecimal(txtColocado.Text)).ToString("N2");

                //Totales en soles y dolares
                txtPendCobroSol.Text = dTeoricoSol.ToString("N2");
                txtCobrRealSol.Text = dRealSol.ToString("N2");
                txtDesembolsoSol.Text = dDesembolsoSol.ToString("N2");

                txtTEATeoricaSol.Text = dTEAPendSol == 0 ? "0.00" : (dTEAPendSol / countSol).ToString("N2");
                txtTEAEfectivaSol.Text = dTEARealSol == 0 ? "0.00" : (dTEARealSol / countSol).ToString("N2");
                txtTEARealizadoSol.Text = dTEADesemSol == 0 ? "0.00" : (dTEADesemSol / countSol).ToString("n2");

                txtPendCobrDol.Text = dTeoricoDol.ToString("N2");
                txtCobrRealDol.Text = dRealDol.ToString("N2");
                txtDesembolsoDol.Text = dDesembolsoDol.ToString("N2");

                txtTEATeoricaDol.Text = dTEAPendDol == 0 ? "0.00" : (dTEAPendDol / countDol).ToString("N2");
                txtTEAEfectivaDol.Text = dTEARealDol == 0 ? "0.00" : (dTEARealDol / countDol).ToString("N2");
                txtTEARealizadoDol.Text = dTEADesemDol == 0 ? "0.00" : (dTEADesemDol / countDol).ToString("N2");

                txtPlazoTeoricaSol.Text = dPlazoPendSol == 0 ? "0.00" : (dPlazoPendSol / countSol).ToString("N0");
                txtPlazoEfectivaSol.Text = dPlazoRealSol == 0 ? "0.00" : (dPlazoRealSol / countSol).ToString("N0");
                txtPlazoRealizadoSol.Text = dPlazoDesemSol == 0 ? "0.00" : (dPlazoDesemSol / countSol).ToString("N0");

                txtPlazoTeoricaDol.Text = dPlazoPendDol == 0 ? "0.00" : (dPlazoPendDol / countDol).ToString("N0");
                txtPlazoEfectivaDol.Text = dPlazoRealDol == 0 ? "0.00" : (dPlazoRealDol / countDol).ToString("N0");
                txtPlazoRealizadoDol.Text = dPlazoDesemDol == 0 ? "0.00" : (dPlazoDesemDol / countDol).ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsGestionAvance = new DataSet();
                DataSet dsGestionAvanceResumen = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.Rpt_CreditosVigentesxProducto", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsGestionAvance, "dsCreditosVigentes");
                    con.Close();
                }

                Crystal.crRpt_CreditosVigentesxProductoX ocrLoteLiquidacion = new Crystal.crRpt_CreditosVigentesxProductoX();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarPermisos(ref bool bPermitir)
        {
            bPermitir = false;
            try
            {
                TableBaseBE oEntity = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    Table_Id = System.Configuration.ConfigurationManager.AppSettings["UsuariosGC"].ToString()
                };
                DataSet ds = new TableBaseBL().ProcesarTableBase(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    string[] ArrayUsuarios = ds.Tables[0].Rows[0]["Table_Value"].ToString().Split('/');

                    foreach (string item in ArrayUsuarios)
                    {
                        if (item.Trim().Equals(General.General.GetUsuario.Trim()))
                        {
                            bPermitir = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}