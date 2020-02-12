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
using Efide.Tesoreria.BusinessLogic;
using Efide.Tesoreria.Util;
using System.Linq;
using Efide.Tesoreria.BusinessLogic.inversion;
using Efide.Tesoreria.BusinessEntity.inversion;

namespace Efide.Tesoreria.WinAdeudosInversiones.lista
{
    public partial class frmListaRescision : frmBase.frmListaBase
    {
        #region "ENTITY"
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
        private RescisionBL _RescisionBL;
        private RescisionBL oRescisionBL
        {
            get { return (_RescisionBL == null ? _RescisionBL = new RescisionBL() : _RescisionBL); }
        }
        private InversionBL _InversionBL;
        private InversionBL oInversionBL
        {
            get { return (_InversionBL == null ? _InversionBL = new InversionBL() : _InversionBL); }
        }
        enum TipoFecha
        {
            fechaInicio,
            fechaFin
        }
        #endregion

        #region "PROPERTIES"
        public string frmParentName { get; set; }
        public string idRescision { get; set; }
        #endregion

        #region " FUNCTION "
        private void listEstadoInversion()
        {
            TableBaseBE oTableBaseBE = new TableBaseBE();
            List<TableBaseBE> listTableBaseBE = new List<TableBaseBE>();
            oTableBaseBE.Table_Parent_Id = GetTablasGenerales.estadosInversion;
            oTableBaseBE.OPCION = 1;

            listTableBaseBE = oTableBaseBL.ProcesarTableBase(oTableBaseBE);
            listTableBaseBE.Insert(0, new TableBaseBE() { Table_Id = "", Table_Name = "-TODOS-" });

            this.Invoke((MethodInvoker)delegate
            {
                cboEstado.ValueMember = "Table_Id";
                cboEstado.DisplayMember = "Table_Name";
                cboEstado.DataSource = listTableBaseBE.Where(x =>
                    x.Table_Id != Util.EstadoInversion.Vigente
                    && x.Table_Id != Util.EstadoInversion.Rescidido
                    && x.Table_Id != Util.EstadoInversion.Renovado
                    && x.Table_Id != Util.EstadoInversion.Cancelado
                ).ToList();
                //cboEstado.SelectedValue = EstadoInversion.Aplicada;
                cboEstado.SelectedIndex = 0;
                if (frmParentName == "frmConfirmacionInversion" || frmParentName == "frmRescisionInversion")
                {
                    cboEstado.Enabled = false;
                }
            });
        }
        public void listRescision()
        {
            List<RescisionBE> lstRescisionBE = new List<RescisionBE>();
            RescisionBE oRescisionBE = null;
            this.Invoke((MethodInvoker)delegate
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                    txtCodigo.Text = txtCodigo.Text.PadLeft(10, '0');

                oRescisionBE = new RescisionBE()
                {
                    idRescision = txtCodigo.Text,
                    oInversionBE = new InversionBE()
                    {
                        idTipoInversion = cboTipoInversion.SelectedValue.ToString(),
                        idTipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue),
                        idEntidadFinanciera = Convert.ToString(cboBanco.SelectedValue),
                        idMoneda = Convert.ToInt32(cboMoneda.SelectedValue)
                    },
                    idEstado = Convert.ToString(cboEstado.SelectedValue)
                };

                if (chkFiltroFecha.Checked)
                {
                    if (cboTipoFecha.SelectedIndex == Convert.ToInt32(TipoFecha.fechaInicio))
                    {
                        if (!string.IsNullOrEmpty(dtpInicio.Text))
                            oRescisionBE.iniciofechaInicio = Convert.ToDateTime(dtpInicio.Text);
                        if (!string.IsNullOrEmpty(dtpFin.Text))
                            oRescisionBE.finfechaInicio = Convert.ToDateTime(dtpFin.Text);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(dtpInicio.Text))
                            oRescisionBE.iniciofechaVencimiento = Convert.ToDateTime(dtpInicio.Text);
                        if (!string.IsNullOrEmpty(dtpFin.Text))
                            oRescisionBE.finfechaVencimiento = Convert.ToDateTime(dtpFin.Text);
                    }
                }
            });

            lstRescisionBE = oRescisionBL.listRescision(oRescisionBE);

            this.Invoke((MethodInvoker)delegate
            {
                dgvRescision.DataSource = lstRescisionBE;
            });
        }
        private void listInstrumentoInversion()
        {
            TableBaseBE oTableBaseBE = new TableBaseBE();
            List<TableBaseBE> listTableBaseBE = new List<TableBaseBE>();
            oTableBaseBE.Table_Parent_Id = GetTablasGenerales.instrumentoInversion;
            oTableBaseBE.OPCION = 1;

            listTableBaseBE = oTableBaseBL.ProcesarTableBase(oTableBaseBE);
            listTableBaseBE.Insert(0, new TableBaseBE() { Table_Id = "", Table_Name = "-TODOS-" });
            this.Invoke((MethodInvoker)delegate
            {
                cboTipoInversion.ValueMember = "Table_Id";
                cboTipoInversion.DisplayMember = "Table_Name";
                cboTipoInversion.DataSource = listTableBaseBE;
                cboTipoInversion.SelectedIndex = 0;
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
        private void listMoneda()
        {
            ValoresGeneralesBE oValoresGeneralesBE = new ValoresGeneralesBE();
            List<ValoresGeneralesBE> listValoresGeneralesBE = new List<ValoresGeneralesBE>();
            oValoresGeneralesBE.valorID = Convert.ToInt32(GetTablasGenerales.moneda);
            oValoresGeneralesBE.varEstado = true;

            listValoresGeneralesBE = oValoresGeneralesBL.listValoresGenerales(oValoresGeneralesBE);
            listValoresGeneralesBE.Insert(0, new ValoresGeneralesBE() { varCodigo = 0, varDescripcion = "-TODOS-" });
            this.Invoke((MethodInvoker)delegate
            {
                cboMoneda.ValueMember = "varCodigo";
                cboMoneda.DisplayMember = "varDescripcion";
                cboMoneda.DataSource = listValoresGeneralesBE;
                cboMoneda.SelectedIndex = 0;
            });
        }
        private void listEntidadFinanciera(int valorTipoEntFinancID)
        {
            EntidadesFinancierasBE oEntidadesFinancierasBE = new EntidadesFinancierasBE();
            List<EntidadesFinancierasBE> listEntidadesFinancierasBE = new List<EntidadesFinancierasBE>();
            oEntidadesFinancierasBE.valorTipoEntFinancID = valorTipoEntFinancID;
            oEntidadesFinancierasBE.entFinEstado = true;

            listEntidadesFinancierasBE = oEntidadesFinancierasBL.obtenerEntidadesFinancieras(oEntidadesFinancierasBE);
            listEntidadesFinancierasBE.Insert(0, new EntidadesFinancierasBE() { entFinancieraID = "", emprRazonSocial = "-TODOS-" });
            this.Invoke((MethodInvoker)delegate
            {
                cboBanco.ValueMember = "entFinancieraID";
                cboBanco.DisplayMember = "emprRazonSocial";
                cboBanco.DataSource = listEntidadesFinancierasBE;
                cboBanco.SelectedIndex = 0;
            });
        }
        private void clear()
        {
            txtCodigo.Text = string.Empty;
            cboTipoInversion.SelectedIndex = 0;
            cboTipoEntidadFinanciera.SelectedIndex = 0;
            cboBanco.SelectedIndex = 0;
            cboMoneda.SelectedIndex = 0;
            cboTipoFecha.SelectedIndex = 0;
            dtpInicio.Text = string.Empty;
            dtpFin.Text = string.Empty;
            dgvRescision.DataSource = null;
        }
        private void openDetailRescision()
        {
            if (dgvRescision.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvRescision.SelectedRows[0];
                idRescision = row.Cells[0].Value.ToString();

                if (frmParentName == "frmRescisionInversion")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult result;
                    inversion.frmRescisionInversion frm = new inversion.frmRescisionInversion();
                    frm.frmParentName = this.Name;
                    frm.mode = frmBase.frmConfirmacionBase.Mode.modal;
                    frm.idRescision = idRescision;
                    frm.Evento = GetEnum.Eventos.view;
                    result = frm.ShowDialog(this);
                    if (result == System.Windows.Forms.DialogResult.OK)
                        listRescision();
                }
            }
            else
                ucMsgBox1.ShowMessageWarnnig("Debe seleccionar una inversión de la lista");
        }
        private void anularRescision(string pIdRescision)
        {
            RescisionBE oRescisionBE = new RescisionBE();
            oRescisionBE = oRescisionBL.getRescision(pIdRescision);

            oRescisionBE.usuUltActualizacion = General.GetCodigoUsuario;
            oRescisionBE.fechaUltActualizacion = Util.General.GetFechaGlobal;
            oRescisionBE.idEstado = Util.EstadoInversion.Anulado;
            oRescisionBL.updateRescision(oRescisionBE);
        }
        private void extornarRescision(string pIdRescision)
        {
            RescisionBE oRescisionBE = new RescisionBE();
            InversionBE oInversionBE = new InversionBE();

            oRescisionBE = oRescisionBL.getRescision(pIdRescision);
            oRescisionBE.usuUltActualizacion = General.GetCodigoUsuario;
            oRescisionBE.fechaUltActualizacion = Util.General.GetFechaGlobal;
            oRescisionBE.idEstado = Util.EstadoInversion.Registrado;
            oRescisionBL.updateRescision(oRescisionBE);

            oInversionBE = oInversionBL.getInversion(oRescisionBE.idInversion, Util.General.GetFechaGlobal);
            oInversionBE.usuUltActualizacion = General.GetCodigoUsuario;
            oInversionBE.fechaUltActualizacion = Util.General.GetFechaGlobal;
            oInversionBE.idEstado = Util.EstadoInversion.Registrado;
            oInversionBL.updateInversion(oInversionBE);
        }
        #endregion
        
        public frmListaRescision()
        {
            InitializeComponent();
        }

        private void frmListaRescision_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoFecha.SelectedIndex = 0;
                cboTipoFecha.Enabled = false;
                dtpInicio.Enabled = false;
                dtpFin.Enabled = false;
                dgvRescision.AutoGenerateColumns = false;
                int tipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);

                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listInstrumentoInversion();
                    listTipoEntidadFinanciera();
                    listEntidadFinanciera(tipoEntidadFinanciera);
                    listMoneda();
                    listEstadoInversion();
                    listRescision();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
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
                    listRescision();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar rescisiones - Error: " + ex.Message);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                this.Invoke((MethodInvoker)delegate
                {
                    if (Convert.ToString(dgvRescision.SelectedRows[0].Cells[13].Value) == Util.EstadoInversion.Registrado)
                    {
                        inversion.frmRescisionInversion frm = new inversion.frmRescisionInversion();
                        frm.frmParentName = this.Name;
                        frm.idRescision = Convert.ToString(dgvRescision.SelectedRows[0].Cells[0].Value);
                        frm.idInversion = Convert.ToString(dgvRescision.SelectedRows[0].Cells[1].Value);
                        frm.Evento = GetEnum.Eventos.edit;
                        frm.mode = frmBase.frmConfirmacionBase.Mode.modal;
                        result = frm.ShowDialog(this);
                        frm.Close();
                        frm.Dispose();
                    }
                    else
                        ucMsgBox1.ShowMessageWarnnig("Solo se puede editar rescisiones en estado Registrado");
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar el detalle de la inversión - Error: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                this.Invoke((MethodInvoker)delegate
                {
                    inversion.frmRescisionInversion frm = new inversion.frmRescisionInversion();
                    frm.frmParentName = this.Name;
                    //frm.idInversion = idInversion;
                    frm.Evento = GetEnum.Eventos.insert;
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    Task.Factory.StartNew(() =>
                    {
                        Util.Util.SetLoading(this, ucLoadingBar1, true);
                        listRescision();
                        Util.Util.SetLoading(this, ucLoadingBar1, false);
                    });
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar rescisiones - Error: " + ex.Message);
            }
        }

        private void chkFiltroFecha_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cboTipoFecha.Enabled = ((DevComponents.DotNetBar.Controls.CheckBoxX)(sender)).Checked;
                dtpInicio.Enabled = ((DevComponents.DotNetBar.Controls.CheckBoxX)(sender)).Checked;
                dtpFin.Enabled = ((DevComponents.DotNetBar.Controls.CheckBoxX)(sender)).Checked;

                if (((DevComponents.DotNetBar.Controls.CheckBoxX)(sender)).Checked)
                {
                    dtpInicio.Text = string.Empty;
                    dtpFin.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al activar la búsqueda por fecha - Error: " + ex.Message);
            }
        }

        private void cboTipoEntidadFinanciera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);
                Task.Factory.StartNew(() =>
                {
                    listEntidadFinanciera(tipoEntidadFinanciera);
                    listRescision();
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar las entidades financieras - Error: " + ex.Message);
            }
        }

        private void dgvRescision_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                openDetailRescision();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al seleccionar rescisión - Error: " + ex.Message);
            }
        }

        private void dgvRescision_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                eTaskDialogResult result;
                if (e.ColumnIndex == 14)
                {
                    result = ucMsgBox1.ShowMessageConfirmation("¿Está seguro que desea anular la rescisión?");
                    if (result == eTaskDialogResult.Yes)
                    {
                        if (Convert.ToString(dgvRescision.SelectedRows[0].Cells[13].Value) == Util.EstadoInversion.Registrado)
                        {
                            string rescisionID = Convert.ToString(dgvRescision.SelectedRows[0].Cells[0].Value);
                            anularRescision(rescisionID);
                            listRescision();
                            ucMsgBox1.ShowMessageSuccess("Se anuló satisfactoriamente la rescisión");
                        }
                        else
                            ucMsgBox1.ShowMessageWarnnig("Solo se pueden anular rescisiones en estado Registrado");
                    }
                }
                else if (e.ColumnIndex == 15)
                {
                    result = ucMsgBox1.ShowMessageConfirmation("¿Está seguro que desea extornar la rescisión?");
                    if (result == eTaskDialogResult.Yes)
                    {
                        if (Convert.ToString(dgvRescision.SelectedRows[0].Cells[13].Value) == Util.EstadoInversion.Aplicada)
                        {
                            string idRescision = Convert.ToString(dgvRescision.SelectedRows[0].Cells[0].Value);
                            if (oRescisionBL.getRescision(idRescision).fechaRescision.ToShortDateString() == Util.General.GetFechaGlobal.ToShortDateString())
                            {
                                string rescisionID = Convert.ToString(dgvRescision.SelectedRows[0].Cells[0].Value);
                                extornarRescision(rescisionID);
                                listRescision();
                                ucMsgBox1.ShowMessageSuccess("Se extornó satisfactoriamente la Rescisión");
                            }
                            else
                                ucMsgBox1.ShowMessageWarnnig("Solo se puede extornar el mismo día de la creación de la rescisión");
                        }
                        else
                            ucMsgBox1.ShowMessageWarnnig("Solo se pueden extornar rescisiones en estado aplicada");
                    }
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al anular la rescisión - Error: " + ex.Message);
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listRescision();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar rescisiones - Error: " + ex.Message);
            }
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listRescision();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar rescisiones - Error: " + ex.Message);
            }
        }

        private void cboBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listRescision();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar rescisiones - Error: " + ex.Message);
            }
        }

        private void cboTipoInversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listRescision();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar rescisiones - Error: " + ex.Message);
            }
        }
    }
}