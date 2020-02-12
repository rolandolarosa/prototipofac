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
using System.Windows.Forms.DataVisualization.Charting;

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmAnalisisCarteraSector : FormulaBase.frmMntDato
    {
        public string _Pagadoras = string.Empty;
        public frmAnalisisCarteraSector()
        {
            InitializeComponent();
        }

        private void frmAnalisisCarteraSector_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos()
        {
            try
            {
                DataSet dsDatos = new GestionComercialBL().ProcesarGestionComercial(0, 0, _Pagadoras, "", 0, 4);
                dgvDatos.DataSource = dsDatos.Tables[0];

                ChartPie.Series[0].Points.Clear();
                ChartPie.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                ChartPie.Titles.Add("Saldo Colocaciones por Setor");
                ChartPie.ChartAreas[0].BackColor = Color.Transparent; 
                ChartPie.Series[0]["PieLabelStyle"] = "Disabled";

                foreach (DataRow dr in dsDatos.Tables[0].Rows)
                {
                    ChartPie.Series[0].Points.AddXY(dr["Sector"].ToString(), decimal.Parse(dr["Utilizado"].ToString()));
                    //ChartPie.Series[0].label
                    //ChartPie.Series[0].Points.AddXY( = dr["Utilizado"].ToString();
                }

                ChartLine.Series[0].Points.Clear();
                ChartLine.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                ChartLine.Titles.Add("Saldo Colocación VS Líneas por Sector");
                ChartLine.ChartAreas[0].BackColor = Color.Transparent;

                Dictionary<string, decimal> LstEntityS1 = new Dictionary<string, decimal>();
                Dictionary<string, decimal> LstEntityS2 = new Dictionary<string, decimal>();

                foreach (DataRow dr in dsDatos.Tables[0].Rows)
                {
                    LstEntityS1.Add(dr["Sector"].ToString(), decimal.Parse(dr["Vigente"].ToString()));
                    LstEntityS2.Add(dr["Sector"].ToString(), decimal.Parse(dr["Utilizado"].ToString()));
                }

                ChartLine.Series.Clear();

                Series barSeries1 = new Series();
                barSeries1.Points.DataBindXY(LstEntityS1.Keys, LstEntityS1.Values);
                barSeries1.Name = "Línea Pagador Vigente";
                barSeries1.Color = Color.Blue;
                barSeries1.ChartType = SeriesChartType.Column;
                barSeries1.ChartArea = "ChartArea1";
                ChartLine.Series.Add(barSeries1);

                Series barSeries2 = new Series();
                barSeries2.Points.DataBindXY(LstEntityS2.Keys, LstEntityS2.Values);
                barSeries2.Name = "Línea Utilizado";
                barSeries2.Color = Color.Red;
                barSeries2.ChartType = SeriesChartType.Column;
                barSeries2.ChartArea = "ChartArea1";
                ChartLine.Series.Add(barSeries2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}