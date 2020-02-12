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
using Efide.Tesoreria.BusinessLogic.adeudo;
using Efide.Tesoreria.BusinessEntity.adeudo;

namespace Efide.Tesoreria.WinAdeudos.busqueda
{
    public partial class frmBusquedaAdeudo : frmBase.frmBusquedaBase
    {
        public frmBusquedaAdeudo()
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
        private AdeudoBL _AdeudoBL;
        private AdeudoBL oAdeudoBL
        {
            get { return (_AdeudoBL == null ? _AdeudoBL = new AdeudoBL() : _AdeudoBL); }
        }
        enum TipoFecha
        {
            fechaInicio,
            fechaFin
        }
        #endregion

        #region " PROPERTIES "
        public string frmParentName { get; set; }
        public string idAdeudo { get; set; }
        public string Estado { get; set; }
        #endregion

        #region "FUNCTIONS"
        public void listAdeudo()
        {
            List<AdeudoBE> lstAdeudoBE = new List<AdeudoBE>();
            AdeudoBE oAdeudoBE = null;
            this.Invoke((MethodInvoker)delegate
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                    txtCodigo.Text = txtCodigo.Text.PadLeft(10, '0');

                oAdeudoBE = new AdeudoBE()
                {
                    idAdeudo = txtCodigo.Text,
                    idTipoAdeudo = cboTipoAdeudo.SelectedValue.ToString(),
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
                            oAdeudoBE.iniciofechaInicio = Convert.ToDateTime(dtpInicio.Text);
                        if (!string.IsNullOrEmpty(dtpFin.Text))
                            oAdeudoBE.finfechaInicio = Convert.ToDateTime(dtpFin.Text);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(dtpInicio.Text))
                            oAdeudoBE.iniciofechaVencimiento = Convert.ToDateTime(dtpInicio.Text);
                        if (!string.IsNullOrEmpty(dtpFin.Text))
                            oAdeudoBE.finfechaVencimiento = Convert.ToDateTime(dtpFin.Text);
                    }
                }

                lstAdeudoBE = oAdeudoBL.listAdeudo(oAdeudoBE);

