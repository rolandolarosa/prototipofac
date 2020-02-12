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
    public partial class frmGrupoPagadora : FormulaBase.frmMntFiltro
    {
        GrupoPagadoraBL GrupoPagadoraBL = new GrupoPagadoraBL();
        GrupoPagadoraDetalleBL GrupoPagadoraDetalleBL = new GrupoPagadoraDetalleBL();

        public frmGrupoPagadora()
        {
            InitializeComponent();
        }

        private void frmGrupoPagadora_Load(object sender, EventArgs e)
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

        #region Eventos ---------------------------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet dsGrupoPagadora = new DataSet();
            GrupoPagadoraBE GrupoPagadoraBE = new GrupoPagadoraBE()
            {
                OPCION = 1,
                USUARIO = General.General.GetCodigoUsuario,
                vcGrupo = TextBoxX1.Text.Trim()
            };

            dsGrupoPagadora = GrupoPagadoraBL.ProcesarGrupoPagadora(GrupoPagadoraBE);

            dgvGrupoPagadoras.DataSource = dsGrupoPagadora.Tables[0];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmGrupoPagadoraDato ofrmGrupoPagadoraDato = new Formula.Catalogo.frmGrupoPagadoraDato();
            ofrmGrupoPagadoraDato.Operacion = "N";
            ofrmGrupoPagadoraDato.ShowDialog();
            btnBuscar.PerformClick();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGrupoPagadoras.Rows.Count > 0)
                {
                    Formula.Catalogo.frmGrupoPagadoraDato ofrmGrupoPagadoraDato = new Formula.Catalogo.frmGrupoPagadoraDato();
                    ofrmGrupoPagadoraDato.Operacion = "M";
                    ofrmGrupoPagadoraDato.Codigo = dgvGrupoPagadoras.CurrentRow.Cells["IdGrupoPagadora"].Value.ToString();
                    ofrmGrupoPagadoraDato.ShowDialog();
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void dgvGrupoPagadoras_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrupoPagadoras.Rows.Count > 0)
            {
                String IdGrupoPagadora = dgvGrupoPagadoras.CurrentRow.Cells["IdGrupoPagadora"].Value.ToString();
                CargarDetalle(IdGrupoPagadora);
            }
        }
        #endregion

        #region Metodos ---------------------------------------------
        private void CargarDetalle(String IdGrupoPagadora)
        {
            DataSet dsGrupoPagadoraDetalle = new DataSet();
            GrupoPagadoraDetalleBE GrupoPagadoraDetalleBE = new GrupoPagadoraDetalleBE()
            {
                OPCION = 1,
                USUARIO = General.General.GetCodigoUsuario,
                IdGrupoPagadora = IdGrupoPagadora
            };

            dsGrupoPagadoraDetalle = GrupoPagadoraDetalleBL.ProcesarGrupoPagadoraDetalle(GrupoPagadoraDetalleBE);

            if (dsGrupoPagadoraDetalle.Tables[0].Rows.Count > 0)
            {
                dgvPagadoras.DataSource = dsGrupoPagadoraDetalle.Tables[0];
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvGrupoPagadoras.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar el grupo: " + dgvGrupoPagadoras.CurrentRow.Cells["vcGrupo"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        GrupoPagadoraBE oEntity = new GrupoPagadoraBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdGrupoPagadora = dgvGrupoPagadoras.CurrentRow.Cells["IdGrupoPagadora"].Value.ToString()
                        };

                        GrupoPagadoraBL.ProcesarGrupoPagadora(oEntity);
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
        #endregion
    }
}