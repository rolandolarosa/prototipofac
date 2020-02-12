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

namespace Efide.Tesoreria.WinAdeudosInversiones.busqueda
{
    public partial class frmBusquedaTransfDepo : frmBase.frmBusquedaBase
    {
        #region "ENTITY"
        private SocioBancoBL _SocioBancoBL;
        private SocioBancoBL oSocioBancoBL
        {
            get { return (_SocioBancoBL == null ? _SocioBancoBL = new SocioBancoBL() : _SocioBancoBL); }
        }

        private ValoresGeneralesBL _ValoresGeneralesBL;
        private ValoresGeneralesBL oValoresGeneralesBL
        {
            get { return (_ValoresGeneralesBL == null ? _ValoresGeneralesBL = new ValoresGeneralesBL() : _ValoresGeneralesBL); }
        }
        #endregion

        #region "PROPERTIES"
        public enum Movimiento
        {
            Ingreso = 1,
            Egreso = 2
        }
        bool isLoad = false;
        public Movimiento movimiento { get; set; }
        public GetEnum.Eventos Evento { get; set; }
        public string frmParentName { get; set; }
        public List<SocioBancoBE> lstSocioBancoBESel { get; set; }
        #endregion

        #region "FUNCTIONS"
        private void listSocioBancos()
        {
            SocioBancoBE oSocioBancoBE = new SocioBancoBE();
            List<SocioBancoBE> lstSocioBancoBE = new List<SocioBancoBE>();

            this.Invoke((MethodInvoker)delegate
            {
                if (!isLoad)
                {
                    if (frmParentName == "frmConfirmacionRescision")
                    {
                        cboMovimiento.SelectedIndex = 1;
                        cboMovimiento.Enabled = false;
                    }
                    oSocioBancoBE.ctaBancariaID = Convert.ToString(cboCuentasBancarias.SelectedValue);
                    oSocioBancoBE.numOperaBanco = txtNroOperacion.Text;
                    oSocioBancoBE.valorTipoOperacionID = Convert.ToInt32(cboMovimiento.SelectedValue); //Convert.ToInt32(movimiento);
                    oSocioBancoBE.sbVigente = true;
                    //oSocioBancoBE

                    lstSocioBancoBE = oSocioBancoBL.listSocioBanco(oSocioBancoBE);
                    dgvTransferencia.DataSource = lstSocioBancoBE;
                }
            });
        }
        private void listCuentasBancarias()
        {
            List<ValueListsBE> lstValoresGeneralesBE = new List<ValueListsBE>();
            lstValoresGeneralesBE = oValoresGeneralesBL.listCuentasBancarias();

            lstValoresGeneralesBE.Insert(0, new ValueListsBE() { ID = "", Name = "-TODOS-" });
            this.Invoke((MethodInvoker)delegate
            {
                cboCuentasBancarias.ValueMember = "ID";
                cboCuentasBancarias.DisplayMember = "Name";
                cboCuentasBancarias.DataSource = lstValoresGeneralesBE;
                cboCuentasBancarias.SelectedIndex = 0;
            });
        }
        private void listDestino()
        {
            List<ValoresGeneralesBE> listValoresGeneralesBE = new List<ValoresGeneralesBE>();
            ValoresGeneralesBE oValoresGeneralesBE = new ValoresGeneralesBE();
            oValoresGeneralesBE.valorID = Convert.ToInt32(GetTablasGenerales.destino);
            oValoresGeneralesBE.varEstado = true;

            listValoresGeneralesBE = oValoresGeneralesBL.listValoresGenerales(oValoresGeneralesBE);
            listValoresGeneralesBE.Insert(0, new ValoresGeneralesBE() { varCodigo = 0, varDescripcion = "-TODOS-" });
            this.Invoke((MethodInvoker)delegate
            {
                cboDestino.ValueMember = "varCodigo";
                cboDestino.DisplayMember = "varDescripcion";
                cboDestino.DataSource = listValoresGeneralesBE;
                cboDestino.SelectedIndex = 0;
            });
        }
        private void listIdentificacion()
        {
            List<ValoresGeneralesBE> listValoresGeneralesBE = new List<ValoresGeneralesBE>();
            ValoresGeneralesBE oValoresGeneralesBE = new ValoresGeneralesBE();
            oValoresGeneralesBE.valorID = Convert.ToInt32(GetTablasGenerales.identificacion);
            oValoresGeneralesBE.varEstado = true;

            listValoresGeneralesBE = oValoresGeneralesBL.listValoresGenerales(oValoresGeneralesBE);
            listValoresGeneralesBE.Insert(0, new ValoresGeneralesBE() { varCodigo = 0, varDescripcion = "-TODOS-" });
            this.Invoke((MethodInvoker)delegate
            {
                cboIdentificacion.ValueMember = "varCodigo";
                cboIdentificacion.DisplayMember = "varDescripcion";
                cboIdentificacion.DataSource = listValoresGeneralesBE;
                cboIdentificacion.SelectedIndex = 0;
            });
        }
        private void listMovimiento()
        {
            List<ValoresGeneralesBE> listValoresGeneralesBE = new List<ValoresGeneralesBE>();
            ValoresGeneralesBE oValoresGeneralesBE = new ValoresGeneralesBE();
            oValoresGeneralesBE.valorID = Convert.ToInt32(GetTablasGenerales.movimiento);
            oValoresGeneralesBE.varEstado = true;

            listValoresGeneralesBE = oValoresGeneralesBL.listValoresGenerales(oValoresGeneralesBE);
            listValoresGeneralesBE.Insert(0, new ValoresGeneralesBE() { varCodigo = 0, varDescripcion = "-TODOS-" });
            this.Invoke((MethodInvoker)delegate
            {
                cboMovimiento.ValueMember = "varCodigo";
                cboMovimiento.DisplayMember = "varDescripcion";
                cboMovimiento.DataSource = listValoresGeneralesBE;
                cboMovimiento.SelectedIndex = 0;
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
                    case GetEnum.Eventos.search:
                        btnBuscar.Visible = true;
                        btnSeleccionar.Visible = true;
                        btnSalir.Visible = true;
                        break;
                    case GetEnum.Eventos.edit:
                        break;
                    case GetEnum.Eventos.delete:
                        break;
                    default:
                        break;
                }
            });
        }
        #endregion

