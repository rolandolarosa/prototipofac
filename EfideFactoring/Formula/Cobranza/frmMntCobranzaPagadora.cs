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
//using Efide.Tesoreria.Util;

namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmMntCobranzaPagadora : FormulaBase.frmMntFiltro
    {
        private CobranzaBL CobranzaBL = new CobranzaBL();

        public frmMntCobranzaPagadora()
        {
            InitializeComponent();
        }
        #region Eventos
        private void frmMntCobranzaPagadora_Load(object sender, EventArgs e)
        {
            //Efide.Tesoreria.WinAdeudosInversiones.busqueda.frmBusquedaTransfDepo ofrm = new Efide.Tesoreria.WinAdeudosInversiones.busqueda.frmBusquedaTransfDepo();
            //ofrm.Evento = GetEnum.Eventos.view;
            //ofrm.Show();

            btnBuscar.PerformClick();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                CobranzaBE CobranzaBE = new CobranzaBE()
                {
                    OPCION = 1,
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
                frmMntCobranzaPagadoraDato ofrmMntCobranzaDato = new frmMntCobranzaPagadoraDato();
                ofrmMntCobranzaDato.Operacion = "N";
                ofrmMntCobranzaDato.ShowDialog();
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
                        MessageBox.Show("Esta cobranza está anulada, no se puede modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //if (dgvCobranza.CurrentRow.Cells["Status"].Value.ToString() != "A")
                    //{
                    //    MessageBox.Show("Esta cobranza no se puede editar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    return;
                    //}
                    frmMntCobranzaPagadoraDato ofrmMntCobranzaDato = new frmMntCobranzaPagadoraDato();
                    ofrmMntCobranzaDato.Operacion = "M";
                    ofrmMntCobranzaDato.Codigo = dgvCobranza.CurrentRow.Cells["IdCobranza"].Value.ToString();
                    ofrmMntCobranzaDato.ShowDialog();
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
                    dialogResult = MessageBox.Show("Seguro de Anular la cobranza Nro. " + dgvCobranza.CurrentRow.Cells["IdCobranza"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
        #endregion
    }
}