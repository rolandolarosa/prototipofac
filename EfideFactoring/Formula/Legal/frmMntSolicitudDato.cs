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
using System.Configuration;
using System.Diagnostics;

namespace EfideFactoring.Formula.Legal
{
    public partial class frmMntSolicitudDato : FormulaBase.frmMntDato
    {
        public string _IdSocio = string.Empty;
        public frmMntSolicitudDato()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmMntSolicitudDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();

                dtSolicitud.Value = DateTime.Now;
                if (Operacion.Equals("C"))
                {
                    btnBuscarSocio.Enabled = false;
                    btnBuscarPagadora.Enabled = false;
                    btnAgregarDocumentoSocio.Visible = false;
                    btnAgregarDocumentoPagador.Visible = false;
                    btnGuardarEnviarLegal.Visible = false;
                    btnAceptar.Visible = false;
                }
                else if (Operacion.Equals("M"))
                {
                    txtIdSolicitud.Text = Codigo;
                    CargarDatos();
                    CargarTracking();
                    CargarSolicitudCheckList("00321");
                    CargarSolicitudCheckList("00322");
                }
                else
                {
                    cboIdArea_tt.SelectedValue = General.General.GetIdTipoGestor_tt;
                    if (!string.IsNullOrEmpty(_IdSocio))
                    {
                        CargarDatosCandidato(_IdSocio);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio._Opcion = 12;
                ofrmBusquedaSocio.ShowDialog();

                if (!string.IsNullOrEmpty(ofrmBusquedaSocio.CodSocio))
                {
                    txtcRucSocio.Text = ofrmBusquedaSocio.RUCSocio.Trim();
                    txtRazonSocialSocio.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();

                    ConsultarDatosConyugue(ofrmBusquedaSocio.CodSocio);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaPagadora ofrmBusquedaPagadora = new Formula.Consulta.frmBusquedaPagadora();
                ofrmBusquedaPagadora.ShowDialog();

                if (!string.IsNullOrEmpty(ofrmBusquedaPagadora.CodigoPagadora))
                {
                    txtcRucPagadora.Text = ofrmBusquedaPagadora.RucPagadora.ToString();
                    txtvRazonSocialPagadora.Text = ofrmBusquedaPagadora.NombrePagadora.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarSolicitud())
                {
                    MessageBox.Show("Se Guardo Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarEnviarLegal_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarSolicitud())
                {
                    SolicitudBE oEntity = new SolicitudBE();
                    oEntity.USUARIO = General.General.GetCodigoUsuario;
                    oEntity.OPCION = 5;
                    oEntity.IdSolicitud = txtIdSolicitud.Text;
                    new SolicitudBL().ProcesarSolicitud(oEntity);
                    MessageBox.Show("Se Guardo Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarObs_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Codigo))
                {
                    if (!GuardarSolicitud())
                    {
                        return;
                    }
                }

                frmMntSolicitudTrackingDato ofrm = new frmMntSolicitudTrackingDato();
                ofrm.Operacion = "N";
                ofrm._IdSolicitud = txtIdSolicitud.Text;
                ofrm.ShowDialog();

                CargarTracking();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarDocumentoSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Codigo))
                {
                    if (!GuardarSolicitud())
                    {
                        return;
                    }
                }

                frmMntSolicitudCheckListDato ofrm = new frmMntSolicitudCheckListDato();
                ofrm.Operacion = "N";
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._IdTipo_tt = "00321"; //Socio
                ofrm._IdTipoSolicitud_tt = cboIdTipoSolicitud_tt.SelectedValue.ToString();
                ofrm._NroIdentidadEntidad = txtcRucSocio.Text.Trim();
                ofrm.ShowDialog();

                CargarSolicitudCheckList("00321");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarDocumentoPagador_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Codigo))
                {
                    if (!GuardarSolicitud())
                    {
                        return;
                    }
                }

                frmMntSolicitudCheckListDato ofrm = new frmMntSolicitudCheckListDato();
                ofrm.Operacion = "N";
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._IdTipo_tt = "00322"; //Pagador
                ofrm._IdTipoSolicitud_tt = cboIdTipoSolicitud_tt.SelectedValue.ToString();
                ofrm._NroIdentidadEntidad = txtcRucPagadora.Text.Trim();
                ofrm.ShowDialog();

                CargarSolicitudCheckList("00322");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCheckListSocio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvCheckListSocio.Columns[e.ColumnIndex].Name.Equals("btnVerDoc") && !string.IsNullOrEmpty(dgvCheckListSocio.CurrentRow.Cells["vDocumentoS"].Value.ToString()))
                {
                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + txtcRucSocio.Text.Trim() + "//Adjuntos//" + txtIdSolicitud.Text + "//" + dgvCheckListSocio.CurrentRow.Cells["vDocumentoS"].Value.ToString();
                    Process.Start(filepath);
                }

                if (dgvCheckListSocio.Columns[e.ColumnIndex].Name.Equals("btnEliminarAdjSocio"))
                {
                    DialogResult dialogResult = 0;
                    dialogResult = MessageBox.Show("¿Seguro de eliminar el documento seleccionado : " + dgvCheckListSocio.CurrentRow.Cells["IdDocumento_tt_DscS"].Value.ToString() + "?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SolicitudCheckListBE oEntity = new SolicitudCheckListBE();
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.OPCION = 3;
                        oEntity.IdSolicitud = Codigo;
                        oEntity.IdTipo_tt = dgvCheckListSocio.CurrentRow.Cells["IdTipo_ttS"].Value.ToString();
                        oEntity.IdDocumento_tt = dgvCheckListSocio.CurrentRow.Cells["vDocumentoS"].Value.ToString();
                        new SolicitudCheckListBL().ProcesarSolicitudCheckList(oEntity);
                        CargarSolicitudCheckList("00321");
                    }
                }

                if (dgvCheckListSocio.Columns[e.ColumnIndex].Name.Equals("btnEditarDocS"))
                {
                    if (string.IsNullOrEmpty(Codigo))
                    {
                        if (!GuardarSolicitud())
                        {
                            return;
                        }
                    }

                    frmMntSolicitudCheckListDato ofrm = new frmMntSolicitudCheckListDato();
                    ofrm.Operacion = "N";
                    ofrm.Codigo = txtIdSolicitud.Text;
                    ofrm._IdTipo_tt = "00321"; //Socio
                    ofrm._IdTipoSolicitud_tt = cboIdTipoSolicitud_tt.SelectedValue.ToString();
                    ofrm._IdDocumento_tt = dgvCheckListSocio.CurrentRow.Cells["IdDocumento_ttS"].Value.ToString();
                    ofrm._NroIdentidadEntidad = txtcRucSocio.Text.Trim();
                    ofrm.ShowDialog();

                    CargarSolicitudCheckList("00321");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCheckListPagador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvCheckListPagador.Columns[e.ColumnIndex].Name.Equals("btnVerDocP") && !string.IsNullOrEmpty(dgvCheckListPagador.CurrentRow.Cells["vDocumentoP"].Value.ToString()))
                {
                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + txtcRucPagadora.Text.Trim() + "//Adjuntos//" + txtIdSolicitud.Text + "//" + dgvCheckListPagador.CurrentRow.Cells["vDocumentoP"].Value.ToString();
                    Process.Start(filepath);
                }

                if (dgvCheckListPagador.Columns[e.ColumnIndex].Name.Equals("btnEliminarAdjPag"))
                {
                    DialogResult dialogResult = 0;
                    dialogResult = MessageBox.Show("¿Seguro de eliminar el documento seleccionado : " + dgvCheckListPagador.CurrentRow.Cells["IdDocumento_tt_DscP"].Value.ToString() + "?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SolicitudCheckListBE oEntity = new SolicitudCheckListBE();
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.OPCION = 3;
                        oEntity.IdSolicitud = Codigo;
                        oEntity.IdTipo_tt = dgvCheckListPagador.CurrentRow.Cells["IdTipo_ttP"].Value.ToString();
                        oEntity.IdDocumento_tt = dgvCheckListPagador.CurrentRow.Cells["vDocumentoP"].Value.ToString();
                        new SolicitudCheckListBL().ProcesarSolicitudCheckList(oEntity);
                        CargarSolicitudCheckList("00322");
                    }
                }

                if (dgvCheckListPagador.Columns[e.ColumnIndex].Name.Equals("btnEditarDocP"))
                {
                    if (string.IsNullOrEmpty(Codigo))
                    {
                        if (!GuardarSolicitud())
                        {
                            return;
                        }
                    }

                    frmMntSolicitudCheckListDato ofrm = new frmMntSolicitudCheckListDato();
                    ofrm.Operacion = "N";
                    ofrm.Codigo = txtIdSolicitud.Text;
                    ofrm._IdTipo_tt = "00322"; //Pagadora
                    ofrm._IdTipoSolicitud_tt = cboIdTipoSolicitud_tt.SelectedValue.ToString();
                    ofrm._IdDocumento_tt = dgvCheckListPagador.CurrentRow.Cells["IdDocumento_ttP"].Value.ToString();
                    ofrm._NroIdentidadEntidad = txtcRucSocio.Text.Trim();
                    ofrm.ShowDialog();

                    CargarSolicitudCheckList("00322");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtiPlazo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtiPlazo.Text))
                {
                    dtVencimiento.Value = DateTime.Now.AddDays(int.Parse(txtiPlazo.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtnImporte.Text);
        }

        private void txtnTEA_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtnTEA.Text);
        }

