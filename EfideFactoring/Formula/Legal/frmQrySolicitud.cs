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
    public partial class frmQrySolicitud : FormulaBase.frmMntDato
    {
        public string _RUC = string.Empty;
        public string _Entidad = string.Empty;
        public frmQrySolicitud()
        {
            InitializeComponent();
        }

        private void frmQrySolicitud_Load(object sender, EventArgs e)
        {
            try
            {
                lblEntidad.Text = _RUC.Trim() + " - " + _Entidad;
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
                SolicitudBE oEntity = new SolicitudBE();
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.OPCION = 8;
                oEntity.IdSolicitud = Codigo;
                oEntity.cRucPagadora = _RUC;
                oEntity.cRucSocio = _RUC;

                DataSet ds = new SolicitudBL().ProcesarSolicitud(oEntity);
                dgvSolicitud.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSolicitud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvSolicitud.Columns[e.ColumnIndex].Name.Equals("btnVerSolicitud"))
                {
                    frmMntSolicitudEvaluacion ofrm = new frmMntSolicitudEvaluacion();
                    ofrm.Operacion = "C";
                    ofrm.Codigo = dgvSolicitud.CurrentRow.Cells["IdSolicitud"].Value.ToString();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}