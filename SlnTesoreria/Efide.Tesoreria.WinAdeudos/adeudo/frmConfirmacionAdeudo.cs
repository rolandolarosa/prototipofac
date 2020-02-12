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
    public partial class frmConfirmacionAdeudo : frmBase.frmConfirmacionBase
    {
        #region "PROPERTIES"
        public string idConfirmacion { get; set; }
        public string idAdeudo { get; set; }
        public GetEnum.Eventos Evento { get; set; }
        public List<SocioBancoBE> lstSocioBancoBE { get; set; }
        #endregion

        #region "ENTITY"
        private ConfirmacionBL _ConfirmacionBL;
        private ConfirmacionBL oConfirmacionBL
        {
            get { return (_ConfirmacionBL == null ? _ConfirmacionBL = new ConfirmacionBL() : _ConfirmacionBL); }
        }
        private ConfirmacionDetalleBL _ConfirmacionDetalleBL;
        private ConfirmacionDetalleBL oConfirmacionDetalleBL
        {
            get { return (_ConfirmacionDetalleBL == null ? _ConfirmacionDetalleBL = new ConfirmacionDetalleBL() : _ConfirmacionDetalleBL); }
        }
        private SocioBancoBL _SocioBancoBL;
        private SocioBancoBL oSocioBancoBL
        {
            get { return (_SocioBancoBL == null ? _SocioBancoBL = new SocioBancoBL() : _SocioBancoBL); }
        }
        private AdeudoBL _AdeudoBL;
        private AdeudoBL oAdeudoBL
        {
            get { return (_AdeudoBL == null ? _AdeudoBL = new AdeudoBL() : _AdeudoBL); }
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

        #region "FUNCTIONS"
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
        private void listPlazoRescision()
        {
            this.Invoke((MethodInvoker)delegate
            {
                cboPlazoRescision.Items.Add("0");
                cboPlazoRescision.Items.Add("30");
                cboPlazoRescision.Items.Add("60");
                cboPlazoRescision.Items.Add("120");
                cboPlazoRescision.Items.Add("240");
                cboPlazoRescision.Items.Add("360");
                cboPlazoRescision.Items.Add("720");
                cboPlazoRescision.Items.Add("1080");
                cboPlazoRescision.Items.Add("1440");
                cboPlazoRescision.Items.Add("1800");
                cboPlazoRescision.SelectedIndex = 0;
            });
        }
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
        private void configButon(GetEnum.Eventos evento)
        {
            this.Invoke((MethodInvoker)delegate
            {
                foreach (ButtonItem item in ribbonBar1.Items)
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
                        btnConfirmar.Visible = true;
                        btnLimpiar.Visible = true;
                        btnSalir.Visible = true;
                        break;
                    case GetEnum.Eventos.edit:
                        btnConfirmar.Visible = true;
                        btnCancelar.Visible = true;
                        break;
                    case GetEnum.Eventos.delete:
                        break;
                    default:
                        break;
                }
            });
        }
        private void cargarAdeudoModal()
        {
            AdeudoBE oAdeudoBE = new AdeudoBE();
            DialogResult result;
            this.Invoke((MethodInvoker)delegate
            {
                busqueda.frmBusquedaAdeudo frm = new busqueda.frmBusquedaAdeudo();

                frm.frmParentName = this.Name;
                frm.mode = frmBase.frmBusquedaBase.Mode.modal;
                frm.Estado = Util.EstadoInversion.Registrado;
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
        private void cargarAdeudo(string idAdeudo)
        {
            AdeudoBE oAdeudoBE = new AdeudoBE();

            txtBusqueda.Text = idAdeudo;
            oAdeudoBE = oAdeudoBL.getAdeudo(txtBusqueda.Text, Util.General.GetFechaGlobal);
            if (oAdeudoBE != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    cboTipoInversion.SelectedValue = oAdeudoBE.idTipoAdeudo;
                    cboTipoEntidadFinanciera.SelectedValue = oAdeudoBE.idTipoEntidadFinanciera;
                    cboBanco.SelectedValue = oAdeudoBE.idEntidadFinanciera;
                    cboMoneda.SelectedValue = oAdeudoBE.idMoneda;
                    txtImporteInversion.Text = oAdeudoBE.importe.ToString("N");
                    txtTasaInversion.Text = oAdeudoBE.tasa.ToString("N");

                    cboPlazo.Text = oAdeudoBE.plazo.ToString();
                    dtFechaInicio.Value = oAdeudoBE.fechaInicio;
                    dtFechaVencimiento.Value = oAdeudoBE.fechaVencimiento;

                    txtTasaRescision.Text = oAdeudoBE.tasaRescision.ToString("N");
                    cboPlazoRescision.Text = oAdeudoBE.plazoRescision.ToString();
                    txtImporteRescision.Text = (oAdeudoBE.importe + (oAdeudoBE.importe * (oAdeudoBE.tasaRescision / 100))).ToString("N");

                    txtObservaciones.Text = oAdeudoBE.observaciones;
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
                });

                ucMsgBox1.ShowMessageWarnnig("No se encuentra el código de inversión ingresado");
            }
        }
        private void enviarAcuerdo()
        {

        }
        private void saveConfirmacion()
        {
            ConfirmacionBE oConfirmacionBE = new ConfirmacionBE(){
                idRelacionado = idAdeudo,
                idTipoConfirmacion = 1,
                importeRescision = Convert.ToDecimal(txtImporteRescision.Text)
            };

            AdeudoBE oAdeudoBE = new AdeudoBE();
            AdeudoBL oAdeudoBL = new AdeudoBL();

            switch (Evento)
            {
                case GetEnum.Eventos.view:
                    break;
                case GetEnum.Eventos.insert:
                    if (ucMsgBox1.ShowMessageConfirmation("¿Está seguro que desea confirmar la inversión?") == eTaskDialogResult.Yes)
                    {
                        ucMsgBox1.ShowMessageInformation("Se enviará el acuerdo por correo electrónico a todos los involucrados");

                        oConfirmacionBE.usuCreacion = General.GetCodigoUsuario;
                        oConfirmacionBE.fechaCreacion = Util.General.GetFechaGlobal;
                        idConfirmacion = oConfirmacionBL.insertConfirmacion(oConfirmacionBE);

                        oAdeudoBE = oAdeudoBL.getAdeudo(idAdeudo, Util.General.GetFechaGlobal);
                        oAdeudoBE.idEstado = Util.EstadoInversion.Vigente;
                        oAdeudoBE.usuUltActualizacion = General.GetCodigoUsuario;
                        oAdeudoBE.fechaUltActualizacion = Util.General.GetFechaGlobal;
                        oAdeudoBL.updateAdeudo(oAdeudoBE);

                        ucMsgBox1.ShowMessageSuccess("Se guardó satisfactoriamente la confirmación de la inversión");
                    }
                    break;
                case GetEnum.Eventos.edit:
                    break;
                case GetEnum.Eventos.delete:
                    break;
                case GetEnum.Eventos.search:
                    break;
                default:
                    break;
            }
        }
        private bool valSaveConfirmacion()
        {
            if (string.IsNullOrEmpty(txtBusqueda.Text))
            {
                ucMsgBox1.ShowMessageWarnnig("Debe seleccionar una inversión para poder realizar su confirmación");
                return false;
            }

            return true;
        }
        private void clearControls()
        {
            txtBusqueda.Text = string.Empty;

            txtImporteInversion.Text = string.Empty;
            txtImporteRescision.Text = string.Empty;
            txtTasaInversion.Text = string.Empty;

            cboTipoInversion.SelectedIndex = 0;
            cboTipoEntidadFinanciera.SelectedIndex = 0;
            cboBanco.SelectedIndex = 0;
            cboMoneda.SelectedIndex = 0;

            clearValidation();
        }
        private void clearValidation()
        {
            Util.Validation.CleanValidate(groupDetalle);
        }
        #endregion

        public frmConfirmacionAdeudo()
        {
            InitializeComponent();
        }

        private void frmConfirmacionAdeudo_Load(object sender, EventArgs e)
        {
            try
            {
                int tipoEntidadFinanciera = 0;
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listTipoEntidadFinanciera();
                    listPlazo();
                    listPlazoRescision();
                    this.Invoke((MethodInvoker)delegate
                    {
                        tipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);
                    });
                    listEntidadFinanciera(tipoEntidadFinanciera);
                    listInstrumentoAdeudo();
                    listMoneda();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });

                cargarAdeudoModal();
                Evento = GetEnum.Eventos.insert;

                configButon(Evento);
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar la información - Error: " + ex.Message);
            }
        }

        private void cboTipoEntidadFinanciera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listEntidadFinanciera(tipoEntidadFinanciera);
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar las entidades financieras - Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    cargarAdeudoModal();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar la inversión - Error: " + ex.Message);
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Util.Validation.ValidateRequired(groupDetalle, errorProvider1))
                {
                    Task.Factory.StartNew(() =>
                    {
                        if (valSaveConfirmacion())
                        {
                            Util.Util.SetLoading(this, ucLoadingBar1, true);
                            saveConfirmacion();
                            enviarAcuerdo();
                            Util.Util.SetLoading(this, ucLoadingBar1, false);
                            this.Invoke((MethodInvoker)delegate
                            {
                                this.Close();
                            });
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al guardar confirmación - Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                clearControls();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al limpiar los controles de la pantalla - Error: " + ex.Message);
            }
        }
    }
}