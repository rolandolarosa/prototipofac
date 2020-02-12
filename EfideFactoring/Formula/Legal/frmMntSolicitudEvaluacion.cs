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
using System.IO;
using System.Data.SqlClient;

namespace EfideFactoring.Formula.Legal
{
    public partial class frmMntSolicitudEvaluacion : FormulaBase.frmMntDato
    {
        #region Eventos
        public frmMntSolicitudEvaluacion()
        {
            InitializeComponent();
        }

        private void frmMntSolicitudEvaluacion_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
                CargarRepresentantes("00321");
                CargarRepresentantes("00322");
                CargarFacultades("00321");
                CargarFacultades("00322");

                if (Operacion.Equals("C"))
                {
                    btnAgregarRepresentantesSocio.Visible = false;
                    btnEditReprSocio.Visible = false;
                    btnDelReprSocio.Visible = false;
                    btnAgregarFacultadesSocio.Visible = false;
                    btnDelFacSocio.Visible = false;
                    btnRepresentantesPagador.Visible = false;
                    btnEditReprPagador.Visible = false;
                    btnDelReprPagador.Visible = false;
                    btnAgregarFacultadesPagador.Visible = false;
                    btnDelFacPagador.Visible = false;
                    btnAceptar.Visible = false;
                    btnObservar.Visible = false;
                    btnGuardar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTracking_Click(object sender, EventArgs e)
        {
            try
            {
                frmQrySolicitudTracking ofrm = new frmQrySolicitudTracking();
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm.ShowDialog();
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
                 //comentado por ingreso de data historica
                //if (dgvFacultadSocio.Rows.Count == 0)
                //{
                //    MessageBox.Show("Debe configurar al menos una facultad para el socio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                //if (dgvFacultadPagador.Rows.Count == 0)
                //{
                //    MessageBox.Show("Debe configurar al menos una facultad para el pagador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                DialogResult dialogResult = 0;
                dialogResult = MessageBox.Show("Está usted seguro de dar por conluido la solicitud?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    GuardarDatos();
                    SolicitudBE oEntity = new SolicitudBE();
                    oEntity.USUARIO = General.General.GetCodigoUsuario;
                    oEntity.OPCION = 7;
                    oEntity.IdSolicitud = txtIdSolicitud.Text;
                    new SolicitudBL().ProcesarSolicitud(oEntity);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObservar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = 0;
                dialogResult = MessageBox.Show("Está usted seguro de observar la solicitud?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    GuardarDatos();
                    frmMntSolicitudTrackingDato ofrm = new frmMntSolicitudTrackingDato();
                    ofrm.Operacion = "N";
                    ofrm._IdSolicitud = txtIdSolicitud.Text;
                    ofrm.ShowDialog();

                    SolicitudBE oEntity = new SolicitudBE();
                    oEntity.USUARIO = General.General.GetCodigoUsuario;
                    oEntity.OPCION = 6;
                    oEntity.IdSolicitud = txtIdSolicitud.Text;
                    new SolicitudBL().ProcesarSolicitud(oEntity);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarDatos();
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerFacultadesSocio_Click(object sender, EventArgs e)
        {
            try
            {
                frmVisorFirma ofrm = new frmVisorFirma();
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._Entidad = "VISOR DE FIRMAS DEL SOCIO " + txtRazonSocialSocio.Text;
                ofrm._IdTipo_tt = "00321";
                ofrm._NroIdentidadEntidad = txtcRucSocio.Text.Trim();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerFacultadesPagador_Click(object sender, EventArgs e)
        {
            try
            {
                frmVisorFirma ofrm = new frmVisorFirma();
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._Entidad = "VISOR DE FIRMAS DE LA PAGADORA: " + txtvRazonSocialPagadora.Text;
                ofrm._IdTipo_tt = "00322";
                ofrm._NroIdentidadEntidad = txtcRucPagadora.Text.Trim();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFacultadSocio_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvFacultadSocio.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    Boolean bFirma = Convert.ToBoolean(dgvFacultadSocio.CurrentRow.Cells["bFirmaSF"].Value.ToString());

                    SolicitudFacultadBE oEntity = new SolicitudFacultadBE()
                    {
                        OPCION = 2,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdSolicitud = txtIdSolicitud.Text,
                        IdTipo_tt = dgvFacultadSocio.CurrentRow.Cells["IdTipo_ttSF"].Value.ToString(),
                        IdItem = dgvFacultadSocio.CurrentRow.Cells["IdItemSF"].Value.ToString(),
                        IdFacultad_tt = dgvFacultadSocio.CurrentRow.Cells["IdFacultad_ttSF"].Value.ToString(),
                        bFirma = bFirma
                    };
                    new SolicitudFacultadBL().ProcesarSolicitudFacultad(oEntity);
                    //CargarFacultades(oEntity.IdTipo_tt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFacultadPagador_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvFacultadPagador.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    Boolean bFirma = Convert.ToBoolean(dgvFacultadPagador.CurrentRow.Cells["bFirmaPF"].Value.ToString());

                    SolicitudFacultadBE oEntity = new SolicitudFacultadBE()
                    {
                        OPCION = 2,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdSolicitud = txtIdSolicitud.Text,
                        IdTipo_tt = dgvFacultadPagador.CurrentRow.Cells["IdTipo_ttPF"].Value.ToString(),
                        IdItem = dgvFacultadPagador.CurrentRow.Cells["IdItemPF"].Value.ToString(),
                        IdFacultad_tt = dgvFacultadPagador.CurrentRow.Cells["IdFacultad_ttPF"].Value.ToString(),
                        bFirma = bFirma
                    };
                    new SolicitudFacultadBL().ProcesarSolicitudFacultad(oEntity);
                    //CargarFacultades(oEntity.IdTipo_tt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarFormatos_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                SolicitudBE oEntityDatos = new SolicitudBE();
                oEntityDatos.USUARIO = General.General.GetCodigoUsuario;
                oEntityDatos.OPCION = 13;
                oEntityDatos.IdSolicitud = txtIdSolicitud.Text;
                dsDatos = new SolicitudBL().ProcesarSolicitud(oEntityDatos);

                DataSet ds = new DataSet();
                SolicitudBE oEntity = new SolicitudBE();
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.OPCION = 12;
                oEntity.IdSolicitud = txtIdSolicitud.Text;
                ds = new SolicitudBL().ProcesarSolicitud(oEntity);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        General.WordDocumentWrite WD = new General.WordDocumentWrite();
                        WD.WordDocument(dr["Archivo"].ToString(), ConfigurationManager.AppSettings["RutaPCUsertTmp"].ToString());

                        foreach (DataColumn dc in dsDatos.Tables[0].Columns)
                        {
                            WD.FindAndReplace(dc.ColumnName.ToString(), dsDatos.Tables[0].Rows[0][dc.ColumnName].ToString());
                        }

                        WD.SaveDocument();
                        WD.CloseDocument();
                    }

                    MessageBox.Show("Los formatos se generarón correctamente en la ruta: " + ConfigurationManager.AppSettings["RutaPCUsertTmp"].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos Generales
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
                    txtIdSolicitud.Text = ds.Tables[0].Rows[0]["IdSolicitud"].ToString();
                    dtSolicitud.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["dtSolicitud"].ToString());
                    txtIdArea_tt_Dsc.Text = ds.Tables[0].Rows[0]["IdArea_tt_Dsc"].ToString();
                    txtIdTipoSolicitud_tt_Dsc.Text = ds.Tables[0].Rows[0]["IdTipoSolicitud_tt_Dsc"].ToString();
                    txtIdSocio.Text = ds.Tables[0].Rows[0]["IdSocio"].ToString();
                    txtcRucSocio.Text = ds.Tables[0].Rows[0]["cRucSocio"].ToString();
                    txtRazonSocialSocio.Text = ds.Tables[0].Rows[0]["vRazonSocialSocio"].ToString();
                    txtvConyugue.Text = ds.Tables[0].Rows[0]["vConyugue"].ToString();
                    txtvConyugueDNI.Text = ds.Tables[0].Rows[0]["vConyugueDNI"].ToString();
                    txtvConyugueDomicilio.Text = ds.Tables[0].Rows[0]["vConyugueDomicilio"].ToString();
                    txtNroPartidaSB.Text = ds.Tables[0].Rows[0]["NroPartidaSB"].ToString();
                    dtNroPartidaDB.Value = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["dtNroPartidaDB"].ToString()) ? DateTime.MinValue : Convert.ToDateTime(ds.Tables[0].Rows[0]["dtNroPartidaDB"].ToString());
                    txtIdPagadora.Text = ds.Tables[0].Rows[0]["IdPagadora"].ToString();
                    txtcRucPagadora.Text = ds.Tables[0].Rows[0]["cRucPagadora"].ToString();
                    txtvRazonSocialPagadora.Text = ds.Tables[0].Rows[0]["vRazonSocialPagadora"].ToString();
                    txtIdMoneda_tt_Dsc.Text = ds.Tables[0].Rows[0]["IdMoneda_tt_Dsc"].ToString();
                    txtnImporte.Text = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["nImporte"].ToString()) ? "0" : Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"].ToString()).ToString("N2");
                    txtnTEA.Text = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["nTEA"].ToString()) ? "0" : Convert.ToDecimal(ds.Tables[0].Rows[0]["nTEA"].ToString()).ToString("N2");
                    txtnTEAMinDol.Text = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["nTEAMinDol"].ToString()) ? "0" : Convert.ToDecimal(ds.Tables[0].Rows[0]["nTEAMinDol"].ToString()).ToString("N2");
                    txtnTEAMaxSol.Text = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["nTEAMaxSol"].ToString()) ? "0" : Convert.ToDecimal(ds.Tables[0].Rows[0]["nTEAMaxSol"].ToString()).ToString("N2");
                    txtnTEAMaxDol.Text = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["nTEAMaxDol"].ToString()) ? "0" : Convert.ToDecimal(ds.Tables[0].Rows[0]["nTEAMaxDol"].ToString()).ToString("N2");
                    txtiPlazo.Text = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["iPlazo"].ToString()) ? "0" : ds.Tables[0].Rows[0]["iPlazo"].ToString();
                    dtVencimiento.Value = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["dtVencimiento"].ToString()) ? DateTime.MinValue : Convert.ToDateTime(ds.Tables[0].Rows[0]["dtVencimiento"].ToString());
                    txtvDomicilioRealPag.Text = ds.Tables[0].Rows[0]["vDomicilioRealPag"].ToString();
                    txtvDomicilioLegalPag.Text = ds.Tables[0].Rows[0]["vDomicilioLegalPag"].ToString();
                    txtvPartidaElectronica.Text = ds.Tables[0].Rows[0]["vPartidaElectronica"].ToString();
                    txtvDomicilioRealSoc.Text = ds.Tables[0].Rows[0]["vDomicilioRealSoc"].ToString();
                    txtvDomicilioAnexoSoc.Text = ds.Tables[0].Rows[0]["vDomicilioAnexoSoc"].ToString();
                    txtvObjetoSocial.Text = ds.Tables[0].Rows[0]["vObjetoSocial"].ToString();
                    txtvCapSocialSoc.Text = ds.Tables[0].Rows[0]["vCapSocialSoc"].ToString();
                    ChkIncluyeLC.Checked = ds.Tables[0].Rows[0]["FlgLetraCambio"].ToString().Equals("1") ? true: false;

