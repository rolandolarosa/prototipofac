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
    public partial class frmIngresoSocio : FormulaBase.frmMntDato
    {
        TercerCasoBL TercerCasoBL = new TercerCasoBL();
        public string Ruc = string.Empty;
        public string RazonSocialSocio = string.Empty;
        public string FlgValSocio = "1";

        public frmIngresoSocio()
        {
            InitializeComponent();
        }

        #region Eventos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRazonSocial.Clear();
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmIngresoSocio_Load(object sender, EventArgs e)
        {
            try
            {
                btnAceptar.Enabled = false;
                
                if (Operacion.Equals("M"))
                {
                    txtRuc.Enabled = false;
                    txtCodT.Text = Codigo.ToString();
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
                if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()))
                {
                    MessageBox.Show("Debe Ingresar RazonSocial", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if ((string.IsNullOrEmpty(txtRuc.Text.Trim())))
                {
                    MessageBox.Show("Debe Ingresar Ruc", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DataSet dsTercercaso = new DataSet();
                TercercasoBE TercercasoBE = new TercercasoBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdTercerCaso = string.IsNullOrEmpty(Codigo) ? String.Empty : Codigo,
                    Razonsocial = txtRazonSocial.Text.Trim(),
                    Ruc = txtRuc.Text.Trim(),
                    FlgValSocio = FlgValSocio
                };

                dsTercercaso = TercerCasoBL.ProcesarTercerCaso(TercercasoBE);

                if (dsTercercaso.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dsTercercaso.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("El Ruc ingresado ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                RazonSocialSocio = dsTercercaso.Tables[0].Rows[0]["RazonSocial"].ToString();
                Ruc = dsTercercaso.Tables[0].Rows[0]["Ruc"].ToString();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtRuc.Text = "";
            txtRazonSocial.Text = "";
            txtRazonSocial.Focus();
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtRuc_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtRuc.Text.Length == 11)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
        #endregion

        #region Metodos
        private void CargarDatos()
        {
            try
            {
                TercercasoBE oEntity = new TercercasoBE()
                {
                    OPCION = 1,
                    IdTercerCaso = Codigo,
                    USUARIO = General.General.GetCodigoUsuario
                };
                DataSet ds = new TercerCasoBL().ProcesarTercerCaso(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtRazonSocial.Text = ds.Tables[0].Rows[0]["RazonSocial"].ToString();
                    txtRuc.Text = ds.Tables[0].Rows[0]["Ruc"].ToString().Trim();
                    btnAceptar.Enabled = true;
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        #endregion
    }
}