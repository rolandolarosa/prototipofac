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
    public partial class frmBusquedaSocioCandidato : DevComponents.DotNetBar.OfficeForm
    {
        public string _Codigo = string.Empty;
        public string _Entidad = string.Empty;
        public int _FlgSocio = 0;

        public frmBusquedaSocioCandidato()
        {
            InitializeComponent();
        }

        private void frmBusquedaSocioCandidato_Load(object sender, EventArgs e)
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
                if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()))
                {
                    return;
                }

                DataSet ds = new DataSet();
                GestionBE GestionBE = new GestionBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    Entidad = txtRazonSocial.Text.Trim()
                };

                ds = new GestionBL().ProcesarGestion(GestionBE);
                dgvSocioCandidato.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSocios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSocioCandidato.RowCount > 0)
                {
                    _Codigo = dgvSocioCandidato.CurrentRow.Cells["Codigo"].Value.ToString();
                    _Entidad = dgvSocioCandidato.CurrentRow.Cells["Entidad"].Value.ToString();
                    _FlgSocio = int.Parse(dgvSocioCandidato.CurrentRow.Cells["FlgSocio"].Value.ToString());
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
            txtRazonSocial.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}