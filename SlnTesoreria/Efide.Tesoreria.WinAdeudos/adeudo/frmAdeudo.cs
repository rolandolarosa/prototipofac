using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

namespace Efide.Tesoreria.WinAdeudos.adeudo
{
    public partial class frmAdeudo : frmBase.frmRegistroBase
    {
        public frmAdeudo()
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
        private ContactoBL _ContactoBL;
        private ContactoBL oContactoBL
        {
            get { return (_ContactoBL == null ? _ContactoBL = new ContactoBL() : _ContactoBL); }
        }
        private DocumentoBL _DocumentoBL;
        private DocumentoBL oDocumentoBL
        {
            get { return (_DocumentoBL == null ? _DocumentoBL = new DocumentoBL() : _DocumentoBL); }
        }
        private CuentaBancosBL _CuentaBancosBL;
        private CuentaBancosBL oCuentaBancosBL
        {
            get { return (_CuentaBancosBL == null ? _CuentaBancosBL = new CuentaBancosBL() : _CuentaBancosBL); }
        }
        #endregion
        
        #region " PROPERTIES "
        public string idAdeudo { get; set; }
        public GetEnum.Eventos Evento { get; set; }
        public string frmParentName { get; set; }
        #endregion

        #region "FUNCTIONS"
        private void loadAdeudo()
        {
            AdeudoBE oAdeudoBE = new AdeudoBE();
            ContactoBE oContactoBE = new ContactoBE();
            List<DocumentoBE> lstDocumentoBE = new List<DocumentoBE>();

            oAdeudoBE = oAdeudoBL.getAdeudo(idAdeudo, Util.General.GetFechaGlobal);
            oContactoBE = oContactoBL.getContacto(idAdeudo);
            lstDocumentoBE = oDocumentoBL.listDocumento(idAdeudo);

            this.Invoke((MethodInvoker)delegate
            {
                txtNroCertificado.Text = oAdeudoBE.nroCertificado;
                cboTipoInversion.SelectedValue = oAdeudoBE.idTipoAdeudo;
                cboTipoEntidadFinanciera.SelectedValue = oAdeudoBE.idTipoEntidadFinanciera;
                cboBanco.SelectedValue = oAdeudoBE.idEntidadFinanciera;
                txtImporte.Text = oAdeudoBE.importe.ToString();
                cboMoneda.SelectedValue = oAdeudoBE.idMoneda;
                txtTasa.Text = oAdeudoBE.tasa.ToString();
                cboPlazo.Text = oAdeudoBE.plazo.ToString();
                dtFechaInicio.Text = oAdeudoBE.fechaInicio.ToShortDateString();
                dtFechaVencimiento.Text = oAdeudoBE.fechaVencimiento.ToShortDateString();

                txtEstadoInversion.Text = oAdeudoBE.nomEstado;

                txtTasaRescision.Text = oAdeudoBE.tasaRescision.ToString();
                cboPlazoRescision.Text = Convert.ToString(oAdeudoBE.plazoRescision);
                //txtDiasAvisioVencimiento.Text = oAdeudoBE.diasAvisoVencimiento.ToString();
                txtObservaciones.Text = oAdeudoBE.observaciones;

                txtFuncionario.Text = oContactoBE.funcionario;
                txtTelefonoFijo.Text = oContactoBE.telefono;
                txtAnexo.Text = oContactoBE.anexo;
                txtCorreo.Text = oContactoBE.correo;
                txtCelular.Text = oContactoBE.celular;
                dtpCumpleanos.Value = oContactoBE.cumpleanos;
                cboCuentaBancaria.SelectedValue = oContactoBE.cuentaBancoID;

                txtIdInversion.Text = idAdeudo;

                dgvAdjuntos.DataSource = lstDocumentoBE;
            });
        }
        private void listCuentasBancarias()
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (cboBanco.SelectedValue != null)
                {
                    List<CuentaBancosBE> lstCuentaBancosBE = new List<CuentaBancosBE>();
                    lstCuentaBancosBE = oCuentaBancosBL.listCuentaBancos(Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue)).Where(x => x.idEntidadFinanciera.Trim() == Convert.ToString(cboBanco.SelectedValue).Trim()).ToList();
                        cboCuentaBancaria.ValueMember = "cuentaBancoID";
                        cboCuentaBancaria.DisplayMember = "cuentaLocal";
                    if(lstCuentaBancosBE.Count > 0)
                        cboCuentaBancaria.DataSource = lstCuentaBancosBE;
                    else
                        cboCuentaBancaria.DataSource = null;
                }
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
        private void saveAdeudos()
        {
            AdeudoBE oAdeudoBE = new AdeudoBE();

            this.Invoke((MethodInvoker)delegate
            {
                oAdeudoBE.nroCertificado = Convert.ToString(txtNroCertificado.Text);
                oAdeudoBE.idTipoAdeudo = Convert.ToString(cboTipoInversion.SelectedValue);
                oAdeudoBE.idTipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);
                oAdeudoBE.idEntidadFinanciera = cboBanco.SelectedValue.ToString();
                oAdeudoBE.idMoneda = Convert.ToInt32(cboMoneda.SelectedValue);
                oAdeudoBE.importe = Convert.ToDecimal(txtImporte.Text);
                oAdeudoBE.tasa = Convert.ToDecimal(txtTasa.Text);
                oAdeudoBE.plazo = Convert.ToInt32(cboPlazo.Text);
                oAdeudoBE.fechaInicio = dtFechaInicio.Value;
                oAdeudoBE.fechaVencimiento = dtFechaVencimiento.Value;
                oAdeudoBE.tasaRescision = Convert.ToDecimal(txtTasaRescision.Text);
                oAdeudoBE.plazoRescision = Convert.ToInt32(cboPlazoRescision.Text);
                oAdeudoBE.diasAvisoVencimiento = 0; //Convert.ToInt32(txtDiasAvisioVencimiento.Text);
                oAdeudoBE.observaciones = txtObservaciones.Text;
                oAdeudoBE.idEstado = Util.EstadoInversion.Registrado;
            });

