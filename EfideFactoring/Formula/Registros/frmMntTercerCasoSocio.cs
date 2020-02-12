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
    public partial class frmMntTercerCasoSocio : DevComponents.DotNetBar.OfficeForm
    {
        public string Codigo = string.Empty;
        public string Empresa = string.Empty;
        public frmMntTercerCasoSocio()
        {
            InitializeComponent();
        }

        private void frmMntTercerCasoSocio_Load(object sender, EventArgs e)
        {
            try
            {
                lblEmpresaNombre.Text = "Empresa: " + Empresa.Trim();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusquedaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio.ShowDialog();
                txtIdSocio.Text = ofrmBusquedaSocio.CodSocio.Trim();
                txtRazonSocialSocio.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                TercerCasoSocioBE oEntity = new TercerCasoSocioBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetUsuario,
                    IdTercerCaso = Codigo,
                    IdSocio = txtIdSocio.Text.Trim()
                };
                new TercerCasoSocioBL().ProcesarTercerCasoSocio(oEntity);
                txtIdSocio.Clear();
                txtRazonSocialSocio.Clear();
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
                TercerCasoSocioBE oEntity = new TercerCasoSocioBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdTercerCaso = Codigo
                };
                DataSet ds = new TercerCasoSocioBL().ProcesarTercerCasoSocio(oEntity);
                dgvDatos.DataSource = ds.Tables[0];
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
                if (dgvDatos.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar: " + dgvDatos.CurrentRow.Cells["IdSocio_Dsc"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TercerCasoSocioBE oEntity = new TercerCasoSocioBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdTercerCaso = dgvDatos.CurrentRow.Cells["IdTercerCaso"].Value.ToString().Trim(),
                            IdSocio = dgvDatos.CurrentRow.Cells["IdSocio"].Value.ToString().Trim()
                        };

                        new TercerCasoSocioBL().ProcesarTercerCasoSocio(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}