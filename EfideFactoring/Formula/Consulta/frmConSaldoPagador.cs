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
    public partial class frmConSaldoPagador : DevComponents.DotNetBar.OfficeForm
    {
        public int _FlgOrigen = 0;
        SocioLineaBL SocioLineaBL = new SocioLineaBL();
        public frmConSaldoPagador()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                SocioLineaBE SocioLineaBE = new SocioLineaBE()
                {
                    OPCION = 11,
                    IdPagadora = txtCodigo.Text.Trim(),
                    IdPagadora_Dsc = txtPagadora.Text.Trim(),
                    USUARIO = General.General.GetUsuario,
                };
                ds = SocioLineaBL.ProcesarSocioLinea(SocioLineaBE);
                dgvSaldoSocio.DataSource = ds.Tables[0];
                GridFormating();
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
                    //frmConSaldoSocio2 ofrmConSaldoSocio2 = new frmConSaldoSocio2();
                    //ofrmConSaldoSocio2.txtCodigo.Text = dgvSaldoSocio.CurrentRow.Cells["IdSocio"].Value.ToString();
                    //ofrmConSaldoSocio2.txtSocio.Text = dgvSaldoSocio.CurrentRow.Cells["Socio"].Value.ToString();
                    //ofrmConSaldoSocio2.ShowDialog();

                    frmConSaldoSocio3 ofrmConSaldoSocio3 = new frmConSaldoSocio3();
                    ofrmConSaldoSocio3.Text = "Consulta de Saldos por Pagadora";
                    ofrmConSaldoSocio3.oIdSocio = "";
                    ofrmConSaldoSocio3.oIdPagadora = dgvSaldoSocio.CurrentRow.Cells["IdPagadora"].Value.ToString();
                    ofrmConSaldoSocio3.oPagadora = dgvSaldoSocio.CurrentRow.Cells["Pagadora"].Value.ToString();
                    ofrmConSaldoSocio3._LineaSaldo = Convert.ToDecimal(dgvSaldoSocio.CurrentRow.Cells["SaldoS"].Value.ToString());
                    ofrmConSaldoSocio3._TipoCambio = Convert.ToDecimal(dgvSaldoSocio.CurrentRow.Cells["TipoCambioC"].Value.ToString());
                    ofrmConSaldoSocio3._FlgOrigen = _FlgOrigen;
                    ofrmConSaldoSocio3.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridFormating()
        {
            try
            {
                foreach (DataGridViewRow row in dgvSaldoSocio.Rows)
                {
                    if (row.Cells["Estado"].Value.ToString().Contains("Bloqueo"))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }

                    if (row.Cells["Estado"].Value.ToString().Equals("Inactiva"))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Blue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSaldoSocio_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridFormating();
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
                    ofrm._IdPagadora = dgvSaldoSocio.CurrentRow.Cells["IdPagadora"].Value.ToString();
                    ofrm._IdPagadora_Dsc = dgvSaldoSocio.CurrentRow.Cells["Pagadora"].Value.ToString();
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
