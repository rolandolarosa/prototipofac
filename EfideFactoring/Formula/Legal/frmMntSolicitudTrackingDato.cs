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
    public partial class frmMntSolicitudTrackingDato : FormulaBase.frmMntDato
    {
        public string _IdSolicitud = string.Empty;
        public string _IdTracking = string.Empty;
        public frmMntSolicitudTrackingDato()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmMntSolicitudTrackingDato_Load(object sender, EventArgs e)
        {
            try
            {
                if (Operacion.Equals("M"))
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtvComentario.Text.Trim()))
                {
                    MessageBox.Show("Ingresar un comentario o observación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SolicitudTrackingBE oEntity = new SolicitudTrackingBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSolicitud = _IdSolicitud;
                oEntity.IdTipo_tt = "00315"; //Comentario
                oEntity.vComentario = txtvComentario.Text.Trim();
                new SolicitudTrackingBL().ProcesarSolicitudTracking(oEntity);
                
                MessageBox.Show("Se Guardo Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos
        private void CargarDatos()
        {
            try
            {
                SolicitudTrackingBE oEntity = new SolicitudTrackingBE();
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.OPCION = 1;
                oEntity.IdSolicitud = _IdSolicitud;
                oEntity.IdTracking = _IdTracking;
                DataSet ds = new SolicitudTrackingBL().ProcesarSolicitudTracking(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtvComentario.Text = ds.Tables[0].Rows[0]["vComentario"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}