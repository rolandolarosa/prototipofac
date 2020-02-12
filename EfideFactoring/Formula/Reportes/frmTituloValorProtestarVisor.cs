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
using Microsoft.Reporting.WinForms;

namespace EfideFactoring.Formula.Reportes
{
    public partial class frmTituloValorProtestarVisor : DevComponents.DotNetBar.OfficeForm
    {
        public DateTime _dtFechaFiltro = DateTime.MinValue;
        public frmTituloValorProtestarVisor()
        {
            InitializeComponent();
        }

        private void frmTituloValorProtestarVisor_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                CobranzaDetalleBL CobranzaDetalleBL = new CobranzaDetalleBL();
                CobranzaDetalleBE CobranzaDetalleBE = new CobranzaDetalleBE()
                {
                    OPCION = 7,
                    USUARIO = General.General.GetUsuario,
                    sdFechaOp = General.General.gFechaOp,
                    sdVencimiento = _dtFechaFiltro
                };

                ds = CobranzaDetalleBL.ProcesarCobranzaDetalle(CobranzaDetalleBE);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables[0]));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}