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

namespace Efide.Tesoreria.WinAdeudosInversiones.inversion
{
    public partial class frmConfirmacionRescision : frmBase.frmConfirmacionBase
    {
        #region "PROPERTIES"
        public string idConfirmacion { get; set; }
        public string idRescision{ get; set; }
        public GetEnum.Eventos Evento { get; set; }
        public List<SocioBancoBE> lstSocioBancoBE { get; set; }
        public TipoOperacionAdeInv tipo { get; set; }
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
        private InversionBL _InversionBL;
        private InversionBL oInversionBL
        {
            get { return (_InversionBL == null ? _InversionBL = new InversionBL() : _InversionBL); }
        }
        //private AdeudoBL _AdeudoBL;
        //private AdeudoBL oAdeudoBL
        //{
        //    get { return (_AdeudoBL == null ? _AdeudoBL = new AdeudoBL() : _AdeudoBL); }
        //}
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

        #region "FUNCTIONS"
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
        private void cargarConfirmacion(string idConfirmacion)
        {

        }
        private void cargarInversionModal()
        {
            InversionBE oInversionBE = new InversionBE();
            DialogResult result;
            this.Invoke((MethodInvoker)delegate
            {
                busqueda.frmBusquedaRescision frm = new busqueda.frmBusquedaRescision();

                frm.frmParentName = this.Name;
                frm.Estado = EstadoInversion.Registrado;
                frm.mode = frmBase.frmBusquedaBase.Mode.modal;

                if (tipo == TipoOperacionAdeInv.inversion)
                    frm.tipoBusqueda = frmBase.frmBusquedaBase.TipoBusqueda.inversion;
                else
                    frm.tipoBusqueda = frmBase.frmBusquedaBase.TipoBusqueda.adeudo;

                    result = frm.ShowDialog(this);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    idRescision = frm.idRescision;
                    cargarRescision(idRescision);
                }
                frm.Close();
                frm.Dispose();
            });
        }

        private void cargarRescision(string idRescision)
        {
            RescisionBE oRescisionBE = new RescisionBE();

            txtBusqueda.Text = idRescision;
            oRescisionBE = oRescisionBL.getRescision(txtBusqueda.Text);
            if (oRescisionBE != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    txtTasaRescision.Text = oRescisionBE.tasa.ToString("N");
                    txtPlazoRescision.Text = oRescisionBE.plazo.ToString("N");
                    txtImporteRescision.Text = oRescisionBE.importe.ToString("N");
                    txtInteresRescision.Text = oRescisionBE.interes.ToString("N");
                    txtTotalCobrar.Text = oRescisionBE.total.ToString("N");
                    txtTasaCerrada.Text = oRescisionBE.tasaCerrada.ToString("N");
                    txtObservacionesResicision.Text = oRescisionBE.observaciones;

                    txtInteresCerrado.Text = oRescisionBE.interesCerrado.ToString("N");
                    txtItf.Text = oRescisionBE.ITF.ToString("N");
                    txtDiasTranscurridos.Text = oRescisionBE.diasTranscurridos.ToString();
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    txtTasaRescision.Text = string.Empty;
                    txtPlazoRescision.Text = string.Empty;
                    txtImporteRescision.Text = string.Empty;
                    txtInteresRescision.Text = string.Empty;
                    txtTotalCobrar.Text = string.Empty;
                    txtTasaCerrada.Text = string.Empty;
                    txtObservacionesResicision.Text = string.Empty;
                });

