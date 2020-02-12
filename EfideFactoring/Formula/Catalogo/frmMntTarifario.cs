using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Catalogo
{
    public partial class frmMntTarifario : EfideFactoring.FormulaBase.frmMntFiltro
    {
        TarifarioBL TarifarioBL = new TarifarioBL();
        public frmMntTarifario()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntTarifarioDato ofrmMntTarifarioDato = new frmMntTarifarioDato();
                ofrmMntTarifarioDato.Operacion = "N";
                ofrmMntTarifarioDato.ShowDialog();
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                TarifarioBE TarifarioBE = new TarifarioBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetUsuario,
                    tipCxcNombre = TextBoxX1.Text.ToString().Trim(),
                };
                ds = TarifarioBL.ProcesarTarifario(TarifarioBE);
                dgvTarifario.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvTarifario.RowCount > 0)
                {
                    frmMntTarifarioDato ofrmMntTarifarioDato = new frmMntTarifarioDato();
                    ofrmMntTarifarioDato.Operacion = "M";
                    ofrmMntTarifarioDato.Codigo = dgvTarifario.CurrentRow.Cells["IdTarifario"].Value.ToString();
                    ofrmMntTarifarioDato.ShowDialog();
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvTarifario.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de Eliminar ...:" + dgvTarifario.CurrentRow.Cells["/* Agregar el campo a mostrar en el mensaje de confirmación */"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        TarifarioBE TarifarioBE = new TarifarioBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdTarifario = dgvTarifario.CurrentRow.Cells["IdTarifario"].Value.ToString(),
                        };

                        TarifarioBL.ProcesarTarifario(TarifarioBE);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxX1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
