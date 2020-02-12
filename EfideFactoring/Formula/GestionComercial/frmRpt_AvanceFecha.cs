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
    public partial class frmRpt_AvanceFecha : FormulaBase.frmMntDato
    {
        public int Origen = 0;
        public frmRpt_AvanceFecha()
        {
            InitializeComponent();
        }

        private void frmRpt_AvanceFecha_Load(object sender, EventArgs e)
        {
            try
            {
                txtAño.Text = General.General.gFechaOp.Year.ToString();
                LlenarCombos();

                if (Origen == 0)
                {
                    this.TitleText = "Reporte Avance a la Fecha";
                }
                else if (Origen == 1)
                {
                    this.TitleText = "Reporte Avance Gestión nuevos";
                }
                else if (Origen == 2)
                {
                    this.TitleText = "Reporte Avance Gestión Gestor";
                }
                else if (Origen == 3)
                {
                    this.TitleText = "Reporte Análisis Mensual";
                }
                else if (Origen == 4)
                {
                    this.TitleText = "Reporte Avance Rendimiento";
                }
                else if (Origen == 5)
                {
                    this.TitleText = "Reporte Desembolso por Ejecutivo";
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
                String Table_Id = "00213"; //MESES
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                cboMes.DataSource = new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0];
                cboMes.DisplayMember = "Table_Name";
                cboMes.ValueMember = "Table_Value";

                cboMes.SelectedValue = DateTime.Now.Month.ToString().PadLeft(2, '0');
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
                if (Origen == 0)
                {
                    DataSet dsGestionAvance = new DataSet();
                    DataSet dsGestionAvanceResumen = new DataSet();
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("dbo.Rpt_ResumenAvanceDesembolsoXGestor", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Annio", txtAño.Text);
                        cmd1.Parameters.AddWithValue("@Mes", cboMes.SelectedValue.ToString());
                        cmd1.Parameters.AddWithValue("@Opcion", 1);
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsGestionAvance, "dtAvanceGestor");
                        con.Close();
                    }

                    DateTime dt1 = DateTime.Now;
                    DateTime dt2 = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (DateTime.Now.AddMonths(1).Month.ToString()) + "-01");
                    dt2 = dt2.AddDays(-1);
                    int dias = (dt2 - dt1).Days;

                    Crystal.crRpt_ResumenAvanceDesembolsoXGestor ocrLoteLiquidacion = new Crystal.crRpt_ResumenAvanceDesembolsoXGestor();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                    ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    ocrLoteLiquidacion.SetParameterValue("DiasCierre", dias.ToString());
                    ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
                else if (Origen == 1)
                {
                    DataSet dsGestionAvance = new DataSet();
                    DataSet dsGestionAvanceResumen = new DataSet();
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("dbo.Rpt_AvanceGestionNuevos", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Annio", txtAño.Text);
                        cmd1.Parameters.AddWithValue("@Mes", cboMes.SelectedValue.ToString());
                        cmd1.Parameters.AddWithValue("@Opcion", 1);
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsGestionAvance, "dtAvanceGestionNuevos");
                        con.Close();
                    }

                    Crystal.Rpt_AvanceGestionNuevos ocrLoteLiquidacion = new Crystal.Rpt_AvanceGestionNuevos();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                    //ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    //ocrLoteLiquidacion.SetParameterValue("Ejecutivo", cboEjecutivo.Text.ToString());
                    ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
                else if (Origen == 2)
                {
                    DataSet dsGestionAvance = new DataSet();
                    DataSet dsGestionAvanceResumen = new DataSet();
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesembolsoXGestor", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Annio", txtAño.Text);
                        cmd1.Parameters.AddWithValue("@Mes", cboMes.SelectedValue.ToString());
                        cmd1.Parameters.AddWithValue("@Opcion", 1);
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsGestionAvance, "dtRpt_DesembolsoXGestor");
                        con.Close();
                    }

                    DateTime dt1 = DateTime.Now;
                    DateTime dt2 = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (DateTime.Now.AddMonths(1).Month.ToString()) + "-01");
                    dt2 = dt2.AddDays(-1);
                    int dias = (dt2 - dt1).Days;

                    Crystal.Rpt_DesembolsoXGestor ocrLoteLiquidacion = new Crystal.Rpt_DesembolsoXGestor();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                    ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    ocrLoteLiquidacion.SetParameterValue("DiasCierre", dias.ToString());
                    //ocrLoteLiquidacion.SetParameterValue("Ejecutivo", cboEjecutivo.Text.ToString());
                    ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
                else if (Origen == 3)
                {
                    DataSet dsGestionAvance = new DataSet();
                    DataSet dsGestionAvanceResumen = new DataSet();
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesembolsoXEjecutivo_Qry", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Opcion", 3);
                        cmd1.CommandTimeout = 0;
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsGestionAvance, "Report3");
                        con.Close();
                    }

                    Crystal.crRpt_DesembolsoXEjecutivo_3 ocrLoteLiquidacion = new Crystal.crRpt_DesembolsoXEjecutivo_3();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                    ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
                else if (Origen == 4)
                {
                    DataSet dsGestionAvance = new DataSet();
                    DataSet dsGestionAvanceResumen = new DataSet();
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesembolsoXEjecutivo_Qry", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Opcion", 2);
                        cmd1.CommandTimeout = 0;
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsGestionAvance, "Report2");
                        con.Close();
                    }

                    Crystal.crRpt_DesembolsoXEjecutivo_2 ocrLoteLiquidacion = new Crystal.crRpt_DesembolsoXEjecutivo_2();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                    ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
                else if (Origen == 5)
                {
                    DataSet dsGestionAvance = new DataSet();
                    DataSet dsGestionAvanceResumen = new DataSet();
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("dbo.Rpt_DesembolsoXEjecutivo_Qry", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Opcion", 1);
                        cmd1.CommandTimeout = 0;
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsGestionAvance, "Report1");
                        con.Close();
                    }

                    Crystal.crRpt_DesembolsoXEjecutivo_1 ocrLoteLiquidacion = new Crystal.crRpt_DesembolsoXEjecutivo_1();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsGestionAvance);
                    ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                    ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
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