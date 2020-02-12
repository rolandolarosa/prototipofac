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
    public partial class frmUsuarioXTipo :FormulaBase.frmMntFiltro
    {
        public frmUsuarioXTipo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                UsuarioGestorBE oEnity = new UsuarioGestorBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    UsuarioID = TextBoxX1.Text.ToString().Trim(),
                };
                ds = new UsuarioGestorBL().ProcesarUsuarioGestor(oEnity);
                dgvUsuarios.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionComercial.frmUsuarioXTipoDato ofrmUsuarioXTipoDato = new Formula.GestionComercial.frmUsuarioXTipoDato();
                ofrmUsuarioXTipoDato.Operacion = "N";
                ofrmUsuarioXTipoDato.ShowDialog();
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
                if (dgvUsuarios.RowCount > 0)
                {
                    Formula.GestionComercial.frmUsuarioXTipoDato ofrmUsuarioXTipoDato = new Formula.GestionComercial.frmUsuarioXTipoDato();
                    ofrmUsuarioXTipoDato.Operacion = "M";
                    ofrmUsuarioXTipoDato.Codigo = dgvUsuarios.CurrentRow.Cells["UsuarioID"].Value.ToString();
                    ofrmUsuarioXTipoDato.ShowDialog();
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
                if (dgvUsuarios.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar el usuario: " + dgvUsuarios.CurrentRow.Cells["UsuarioID"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        UsuarioGestorBE oEntity = new UsuarioGestorBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            UsuarioID = dgvUsuarios.CurrentRow.Cells["UsuarioID"].Value.ToString(),
                            IdGestor = dgvUsuarios.CurrentRow.Cells["IdGestor"].Value.ToString(),
                        };

                        new UsuarioGestorBL().ProcesarUsuarioGestor(oEntity);
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

        private void dgvUsuarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selValue = 0;
                int option = 0;
                if (((DataGridViewCheckBoxCell)(dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex])).Value == DBNull.Value)
                    selValue = 0;
                else
                    selValue = Convert.ToInt32(((DataGridViewCheckBoxCell)(dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex])).Value);

                if(e.ColumnIndex == 5)
                    option = 6;
                if(e.ColumnIndex == 6)
                    option = 7;

                if (e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9)
                {
                    option = 9;
                }

                UsuarioGestorBE oEntity = new UsuarioGestorBE();
                oEntity.OPCION = option;
                oEntity.IndPrint = selValue;
                oEntity.IndExport = selValue;
                oEntity.bAdmLineaPag = dgvUsuarios.Rows[e.RowIndex].Cells["bAdmLineaPag"].Value != null ? Convert.ToBoolean(dgvUsuarios.Rows[e.RowIndex].Cells["bAdmLineaPag"].Value) : false;
                oEntity.bAdmBloqueoPag = dgvUsuarios.Rows[e.RowIndex].Cells["bAdmBloqueoPag"].Value != null ? Convert.ToBoolean(dgvUsuarios.Rows[e.RowIndex].Cells["bAdmBloqueoPag"].Value) : false;
                oEntity.bAdmContactos = dgvUsuarios.Rows[e.RowIndex].Cells["bAdmContactos"].Value != null ? Convert.ToBoolean(dgvUsuarios.Rows[e.RowIndex].Cells["bAdmContactos"].Value) : false;
                oEntity.UsuarioID = dgvUsuarios.Rows[e.RowIndex].Cells["UsuarioID"].Value.ToString();
                oEntity.IdGestor = dgvUsuarios.Rows[e.RowIndex].Cells["IdGestor"].Value.ToString();
                new UsuarioGestorBL().ProcesarUsuarioGestor(oEntity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsuarios.EndEdit();
        }
    }
}