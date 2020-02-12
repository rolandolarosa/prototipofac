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

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmCompromisoDato : FormulaBase.frmMntDato
    {
        public DataSet _dsPagadoras = new DataSet();
        public string _IdSocio = string.Empty;
        public string _NombreGestor = string.Empty;
        public string _IdGestor = string.Empty;
        private string IdPagadora = string.Empty;
        CompromisoComBL CompromisoComBL = new CompromisoComBL();
        TableBaseBL TableBaseBL = new TableBaseBL();

        public frmCompromisoDato()
        {
            InitializeComponent();
        }

        private void frmCompromisoDato_Load(object sender, EventArgs e)
        {
            try
            {
                lblEjecutivo.Text = "Ejecutivo: " + _NombreGestor.Trim();
                LlenarCombos();

                if (Operacion.Equals("M"))
                {
                    btnBuscarPagadora.Visible = false;
                    txtRucPagadora.ReadOnly = true;
                    txtvcPagadora.ReadOnly = true;
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCombos()
        {
            try
            {
                //General.General.LlenarCombobox(cboIdPagadora, "vcPagadora", "IdPagadora", _dsPagadoras.Tables[0], false);

                String Table_Id = "00001"; //SECTORES
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                General.General.LlenarCombobox(cboidsector_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
                
                //TableBaseBE.Table_Parent_Id = "00042"; //TIPO LINEA
                //General.General.LlenarCombobox(cboIdTipoLin_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00234"; //TIPO SERVICIO
                General.General.LlenarCombobox(cboIdTipoSer_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00035"; //MONEDA
                General.General.LlenarCombobox(cboIdMoneda_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00009"; //CARGO
                General.General.LlenarCombobox(cboidcargo_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
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
                if (string.IsNullOrEmpty(txtRucPagadora.Text.Trim().ToString()))
                {
                    MessageBox.Show("Ingrese nro. de RUC", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtvcPagadora.Text.Trim().ToString()))
                {
                    MessageBox.Show("Ingrese la razón social", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtRucPagadora.Text.Trim().ToString()))
                {
                    MessageBox.Show("Se debe seleccionar una pagadora", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtOrigen.Text.Trim().Equals("Efide Top")) //Para efide TOP
                {
                    /*
                    if (string.IsNullOrEmpty(cboidsector_tt.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Se debe seleccionar un sector", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }*/

                    if (string.IsNullOrEmpty(cboidcargo_tt.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Se debe seleccionar un cargo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (string.IsNullOrEmpty(txttelefonoanx.Text.Trim()))
                    {
                        MessageBox.Show("Ingresar un número de teléfono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (string.IsNullOrEmpty(txtemailcorp.Text.Trim()))
                    {
                        MessageBox.Show("Ingresar el email", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (string.IsNullOrEmpty(cboidcargo_tt.SelectedValue.ToString().Trim()))
                    {
                        MessageBox.Show("Seleccione un cargo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (string.IsNullOrEmpty(cboIdTipoSer_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un tipo de servicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(cboIdMoneda_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar una moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                CompromisoComBE CompromisoComBE = new CompromisoComBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdCompromiso = Codigo,
                    sdFechaReg = DateTime.Now,
                    IdPagadora = IdPagadora,
                    RucPagadora = txtRucPagadora.Text,
                    vcPagadora = txtvcPagadora.Text.Trim(),
                    idsector_tt = cboidsector_tt.SelectedValue.ToString(),
                    Origen = txtOrigen.Text,
                    nLineaDisp = String.IsNullOrEmpty(txtnLineaDisp.Text.Trim()) ? 0 : Convert.ToDecimal(txtnLineaDisp.Text),
                    IdTipoSer_tt = cboIdTipoSer_tt.SelectedValue.ToString(),
                    vcDescServicio = txtvcDescServicio.Text,
                    IdSocio = _IdSocio,
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    nImporteFIn = String.IsNullOrEmpty(txtnImporteFIn.Text.Trim()) ? 0 : Convert.ToDecimal(txtnImporteFIn.Text),
                    sdFechaFin = dtsdFechaFin.Value,
                    nImporteAte = String.IsNullOrEmpty(txtnImporteAte.Text.Trim()) ? 0 : Convert.ToDecimal(txtnImporteAte.Text),
                    vcContacto = txtvcContacto.Text,
                    idcargo_tt = cboidcargo_tt.SelectedValue.ToString(),
                    telefonoanx = txttelefonoanx.Text,
                    celular = txtcelular.Text,
                    emailcorp = txtemailcorp.Text,
                    IdGestor = _IdGestor,
                };

                DataSet dsCompromisoCom = new DataSet();
                dsCompromisoCom = CompromisoComBL.ProcesarCompromisoCom(CompromisoComBE);

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
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
                DataSet dsCompromisoCom = new DataSet();
                CompromisoComBE CompromisoComBE = new CompromisoComBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdCompromiso = Codigo,
                };
                
                dsCompromisoCom = CompromisoComBL.ProcesarCompromisoCom(CompromisoComBE);
                
                if (dsCompromisoCom.Tables[0].Rows.Count > 0)
                {
                    txtRucPagadora.Text = dsCompromisoCom.Tables[0].Rows[0]["RucPagadora"].ToString();
                    txtvcPagadora.Text = dsCompromisoCom.Tables[0].Rows[0]["vcPagadora"].ToString();
                    cboidsector_tt.SelectedValue = dsCompromisoCom.Tables[0].Rows[0]["idsector_tt"].ToString();
                    txtOrigen.Text = dsCompromisoCom.Tables[0].Rows[0]["Origen"].ToString();   
                    txtnLineaDisp.Text = Convert.ToDecimal(dsCompromisoCom.Tables[0].Rows[0]["nLineaDisp"]).ToString("N2");
                    cboIdTipoSer_tt.SelectedValue = dsCompromisoCom.Tables[0].Rows[0]["IdTipoSer_tt"].ToString();
                    txtvcDescServicio.Text = dsCompromisoCom.Tables[0].Rows[0]["vcDescServicio"].ToString();
                    cboIdMoneda_tt.SelectedValue = dsCompromisoCom.Tables[0].Rows[0]["IdMoneda_tt"].ToString();
                    txtnImporteFIn.Text = Convert.ToDecimal(dsCompromisoCom.Tables[0].Rows[0]["nImporteFIn"]).ToString("N2");
                    txtnImporteAte.Text = Convert.ToDecimal(dsCompromisoCom.Tables[0].Rows[0]["nImporteAte"]).ToString("N2");
                    txtvcContacto.Text = dsCompromisoCom.Tables[0].Rows[0]["vcContacto"].ToString();
                    cboidcargo_tt.SelectedValue = dsCompromisoCom.Tables[0].Rows[0]["idcargo_tt"].ToString();
                    txttelefonoanx.Text = dsCompromisoCom.Tables[0].Rows[0]["telefonoanx"].ToString();
                    txtcelular.Text = dsCompromisoCom.Tables[0].Rows[0]["celular"].ToString();
                    txtemailcorp.Text = dsCompromisoCom.Tables[0].Rows[0]["emailcorp"].ToString();
                    
                    if (!string.IsNullOrEmpty(dsCompromisoCom.Tables[0].Rows[0]["sdFechaFin"].ToString()))
                    {
                        dtsdFechaFin.Value = Convert.ToDateTime(dsCompromisoCom.Tables[0].Rows[0]["sdFechaFin"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Este .... no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRucPagadora_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRucPagadora.Text.Trim().Length == 11)
                {
                    PagadoraBE oEntity = new PagadoraBE()
                    {
                        OPCION = 7,
                        USUARIO = General.General.GetCodigoUsuario,
                        vcRuc = txtRucPagadora.Text
                    };
                    DataSet ds = new PagadoraBL().ProcesarPagadora(oEntity);

                    if (ds.Tables[0].Rows.Count > 0)
	                {
                        IdPagadora = ds.Tables[0].Rows[0]["IdPagadora"].ToString();
                        txtvcPagadora.Text = ds.Tables[0].Rows[0]["vcPagadora"].ToString();
                        cboidsector_tt.SelectedValue = ds.Tables[0].Rows[0]["IdSector_tt"].ToString();
                        txtnLineaDisp.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["LineaDisponible"].ToString()).ToString("N2");
                        txtOrigen.Text = ds.Tables[0].Rows[0]["Tipo"].ToString();
                        txtEstadoLinea.Text = ds.Tables[0].Rows[0]["EstadoLinea"].ToString();
                        txtObservacion.Text = ds.Tables[0].Rows[0]["Observacion"].ToString();
                    }
                    else
                    {
                        txtOrigen.Text = "NRL";
                    }           
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
                Formula.Consulta.frmBusquedaPagadoraEfideTop ofrm = new Formula.Consulta.frmBusquedaPagadoraEfideTop();
                ofrm.ShowDialog();

                if (!string.IsNullOrEmpty(ofrm.NombrePagadora))
                {
                    IdPagadora = ofrm.CodigoPagadora;
                    txtRucPagadora.Text = ofrm._vcRuc;
                    txtvcPagadora.Text = ofrm.NombrePagadora;
                    cboidsector_tt.SelectedValue = ofrm._IdSector_tt;
                    txtOrigen.Text = ofrm._Tipo;
                    txtnLineaDisp.Text = ofrm._LineaDisponible.ToString("N2");
                    txtEstadoLinea.Text = ofrm._EstadoLinea;
                    txtObservacion.Text = ofrm._Observacion;

                    cboidsector_tt.Enabled = false;
                    if (txtOrigen.Text.Trim().Equals("Efide"))
                    {
                        txtvcContacto.Enabled = false;
                        txttelefonoanx.Enabled = false;
                        txtemailcorp.Enabled = false;
                        cboidcargo_tt.Enabled = false;
                        txtcelular.Enabled = false;
                    }
                    else
                    {
                        //cboIdTipoSer_tt.Enabled = true;
                        txtvcContacto.Enabled = true;
                        txttelefonoanx.Enabled = true;
                        txtemailcorp.Enabled = true;
                        cboidcargo_tt.Enabled = true;
                        txtcelular.Enabled = true;
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnImporteFIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtnImporteFIn.Text);
        }

        private void txtnImporteAte_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtnImporteAte.Text);
        }
    }
}