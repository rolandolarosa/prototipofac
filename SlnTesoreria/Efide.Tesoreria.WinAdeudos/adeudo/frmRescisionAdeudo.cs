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
using Efide.Tesoreria.BusinessEntity.adeudo;
using Efide.Tesoreria.BusinessLogic;
using Efide.Tesoreria.BusinessLogic.adeudo;
using Efide.Tesoreria.Util;

namespace Efide.Tesoreria.WinAdeudos.adeudo
{
    public partial class frmRescisionAdeudo : frmBase.frmConfirmacionBase
    {
        public frmRescisionAdeudo()
        {
            InitializeComponent();
        }

        #region "ENTITY"
        private AdeudoBL _AdeudoBL;
        private AdeudoBL oAdeudoBL
        {
            get { return (_AdeudoBL == null ? _AdeudoBL = new AdeudoBL() : _AdeudoBL); }
        }
        private RescisionBL _RescisionBL;
        private RescisionBL oRescisionBL
        {
            get { return (_RescisionBL == null ? _RescisionBL = new RescisionBL() : _RescisionBL); }
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
        private TableBaseBL _TableBaseBL;
        private TableBaseBL oTableBaseBL
        {
            get { return (_TableBaseBL == null ? _TableBaseBL = new TableBaseBL() : _TableBaseBL); }
        }
        #endregion

        #region "PROPERTIES"
        public string idRescision { get; set; }
        public string idAdeudo { get; set; }
        public GetEnum.Eventos Evento { get; set; }
        public string frmParentName { get; set; }
        public bool isLoad { get; set; }
        #endregion

        #region "FUNCTIONS"
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
        private void listInstrumentoAdeudo()
        {
            TableBaseBE oTableBaseBE = new TableBaseBE();
            List<TableBaseBE> listTableBaseBE = new List<TableBaseBE>();
            oTableBaseBE.Table_Parent_Id = GetTablasGenerales.tipoAdeudos;
            oTableBaseBE.OPCION = 1;

            listTableBaseBE = oTableBaseBL.ProcesarTableBase(oTableBaseBE);
            this.Invoke((MethodInvoker)delegate
            {
                cboTipoInversion.ValueMember = "Table_Id";
                cboTipoInversion.DisplayMember = "Table_Name";
                cboTipoInversion.DataSource = listTableBaseBE;
            });
        }
        private void clear()
        {
            txtBusqueda.Text = string.Empty;

            cboTipoInversion.SelectedIndex = 0;
            cboTipoEntidadFinanciera.SelectedIndex = 0;
            cboBanco.SelectedIndex = 0;
            cboMoneda.SelectedIndex = 0;

            txtTasaInversion.Text = string.Empty;
            txtImporteInversion.Text = string.Empty;

            txtTasaRescision.Text = string.Empty;
            txtPlazoRescision.Text = string.Empty;
            txtImporteRescision.Text = string.Empty;
            txtInteresRescision.Text = string.Empty;
            txtTasaCerrada.Text = string.Empty;
            txtObservacionesResicision.Text = string.Empty;

            txtTotalCobrar.Text = string.Empty;
        }
        private bool saveRescision()
        {
            RescisionBE oRescisionBE = new RescisionBE();

            if (string.IsNullOrEmpty(txtBusqueda.Text))
            {
                ucMsgBox1.ShowMessageWarnnig("Debe seleccionar una inversión para guardar la rescisión");
                return false;
            }
            this.Invoke((MethodInvoker)delegate
            {
                idAdeudo = txtBusqueda.Text;
                oRescisionBE.idAdeudo = idAdeudo;
                oRescisionBE.tasa = string.IsNullOrEmpty(txtTasaRescision.Text) ? 0 : Convert.ToDecimal(txtTasaRescision.Text);
                oRescisionBE.plazo = string.IsNullOrEmpty(txtPlazoRescision.Text) ? 0 : Convert.ToInt32(txtPlazoRescision.Text);
                oRescisionBE.importe = string.IsNullOrEmpty(txtImporteRescision.Text) ? 0 : Convert.ToDecimal(txtImporteRescision.Text);
                oRescisionBE.interes = string.IsNullOrEmpty(txtInteresRescision.Text) ? 0 : Convert.ToDecimal(txtInteresRescision.Text);
                oRescisionBE.ITF = string.IsNullOrEmpty(txtITF.Text) ? 0 : Convert.ToDecimal(txtITF.Text);
                oRescisionBE.total = string.IsNullOrEmpty(txtTotalCobrar.Text) ? 0 : Convert.ToDecimal(txtTotalCobrar.Text);
                oRescisionBE.fechaRescision = dtpFechaRescision.Value;
                oRescisionBE.diferencia = string.IsNullOrEmpty(txtDiferencia.Text) ? 0 : Convert.ToDecimal(txtDiferencia.Text);
                oRescisionBE.diasTranscurridos = string.IsNullOrEmpty(txtDiasTranscurridos.Text) ? 0 : Convert.ToInt32(txtDiasTranscurridos.Text);

                if(!string.IsNullOrEmpty(txtTasaCerrada.Text))
                    oRescisionBE.tasaCerrada = string.IsNullOrEmpty(txtTasaCerrada.Text) ? 0 : Convert.ToDecimal(txtTasaCerrada.Text);
                else
                    oRescisionBE.tasaCerrada = string.IsNullOrEmpty(txtTasaRescision.Text) ? 0 : Convert.ToDecimal(txtTasaRescision.Text);

                if (!string.IsNullOrEmpty(txtInteresCerrado.Text))
                    oRescisionBE.interesCerrado = string.IsNullOrEmpty(txtInteresCerrado.Text) ? 0 : Convert.ToDecimal(txtInteresCerrado.Text);
                else
                    oRescisionBE.interesCerrado = string.IsNullOrEmpty(txtInteresCerrado.Text) ? 0 : Convert.ToDecimal(txtInteresCerrado.Text);

                oRescisionBE.observaciones = txtObservacionesResicision.Text;
                oRescisionBE.idEstado = Util.EstadoInversion.Registrado; //registrado
            });

            btnEnviarAcuerdo.Visible = true;

            switch (Evento)
            {
                case GetEnum.Eventos.view:
                    break;
                case GetEnum.Eventos.insert:
                    oRescisionBE.usuCreacion = General.GetCodigoUsuario;
                    oRescisionBE.fechaCrecion = Util.General.GetFechaGlobal;
                    idRescision = oRescisionBL.insertRescision(oRescisionBE);
                    ucMsgBox1.ShowMessageSuccess("Se registró satisfactoriamente la Rescisión de la inversión");
                    break;
                case GetEnum.Eventos.edit:
                    oRescisionBE.idRescision = idRescision;
                    oRescisionBE.usuUltActualizacion = General.GetCodigoUsuario;
                    oRescisionBE.fechaUltActualizacion = Util.General.GetFechaGlobal;
                    oRescisionBL.updateRescision(oRescisionBE);
                    ucMsgBox1.ShowMessageSuccess("Se actualizó satisfactoriamente la Rescisión de la inversión");
                    break;
                case GetEnum.Eventos.delete:
                    break;
                case GetEnum.Eventos.search:
                    break;
                default:
                    break;
            }

            this.Invoke((MethodInvoker)delegate
            {
                txtIdRescisionInversion.Text = idRescision;
            });

            return true;
        }
        private void cargarRescision(string idRescision)
        {
            RescisionBE oRescisionBE = new RescisionBE();
            AdeudoBE oAdeudoBE = new AdeudoBE();

            oRescisionBE = oRescisionBL.getRescision(idRescision);
            oAdeudoBE = oAdeudoBL.getAdeudo(oRescisionBE.idAdeudo, Util.General.GetFechaGlobal);
            if (oRescisionBE != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    txtIdRescisionInversion.Text = oRescisionBE.idRescision;

                    //Inversión
                    txtNroCertificado.Text = oRescisionBE.nroCertificado;
                    idAdeudo = oRescisionBE.idAdeudo;
                    txtBusqueda.Text = oRescisionBE.idAdeudo;
                    cboTipoInversion.SelectedValue = oRescisionBE.idTipoAdeudo;
                    cboTipoEntidadFinanciera.SelectedValue = oRescisionBE.idTipoEntidadFinanciera;
                    cboBanco.SelectedValue = oRescisionBE.idEntidadFinanciera;
                    cboMoneda.SelectedValue = oRescisionBE.idMoneda;
                    txtImporteInversion.Text = oRescisionBE.ImporteAdeudo.ToString("N");
                    txtTasaInversion.Text = oAdeudoBE.tasa.ToString("N");
                    txtTotalCobrar.Text = oRescisionBE.total.ToString("N");
                    cboPlazo.Text = oRescisionBE.plazo.ToString();
                    dtFechaInicio.Value = oRescisionBE.fechaInicio;
                    dtFechaVencimiento.Value = oRescisionBE.fechaVencimiento;

                    //Rescisión
                    txtTasaRescision.Text = oRescisionBE.tasa.ToString("N");
                    txtPlazoRescision.Text = oRescisionBE.plazoRescision.ToString();
                    txtImporteRescision.Text = oRescisionBE.importe.ToString("N");
                    txtInteresRescision.Text = oRescisionBE.interes.ToString("N");
                    txtTasaCerrada.Text = oRescisionBE.tasaCerrada.ToString("N");
                    txtInteresCerrado.Text = oRescisionBE.interesCerrado.ToString("N");
                    txtDiasTranscurridos.Text = oRescisionBE.diasTranscurridos.ToString();
                    txtITF.Text = oRescisionBE.ITF.ToString("N");
                    txtObservacionesResicision.Text = oRescisionBE.observaciones;
                    dtpFechaRescision.Value = oRescisionBE.fechaRescision;

                    txtDiferencia.Text = oRescisionBE.diferencia.ToString("N");

                    if (oRescisionBE.fechaRescision.ToShortDateString() != Util.General.GetFechaGlobal.ToShortDateString())
                        btnActualizar.Visible = true;

                    //if (txtTasaCerrada.Text != txtTasaRescision.Text)
                    if (oAdeudoBE.transcurrido < oRescisionBE.plazoRescision)
                    {
                        txtTasaRescision.Border.Border = DevComponents.DotNetBar.eStyleBorderType.Solid;
                        txtTasaRescision.Border.BorderColor = System.Drawing.Color.Crimson;
                        txtTasaRescision.Border.BorderWidth = 2;

                        showNotification("Sujeto a castigo");
                    }
                });
            }
            else
                ucMsgBox1.ShowMessageWarnnig("No se encuentra el código de inversión ingresado");
        }
        private void cargarAdeudo(string idAdeudo)
        {
            AdeudoBE oAdeudoBE = new AdeudoBE();

            txtBusqueda.Text = idAdeudo;
            oAdeudoBE = oAdeudoBL.getAdeudo(txtBusqueda.Text, Util.General.GetFechaGlobal);
            if (oAdeudoBE != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    txtNroCertificado.Text = oAdeudoBE.nroCertificado;
                    cboTipoInversion.SelectedValue = oAdeudoBE.idTipoAdeudo;
                    cboTipoEntidadFinanciera.SelectedValue = oAdeudoBE.idTipoEntidadFinanciera;
                    cboBanco.SelectedValue = oAdeudoBE.idEntidadFinanciera;
                    cboMoneda.SelectedValue = oAdeudoBE.idMoneda;
                    txtImporteInversion.Text = oAdeudoBE.importe.ToString("N");
                    txtTasaInversion.Text = oAdeudoBE.tasa.ToString("N");
                    dtFechaInicio.Value = oAdeudoBE.fechaInicio;
                    dtFechaVencimiento.Value = oAdeudoBE.fechaVencimiento;
                    cboPlazo.Text = oAdeudoBE.plazo.ToString();

                    txtTasaRescision.Text = oAdeudoBE.tasaRescision.ToString("N");
                    txtPlazoRescision.Text = oAdeudoBE.plazoRescision.ToString();
                    txtImporteRescision.Text = oAdeudoBE.importe.ToString("N");
                    txtInteresRescision.Text = (oAdeudoBE.importe * (oAdeudoBE.tasaRescision / 100)).ToString("N");
                    txtDiasTranscurridos.Text = oAdeudoBE.transcurrido.ToString();

                    txtITF.Text = ((Convert.ToDouble(txtInteresRescision.Text) + Convert.ToDouble(txtImporteRescision.Text)) * (Convert.ToDouble(0.005) / 100)).ToString("N");
                    txtTotalCobrar.Text = (Convert.ToDouble(txtInteresRescision.Text) + Convert.ToDouble(txtImporteRescision.Text) - Convert.ToDouble(txtITF.Text)).ToString("N");

                    dtpFechaRescision.Value = Util.General.GetFechaGlobal;

                    if (oAdeudoBE.transcurrido >= oAdeudoBE.plazo)
                        txtTasaRescision.Text = txtTasaInversion.Text;

                    actualizarFechaRescision(idAdeudo);

                    //if (txtTasaRescision.Text != txtTasaInversion.Text)
                    if (oAdeudoBE.transcurrido < oAdeudoBE.plazoRescision)
                    {
                        txtTasaRescision.Border.Border = DevComponents.DotNetBar.eStyleBorderType.Solid;
                        txtTasaRescision.Border.BorderColor = System.Drawing.Color.Crimson;
                        txtTasaRescision.Border.BorderWidth = 2;
                        
                        showNotification("Sujeto a castigo");
                    }

                    //txtDiferencia.Text = ((Convert.ToDouble(txtImporteInversion.Text) * (Convert.ToDouble(txtTasaInversion.Text) / 100)) - Convert.ToDouble(txtInteresRescision.Text)).ToString("N");
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    cboTipoInversion.SelectedIndex = 0;
                    cboTipoEntidadFinanciera.SelectedIndex = 0;
                    cboBanco.SelectedIndex = 0;
                    cboMoneda.SelectedIndex = 0;
                    txtImporteInversion.Text = string.Empty;
                    txtTasaInversion.Text = string.Empty;
                    txtTasaRescision.Text = string.Empty;
                    txtPlazoRescision.Text = string.Empty;
                    txtImporteRescision.Text = string.Empty;
                    txtInteresRescision.Text = string.Empty;
                    txtTotalCobrar.Text = string.Empty;
                    dtpFechaRescision.Text = string.Empty;
                    txtITF.Text = string.Empty;
                });

