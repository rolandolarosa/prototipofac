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
    public partial class frmMntMovimientoEgreso : FormulaBase.frmMntDato
    {
        public int _Opcion = 3;
        public string _Concepto = string.Empty;
        public int _ConceptoId = 0;
        public string _Columna = string.Empty;
        public int _ValorMonedaId = 0;
        public string _IdTipo_tt = string.Empty;
        public frmMntMovimientoEgreso()
        {
            InitializeComponent();
        }

        private void frmMntMovimientoEgreso_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
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
                DataSet ds = new DataSet();

                ds = new ReporteBL().ProcesarReporte(_Opcion, General.General.GetCodigoUsuario, _ConceptoId, _Columna, _ValorMonedaId);
                dgvMovimientos.DataSource = ds.Tables[0];
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
                frmMntMovimientoDatoEgreso ofrm = new frmMntMovimientoDatoEgreso();
                ofrm._IdTipo_tt = _IdTipo_tt;
                ofrm.ShowDialog();
                CargarDatos();
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
                if (dgvMovimientos.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("¿Seguro de eliminar el deposito?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        MovimientoBE oEntity = new MovimientoBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetCodigoUsuario,
                            IdMovimiento = dgvMovimientos.CurrentRow.Cells["IdMovimiento"].Value.ToString(), // Depositos
                        };

                        new MovimientoBL().ProcesarMovimiento(oEntity);
                        CargarDatos();
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