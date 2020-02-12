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
    public partial class frmMntContactos : FormulaBase.frmMntDato
    {
        public string _IdSocio = string.Empty;
        public frmMntContactos()
        {
            InitializeComponent();
        }

        private void frmMntContactos_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtcontacCargo.Text.Trim()))
                {
                    MessageBox.Show("Ingrese el cargo del contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtcontacArea.Text.Trim()))
                {
                    MessageBox.Show("Ingrese el área del contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtcontacNombre.Text.Trim()))
                {
                    MessageBox.Show("Ingrese el nombre completo del contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtcontacEmail1.Text.Trim()))
                {
                    MessageBox.Show("Ingrese el email del contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                PersonaContactoTDBE oEntity = new PersonaContactoTDBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.IdSocio = _IdSocio;
                oEntity.contacCargo = txtcontacCargo.Text.Trim();
                oEntity.contacArea = txtcontacArea.Text.Trim();
                oEntity.contacNombre = txtcontacNombre.Text.Trim();
                oEntity.contacAnexo = txtcontacAnexo.Text.Trim();
                oEntity.contacEmail1 = txtcontacEmail1.Text.Trim();
                oEntity.contacEmail2 = txtcontacEmail2.Text.Trim();
                new PersonaContactoTDBL().ProcesarPersonaContactoTD(oEntity);

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