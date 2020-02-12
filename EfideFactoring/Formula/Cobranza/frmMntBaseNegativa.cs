using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBL;
using EfideFactoringBE;

namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmMntBaseNegativa : FormulaBase.frmMntFiltro
    {
        public frmMntBaseNegativa()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Cobranza.frmMntBaseNegativaDato ofrm = new Formula.Cobranza.frmMntBaseNegativaDato();
                ofrm.Operacion = "N";
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
                if (dgvBaseNegativa.RowCount > 0)
                {
                    Formula.Cobranza.frmMntBaseNegativaDato ofrm = new Formula.Cobranza.frmMntBaseNegativaDato();
                    ofrm.Operacion = "M";
                    ofrm.Codigo = dgvBaseNegativa.CurrentRow.Cells["IdBaseNegativa"].Value.ToString();
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
                if (dgvBaseNegativa.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar al candidato: " + dgvBaseNegativa.CurrentRow.Cells["vApePaterno"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        BaseNegativaBE oEntity = new BaseNegativaBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdBaseNegativa = dgvBaseNegativa.CurrentRow.Cells["IdBaseNegativa"].Value.ToString(),
                        };

                        new BaseNegativaBL().ProcesarBaseNegativa(oEntity);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                BaseNegativaBE oEntity = new BaseNegativaBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    vApePaterno = TextBoxX1.Text.ToString().Trim(),
                    vNroDocumento = txtvNroDocumento.Text,
                };
                ds = new BaseNegativaBL().ProcesarBaseNegativa(oEntity);
                dgvBaseNegativa.DataSource = ds.Tables[0];
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
                TextBoxX1.Clear();
                txtvNroDocumento.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}