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
    public partial class frmBusquedaCtaAhorros : DevComponents.DotNetBar.OfficeForm
    {
        CuentaSocioBL CuentaSocioLogic = new CuentaSocioBL();
        public String fbcsNumCuentaID = string.Empty;
        public String fbcsProdNombre = string.Empty;
        public String fbcsTipoMoneda = string.Empty;
        public String fbcsTipoProducto = string.Empty;
        public Decimal fbcsValorTipoMonedaID = 1;
        public Decimal fbcsSaldoTotal = 0;

        String fClienteID, fProductoID;
        Decimal? fValorTipoProductoID = null;
        Decimal? fValorTipoCuentaAhoD = null;
        Decimal? fValorTipoMonedaID = null;
        Int32? fTipoOpcion = null;

        public frmBusquedaCtaAhorros(int tipoOpcion, Decimal? valorTipoProductoID, Decimal? valorTipoCuentaAhoID,
            String clienteID, String productoID, decimal? valorTipoMonedaID)
        {
            InitializeComponent();
            fValorTipoCuentaAhoD = valorTipoCuentaAhoID;
            fValorTipoMonedaID = valorTipoMonedaID;
            fValorTipoProductoID = valorTipoProductoID;
            fClienteID = clienteID;
            fProductoID = productoID;
            fTipoOpcion = tipoOpcion;
        }

        private void frmBusquedaCtaAhorros_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Buscar cuenta de ahorros";
                if (fTipoOpcion == 2 && fClienteID != null)
                {
                    DataSet dsSocio = new DataSet();
                    CuentaSocioBE ctaSocioBE = new CuentaSocioBE()
                    {
                        OPCION = 1,
                        USUARIO = General.General.GetCodigoUsuario,
                        valorTipoCuentaID = 1,
                        valorTipoCuentaAhoID = fValorTipoCuentaAhoD,
                        productoID = fProductoID,
                        valorMonedaID = fValorTipoMonedaID,
                        clienteID = fClienteID,

                    };
                    txtRazonSocial.ReadOnly = true;
                    dgvSocios.AutoGenerateColumns = false;
                    dsSocio = CuentaSocioLogic.BuscarCuentaSocio(ctaSocioBE);
                    dgvSocios.DataSource = dsSocio.Tables[0];
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
                if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()))
                {
                    return;
                }

                DataSet dsSocio = new DataSet();
                CuentaSocioBE ctaSocioBE = new CuentaSocioBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    razonSocial = txtRazonSocial.Text.Trim(),
                    valorTipoCuentaID = 1,
                    valorTipoCuentaAhoID = fValorTipoCuentaAhoD,
                    productoID = fProductoID,
                    valorMonedaID = fValorTipoMonedaID,
                    
                    
                };
                dgvSocios.AutoGenerateColumns = false;
                dsSocio = CuentaSocioLogic.BuscarCuentaSocio(ctaSocioBE);
                dgvSocios.DataSource = dsSocio.Tables[0];
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

        private void dgvSocios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSocios.RowCount > 0)
            {
                //CodSocio = dgvSocios.CurrentRow.Cells["CodigoSocio"].Value.ToString();
                fbcsNumCuentaID = dgvSocios.CurrentRow.Cells["dgvtxtNumCuentaID"].Value.ToString();
                fbcsProdNombre = dgvSocios.CurrentRow.Cells["dgvtxtProducto"].Value.ToString();
                fbcsTipoMoneda = dgvSocios.CurrentRow.Cells["dgvtxtMoneda"].Value.ToString();
                fbcsTipoProducto = dgvSocios.CurrentRow.Cells["dgvtxtTipoProducto"].Value.ToString();
                fbcsSaldoTotal = Convert.ToDecimal(dgvSocios.CurrentRow.Cells["dgvtxtSaldo"].Value);
                fbcsValorTipoMonedaID = Convert.ToDecimal(dgvSocios.CurrentRow.Cells["dgvtxtValorMonedaID"].Value);
                this.Dispose();
            }
        }

        private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
            }
        }
    }
}
