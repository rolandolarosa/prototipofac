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
    public partial class frmMntTercerCaso : FormulaBase.frmMntFiltro
    {
        public frmMntTercerCaso()
        {
            InitializeComponent();
        }

        private void frmMntTercerCaso_Load(object sender, EventArgs e)
        {
            try
            {
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
                TercercasoBE oEntity = new TercercasoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    Razonsocial = TextBoxX1.Text.Trim()
                };

                ds = new TercerCasoBL().ProcesarTercerCaso(oEntity);
                dgvTercerCaso.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
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
                frmIngresoSocio ofrm = new frmIngresoSocio();
                ofrm.Operacion = "N";
                ofrm.FlgValSocio = "0";
                ofrm.Codigo = string.Empty;
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
                if (dgvTercerCaso.RowCount > 0)
                {
                    frmIngresoSocio ofrm = new frmIngresoSocio();
                    ofrm.Operacion = "M";
                    ofrm.Codigo = dgvTercerCaso.CurrentRow.Cells["IdTercerCaso"].Value.ToString().Trim();
                    ofrm.ShowDialog();
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
                if (dgvTercerCaso.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar: " + dgvTercerCaso.CurrentRow.Cells["RazonSocial"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TercercasoBE oEntity = new TercercasoBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            Razonsocial = dgvTercerCaso.CurrentRow.Cells["IdTercerCaso"].Value.ToString().Trim()
                        };

                        new TercerCasoBL().ProcesarTercerCaso(oEntity);
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

        private void dgvTercerCaso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;
                if (dgvTercerCaso.Columns[e.ColumnIndex].Name == "btnSocios")
                {
                    frmMntTercerCasoSocio ofrm = new frmMntTercerCasoSocio();
                    ofrm.Codigo = dgvTercerCaso.CurrentRow.Cells["IdTercerCaso"].Value.ToString();
                    ofrm.Empresa = dgvTercerCaso.CurrentRow.Cells["Ruc"].Value.ToString() + " - " + dgvTercerCaso.CurrentRow.Cells["RazonSocial"].Value.ToString();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}