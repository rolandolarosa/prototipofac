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
    public partial class frmQryDatosSocio : FormulaBase.frmMntDato
    {
        public frmQryDatosSocio()
        {
            InitializeComponent();
        }

        private void frmQryDatosSocio_Load(object sender, EventArgs e)
        {
            try
            {
                CargarContactos();
                CargarTelefonos();
                CargarCorreos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarContactos()
        {
            try
            {
                SocioBE oEntity = new SocioBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetUsuario,
                    CodSocio = Codigo
                };
                dgvContactos.DataSource = new SocioBL().ProcesarSocio(oEntity).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTelefonos()
        {
            try
            {
                SocioBE oEntity = new SocioBE()
                {
                    OPCION = 3,
                    USUARIO = General.General.GetUsuario,
                    CodSocio = Codigo
                };
                dgvTelefonos.DataSource = new SocioBL().ProcesarSocio(oEntity).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCorreos()
        {
            try
            {
                SocioBE oEntity = new SocioBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetUsuario,
                    CodSocio = Codigo
                };
                dgvCorreos.DataSource = new SocioBL().ProcesarSocio(oEntity).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarContactos_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionComercial.frmMntContactos ofrm = new Formula.GestionComercial.frmMntContactos();
                ofrm._IdSocio = Codigo.Trim();
                ofrm.ShowDialog();
                CargarContactos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvContactos.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar el teléfono: " + dgvContactos.CurrentRow.Cells["Contacto"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        PersonaContactoTDBE oEntity = new PersonaContactoTDBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdSocio = Codigo.Trim(),
                            contacCargo = dgvContactos.CurrentRow.Cells["Cargo"].Value.ToString(),
                            contacNombre = dgvContactos.CurrentRow.Cells["Contacto"].Value.ToString(),
                        };

                        new PersonaContactoTDBL().ProcesarPersonaContactoTD(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarContactos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionComercial.frmMntTelefono ofrm = new Formula.GestionComercial.frmMntTelefono();
                ofrm._IdSocio = Codigo.Trim();
                ofrm.ShowDialog();
                CargarTelefonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brnEliminarTelefono_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvTelefonos.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar el teléfono: " + dgvTelefonos.CurrentRow.Cells["Telefono"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        TelefonoTDBE oEntity = new TelefonoTDBE()
                        {
                            OPCION = 5,
                            USUARIO = General.General.GetUsuario,
                            IdSocio = Codigo.Trim(),
                            valorCodigoID = int.Parse(dgvTelefonos.CurrentRow.Cells["valorCodigoID"].Value.ToString()),
                            teleTelefono = dgvTelefonos.CurrentRow.Cells["Telefono"].Value.ToString()
                        };

                        new TelefonoTDBL().ProcesarTelefonoTDDA(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTelefonos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionComercial.frmMntEmail ofrm = new Formula.GestionComercial.frmMntEmail();
                ofrm._IdSocio = Codigo.Trim();
                ofrm.ShowDialog();
                CargarCorreos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCorreo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvCorreos.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar el correo: " + dgvCorreos.CurrentRow.Cells["Email"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        EmailTDBE oEntity = new EmailTDBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdSocio = Codigo.Trim(),
                            mailCorreo = dgvCorreos.CurrentRow.Cells["Email"].Value.ToString(),
                        };

                        new EmailTDBL().ProcesarEmailTD(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCorreos();
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