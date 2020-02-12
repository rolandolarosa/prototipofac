using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;
using System.Diagnostics;
using System.Configuration;

namespace EfideFactoring.Formula.Catalogo
{
    public partial class frmMntPagadoraDato : FormulaBase.frmMntDato
    {
        bool ind = false;

        PagadoraBL PagadoraBL = new PagadoraBL();
        UbigeoBL UbigeoBL = new UbigeoBL();
        TableBaseBL TableBaseBL = new TableBaseBL();
        PagadoraContactoBL PagadoraContactoBL = new PagadoraContactoBL();
        PagadoraDocumentoBL PagadoraDocumentoBL = new PagadoraDocumentoBL();
        PagadoraLineaBL PagadoraLineaBL = new PagadoraLineaBL();
        PagadoraObservacionBL PagadoraObservacionBL = new PagadoraObservacionBL();
        GrupoPagadoraBL GrupoPagadoraBL = new GrupoPagadoraBL();
        string _IdEstadoLinea_tt = string.Empty;
 
        public frmMntPagadoraDato()
        {
            InitializeComponent();
        }

        #region Eventos ---------------------------------------------
        private void frmMntPagadoraDato_Load(object sender, EventArgs e)
        {
            ind = false;
            LlenarCombos();

            if (Operacion.Equals("N"))
            {
                cboDepartamento.SelectedValue = "15";
                rbtnSinConvenio.Checked = true;
                cboIdRiesgo_tt.SelectedValue = "00006"; // Riesgo Pagador
            }
            else if (Operacion.Equals("M"))
            {
                txtIdPagadora.Text = Codigo;
                CargarDatos();
                CargarPagadoraObservacion();
            }
            else
            {
                txtIdPagadora.Text = Codigo;
                CargarDatos();
                CargarPagadoraObservacion();
                btnAceptar.Enabled = false;
            }
            CargarPermisos();
            CargarBitacoraComercial();
            CargarBitacoraCobranza();
            CargarMediosAutomaticos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
               if (ValidaIngresoPagadora())
                {
                    string FlgIndividualReporte = string.Empty;
                    string FlgConvenio = "0";
                    if (rdbIndividual.Checked) { FlgIndividualReporte = "1"; } else if (rdbReporte.Checked) { FlgIndividualReporte = "2"; }
                    if (rbtnConConvenio.Checked) { FlgConvenio = "1"; }

                    PagadoraBE PagadoraBE = new PagadoraBE()
                    {
                        OPCION = 2,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdPagadora = txtIdPagadora.Text.Trim(),
                        vcPagadora = txtvcPagadora.Text.Trim(),
                        vcNComercial = txtvcNComercial.Text.Trim(),
                        vcNombreCPagadora = txtvcNombreCPagadora.Text.Trim(),
                        bNacional = CheckbNacional.Checked == true ? true : false,
                        vcRuc = txtvcRuc.Text.Trim(),
                        vcPartida = txtvcPartida.Text.Trim(),
                        dtFechaInicio = mskdtFechaInicio.Text.Trim() != string.Empty ? DateTime.Parse(mskdtFechaInicio.Text.Trim()) : DateTime.Parse("01/01/1900"),
                        IdSector_tt = cboIdSector_tt.SelectedValue.ToString(),
                        IdRiesgo_tt = cboIdRiesgo_tt.SelectedValue.ToString(),
                        vcDireccion = txtvcDireccion.Text.Trim(),
                        IdUbigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString(),
                        vcReferencia = txtvcReferencia.Text.Trim(),
                        FlgIndividualReporte = FlgIndividualReporte,
                        FlgConvenio = FlgConvenio
                    };

                    PagadoraBL.ProcesarPagadora(PagadoraBE);
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
               else { return; }
            }
            catch (Exception ex)
            {
                //if (ex.HResult.Equals(-2146233088))
                //{
                //    MessageBox.Show("El Nombre o RUC de esta Pagadora ya esta registrado", "Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIncrementa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.Empty.Equals(txtIdPagadora.Text.Trim()))
                {
                    if (ValidaIngresoPagadora())
                    {
                        DataSet dsPagadora = new DataSet();
                        PagadoraBE PagadoraBE = new PagadoraBE();
                        PagadoraBE = CargarEntidades();

                        dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);
                        txtIdPagadora.Text = dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString();
                    }
                    else { return; }
                }

                Formula.Catalogo.frmPagadoraLinea ofrmPagadoraLinea = new Formula.Catalogo.frmPagadoraLinea();
                ofrmPagadoraLinea.IdPagadora = txtIdPagadora.Text;
                ofrmPagadoraLinea.TipoOperacion = "I";
                ofrmPagadoraLinea.ShowDialog();
                BuscarLineaCredito();
            }
            catch (Exception ex)
            {
                if (ex.HResult.Equals(-2146233088))
                {
                    MessageBox.Show("El Nombre o RUC de esta Pagadora ya esta registrado", "Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.Empty.Equals(txtIdPagadora.Text.Trim()))
                {
                    if (ValidaIngresoPagadora())
                    {
                        DataSet dsPagadora = new DataSet();
                        PagadoraBE PagadoraBE = new PagadoraBE();
                        PagadoraBE = CargarEntidades();

                        dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);
                        txtIdPagadora.Text = dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString();
                    }
                    else { return; }
                }
                Formula.Catalogo.frmPagadoraLinea ofrmPagadoraLinea = new Formula.Catalogo.frmPagadoraLinea();
                ofrmPagadoraLinea.IdPagadora = txtIdPagadora.Text;
                ofrmPagadoraLinea.TipoOperacion = "R";
                ofrmPagadoraLinea.ShowDialog();
                BuscarLineaCredito();
            }
            catch (Exception ex)
            {
                if (ex.HResult.Equals(-2146233088))
                {
                    MessageBox.Show("El Nombre o RUC de esta Pagadora ya esta registrado", "Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmPagadoraLineaLog ofrmPagadoraLineaLog = new Formula.Catalogo.frmPagadoraLineaLog();
            ofrmPagadoraLineaLog.IdPagadora = txtIdPagadora.Text.Trim();
            ofrmPagadoraLineaLog.Pagadora = txtvcPagadora.Text.Trim();
            ofrmPagadoraLineaLog.ShowDialog();
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.Empty.Equals(txtIdPagadora.Text.Trim()))
                {
                    if (ValidaIngresoPagadora())
                    {
                        DataSet dsPagadora = new DataSet();
                        PagadoraBE PagadoraBE = new PagadoraBE();
                        PagadoraBE = CargarEntidades();
                        dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);
                        txtIdPagadora.Text = dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString();
                    }
                    else { return; }
                }
                Formula.Catalogo.frmPagadoraContacto ofrmPagadoraContacto = new Formula.Catalogo.frmPagadoraContacto();
                ofrmPagadoraContacto.IdPagadora = txtIdPagadora.Text;
                ofrmPagadoraContacto.ShowDialog();
                BuscarPagadoraContacto();
            }
            catch (Exception ex)
            {
                if (ex.HResult.Equals(-2146233088))
                {
                    MessageBox.Show("El Nombre o RUC de esta Pagadora ya esta registrado", "Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQuitarContactos_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvContactos.RowCount > 0)
                {

                    dialogResult = MessageBox.Show("Seguro de Eliminar el Contacto: " + dgvContactos.CurrentRow.Cells["vcContacto"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        PagadoraContactoBE PagadoraContactoBE = new PagadoraContactoBE();
                        PagadoraContactoBE.OPCION = 3;
                        PagadoraContactoBE.USUARIO = General.General.GetCodigoUsuario;
                        PagadoraContactoBE.IdPagadora = dgvContactos.CurrentRow.Cells["IdPagadora"].Value.ToString();
                        PagadoraContactoBE.IdItemCtc = dgvContactos.CurrentRow.Cells["IdItemCtc"].Value.ToString();
                        PagadoraContactoBL.ProcesarPagadoraContacto(PagadoraContactoBE);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BuscarPagadoraContacto();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult.Equals(-2146233088))
                {
                    MessageBox.Show("El Nombre o RUC de esta Pagadora ya esta registrado", "Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.Empty.Equals(txtIdPagadora.Text.Trim()))
                {
                    if (ValidaIngresoPagadora())
                    {
                        DataSet dsPagadora = new DataSet();
                        PagadoraBE PagadoraBE = new PagadoraBE();
                        PagadoraBE = CargarEntidades();

                        dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);
                        txtIdPagadora.Text = dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString();
                    }
                    else { return; }
                }

                Formula.Catalogo.frmPagadoraDocumento ofrmPagadoraDocumento = new Formula.Catalogo.frmPagadoraDocumento();
                ofrmPagadoraDocumento.IdPagadora = txtIdPagadora.Text;
                ofrmPagadoraDocumento.ShowDialog();
                BuscarPagadoraDocumento();
            }
            catch (Exception ex)
            {
                if (ex.HResult.Equals(-2146233088))
                {
                    MessageBox.Show("El Nombre o RUC de esta Pagadora ya esta registrado", "Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQuitarDocumentos_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvDocumentos.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de Eliminar el Documento: " + dgvDocumentos.CurrentRow.Cells["IdDocumento"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        PagadoraDocumentoBE PagadoraDocumentoBE = new PagadoraDocumentoBE();
                        PagadoraDocumentoBE.OPCION = 3;
                        PagadoraDocumentoBE.USUARIO = "Administrador";
                        PagadoraDocumentoBE.IdPagadora = txtIdPagadora.Text;
                        PagadoraDocumentoBE.IdDocumento = dgvDocumentos.CurrentRow.Cells["IdDocumento"].Value.ToString();
                        PagadoraDocumentoBE.IdItemDoc = dgvDocumentos.CurrentRow.Cells["IdItemDoc"].Value.ToString();
                        PagadoraDocumentoBL.ProcesarPagadoraDocumento(PagadoraDocumentoBE);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BuscarPagadoraDocumento();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult.Equals(-2146233088))
                {
                    MessageBox.Show("El Nombre o RUC de esta Pagadora ya esta registrado", "Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.ValueMember.ToString() != string.Empty)
            {
                UbigeoBE UbigeoBE = new UbigeoBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    ubiDepartamento = cboDepartamento.SelectedValue.ToString()
                };

                DataSet dsUbigeo = new DataSet();
                dsUbigeo = UbigeoBL.ProcesarUbigeo(UbigeoBE);

                cboProvincia.DataSource = dsUbigeo.Tables[0];
                cboProvincia.DisplayMember = "ubiNombre";
                cboProvincia.ValueMember = "ubiProvincia";

                cboProvincia_SelectedIndexChanged(new object(), new EventArgs());
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.ValueMember.ToString() != string.Empty)
            {
                UbigeoBE UbigeoBE = new UbigeoBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetCodigoUsuario,
                    ubiDepartamento = cboDepartamento.SelectedValue.ToString(),
                    ubiProvincia = cboProvincia.SelectedValue.ToString()
                };

                DataSet dsUbigeo = new DataSet();
                dsUbigeo = UbigeoBL.ProcesarUbigeo(UbigeoBE);

                cboDistrito.DataSource = dsUbigeo.Tables[0];
                cboDistrito.DisplayMember = "ubiNombre";
                cboDistrito.ValueMember = "ubiDistrito";
            }
        }

        private void btnAgregarObservacion_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Catalogo.frmPagadoraObservacion frmPagadoraObservacion = new Formula.Catalogo.frmPagadoraObservacion();
                frmPagadoraObservacion.Operacion = "N";
                frmPagadoraObservacion.Codigo = txtIdPagadora.Text;
                frmPagadoraObservacion._IdObservacion = string.Empty;
                frmPagadoraObservacion.ShowDialog();
                CargarPagadoraObservacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarObservacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPagadoraObservacion.RowCount > 0)
                {
                    if (dgvPagadoraObservacion.CurrentRow.Cells["vcUsuario"].Value.ToString() != General.General.GetUsuario)
                    {
                        MessageBox.Show("Usted no puede modificar esta observación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Formula.Catalogo.frmPagadoraObservacion frmPagadoraObservacion = new Formula.Catalogo.frmPagadoraObservacion();
                    frmPagadoraObservacion.Operacion = "M";
                    frmPagadoraObservacion.Codigo = txtIdPagadora.Text;
                    frmPagadoraObservacion._IdObservacion = dgvPagadoraObservacion.CurrentRow.Cells["IdObservacion"].Value.ToString();
                    frmPagadoraObservacion.ShowDialog();
                    CargarPagadoraObservacion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarObservacion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvPagadoraObservacion.RowCount > 0)
                {
                    if (dgvPagadoraObservacion.CurrentRow.Cells["vcUsuario"].Value.ToString() != General.General.GetUsuario)
                    {
                        MessageBox.Show("Usted no puede eliminar esta observación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    dialogResult = MessageBox.Show("Seguro de eliminar la observación: " + dgvPagadoraObservacion.CurrentRow.Cells["IdObservacion"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        PagadoraObservacionBE PagadoraObservacionBE = new PagadoraObservacionBE();
                        PagadoraObservacionBE.OPCION = 3;
                        PagadoraObservacionBE.USUARIO = General.General.GetCodigoUsuario;
                        PagadoraObservacionBE.IdPagadora = txtIdPagadora.Text;
                        PagadoraObservacionBE.IdObservacion = dgvPagadoraObservacion.CurrentRow.Cells["IdObservacion"].Value.ToString();
                        PagadoraObservacionBL.ProcesarPagadoraObservacion(PagadoraObservacionBE);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPagadoraObservacion();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Metodos ---------------------------------------------
        private void LlenarCombos()
        {
            try
            {
                UbigeoBE UbigeoBE = new UbigeoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario
                };

                DataSet ds = new DataSet();
                ds = UbigeoBL.ProcesarUbigeo(UbigeoBE);

                cboDepartamento.DataSource = ds.Tables[0];
                cboDepartamento.DisplayMember = "ubiNombre";
                cboDepartamento.ValueMember = "ubiDepartamento";

                cboDepartamento_SelectedIndexChanged(new object(), new EventArgs());

                String Table_Id = "00001";

                TableBaseBE TableBaseBE = new TableBaseBE
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                General.General.LlenarCombobox(cboIdSector_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
                //cboIdSector_tt.DataSource = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                //cboIdSector_tt.DisplayMember = "Table_Name";
                //cboIdSector_tt.ValueMember = "Table_Id";

                TableBaseBE.Table_Parent_Id = "00005";
                General.General.LlenarCombobox(cboIdRiesgo_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
                //cboIdRiesgo_tt.DataSource = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                //cboIdRiesgo_tt.DisplayMember = "Table_Name";
                //cboIdRiesgo_tt.ValueMember = "Table_Id";

                TableBaseBE.Table_Parent_Id = "01014"; //Tipo Origen
                General.General.LlenarCombobox(cboIdOrigenBitacora_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0], true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaIngresoPagadora()
        {
            bool flg = true;
            if (string.IsNullOrEmpty(txtvcPagadora.Text.Trim()))
            {
                MessageBox.Show("Debe Ingresar el nombre de la Pagadora", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtvcPagadora.Focus();
                flg = false;
            }
            if (string.IsNullOrEmpty(txtvcNombreCPagadora.Text.Trim()))
            {
                MessageBox.Show("Debe Ingresar el nombre corto de la Pagadora", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtvcRuc.Focus();
                flg = false;
            }
            if (string.IsNullOrEmpty(txtvcRuc.Text.Trim()))
            {
                MessageBox.Show("Debe Ingresar el RUC de la Pagadora", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtvcRuc.Focus();
                flg = false;
            }

            return flg;
        }

        private PagadoraBE CargarEntidades()
        {
            PagadoraBE PagadoraBE = new PagadoraBE()
            {
                OPCION = 2,
                USUARIO = General.General.GetCodigoUsuario,
                vcPagadora = txtvcPagadora.Text.Trim(),
                vcNComercial = txtvcNComercial.Text.Trim(),
                vcNombreCPagadora = txtvcNombreCPagadora.Text.Trim(),
                bNacional = CheckbNacional.Checked == true ? true : false,
                vcRuc = txtvcRuc.Text.Trim(),
                vcPartida = txtvcPartida.Text.Trim(),
                dtFechaInicio = mskdtFechaInicio.Text.Trim() != string.Empty ? DateTime.Parse(mskdtFechaInicio.Text.Trim()) : DateTime.Parse("01/01/1900"),
                IdSector_tt = cboIdSector_tt.SelectedValue.ToString(),
                IdRiesgo_tt = cboIdRiesgo_tt.SelectedValue.ToString(),
                vcDireccion = txtvcDireccion.Text.Trim(),
                IdUbigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString(),
                vcReferencia = txtvcReferencia.Text.Trim()
            };

            return PagadoraBE;
        }

        private void BuscarPagadoraContacto()
        {
            try
            {
                PagadoraContactoBE PagadoraContactoBE = new PagadoraContactoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = txtIdPagadora.Text.Trim()
                };

                dgvContactos.DataSource = PagadoraContactoBL.ProcesarPagadoraContacto(PagadoraContactoBE).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPagadoraDocumento()
        {
            try
            {
                PagadoraDocumentoBE PagadoraDocumentoBE = new PagadoraDocumentoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = txtIdPagadora.Text.Trim()
                };

                dgvDocumentos.DataSource = PagadoraDocumentoBL.ProcesarPagadoraDocumento(PagadoraDocumentoBE).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarLineaCredito()
        {
            try
            {
                DataSet dsPagadoraLinea = new DataSet();
                PagadoraLineaBE PagadoraLineaBE = new PagadoraLineaBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = txtIdPagadora.Text.Trim()
                };

                dsPagadoraLinea = PagadoraLineaBL.ProcesarPagadoraLinea(PagadoraLineaBE);

                if (dsPagadoraLinea.Tables[0].Rows.Count > 0)
                {
                    EvaluarMoneda(dsPagadoraLinea.Tables[0].Rows[0]["IdMoneda_tt"].ToString());
                    txtnLinea.Text = Decimal.Parse(dsPagadoraLinea.Tables[0].Rows[0]["nLinea"].ToString()).ToString("N2");
                    txtnUtilizado.Text = Decimal.Parse(dsPagadoraLinea.Tables[0].Rows[0]["nUtilizado"].ToString()).ToString("N2");
                    txtSaldo.Text = (Convert.ToDecimal(dsPagadoraLinea.Tables[0].Rows[0]["nLinea"]) - Convert.ToDecimal(dsPagadoraLinea.Tables[0].Rows[0]["nUtilizado"])).ToString("N2");
                    dtFechaVencimiento.Value = DateTime.Parse(dsPagadoraLinea.Tables[0].Rows[0]["dtFechaVencimiento"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EvaluarMoneda(string IdMoneda)
        {
            if (IdMoneda.Equals("1"))
            {
                lnlSimbolo1.Text = "S/.";
                lnlSimbolo2.Text = "S/.";
                lnlSimbolo3.Text = "S/.";
            }
            else if (IdMoneda.Equals("2"))
            {
                lnlSimbolo1.Text = "US$";
                lnlSimbolo2.Text = "US$";
                lnlSimbolo3.Text = "US$";
            }
            else
            {
                lnlSimbolo1.Text = "S/.";
                lnlSimbolo2.Text = "S/.";
                lnlSimbolo3.Text = "S/.";
            }
        }

        private void BuscarGrupo()
        {
            try
            {
                DataSet dsGrupoPagadora = new DataSet();
                GrupoPagadoraBE GrupoPagadoraBE = new GrupoPagadoraBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = txtIdPagadora.Text.Trim()

                };

                dsGrupoPagadora = GrupoPagadoraBL.ProcesarGrupoPagadora(GrupoPagadoraBE);
                dgvGrupoPagadora.DataSource = dsGrupoPagadora.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos()
        {
            try
            {
                DataSet dsPagadora = new DataSet();
                PagadoraBE PagadoraBE = new PagadoraBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = txtIdPagadora.Text.Trim()
                };

                dsPagadora =  PagadoraBL.ProcesarPagadora(PagadoraBE);

                if (dsPagadora.Tables[0].Rows.Count > 0)
                {
                    txtvcPagadora.Text = dsPagadora.Tables[0].Rows[0]["vcPagadora"].ToString();
                    txtvcNComercial.Text = dsPagadora.Tables[0].Rows[0]["vcNComercial"].ToString();
                    txtvcNombreCPagadora.Text = dsPagadora.Tables[0].Rows[0]["vcNombreCPagadora"].ToString();
                    lblIdGestor_Dsc.Text = dsPagadora.Tables[0].Rows[0]["IdGestor_Dsc"].ToString();
                    txtvcRuc.Text = dsPagadora.Tables[0].Rows[0]["vcRuc"].ToString();
                    CheckbNacional.CheckValue = dsPagadora.Tables[0].Rows[0]["bNacional"].ToString();
                    if (dsPagadora.Tables[0].Rows[0]["IdUbigeo"].ToString().Trim().Length == 6)
                    {
                        cboDepartamento.SelectedValue = dsPagadora.Tables[0].Rows[0]["IdUbigeo"].ToString().Substring(0, 2);

                        if (!dsPagadora.Tables[0].Rows[0]["IdUbigeo"].ToString().Substring(2, 2).Equals("00"))
                        {
                            cboProvincia.SelectedValue = dsPagadora.Tables[0].Rows[0]["IdUbigeo"].ToString().Substring(2, 2); ;
                        }

                        if (!dsPagadora.Tables[0].Rows[0]["IdUbigeo"].ToString().Substring(4, 2).Equals("00"))
                        {
                            cboDistrito.SelectedValue = dsPagadora.Tables[0].Rows[0]["IdUbigeo"].ToString().Substring(4, 2);
                        }
                    }

                    txtvcDireccion.Text = dsPagadora.Tables[0].Rows[0]["vcDireccion"].ToString();
                    txtvcReferencia.Text = dsPagadora.Tables[0].Rows[0]["vcReferencia"].ToString();
                    txtvcPartida.Text = dsPagadora.Tables[0].Rows[0]["vcPartida"].ToString();
                    mskdtFechaInicio.Value = Convert.ToDateTime(dsPagadora.Tables[0].Rows[0]["dtFechaInicio"].ToString());
                    cboIdSector_tt.SelectedValue = dsPagadora.Tables[0].Rows[0]["IdSector_tt"].ToString();
                    cboIdRiesgo_tt.SelectedValue = dsPagadora.Tables[0].Rows[0]["IdRiesgo_tt"].ToString();
                    if (dsPagadora.Tables[0].Rows[0]["FlgIndividualReporte"].ToString().Equals("1")) { rdbIndividual.Checked = true; } else if (dsPagadora.Tables[0].Rows[0]["FlgIndividualReporte"].ToString().Equals("2")) { rdbReporte.Checked = true; }
                    if (dsPagadora.Tables[0].Rows[0]["FlgConvenio"].ToString().Equals("1")) { rbtnConConvenio.Checked = true; } else { rbtnSinConvenio.Checked = true; }
                    _IdEstadoLinea_tt = dsPagadora.Tables[0].Rows[0]["IdEstadoLinea_tt"].ToString();

                    if (dsPagadora.Tables[0].Rows[0]["Status"].ToString().Equals("B"))
                    {
                        labelX15.Visible = true;
                        labelX15.Text = "*** " + dsPagadora.Tables[0].Rows[0]["IdEstadoLinea_tt_Dsc"].ToString() + " " + dsPagadora.Tables[0].Rows[0]["FechaProceso_Dsc"].ToString() + " ***";
                        btnAnular.Enabled = true; 
                    }
                    else if (dsPagadora.Tables[0].Rows[0]["Status"].ToString().Equals("*")) 
                    { 
                        btnAceptar.Enabled = false; 
                        btnAgregarContacto.Enabled = false; 
                        btnQuitarContactos.Enabled = false; 
                        btnAgregarDocumento.Enabled = false; 
                        btnQuitarDocumentos.Enabled = false; 
                        btnAgregarObservacion.Enabled = false; 
                        btnEditarObservacion.Enabled = false; 
                        btnEliminarObservacion.Enabled = false; 
                        buttonX12.Enabled = false; 
                        btnIncrementa.Enabled = false;
                        btnLineaPagadora.Enabled = false;
                        btnReduce.Enabled = false; 
                        btnHistorial.Enabled = false; 
                        btnBloqueoDef.Enabled = false;
                        btnAnular.Enabled = false; 
                    }
                    else if (dsPagadora.Tables[0].Rows[0]["Status"].ToString().Equals("I"))
                    {
                        btnActivar.Visible = true;
                        btnAnular.Enabled = false; 
                    }
                    else
	                {
                        labelX15.Visible = false;
                        btnActivar.Visible = false;
                        btnAnular.Enabled = false; 
	                }


                    BuscarPagadoraContacto();
                    BuscarPagadoraDocumento();
                    BuscarLineaCredito();
                    BuscarGrupo();
                    BuscarPagadoraAutorizaDoc();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtvcPagadora.Text.Trim()))
                    {
                        MessageBox.Show("Esta Pagadora no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPagadoraObservacion()
        {
            try
            {
                PagadoraObservacionBE PagadoraObservacionBE = new PagadoraObservacionBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = txtIdPagadora.Text.Trim()
                };

                dgvPagadoraObservacion.DataSource = PagadoraObservacionBL.ProcesarPagadoraObservacion(PagadoraObservacionBE).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnAgregarAutorizacionDoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.Empty.Equals(txtIdPagadora.Text.Trim()))
                {
                    if (ValidaIngresoPagadora())
                    {
                        DataSet dsPagadora = new DataSet();
                        PagadoraBE PagadoraBE = new PagadoraBE();
                        PagadoraBE = CargarEntidades();
                        dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);
                        txtIdPagadora.Text = dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString();
                    }
                    else { return; }
                }
                Formula.Catalogo.frmMntPagadoraAutorizaDocDato ofrmPagadoraContacto = new Formula.Catalogo.frmMntPagadoraAutorizaDocDato();
                ofrmPagadoraContacto.Codigo = txtIdPagadora.Text;
                ofrmPagadoraContacto.ShowDialog();
                BuscarPagadoraAutorizaDoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPagadoraAutorizaDoc()
        {
            try
            {
                PagadoraAutorizaDocBE oEntity = new PagadoraAutorizaDocBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = txtIdPagadora.Text.Trim()
                };

                dgvAutorizacionDoc.DataSource = new PagadoraAutorizaDocBL().ProcesarPagadoraAutorizaDoc(oEntity).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarAutorizacionDoc_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = 0;
                try
                {
                    if (dgvAutorizacionDoc.RowCount > 0)
                    {

                        dialogResult = MessageBox.Show("Seguro de eliminar el registro seleccionado", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            PagadoraAutorizaDocBE IEntity = new PagadoraAutorizaDocBE();
                            IEntity.OPCION = 3;
                            IEntity.USUARIO = General.General.GetCodigoUsuario;
                            IEntity.IdPagadora = dgvAutorizacionDoc.CurrentRow.Cells["IdPagadoraADOC"].Value.ToString();
                            IEntity.IdSocio = dgvAutorizacionDoc.CurrentRow.Cells["IdSocio"].Value.ToString();
                            IEntity.IdDocumento = dgvAutorizacionDoc.CurrentRow.Cells["IdDocumentoADoc"].Value.ToString();
                            new PagadoraAutorizaDocBL().ProcesarPagadoraAutorizaDoc(IEntity);
                            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BuscarPagadoraAutorizaDoc();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBloqueoDef_Click(object sender, EventArgs e)
        {
            try
            {
                frmPagadoraTipoBloqueo ofrm = new frmPagadoraTipoBloqueo();
                ofrm.Codigo = txtIdPagadora.Text;
                ofrm._vcPagadora = txtvcPagadora.Text;
                ofrm.ShowDialog();
                CargarPagadoraObservacion();
                labelX15.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            /*DialogResult dialogResult = 0;
            dialogResult = MessageBox.Show("Seguro de Desbloquear a la Pagadora: " + txtvcPagadora.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                PagadoraBE PagadoraBE = new PagadoraBE();
                PagadoraBE.OPCION = 6;
                PagadoraBE.USUARIO = General.General.GetCodigoUsuario;
                PagadoraBE.IdPagadora = txtIdPagadora.Text;
                PagadoraBL.ProcesarPagadora(PagadoraBE);
                CargarPagadoraObservacion();
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelX15.Visible = false;
             }*/

            // Bloqueo Temporal
            //if (_IdEstadoLinea_tt.Equals("00032"))
            //{
                frmComentarioDesbloqueo ofrm = new frmComentarioDesbloqueo();
                ofrm._IdPagadora = txtIdPagadora.Text;
                ofrm._IdPagadora_Dsc = txtvcPagadora.Text;
                ofrm.ShowDialog();
                CargarPagadoraObservacion();

                if (ofrm._Result.Equals("OK"))
                {
                    labelX15.Visible = false;
                }
            //}
            //else
            //{
            //    MessageBox.Show("No se puedes desbloquear la pagadora, solo los que son de tipo bloqueo temporal.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void dgvContactos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvContactos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    Boolean bEntregaLetra = string.IsNullOrEmpty(dgvContactos.CurrentRow.Cells["bEntregaLetra"].Value.ToString()) ? false : Convert.ToBoolean(dgvContactos.CurrentRow.Cells["bEntregaLetra"].Value.ToString());
                    Boolean bEnvioDocumentacion = string.IsNullOrEmpty(dgvContactos.CurrentRow.Cells["bEnvioDocumentacion"].Value.ToString()) ? false : Convert.ToBoolean(dgvContactos.CurrentRow.Cells["bEnvioDocumentacion"].Value.ToString());
                    Boolean bEnvioCobranza = string.IsNullOrEmpty(dgvContactos.CurrentRow.Cells["bEnvioCobranza"].Value.ToString()) ? false : Convert.ToBoolean(dgvContactos.CurrentRow.Cells["bEnvioCobranza"].Value.ToString());
                    Boolean bFinanzas = string.IsNullOrEmpty(dgvContactos.CurrentRow.Cells["bFinanzas"].Value.ToString()) ? false : Convert.ToBoolean(dgvContactos.CurrentRow.Cells["bFinanzas"].Value.ToString());
                    Boolean bRealizarLLamada = string.IsNullOrEmpty(dgvContactos.CurrentRow.Cells["bRealizarLLamada"].Value.ToString()) ? false : Convert.ToBoolean(dgvContactos.CurrentRow.Cells["bRealizarLLamada"].Value.ToString());

                    PagadoraContactoBE oEntity = new PagadoraContactoBE()
                    {
                        OPCION = 5,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdPagadora = dgvContactos.CurrentRow.Cells["IdPagadora"].Value.ToString(),
                        IdItemCtc = dgvContactos.CurrentRow.Cells["IdItemCtc"].Value.ToString(),
                        bEntregaLetra = bEntregaLetra,
                        bEnvioDocumentacion = bEnvioDocumentacion,
                        bEnvioCobranza = bEnvioCobranza,
                        bFinanzas = bFinanzas,
                        bRealizarLLamada = bRealizarLLamada
                    };
                    new PagadoraContactoBL().ProcesarPagadoraContacto(oEntity);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContactos.RowCount > 0)
                {
                    Formula.Catalogo.frmPagadoraContacto ofrmPagadoraContacto = new Formula.Catalogo.frmPagadoraContacto();
                    ofrmPagadoraContacto.Operacion = "M";
                    ofrmPagadoraContacto.IdPagadora = txtIdPagadora.Text;
                    ofrmPagadoraContacto.Codigo = dgvContactos.CurrentRow.Cells["IdItemCtc"].Value.ToString();
                    ofrmPagadoraContacto.ShowDialog();
                    BuscarPagadoraContacto();
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult.Equals(-2146233088))
                {
                    MessageBox.Show("El Nombre o RUC de esta Pagadora ya esta registrado", "Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = 0;
                dialogResult = MessageBox.Show("Seguro de activar a la pagadora : " + txtvcPagadora.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    PagadoraBE PagadoraBE = new PagadoraBE();
                    PagadoraBE.OPCION = 9;
                    PagadoraBE.USUARIO = General.General.GetCodigoUsuario;
                    PagadoraBE.IdPagadora = txtIdPagadora.Text;
                    PagadoraBL.ProcesarPagadora(PagadoraBE);
                    CargarDatos();
                    CargarPagadoraObservacion();
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMntPagadoraDato_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null && !ind)
            {
                ind = true;
                this.Owner.Close();
            }
        }

        private void CargarPermisos()
        {
            try
            {
                DataSet ds = new DataSet();
                UsuarioGestorBE oEntity = new UsuarioGestorBE();
                oEntity.OPCION = 1;
                oEntity.UsuarioID = General.General.GetCodigoUsuario;
                ds = new UsuarioGestorBL().ProcesarUsuarioGestor(oEntity);

                Boolean bAdmLineaPag = false;
                Boolean bAdmBloqueoPag = false;
                Boolean bAdmContactos = false;
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        bAdmLineaPag = Convert.ToBoolean(ds.Tables[0].Rows[0]["bAdmLineaPag"].ToString());
                        bAdmBloqueoPag = Convert.ToBoolean(ds.Tables[0].Rows[0]["bAdmBloqueoPag"].ToString());
                        bAdmContactos = Convert.ToBoolean(ds.Tables[0].Rows[0]["bAdmContactos"].ToString());
                    }
                }

                if (!General.General.GetCodigoUsuario.Trim().Equals("ADMIN"))
                {
                    if (!bAdmLineaPag)
                    {
                        btnIncrementa.Enabled = false;
                        btnLineaPagadora.Enabled = false;
                        btnReduce.Enabled = false;
                        cboIdRiesgo_tt.Enabled = false;
                        TabCobrMA.Visible = false;
                        //dgvContactos.Columns["bEntregaLetra"].Visible = false;
                        //dgvContactos.Columns["bEnvioDocumentacion"].Visible = false;
                        //dgvContactos.Columns["bEnvioCobranza"].Visible = false;
                        //dgvContactos.Columns["bFinanzas"].Visible = false;
                    }

                    if (!bAdmBloqueoPag)
                    {
                        btnActivar.Enabled = false;
                        btnBloqueoDef.Enabled = false;
                        btnAnular.Enabled = false;
                        TabCobrMA.Visible = false;
                    }

                    if (!bAdmContactos)
                    {
                        dgvContactos.Columns["bEntregaLetra"].Visible = false;
                        dgvContactos.Columns["bEnvioDocumentacion"].Visible = false;
                        dgvContactos.Columns["bEnvioCobranza"].Visible = false;
                        dgvContactos.Columns["bFinanzas"].Visible = false;
                        dgvContactos.Columns["bRealizarLLamada"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarBitacoraComercial()
        {
            try
            {
                DataSet dsBitacoraComercial = new DataSet();
                BitacoraComercialBE BitacoraComercialBE = new BitacoraComercialBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdSocio = Codigo,
                    IdGestor = string.Empty,
                };

                dsBitacoraComercial = new BitacoraComercialBL().ProcesarBitacoraComercial(BitacoraComercialBE);
                dgvBitacoraComercial.DataSource = dsBitacoraComercial.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdOrigenBitacora_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarBitacoraCobranza();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarBitacoraCobranza()
        {
            try
            {
                DataSet dsBitacora = new DataSet();
                BitacoraCobranzaInputBE IEntity = new BitacoraCobranzaInputBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdEntidad = Codigo,
                    IdGestor = string.Empty,
                    IdOrigenBitacora_tt = cboIdOrigenBitacora_tt.SelectedValue.ToString()
                };

                dsBitacora = new BitacoraCobranzaBL().ProcesarBitacoraCobranza(IEntity);
                dgvBitacoraCobranza.DataSource = dsBitacora.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEditarDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operacion.Equals("M") && dgvDocumentos.Rows.Count > 0)
                {
                    Formula.Catalogo.frmPagadoraDocumento ofrmPagadoraDocumento = new Formula.Catalogo.frmPagadoraDocumento();
                    ofrmPagadoraDocumento.Operacion = "M";
                    ofrmPagadoraDocumento.IdPagadora = txtIdPagadora.Text;
                    ofrmPagadoraDocumento.IdItemDoc = dgvDocumentos.CurrentRow.Cells["IdItemDoc"].Value.ToString();
                    ofrmPagadoraDocumento.ShowDialog();
                    BuscarPagadoraDocumento();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBitacoraCobranza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvBitacoraCobranza.Columns[e.ColumnIndex].Name.Equals("btnVer"))
                {
                    if (string.IsNullOrEmpty(dgvBitacoraCobranza.CurrentRow.Cells["NombreDocumento"].Value.ToString()))
                    {
                        string filepath = ConfigurationManager.AppSettings["RutaUnidad"].ToString() + "//AvisoVencimiento//" + dgvBitacoraCobranza.CurrentRow.Cells["NombreDocumento"].Value.ToString() + ".pdf";
                        Process.Start(filepath);
                    }
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMediosAutomaticos()
        {
            try
            {
                PagadoraEventosBE oEntity = new PagadoraEventosBE();
                oEntity.OPCION = 1;
                oEntity.IdPagadora = Codigo;
                DataSet ds = new PagadoraEventosBL().ProcesarCobranza(oEntity);
                dgvPagadoraEventos.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPagadoraEventos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvPagadoraEventos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    Boolean bChk = Convert.ToBoolean(dgvPagadoraEventos.CurrentRow.Cells["ChkEvento"].Value);

                    PagadoraEventosBE oEntity = new PagadoraEventosBE()
                    {
                        OPCION = bChk ? 2 : 3,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdPagadora = Codigo,
                        IdEvento_tt = dgvPagadoraEventos.CurrentRow.Cells["IdEvento_tt"].Value.ToString()
                    };
                    new PagadoraEventosBL().ProcesarCobranza(oEntity);
                    CargarPagadoraObservacion();
                    //CargarMediosAutomaticos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLineaPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                EfideFactoring.Formula.Consulta.frmConSaldoSocio3 ofrm = new EfideFactoring.Formula.Consulta.frmConSaldoSocio3();
                ofrm.oIdPagadora = Codigo;
                ofrm.oPagadora = txtIdPagadora.Text;
                ofrm._FlgOrigen = 1;
                //ofrm.btnBuscar.PerformClick();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}