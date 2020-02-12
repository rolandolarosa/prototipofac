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
    public partial class frmMntTarifarioExepciones : FormulaBase.frmMntFiltro
    {
        TarifarioBL TarifarioBL = new TarifarioBL();
        public frmMntTarifarioExepciones()
        {
            InitializeComponent();
        }

        private void frmMntTarifarioExepciones_Load(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntTarifarioExepcionesDato ofrmMntTarifarioDato = new frmMntTarifarioExepcionesDato();
                ofrmMntTarifarioDato.Operacion = "N";
                ofrmMntTarifarioDato.ShowDialog();
                btnBuscar.PerformClick();
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
                DataSet ds = new DataSet();
                TarifarioBE TarifarioBE = new TarifarioBE()
                {
                    OPCION = 7,
                    USUARIO = General.General.GetUsuario,
                    tipCxcNombre = TextBoxX1.Text.ToString().Trim(),
                    IdSocio = txtIdSocio.Text
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTarifario.RowCount > 0)
                {
                    frmMntTarifarioExepcionesDato ofrmMntTarifarioDato = new frmMntTarifarioExepcionesDato();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvTarifario.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar registro: " + dgvTarifario.CurrentRow.Cells["IdTarifario"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxX1.Clear();
                txtIdSocio.Clear();
                txtRazonSocialSocio.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}