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
    public partial class frmMntDocumento : FormulaBase.frmMntFiltro
    {
        DocumentoBL DocumentoBL = new DocumentoBL();
        public frmMntDocumento()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DocumentoBE DocumentoBE = new DocumentoBE()
            {
                OPCION = 1,
                USUARIO = General.General.GetUsuario,
                vDocumento = TextBoxX1.Text.Trim()
            };

            ds = DocumentoBL.ProcesarDocumento(DocumentoBE);
            dgvDocumento.DataSource = ds.Tables[0];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Catalogo.frmMntDocumentoDato ofrmMntDocumentoDato = new Catalogo.frmMntDocumentoDato();
                ofrmMntDocumentoDato.Operacion = "N";
                ofrmMntDocumentoDato.ShowDialog();
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
                Catalogo.frmMntDocumentoDato ofrmMntDocumentoDato = new Catalogo.frmMntDocumentoDato();
                ofrmMntDocumentoDato.Operacion = "M";
                ofrmMntDocumentoDato.Codigo = dgvDocumento.CurrentRow.Cells["IdDocumento"].Value.ToString();
                ofrmMntDocumentoDato.ShowDialog();
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Catalogo.frmMntDocumentoDato ofrmMntDocumentoDato = new Catalogo.frmMntDocumentoDato();
                ofrmMntDocumentoDato.Operacion = "C";
                ofrmMntDocumentoDato.Codigo = dgvDocumento.CurrentRow.Cells["IdDocumento"].Value.ToString();
                ofrmMntDocumentoDato.ShowDialog();

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
                if (dgvDocumento.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de Eliminar el Documento: " + dgvDocumento.CurrentRow.Cells["vDocumento"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        DocumentoBE DocumentoBE = new DocumentoBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdDocumento = dgvDocumento.CurrentRow.Cells["IdDocumento"].Value.ToString()
                        };

                        DocumentoBL.ProcesarDocumento(DocumentoBE);
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
    }
}