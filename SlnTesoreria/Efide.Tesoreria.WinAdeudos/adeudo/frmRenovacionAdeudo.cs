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
    public partial class frmRenovacionAdeudo : frmBase.frmConfirmacionBase
    {
        #region " PROPERTIES "
        public string idRenovacion { get; set; }
        public string idAdeudo { get; set; }
        public GetEnum.Eventos Evento { get; set; }
        public string frmParentName { get; set; }
        #endregion

        #region "ENTITY"
        private AdeudoBL _AdeudoBL;
        private AdeudoBL oAdeudoBL
        {
            get { return (_AdeudoBL == null ? _AdeudoBL = new AdeudoBL() : _AdeudoBL); }
        }
        private RenovacionBL _RenovacionBL;
        private RenovacionBL oRenovacionBL
        {
            get { return (_RenovacionBL == null ? _RenovacionBL = new RenovacionBL() : _RenovacionBL); }
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

                cboTipoEntidadFinancieraNew.ValueMember = "varCodigo";
                cboTipoEntidadFinancieraNew.DisplayMember = "varDescripcion";
                cboTipoEntidadFinancieraNew.DataSource = listValoresGeneralesBE;
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

                cboMonedaNew.ValueMember = "varCodigo";
                cboMonedaNew.DisplayMember = "varDescripcion";
                cboMonedaNew.DataSource = listValoresGeneralesBE;
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

                cboBancoNew.ValueMember = "entFinancieraID";
                cboBancoNew.DisplayMember = "emprRazonSocial";
                cboBancoNew.DataSource = listEntidadesFinancierasBE;
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

                cboTipoInversionNew.ValueMember = "Table_Id";
                cboTipoInversionNew.DisplayMember = "Table_Name";
                cboTipoInversionNew.DataSource = listTableBaseBE;
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

                cboPlazoNew.Items.Add("0");
                cboPlazoNew.Items.Add("30");
                cboPlazoNew.Items.Add("60");
                cboPlazoNew.Items.Add("120");
                cboPlazoNew.Items.Add("240");
                cboPlazoNew.Items.Add("360");
                cboPlazoNew.Items.Add("720");
                cboPlazoNew.Items.Add("1080");
                cboPlazoNew.Items.Add("1440");
                cboPlazoNew.Items.Add("1800");
                cboPlazoNew.SelectedIndex = 0;

                cboPlazoMinimoNew.Items.Add("0");
                cboPlazoMinimoNew.Items.Add("30");
                cboPlazoMinimoNew.Items.Add("60");
                cboPlazoMinimoNew.Items.Add("120");
                cboPlazoMinimoNew.Items.Add("240");
                cboPlazoMinimoNew.Items.Add("360");
                cboPlazoMinimoNew.Items.Add("720");
                cboPlazoMinimoNew.Items.Add("1080");
                cboPlazoMinimoNew.Items.Add("1440");
                cboPlazoMinimoNew.Items.Add("1800");
                cboPlazoMinimoNew.SelectedIndex = 0;
            });
        }
        private void listTipoRenovacion()
        {
            this.Invoke((MethodInvoker)delegate
            {
                List <cboValue>lstcboValue = new List<cboValue>();
                lstcboValue.Add(new cboValue() { id = 1, name = "Capital" });
                lstcboValue.Add(new cboValue() { id = 2, name = "Capital + Interés" });

                cboTipoRenovacion.ValueMember = "id";
                cboTipoRenovacion.DisplayMember = "name";
                cboTipoRenovacion.DataSource = lstcboValue;
                cboTipoRenovacion.SelectedValue = 2;
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
        private void cargarRenovacion(string idRenovacion)
        {
            RenovacionBE oRenovacionBE = new RenovacionBE();
            this.Invoke((MethodInvoker)delegate
            {
                oRenovacionBE = oRenovacionBL.getRenovacion(idRenovacion);
                cargarAdeudo(oRenovacionBE.idAdeudo);
                cboTipoRenovacion.SelectedValue = oRenovacionBE.idTipoRenovacion;

                if (oRenovacionBE.porcenImporte > 0)
                    txtPorcenImporte.Text = Convert.ToString(oRenovacionBE.porcenImporte);

                txtTasaInversionNew.Text = Convert.ToString(oRenovacionBE.tasa);
                txtTasaRescisionNew.Text = Convert.ToString(oRenovacionBE.tasaRescision);
                cboPlazoNew.Text = Convert.ToString(oRenovacionBE.plazo);
                cboPlazoMinimoNew.Text = Convert.ToString(oRenovacionBE.plazoRescision);
            });
        }
        private void cargarAdeudo(string idAdeudo)
        {
            AdeudoBE oAdeudoBE = new AdeudoBE();

            if (oAdeudoBE != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    txtBusqueda.Text = idAdeudo;
                    oAdeudoBE = oAdeudoBL.getAdeudo(txtBusqueda.Text, Util.General.GetFechaGlobal);

                    txtNroCertificado.Text = oAdeudoBE.nroCertificado;
                    cboTipoInversion.SelectedValue = oAdeudoBE.idTipoAdeudo;
                    cboTipoEntidadFinanciera.SelectedValue = oAdeudoBE.idTipoEntidadFinanciera;
                    cboBanco.SelectedValue = oAdeudoBE.idEntidadFinanciera;
                    cboMoneda.SelectedValue = oAdeudoBE.idMoneda;
                    txtImporteInversion.Text = oAdeudoBE.importe.ToString("N");
                    txtTasaInversion.Text = oAdeudoBE.tasa.ToString("N");
                    dtFechaInicio.Value = oAdeudoBE.fechaInicio;
                    dtFechaVencimiento.Value = oAdeudoBE.fechaVencimiento;
                    cboPlazo.SelectedValue = oAdeudoBE.plazo;

                    txtTasaRescision.Text = oAdeudoBE.tasaRescision.ToString("N");
                    //txtPlazoRescision.Text = oInversionBE.plazoRescision.ToString();
                    txtImporteRescision.Text = oAdeudoBE.importe.ToString("N");
                    txtInteresRescision.Text = (oAdeudoBE.importe * (oAdeudoBE.tasaRescision / 100)).ToString("N");
                    txtTotalCobrar.Text = (Convert.ToDouble(txtInteresRescision.Text) + Convert.ToDouble(txtImporteRescision.Text)).ToString("N");

                    txtImporteInversionNew.Text = txtTotalCobrar.Text;
                    //cboPlazo
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
                    //txtPlazoRescision.Text = string.Empty;
                    txtImporteRescision.Text = string.Empty;
                    txtInteresRescision.Text = string.Empty;
                    txtTotalCobrar.Text = string.Empty;
                    //dtpFechaRescision.Text = string.Empty;
                });

                ucMsgBox1.ShowMessageWarnnig("No se encuentra el código de inversión ingresado");
            }
        }
        private bool saveRenovacion(string pIdAdeudo)
        {
            if (string.IsNullOrEmpty(txtBusqueda.Text))
            {
                ucMsgBox1.ShowMessageWarnnig("Debe seleccionar una inversión para guardar la renovación");
                return false;
            }

            this.Invoke((MethodInvoker)delegate
            {
                RenovacionBE oRenovacionBE = new RenovacionBE();

                oRenovacionBE.idAdeudo = idAdeudo;
                oRenovacionBE.idTipoRenovacion = Convert.ToInt32(cboTipoRenovacion.SelectedValue);

                if (string.IsNullOrEmpty(txtPorcenImporte.Text))
                    oRenovacionBE.porcenImporte = 0;
                else
                    oRenovacionBE.porcenImporte = Convert.ToDecimal(txtPorcenImporte.Text);

                oRenovacionBE.plazo = Convert.ToDecimal(cboPlazo.Text);
                oRenovacionBE.plazoRescision = Convert.ToInt32(cboPlazoMinimoNew.Text);
                oRenovacionBE.tasa = Convert.ToDecimal(txtTasaInversionNew.Text);
                oRenovacionBE.tasaRescision = Convert.ToDecimal(txtTasaRescisionNew.Text);
                oRenovacionBE.idEstado = Util.EstadoInversion.Registrado;
                oRenovacionBE.fechaRenovacion = Util.General.GetFechaGlobal;
                oRenovacionBE.usuCreacion = General.GetCodigoUsuario;

                oRenovacionBL.insertRenovacion(oRenovacionBE);
                ucMsgBox1.ShowMessageSuccess("Se renovó satisfactoriamente le inversión");
            });

            return true;
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
                
                //btnConfirmar.Visible = true;
                //btnCancelar.Visible = true;
                //btnSalir.Visible = true;

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
                    case GetEnum.Eventos.confirmar:
                        btnConfirmar2.Visible = true;
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
        #endregion

        public frmRenovacionAdeudo()
        {
            InitializeComponent();
        }

        private void frmRenovacionAdeudo_Load(object sender, EventArgs e)
        {
            int tipoEntidadFinanciera = 0;
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listTipoEntidadFinanciera();
                    this.Invoke((MethodInvoker)delegate
                    {
                        tipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);
                        dtFechaInicioNew.Value = Util.General.GetFechaGlobal;
                        dtFechaVencimientoNew.Value = Util.General.GetFechaGlobal;
                    });
                    listTipoRenovacion();
                    listEntidadFinanciera(tipoEntidadFinanciera);
                    listInstrumentoAdeudo();
                    listMoneda();
                    listPlazo();

                    if (!string.IsNullOrEmpty(idRenovacion) && (Evento == GetEnum.Eventos.edit || Evento == GetEnum.Eventos.view))
                    {
                        cargarRenovacion(idRenovacion);
                        this.Invoke((MethodInvoker)delegate
                        {
                            cboPlazoNew.Enabled = false;
                            cboPlazoMinimoNew.Enabled = false;
                            txtTasaInversionNew.Enabled = false;
                            txtTasaRescisionNew.Enabled = false;
                            cboTipoRenovacion.Enabled = false;
                            txtPorcenImporte.Enabled = false;
                        });
                    }
                    else
                    {
                        cargarAdeudoModal();
                        Evento = GetEnum.Eventos.insert;
                    }

                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });

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

        private void cboPlazoNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtFechaVencimientoNew.Value = Convert.ToDateTime(dtFechaInicioNew.Value).AddDays(Convert.ToInt32(cboPlazoNew.Text));
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al calcular la fecha de vencimiento - Error: " + ex.Message);
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
                ucMsgBox1.ShowMessageError("Error al cargar el importe de la nueva inversión - Error: " + ex.Message);
            }
        }

        private void cboTipoRenovacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtPorcenImporte.Enabled = false;
                if (Convert.ToInt32(cboTipoRenovacion.SelectedValue) == 1)
                {
                    if (!string.IsNullOrEmpty(txtImporteInversion.Text))
                    {
                        txtImporteInversionNew.Text = txtImporteInversion.Text;
                        txtPorcenImporte.Enabled = true;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtInteresRescision.Text))
                        txtImporteInversionNew.Text = (Convert.ToDecimal(txtImporteRescision.Text) + Convert.ToDecimal(txtInteresRescision.Text)).ToString("N");
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar el importe de la nueva inversión - Error: " + ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Util.Validation.ValidateRequired(groupPanel1, errorProvider1))
                {
                    Task.Factory.StartNew(() =>
                    {
                        Util.Util.SetLoading(this, ucLoadingBar1, true);
                        if (saveRenovacion(txtBusqueda.Text))
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
                ucMsgBox1.ShowMessageError("Error al renovar la inversión - Error: " + ex.Message);
            }
        }

        private void txtPorcenImporte_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPorcenImporte.Text))
                {
                    txtImporteInversionNew.Text = (Convert.ToDecimal(txtImporteInversion.Text) * (Convert.ToDecimal(txtPorcenImporte.Text) / 100)).ToString("N");
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al calcular el importe de la inversión - Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    partial class cboValue
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}