        private void txtiPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Enteros(e);
        }
        #endregion

        #region Metodos
        private void LlenarCombos()
        {
            try
            {
                String Table_Id = "00287"; // Tipo Solicitud
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdTipoSolicitud_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00246"; // Areas
                General.General.LlenarCombobox(cboIdArea_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                //TableBaseBE.Table_Parent_Id = "00416"; // Tipo Linea Pagadora
                //General.General.LlenarCombobox(cboIdTipoLinea_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00035 "; // Moneda
                General.General.LlenarCombobox(cboIdMoneda_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GuardarSolicitud()
        {
            bool bResult = true;
            try
            {
                if (dtSolicitud.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Se debe ingresar una fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (string.IsNullOrEmpty(cboIdArea_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar una área", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (string.IsNullOrEmpty(cboIdTipoSolicitud_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar el tipo de solicitud", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (string.IsNullOrEmpty(txtcRucSocio.Text) && cboIdTipoSolicitud_tt.SelectedValue.ToString() != "00300") //00300 Estudio Poderes Pagadora
                {
                    MessageBox.Show("Ingrese el número de documento del socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (string.IsNullOrEmpty(txtRazonSocialSocio.Text) && cboIdTipoSolicitud_tt.SelectedValue.ToString() != "00300") //00300 Estudio Poderes Pagadora
                {
                    MessageBox.Show("Ingrese un socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (string.IsNullOrEmpty(txtcRucPagadora.Text) && cboIdTipoSolicitud_tt.SelectedValue.ToString() != "00365") //00365 Estudio Poderes Socio
                {
                    MessageBox.Show("Ingrese el número de documento de la pagadora", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                
                if (string.IsNullOrEmpty(txtvRazonSocialPagadora.Text) && cboIdTipoSolicitud_tt.SelectedValue.ToString() != "00365") //00365 Estudio Poderes Socio
                {
                    MessageBox.Show("Ingrese una pagadora", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                //00300	Estudio Poderes Pagadora || 00365	Estudio Poderes Socio
                if (cboIdTipoSolicitud_tt.SelectedValue.ToString() != "00300" && cboIdTipoSolicitud_tt.SelectedValue.ToString() != "00365")
                {
                    if (string.IsNullOrEmpty(cboIdMoneda_tt.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Seleccione una moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (string.IsNullOrEmpty(txtnImporte.Text))
                    {
                        MessageBox.Show("Ingrese el importe de la operacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                /*
                if (string.IsNullOrEmpty(txtnTEA.Text))
                {
                    MessageBox.Show("Ingrese la TEA de la operacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (string.IsNullOrEmpty(txtiPlazo.Text))
                {
                    MessageBox.Show("Ingrese el plazo de la operacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (dtVencimiento.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Se debe ingresar una fecha de vencimiento de la operación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }*/

                SolicitudBE oEntity = new SolicitudBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSolicitud = Codigo;
                oEntity.dtSolicitud = dtSolicitud.Value;
                oEntity.IdPersonaSolicitud = General.General.GetCodigoUsuario;
                oEntity.IdArea_tt = cboIdArea_tt.SelectedValue.ToString();
                oEntity.IdTipoSolicitud_tt = cboIdTipoSolicitud_tt.SelectedValue.ToString();
                oEntity.cRucSocio = txtcRucSocio.Text;
                oEntity.vRazonSocialSocio = txtRazonSocialSocio.Text;
                oEntity.vConyugue = txtvConyugue.Text;
                oEntity.vConyugueDNI = txtvConyugueDNI.Text;
                oEntity.vConyugueDomicilio = txtvConyugueDomicilio.Text;
                oEntity.NroPartidaSB = txtNroPartidaSB.Text;
                oEntity.dtNroPartidaDB = dtNroPartidaDB.Value;
                oEntity.cRucPagadora = txtcRucPagadora.Text.Trim();
                oEntity.vRazonSocialPagadora = txtvRazonSocialPagadora.Text;
                //oEntity.IdTipoLinea_tt = cboIdTipoLinea_tt.SelectedValue.ToString();
                oEntity.IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString();
                oEntity.nImporte = string.IsNullOrEmpty(txtnImporte.Text)? 0 : Convert.ToDecimal(txtnImporte.Text);
                oEntity.nTEA = string.IsNullOrEmpty(txtnTEA.Text) ? 0 : Convert.ToDecimal(txtnTEA.Text);
                oEntity.iPlazo = string.IsNullOrEmpty(txtiPlazo.Text) ? 0 : int.Parse(txtiPlazo.Text);
                oEntity.iPlanPago = 0;
                oEntity.dtVencimiento = dtVencimiento.Value;
                oEntity.FlgLetraCambio = ChkIncluyeLC.Checked ? 1 : 0;
                DataSet ds = new SolicitudBL().ProcesarSolicitud(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Codigo = ds.Tables[0].Rows[0]["IdSolicitud"].ToString();
                    txtIdSolicitud.Text = Codigo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bResult;
        }

        private void CargarTracking()
        {
            try
            {
                SolicitudTrackingBE oEntity = new SolicitudTrackingBE();
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.OPCION = 1;
                oEntity.IdSolicitud = Codigo;
                
                DataSet ds = new SolicitudTrackingBL().ProcesarSolicitudTracking(oEntity);
                dgvSolicitudTracking.DataSource = ds.Tables[0];
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
                SolicitudBE oEntity = new SolicitudBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSolicitud = Codigo;
                DataSet ds = new SolicitudBL().ProcesarSolicitud(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dtSolicitud.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["dtSolicitud"].ToString());
                    cboIdArea_tt.SelectedValue = ds.Tables[0].Rows[0]["IdArea_tt"].ToString();
                    cboIdTipoSolicitud_tt.SelectedValue = ds.Tables[0].Rows[0]["IdTipoSolicitud_tt"].ToString();
                    txtcRucSocio.Text = ds.Tables[0].Rows[0]["cRucSocio"].ToString();
                    txtRazonSocialSocio.Text = ds.Tables[0].Rows[0]["vRazonSocialSocio"].ToString();
                    txtvConyugue.Text = ds.Tables[0].Rows[0]["vConyugue"].ToString();
                    txtvConyugueDNI.Text = ds.Tables[0].Rows[0]["vConyugueDNI"].ToString();
                    txtvConyugueDomicilio.Text = ds.Tables[0].Rows[0]["vConyugueDomicilio"].ToString();
                    txtNroPartidaSB.Text = ds.Tables[0].Rows[0]["NroPartidaSB"].ToString();
                    dtNroPartidaDB.Value = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["dtNroPartidaDB"].ToString()) ? DateTime.MinValue : Convert.ToDateTime(ds.Tables[0].Rows[0]["dtNroPartidaDB"].ToString());
                    txtcRucPagadora.Text = ds.Tables[0].Rows[0]["cRucPagadora"].ToString();
                    txtvRazonSocialPagadora.Text = ds.Tables[0].Rows[0]["vRazonSocialPagadora"].ToString();
                    //cboIdTipoLinea_tt.SelectedValue = !string.IsNullOrEmpty(ds.Tables[0].Rows[0]["IdTipoLinea_tt"].ToString()) ? ds.Tables[0].Rows[0]["IdTipoLinea_tt"].ToString() : string.Empty;
                    cboIdMoneda_tt.SelectedValue = !string.IsNullOrEmpty(ds.Tables[0].Rows[0]["IdMoneda_tt"].ToString()) ? ds.Tables[0].Rows[0]["IdMoneda_tt"].ToString() : string.Empty;
                    txtnImporte.Text = !string.IsNullOrEmpty(ds.Tables[0].Rows[0]["nImporte"].ToString()) ? "0" : Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"].ToString()).ToString("N2");
                    txtnTEA.Text = !string.IsNullOrEmpty(ds.Tables[0].Rows[0]["nTEA"].ToString()) ? "0" : Convert.ToDecimal(ds.Tables[0].Rows[0]["nTEA"].ToString()).ToString("N2");
                    txtiPlazo.Text = !string.IsNullOrEmpty(ds.Tables[0].Rows[0]["iPlazo"].ToString()) ? "0" : ds.Tables[0].Rows[0]["iPlazo"].ToString();
                    dtVencimiento.Value = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["dtVencimiento"].ToString()) ? DateTime.MinValue : Convert.ToDateTime(ds.Tables[0].Rows[0]["dtVencimiento"].ToString());
                    ChkIncluyeLC.Checked = ds.Tables[0].Rows[0]["FlgLetraCambio"].ToString().Equals("1") ? true : false;

                    if (!ds.Tables[0].Rows[0]["IdEstado_tt"].ToString().Equals("00312"))
                    {
                        btnAceptar.Visible = false;
                        btnGuardarEnviarLegal.Visible = false;
                        btnAgregarDocumentoPagador.Visible = false;
                        btnAgregarDocumentoSocio.Visible = false;
                    }

                    cboIdTipoSolicitud_tt.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarDatosConyugue(string IdSocio)
        {
            try
            {
                DataSet ds = new DataSet();
                SolicitudBE IEntity = new SolicitudBE();
                IEntity.OPCION = 15;
                IEntity.IdSocio = IdSocio;
                ds = new SolicitudBL().ProcesarSolicitud(IEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtvConyugue.Text = ds.Tables[0].Rows[0]["nombreCompleto"].ToString();
                    txtvConyugueDNI.Text = ds.Tables[0].Rows[0]["perNumDoc"].ToString();
                    txtvConyugueDomicilio.Text = ds.Tables[0].Rows[0]["dirDireccion"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarSolicitudCheckList(string IdTipo_tt)
        {
            try
            {
                SolicitudCheckListBE oEntity = new SolicitudCheckListBE();
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.OPCION = 1;
                oEntity.IdSolicitud = Codigo;
                oEntity.IdTipo_tt = IdTipo_tt;

                DataSet ds = new SolicitudCheckListBL().ProcesarSolicitudCheckList(oEntity);

                if (IdTipo_tt.Equals("00321")) // Socio
                {
                    dgvCheckListSocio.DataSource = ds.Tables[0];
                }
                else
                {
                    dgvCheckListPagador.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosCandidato(string IdCandidato)
        {
            try
            {
                DataSet dsCartera = new DataSet();
                CarteraCandidatoBE CarteraCandidatoBE = new CarteraCandidatoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdCartera = IdCandidato,
                };

                dsCartera = new CarteraCandidatoBL().ProcesarCarteraCandidato(CarteraCandidatoBE);

                if (dsCartera.Tables[0].Rows.Count > 0)
                {
                    //txtvApePaterno.Text = dsCartera.Tables[0].Rows[0]["vApePaterno"].ToString();
                    //txtvApeMaterno.Text = dsCartera.Tables[0].Rows[0]["vApeMaterno"].ToString();
                    //txtvNombre.Text = dsCartera.Tables[0].Rows[0]["vNombre"].ToString();
                    //cboIdTipoDocumento_tt.SelectedValue = dsCartera.Tables[0].Rows[0]["IdTipoDocumento_tt"].ToString();
                    //txtvNroDocumento.Text = dsCartera.Tables[0].Rows[0]["vNroDocumento"].ToString();
                    //cboIdTipoPersona_tt.SelectedValue = dsCartera.Tables[0].Rows[0]["IdTipoPersona_tt"].ToString();
                    //txtvContacto.Text = dsCartera.Tables[0].Rows[0]["vContacto"].ToString();
                    //txtvCargo.Text = dsCartera.Tables[0].Rows[0]["vCargo"].ToString();
                    //txtvTelefono1.Text = dsCartera.Tables[0].Rows[0]["vTelefono1"].ToString();
                    //txtvTelefono2.Text = dsCartera.Tables[0].Rows[0]["vTelefono2"].ToString();
                    //txtvTelefono3.Text = dsCartera.Tables[0].Rows[0]["vTelefono3"].ToString();
                    //txtvCorreo.Text = dsCartera.Tables[0].Rows[0]["vCorreo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void ChkIncluyeLC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //00300	Estudio Poderes Pagadora || 00365	Estudio Poderes Socio
                if (cboIdTipoSolicitud_tt.SelectedValue.ToString().Equals("00300") || cboIdTipoSolicitud_tt.SelectedValue.ToString().Equals("00365"))
                {
                    return;
                }

                TabControlPagadora.Enabled = false;
                if (ChkIncluyeLC.Checked)
                {
                    TabControlPagadora.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdTipoSolicitud_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtiPlazo.Enabled = true;
                dtVencimiento.Enabled = true;
                if (cboIdTipoSolicitud_tt.SelectedValue.ToString().Equals("00288"))
                {
                    txtiPlazo.Enabled = false;
                    dtVencimiento.Enabled = false;
                }

                if (!ChkIncluyeLC.Checked)
                {
                    TabControlPagadora.Enabled = false;
                }

                btnAgregarDocumentoSocio.Enabled = true;
                if (cboIdTipoSolicitud_tt.SelectedValue.ToString().Equals("00300")) //00300	Estudio Poderes Pagadora
                {
                    TabControlPagadora.Enabled = true;
                    btnAgregarDocumentoSocio.Enabled = false;
                }

                if (!string.IsNullOrEmpty(cboIdTipoSolicitud_tt.SelectedValue.ToString()))
                {
                    SolicitudCheckListBE oEntity = new SolicitudCheckListBE();
                    oEntity.OPCION = 4;
                    oEntity.USUARIO = General.General.GetCodigoUsuario;
                    oEntity.IdTipo_tt = cboIdTipoSolicitud_tt.SelectedValue.ToString();
                    DataSet ds = new DataSet();
                    ds = new SolicitudCheckListBL().ProcesarSolicitudCheckList(oEntity);

                    //if (ds.Tables.Count > 0)
                    //{
                        dgvCheckListSocio.DataSource = ds.Tables[0];
                    //}

                    string IdTipo_tt = "X";
                    if (ChkIncluyeLC.Checked || cboIdTipoSolicitud_tt.SelectedValue.ToString().Equals("00300")) //Estudio pagadoras
                    {
                        IdTipo_tt = cboIdTipoSolicitud_tt.SelectedValue.ToString();
                    }

                    oEntity = new SolicitudCheckListBE();
                    oEntity.OPCION = 5;
                    oEntity.USUARIO = General.General.GetCodigoUsuario;
                    oEntity.IdTipo_tt = IdTipo_tt;
                    DataSet dsP = new DataSet();
                    dsP = new SolicitudCheckListBL().ProcesarSolicitudCheckList(oEntity);

                    //if (dsP.Tables.Count > 0)
                    //{
                        dgvCheckListPagador.DataSource = dsP.Tables[0];
                    //}
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}       