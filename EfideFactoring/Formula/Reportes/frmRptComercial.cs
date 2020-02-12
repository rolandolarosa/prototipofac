using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfideFactoringBL;
using EfideFactoring.General;


namespace EfideFactoring.Formula.Reportes
{
    public partial class frmRptComercial : DevComponents.DotNetBar.OfficeForm
    {
        LoteBL LoteBL = new LoteBL();
        DataTable dtConsulta = new DataTable();
        public frmRptComercial()
        {
            InitializeComponent();
        }

        private void frmRptComercial_Load(object sender, EventArgs e)
        {
            cboEjecutivo.SelectedIndex = 0;
            txtAño.Text = General.General.gFechaOp.Year.ToString();
            txtMes.Text = General.General.MonthName(General.General.gFechaOp.Month).ToUpper() ;
            btnBuscar.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtConsulta = LoteBL.ProcesarRptComercial(General.General.gFechaOp.Year, General.General.gFechaOp.Month, Convert.ToDecimal(txtTipCam.Text));
            dgvReporte.DataSource = dtConsulta;
            lblRegistros.Text = dgvReporte.Rows.Count + " registro(s)";

            // 4) X.nTeorico  5) X.nReal 6) X.nDesembolso 7) X. Diferencia

            Decimal dTeorico = 0;
            Decimal dReal = 0; 
            Decimal dDesembolso = 0;
            Decimal dDiferencia = 0;

            foreach (DataRow dr in dtConsulta.Rows)
            {
                dTeorico += Convert.ToDecimal(dr["nTeorico"].ToString());
                dReal += Convert.ToDecimal(dr["nReal"].ToString());
                dDesembolso += Convert.ToDecimal(dr["nDesembolso"].ToString());
                dDiferencia += Convert.ToDecimal(dr["Diferencia"].ToString());
            }

            txtTeorica.Text = dTeorico.ToString("N2");
            txtReal.Text = dReal.ToString("N2");
            txtDesembolso.Text = dDesembolso.ToString("N2");
            txtDiferencia.Text = dDiferencia.ToString("N2");

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //General.General.ExportToExcel(dtConsulta,null);
            General.msgHelper.ExportToExcel(dtConsulta);
        }

    }
}