        public frmBusquedaTransfDepo()
        {
            InitializeComponent();
        }

        private void frmBusquedaTransfDepo_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTransferencia.AutoGenerateColumns = false;
                Task.Factory.StartNew(() =>
                {
                    isLoad = true;
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listDestino();
                    listMovimiento();
                    listIdentificacion();
                    listCuentasBancarias();
                    listSocioBancos();
                    isLoad = false;
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });

                configButon(Evento);
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar la información - Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listSocioBancos();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar los socios de bancos - Error: " + ex.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                List<SocioBancoBE> lstSocioBancoBE = new List<SocioBancoBE>();
                if(lstSocioBancoBESel == null)
                    lstSocioBancoBESel = new List<SocioBancoBE>();

                foreach (DataGridViewRow row in dgvTransferencia.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        lstSocioBancoBE.Add(new SocioBancoBE()
                        {
                            socioBancoID = Convert.ToString(row.Cells["socioBancoID"].Value),
                            ctasBanNumCta = Convert.ToString(row.Cells[1].Value),
                            ent_emprRazonSocial = Convert.ToString(row.Cells[2].Value),
                            tipoMoneda = Convert.ToString(row.Cells[3].Value),
                            sbImporte = Convert.ToDecimal(row.Cells[10].Value),
                            sbNumOperacion = Convert.ToString(row.Cells[5].Value),
                            tipollamada = Convert.ToString(row.Cells[7].Value),
                            sbFechaOperacion = Convert.ToDateTime(row.Cells[4].Value)
                        });
                    }
                }

                lstSocioBancoBESel = lstSocioBancoBE;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al seleccionar las transferencias/depósitos - Error: " + ex.Message);
            }
        }

        private void cboMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listSocioBancos();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar los socios de bancos - Error: " + ex.Message);
            }
        }

        private void cboIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listSocioBancos();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar los socios de bancos - Error: " + ex.Message);
            }
        }

        private void cboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listSocioBancos();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar los socios de bancos - Error: " + ex.Message);
            }
        }

        private void cboCuentasBancarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listSocioBancos();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar los socios de bancos - Error: " + ex.Message);
            }
        }
    }
}