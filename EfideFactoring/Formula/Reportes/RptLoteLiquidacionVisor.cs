using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.Reporting.WinForms;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Reportes
{
    public partial class RptLoteLiquidacionVisor : DevComponents.DotNetBar.OfficeForm
    {
        public string IdLote = string.Empty;
        LoteBL LoteBL = new LoteBL();
        DataSet ds = new DataSet();
        DataSet dsDet = new DataSet();

        public RptLoteLiquidacionVisor()
        {
            InitializeComponent();
        }

        private void RptLoteLiquidacionVisor_Load(object sender, EventArgs e)
        {
            LoteBE ILote = new LoteBE()
            {
                OPCION = 1,
                IdLote = IdLote
            };
            ds = LoteBL.ProcesarRptLote(ILote);
            
            ILote.OPCION = 2;
            dsDet = LoteBL.ProcesarRptLote(ILote);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dsDet.Tables[0]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", ds.Tables[0]));
            reportViewer1.RefreshReport();


        }
    }
}