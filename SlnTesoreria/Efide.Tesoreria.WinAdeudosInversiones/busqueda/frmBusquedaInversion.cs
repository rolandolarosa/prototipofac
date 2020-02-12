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
using Efide.Tesoreria.WinAdeudosInversiones.inversion;
using System.Linq;
using Efide.Tesoreria.BusinessLogic.inversion;
using Efide.Tesoreria.BusinessEntity.inversion;

namespace Efide.Tesoreria.WinAdeudosInversiones.busqueda
{
    public partial class frmBusquedaInversion : frmBase.frmBusquedaBase
    {
        public frmBusquedaInversion()
        {
            InitializeComponent();
        }

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

        #region " PROPERTIES "
        public string frmParentName { get; set; }
        public string idInversion { get; set; }
        public string Estado { get; set; }
        #endregion

        #region "FUNCTIONS"
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

                if ((lstInversionBE.Count > 0) && (Convert.ToString(cboEstado.SelectedValue) == Util.EstadoInversion.Vigente))
                {
                    lblImporteSoles.Text = lstInversionBE.Where(y => y.idMoneda == 1).Sum(x => x.importe).ToString("N");
                    lblImporteDolares.Text = lstInversionBE.Where(y => y.idMoneda == 2).Sum(x => x.importe).ToString("N");
                    lblRescisionSoles.Text = lstInversionBE.Where(y => y.idMoneda == 1).Sum(x => x.rescisionHoy).ToString("N");
                    lblRescisionDolares.Text = lstInversionBE.Where(y => y.idMoneda == 2).Sum(x => x.rescisionHoy).ToString("N");
                    lblAlVtoSoles.Text = lstInversionBE.Where(y => y.idMoneda == 1).Sum(x => x.alVto).ToString("N");
                    lblAlVtoDolares.Text = lstInversionBE.Where(y => y.idMoneda == 2).Sum(x => x.alVto).ToString("N");
                }
                else
                {
                    lblImporteSoles.Text = "0";
                    lblImporteDolares.Text = "0";
                    lblRescisionSoles.Text = "0";
                    lblRescisionDolares.Text = "0";
                    lblAlVtoSoles.Text = "0";
                    lblAlVtoDolares.Text = "0";
                }
                dgvInversion.DataSource = lstInversionBE;
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
                cboEstado.DataSource = listTableBaseBE.Where(x => x.Table_Id != Util.EstadoInversion.Aplicada && x.Table_Id != Util.EstadoInversion.Aprobado).ToList();
                cboEstado.SelectedValue = (Estado != null? Estado: EstadoInversion.Vigente);
                if (frmParentName == "frmConfirmacionInversion" || frmParentName == "frmRescisionInversion")
                {
                    cboEstado.Enabled = false;
                }
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
            listEntidadesFinancierasBE.Insert(0, new EntidadesFinancierasBE() { entFinancieraID = "", emprRazonSocial = "-TODOS-" } );

            this.Invoke((MethodInvoker)delegate
            {
                cboBanco.ValueMember = "entFinancieraID";
                cboBanco.DisplayMember = "emprRazonSocial";
                cboBanco.DataSource = listEntidadesFinancierasBE;
                cboBanco.SelectedIndex = 0;
            });
        }
        private void openDetailInversion()
        {
            //Form frm;
            if (dgvInversion.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvInversion.SelectedRows[0];
                idInversion = row.Cells[0].Value.ToString();

                if (frmParentName == "frmRescisionInversion")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else if (frmParentName == "frmConfirmacionInversion")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else if (frmParentName == "frmConfirmacionRescision")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else if (frmParentName == "frmConfirmacionRenovacion")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else if (frmParentName == "frmRenovacionInversion")
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
                }
            }
            else
                ucMsgBox1.ShowMessageWarnnig("Debe seleccionar una inversión de la lista");
        }
        #endregion

        private void frmBusquedaInversion_Load(object sender, EventArgs e)
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
                    listEstadoInversion();
                    listEntidadFinanciera(tipoEntidadFinanciera);
                    listMoneda();
                    listInversion();
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
                    listInversion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar la inversiones - Error: " + ex.Message);
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
                ucMsgBox1.ShowMessageError("Error al salir de la búsqueda - Error: " + ex.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                openDetailInversion();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al seleccionar inversión - Error: " + ex.Message);
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
                        listInversion();
                        Util.Util.SetLoading(this, ucLoadingBar1, false);
                    });
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar las inversiones - Error: " + ex.Message);
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
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listEntidadFinanciera(tipoEntidadFinanciera);
                    listInversion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar las entidades financieras - Error: " + ex.Message);
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
                ucMsgBox1.ShowMessageError("Error al buscar las inversiones - Error: " + ex.Message);
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
                ucMsgBox1.ShowMessageError("Error al buscar las inversiones - Error: " + ex.Message);
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
                ucMsgBox1.ShowMessageError("Error al buscar las inversiones - Error: " + ex.Message);
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
                ucMsgBox1.ShowMessageError("Error al buscar las inversiones - Error: " + ex.Message);
            }
        }

        private void dgvInversion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 17)
                {
                    openDetailInversion();
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al agregar observaciones - Error: " + ex.Message);
            }
        }

        private void dgvInversion_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                openDetailInversion();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al seleccionar inversión - Error: " + ex.Message);
            }
        }

        private void dgvInversion_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if(Convert.ToString(dgvInversion.Rows[e.RowIndex].Cells[15].Value) == "Vigente")
            {
                if (Convert.ToInt32(dgvInversion.Rows[e.RowIndex].Cells[10].Value) > 0)
                {
                    if (Convert.ToInt32(dgvInversion.Rows[e.RowIndex].Cells[14].Value) <= -5)
                        dgvInversion.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Crimson;
                    //else if (Convert.ToInt32(dgvInversion.Rows[e.RowIndex].Cells[14].Value) <= 5)
                    //    dgvInversion.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.YellowGreen;
                    else if (Convert.ToInt32(dgvInversion.Rows[e.RowIndex].Cells[13].Value) < Convert.ToInt32(dgvInversion.Rows[e.RowIndex].Cells[10].Value))
                        dgvInversion.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;
                }
            }
        }
    }
}