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
    public partial class frmMntSocioGrupoDet : FormulaBase.frmMntDato
    {
        public frmMntSocioGrupoDet()
        {
            InitializeComponent();
        }

        private void frmMntSocioGrupoDet_Load(object sender, EventArgs e)
        {
            try
            {
                if (Operacion == "M")
                {
                    CargarDatos();
                    CargarDetalle();
                }
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
                SocioGrupoBE oEntity = new SocioGrupoBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdGrupo = Codigo;
                DataSet ds = new DataSet();
                ds = new SocioGrupoBL().ProcesarSocioGrupo(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtIdGrupo.Text = ds.Tables[0].Rows[0]["IdGrupo"].ToString();
                    txtvcGrupo.Text = ds.Tables[0].Rows[0]["vcGrupo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDetalle()
        {
            try
            {
                SocioGrupoDetBE oEntity = new SocioGrupoDetBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdGrupo = Codigo;
                DataSet ds = new DataSet();
                ds = new SocioGrupoDetBL().ProcesarSocioGrupoDet(oEntity);

                dgvSocio.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GuardarDatos()
        {
            bool bResult = false;

            try
            {
                if (string.IsNullOrEmpty(txtvcGrupo.Text))
                {
                    MessageBox.Show("Ingresar el nombre del riesgo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvcGrupo.Focus();
                    return false;
                }

                SocioGrupoBE oEntity = new SocioGrupoBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdGrupo = Codigo;
                oEntity.vcGrupo = txtvcGrupo.Text;
                DataSet ds = new DataSet();

                ds = new SocioGrupoBL().ProcesarSocioGrupo(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Codigo = ds.Tables[0].Rows[0]["IdGrupo"].ToString();
                    bResult = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bResult;
        }

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Codigo))
                {
                    if (!GuardarDatos())
                    {
                        return;
                    }
                }

                if (string.IsNullOrEmpty(txtIdSocio.Text))
                {
                    MessageBox.Show("Se debe seleccionar un socio para agregar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SocioGrupoDetBE oEntity = new SocioGrupoDetBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdGrupo = Codigo;
                oEntity.IdSocio = txtIdSocio.Text;
                new SocioGrupoDetBL().ProcesarSocioGrupoDet(oEntity);
                
                txtIdSocio.Clear();
                txtRazonSocialSocio.Clear();

                CargarDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarSocio_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvSocio.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar el socio: " + dgvSocio.CurrentRow.Cells["IdSocio_Dsc"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SocioGrupoDetBE oEntity = new SocioGrupoDetBE();
                        oEntity.OPCION = 3;
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.IdGrupo = Codigo;
                        oEntity.IdSocio = dgvSocio.CurrentRow.Cells["IdSocio"].Value.ToString();
                        new SocioGrupoDetBL().ProcesarSocioGrupoDet(oEntity);
                        CargarDetalle();
                    }
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
                if (GuardarDatos())
                {
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
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
    }
}