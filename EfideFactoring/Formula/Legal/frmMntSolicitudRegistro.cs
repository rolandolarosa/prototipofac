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
    public partial class frmMntSolicitudRegistro : FormulaBase.frmMntDato
    {
        public string _RUC = string.Empty;
        public string _Entidad = string.Empty;
        public frmMntSolicitudRegistro()
        {
            InitializeComponent();
        }

        private void frmMntSolicitudRegistro_Load(object sender, EventArgs e)
        {
            try
            {
                lblEntidad.Text = _RUC.Trim() + " - " + _Entidad;
                CargarDatos();

                if (Operacion.Equals("C"))
                {
                    btnAgregar.Visible = false;
                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Metodos
        private void CargarDatos()
        {
            try
            {
                SolicitudRegistroBE oEntity = new SolicitudRegistroBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.IdSolicitud = Codigo;
                DataSet ds = new SolicitudRegistroBL().ProcesarSolicitudRegistro(oEntity);
                dgvRegistro.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntSolicitudRegistroDato ofrm = new frmMntSolicitudRegistroDato();
                ofrm.Operacion = "N";
                ofrm.Codigo = Codigo;
                ofrm.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntSolicitudRegistroDato ofrm = new frmMntSolicitudRegistroDato();
                ofrm.Operacion = "M";
                ofrm.Codigo = Codigo;
                ofrm.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvRegistro.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar a la solicitud: " + dgvRegistro.CurrentRow.Cells["IdTipoRegistro_tt_Dsc"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SolicitudRegistroBE oEntity = new SolicitudRegistroBE();
                        oEntity.OPCION = 3;
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.IdSolicitud = Codigo;
                        oEntity.IdTipoRegistro_tt = dgvRegistro.CurrentRow.Cells["IdTipoRegistro_tt"].Value.ToString();
                        new SolicitudRegistroBL().ProcesarSolicitudRegistro(oEntity);
                        CargarDatos();
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}