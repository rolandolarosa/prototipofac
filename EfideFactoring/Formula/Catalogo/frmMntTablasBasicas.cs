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
    public partial class frmMntTablasBasicas : DevComponents.DotNetBar.OfficeForm
    {
        TableBaseBL TableBaseBL = new TableBaseBL();

        public frmMntTablasBasicas()
        {
            InitializeComponent();
        }

        private void frmMntTablasBasicas_Load(object sender, EventArgs e)
        {
            CargarTablas();
        }

        private void CargarTablas()
        {
            try
            {
                DataSet ds = new DataSet();
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetUsuario,
                    Table_Name = txtTabla.Text
                };

                ds = TableBaseBL.ProcesarTableBase(TableBaseBE);
                dgvTablasPadre.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaTablaDetalle()
        {
            DataSet ds = new DataSet();
            TableBaseBE TableBaseBE = new TableBaseBE()
            {
                OPCION = 5,
                USUARIO = General.General.GetUsuario,
                Table_Parent_Id = dgvTablasPadre.CurrentRow.Cells["Table_Id"].Value.ToString(),
                Table_Name = txtDetalle.Text
            };

            ds = TableBaseBL.ProcesarTableBase(TableBaseBE);
            dgvTablasHijos.DataSource = ds.Tables[0];
            lblregdet.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
        }

        private void btnNuevoPadre_Click(object sender, EventArgs e)
        {
            try
            {
                Catalogo.frmMntTablasBasicasPadre ofrmMntTableBaseDato = new Catalogo.frmMntTablasBasicasPadre();
                ofrmMntTableBaseDato.Operacion = "N";
                ofrmMntTableBaseDato.ShowDialog();
                CargarTablas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarPadre_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTablasPadre.RowCount > 0)
                {
                    Catalogo.frmMntTablasBasicasPadre ofrmMntTableBaseDato = new Catalogo.frmMntTablasBasicasPadre();
                    ofrmMntTableBaseDato.Operacion = "M";
                    ofrmMntTableBaseDato.Codigo = dgvTablasPadre.CurrentRow.Cells["Table_Id"].Value.ToString();
                    ofrmMntTableBaseDato.ShowDialog();
                    CargarTablas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTablasPadre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (dgvTablasPadre.RowCount > 0)
            //    {
            //        DataSet ds = new DataSet();
            //        TableBaseBE TableBaseBE = new TableBaseBE()
            //        {
            //            OPCION = 5,
            //            USUARIO = General.General.GetUsuario,
            //            Table_Parent_Id = dgvTablasPadre.CurrentRow.Cells["Table_Id"].Value.ToString(),
            //        };

            //        ds = TableBaseBL.ProcesarTableBase(TableBaseBE);
            //        dgvTablasHijos.DataSource = ds.Tables[0];
            //        lblregdet.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnNuevoHijo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTablasPadre.RowCount > 0)
                {
                    Catalogo.frmMntTablasBasicasHijo ofrmMntTableBaseDato = new Catalogo.frmMntTablasBasicasHijo();
                    ofrmMntTableBaseDato.Operacion = "N";
                    ofrmMntTableBaseDato.Codigo = dgvTablasPadre.CurrentRow.Cells["Table_Id"].Value.ToString();
                    ofrmMntTableBaseDato.ShowDialog();
                    //dgvTablasPadre_CellClick(new object(), null);
                    dgvTablasPadre_SelectionChanged(new object(), null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarHijo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTablasHijos.RowCount > 0)
                {
                    Catalogo.frmMntTablasBasicasHijo ofrmMntTableBaseDato = new Catalogo.frmMntTablasBasicasHijo();
                    ofrmMntTableBaseDato.Operacion = "M";
                    ofrmMntTableBaseDato.Codigo = dgvTablasHijos.CurrentRow.Cells["Table_IdH"].Value.ToString();
                    ofrmMntTableBaseDato.ShowDialog();
                    //dgvTablasPadre_CellClick(new object(), null);
                    dgvTablasPadre_SelectionChanged(new object(), null);
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


        private void dgvTablasPadre_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTablasPadre.RowCount > 0)
                {
                    CargaTablaDetalle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtTabla_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarTablas();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargaTablaDetalle();
            }
            catch (Exception ex)
            {

            }
        }
    }
}