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
    public partial class frmQrySolicitudTracking : FormulaBase.frmMntDato
    {
        public frmQrySolicitudTracking()
        {
            InitializeComponent();
        }

        private void frmQrySolicitudTracking_Load(object sender, EventArgs e)
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
                SolicitudTrackingBE oEntity = new SolicitudTrackingBE();
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.OPCION = 1;
                oEntity.IdSolicitud = Codigo;

                DataSet ds = new SolicitudTrackingBL().ProcesarSolicitudTracking(oEntity);
                dgvSolicitudTracking.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}