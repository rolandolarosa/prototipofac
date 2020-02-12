using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.inversion;
using Efide.Tesoreria.BusinessLogic;
using Efide.Tesoreria.BusinessLogic.inversion;
using Efide.Tesoreria.Util;

namespace Efide.Tesoreria.WinAdeudos.cuentaBancos
{
    public partial class frmListCuentaBancos : frmBase.frmListaBase
    {
        public frmListCuentaBancos()
        {
            InitializeComponent();
        }

        #region " PROPERTIES "
        public int cuentaBancosID { get; set; }
        public GetEnum.Eventos Evento { get; set; }
        public string frmParentName { get; set; }
        #endregion

        #region " ENTITY "
        private ValoresGeneralesBL _ValoresGeneralesBL;
        private ValoresGeneralesBL oValoresGeneralesBL
        {
            get { return (_ValoresGeneralesBL == null ? _ValoresGeneralesBL = new ValoresGeneralesBL() : _ValoresGeneralesBL); }
        }
        private EntidadesFinancierasBL _EntidadesFinancierasBL;
        private EntidadesFinancierasBL oEntidadesFinancierasBL
        {
            get { return (_EntidadesFinancierasBL == null ? _EntidadesFinancierasBL = new EntidadesFinancierasBL() : _EntidadesFinancierasBL); }
        }
        private CuentaBancosBL _CuentaBancosBL;
        private CuentaBancosBL oCuentaBancosBL
        {
            get { return (_CuentaBancosBL == null ? _CuentaBancosBL = new CuentaBancosBL() : _CuentaBancosBL); }
        }
        #endregion

        #region " FUNCTIONS "
        private void listEntidadFinanciera(int pidTipoEntidadFinanciera)
        {
            CuentaBancosBE oCuentaBancosBE = new CuentaBancosBE();
            List<CuentaBancosBE> listCuentaBancosBE = new List<CuentaBancosBE>();
            listCuentaBancosBE = oCuentaBancosBL.listCuentaBancos(pidTipoEntidadFinanciera);

            this.Invoke((MethodInvoker)delegate
            {
                dgvCuentaBancos.DataSource = listCuentaBancosBE;
            });
        }
        private void listTipoEntidadFinanciera()
        {
            ValoresGeneralesBE oValoresGeneralesBE = new ValoresGeneralesBE();
            List<ValoresGeneralesBE> listValoresGeneralesBE = new List<ValoresGeneralesBE>();
            oValoresGeneralesBE.valorID = Convert.ToInt32(GetTablasGenerales.tipoEntidadFinanciera);
            oValoresGeneralesBE.varEstado = true;

            listValoresGeneralesBE = oValoresGeneralesBL.listValoresGenerales(oValoresGeneralesBE);
            listValoresGeneralesBE.Insert(0, new ValoresGeneralesBE() { varCodigo = 0, varDescripcion = "-TODOS-" });

            this.Invoke((MethodInvoker)delegate
            {
                cboTipoEntidadFinanciera.ValueMember = "varCodigo";
                cboTipoEntidadFinanciera.DisplayMember = "varDescripcion";
                cboTipoEntidadFinanciera.DataSource = listValoresGeneralesBE;
                cboTipoEntidadFinanciera.SelectedIndex = 0;
            });
        }
        #endregion

        private void frmListCuentaBancos_Load(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    dgvCuentaBancos.AutoGenerateColumns = false;
                    listTipoEntidadFinanciera();
                    this.Invoke((MethodInvoker)delegate
                    {
                        listEntidadFinanciera(Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue));
                    });
                    btnLimpiar.Visible = false;
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar la información - Error: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                this.Invoke((MethodInvoker)delegate
                {
                    frmCuentaBancos frm = new frmCuentaBancos();
                    frm.frmParentName = this.Name;
                    //frm.idInversion = idInversion;
                    frm.Evento = GetEnum.Eventos.insert;
                    frm.mode = frmBase.frmRegistroBase.Mode.modal;
                    result = frm.ShowDialog(this);
                    frm.Close();
                    frm.Dispose();
                    listEntidadFinanciera(Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue));
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al crear una nueva cuenta de bancos - Error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                this.Invoke((MethodInvoker)delegate
                {
                    frmCuentaBancos frm = new frmCuentaBancos();
                    frm.frmParentName = this.Name;
                    frm.cuentaBancosID = Convert.ToInt32(dgvCuentaBancos.SelectedRows[0].Cells[6].Value);
                    frm.Evento = GetEnum.Eventos.edit;
                    frm.mode = frmBase.frmRegistroBase.Mode.modal;
                    result = frm.ShowDialog(this);
                    frm.Close();
                    frm.Dispose();
                    listEntidadFinanciera(Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue));
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar editar cuentas de bancos - Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    this.Invoke((MethodInvoker)delegate
                    {
                        listEntidadFinanciera(Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue));
                    });
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar cuentas de bancos - Error: " + ex.Message);
            }
        }

        private void dgvCuentaBancos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboTipoEntidadFinanciera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    this.Invoke((MethodInvoker)delegate
                    {
                        listEntidadFinanciera(Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue));
                    });
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar cuentas de bancos - Error: " + ex.Message);
            }
        }
    }
}