            switch (Evento)
            {
                case GetEnum.Eventos.insert:
                    oAdeudoBE.usuCreacion = General.GetCodigoUsuario;
                    oAdeudoBE.fechaCreacion = Util.General.GetFechaGlobal;
                    idAdeudo = oAdeudoBL.insertAdeudo(oAdeudoBE);
                    break;
                case GetEnum.Eventos.edit:
                    oAdeudoBE.idAdeudo = idAdeudo;
                    oAdeudoBE.usuUltActualizacion = General.GetCodigoUsuario;
                    oAdeudoBE.fechaUltActualizacion = Util.General.GetFechaGlobal;
                    oAdeudoBL.updateAdeudo(oAdeudoBE);
                    break;
                case GetEnum.Eventos.delete:
                    oAdeudoBE.usuUltActualizacion = General.GetCodigoUsuario;
                    oAdeudoBE.fechaUltActualizacion = Util.General.GetFechaGlobal;
                    oAdeudoBE.idEstado = Util.EstadoInversion.Vigente;
                    oAdeudoBL.updateAdeudo(oAdeudoBE);
                    break;
                default:
                    break;
            }

            this.Invoke((MethodInvoker)delegate
            {
                txtIdInversion.Text = idAdeudo;
            });
        }
        private void saveContacto()
        {
            ContactoBE oContactoBE = new ContactoBE();

            this.Invoke((MethodInvoker)delegate
            {
                oContactoBE.idAdeudo = idAdeudo;
                oContactoBE.correo = txtCorreo.Text;
                oContactoBE.telefono = txtTelefonoFijo.Text;
                oContactoBE.anexo = txtAnexo.Text;
                oContactoBE.funcionario = txtFuncionario.Text;
                oContactoBE.cumpleanos = dtpCumpleanos.Value;
                oContactoBE.celular = txtCelular.Text;
                oContactoBE.cuentaBancoID = Convert.ToInt32(cboCuentaBancaria.SelectedValue);
            });

            switch (Evento)
            {
                case GetEnum.Eventos.insert:
                    oContactoBL.insertContato(oContactoBE);
                    break;
                case GetEnum.Eventos.edit:
                    oContactoBL.updateContato(oContactoBE);
                    break;
                case GetEnum.Eventos.delete:
                    break;
                default:
                    break;
            }
        }
        private void saveDocumento()
        {
            string idDocumento = string.Empty;
            List<DocumentoBE> lstDocumentoBE = new List<DocumentoBE>();
            List<DocumentoBE> lstDocumentoBEdb = new List<DocumentoBE>();
            List<DocumentoBE> lstDocumentoBEdel = new List<DocumentoBE>();
            List<DocumentoBE> lstDocumentoBEinsert = new List<DocumentoBE>();

            this.Invoke((MethodInvoker)delegate
            {
                foreach (DataGridViewRow row in dgvAdjuntos.Rows)
                {
                    lstDocumentoBE.Add(new DocumentoBE()
                    {
                        rutaAnterior = row.Cells[0].Value.ToString(),
                        ruta = AppSettings.rutaDocumentosAdjuntos,
                        nombre = row.Cells[1].Value.ToString(),
                        observaciones = row.Cells[2].Value.ToString(),
                        idDocumento = (row.Cells[5].Value == null ? "" : row.Cells[5].Value.ToString())
                    });
                }
            });

            if (Evento == GetEnum.Eventos.edit)
            {
                lstDocumentoBEdb = oDocumentoBL.listDocumento(idAdeudo);
                lstDocumentoBEdel = (from t in lstDocumentoBEdb where !lstDocumentoBE.Any(x => x.idDocumento == t.idDocumento) select t).ToList();

                foreach (DocumentoBE oDocumentoBE in lstDocumentoBEdel)
                {
                    oDocumentoBL.deleteDocumento(oDocumentoBE.idDocumento, idAdeudo);
                    //File.Copy(oDocumentoBE.rutaAnterior + oDocumentoBE.nombre, oDocumentoBE.ruta + oDocumentoBE.idAdeudo + idDocumento + oDocumentoBE.nombre.Substring(oDocumentoBE.nombre.LastIndexOf("."), oDocumentoBE.nombre.Length - oDocumentoBE.nombre.LastIndexOf(".")), true);
                    File.Delete(oDocumentoBE.ruta + oDocumentoBE.nombre);
                }

                lstDocumentoBEinsert = (from t in lstDocumentoBE where !lstDocumentoBEdb.Any(x => x.idDocumento == t.idDocumento) select t).ToList();
                lstDocumentoBE = lstDocumentoBEinsert;
            }

            foreach (DocumentoBE oDocumentoBE in lstDocumentoBE)
            {
                switch (Evento)
                {
                    case GetEnum.Eventos.insert:
                        oDocumentoBE.idAdeudo = idAdeudo;
                        idDocumento = oDocumentoBL.insertDocumento(oDocumentoBE);
                        File.Copy(oDocumentoBE.rutaAnterior + oDocumentoBE.nombre, oDocumentoBE.ruta + oDocumentoBE.idAdeudo + idDocumento + oDocumentoBE.nombre.Substring(oDocumentoBE.nombre.LastIndexOf("."), oDocumentoBE.nombre.Length - oDocumentoBE.nombre.LastIndexOf(".")), true);
                        break;
                    case GetEnum.Eventos.edit:
                        oDocumentoBE.idAdeudo = idAdeudo;
                        idDocumento = oDocumentoBL.insertDocumento(oDocumentoBE);
                        File.Copy(oDocumentoBE.rutaAnterior + oDocumentoBE.nombre, oDocumentoBE.ruta + oDocumentoBE.idAdeudo + idDocumento + oDocumentoBE.nombre.Substring(oDocumentoBE.nombre.LastIndexOf("."), oDocumentoBE.nombre.Length - oDocumentoBE.nombre.LastIndexOf(".")), true);
                        break;
                    case GetEnum.Eventos.delete:
                        break;
                    default:
                        break;
                }
            }
        }
        private void listDocumento()
        {
            List<DocumentoBE> lstDocumentoBE = new List<DocumentoBE>();
            lstDocumentoBE = oDocumentoBL.listDocumento(idAdeudo);
            this.Invoke((MethodInvoker)delegate
            {
                dgvAdjuntos.DataSource = lstDocumentoBE;
            });
        }
        private void viewAdjunto(string fileName, string path)
        {
            ProcessStartInfo info;
            info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.WorkingDirectory = path;
            info.FileName = fileName;
            Process.Start(info);
        }
        private void deleteAdjuntoTemp(string fileName)
        {
            List<DocumentoBE> lstDocumentoBE = new List<DocumentoBE>();
            eTaskDialogResult result = ucMsgBox1.ShowMessageConfirmation("¿Desea eliminar el archivo seleccionado?");
            if (result == eTaskDialogResult.Yes)
            {
                if (dgvAdjuntos.DataSource != null)
                    lstDocumentoBE.AddRange((List<DocumentoBE>)dgvAdjuntos.DataSource);

                lstDocumentoBE.Remove(lstDocumentoBE.Find(x => x.nombre == fileName));
                dgvAdjuntos.DataSource = lstDocumentoBE;
            }
        }
        private void saveAdjuntoTemp()
        {
            List<DocumentoBE> lstDocumentoBE = new List<DocumentoBE>();
            string fileName = string.Empty;
            string pathTemp = string.Empty;

            fileName = txtDocumentosAdjuntos.Text.Substring(txtDocumentosAdjuntos.Text.LastIndexOf(@"\") + 1, txtDocumentosAdjuntos.Text.Length - (txtDocumentosAdjuntos.Text.LastIndexOf(@"\") + 1));
            pathTemp = txtDocumentosAdjuntos.Text.Substring(0, txtDocumentosAdjuntos.Text.LastIndexOf(@"\") + 1);

            if (dgvAdjuntos.DataSource != null)
                lstDocumentoBE.AddRange((List<DocumentoBE>)dgvAdjuntos.DataSource);

            if (lstDocumentoBE == null)
                lstDocumentoBE = new List<DocumentoBE>();

            if (lstDocumentoBE.Exists(x => x.nombre == fileName && x.ruta == pathTemp))
                ucMsgBox1.ShowMessageWarnnig("Se no se puede adjuntar el mismo archivo mas de una vez");
            else
            {
                lstDocumentoBE.Add(new DocumentoBE() { ruta = pathTemp, nombre = fileName, observaciones = txtObservacionesAdjunto.Text });
                dgvAdjuntos.DataSource = lstDocumentoBE;
                txtDocumentosAdjuntos.Text = string.Empty;
                txtObservacionesAdjunto.Text = string.Empty;
            }
        }
        private void selectFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.CheckPathExists)
                    txtDocumentosAdjuntos.Text = openFileDialog1.FileName;
            }
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
                        //dgvAdjuntos.Columns["Column5"].Visible = false;
                        dgvAdjuntos.Columns["Column4"].Visible = false;
                        btnAdjuntar.Enabled = false;
                        btnSalir.Visible = true;
                        break;
                    case GetEnum.Eventos.insert:
                        btnGuardar.Visible = true;
                        btnLimpiar.Visible = true;
                        btnSalir.Visible = true;
                        break;
                    case GetEnum.Eventos.edit:
                        btnGuardar.Visible = true;
                        btnCancelar.Visible = true;
                        //btnAprobar.Visible = true;
                        break;
                    case GetEnum.Eventos.confirmar:
                        dgvAdjuntos.Columns["Column4"].Visible = false;
                        btnAdjuntar.Enabled = false;
                        btnSalir.Visible = true;
                        break;
                    case GetEnum.Eventos.delete:
                        break;
                    default:
                        break;
                }
            });
        }
        private void limpiarControles()
        {
            cboTipoInversion.SelectedIndex = 0;
            cboTipoEntidadFinanciera.SelectedIndex = 0;
            cboBanco.SelectedIndex = 0;
            cboMoneda.SelectedIndex = 0;
            txtImporte.Text = string.Empty;
            txtTasa.Text = string.Empty;
            cboPlazo.SelectedIndex = 0;

            dtFechaInicio.Text = Util.General.GetFechaGlobal.ToShortDateString();
            dtFechaVencimiento.Text = Util.General.GetFechaGlobal.ToShortDateString();

            txtTasaRescision.Text = string.Empty;
            cboPlazoRescision.SelectedIndex = 0;
            //txtDiasAvisioVencimiento.Text = string.Empty;
            txtObservaciones.Text = string.Empty;

            txtFuncionario.Text = string.Empty;
            txtTelefonoFijo.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtAnexo.Text = string.Empty;
            txtCelular.Text = string.Empty;
            dtpCumpleanos.Value = Util.General.GetFechaGlobal;
            cboCuentaBancaria.SelectedIndex = 0;

            clearValidation();
        }
        private void clearValidation()
        {
            Util.Validation.CleanValidate(groupPanel1);
            Util.Validation.CleanValidate(groupPanel2);
            Util.Validation.CleanValidate(groupPanel3);
        }

        private void saveGeneral()
        {
            saveAdeudos();
            saveContacto();
            saveDocumento();
            listDocumento();

            switch (Evento)
            {
                case GetEnum.Eventos.insert: ucMsgBox1.ShowMessageSuccess("Se registró satisfactoriamente la Inversión");
                    break;
                case GetEnum.Eventos.edit: ucMsgBox1.ShowMessageSuccess("Se actualizó satisfactoriamente la Inversión");
                    break;
                default:
                    break;
            }
        }
        private void listPlazo()
        {
            this.Invoke((MethodInvoker)delegate
            {
                //cboPlazo.Items.Add("0");
                cboPlazo.Items.Add("30");
                cboPlazo.Items.Add("60");
                cboPlazo.Items.Add("120");
                cboPlazo.Items.Add("240");
                cboPlazo.Items.Add("360");
                cboPlazo.Items.Add("365");
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
                cboPlazoRescision.Items.Add("365");
                cboPlazoRescision.Items.Add("720");
                cboPlazoRescision.Items.Add("1080");
                cboPlazoRescision.Items.Add("1440");
                cboPlazoRescision.Items.Add("1800");
                cboPlazoRescision.SelectedIndex = 0;
            });
        }
        #endregion

        private void frmAdeudo_Load(object sender, EventArgs e)
        {
            try
            {
                dgvAdjuntos.AutoGenerateColumns = false;
                //int tipoEntidadFinanciera = Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue);

                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    listTipoEntidadFinanciera();
                    //listEntidadFinanciera(tipoEntidadFinanciera);
                    listCuentasBancarias();
                    listInstrumentoAdeudo();
                    listMoneda();
                    listPlazoRescision();
                    listPlazo();
                    if (!string.IsNullOrEmpty(idAdeudo) && (Evento == GetEnum.Eventos.edit || Evento == GetEnum.Eventos.view))
                        loadAdeudo();
                    else
                    {
                        Evento = GetEnum.Eventos.insert;
                        dtFechaInicio.Value = Util.General.GetFechaGlobal;
                        dtFechaInicio.Text = Util.General.GetFechaGlobal.ToShortDateString();
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

        private void cboTipoEntidadFinanciera_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string tipoEntidadFinanciera = ""; 

                this.Invoke((MethodInvoker)delegate
                {
                    if(cboTipoEntidadFinanciera.SelectedValue != null)
                        tipoEntidadFinanciera = cboTipoEntidadFinanciera.SelectedValue.ToString();

                    if (!string.IsNullOrEmpty(tipoEntidadFinanciera))
                        listEntidadFinanciera(Convert.ToInt32(tipoEntidadFinanciera));
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar las entidades financieras - Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clearValidation();
                if (Util.Validation.ValidateRequired(groupPanel2, errorProvider1) && Util.Validation.ValidateRequired(groupPanel1, errorProvider1) && Util.Validation.ValidateRequired(groupPanel3, errorProvider1))
                {
                    Task.Factory.StartNew(() =>
                    {
                        Util.Util.SetLoading(this, ucLoadingBar1, true);
                        saveGeneral();
                        Util.Util.SetLoading(this, ucLoadingBar1, false);
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.Close();
                        });
                    });
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al guardar Inversión - Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarControles();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al limpiar la pantalla - Error: " + ex.Message);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cancelar - Error: " + ex.Message);
            }
        }

        private void btnSelectAdjuntos_Click(object sender, EventArgs e)
        {
            try
            {
                selectFile();   
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar archivo para adjuntar - Error: " + ex.Message);
            }
        }

        private void dgvAdjuntos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string path = dgvAdjuntos.Rows[e.RowIndex].Cells[0].Value.ToString();
                string fileName = dgvAdjuntos.Rows[e.RowIndex].Cells[1].Value.ToString();

                switch (e.ColumnIndex)
                {
                    case 3:
                        viewAdjunto(fileName, path);
                        break;
                    case 4:
                        deleteAdjuntoTemp(fileName);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(txtDocumentosAdjuntos.Text))
                    saveAdjuntoTemp();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al adjuntar archivo - Error: " + ex.Message);
            }
        }

        private void cboPlazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtFechaVencimiento.Value = Convert.ToDateTime(dtFechaInicio.Value).AddDays(Convert.ToInt32(cboPlazo.Text));
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al calcular la fecha de vencimiento - Error: " + ex.Message);
            }
        }

        private void cboBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            listCuentasBancarias();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                clearValidation();
                if (Util.Validation.ValidateRequired(groupPanel2, errorProvider1) && Util.Validation.ValidateRequired(groupPanel1, errorProvider1) && Util.Validation.ValidateRequired(groupPanel3, errorProvider1))
                {
                    Task.Factory.StartNew(() =>
                    {
                        Util.Util.SetLoading(this, ucLoadingBar1, true);
                        Evento = GetEnum.Eventos.confirmar;
                        saveGeneral();
                        Util.Util.SetLoading(this, ucLoadingBar1, false);
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.Close();
                        });
                    });
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al guardar Inversión - Error: " + ex.Message);
            }
        }

        private void cboCuentaBancaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<CuentaBancosBE> lstCuentaBancosBE = new List<CuentaBancosBE>();
                lstCuentaBancosBE = oCuentaBancosBL.listCuentaBancos(Convert.ToInt32(cboTipoEntidadFinanciera.SelectedValue)).Where(x => x.idEntidadFinanciera.Trim() == Convert.ToString(cboBanco.SelectedValue).Trim() && x.cuentaBancoID == Convert.ToInt32(cboCuentaBancaria.SelectedValue)).ToList();

                if (lstCuentaBancosBE.Count > 0)
                    lblCCI.Text = lstCuentaBancosBE[0].cuentaCCI;
                else
                    lblCCI.Text = "";
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al listar las cuentas de bancos - Error: " + ex.Message);
            }
        }

        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if(!string.IsNullOrEmpty(cboPlazo.Text))
                        dtFechaVencimiento.Value = Convert.ToDateTime(dtFechaInicio.Value).AddDays(Convert.ToInt32(cboPlazo.Text));
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al calcular la fecha de vencimiento - Error: " + ex.Message);
            }
        }
    }
}
