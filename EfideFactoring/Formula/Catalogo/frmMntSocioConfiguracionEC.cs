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

namespace EfideFactoring.Formula.Catalogo
{
    public partial class frmMntSocioConfiguracionEC : FormulaBase.frmMntFiltro
    {
        public frmMntSocioConfiguracionEC()
        {
            InitializeComponent();
        }

        private void frmMntSocioConfiguracionEC_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
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
                DataSet dsDatos = new DataSet();
                SocioConfiguracionECBE oEntity = new SocioConfiguracionECBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSocio_Dsc = TextBoxX1.Text.Trim();
                dsDatos = new SocioConfiguracionECBL().ProcesarSocioConfiguracionEC(oEntity);
                dgvEstadoCuenta.DataSource = dsDatos.Tables[0];

                lblRegistros.Text = dsDatos.Tables[0].Rows.Count + " registro(s)";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Catalogo.frmMntSocioConfiguracionECDato ofrm = new Formula.Catalogo.frmMntSocioConfiguracionECDato();
                ofrm.Operacion = "N";
                ofrm.ShowDialog();
                btnBuscar.PerformClick();
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
                Formula.Catalogo.frmMntSocioConfiguracionECDato ofrm = new Formula.Catalogo.frmMntSocioConfiguracionECDato();
                ofrm.Operacion = "M";
                ofrm.Codigo = dgvEstadoCuenta.CurrentRow.Cells["IdSocio"].Value.ToString();
                ofrm.ShowDialog();
                btnBuscar.PerformClick();
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
                if (dgvEstadoCuenta.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar al socio: " + dgvEstadoCuenta.CurrentRow.Cells["IdSocio_Dsc"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SocioConfiguracionECBE oEntity = new SocioConfiguracionECBE();
                        oEntity.OPCION = 3;
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.IdSocio = dgvEstadoCuenta.CurrentRow.Cells["IdSocio"].Value.ToString();
                        new SocioConfiguracionECBL().ProcesarSocioConfiguracionEC(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar.PerformClick();
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