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
    public partial class frmBusquedaPagadora : DevComponents.DotNetBar.OfficeForm
    {
        PagadoraBL PagadoraBL = new PagadoraBL();
        public string CodigoPagadora = string.Empty;
        public string NombrePagadora = string.Empty;
        public string RucPagadora = string.Empty;

        public frmBusquedaPagadora()
        {
            InitializeComponent();
        }

        #region Eventos ---------------------------------------------
        private void frmBusquedaPagadora_Load(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsPagadora = new DataSet();
                PagadoraBE PagadoraBE = new PagadoraBE();
                PagadoraBE.OPCION = 4;
                PagadoraBE.USUARIO = General.General.GetCodigoUsuario;
                PagadoraBE.vcPagadora = txtvcPagadora.Text.Trim();
                dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);
                dgvPagadoras.DataSource = dsPagadora.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtvcPagadora.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        private void dgvPagadoras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPagadoras.RowCount > 0)
            {
                CodigoPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                NombrePagadora = dgvPagadoras.CurrentRow.Cells["vcPagadora"].Value.ToString();
                RucPagadora = dgvPagadoras.CurrentRow.Cells["vcRuc"].Value.ToString();
                this.Dispose();
            }
        }

    }
}