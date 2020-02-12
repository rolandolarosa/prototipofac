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

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmMntEmail : FormulaBase.frmMntDato
    {
        public string _IdSocio = string.Empty;
        public frmMntEmail()
        {
            InitializeComponent();
        }

        private void frmMntEmail_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtmailCorreo.Text.Trim()))
                {
                    MessageBox.Show("Se debe un correo válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                EmailTDBE oEntity = new EmailTDBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.IdSocio = _IdSocio;
                oEntity.mailCorreo = txtmailCorreo.Text.Trim();
                new EmailTDBL().ProcesarEmailTD(oEntity);

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}