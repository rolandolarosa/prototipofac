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
    public partial class frmSociosXUsuarios : FormulaBase.frmMntFiltro
    {
        public frmSociosXUsuarios()
        {
            InitializeComponent();
        }

        private void frmSociosXUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCombos()
        {
            try
            {
                DataSet dsGestor = new GestionComercialBL().ProcesarGestionComercial(0, 0, "", "", 0, 3);
                General.General.LlenarCombobox(cboUsuarios, "nombreCompleto", "gestorID", dsGestor.Tables[0]);
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
                if (string.IsNullOrEmpty(cboUsuarios.SelectedValue.ToString().Trim()))
                {
                    MessageBox.Show("Seleccione un ejecutivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboUsuarios.Focus();
                    return;
                }

                CarteraSocioBE oEntity = new CarteraSocioBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetUsuario,
                    UsuarioID = cboUsuarios.SelectedValue.ToString()
                };
                DataSet ds = new DataSet();
                ds = new CarteraSocioBL().ProcesarCarteraSocio(oEntity);
                dgvSocios.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSocios.Rows.Clear();
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
                if (dgvSocios.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de desasignar los socios del usuario", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvSocios.Rows)
                        {
                            CarteraSocioBE oEntity = new CarteraSocioBE()
                            {
                                OPCION = 3,
                                USUARIO = General.General.GetUsuario,
                                IdSocio = row.Cells["IdSocio"].Value.ToString()
                            };
                            new CarteraSocioBL().ProcesarCarteraSocio(oEntity);
                        }
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