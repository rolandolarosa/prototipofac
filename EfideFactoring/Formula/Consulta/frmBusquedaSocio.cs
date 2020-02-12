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
    public partial class frmBusquedaSocio : DevComponents.DotNetBar.OfficeForm
    {
        SocioBL SocioBL = new SocioBL();
        public String CodSocio = string.Empty;
        public string RazorSocialSocio = string.Empty;
        public string RUCSocio = string.Empty;
        public string DocumentoSocio = string.Empty;
        public DataSet dsSocio = new DataSet();
        public int _Opcion = 1; // Opcion a consultar, solo desde girador se le enviara una opcion diferente
        public bool bDesactivarBotones = false; // los botones deben estar deshabilitado para el tercer caso
        public frmBusquedaSocio()
        {               
            InitializeComponent();
        }

        #region Eventos
        private void frmBusquedaSocio_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Opcion == 8)
                {
                    Cargasocio(_Opcion);
                }

                if (bDesactivarBotones)
                {
                    btnEditar.Visible = false;
                    btnNuevo.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargasocio(int opcion)
        {
            SocioBE SocioBE = new SocioBE()
            {
                OPCION = opcion,
                USUARIO = General.General.GetCodigoUsuario,
                RazonSocial = txtRazonSocial.Text.Trim(),
                CodSocio = CodSocio
            };

            dsSocio = SocioBL.ProcesarSocio(SocioBE);
            dgvSocios.DataSource = dsSocio.Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtRazonSocial.Text.Trim()))
                {
                    return;
                }

                Cargasocio(_Opcion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRazonSocial.Clear();
        }

        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvSocios.RowCount > 0)
            //{
            //    CodSocio = dgvSocios.CurrentRow.Cells["CodigoSocio"].Value.ToString();
            //    RazorSocialSocio = dgvSocios.CurrentRow.Cells["RazonSocial"].Value.ToString();
            //    this.Dispose();
            //}
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void dgvSocios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSocios.RowCount > 0)
            {
                //CodSocio = dgvSocios.CurrentRow.Cells["CodigoSocio"].Value.ToString();
                CodSocio = dgvSocios.CurrentRow.Cells["CodCliente"].Value.ToString();
                RazorSocialSocio = dgvSocios.CurrentRow.Cells["RazonSocial"].Value.ToString();
                RUCSocio = dgvSocios.CurrentRow.Cells["NumDoc"].Value.ToString();
                DocumentoSocio = dgvSocios.CurrentRow.Cells["Documento"].Value.ToString();
                this.Dispose();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Registros.frmIngresoSocio ofrmIngresoSocio = new Formula.Registros.frmIngresoSocio();

                if (dgvSocios.Rows.Count == 0 && string.IsNullOrEmpty(txtRazonSocial.Text.Trim()))
                {
                    Cargasocio(5);
                }
                ofrmIngresoSocio.ShowDialog();
                // txtRazonSocialSocio.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
                DataRow row = dsSocio.Tables[0].NewRow();
         
                    row["RazonSocial"] = ofrmIngresoSocio.RazonSocialSocio.Trim();
                    row["NumDoc"] = ofrmIngresoSocio.Ruc.Trim();

                dsSocio.Tables[0].Rows.Add(row);

                if (dsSocio.Tables[0].Rows.Count > 0)
                {
                    dgvSocios.DataSource = dsSocio.Tables[0];
                }

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
                if (dgvSocios.RowCount > 0)
                {
                    if (dgvSocios.CurrentRow.Cells["FlgEditar"].Value.ToString().Equals("1"))
                    {
                        Formula.Registros.frmIngresoSocio ofrm = new Formula.Registros.frmIngresoSocio();
                        ofrm.Operacion = "M";
                        ofrm.Codigo = dgvSocios.CurrentRow.Cells["CodCliente"].Value.ToString();
                        ofrm.ShowDialog();
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