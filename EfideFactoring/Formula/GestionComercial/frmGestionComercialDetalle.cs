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

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmGestionComercialDetalle : FormulaBase.frmMntDato
    {
        public string _NombreSocio = string.Empty;
        public string _NombreGestor = string.Empty;
        public string _IdGestor = string.Empty;
        public int _Annio = 0;
        public int _Mes = 0;
        public decimal _TipCam = 0;
        public string Clasificacion = string.Empty;
        DataSet ds = new DataSet();
        public frmGestionComercialDetalle()
        {
            InitializeComponent();
        }

        private void frmGestionComercialDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                lblSocio.Text = "Socio: " + Codigo.Trim() + " - " + _NombreSocio.Trim();
                lblEjecutivo.Text = "Ejecutivo: " + _NombreGestor.Trim();
                lblMes.Text = "Mes Procesado: " + _Mes.ToString().PadLeft(2, '0') + "-" + _Annio.ToString();
                lblCasificacion.Text = "Clasificación: " + Clasificacion;
                CargarDatos();
                CargarBitacoraComercial();
                CargarContactos();
                CargarTelefonos();
                CargarCorreos();

                if (Clasificacion.Equals("PROSPECTOS/NUEVOS"))
                {
                    btnAgregarContactos.Visible = false;
                    btnAgregarContactos.Visible = false;
                    btnEliminarContacto.Visible = false;
                    btnAgregarTelefono.Visible = false;
                    brnEliminarTelefono.Visible = false;
                    btnAgregarCorreo.Visible = false;
                    btnEliminarCorreo.Visible = false;
                    btnActualizarDatos.Visible = true;
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarDatos()
        {
            try
            {
                ds = new GestionComercialBL().ProcesarGestionComercial(_Annio, _Mes, "", Codigo, _TipCam, 2);
                dgvReporte.DataSource = ds.Tables[0];
                lblRegistros.Text = dgvReporte.Rows.Count + " registro(s)";

                Decimal dPendCobroSol = 0;
                Decimal dPendCobroDol = 0;
                Decimal dCobrRealizadaSol = 0;
                Decimal dCobrRealizadaDol = 0;
                Decimal dDesembolsoSol = 0;
                Decimal dDesembolsoDol = 0;
                Decimal dDiferenciaSol = 0;
                Decimal dDiferenciaDol = 0;
                Decimal dPendCobroTEASol = 0;
                Decimal dPendCobroTEADol = 0;
                Decimal dCobrRealizadaTEASol = 0;
                Decimal dCobrRealizadaTEADol = 0;
                Decimal dDesembolsoTEASol = 0;
                Decimal dDesembolsoTEADol = 0;
                Decimal dPendCobroPlazoSol = 0;
                Decimal dPendCobroPlazoDol = 0;
                Decimal dCobrRealizadaPlazoSol = 0;
                Decimal dCobrRealizadaPlazoDol = 0;
                Decimal dDesembolsoPlazoSol = 0;
                Decimal dDesembolsoPlazoDol = 0;
                int CountPendCobroSol = 0;
                int CountPendCobroDol = 0;
                int CountCobranRealSol = 0;
                int CountCobranRealDol = 0;
                int CountDesemSol = 0;
                int CountDesemDol = 0;
                
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dPendCobroSol += dr["valorMonedaID"].ToString().Equals("1") ? Convert.ToDecimal(dr["PendCob"].ToString()) : 0;
                    dPendCobroDol += dr["valorMonedaID"].ToString().Equals("2") ? Convert.ToDecimal(dr["PendCob"].ToString()) : 0;
                    dCobrRealizadaSol += dr["valorMonedaID"].ToString().Equals("1") ? Convert.ToDecimal(dr["CobReal"].ToString()) : 0;
                    dCobrRealizadaDol += dr["valorMonedaID"].ToString().Equals("2") ? Convert.ToDecimal(dr["CobReal"].ToString()) : 0;
                    dDesembolsoSol += dr["valorMonedaID"].ToString().Equals("1") ? Convert.ToDecimal(dr["nDesembolso"].ToString()) : 0;
                    dDesembolsoDol += dr["valorMonedaID"].ToString().Equals("2") ? Convert.ToDecimal(dr["nDesembolso"].ToString()) : 0;
                    dDiferenciaSol += dr["valorMonedaID"].ToString().Equals("1") ? Convert.ToDecimal(dr["nDesembolso"].ToString()) - Convert.ToDecimal(dr["CobReal"].ToString()) : 0;
                    dDiferenciaDol += dr["valorMonedaID"].ToString().Equals("2") ? Convert.ToDecimal(dr["nDesembolso"].ToString()) - Convert.ToDecimal(dr["CobReal"].ToString()) : 0;
                    
                    //TEA
                    dPendCobroTEASol += dr["valorMonedaID"].ToString().Equals("1") ? Convert.ToDecimal(dr["TasaPendCob"].ToString()) : 0;
                    dPendCobroTEADol += dr["valorMonedaID"].ToString().Equals("2") ? Convert.ToDecimal(dr["TasaPendCob"].ToString()) : 0;

                    dCobrRealizadaTEASol += dr["valorMonedaID"].ToString().Equals("1") ? Convert.ToDecimal(dr["TasaCobReal"].ToString()) : 0;
                    dCobrRealizadaTEADol += dr["valorMonedaID"].ToString().Equals("2") ? Convert.ToDecimal(dr["TasaCobReal"].ToString()) : 0;

                    dDesembolsoTEASol += dr["valorMonedaID"].ToString().Equals("1") ? Convert.ToDecimal(dr["TasaDesembolso"].ToString()) : 0;
                    dDesembolsoTEADol += dr["valorMonedaID"].ToString().Equals("2") ? Convert.ToDecimal(dr["TasaDesembolso"].ToString()) : 0;

                    //Plazo
                    dPendCobroPlazoSol += dr["valorMonedaID"].ToString().Equals("1") ? Convert.ToDecimal(dr["PlazoPendCob"].ToString()) : 0;
                    dPendCobroPlazoDol += dr["valorMonedaID"].ToString().Equals("2") ? Convert.ToDecimal(dr["PlazoPendCob"].ToString()) : 0;

                    dCobrRealizadaPlazoSol += dr["valorMonedaID"].ToString().Equals("1") ? Convert.ToDecimal(dr["PlazoCobReal"].ToString()) : 0;
                    dCobrRealizadaPlazoDol += dr["valorMonedaID"].ToString().Equals("2") ? Convert.ToDecimal(dr["PlazoCobReal"].ToString()) : 0;

                    dDesembolsoPlazoSol += dr["valorMonedaID"].ToString().Equals("1") ? Convert.ToDecimal(dr["PlazoDesembolso"].ToString()) : 0;
                    dDesembolsoPlazoDol += dr["valorMonedaID"].ToString().Equals("2") ? Convert.ToDecimal(dr["PlazoDesembolso"].ToString()) : 0;

                    CountPendCobroSol += dr["valorMonedaID"].ToString().Equals("1") && Convert.ToDecimal(dr["PendCob"].ToString()) > 0 ? 1 : 0;
                    CountPendCobroDol += dr["valorMonedaID"].ToString().Equals("2") && Convert.ToDecimal(dr["PendCob"].ToString()) > 0 ? 1 : 0;
                    CountCobranRealSol += dr["valorMonedaID"].ToString().Equals("1") && Convert.ToDecimal(dr["CobReal"].ToString()) > 0 ? 1 : 0;
                    CountCobranRealDol += dr["valorMonedaID"].ToString().Equals("2") && Convert.ToDecimal(dr["CobReal"].ToString()) > 0 ? 1 : 0;
                    CountDesemSol += dr["valorMonedaID"].ToString().Equals("1") && Convert.ToDecimal(dr["nDesembolso"].ToString()) > 0 ? 1 : 0;
                    CountDesemDol += dr["valorMonedaID"].ToString().Equals("2") && Convert.ToDecimal(dr["nDesembolso"].ToString()) > 0 ? 1 : 0;
                }

                txtPendCobroSol.Text = dPendCobroSol.ToString("N2");
                txtPendCobroDol.Text = dPendCobroDol.ToString("N2");
                txtCobrRealizadaSol.Text = dCobrRealizadaSol.ToString("N2");
                txtCobrRealizadaDol.Text = dCobrRealizadaDol.ToString("N2");
                txtDesembolsoSol.Text = dDesembolsoSol.ToString("N2");
                txtDesembolsoDol.Text = dDesembolsoDol.ToString("N2");
                txtDiferenciaSol.Text = dDiferenciaSol.ToString("N2");
                txtDiferenciaDol.Text = dDiferenciaDol.ToString("N2");
                txtPendCobroTEASol.Text = CountPendCobroSol == 0 ? "0" : (dPendCobroTEASol / CountPendCobroSol).ToString("N2");
                txtPendCobroTEADol.Text = CountPendCobroDol == 0 ? "0" : (dPendCobroTEADol / CountPendCobroDol).ToString("N2");
                txtCobrRealizadaTEASol.Text = CountCobranRealSol == 0 ? "0" : (dCobrRealizadaTEASol / CountCobranRealSol).ToString("N2");
                txtCobrRealizadaTEADol.Text = CountCobranRealDol == 0 ? "0" : (dCobrRealizadaTEADol / CountCobranRealDol).ToString("N2");
                txtDesembolsoTEASol.Text = CountDesemSol == 0 ? "0" : (dDesembolsoTEASol / CountDesemSol).ToString("N2");
                txtDesembolsoTEADol.Text = CountDesemDol == 0 ? "0" : (dDesembolsoTEADol / CountDesemDol).ToString("N2");

                txtPendCobroPlazoSol.Text = CountPendCobroSol == 0 ? "0" : (dPendCobroPlazoSol / CountPendCobroSol).ToString("N0");
                txtPendCobroPlazoDol.Text = CountPendCobroDol == 0 ? "0" : (dPendCobroPlazoDol / CountPendCobroDol).ToString("N0");
                txtCobrRealizadaPlazoSol.Text = CountCobranRealSol == 0 ? "0" : (dCobrRealizadaPlazoSol / CountCobranRealSol).ToString("N0");
                txtCobrRealizadaPlazoDol.Text = CountCobranRealDol == 0 ? "0" : (dCobrRealizadaPlazoDol / CountCobranRealDol).ToString("N0");
                txtDesembolsoPlazoSol.Text = CountDesemSol == 0 ? "0" : (dDesembolsoPlazoSol / CountDesemSol).ToString("N0");
                txtDesembolsoPlazoDol.Text = CountDesemDol == 0 ? "0" : (dDesembolsoPlazoDol / CountDesemDol).ToString("N0");

                if (dDiferenciaSol < 0)
                {
                    txtDiferenciaSol.ForeColor = System.Drawing.Color.Red;
                }

                if (dDiferenciaDol < 0)
                {
                    txtDiferenciaDol.ForeColor = System.Drawing.Color.Red;
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
                    IdGestor = _IdGestor,
                };

                dsBitacoraComercial = new BitacoraComercialBL().ProcesarBitacoraComercial(BitacoraComercialBE);
                dgvBitacoraComercial.DataSource = dsBitacoraComercial.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarBitacoraComercial_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntBitacoraComercialDato frm = new frmMntBitacoraComercialDato();
                frm.Operacion = "N";
                frm._IdSocio = Codigo;
                frm._NombreSocio = _NombreSocio;
                frm._IdGestor = _IdGestor;
                frm._NombreGestor = _NombreGestor;
                frm.ShowDialog();
                CargarBitacoraComercial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarContactos()
        {
            try
            {
                SocioBE oEntity = new SocioBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetUsuario,
                    CodSocio = Codigo
                };
                dgvContactos.DataSource = new SocioBL().ProcesarSocio(oEntity).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTelefonos()
        {
            try
            {
                SocioBE oEntity = new SocioBE()
                {
                    OPCION = 3,
                    USUARIO = General.General.GetUsuario,
                    CodSocio = Codigo
                };
                dgvTelefonos.DataSource = new SocioBL().ProcesarSocio(oEntity).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCorreos()
        {
            try
            {
                SocioBE oEntity = new SocioBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetUsuario,
                    CodSocio = Codigo
                };
                dgvCorreos.DataSource = new SocioBL().ProcesarSocio(oEntity).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompromisos_Click(object sender, EventArgs e)
        {
            try
            {
                frmCompromiso frm = new frmCompromiso();
                frm._IdSocio = Codigo;
                frm._NombreSocio = _NombreSocio;
                frm._IdGestor = _IdGestor;
                frm._NombreGestor = _NombreGestor;
                frm.dsPagadoras = ds;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnalisisCartera_Click(object sender, EventArgs e)
        {
            try
            {
                string StrPagadoras = string.Empty;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    StrPagadoras += dr["IdPagadora"].ToString().Trim() + ";";
                }

                frmAnalisisCarteraSector frm = new frmAnalisisCarteraSector();
                frm._Pagadoras = StrPagadoras;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEstadisticaPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dgvReporte.RowCount > 0)
                //{
                //    //Formula.GestionComercial.frmEstadisticaPagadora ofrm = new Formula.GestionComercial.frmEstadisticaPagadora();
                //    //ofrm._IdPagadora = dgvReporte.CurrentRow.Cells["IdPagadora"].Value.ToString();
                //    //ofrm._IdSocio = Codigo.Trim();
                //    //ofrm._IdPagadora_Dsc = dgvReporte.CurrentRow.Cells["vcPagadora"].Value.ToString();
                //    //ofrm.ShowDialog();
                //}

                ProcessStartInfo info = new ProcessStartInfo();
                info.UseShellExecute = true;
                info.FileName = "ReporteInformeRendimiento.xlsm";
                info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\ReportesCobranza\";
                Process.Start(info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSunat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias");
        }

        private void btnSentinel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sentinelperu.com/cliente/sentinel.aspx");
        }

        private void btnAgregarContactos_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionComercial.frmMntContactos ofrm = new Formula.GestionComercial.frmMntContactos();
                ofrm._IdSocio = Codigo.Trim();
                ofrm.ShowDialog();
                CargarContactos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionComercial.frmMntTelefono ofrm = new Formula.GestionComercial.frmMntTelefono();
                ofrm._IdSocio = Codigo.Trim();
                ofrm.ShowDialog();
                CargarTelefonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionComercial.frmMntEmail ofrm = new Formula.GestionComercial.frmMntEmail();
                ofrm._IdSocio = Codigo.Trim();
                ofrm.ShowDialog();
                CargarCorreos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCorreo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvCorreos.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar el correo: " + dgvCorreos.CurrentRow.Cells["Email"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        EmailTDBE oEntity = new EmailTDBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdSocio = Codigo.Trim(),
                            mailCorreo = dgvCorreos.CurrentRow.Cells["Email"].Value.ToString(),
                        };

                        new EmailTDBL().ProcesarEmailTD(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCorreos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brnEliminarTelefono_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvTelefonos.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar el teléfono: " + dgvTelefonos.CurrentRow.Cells["Telefono"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        TelefonoTDBE oEntity = new TelefonoTDBE()
                        {
                            OPCION = 5,
                            USUARIO = General.General.GetUsuario,
                            IdSocio = Codigo.Trim(),
                            valorCodigoID = int.Parse(dgvTelefonos.CurrentRow.Cells["valorCodigoID"].Value.ToString()),
                            teleTelefono = dgvTelefonos.CurrentRow.Cells["Telefono"].Value.ToString()
                        };

                        new TelefonoTDBL().ProcesarTelefonoTDDA(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTelefonos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvContactos.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar el teléfono: " + dgvContactos.CurrentRow.Cells["Contacto"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        PersonaContactoTDBE oEntity = new PersonaContactoTDBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdSocio = Codigo.Trim(),
                            contacCargo = dgvContactos.CurrentRow.Cells["Cargo"].Value.ToString(),
                            contacNombre = dgvContactos.CurrentRow.Cells["Contacto"].Value.ToString(),
                        };

                        new PersonaContactoTDBL().ProcesarPersonaContactoTD(oEntity);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarContactos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBitacoraComercial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBitacoraComercial.RowCount > 0)
                {
                    frmMntBitacoraComercialDato ofrm = new frmMntBitacoraComercialDato();
                    ofrm.Operacion = "M";
                    ofrm.Codigo = dgvBitacoraComercial.CurrentRow.Cells["IdBitacoraComercial"].Value.ToString();
                    ofrm._IdSocio = Codigo;
                    ofrm._NombreSocio = _NombreSocio;
                    ofrm._NombreGestor = _NombreGestor;
                    ofrm._IdGestor = _IdGestor;
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                frmCarteraCandidatoDato ofrm = new frmCarteraCandidatoDato();
                ofrm.Operacion = "M";
                ofrm.Codigo = Codigo;
                ofrm._OrigenGestion = 1;
                ofrm.ShowDialog();

                CargarContactos();
                CargarTelefonos();
                CargarCorreos();
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
                if (dgvReporte.Rows.Count > 0)
                {
                    Formula.Consulta.frmConSaldoPagador ofrm = new Consulta.frmConSaldoPagador();
                    ofrm.txtCodigo.Text = dgvReporte.CurrentRow.Cells["IdPagadora"].Value.ToString();
                    ofrm.txtPagadora.Text = dgvReporte.CurrentRow.Cells["vcPagadora"].Value.ToString();
                    ofrm.btnBuscar.PerformClick();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLineaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmConSaldoSocio2 ofrmConSaldoSocio2 = new Formula.Consulta.frmConSaldoSocio2();
                ofrmConSaldoSocio2.txtCodigo.Text = Codigo;
                ofrmConSaldoSocio2.txtSocio.Text = _NombreSocio;
                ofrmConSaldoSocio2.ChkVerPagadoras.Checked = true;
                ofrmConSaldoSocio2._Ejecutivo = "";
                ofrmConSaldoSocio2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarSolicitud_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Legal.frmMntSolicitud ofrm = new Formula.Legal.frmMntSolicitud();
                //ofrm.Operacion = "N";
                //ofrm._IdSocio = Codigo;
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoProspecto_Click(object sender, EventArgs e)
        {
            try
            {
                //Formula.GestionComercial.frmCarteraCandidatoDato ofrmCarteraCandidatoDato = new Formula.GestionComercial.frmCarteraCandidatoDato();
                //ofrmCarteraCandidatoDato.Operacion = "N";
                //ofrmCarteraCandidatoDato._OrigenGestion = 1;
                //ofrmCarteraCandidatoDato.ShowDialog();

                Formula.Registros.frmQryOperacionesProceso ofrm = new Formula.Registros.frmQryOperacionesProceso();
                ofrm.Tipo = 2;
                //ofrm.MdiParent = this;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReporte_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionPagadora.frmGestionPagadoraDetalle ofrm = new Formula.GestionPagadora.frmGestionPagadoraDetalle();
                ofrm.Codigo = dgvReporte.CurrentRow.Cells["IdPagadora"].Value.ToString();
                ofrm._IdPagadoraDsc = dgvReporte.CurrentRow.Cells["vcPagadora"].Value.ToString();
                ofrm._IdGestor = _IdGestor;
                ofrm._NombreGestor = _NombreGestor;
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}