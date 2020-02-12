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
    public partial class frmCuentaBancos : frmBase.frmRegistroBase
    {
        #region " ENTITY "
        private TableBaseBL _TableBaseBL;
        private TableBaseBL oTableBaseBL
        {
            get { return (_TableBaseBL == null ? _TableBaseBL = new TableBaseBL() : _TableBaseBL); }
        }
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

        #region " PROPERTIES "
        public GetEnum.Eventos Evento { get; set; }
        public int cuentaBancosID { get; set; }
        public string frmParentName { get; set; }
        #endregion

        #region " FUNCTIONS "
        private void listTipoEntidadFinanciera()
        {
            ValoresGeneralesBE oValoresGeneralesBE = new ValoresGeneralesBE();
            List<ValoresGeneralesBE> listValoresGeneralesBE = new List<ValoresGeneralesBE>();
            oValoresGeneralesBE.valorID = Convert.ToInt32(GetTablasGenerales.tipoEntidadFinanciera);
            oValoresGeneralesBE.varEstado = true;

            listValoresGeneralesBE = oValoresGeneralesBL.listValoresGenerales(oValoresGeneralesBE);

            this.Invoke((MethodInvoker)delegate
            {
                cboTipoEntidadFinanciera.ValueMember = "varCodigo";
                cboTipoEntidadFinanciera.DisplayMember = "varDescripcion";
                cboTipoEntidadFinanciera.DataSource = listValoresGeneralesBE;
            });
        }
        private void listEntidadFinanciera(int valorTipoEntFinancID)
        {
            EntidadesFinancierasBE oEntidadesFinancierasBE = new EntidadesFinancierasBE();
            List<EntidadesFinancierasBE> listEntidadesFinancierasBE = new List<EntidadesFinancierasBE>();
            oEntidadesFinancierasBE.valorTipoEntFinancID = valorTipoEntFinancID;
            oEntidadesFinancierasBE.entFinEstado = true;
            listEntidadesFinancierasBE = oEntidadesFinancierasBL.obtenerEntidadesFinancieras(oEntidadesFinancierasBE);

            this.Invoke((MethodInvoker)delegate
            {
                cboBanco.ValueMember = "entFinancieraID";
                cboBanco.DisplayMember = "emprRazonSocial";
                cboBanco.DataSource = listEntidadesFinancierasBE;
            });
        }
        private void listMoneda()
        {
            ValoresGeneralesBE oValoresGeneralesBE = new ValoresGeneralesBE();
            List<ValoresGeneralesBE> listValoresGeneralesBE = new List<ValoresGeneralesBE>();
            oValoresGeneralesBE.valorID = Convert.ToInt32(GetTablasGenerales.moneda);
            oValoresGeneralesBE.varEstado = true;
            listValoresGeneralesBE = oValoresGeneralesBL.listValoresGenerales(oValoresGeneralesBE);

            this.Invoke((MethodInvoker)delegate
            {
                cboMoneda.ValueMember = "varCodigo";
                cboMoneda.DisplayMember = "varDescripcion";
                cboMoneda.DataSource = listValoresGeneralesBE;
            });
        }
        private void listTipoCuentaBancaria()
        {
            TableBaseBE oTableBaseBE = new TableBaseBE();
            List<TableBaseBE> listTableBaseBE = new List<TableBaseBE>();
            oTableBaseBE.Table_Parent_Id = GetTablasGenerales.TipoCuentaBancaria;
            oTableBaseBE.OPCION = 1;
            listTableBaseBE = oTableBaseBL.ProcesarTableBase(oTableBaseBE);

            this.Invoke((MethodInvoker)delegate
            {
                cboTipoCuenta.ValueMember = "Table_Id";
                cboTipoCuenta.DisplayMember = "Table_Name";
                cboTipoCuenta.DataSource = listTableBaseBE;
            });
        }

        private void configButon(GetEnum.Eventos evento)
        {
            this.Invoke((MethodInvoker)delegate
            {
                foreach (ButtonItem item in toolBar.Items)
                {
                    if (item.GetType().Name == "ButtonItem")
                        item.Visible = false;
                }
                switch (evento)
                {
                    case GetEnum.Eventos.view:
                        btnSalir.Visible = true;
                        break;
                    case GetEnum.Eventos.insert:
                        btnGuardar.Visible = true;
                        btnLimpiar.Visible = true;
                        btnSalir.Visible = true;
                        break;
                    case GetEnum.Eventos.edit:
                        btnGuardar.Visible = true;
                        btnCancelar.Visible = true;
                        break;
                    case GetEnum.Eventos.delete:
                        break;
                    default:
                        break;
                }
            });
        }
        private void saveCuentaBanco(){
            CuentaBancosBE oCuentaBancosBE = new CuentaBancosBE();
            this.Invoke((MethodInvoker)delegate
            {
                oCuentaBancosBE.cuentaBancoID = cuentaBancosID;
                oCuentaBancosBE.cuentaCCI = txtCuentaCCI.Text;
                oCuentaBancosBE.cuentaLocal = txtCuentaLocal.Text;
                oCuentaBancosBE.idTipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);
                oCuentaBancosBE.idEntidadFinanciera = Convert.ToString(cboBanco.SelectedValue);
                oCuentaBancosBE.idMoneda = Convert.ToInt32(cboMoneda.SelectedValue);
                oCuentaBancosBE.idTipoCuenta = Convert.ToString(cboTipoCuenta.SelectedValue);
            });

            switch (Evento)
            {
                case GetEnum.Eventos.insert:
                    oCuentaBancosBE.usuCreacion = General.GetCodigoUsuario;
                    oCuentaBancosBL.insertCuentaBancos(oCuentaBancosBE);
                    ucMsgBox1.ShowMessageSuccess("Se registró satisfactoriamente la cuenta de banco");
                    break;
                case GetEnum.Eventos.edit:
                    oCuentaBancosBE.usuUltActualizacion = General.GetCodigoUsuario;
                    oCuentaBancosBL.updateCuentaBancos(oCuentaBancosBE);
                    ucMsgBox1.ShowMessageSuccess("Se actualizó satisfactoriamente la cuenta de banco");
                    break;
                default:
                    break;
            }
        }
        private void loadCuentaBanco(int cuentaBancosID)
        {
            CuentaBancosBE oCuentaBancosBE = new CuentaBancosBE();
            oCuentaBancosBE = oCuentaBancosBL.getCuentaBancos(cuentaBancosID);
            this.Invoke((MethodInvoker)delegate
            {
                cuentaBancosID = oCuentaBancosBE.cuentaBancoID;
                txtCuentaCCI.Text = oCuentaBancosBE.cuentaCCI;
                txtCuentaLocal.Text = oCuentaBancosBE.cuentaLocal;
                cboTipoEntidadFinanciera.SelectedValue = Convert.ToDecimal(oCuentaBancosBE.idTipoEntidadFinanciera);
                cboBanco.SelectedValue = oCuentaBancosBE.idEntidadFinanciera;
                cboMoneda.SelectedValue = Convert.ToDecimal(oCuentaBancosBE.idMoneda);
                cboTipoCuenta.SelectedValue = oCuentaBancosBE.idTipoCuenta;
            });
        }
        #endregion

        public frmCuentaBancos()
        {
            InitializeComponent();
        }

        private void frmCuentaBancos_Load(object sender, EventArgs e)
        {
            try
            {
                //int tipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);

                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listTipoEntidadFinanciera();
                    //listEntidadFinanciera(Convert.ToInt32(tipoEntidadFinanciera)); //TIPO DE ENTIDAD BANCOS (1)
                    listMoneda();
                    listTipoCuentaBancaria();

                    if (cuentaBancosID !=0 && (Evento == GetEnum.Eventos.edit || Evento == GetEnum.Eventos.view))
                        loadCuentaBanco(cuentaBancosID);
                    else
                        Evento = GetEnum.Eventos.insert;

                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
                configButon(Evento);
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar la información - Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    saveCuentaBanco();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);

                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Close();
                    });
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al guardar cuenta bancaria - Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                cboTipoEntidadFinanciera.SelectedItem = 0;
                cboBanco.SelectedIndex = 0;
                cboMoneda.SelectedIndex = 0;
                cboTipoCuenta.SelectedIndex = 0;
                txtCuentaCCI.Text = "";
                txtCuentaLocal.Text = "";
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al limpiar controles - Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cancelar - Error: " + ex.Message);
            }
        }

        private void cboTipoEntidadFinanciera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tipoEntidadFinanciera = "";

                this.Invoke((MethodInvoker)delegate
                {
                if (cboTipoEntidadFinanciera.SelectedValue != null)
                    tipoEntidadFinanciera = cboTipoEntidadFinanciera.SelectedValue.ToString();
                });
                Task.Factory.StartNew(() =>
                {
                Util.Util.SetLoading(this, ucLoadingBar1, true);
                if (!string.IsNullOrEmpty(tipoEntidadFinanciera))
                    listEntidadFinanciera(Convert.ToInt32(tipoEntidadFinanciera));
                Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar las entidades financieras - Error: " + ex.Message);
            }
        }
    }
}