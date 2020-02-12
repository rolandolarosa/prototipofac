using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfideFactoringBE;
using EfideFactoringBL;
namespace EfideFactoring.Formula.Catalogo
{
    public partial class frmMntProductosFactoring : FormulaBase.frmMntFiltro
    {
        ProductosFactoringBL ProductosFactoringBL = new ProductosFactoringBL();
        public frmMntProductosFactoring()
        {
            InitializeComponent();
        }

        private void frmMntProductosFactoring_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ProductosFactoringBE ProductosFactoringBE = new ProductosFactoringBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetUsuario,
                    /*Agregar Filtros*/
                };

                ds = ProductosFactoringBL.ProcesarProductosFactoring(ProductosFactoringBE);
                dgvProductosFactoring.DataSource = ds.Tables[0];
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
                frmMntProductosFactoringDato ofrmMntProductosFactoringDato = new frmMntProductosFactoringDato();
                ofrmMntProductosFactoringDato.Operacion = "N";
                ofrmMntProductosFactoringDato.ShowDialog();
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
                if (dgvProductosFactoring.RowCount > 0)
                {
                    frmMntProductosFactoringDato ofrmMntProductosFactoringDato = new frmMntProductosFactoringDato();
                    ofrmMntProductosFactoringDato.Operacion = "M";
                    ofrmMntProductosFactoringDato.Codigo = dgvProductosFactoring.CurrentRow.Cells["prodCreditoID"].Value.ToString();
                    ofrmMntProductosFactoringDato.ShowDialog();
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
                if (dgvProductosFactoring.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de Eliminar ...:" + dgvProductosFactoring.CurrentRow.Cells["/* Agregar el campo a mostrar en el mensaje de confirmación */"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        ProductosFactoringBE ProductosFactoringBE = new ProductosFactoringBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            prodCreditoID = dgvProductosFactoring.CurrentRow.Cells["prodCreditoID"].Value.ToString(),
                        };

                        ProductosFactoringBL.ProcesarProductosFactoring(ProductosFactoringBE);
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
