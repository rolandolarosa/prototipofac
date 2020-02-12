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
    public partial class frmMntSocioGrupo : FormulaBase.frmMntFiltro
    {
        public frmMntSocioGrupo()
        {
            InitializeComponent();
        }

        private void frmMntSocioGrupo_Load(object sender, EventArgs e)
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

        private void CargarDetalle()
        {
            try
            {
                SocioGrupoDetBE oEntity = new SocioGrupoDetBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.IdGrupo = dgvGrupo.CurrentRow.Cells["IdGrupo_"].Value.ToString();
                DataSet ds = new SocioGrupoDetBL().ProcesarSocioGrupoDet(oEntity);

                dgvSocio.DataSource = ds.Tables[0];
                lblRegistrosDet.Text = ds.Tables[0].Rows.Count + " registro(s)";
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
                SocioGrupoBE oEntity = new SocioGrupoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    vcGrupo = TextBoxX1.Text.Trim()
                };

                DataSet ds = new SocioGrupoBL().ProcesarSocioGrupo(oEntity);
                dgvGrupo.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count + " registro(s)";
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
                frmMntSocioGrupoDet ofrm = new frmMntSocioGrupoDet();
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
                if (dgvGrupo.Rows.Count > 0)
                {
                    frmMntSocioGrupoDet ofrmGrupoPagadoraDato = new frmMntSocioGrupoDet();
                    ofrmGrupoPagadoraDato.Operacion = "M";
                    ofrmGrupoPagadoraDato.Codigo = dgvGrupo.CurrentRow.Cells["IdGrupo_"].Value.ToString();
                    ofrmGrupoPagadoraDato.ShowDialog();
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
                if (dgvGrupo.RowCount > 0)
                {
                    SocioGrupoDetBE IEntity = new SocioGrupoDetBE();
                    IEntity.OPCION = 1;
                    IEntity.USUARIO = General.General.GetUsuario;
                    IEntity.IdGrupo = dgvGrupo.CurrentRow.Cells["IdGrupo_"].Value.ToString();
                    DataSet ds = new SocioGrupoDetBL().ProcesarSocioGrupoDet(IEntity);

                    dialogResult = MessageBox.Show("Seguro de eliminar el grupo: " + dgvGrupo.CurrentRow.Cells["vcGrupo"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (!dgvGrupo.CurrentRow.Cells["UserNew"].Value.ToString().Trim().Equals(General.General.GetCodigoUsuario.Trim()))
                        {
                            MessageBox.Show("Usted no puede eliminar este registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("No se puede eliminar el riesgo, existen socios vinculados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        SocioGrupoBE oEntity = new SocioGrupoBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdGrupo = dgvGrupo.CurrentRow.Cells["IdGrupo_"].Value.ToString()
                        };

                        new SocioGrupoBL().ProcesarSocioGrupo(oEntity);
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

        private void dgvGrupo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGrupo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvGrupo.Rows.Count > 0)
                {
                    CargarDetalle();
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSocio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;
                if (dgvSocio.Columns[e.ColumnIndex].Name == "btnEliminarDet")
                {
                    DialogResult dialogResult = 0;

                    dialogResult = MessageBox.Show("Seguro de eliminar el socio: " + dgvSocio.CurrentRow.Cells["IdSocio_Dsc"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (!dgvSocio.CurrentRow.Cells["UserNew_"].Value.ToString().Trim().Equals(General.General.GetCodigoUsuario.Trim()))
                        {
                            MessageBox.Show("Usted no puede eliminar este registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        SocioGrupoDetBE oEntity = new SocioGrupoDetBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdGrupo = dgvSocio.CurrentRow.Cells["IdGrupo"].Value.ToString(),
                            IdSocio = dgvSocio.CurrentRow.Cells["IdSocio"].Value.ToString(),
                        };

                        new SocioGrupoDetBL().ProcesarSocioGrupoDet(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDetalle();
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