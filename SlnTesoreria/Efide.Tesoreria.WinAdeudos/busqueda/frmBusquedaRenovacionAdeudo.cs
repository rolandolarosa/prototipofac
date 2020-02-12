using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessLogic;
using Efide.Tesoreria.Util;
using System.Linq;
using System.Threading.Tasks;
using Efide.Tesoreria.BusinessLogic.adeudo;
using Efide.Tesoreria.BusinessEntity.adeudo;

namespace Efide.Tesoreria.WinAdeudos.busqueda
{
    public partial class frmBusquedaRenovacionAdeudo : frmBase.frmBusquedaBase
    {
        public frmBusquedaRenovacionAdeudo()
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
        //private RescisionBL _RescisionBL;
        //private RescisionBL oRescisionBL
        //{
        //    get { return (_RescisionBL == null ? _RescisionBL = new RescisionBL() : _RescisionBL); }
        //}
        private RenovacionBL _RenovacionBL;
        private RenovacionBL oRenovacionBL
        {
            get { return (_RenovacionBL == null ? _RenovacionBL = new RenovacionBL() : _RenovacionBL); }
        }
        enum TipoFecha
        {
            fechaInicio,
            fechaFin
        }
        #endregion

        #region "PROPERTIES"
        public string frmParentName { get; set; }
        public string idRenovacion { get; set; }
        #endregion

        #region "FUNCTIONS"
        private void listTipoREnovacion()
        {
            this.Invoke((MethodInvoker)delegate
            {
                List<cboValue> lstcboValue = new List<cboValue>();
                lstcboValue.Add(new cboValue() { id = 0, name = "-TODOS-" });
                lstcboValue.Add(new cboValue() { id = 1, name = "Capital" });
                lstcboValue.Add(new cboValue() { id = 2, name = "Capital + Interés" });

                cboTipoRenovacion.ValueMember = "id";
                cboTipoRenovacion.DisplayMember = "name";
                cboTipoRenovacion.DataSource = lstcboValue;
                cboTipoRenovacion.SelectedValue = 0;
            });
        }
        private void listEstadoAdeudo()
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
                    x.Table_Id == Util.EstadoInversion.Registrado
                    || x.Table_Id == Util.EstadoInversion.Aplicada
                    || x.Table_Id == ""
                ).ToList();
                cboEstado.SelectedValue = EstadoInversion.Registrado;
                if (frmParentName == "frmConfirmacionRenovacionAdeudo" || frmParentName == "frmRenovacionAdeudo")
                {
                    cboEstado.Enabled = false;
                }
            });
        }
        public void listRenovacion()
        {
            List<RenovacionBE> lstRenovacionBE = new List<RenovacionBE>();
            RenovacionBE oRenovacionBE = null;
            this.Invoke((MethodInvoker)delegate
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                    txtCodigo.Text = txtCodigo.Text.PadLeft(10, '0');

                oRenovacionBE = new RenovacionBE()
                {
                    idRenovacion = txtCodigo.Text,
                    oAdeudoBE = new AdeudoBE()
                    {
                        idTipoAdeudo = cboTipoInversion.SelectedValue.ToString(),
                        idTipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue),
                        idEntidadFinanciera = Convert.ToString(cboBanco.SelectedValue),
                        idMoneda = Convert.ToInt32(cboMoneda.SelectedValue)
                    },
                    idEstado = Convert.ToString(cboEstado.SelectedValue),
                    idTipoRenovacion = Convert.ToInt32(cboTipoRenovacion.SelectedValue)
                };

                if (chkFiltroFecha.Checked)
                {
                    if (cboTipoFecha.SelectedIndex == Convert.ToInt32(TipoFecha.fechaInicio))
                    {
                        if (!string.IsNullOrEmpty(dtpInicio.Text))
                            oRenovacionBE.iniciofechaInicio = Convert.ToDateTime(dtpInicio.Text);
                        if (!string.IsNullOrEmpty(dtpFin.Text))
                            oRenovacionBE.finfechaInicio = Convert.ToDateTime(dtpFin.Text);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(dtpInicio.Text))
                            oRenovacionBE.iniciofechaVencimiento = Convert.ToDateTime(dtpInicio.Text);
                        if (!string.IsNullOrEmpty(dtpFin.Text))
                            oRenovacionBE.finfechaVencimiento = Convert.ToDateTime(dtpFin.Text);
                    }
                }
            });

            lstRenovacionBE = oRenovacionBL.listRenovacion(oRenovacionBE);

            this.Invoke((MethodInvoker)delegate
            {
                dgvRenovacion.DataSource = lstRenovacionBE;
            });
        }
        private void listInstrumentoAdeudo()
        {
            TableBaseBE oTableBaseBE = new TableBaseBE();
            List<TableBaseBE> listTableBaseBE = new List<TableBaseBE>();
            oTableBaseBE.Table_Parent_Id = GetTablasGenerales.tipoAdeudos;
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
        private void openDetailRenovacion()
        {
            if (dgvRenovacion.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvRenovacion.SelectedRows[0];
                idRenovacion = row.Cells[0].Value.ToString();

                if (frmParentName == "frmRenovacionAdeudo")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else if (frmParentName == "frmConfirmacionRenovacionAdeudo")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult result;
                    adeudo.frmRenovacionAdeudo frm = new adeudo.frmRenovacionAdeudo();
                    frm.frmParentName = this.Name;
                    frm.mode = frmBase.frmConfirmacionBase.Mode.modal;
                    frm.idRenovacion = idRenovacion;
                    frm.Evento = GetEnum.Eventos.view;
                    result = frm.ShowDialog(this);
                    if (result == System.Windows.Forms.DialogResult.OK)
                        listRenovacion();
                }
            }
            else
                ucMsgBox1.ShowMessageWarnnig("Debe seleccionar una renovación de la lista");
        }
        #endregion

        private void frmBusquedaRenovacion_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoFecha.SelectedIndex = 0;
                cboTipoFecha.Enabled = false;
                dtpInicio.Enabled = false;
                dtpFin.Enabled = false;
                dgvRenovacion.AutoGenerateColumns = false;
                int tipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);

                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listInstrumentoAdeudo();
                    listTipoEntidadFinanciera();
                    listEntidadFinanciera(tipoEntidadFinanciera);
                    listMoneda();
                    listTipoREnovacion();
                    listEstadoAdeudo();
                    listRenovacion();
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
                    listRenovacion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar renovaciones - Error: " + ex.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                openDetailRenovacion();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al seleccionar renovación - Error: " + ex.Message);
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
                        listRenovacion();
                        Util.Util.SetLoading(this, ucLoadingBar1, false);
                    });
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar renovaciones - Error: " + ex.Message);
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
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar las entidades financieras - Error: " + ex.Message);
            }
        }

        private void dgvRenovacion_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                openDetailRenovacion();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al seleccionar renovación - Error: " + ex.Message);
            }
        }

        private void cboBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listRenovacion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar renovaciones - Error: " + ex.Message);
            }
        }

        private void cboTipoInversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listRenovacion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar renovaciones - Error: " + ex.Message);
            }
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listRenovacion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar renovaciones - Error: " + ex.Message);
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listRenovacion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar renovaciones - Error: " + ex.Message);
            }
        }

        private void cboTipoRenovacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listRenovacion();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar renovaciones - Error: " + ex.Message);
            }
        }
    }

    partial class cboValue
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}