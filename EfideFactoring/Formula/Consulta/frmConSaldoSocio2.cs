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

namespace EfideFactoring.Formula.Consulta
{
    public partial class frmConSaldoSocio2 : DevComponents.DotNetBar.OfficeForm
    {
        bool ind = false;
        public string _Ejecutivo = string.Empty;
        SocioLineaBL SocioLineaBL = new SocioLineaBL();
        public frmConSaldoSocio2()
        {
            InitializeComponent();
        }

        private void frmConSaldoSocio2_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                SocioLineaBE SocioLineaBE = new SocioLineaBE()
                {
                    OPCION = 8,
                    IdSocio = txtCodigo.Text.Trim(),
                    IdSocio_Dsc = txtSocio.Text.Trim(),
                    USUARIO = General.General.GetUsuario,
                };
                ds = SocioLineaBL.ProcesarSocioLinea(SocioLineaBE);
                dgvSaldoSocio.DataSource = ds.Tables[0];

                DataSet ds2 = new DataSet();
                SocioLineaBE SocioLineaBE2 = new SocioLineaBE()
                {
                    OPCION = 9,
                    IdSocio = txtCodigo.Text.Trim(),
                    IdSocio_Dsc = txtSocio.Text.Trim(),
                    USUARIO = General.General.GetUsuario,
                };
                ds = SocioLineaBL.ProcesarSocioLinea(SocioLineaBE2);
                dgvPagadora.DataSource = ds.Tables[0];

                lblEjecutivo.Text = "Ejecutivo: " + _Ejecutivo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewX1_DoubleClick(object sender, EventArgs e)
        {
            frmConSaldoSocio3 ofrmConSaldoSocio3 = new frmConSaldoSocio3();
            ofrmConSaldoSocio3.oIdSocio = txtCodigo.Text;
            ofrmConSaldoSocio3.oIdPagadora = dgvPagadora.CurrentRow.Cells["IdPagador"].Value.ToString();
            ofrmConSaldoSocio3.oPagadora = dgvPagadora.CurrentRow.Cells["Pagador"].Value.ToString();
            ofrmConSaldoSocio3.ShowDialog();
        }

        private void frmConSaldoSocio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null && !ind)
            {
                ind = true;
                this.Owner.Close();
            }
        }

        private void dgvPagadora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvPagadora.Columns[e.ColumnIndex].Name.Equals("btnVisorFirma"))
                {
                    Legal.frmVisorFirmaLote ofrm = new Legal.frmVisorFirmaLote();
                    ofrm._IdPagadora = dgvPagadora.CurrentRow.Cells["IdPagador"].Value.ToString();
                    ofrm._IdPagadora_Dsc = dgvPagadora.CurrentRow.Cells["Pagador"].Value.ToString();
                    ofrm.ShowDialog();
                }
                else if (dgvPagadora.Columns[e.ColumnIndex].Name.Equals("btnVerDocumentos"))
                {
                    EfideFactoring.Formula.Catalogo.frmQrySocioLineaPagDoc ofrm = new Catalogo.frmQrySocioLineaPagDoc();
                    ofrm._IdSocio = txtCodigo.Text;
                    ofrm._IdSocio_Dsc = txtSocio.Text;
                    ofrm._IdPagadora = dgvPagadora.CurrentRow.Cells["IdPagador"].Value.ToString();
                    ofrm._IdPagadora_Dsc = dgvPagadora.CurrentRow.Cells["Pagador"].Value.ToString();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkVerPagadoras_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                SocioLineaBE SocioLineaBE2 = new SocioLineaBE()
                {
                    OPCION = 9,
                    IdSocio = txtCodigo.Text.Trim(),
                    IdSocio_Dsc = txtSocio.Text.Trim(),
                    USUARIO = General.General.GetUsuario,
                    FlgVerPagadoras = ChkVerPagadoras.Checked ? 1 : 0
                };
                ds = SocioLineaBL.ProcesarSocioLinea(SocioLineaBE2);
                dgvPagadora.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
