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

namespace EfideFactoring.Formula.Movimiento
{
    public partial class frmMntMovimientoDatoEgreso : FormulaBase.frmMntDato
    {
        public string _IdTipo_tt = string.Empty;
        public frmMntMovimientoDatoEgreso()
        {
            InitializeComponent();
        }

        private void frmMntMovimientoDatoEgreso_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
        {
            try
            {
                String Table_Id = "00035";
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdMoneda_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
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
                if (dtFechaMovimiento.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Debe ingresar la fecha del movimiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtFechaMovimiento.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cboIdMoneda_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Debe seleccionar la moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdMoneda_tt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtImporte.Text))
                {
                    MessageBox.Show("Ingrese un importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtImporte.Focus();
                    return;
                }

                MovimientoBE oEntity = new MovimientoBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdMovimiento = "",
                    IdTipo_tt = _IdTipo_tt, // Inversiones o Presupuesto
                    FechaMovimiento = dtFechaMovimiento.Value,
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    Importe = Convert.ToDecimal(txtImporte.Text),
                    IdEstado_tt = "2", // Atendido
                    Comentario = txtComentario.Text
                };

                new MovimientoBL().ProcesarMovimiento(oEntity);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtImporte.Text);
        }
    }
}