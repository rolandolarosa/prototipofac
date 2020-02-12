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

namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmMntCobranzaSocio : FormulaBase.frmMntFiltro
    {
        private CobranzaBL CobranzaBL = new CobranzaBL();

        public frmMntCobranzaSocio()
        {
            InitializeComponent();
        }

        private void frmMntCobranzaSocio_Load(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                CobranzaBE CobranzaBE = new CobranzaBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetUsuario,
                    Entidad = TextBoxX1.Text.Trim()
                };

                ds = CobranzaBL.ProcesarCobranza(CobranzaBE);
                dgvCobranza.DataSource = ds.Tables[0];
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
                General.General.ValidarTipoCambio();
                frmMntCobranzaSocioDato ofrmMntCobranzaSocioDato = new frmMntCobranzaSocioDato();
                ofrmMntCobranzaSocioDato.Operacion = "N";
                ofrmMntCobranzaSocioDato.ShowDialog();
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
                General.General.ValidarTipoCambio();
                if (dgvCobranza.RowCount > 0)
                {
                    if (dgvCobranza.CurrentRow.Cells["Status"].Value.ToString() == "*")
                    {
                        MessageBox.Show("Esta cobranza está anulada, no se puede editar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    frmMntCobranzaSocioDato ofrmMntCobranzaSocioDato = new frmMntCobranzaSocioDato();
                    ofrmMntCobranzaSocioDato.Operacion = "M";
                    ofrmMntCobranzaSocioDato.Codigo = dgvCobranza.CurrentRow.Cells["IdCobranza"].Value.ToString();
                    ofrmMntCobranzaSocioDato.ShowDialog();
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
                if (dgvCobranza.RowCount > 0)
                {
                    if (dgvCobranza.CurrentRow.Cells["Status"].Value.ToString() == "C")
                    {
                        MessageBox.Show("Esta cobranza está confirmada, no se puede anular", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    dialogResult = MessageBox.Show("Seguro de anular la cobranza Nro. " + dgvCobranza.CurrentRow.Cells["IdCobranza"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        CobranzaBE CobranzaBE = new CobranzaBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdCobranza = dgvCobranza.CurrentRow.Cells["IdCobranza"].Value.ToString(),
                        };

                        CobranzaBL.ProcesarCobranza(CobranzaBE);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TextBoxX1.Clear();
        }
    }
}