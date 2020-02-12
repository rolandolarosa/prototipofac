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

namespace EfideFactoring.Formula.Consulta
{
    public partial class frmBusquedaPagadoraEfideTop : DevComponents.DotNetBar.OfficeForm
    {
        public string CodigoPagadora = string.Empty;
        public string NombrePagadora = string.Empty;
        public string _vcRuc = string.Empty;
        public string _IdSector_tt = string.Empty;
        public string _Tipo = string.Empty;
        public string _Observacion = string.Empty;
        public string _EstadoLinea = string.Empty;
        public decimal _LineaDisponible = 0;

        public frmBusquedaPagadoraEfideTop()
        {
            InitializeComponent();
        }

        private void frmBusquedaPagadoraEfideTop_Load(object sender, EventArgs e)
        {
            try
            {

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
                DataSet dsPagadora = new DataSet();
                PagadoraBE PagadoraBE = new PagadoraBE();
                PagadoraBE.OPCION = 8;
                PagadoraBE.USUARIO = General.General.GetCodigoUsuario;
                PagadoraBE.vcPagadora = txtvcPagadora.Text.Trim();
                dsPagadora = new PagadoraBL().ProcesarPagadora(PagadoraBE);
                dgvPagadoras.DataSource = dsPagadora.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPagadoras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPagadoras.RowCount > 0)
                {
                    CodigoPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                    NombrePagadora = dgvPagadoras.CurrentRow.Cells["vcPagadora"].Value.ToString();
                    _vcRuc = dgvPagadoras.CurrentRow.Cells["vcRuc"].Value.ToString();
                    _IdSector_tt = dgvPagadoras.CurrentRow.Cells["IdSector_tt"].Value.ToString();
                    _Tipo = dgvPagadoras.CurrentRow.Cells["Tipo"].Value.ToString();
                    _LineaDisponible = string.IsNullOrEmpty(dgvPagadoras.CurrentRow.Cells["LineaDisponible"].Value.ToString())? 0 : Convert.ToDecimal(dgvPagadoras.CurrentRow.Cells["LineaDisponible"].Value.ToString());
                    _Observacion = dgvPagadoras.CurrentRow.Cells["Observacion"].Value.ToString();
                    _EstadoLinea = dgvPagadoras.CurrentRow.Cells["EstadoLinea"].Value.ToString();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtvcPagadora.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}