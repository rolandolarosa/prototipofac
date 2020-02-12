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

namespace EfideFactoring.Formula.Registros
{
    public partial class frmMntLineasAutorizadasLog : DevComponents.DotNetBar.OfficeForm
    {
        public string pIdLinea = string.Empty;
        public string pIdSocio_Dsc = string.Empty;
        public string pnImporte = string.Empty;
        public string pIdMoneda_tt = string.Empty;
        private SocioLineaLogBL SocioLineaLogBL = new SocioLineaLogBL();

        public frmMntLineasAutorizadasLog()
        {
            InitializeComponent();
        }

        private void frmMntLineasAutorizadasLog_Load(object sender, EventArgs e)
        {
            try
            {
                if (!pIdMoneda_tt.Equals("00036"))
                {
                    lblLineaMon.Text = "Línea Actual US$";
                }

                txtSocio_Id_Dsc.Text = pIdSocio_Dsc.Trim();
                txtImporte.Text = pnImporte.Trim();

                SocioLineaLogBE SocioLineaLogBE = new SocioLineaLogBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdLinea = pIdLinea.Trim()
                };
                DataSet ds = new DataSet();
                ds = SocioLineaLogBL.ProcesarSocioLineaLog(SocioLineaLogBE);
                dgvHistorial.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}