                ucMsgBox1.ShowMessageWarnnig("No se encuentra el código de inversión ingresado");
            }
        }
        private void cargarAdeudoModal()
        {
            AdeudoBE oInversionBE = new AdeudoBE();
            DialogResult result;
            this.Invoke((MethodInvoker)delegate
            {
                busqueda.frmBusquedaAdeudo frm = new busqueda.frmBusquedaAdeudo();

                frm.frmParentName = this.Name;
                frm.mode = frmBase.frmBusquedaBase.Mode.modal;
                frm.Estado = Util.EstadoInversion.Vigente;
                result = frm.ShowDialog(this);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    idAdeudo = frm.idAdeudo;
                    cargarAdeudo(idAdeudo);
                }
                frm.Close();
                frm.Dispose();
            });
        }
        private void configButon(GetEnum.Eventos evento)
        {
            this.Invoke((MethodInvoker)delegate
            {
                foreach (ButtonItem item in ribbonBar1.Items)
                {
                    if (item.GetType().Name == "ButtonItem" && item.Name != "btnActualizar")
                        item.Visible = false;
                }
                switch (evento)
                {
                    case GetEnum.Eventos.view:
                        btnSalir.Visible = true;
                        break;
                    case GetEnum.Eventos.insert:
                        btnConfirmar.Visible = true;
                        btnLimpiar.Visible = true;
                        btnSalir.Visible = true;
                        break;
                    case GetEnum.Eventos.edit:
                        btnConfirmar.Visible = true;
                        btnCancelar.Visible = true;
                        btnEnviarAcuerdo.Visible = true;
                        break;
                    case GetEnum.Eventos.delete:
                        break;
                    default:
                        break;
                }
            });
        }
        private void listPlazo()
        {
            this.Invoke((MethodInvoker)delegate
            {
                cboPlazo.Items.Add("0");
                cboPlazo.Items.Add("30");
                cboPlazo.Items.Add("60");
                cboPlazo.Items.Add("120");
                cboPlazo.Items.Add("240");
                cboPlazo.Items.Add("360");
                cboPlazo.Items.Add("720");
                cboPlazo.Items.Add("1080");
                cboPlazo.Items.Add("1440");
                cboPlazo.Items.Add("1800");
                cboPlazo.SelectedIndex = 0;
            });
        }
        private void showNotification(string message)
        {
            ToastNotification.Show(this, message, null, -1, eToastGlowColor.Red, 400, 348);
        }
        private void actualizarFechaRescision(string pIdAdeudo)
        {
            if (! isLoad)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    double interes = 0;
                    double porcen = 0;
                    double tasa = 0;

                    double interesCerrado = 0;
                    double porcenCerrado = 0;
                    double tasaCerrada = 0;

                    double interesSinCastigo = 0;
                    double porcenSinCastigo = 0;
                    double tasaSinCastigo = 0;

                    dtpFechaRescision.Value = Util.General.GetFechaGlobal;
                    AdeudoBE oAdeudoBE = new AdeudoBE();
                    oAdeudoBE = oAdeudoBL.getAdeudo(pIdAdeudo, Util.General.GetFechaGlobal);

                    if (oAdeudoBE.transcurrido >= oAdeudoBE.plazo)
                        txtTasaRescision.Text = txtTasaInversion.Text;

                    double importe = Convert.ToDouble(txtImporteInversion.Text);
                    int dias = (oAdeudoBE.transcurrido < oAdeudoBE.plazo ? oAdeudoBE.transcurrido : oAdeudoBE.plazo);
                    double poten = Convert.ToDouble((Convert.ToDouble(dias) / Convert.ToDouble(360)));

                    tasa = Convert.ToDouble(txtTasaRescision.Text);
                    porcen = Convert.ToDouble((tasa / Convert.ToDouble(100)) + 1);
                    interes = Convert.ToDouble(((Math.Pow(porcen, poten) - 1) * importe));

                    tasaSinCastigo = Convert.ToDouble(txtTasaInversion.Text);
                    porcenSinCastigo = Convert.ToDouble((tasaSinCastigo / Convert.ToDouble(100)) + 1);
                    interesSinCastigo = Convert.ToDouble(((Math.Pow(porcenSinCastigo, poten) - 1) * importe));

                    if (!string.IsNullOrEmpty(txtTasaCerrada.Text))
                    {
                        tasaCerrada = Convert.ToDouble(txtTasaCerrada.Text);
                        porcenCerrado = Convert.ToDouble((tasaCerrada / Convert.ToDouble(100)) + 1);
                        interesCerrado = Convert.ToDouble(((Math.Pow(porcenCerrado, poten) - 1) * importe));
                    }

                    double itf = ((interesCerrado == 0 ? interes : interesCerrado) + importe) * (0.005 / 100);
                    txtInteresRescision.Text = interes.ToString("N");
                    txtInteresCerrado.Text = interesCerrado.ToString("N");
                    txtDiferencia.Text = ((interesCerrado == 0 ? interes : interesCerrado) - interesSinCastigo).ToString("N");
                    txtTotalCobrar.Text = ((interesCerrado == 0 ? interes : interesCerrado) + importe - itf).ToString("N");
                    txtITF.Text = itf.ToString("N");

                    //txtDiferencia.Text = ((Convert.ToDouble(txtImporteInversion.Text) * (Convert.ToDouble(txtTasaInversion.Text) / 100)) - Convert.ToDouble(txtInteresRescision.Text)).ToString("N");
                });
            }
        }
        private bool validUpdateFecha(string pIdRescision)
        {
            if (dtpFechaRescision.Value.ToShortDateString() != Util.General.GetFechaGlobal.ToShortDateString())
            {
                ucMsgBox1.ShowMessageWarnnig("No puede enviar acuerdo, la fecha no corresponde");
                return false;
            }
            else
                return true;

        }
        #endregion

        private void frmRescisionAdeudo_Load(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    int tipoEntidadFinanciera = 0;
                    listTipoEntidadFinanciera();

                    this.Invoke((MethodInvoker)delegate
                    {
                        tipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);
                    });

                    listEntidadFinanciera(tipoEntidadFinanciera);
                    listInstrumentoAdeudo();
                    listMoneda();
                    listPlazo();
                    if (!string.IsNullOrEmpty(idRescision) && (Evento == GetEnum.Eventos.edit || Evento == GetEnum.Eventos.view))
                    {
                        isLoad = true;
                        cargarRescision(idRescision);
                        isLoad = false;
                    }
                    else //if (string.IsNullOrEmpty(idRescision) && string.IsNullOrEmpty(idInversion))
                    {

                        cargarAdeudoModal();
                        

                        Evento = GetEnum.Eventos.insert;
                    }

                    configButon(Evento);

                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar la información - Error: " + ex.Message);
            }
        }

        private void cboTipoEntidadFinanciera_SelectedValueChanged(object sender, EventArgs e)
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

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                this.Invoke((MethodInvoker)delegate
                {
                    adeudo.frmAdeudo frm = new adeudo.frmAdeudo();
                    frm.frmParentName = this.Name;
                    frm.idAdeudo = idAdeudo;
                    frm.Evento = GetEnum.Eventos.view;
                    frm.mode = frmBase.frmRegistroBase.Mode.modal;
                    result = frm.ShowDialog(this);
                    frm.Close();
                    frm.Dispose();
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar el detalle de la inversión - Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarAdeudoModal();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar la inversión - Error: " + ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Util.Validation.ValidateRequired(groupDetalle, errorProvider1) && Util.Validation.ValidateRequired(groupPanel2, errorProvider1))
                {
                    Task.Factory.StartNew(() =>
                    {
                        Util.Util.SetLoading(this, ucLoadingBar1, true);
                        if (saveRescision())
                        {
                            Util.Util.SetLoading(this, ucLoadingBar1, false);
                            this.Invoke((MethodInvoker)delegate
                            {
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                                this.Close();
                            });
                        }
                        else
                            Util.Util.SetLoading(this, ucLoadingBar1, false);
                    });
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al generar rescisión - Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al salir de la pantalla - Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al limpiar los controles de la pantalla - Error: " + ex.Message);
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(txtBusqueda.Text) && Convert.ToInt32(txtBusqueda.Text) > 0)
                    {
                        txtBusqueda.Text = txtBusqueda.Text.PadLeft(10, '0');
                        idAdeudo = txtBusqueda.Text;
                        Task.Factory.StartNew(() =>
                        {
                            Util.Util.SetLoading(this, ucLoadingBar1, true);
                            cargarAdeudo(idAdeudo);
                            Util.Util.SetLoading(this, ucLoadingBar1, false);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar la inversión - Error: " + ex.Message);
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
                ucMsgBox1.ShowMessageError("Error al cancelar la acción - Error: " + ex.Message);
            }
        }

        private void txtTasaCerrada_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    actualizarFechaRescision(idAdeudo);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al calcular el interés - Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                actualizarFechaRescision(txtBusqueda.Text);
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al actualizar los datos de rescisión - Error: " + ex.Message);
            }
        }

        private void btnEnviarAcuerdo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Util.Validation.ValidateRequired(groupDetalle, errorProvider1) && Util.Validation.ValidateRequired(groupPanel2, errorProvider1))
                {
                    Task.Factory.StartNew(() =>
                    {
                        Util.Util.SetLoading(this, ucLoadingBar1, true);
                        if (validUpdateFecha(idAdeudo))
                        {
                            Evento = GetEnum.Eventos.confirmar;
                            if (saveRescision())
                            {
                                Util.Util.SetLoading(this, ucLoadingBar1, false);
                                this.Invoke((MethodInvoker)delegate
                                {
                                    DialogResult = System.Windows.Forms.DialogResult.OK;
                                    this.Close();
                                });
                            }
                            else
                                Util.Util.SetLoading(this, ucLoadingBar1, false);
                        }
                        else
                            Util.Util.SetLoading(this, ucLoadingBar1, false);
                    });
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al enviar el acuerdo de rescisión - Error: " + ex.Message);
            }
        }

        private void txtInteresCerrado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    actualizarFechaRescision(idAdeudo);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al calcular el interés - Error: " + ex.Message);
            }
        }
    }
}