using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Consulta
{
    public partial class frmConSaldoSocio : DevComponents.DotNetBar.OfficeForm
    {
        public string _IdSocio = string.Empty;
        public string _IdSocio_Dsc = string.Empty;
        SocioLineaBL SocioLineaBL = new SocioLineaBL();
        public frmConSaldoSocio()
        {
            InitializeComponent();
        }

        private void frmConSaldoSocio_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(_IdSocio))
                {
                    txtCodigo.Text = _IdSocio;
                    txtSocio.Text = _IdSocio_Dsc;
                    btnBuscar.PerformClick();
                }
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
                DataSet ds = new DataSet();
                SocioLineaBE SocioLineaBE = new SocioLineaBE()
                {
                    OPCION = 7,
                    IdSocio = txtCodigo.Text.Trim(),
                    IdSocio_Dsc = txtSocio.Text.Trim(),
                    USUARIO = General.General.GetUsuario,
                };
                ds = SocioLineaBL.ProcesarSocioLinea(SocioLineaBE);
                dgvSaldoSocio.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSaldoSocio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSaldoSocio.RowCount > 0)
                {
                    frmConSaldoSocio2 ofrmConSaldoSocio2 = new frmConSaldoSocio2();
                    ofrmConSaldoSocio2.txtCodigo.Text  = dgvSaldoSocio.CurrentRow.Cells["IdSocio"].Value.ToString();
                    ofrmConSaldoSocio2.txtSocio.Text = dgvSaldoSocio.CurrentRow.Cells["Socio"].Value.ToString();
                    ofrmConSaldoSocio2._Ejecutivo = dgvSaldoSocio.CurrentRow.Cells["UsuarioID"].Value.ToString();
                    ofrmConSaldoSocio2.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSaldoSocio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvSaldoSocio.Columns[e.ColumnIndex].Name.Equals("btnVisorFirma"))
                {
                    Legal.frmVisorFirmaLote ofrm = new Legal.frmVisorFirmaLote();
                    ofrm._IdSocio = dgvSaldoSocio.CurrentRow.Cells["IdSocio"].Value.ToString();
                    ofrm._IdSocio_Dsc = dgvSaldoSocio.CurrentRow.Cells["Socio"].Value.ToString();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
