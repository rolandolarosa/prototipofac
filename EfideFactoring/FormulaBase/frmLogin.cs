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

namespace EfideFactoring.FormulaBase
{
    public partial class frmLogin : DevComponents.DotNetBar.OfficeForm
    {
        private int veces = 0;
        private const int NumeroIntentos = 3;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                txtUsuario.Focus();
                lblSession.Text = General.General.GetSessionGlobal;
                lblUsuario.Text = General.General.GetUsuarioGlobal;
                lblFecha.Text = General.General.GetFechaGlobal.ToShortDateString();
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
                if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
                {
                    MessageBox.Show("Ingrese el nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtClave.Text.Trim()))
                {
                    MessageBox.Show("Ingrese una contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                UsuarioBL UsuarioBL = new UsuarioBL();
                UsuarioBE UsuarioBE = new UsuarioBE()
                {
                    OPCION = 1,
                    usuarioID = txtUsuario.Text.Trim(),
                    usuContrasena = General.General.Encriptar(txtClave.Text),
                    pfecha = EfideFactoring.General.General.gFechaOp
                };
                DataSet ds = new DataSet();
                ds = UsuarioBL.ProcesarUsuario(UsuarioBE);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    General.General.GetUsuario = ds.Tables[0].Rows[0]["usuarioID"].ToString();
                    General.General.GetCodigoUsuario = ds.Tables[0].Rows[0]["usuarioID"].ToString();
                    General.General.GetIdGestor = ds.Tables[0].Rows[0]["IdGestor"].ToString();
                    General.General.gSesionID = ds.Tables[0].Rows[0]["sesionID"].ToString();
                    General.General.gventanillaID = ds.Tables[0].Rows[0]["ventanillaID"].ToString();
                    General.General.GetIdTipoGestor_tt = ds.Tables[0].Rows[0]["IdTipoGestor_tt"].ToString();
                    //EfideFactoring.General.General.gFechaOp = new DateTime(2018, 03, 02, 08, 50, 00);
                    General.General.gRol = ds.Tables[0].Rows[0]["rolGlobal"].ToString();
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    veces = veces + 1;
                    if (veces < NumeroIntentos) 
                    {
                        txtClave.Text = "";
                        txtClave.Focus();
                        MessageBox.Show("Usuario o Constraseña incorrecta" + (char)13 + "Quedan " + (NumeroIntentos - veces) + " intentos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DialogResult = System.Windows.Forms.DialogResult.No;
                }


                //UsuarioBE UsuarioBE2 = new UsuarioBE()
                //{
                //    OPCION = 2,
                //    pfecha = EfideFactoring.General.General.gFechaOp
                //};
                //ds = UsuarioBL.ProcesarUsuario(UsuarioBE2);
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    DialogResult = System.Windows.Forms.DialogResult.OK;
                //}
                //else
                //{
                //    DialogResult = System.Windows.Forms.DialogResult.No;
                //}

            }
            catch (Exception ex)
            {
                DialogResult = System.Windows.Forms.DialogResult.No;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}