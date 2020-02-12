using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
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
    public partial class frmListaInversion : frmBase.frmListaBase
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
        public string idInversion { get; set; }
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
                    x.Table_Id != Util.EstadoInversion.Aplicada 
                ).ToList();
                //cboEstado.SelectedValue = EstadoInversion.Vigente;
                cboEstado.SelectedIndex = 0;
                if (frmParentName == "frmConfirmacionInversion" || frmParentName == "frmRescisionInversion")
                {
                    cboEstado.Enabled = false;
                }
            });
        }
        public void listInversion()
        {
            List<InversionBE> lstInversionBE = new List<InversionBE>();
            InversionBE oInversionBE = null;
            this.Invoke((MethodInvoker)delegate
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                    txtCodigo.Text = txtCodigo.Text.PadLeft(10, '0');

                oInversionBE = new InversionBE()
                {
                    idInversion = txtCodigo.Text,
                    idTipoInversion = cboTipoInversion.SelectedValue.ToString(),
                    idTipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue),
                    idEntidadFinanciera = Convert.ToString(cboBanco.SelectedValue),
                    idMoneda = Convert.ToInt32(cboMoneda.SelectedValue),
                    idEstado = Convert.ToString(cboEstado.SelectedValue),
                    fechaGlobal = Util.General.GetFechaGlobal
                };

                if (chkFiltroFecha.Checked)
                {
                    if (cboTipoFecha.SelectedIndex == Convert.ToInt32(TipoFecha.fechaInicio))
                    {
                        if (!string.IsNullOrEmpty(dtpInicio.Text))
                            oInversionBE.iniciofechaInicio = Convert.ToDateTime(dtpInicio.Text);
                        if (!string.IsNullOrEmpty(dtpFin.Text))
                            oInversionBE.finfechaInicio = Convert.ToDateTime(dtpFin.Text);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(dtpInicio.Text))
                            oInversionBE.iniciofechaVencimiento = Convert.ToDateTime(dtpInicio.Text);
                        if (!string.IsNullOrEmpty(dtpFin.Text))
                            oInversionBE.finfechaVencimiento = Convert.ToDateTime(dtpFin.Text);
                    }
                }

                lstInversionBE = oInversionBL.listInversion(oInversionBE);

                this.Invoke((MethodInvoker)delegate
                {
                    dgvInversion.DataSource = lstInversionBE;
                });
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
            oValoresGeneralesBE.varEstado  = true;

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
            dgvInversion.DataSource = null;
        }
        private void openDetailInversion()
        {
            if (dgvInversion.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvInversion.SelectedRows[0];
                idInversion = row.Cells[0].Value.ToString();

                if (frmParentName == "frmInversion")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult result;
                    inversion.frmInversion frm = new inversion.frmInversion();
                    frm.frmParentName = this.Name;
                    frm.mode = frmBase.frmRegistroBase.Mode.modal;
                    frm.idInversion = idInversion;
                    frm.Evento = GetEnum.Eventos.view;
                    result = frm.ShowDialog(this);
                    if (result == System.Windows.Forms.DialogResult.OK)
                        listInversion();
                }
            }
            else
                ucMsgBox1.ShowMessageWarnnig("Debe seleccionar una inversión de la lista");
        }
        private void anularInversion(string pIdInversion)
        {
            InversionBE oInversionBE = new InversionBE();
            oInversionBE = oInversionBL.getInversion(pIdInversion, Util.General.GetFechaGlobal);

            oInversionBE.usuUltActualizacion = General.GetCodigoUsuario;
            oInversionBE.fechaUltActualizacion = Util.General.GetFechaGlobal;
            oInversionBE.idEstado = Util.EstadoInversion.Anulado;

            oInversionBL.updateInversion(oInversionBE);
        }
        private void extornarInversion(string pIdInversion)
        {
            InversionBE oInversionBE = new InversionBE();
            oInversionBE = oInversionBL.getInversion(pIdInversion, Util.General.GetFechaGlobal);

            oInversionBE.usuUltActualizacion = General.GetCodigoUsuario;
            oInversionBE.fechaUltActualizacion = Util.General.GetFechaGlobal;
            oInversionBE.idEstado = Util.EstadoInversion.Registrado;

            oInversionBL.updateInversion(oInversionBE);
        }
        #endregion

        public frmListaInversion()
        {
            InitializeComponent();
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

        private void frmListaInversion_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoFecha.SelectedIndex = 0;
                cboTipoFecha.Enabled = false;
                dtpInicio.Enabled = false;
                dtpFin.Enabled = false;
                dgvInversion.AutoGenerateColumns = false;
                int tipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);

                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listInstrumentoInversion();
                    listTipoEntidadFinanciera();
                    listEntidadFinanciera(tipoEntidadFinanciera);
                    listMoneda();
                    listEstadoInversion();
                    listInversion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar la información - Error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                this.Invoke((MethodInvoker)delegate
                {
                    if (Convert.ToString(dgvInversion.SelectedRows[0].Cells[10].Value) == Util.EstadoInversion.Registrado)
                    {
                        inversion.frmInversion frm = new inversion.frmInversion();
                        frm.frmParentName = this.Name;
                        //frm.idRescision = Convert.ToString(dgvInversion.SelectedRows[0].Cells[0].Value);
                        frm.idInversion = Convert.ToString(dgvInversion.SelectedRows[0].Cells[0].Value);
                        frm.Evento = GetEnum.Eventos.edit;
                        frm.mode = frmBase.frmRegistroBase.Mode.modal;
                        result = frm.ShowDialog(this);
                        listInversion();
                        frm.Close();
                        frm.Dispose();
                    }
                    else
                        ucMsgBox1.ShowMessageWarnnig("Solo se puede editar inversiones en estado Registrado");
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
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listInversion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar inversiones - Error: " + ex.Message);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        listInversion();
                        Util.Util.SetLoading(this, ucLoadingBar1, false);
                    });
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar inversiones - Error: " + ex.Message);
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
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar las entidades financieras - Error: " + ex.Message);
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

        private void dgvInversion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 11)
                    openDetailInversion();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al seleccionar inversión - Error: " + ex.Message);
            }
        }

        private void dgvInversion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                eTaskDialogResult result;
                if (e.ColumnIndex == 11)
                {
                    result = ucMsgBox1.ShowMessageConfirmation("¿Está seguro que desea anular la inversión?");
                    if (result == eTaskDialogResult.Yes)
                    {
                        if (Convert.ToString(dgvInversion.SelectedRows[0].Cells[10].Value) == Util.EstadoInversion.Registrado)
                        {
                            string inversionID = Convert.ToString(dgvInversion.SelectedRows[0].Cells[0].Value);
                            anularInversion(inversionID);
                            listInversion();
                            ucMsgBox1.ShowMessageSuccess("Se anuló satisfactoriamente la Inversión");
                        }
                        else
                            ucMsgBox1.ShowMessageWarnnig("Solo se pueden anular inversiones en estado Registrado");
                    }
                }
                else if (e.ColumnIndex == 12)
                {
                    result = ucMsgBox1.ShowMessageConfirmation("¿Está seguro que desea extornar la inversión?");
                    if (result == eTaskDialogResult.Yes)
                    {
                        if (Convert.ToString(dgvInversion.SelectedRows[0].Cells[10].Value) == Util.EstadoInversion.Vigente)
                        {
                            if (oInversionBL.getInversion(idInversion, Util.General.GetFechaGlobal).fechaCreacion.ToShortDateString() == Util.General.GetFechaGlobal.ToShortDateString())
                            {
                                string inversionID = Convert.ToString(dgvInversion.SelectedRows[0].Cells[0].Value);
                                extornarInversion(inversionID);
                                listInversion();
                                ucMsgBox1.ShowMessageSuccess("Se extornó satisfactoriamente la Inversión");
                            }
                            else
                                ucMsgBox1.ShowMessageWarnnig("Solo se puede extornar el mismo día de la creación de la inversión");
                        }
                        else
                            ucMsgBox1.ShowMessageWarnnig("Solo se pueden extornar inversiones en estado vigente");
                    }
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al anular la inversión - Error: " + ex.Message);
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listInversion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar inversiones - Error: " + ex.Message);
            }
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listInversion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar inversiones - Error: " + ex.Message);
            }
        }

        private void cboBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listInversion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar inversiones - Error: " + ex.Message);
            }
        }

        private void cboTipoInversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listInversion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar inversiones - Error: " + ex.Message);
            }
        }
    }
}