                    if (ds.Tables[0].Rows[0]["FlgDefinitivo"].ToString().Equals("1"))
                    {
                        btnGenerarDefinitivo.Visible = false;
                        btnGenerarFormatos.Text = "Descargar Formatos";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarRepresentantes(string IdTipo_tt)
        {
            try
            {
                SolicitudRepresentanteBE oEntity = new SolicitudRepresentanteBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSolicitud = txtIdSolicitud.Text;
                oEntity.IdTipo_tt = IdTipo_tt;
                DataSet ds = new SolicitudRepresentanteBL().ProcesarSolicitudRepresentante(oEntity);

                if (IdTipo_tt.Equals("00321")) // Socio
                {
                    dgvRepresentantesSocio.DataSource = ds.Tables[0];
                }
                else
                {
                    dgvRepresentantesPagador.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarFacultades(string IdTipo_tt)
        {
            try
            {
                SolicitudFacultadBE oEntity = new SolicitudFacultadBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSolicitud = txtIdSolicitud.Text;
                oEntity.IdTipo_tt = IdTipo_tt;
                DataSet ds = new SolicitudFacultadBL().ProcesarSolicitudFacultad(oEntity);

                if (IdTipo_tt.Equals("00321")) // Socio
                {
                    dgvFacultadSocio.DataSource = ds.Tables[0];
                }
                else
                {
                    dgvFacultadPagador.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarDatos()
        {
            try
            {
                SolicitudBE oEntity = new SolicitudBE();
                oEntity.OPCION = 9;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.IdSolicitud = Codigo;
                oEntity.cRucSocio = txtcRucSocio.Text;
                oEntity.vRazonSocialSocio = txtRazonSocialSocio.Text;
                oEntity.vDomicilioRealPag = txtvDomicilioRealPag.Text;
                oEntity.vDomicilioLegalPag = txtvDomicilioLegalPag.Text;
                oEntity.vPartidaElectronica = txtvPartidaElectronica.Text;
                oEntity.vDomicilioRealSoc = txtvDomicilioRealSoc.Text;
                oEntity.vDomicilioAnexoSoc = txtvDomicilioAnexoSoc.Text;
                oEntity.vObjetoSocial = txtvObjetoSocial.Text;
                oEntity.vCapSocialSoc = txtvCapSocialSoc.Text;
                oEntity.nTEA = string.IsNullOrEmpty(txtnTEA.Text) ? 0 : Convert.ToDecimal(txtnTEA.Text);
                oEntity.nTEAMinDol = string.IsNullOrEmpty(txtnTEAMinDol.Text) ? 0 : Convert.ToDecimal(txtnTEAMinDol.Text);
                oEntity.nTEAMaxSol = string.IsNullOrEmpty(txtnTEAMaxSol.Text) ? 0 : Convert.ToDecimal(txtnTEAMaxSol.Text);
                oEntity.nTEAMaxDol = string.IsNullOrEmpty(txtnTEAMaxDol.Text) ? 0 : Convert.ToDecimal(txtnTEAMaxDol.Text);
                new SolicitudBL().ProcesarSolicitud(oEntity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Evaluacion Socio
        private void btnHistorialSocio_Click(object sender, EventArgs e)
        {
            try
            {
                frmQrySolicitud ofrm = new frmQrySolicitud();
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._RUC = txtcRucSocio.Text;
                ofrm._Entidad = txtRazonSocialSocio.Text;
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdjuntosSocio_Click(object sender, EventArgs e)
        {
            try
            {
                frmQrySolicitudCheckList ofrm = new frmQrySolicitudCheckList();
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._RUC = txtcRucSocio.Text;
                ofrm._Entidad = txtRazonSocialSocio.Text;
                ofrm._IdTipo_tt = "00321";
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDatosSocio_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntSolicitudRegistro ofrm = new frmMntSolicitudRegistro();
                ofrm.Operacion = Operacion;
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._RUC = txtcRucSocio.Text;
                ofrm._Entidad = txtRazonSocialSocio.Text;
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarRepresentantesSocio_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntSolicitudRepresentanteDato ofrm = new frmMntSolicitudRepresentanteDato();
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._IdTipo_tt = "00321";
                ofrm._NroIdentidadEntidad = txtcRucSocio.Text.Trim();
                ofrm.ShowDialog();

                CargarRepresentantes("00321");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditReprSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRepresentantesSocio.Rows.Count > 0)
                {
                    frmMntSolicitudRepresentanteDato ofrm = new frmMntSolicitudRepresentanteDato();
                    ofrm.Operacion = "M";
                    ofrm.Codigo = txtIdSolicitud.Text;
                    ofrm._IdTipo_tt = "00321";
                    ofrm._IdRepresentante = dgvRepresentantesSocio.CurrentRow.Cells["IdRepresentanteS"].Value.ToString();
                    ofrm._NroIdentidadEntidad = txtcRucSocio.Text.Trim();
                    ofrm.ShowDialog();

                    CargarRepresentantes("00321");
                    CargarFacultades("00321");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelReprSocio_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvRepresentantesSocio.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar al representante " + dgvRepresentantesSocio.CurrentRow.Cells["vNombreRepresentanteS"].Value.ToString().Trim() + "?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SolicitudRepresentanteBE oEntity = new SolicitudRepresentanteBE();
                        oEntity.OPCION = 3;
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.IdSolicitud = txtIdSolicitud.Text;
                        oEntity.IdTipo_tt = dgvRepresentantesSocio.CurrentRow.Cells["IdTipo_ttS"].Value.ToString();
                        oEntity.IdRepresentante = dgvRepresentantesSocio.CurrentRow.Cells["IdRepresentanteS"].Value.ToString();
                        new SolicitudRepresentanteBL().ProcesarSolicitudRepresentante(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarRepresentantes("00321");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void dgvFacultadSocio_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if (e.ColumnIndex < 0) return;
        //        if (e.RowIndex == -1) return;

        //        if (dgvFacultadSocio.Columns[e.ColumnIndex].Name.Equals("btnVisorFirma"))
        //        {
        //            frmVisorFirma ofrm = new frmVisorFirma();
        //            ofrm.Codigo = txtIdSolicitud.Text;
        //            ofrm._IdTipo_tt = "00321";
        //            ofrm._Facultad = dgvFacultadSocio.CurrentRow.Cells["IdFacultad_tt_DscSF"].Value.ToString();
        //            ofrm._Firma1 = dgvFacultadSocio.CurrentRow.Cells["vFirmaAdjunta1S"].Value.ToString();
        //            ofrm._Firma2 = dgvFacultadSocio.CurrentRow.Cells["vFirmaAdjunta2S"].Value.ToString();
        //            ofrm.ShowDialog();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnAgregarFacultadesSocio_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntSolicitudFacultadDato ofrm = new frmMntSolicitudFacultadDato();
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._IdTipo_tt = "00321";
                ofrm.ShowDialog();

                CargarFacultades("00321");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelFacSocio_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvFacultadSocio.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar la facultad " + dgvFacultadSocio.CurrentRow.Cells["IdFacultad_tt_DscSF"].Value.ToString().Trim() + "?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SolicitudFacultadBE oEntity = new SolicitudFacultadBE();
                        oEntity.OPCION = 3;
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.IdSolicitud = txtIdSolicitud.Text;
                        oEntity.IdTipo_tt = dgvFacultadSocio.CurrentRow.Cells["IdTipo_ttSF"].Value.ToString();
                        oEntity.IdItem = dgvFacultadSocio.CurrentRow.Cells["IdItemSF"].Value.ToString();
                        new SolicitudFacultadBL().ProcesarSolicitudFacultad(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarFacultades("00321");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Evaluacion Pagador
        private void btnHistorialPagador_Click(object sender, EventArgs e)
        {
            try
            {
                frmQrySolicitud ofrm = new frmQrySolicitud();
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._RUC = txtcRucPagadora.Text;
                ofrm._Entidad = txtvRazonSocialPagadora.Text;
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdjuntosPagador_Click(object sender, EventArgs e)
        {
            try
            {
                frmQrySolicitudCheckList ofrm = new frmQrySolicitudCheckList();
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._RUC = txtcRucPagadora.Text;
                ofrm._Entidad = txtvRazonSocialPagadora.Text;
                ofrm._IdTipo_tt = "00322";
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDocumentosFinanciar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntSolicitudDocumento ofrm = new frmMntSolicitudDocumento();
                ofrm.Operacion = Operacion;
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._RUC = txtcRucPagadora.Text;
                ofrm._Entidad = txtIdPagadora.Text;
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRepresentantesPagador_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntSolicitudRepresentanteDato ofrm = new frmMntSolicitudRepresentanteDato();
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._IdTipo_tt = "00322";
                ofrm._NroIdentidadEntidad = txtcRucPagadora.Text.Trim();
                ofrm.ShowDialog();

                CargarRepresentantes("00322");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditReprPagador_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRepresentantesPagador.Rows.Count > 0)
                {
                    frmMntSolicitudRepresentanteDato ofrm = new frmMntSolicitudRepresentanteDato();
                    ofrm.Operacion = "M";
                    ofrm.Codigo = txtIdSolicitud.Text;
                    ofrm._IdTipo_tt = "00322";
                    ofrm._IdRepresentante = dgvRepresentantesPagador.CurrentRow.Cells["IdRepresentanteP"].Value.ToString();
                    ofrm._NroIdentidadEntidad = txtcRucPagadora.Text.Trim();
                    ofrm.ShowDialog();

                    CargarRepresentantes("00322");
                    CargarFacultades("00322");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelReprPagador_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvRepresentantesPagador.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar al representante " + dgvRepresentantesPagador.CurrentRow.Cells["vNombreRepresentanteP"].Value.ToString().Trim() + "?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SolicitudRepresentanteBE oEntity = new SolicitudRepresentanteBE();
                        oEntity.OPCION = 3;
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.IdSolicitud = txtIdSolicitud.Text;
                        oEntity.IdTipo_tt = dgvRepresentantesPagador.CurrentRow.Cells["IdTipo_ttP"].Value.ToString();
                        oEntity.IdRepresentante = dgvRepresentantesPagador.CurrentRow.Cells["IdRepresentanteP"].Value.ToString();
                        new SolicitudRepresentanteBL().ProcesarSolicitudRepresentante(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarRepresentantes("00322");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarFacultadesPagador_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntSolicitudFacultadDato ofrm = new frmMntSolicitudFacultadDato();
                ofrm.Codigo = txtIdSolicitud.Text;
                ofrm._IdTipo_tt = "00322";
                ofrm.ShowDialog();

                CargarFacultades("00322");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelFacPagador_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvFacultadPagador.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar la facultad " + dgvFacultadPagador.CurrentRow.Cells["IdFacultad_tt_DscPF"].Value.ToString().Trim() + "?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SolicitudFacultadBE oEntity = new SolicitudFacultadBE();
                        oEntity.OPCION = 3;
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.IdSolicitud = txtIdSolicitud.Text;
                        oEntity.IdTipo_tt = dgvFacultadPagador.CurrentRow.Cells["IdTipo_ttPF"].Value.ToString();
                        oEntity.IdItem = dgvFacultadPagador.CurrentRow.Cells["IdItemPF"].Value.ToString();
                        new SolicitudFacultadBL().ProcesarSolicitudFacultad(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarFacultades("00322");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnGenerarDefinitivo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                DataSet dsDatos = new DataSet();
                SolicitudBE oEntityDatos = new SolicitudBE();
                oEntityDatos.USUARIO = General.General.GetCodigoUsuario;
                oEntityDatos.OPCION = 14;
                oEntityDatos.IdSolicitud = txtIdSolicitud.Text;
                dsDatos = new SolicitudBL().ProcesarSolicitud(oEntityDatos);

                DataSet ds = new DataSet();
                SolicitudBE oEntity = new SolicitudBE();
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.OPCION = 12;
                oEntity.IdSolicitud = txtIdSolicitud.Text;
                ds = new SolicitudBL().ProcesarSolicitud(oEntity);

                string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + txtcRucSocio.Text.Trim() +"//Contratos//";

                if (ds.Tables.Count > 0)
                {
                    dialogResult = MessageBox.Show("¿Usted está seguro de generar los formatos definitivamente?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            General.WordDocumentWrite WD = new General.WordDocumentWrite();
                            WD.WordDocument(dr["Archivo"].ToString(), filepath);

                            foreach (DataColumn dc in dsDatos.Tables[0].Columns)
                            {
                                WD.FindAndReplace(dc.ColumnName.ToString(), dsDatos.Tables[0].Rows[0][dc.ColumnName].ToString());
                            }

                            WD.SaveDocument();
                            WD.CloseDocument();
                        }
                        MessageBox.Show("Los formatos se generarón correctamente en la ruta: " + filepath, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirEvaluacion_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("RptSolicitudFormato", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.Parameters.AddWithValue("@IdSolicitud", txtIdSolicitud.Text);
                    cmd1.Parameters.AddWithValue("@IdTipo_tt", "00321");
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(ds, "DataTable");
                    con.Close();
                }

                Crystal.crRptFormatoEvaluacionLegal ocrLoteLiquidacion = new Crystal.crRptFormatoEvaluacionLegal();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(ds);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("Titulo", "EVALUACION DE LEGAL DEL SOCIO");
                ocrLoteLiquidacion.SetParameterValue("IdTipo_tt", "00321");
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirEvaluacionP_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("RptSolicitudFormato", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.Parameters.AddWithValue("@IdSolicitud", txtIdSolicitud.Text);
                    cmd1.Parameters.AddWithValue("@IdTipo_tt", "00322");
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(ds, "DataTable");
                    con.Close();
                }

                Crystal.crRptFormatoEvaluacionLegal ocrLoteLiquidacion = new Crystal.crRptFormatoEvaluacionLegal();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                ocrLoteLiquidacion.SetDataSource(ds);
                ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                ocrLoteLiquidacion.SetParameterValue("Titulo", "EVALUACION DE LEGAL DEL PAGADOR");
                ocrLoteLiquidacion.SetParameterValue("IdTipo_tt", "00322");
                ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}