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
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

using System.Reflection;
using System.IO;

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmEstadisticaPagadora : FormulaBase.frmMntDato
    {
        public string _IdPagadora = string.Empty;
        public string _IdSocio = string.Empty;
        public string _IdPagadora_Dsc = string.Empty;
        private DataSet _DataSet;

        private Background _Background1 =
            new Background(Color.White, Color.FromArgb(238, 244, 251), 45);

        private Background _Background2 = new Background(Color.FromArgb(249, 249, 234));
        private Background _Background3 = new Background(Color.FromArgb(255, 247, 250));
        private Background Fondo;

        public frmEstadisticaPagadora()
        {
            InitializeComponent();
        }

        private void frmEstadisticaPagadora_Load(object sender, EventArgs e)
        {
            try
            {
                lblPagadora.Text = _IdPagadora_Dsc;
                InitializeGrid();
                BindCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            panel.Name = "Customers";
            panel.ShowToolTips = true;

            panel.MinRowHeight = 20;
            panel.AutoGenerateColumns = true;

            panel.DefaultVisualStyles.GroupByStyles.Default.Background = _Background1;

            panel.SelectionGranularity = SelectionGranularity.Cell;

            superGridControl1.CellValueChanged += SuperGridControl1CellValueChanged;
            superGridControl1.GetCellStyle += SuperGridControl1GetCellStyle;
            superGridControl1.DataBindingComplete += SuperGridControl1DataBindingComplete;
        }

        private void BindCustomerData()
        {
            string location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Resources";

            if (location != null)
            {
                _DataSet = new DataSet();

                string path = Path.Combine(location, "nwind.mdb");

                _DataSet = new GestionComercialBL().ProcesarRptEstadistica(_IdPagadora, _IdSocio, 1);
                _DataSet.Relations.Add("1", _DataSet.Tables[0].Columns["PK"],
                    _DataSet.Tables[1].Columns["PK"], false);
                
                superGridControl1.PrimaryGrid.DataSource = _DataSet;
                superGridControl1.PrimaryGrid.DataMember = _DataSet.Tables[0].TableName;
            }
        }

        void SuperGridControl1GetCellStyle(object sender, GridGetCellStyleEventArgs e)
        {
            GridPanel panel = e.GridPanel;
            Background FondoSoles = new Background(Color.SandyBrown);
            Background FondoDolares = new Background(Color.SpringGreen);

            if (panel.Name.Equals("Table1") == true)
            {
                if (e.GridCell.GridColumn.Name.Equals("Moneda") == true)
                {
                    if (((string)e.GridCell.Value).Trim().Equals("S/")) // SOLES
                    {
                        Fondo = FondoSoles;
                        e.Style.Background = FondoSoles;
                    }
                    else
                    {
                        e.Style.Background = FondoDolares;
                        Fondo = FondoDolares;
                    }
                }
                else
                {
                    e.Style.Background = Fondo;
                }
            }
        }

        void SuperGridControl1DataBindingComplete(
            object sender, GridDataBindingCompleteEventArgs e)
        {
            GridPanel panel = e.GridPanel;

            panel.GroupByRow.Visible = true;

            switch (panel.DataMember)
            {
                case "Table":
                    //CustomizeCustomerPanel(panel);
                    break;

                case "Table1":
                    CustomizeOrdersPanel(panel);
                    UpdateFooter(panel);
                    break;
            }
        }

        void SuperGridControl1CellValueChanged(object sender, GridCellValueChangedEventArgs e)
        {
            GridPanel panel = e.GridPanel;

            // If a cell value in the "Order Details" panel has changed
            // then update its footer to reflect the change

            if (panel.Name.Equals("Table1") == true)
                UpdateFooter(panel);
        }

        private void CustomizeOrdersPanel(GridPanel panel)
        {
            panel.ShowRowGridIndex = true;
            panel.ShowRowDirtyMarker = true;
            panel.ColumnHeader.RowHeight = 30;

            panel.Columns[1].CellStyles.Default.Background =
                new Background(Color.Beige);

            panel.Columns["PK"].Visible = false;
            panel.Columns["valorMonedaID"].Visible = false;
            panel.Columns["Orden"].Visible = false;

            panel.Columns["Moneda"].ReadOnly = true;
            panel.Columns["Moneda"].Width = 80;

            panel.Columns["Descripcion"].HeaderText = "";
            panel.Columns["Descripcion"].ReadOnly = true;
            panel.Columns["Descripcion"].Width = 100;

            panel.Columns["NroDoc"].HeaderText = "NroDoc. / Pag.";
            panel.Columns["NroDoc"].ReadOnly = true;
            panel.Columns["NroDoc"].Width = 90;
            panel.Columns["NroDoc"].CellStyles.Default.Alignment = Alignment.MiddleCenter;

            panel.Columns["Total"].HeaderText = "Total / Pag.";
            panel.Columns["Total"].ReadOnly = true;
            panel.Columns["Total"].Width = 80;
            panel.Columns["Total"].CellStyles.Default.Alignment = Alignment.MiddleRight;

            panel.Columns["NroDocSOC"].HeaderText = "NroDoc. / Socio";
            panel.Columns["NroDocSOC"].ReadOnly = true;
            panel.Columns["NroDocSOC"].Width = 90;
            panel.Columns["NroDocSOC"].CellStyles.Default.Alignment = Alignment.MiddleCenter;

            panel.Columns["TotalSOC"].HeaderText = "Total / Socio";
            panel.Columns["TotalSOC"].ReadOnly = true;
            panel.Columns["TotalSOC"].Width = 80;
            panel.Columns["TotalSOC"].CellStyles.Default.Alignment = Alignment.MiddleRight;

            panel.Caption = new GridCaption();

            //panel.Caption.Text = String.Format("Orders ({0}) for customer <font color=\"Maroon\"><i>\"{1}</i>\"</font>",
            //    panel.Rows.Count, ((GridRow)panel.Parent)["Moneda"].Value);

            panel.DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft;
            panel.DefaultVisualStyles.GroupByStyles.Default.Background = _Background2;
        }

        private void UpdateFooter(GridPanel panel)
        {
            if (panel.Footer == null)
                panel.Footer = new GridFooter();

            string PK = string.Empty;
            foreach (GridContainer item in panel.Rows)
            {
                if (item is GridRow)
                {
                    GridRow row = (GridRow)item;
                    PK = row["PK"].Value.ToString();
                    break;
                }
            }

            DataRow[] drResult = _DataSet.Tables[2].Select("PK = '" + PK + "'");

            foreach (DataRow row in drResult)
            {
                panel.Footer.Text = "AL DIA: " + row["NroAlDia"].ToString() + " | NRO. DOC. VENCIDOS: " + row["NroVenc"].ToString() + " | TOTAL VENCIDOS: " + Convert.ToDecimal(row["TotalVenc"]).ToString("#0.00");   
            }
        }
    }
}