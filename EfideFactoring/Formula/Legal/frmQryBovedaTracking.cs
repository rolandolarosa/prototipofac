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

namespace EfideFactoring.Formula.Legal
{
    public partial class frmQryBovedaTracking : FormulaBase.frmMntDato
    {
        public string _IdFormatoDocLegal_tt = string.Empty;
        public frmQryBovedaTracking()
        {
            InitializeComponent();
        }

        private void frmQryBovedaTracking_Load(object sender, EventArgs e)
        {
            try
            {
                CargarTracking();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTracking()
        {
            try
            {
                BovedaTrackingBE oEntity = new BovedaTrackingBE();
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.OPCION = 1;
                oEntity.IdBoveda = Codigo;
                oEntity.IdFormatoDocLegal_tt = _IdFormatoDocLegal_tt;

                DataSet ds = new BovedaTrackingBL().ProcesarBovedaTracking(oEntity);
                dgvSolicitudTracking.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}