                if ((lstAdeudoBE.Count > 0) && (Convert.ToString(cboEstado.SelectedValue) == Util.EstadoInversion.Vigente))
                {
                    lblImporteSoles.Text = lstAdeudoBE.Where(y => y.idMoneda == 1).Sum(x => x.importe).ToString("N");
                    lblImporteDolares.Text = lstAdeudoBE.Where(y => y.idMoneda == 2).Sum(x => x.importe).ToString("N");
                    lblRescisionSoles.Text = lstAdeudoBE.Where(y => y.idMoneda == 1).Sum(x => x.rescisionHoy).ToString("N");
                    lblRescisionDolares.Text = lstAdeudoBE.Where(y => y.idMoneda == 2).Sum(x => x.rescisionHoy).ToString("N");
                    lblAlVtoSoles.Text = lstAdeudoBE.Where(y => y.idMoneda == 1).Sum(x => x.alVto).ToString("N");
                    lblAlVtoDolares.Text = lstAdeudoBE.Where(y => y.idMoneda == 2).Sum(x => x.alVto).ToString("N");
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
                dgvAdeudo.DataSource = lstAdeudoBE;
            });
        }
        private void listInstrumento()
        {
            TableBaseBE oTableBaseBE = new TableBaseBE();
            List<TableBaseBE> listTableBaseBE = new List<TableBaseBE>();
            oTableBaseBE.Table_Parent_Id = GetTablasGenerales.tipoAdeudos;
            oTableBaseBE.OPCION = 1;

            listTableBaseBE = oTableBaseBL.ProcesarTableBase(oTableBaseBE);
            listTableBaseBE.Insert(0, new TableBaseBE() { Table_Id = "", Table_Name = "-TODOS-" });

            this.Invoke((MethodInvoker)delegate
            {
                cboTipoAdeudo.ValueMember = "Table_Id";
                cboTipoAdeudo.DisplayMember = "Table_Name";
                cboTipoAdeudo.DataSource = listTableBaseBE;
                cboTipoAdeudo.SelectedIndex = 0;
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
                cboEstado.DataSource = listTableBaseBE.Where(x => x.Table_Id != Util.EstadoInversion.Aplicada && x.Table_Id != Util.EstadoInversion.Aprobado).ToList();
                cboEstado.SelectedValue = (Estado != null ? Estado : EstadoInversion.Vigente);
                if (frmParentName == "frmConfirmacionAdeudo" || frmParentName == "frmRescisionAdeudo")
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
            listEntidadesFinancierasBE.Insert(0, new EntidadesFinancierasBE() { entFinancieraID = "", emprRazonSocial = "-TODOS-" });

            this.Invoke((MethodInvoker)delegate
            {
                cboBanco.ValueMember = "entFinancieraID";
                cboBanco.DisplayMember = "emprRazonSocial";
                cboBanco.DataSource = listEntidadesFinancierasBE;
                cboBanco.SelectedIndex = 0;
            });
        }
        private void openDetailAdeudo()
        {
            //Form frm;
            if (dgvAdeudo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAdeudo.SelectedRows[0];
                idAdeudo = row.Cells[0].Value.ToString();

                if (frmParentName == "frmRescisionAdeudo")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else if (frmParentName == "frmConfirmacionAdeudo")
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
                else if (frmParentName == "frmRenovacionAdeudo")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult result;
                    adeudo.frmAdeudo frm = new adeudo.frmAdeudo();
                    frm.frmParentName = this.Name;
                    frm.mode = frmBase.frmRegistroBase.Mode.modal;
                    frm.idAdeudo = idAdeudo;
                    frm.Evento = GetEnum.Eventos.view;
                    result = frm.ShowDialog(this);
                }
            }
            else
                ucMsgBox1.ShowMessageWarnnig("Debe seleccionar una adeudo de la lista");
        }
        #endregion

        private void frmBusquedaAdeudo_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoFecha.SelectedIndex = 0;
                cboTipoFecha.Enabled = false;
                dtpInicio.Enabled = false;
                dtpFin.Enabled = false;
                dgvAdeudo.AutoGenerateColumns = false;
                int tipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);

                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listInstrumento();
                    listTipoEntidadFinanciera();
                    listEstadoAdeudo();
                    listEntidadFinanciera(tipoEntidadFinanciera);
                    listMoneda();
                    listAdeudo();
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
                    listAdeudo();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar el adeudo - Error: " + ex.Message);
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
                openDetailAdeudo();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al seleccionar adeudo - Error: " + ex.Message);
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
                        listAdeudo();
                        Util.Util.SetLoading(this, ucLoadingBar1, false);
                    });
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar los adeudos - Error: " + ex.Message);
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
                    listAdeudo();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar las entidades financieras - Error: " + ex.Message);
            }
        }

        private void cboTipoAdeudo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listAdeudo();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar los adeudos - Error: " + ex.Message);
            }
        }

        private void cboBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listAdeudo();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar los adeudos - Error: " + ex.Message);
            }
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listAdeudo();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar los adeudos - Error: " + ex.Message);
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listAdeudo();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al buscar los adeudos - Error: " + ex.Message);
            }
        }

        private void dgvAdeudo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 17)
                {
                    openDetailAdeudo();
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al agregar observaciones - Error: " + ex.Message);
            }
        }

        private void dgvAdeudo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                openDetailAdeudo();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al seleccionar adeudo - Error: " + ex.Message);
            }
        }

        private void dgvAdeudo_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToString(dgvAdeudo.Rows[e.RowIndex].Cells[15].Value) == "Vigente")
            {
                if (Convert.ToInt32(dgvAdeudo.Rows[e.RowIndex].Cells[10].Value) > 0)
                {
                    if (Convert.ToInt32(dgvAdeudo.Rows[e.RowIndex].Cells[14].Value) <= -5)
                        dgvAdeudo.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Crimson;
                    //else if (Convert.ToInt32(dgvAdeudo.Rows[e.RowIndex].Cells[14].Value) <= 5)
                    //    dgvAdeudo.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.YellowGreen;
                    else if (Convert.ToInt32(dgvAdeudo.Rows[e.RowIndex].Cells[13].Value) < Convert.ToInt32(dgvAdeudo.Rows[e.RowIndex].Cells[10].Value))
                        dgvAdeudo.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;
                }
            }
        }
    }
}