                ucMsgBox1.ShowMessageWarnnig("No se encuentra el código de rescisión ingresado");
            }
        }
        private void listSocioBancos(List<SocioBancoBE> _lstSocioBancoBE)
        {
            //this.Invoke((MethodInvoker)delegate
            //{
                lstSocioBancoBE = _lstSocioBancoBE;
                dgvDepositos2.DataSource = lstSocioBancoBE;
            //});
        }
        private void clearControls()
        {
            txtBusqueda.Text = string.Empty;

            txtTasaRescision.Text = string.Empty;
            txtPlazoRescision.Text = string.Empty;
            txtImporteRescision.Text = string.Empty;
            txtInteresRescision.Text = string.Empty;
            txtTotalCobrar.Text = string.Empty;
            txtTasaCerrada.Text = string.Empty;
            txtObservacionesResicision.Text = string.Empty;

            dgvDepositos2.DataSource = null;
            clearValidation();
        }
        private void clearValidation()
        {
            Util.Validation.CleanValidate(groupDetalle);
        }
        private bool valSaveConfirmacion()
        {
            double importeTotal = 0;

            if (string.IsNullOrEmpty(txtBusqueda.Text))
            {
                ucMsgBox1.ShowMessageWarnnig("Debe seleccionar una inversión para poder realizar su confirmación");
                return false;
            }
            if (dgvDepositos2.Rows.Count == 0)
            {
                ucMsgBox1.ShowMessageWarnnig("Debe seleccionar al menos una transferencia en bancos");
                return false;
            }

            foreach (DataGridViewRow row in dgvDepositos2.Rows)
            {
                importeTotal += Convert.ToDouble(row.Cells["sbImporte"].Value.ToString());
            }

            if (importeTotal < Convert.ToDouble(txtTotalCobrar.Text))
            {
                ucMsgBox1.ShowMessageWarnnig("El total de los depósitos debe ser igual o mayor al importe total a cobrar");
                return false;
            }

            return true;
        }
        private void saveConfirmacion()
        {
            RescisionBE oRescisionBE = new RescisionBE();
            ConfirmacionBE oConfirmacionBE = new ConfirmacionBE()
            {
                idRelacionado = idRescision,
                idTipoConfirmacion = 2,
                tasa = Convert.ToDecimal(txtTasaCerrada.Text),
                importe = Convert.ToDecimal(txtImporteRescision.Text),
                interes = Convert.ToDecimal(txtInteresRescision.Text),
                importeCobrar = Convert.ToDecimal((string.IsNullOrWhiteSpace(txtTotalCobrar.Text) ? "" : txtTotalCobrar.Text))
            };

            switch (Evento)
            {
                case GetEnum.Eventos.view:
                    break;
                case GetEnum.Eventos.insert:
                    oConfirmacionBE.usuCreacion = General.GetCodigoUsuario;
                    oConfirmacionBE.fechaCreacion = Util.General.GetFechaGlobal;
                    idConfirmacion = oConfirmacionBL.insertConfirmacion(oConfirmacionBE);
                    saveConfirmacionDetail(idConfirmacion);

                    oRescisionBE = oRescisionBL.getRescision(idRescision);
                    oRescisionBE.usuCreacion = General.GetCodigoUsuario;
                    oRescisionBE.fechaUltActualizacion = Util.General.GetFechaGlobal;
                    oRescisionBE.idEstado = Util.EstadoInversion.Aplicada;
                    oRescisionBL.updateRescision(oRescisionBE);

                    InversionBE oInversionBE = new InversionBE();
                    oInversionBE = oInversionBL.getInversion(oRescisionBE.idInversion, Util.General.GetFechaGlobal);
                    oInversionBE.usuCreacion = General.GetCodigoUsuario;
                    oInversionBE.fechaUltActualizacion = Util.General.GetFechaGlobal;

                    if (oInversionBE.fechaVencimiento <= Util.General.GetFechaGlobal)
                        oInversionBE.idEstado = Util.EstadoInversion.Cancelado;
                    else
                        oInversionBE.idEstado = Util.EstadoInversion.Rescidido;

                    oInversionBL.updateInversion(oInversionBE);
                    ucMsgBox1.ShowMessageSuccess("Se guardó satisfactoriamente la confirmación de la rescisión");
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
        private void saveConfirmacionDetail(string idConfirmacion)
        {
            ConfirmacionDetalleBE oConfirmacionDetalleBE = new ConfirmacionDetalleBE();
            int cantRow = dgvDepositos2.Rows.Count;
            decimal importe = 0;
            RescisionBE oRescisionBE = new RescisionBE();

            foreach (DataGridViewRow row in dgvDepositos2.Rows)
            {
                oConfirmacionDetalleBE = new ConfirmacionDetalleBE()
                {
                    idConfirmacion = idConfirmacion,
                    socioBancoID = row.Cells["socioBancoID"].Value.ToString()
                };

                oConfirmacionDetalleBL.insertConfirmacionDetalle(oConfirmacionDetalleBE);
                if(cantRow == 1)
                    importe = Convert.ToDecimal(txtTotalCobrar.Text);

                oRescisionBE = oRescisionBL.getRescision(idRescision);
                oRescisionBE.socioBancoID = oConfirmacionDetalleBE.socioBancoID;
                oRescisionBE.importe = importe;
                oRescisionBE.Glosa = @"Rescisión de Inversiones - Adeudos a inversiones";
                oRescisionBE.gSesionID = Util.General.GetSessionGlobal;
                oSocioBancoBL.insertMovimintoSocio(oRescisionBE);
            }
        }
        #endregion

        public frmConfirmacionRescision()
        {
            InitializeComponent();
        }

        private void frmConfirmacionRescision_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDepositos2.AutoGenerateColumns = false;
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);

                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });

                if (!string.IsNullOrEmpty(idConfirmacion) && (Evento == GetEnum.Eventos.edit || Evento == GetEnum.Eventos.view))
                    cargarConfirmacion(idConfirmacion);
                else
                {
                    cargarInversionModal();
                    Evento = GetEnum.Eventos.insert;
                }

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
                    cargarInversionModal();
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
                    inversion.frmRescisionInversion frm = new inversion.frmRescisionInversion();
                    frm.frmParentName = this.Name;
                    frm.idInversion = idRescision;
                    frm.Evento = GetEnum.Eventos.view;
                    frm.mode = frmBase.frmConfirmacionBase.Mode.modal;
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
                        idRescision = txtBusqueda.Text;
                        Task.Factory.StartNew(() =>
                        {
                            Util.Util.SetLoading(this, ucLoadingBar1, true);
                            cargarRescision(idRescision);
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

        private void btnSelTransDepo_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    InversionBE oInversionBE = new InversionBE();
                    RescisionBE oRescisionBE = new RescisionBE();

                    oRescisionBE = oRescisionBL.getRescision(txtBusqueda.Text);
                    oInversionBE = oInversionBL.getInversion(oRescisionBE.idInversion, Util.General.GetFechaGlobal);
                    DialogResult result;
                    busqueda.frmBusquedaTransfXAplicar frm = new busqueda.frmBusquedaTransfXAplicar();
                    frm.frmParentName = this.Name;
                    frm.Evento = GetEnum.Eventos.search;
                    //frm.lstSocioBancoBESel = lstSocioBancoBE;
                    frm._entFinancieraID = oInversionBE.idEntidadFinanciera;
                    frm._valorMonedaID = Convert.ToString(oInversionBE.idMoneda);
                    //frm.listSocioBancos();
                    this.Invoke((MethodInvoker)delegate
                    {
                        result = frm.ShowDialog(this);
                        if (result == System.Windows.Forms.DialogResult.OK)
                            listSocioBancos(frm.lstSocioBancoBESel);

                    });
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar transferencias a seleccionar - Error: " + ex.Message);
            }
        }

        //private void dgvDepositos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        lstSocioBancoBE = new List<SocioBancoBE>();
        //        lstSocioBancoBE.AddRange((List<SocioBancoBE>)dgvDepositos2.DataSource);

        //        if (e.ColumnIndex == 7)
        //        {
        //            lstSocioBancoBE.Remove(lstSocioBancoBE.Find(x => x.socioBancoID == dgvDepositos2.Rows[e.RowIndex].Cells["socioBancoID"].Value.ToString()));
        //            dgvDepositos2.DataSource = lstSocioBancoBE;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ucMsgBox1.ShowMessageError("Error al eliminar tranferencia seleccionada - Error: " + ex.Message);
        //    }
        //}

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Util.Validation.ValidateRequired(groupDetalle, errorProvider1))
                {
                    Task.Factory.StartNew(() =>
                    {
                        Util.Util.SetLoading(this, ucLoadingBar1, true);
                        if (valSaveConfirmacion())
                        {
                            saveConfirmacion();
                            Util.Util.SetLoading(this, ucLoadingBar1, false);
                            this.Invoke((MethodInvoker)delegate
                            {
                                this.Close();
                            });
                        }
                        Util.Util.SetLoading(this, ucLoadingBar1, false);
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

        private void dgvDepositos2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string socioBancoID = "";
                List<SocioBancoBE> lstSocioBancoBEGrid = new List<SocioBancoBE>();

                lstSocioBancoBEGrid.AddRange(lstSocioBancoBE);

                if (lstSocioBancoBE == null)
                    lstSocioBancoBE = new List<SocioBancoBE>();
                //else
                //    lstSocioBancoBE = ((List<SocioBancoBE>)dgvDepositos2.DataSource);

                if (dgvDepositos2.Rows.Count > 0)
                    socioBancoID = dgvDepositos2.Rows[e.RowIndex].Cells["socioBancoID"].Value.ToString();
                else
                    socioBancoID = "";

                if (e.ColumnIndex == 21)
                {
                    //lstSocioBancoBE.RemoveAt(e.RowIndex);
                    lstSocioBancoBEGrid.Remove(lstSocioBancoBE.Find(x => x.socioBancoID == socioBancoID));
                    //dgvDepositos2.DataSource = lstSocioBancoBE;
                    dgvDepositos2.DataSource = lstSocioBancoBEGrid;
                    lstSocioBancoBE = lstSocioBancoBEGrid;
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al eliminar tranferencia seleccionada - Error: " + ex.Message);
            }
        }
    }
}