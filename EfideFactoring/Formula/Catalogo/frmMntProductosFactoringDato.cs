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
    public partial class frmMntProductosFactoringDato : FormulaBase.frmMntDato
    {
        ProductosFactoringBL ProductosFactoringBL = new ProductosFactoringBL();
        public frmMntProductosFactoringDato()
        {
            InitializeComponent();
        }

        private void frmMntProductosFactoringDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                if (Operacion.Equals("N"))
                {
                    /* Evaluar - Llenar datos por defecto si es necesario....*/
                }
                else if (Operacion.Equals("M"))
                {
                    txtprodCreditoID.Text = Codigo;
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtlineaCreditoID.Text))
                {
                    MessageBox.Show("Se debe Ingresar un lineaCreditoID", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtcondicionID.Text))
                {
                    MessageBox.Show("Se debe Ingresar un condicionID", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtmonedaID.Text))
                {
                    MessageBox.Show("Se debe Ingresar un monedaID", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (int.Parse(txtmonedaID.Text) == 0)
                {
                    MessageBox.Show("monedaID debe ser mayo a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ProductosFactoringBE ProductosFactoringBE = new ProductosFactoringBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    prodCreditoID = txtprodCreditoID.Text,
                    lineaCreditoID = txtlineaCreditoID.Text,
                    condicionID = txtcondicionID.Text,
                    monedaID = String.IsNullOrEmpty(txtmonedaID.Text.Trim()) ? 0 : int.Parse(txtmonedaID.Text),
                };

                DataSet dsProductosFactoring = new DataSet();
                dsProductosFactoring = ProductosFactoringBL.ProcesarProductosFactoring(ProductosFactoringBE);

                /* Solo si es necesario....para evaluar
                if (dsProductosFactoring.Tables[0].Rows.Count > 0)
                {
                }
                */

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* LLenar Combobox */
        private void LlenarCombos()
        {
            try
            {
                //cboprodCreditoID
                ProductosFactoringBE prodCreditoIDBE = new ProductosFactoringBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetUsuario
                };
                General.General.LlenarCombobox(cboprodCreditoID, "prodCredNombre", "prodCreditoID", ProductosFactoringBL.ProcesarProductosFactoring(prodCreditoIDBE).Tables[0]);

                //cbolineaCreditoID
                ProductosFactoringBE lineaCreditoIDBE = new ProductosFactoringBE()
                {
                    OPCION = 6,
                    USUARIO = General.General.GetUsuario
                };
                General.General.LlenarCombobox(cbolineaCreditoID, "linCredNombre", "lineaCreditoID", ProductosFactoringBL.ProcesarProductosFactoring(lineaCreditoIDBE).Tables[0]);

                //cbocondicionID
                ProductosFactoringBE condicionIDBE = new ProductosFactoringBE()
                {
                    OPCION = 7,
                    USUARIO = General.General.GetUsuario
                };
                General.General.LlenarCombobox(cbocondicionID, "lineaCreditoID", "condicionID", ProductosFactoringBL.ProcesarProductosFactoring(condicionIDBE).Tables[0]);

                //cbomonedaID
                ProductosFactoringBE monedaIDBE = new ProductosFactoringBE()
                {
                    OPCION = 8,
                    USUARIO = General.General.GetUsuario
                };
                General.General.LlenarCombobox(cbomonedaID, "varDescripcion", "varCodigo", ProductosFactoringBL.ProcesarProductosFactoring(monedaIDBE).Tables[0]);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void CargarDatos()
        {
            try
            {
                DataSet dsProductosFactoring = new DataSet();
                ProductosFactoringBE ProductosFactoringBE = new ProductosFactoringBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    prodCreditoID = txtprodCreditoID.Text,
                };
                
                dsProductosFactoring = ProductosFactoringBL.ProcesarProductosFactoring(ProductosFactoringBE);
                
                if (dsProductosFactoring.Tables[0].Rows.Count > 0)
                {
                    txtlineaCreditoID.Text = dsProductosFactoring.Tables[0].Rows[0]["lineaCreditoID"].ToString();
                    txtcondicionID.Text = dsProductosFactoring.Tables[0].Rows[0]["condicionID"].ToString();
                    txtmonedaID.Text = dsProductosFactoring.Tables[0].Rows[0]["monedaID"].ToString();
                }
                else
                {
                    MessageBox.Show("Este .... no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
