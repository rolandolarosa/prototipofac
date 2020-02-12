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

namespace EfideFactoring.Formula.GestionPagadora
{
    public partial class frmAnalisisSector : FormulaBase.frmMntDato
    {
        public frmAnalisisSector()
        {
            InitializeComponent();
        }

        private void frmAnalisisSector_Load(object sender, EventArgs e)
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
                GestionPagadoraBE IEntity = new GestionPagadoraBE();
                IEntity.OPCION = 5;
                IEntity.IdPagadora = Codigo;
                DataSet ds = new GestionPagadoraBL().ProcesarGestionPagadora(IEntity);

                dgvSectores.DataSource = ds.Tables[0];
                ChartPie.Series[0].Points.Clear();
                ChartPie.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                ChartPie.Titles.Add("Uso de Líneas por Sector").Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
                ChartPie.ChartAreas[0].BackColor = Color.Transparent;
                ChartPie.ChartAreas[0].AxisX.LabelStyle.Enabled = true;
                ChartPie.Series[0]["PieLabelStyle"] = "Disabled"; //Deshabilitar los labels

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(dr["IdSector_tt_Dsc"].ToString(), decimal.Parse(dr["Saldo"].ToString()));
                    point.ToolTip = string.Format("{0} : {1}%", dr["IdSector_tt_Dsc"].ToString(), decimal.Parse(dr["Porj"].ToString()).ToString("N2"));
                    ChartPie.Series[0].Points.Add(point);
                    //ChartPie.Series[0].Points.AddXY(dr["IdSector_tt_Dsc"].ToString(), decimal.Parse(dr["Saldo"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}