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
using System.Linq;

namespace EfideFactoring.Formula.Registros
{
    public partial class frmMntLineasAutorizadasDato : FormulaBase.frmMntDato
    {
        #region Variables
        SocioLineaBL SocioLineaBL = new SocioLineaBL();
        SocioLineaPagadoraBL SocioLineaPagadoraBL = new SocioLineaPagadoraBL();
        SocioLineaPagDocBL SocioLineaPagDocBL = new SocioLineaPagDocBL();
        SocioLineaPagPlazoBL SocioLineaPagPlazoBL = new SocioLineaPagPlazoBL();
        SocioLineaPagRetencionBL SocioLineaPagRetencionBL = new SocioLineaPagRetencionBL();
        SocioLineaGarantiaBL SocioLineaGarantiaBL = new SocioLineaGarantiaBL();
        PagadoraBL PagadoraBL = new PagadoraBL();
        TableBaseBL TableBaseBL = new TableBaseBL();
        private BindingList<SocioLineaPagadoraBE> LstSocioLineaPagadora = new BindingList<SocioLineaPagadoraBE>();
        private BindingList<SocioLineaPagDocBE> LstSocioLineaPagDoc = new BindingList<SocioLineaPagDocBE>();
        private BindingList<SocioLineaPagPlazoBE> LstSocioLineaPagPlazo = new BindingList<SocioLineaPagPlazoBE>();
        private BindingList<SocioLineaPagRetencionBE> LstSocioLineaPagRetencion = new BindingList<SocioLineaPagRetencionBE>();
        private BindingList<SocioLineaGarantiaBE> LstSocioLineaGarantia = new BindingList<SocioLineaGarantiaBE>();
        private List<SocioLineaPagadoraBE> LstLSocioLineaPagadora = new List<SocioLineaPagadoraBE>();
        int count = 0;
        int dgvPagadoraposicion = 0;

        #endregion
        
        #region Eventos
        public frmMntLineasAutorizadasDato()
        {
            InitializeComponent();
        }

        private void frmMntLineasAutorizadasDato_Load(object sender, EventArgs e)
        {
            LlenarCombos();
            dtRegistro.Value = DateTime.Today;
            if (Operacion.Equals("M"))
            {
                txtnImporte.Enabled = false;
                btnBusquedaSocio.Enabled = false;
                txtIdLinea.Text = Codigo.ToString();
                CargarDatos();
                CargarDocumentos();
            }
            else
            {
                DateTime dToday = DateTime.Now;
                dtRegistro.Value = dToday;
                dtVencimiento.Value = dToday.AddYears(1);
            }
        }

        private void btnBusquedaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio.ShowDialog();
                txtIdSocio.Text = ofrmBusquedaSocio.CodSocio.Trim();
                txtRazonSocialSocio.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarPagadoras_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaPagadora ofrmBusquedaPagadora = new Formula.Consulta.frmBusquedaPagadora();
                ofrmBusquedaPagadora.ShowDialog();

                if (!string.IsNullOrEmpty(ofrmBusquedaPagadora.CodigoPagadora))
                {
                    foreach (var item in LstSocioLineaPagadora)
                    {
                        if (item.IdPagadora.Equals(ofrmBusquedaPagadora.CodigoPagadora))
                        {
                            MessageBox.Show("La pagadora ya exite, seleccione otra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    DataSet ds = new DataSet();
                    PagadoraBE oEntity = new PagadoraBE();
                    oEntity.OPCION = 1;
                    oEntity.IdPagadora = ofrmBusquedaPagadora.CodigoPagadora;
                    ds = new PagadoraBL().ProcesarPagadora(oEntity);

                    string IdGestionCobranza_tt = string.Empty;
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["IdRiesgo_tt"].ToString().Equals("00006")) // Riesgo Pagador
                            {
                                IdGestionCobranza_tt = "00046"; //Gestion Cobanza Pagador
                            }
                        }
                    }


                    SocioLineaPagadoraBE oPagadoraBE = new SocioLineaPagadoraBE()
                    {
                        IdPagadora = ofrmBusquedaPagadora.CodigoPagadora,
                        vcPagadora = ofrmBusquedaPagadora.NombrePagadora,
                        IdGestionCobranza_tt = IdGestionCobranza_tt,
                    };

                      SocioLineaPagadoraBE olPagadoraBE = new SocioLineaPagadoraBE()
                    {
                        IdPagadora = ofrmBusquedaPagadora.CodigoPagadora,
                        IdGestionCobranza_tt = IdGestionCobranza_tt,
                        Confirmacionl = 1
                    };

                    LstSocioLineaPagadora.Add(oPagadoraBE);

                    dgvPagadoras.DataSource = LstSocioLineaPagadora;
                    dgvPagadoraposicion = dgvPagadoras.Rows.Count;
                    dgvPagadoras.Rows[dgvPagadoraposicion - 1].Cells["Confirmacion"].Value = 1;

                    LstLSocioLineaPagadora.Add(olPagadoraBE);
                      
                    dgvPagadoras_CellEnter(new object(), null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarDocumentos_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Registros.frmSocioLineaPagDocDato oSocioLineaPagDocDato = new Formula.Registros.frmSocioLineaPagDocDato();
                oSocioLineaPagDocDato._IdPagadora = txtIdPagadora.Text;
                oSocioLineaPagDocDato.ShowDialog();

                string varIdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();

                if (!string.IsNullOrEmpty(oSocioLineaPagDocDato._IdDocumento))
                {
                    foreach (var item in LstSocioLineaPagDoc)
                    {
                        if (item.IdPagadora.Equals(varIdPagadora) && item.IdDocumento.Equals(oSocioLineaPagDocDato._IdDocumento))
                        {
                            MessageBox.Show("El documento ya existe, ingrese otro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    SocioLineaPagDocBE oSocioLineaPagDocBE = new SocioLineaPagDocBE()
                    {
                        IdPagadora = varIdPagadora,
                        IdDocumento = oSocioLineaPagDocDato._IdDocumento,
                        vDocumento = oSocioLineaPagDocDato._vDocumento,
                        nFondoGarantia = oSocioLineaPagDocDato._FondoGarantia,
                        bInteres = oSocioLineaPagDocDato._Interes,
                        IdTipoConfirmacion = oSocioLineaPagDocDato._IdTipoConfirmacion,
                    };
                    LstSocioLineaPagDoc.Add(oSocioLineaPagDocBE);

                    BindingList<SocioLineaPagDocBE> lst = new BindingList<SocioLineaPagDocBE>();
                    foreach (var item in LstSocioLineaPagDoc)
                    {
                        if (item.IdPagadora.Equals(varIdPagadora))
                        {
                            lst.Add(item);
                        }
                    }

                    dgvDocumento.DataSource = lst;
                    dgvDocumento_CellEnter(new object(), null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarPlazos_Click(object sender, EventArgs e)
        {
            try
            {
                decimal _nPlazo = string.IsNullOrEmpty(txtnPlazo.Text.Trim()) ? 0 : Convert.ToDecimal(txtnPlazo.Text.Trim());
                decimal _nTasa = string.IsNullOrEmpty(txtnTasa.Text.Trim()) ? 0 : Convert.ToDecimal(txtnTasa.Text.Trim());
                decimal _nTasaSobregiro = string.IsNullOrEmpty(txtnTasaSobregiro.Text.Trim()) ? 0 : Convert.ToDecimal(txtnTasaSobregiro.Text.Trim());
                string varIdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                string varIdDocumento = dgvDocumento.CurrentRow.Cells["IdDocument"].Value.ToString();

                if (_nPlazo + _nTasa + _nTasaSobregiro > 0)
                {
                    SocioLineaPagPlazoBE oSocioLineaPagPlazoBE = new SocioLineaPagPlazoBE()
                    {
                        IdPagadora = varIdPagadora,
                        IdDocumento = varIdDocumento,
                        nPlazo = _nPlazo,
                        nTasa = _nTasa,
                        nTasaSobregiro = _nTasaSobregiro
                    };
                    LstSocioLineaPagPlazo.Add(oSocioLineaPagPlazoBE);

                    BindingList<SocioLineaPagPlazoBE> lst = new BindingList<SocioLineaPagPlazoBE>();
                    foreach (var item in LstSocioLineaPagPlazo)
                    {
                        if (item.IdPagadora.Equals(varIdPagadora) && item.IdDocumento.Equals(varIdDocumento))
                        {
                            lst.Add(item);
                        }
                    }

                    dgvPlazos.DataSource = lst;
                    txtnPlazo.Clear();
                    txtnTasa.Clear();
                    txtnTasaSobregiro.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarGarantia_Click(object sender, EventArgs e)
        {
            try
            {
                string varIdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                string varIdDocumento = dgvDocumento.CurrentRow.Cells["IdDocument"].Value.ToString();

                frmSocioLineaGarantia ofrmSocioLineaGarantia = new frmSocioLineaGarantia();
                ofrmSocioLineaGarantia._IdLinea = txtIdLinea.Text;
                ofrmSocioLineaGarantia._IdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                ofrmSocioLineaGarantia._IdDocumento = dgvDocumento.CurrentRow.Cells["IdDocument"].Value.ToString();
                ofrmSocioLineaGarantia.ShowDialog();

                if (ofrmSocioLineaGarantia.IsLoadDocument == 1)
                {
                    foreach (var item in LstSocioLineaGarantia)
                    {
                        if (item.IdPagadora.Equals(ofrmSocioLineaGarantia._LstSocioLineaGarantia[0].IdPagadora) && item.IdDocumento.Equals(ofrmSocioLineaGarantia._LstSocioLineaGarantia[0].IdDocumento) &&
                            item.IdTipo_Documento_tt.Equals(ofrmSocioLineaGarantia._LstSocioLineaGarantia[0].IdTipo_Documento_tt))
                        {
                            MessageBox.Show("El tipo de documento ya existe, debe seleccionar otro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }  
                    }

                    LstSocioLineaGarantia.Add(ofrmSocioLineaGarantia._LstSocioLineaGarantia[0]);
                }

                BindingList<SocioLineaGarantiaBE> lst = new BindingList<SocioLineaGarantiaBE>();
                foreach (var item in LstSocioLineaGarantia)
                {
                    if (item.IdPagadora.Equals(varIdPagadora) && item.IdDocumento.Equals(varIdDocumento))
                    {
                        lst.Add(item);
                    }
                }

                dgvSocioLineaGarantia.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarPagadora_Click(object sender, EventArgs e)
        {
            if (dgvPagadoras.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Está Ud. seguro de eliminar la Pagadora " + dgvPagadoras.CurrentRow.Cells["vcPagadora"].Value.ToString().Trim() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    string varIdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();

                    // Retencion
                    BindingList<SocioLineaPagRetencionBE> LstSocioLineaPagRetencionBk = new BindingList<SocioLineaPagRetencionBE>();
                    foreach (var item in LstSocioLineaPagRetencion)
                    {
                        LstSocioLineaPagRetencionBk.Add(item);
                    }

                    foreach (var item in LstSocioLineaPagRetencion)
                    {
                        if (item.IdPagadora == varIdPagadora)
                        {
                            LstSocioLineaPagRetencionBk.Remove(item);
                        }
                    }
                    LstSocioLineaPagRetencion = LstSocioLineaPagRetencionBk;

                    // Plazos y Tasas
                    BindingList<SocioLineaPagPlazoBE> LstSocioLineaPagPlazoBk = new BindingList<SocioLineaPagPlazoBE>();
                    foreach (var item in LstSocioLineaPagPlazo)
                    {
                        LstSocioLineaPagPlazoBk.Add(item);
                    }

                    foreach (var item in LstSocioLineaPagPlazo)
                    {
                        if (item.IdPagadora == varIdPagadora)
                        {
                            LstSocioLineaPagPlazoBk.Remove(item);
                        }
                    }
                    LstSocioLineaPagPlazo = LstSocioLineaPagPlazoBk;

                    //Documentos
                    BindingList<SocioLineaPagDocBE> LstSocioLineaPagDocBk = new BindingList<SocioLineaPagDocBE>();
                    foreach (var item in LstSocioLineaPagDoc)
                    {
                        LstSocioLineaPagDocBk.Add(item);
                    }

                    foreach (var item in LstSocioLineaPagDoc)
                    {
                        if (item.IdPagadora == varIdPagadora)
                        {
                            LstSocioLineaPagDocBk.Remove(item);
                        }
                    }
                    LstSocioLineaPagDoc = LstSocioLineaPagDocBk;

                    //Pagadoras
                    foreach (var item in LstSocioLineaPagadora)
                    {
                        if (item.IdPagadora == varIdPagadora)
                        {
                            LstSocioLineaPagadora.Remove(item);
                            LstLSocioLineaPagadora.Remove(item);
                            break;
                        }
                        
                    }

                    dgvPagadoras.DataSource = LstSocioLineaPagadora;
                    dgvPagadoras.Refresh();

                    if (dgvPagadoras.Rows.Count > 0)
                    {
                        dgvPagadoras.Columns["IdPagadora"].DisplayIndex = 0;
                        dgvPagadoras_CellEnter(new object(), null);
                    }
                    else
                    {
                        txtIdPagadora.Clear();
                        txtvcPagadora.Clear();
                        txtPagadoraDsc_TD.Clear();
                        //txtPagadora_PT.Clear();
                        //txtDocumento_Dsc_PT.Clear();
                        //TabPlazosTasa.Enabled = false;
                        TabTipoDocumentos.Enabled = false;

                        BindingList<SocioLineaPagPlazoBE> lstPlazo = new BindingList<SocioLineaPagPlazoBE>();
                        dgvPlazos.DataSource = lstPlazo;

                        BindingList<SocioLineaPagDocBE> lstDocumentos = new BindingList<SocioLineaPagDocBE>();
                        dgvDocumento.DataSource = lstDocumentos;
                    }
                }
            }
        }
        private void btnEliminarDocumento_Click(object sender, EventArgs e)
        {
            if (dgvDocumento.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Está Ud. seguro de eliminar el documento " + dgvDocumento.CurrentRow.Cells["vDocumento"].Value.ToString().Trim() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string varIdPagadora = dgvDocumento.CurrentRow.Cells["IdPagadoraTD"].Value.ToString();
                    string varIdDocumento = dgvDocumento.CurrentRow.Cells["IdDocument"].Value.ToString();

                    //Retencion
                    BindingList<SocioLineaPagRetencionBE> LstSocioLineaPagRetencionBk = new BindingList<SocioLineaPagRetencionBE>();
                    foreach (var item in LstSocioLineaPagRetencion)
                    {
                        LstSocioLineaPagRetencionBk.Add(item);
                    }

                    foreach (var item in LstSocioLineaPagRetencion)
                    {
                        if (item.IdPagadora == varIdPagadora &&
                            item.IdDocumento == varIdDocumento)
                        {
                            LstSocioLineaPagRetencionBk.Remove(item);
                        }
                    }
                    LstSocioLineaPagRetencion = LstSocioLineaPagRetencionBk;

                    //Plazos y Tasas
                    BindingList<SocioLineaPagPlazoBE> LstSocioLineaPagPlazoBk = new BindingList<SocioLineaPagPlazoBE>();
                    foreach (var item in LstSocioLineaPagPlazo)
                    {
                        LstSocioLineaPagPlazoBk.Add(item);    
                    }

                    foreach (var item in LstSocioLineaPagPlazo)
                    {
                        if (item.IdPagadora == varIdPagadora &&
                            item.IdDocumento == varIdDocumento)
                        {
                            LstSocioLineaPagPlazoBk.Remove(item);
                        }
                    }
                    LstSocioLineaPagPlazo = LstSocioLineaPagPlazoBk;

                    //Documentos
                    foreach (var item in LstSocioLineaPagDoc)
                    {
                        if (item.IdPagadora == varIdPagadora &&
                            item.IdDocumento == varIdDocumento)
                        {
                            LstSocioLineaPagDoc.Remove(item);
                            break;
                        }
                    }

                    BindingList<SocioLineaPagDocBE> lst = new BindingList<SocioLineaPagDocBE>();
                    foreach (var item in LstSocioLineaPagDoc)
                    {
                        if (item.IdPagadora.Equals(varIdPagadora))
                        {
                            lst.Add(item);
                        }
                    }

                    dgvDocumento.DataSource = lst;

                    if (dgvDocumento.Rows.Count > 0)
                    {
                        dgvDocumento.Columns["IdDocument"].DisplayIndex = 0;
                        dgvDocumento_CellEnter(new object(), null);
                    }
                    else
                    {
                        //txtPagadora_PT.Clear();
                        //txtDocumento_Dsc_PT.Clear();
                        //TabPlazosTasa.Enabled = false;

                        BindingList<SocioLineaPagPlazoBE> lstPlazo = new BindingList<SocioLineaPagPlazoBE>();
                        dgvPlazos.DataSource = lstPlazo;
                    }
                }
            }
        }
        private void btnEliminarPlazos_Click(object sender, EventArgs e)
        {
            if (dgvPlazos.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Está Ud. seguro de eliminar el registro seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (var item in LstSocioLineaPagPlazo)
                    {
                        if (item.nPlazo == Decimal.Parse(dgvPlazos.CurrentRow.Cells["nPlazo"].Value.ToString()) &&
                            item.nTasa == Decimal.Parse(dgvPlazos.CurrentRow.Cells["nTasa"].Value.ToString()) &&
                            item.nTasaSobregiro == Decimal.Parse(dgvPlazos.CurrentRow.Cells["nTasaSobregiro"].Value.ToString()) &&
                            item.IdPagadora == dgvPlazos.CurrentRow.Cells["IdPagadora_Plazo"].Value.ToString() &&
                            item.IdDocumento == dgvPlazos.CurrentRow.Cells["IdDocumento_Plazo"].Value.ToString())
                        {
                            LstSocioLineaPagPlazo.Remove(item);
                            break;
                        }
                    }

                    string varIdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                    string varIdDocumento = dgvDocumento.CurrentRow.Cells["IdDocument"].Value.ToString();

                    BindingList<SocioLineaPagPlazoBE> lst = new BindingList<SocioLineaPagPlazoBE>();
                    foreach (var item in LstSocioLineaPagPlazo)
                    {
                        if (item.IdPagadora.Equals(varIdPagadora) && item.IdDocumento.Equals(varIdDocumento))
                        {
                            lst.Add(item);
                        }
                    }

                    dgvPlazos.DataSource = lst;
                }
            }
        }
        private void btnQuitarGarantia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPlazos.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Está Ud. seguro de eliminar el registro seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        foreach (var item in LstSocioLineaGarantia)
                        {
                            if (item.IdLinea == dgvPlazos.CurrentRow.Cells["IdLinea_D"].Value.ToString() &&
                                item.IdPagadora == dgvPlazos.CurrentRow.Cells["_IdPagadora"].Value.ToString() &&
                                item.IdDocumento == dgvPlazos.CurrentRow.Cells["IdDocumento"].Value.ToString() &&
                                item.IdTipo_Documento_tt == dgvPlazos.CurrentRow.Cells["IdTipo_Documento_tt"].Value.ToString()) 
                            {
                                LstSocioLineaGarantia.Remove(item);
                                break;
                            }
                        }

                        string varIdDocumento = dgvDocumento.CurrentRow.Cells["IdDocument"].Value.ToString();
                        string varIdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();

                        BindingList<SocioLineaPagPlazoBE> lst = new BindingList<SocioLineaPagPlazoBE>();
                        foreach (var item in LstSocioLineaPagPlazo)
                        {
                            if (item.IdPagadora.Equals(varIdPagadora) && item.IdDocumento.Equals(varIdDocumento))
                            {
                                lst.Add(item);
                            }
                        }
                        dgvSocioLineaGarantia.DataSource = lst;
                    }
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
                if (string.IsNullOrEmpty(txtIdSocio.Text))
                {
                    MessageBox.Show("Se debe Ingresar un Socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(cboIdTipoLinea_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un tipo de línea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(dtVencimiento.Text))
                {
                    MessageBox.Show("Ingresar una fecha de vencimiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(cboIdMoneda_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar una Moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Convert.ToDecimal(txtnImporte.Text) == 0)
                {
                    MessageBox.Show("Ingresar un Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (LstSocioLineaPagadora.Where(p => p.IdGestionCobranza_tt == string.Empty).Count() > 0)
                {
                    MessageBox.Show("Debe configurar la gestión de cobranza para las pagadoras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                bool IsError = false;
                foreach (var item in LstSocioLineaPagDoc)
                {
                    if (LstSocioLineaPagPlazo.Where(p => p.IdPagadora == item.IdPagadora && p.IdDocumento == item.IdDocumento).Count() == 0)
                    {
                        IsError = true;
                    }
                }

                if (IsError)
                {
                    MessageBox.Show("Por favor, verificar las tasas y plazos de los documentos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                /* Grabar la Cabecera */
                SocioLineaBE SocioLineaBE = new SocioLineaBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdLinea = txtIdLinea.Text,
                    IdSocio = txtIdSocio.Text,
                    IdTipoLinea_tt = cboIdTipoLinea_tt.SelectedValue.ToString(),
                    dtRegistro = dtRegistro.Value,
                    dtVencimiento = dtVencimiento.Value,
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    nImporte = String.IsNullOrEmpty(txtnImporte.Text.Trim()) ? 0 : Convert.ToDecimal(txtnImporte.Text),
                    nUtilizado = 0,
                };

                DataSet ds = new DataSet();
                ds = SocioLineaBL.ProcesarSocioLinea(SocioLineaBE);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    var idLinea = ds.Tables[0].Rows[0]["IdLinea"].ToString();
                    //Eliminamos
                    SocioLineaPagadoraBE oSocioLineaPagadoraBE = new SocioLineaPagadoraBE()
                    {
                        USUARIO =  General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdLinea = idLinea,
                    };
                    SocioLineaPagadoraBL.ProcesarSocioLineaPagadora(oSocioLineaPagadoraBE);

                    SocioLineaPagDocBE oSocioLineaPagDocBE = new SocioLineaPagDocBE()
                    {
                        USUARIO = General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdLinea = idLinea,
                    };
                    SocioLineaPagDocBL.ProcesarSocioLineaPagDoc(oSocioLineaPagDocBE);

                    SocioLineaPagPlazoBE oSocioLineaPagPlazoBE = new SocioLineaPagPlazoBE()
                    {
                        USUARIO = General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdLinea = idLinea,
                    };
                    SocioLineaPagPlazoBL.ProcesarSocioLineaPagPlazo(oSocioLineaPagPlazoBE);

                    SocioLineaPagRetencionBE oSocioLineaPagRetencionBE = new SocioLineaPagRetencionBE()
                    {
                        USUARIO = General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdLinea = idLinea,
                    };
                    SocioLineaPagRetencionBL.ProcesarSocioLineaPagRetencion(oSocioLineaPagRetencionBE);

                    SocioLineaGarantiaBE oSocioLineaGarantiaBE = new SocioLineaGarantiaBE()
                    {
                        USUARIO = General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdLinea = idLinea,
                    };
                    SocioLineaGarantiaBL.ProcesarSocioLineaGarantia(oSocioLineaGarantiaBE);

                    /* Grabamos Pagadoras */
                    foreach (var item in LstSocioLineaPagadora)
                    {
                        item.USUARIO = General.General.GetCodigoUsuario;
                        item.OPCION = 2;
                        item.IdLinea = idLinea;
                        item.Confirmacionl = LstLSocioLineaPagadora.Find(i => i.IdPagadora == item.IdPagadora).Confirmacionl;
                        SocioLineaPagadoraBL.ProcesarSocioLineaPagadora(item);
                    }

                    /* Documentos */
                    foreach (var item in LstSocioLineaPagDoc)
                    {
                        item.USUARIO = General.General.GetCodigoUsuario;
                        item.OPCION = 2;
                        item.IdLinea = idLinea;
                        SocioLineaPagDocBL.ProcesarSocioLineaPagDoc(item);
                    }

                    /* Plazos */
                    foreach (var item in LstSocioLineaPagPlazo)
                    {
                        item.USUARIO = General.General.GetCodigoUsuario;
                        item.OPCION = 2;
                        item.IdLinea = idLinea;
                        SocioLineaPagPlazoBL.ProcesarSocioLineaPagPlazo(item);
                    }

                    /* Retenciones */
                    foreach (var item in LstSocioLineaPagRetencion)
                    {
                        item.USUARIO = General.General.GetCodigoUsuario;
                        item.OPCION = 2;
                        item.IdLinea = idLinea;
                        SocioLineaPagRetencionBL.ProcesarSocioLineaPagRetencion(item);
                    }

                    /* Documentos */
                    foreach (var item in LstSocioLineaGarantia)
                    {
                        item.USUARIO = General.General.GetCodigoUsuario;
                        item.OPCION = 2;
                        item.IdLinea = idLinea;
                        SocioLineaGarantiaBL.ProcesarSocioLineaGarantia(item);
                    }

                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
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
        #endregion

        #region Metodos
        private void LlenarCombos()
        {
            try
            {
                String Table_Id = "00042";
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdTipoLinea_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00035";
                General.General.LlenarCombobox(cboIdMoneda_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                LlenarComboGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarComboGrid()
        {
            try
            {
                String Table_Id = "00044";
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                DataGridViewComboBoxColumn cboColumn = dgvPagadoras.Columns["IdGestionCobranza_tt"] as DataGridViewComboBoxColumn;
                DataTable dt = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                DataRow dr;
                dr = dt.NewRow();
                dr["Table_Name"] = "--Seleccionar--";
                dr["Table_Id"] = "";
                dt.Rows.InsertAt(dr, 0);

                cboColumn.DataSource = dt;
                cboColumn.DisplayMember = "Table_Name";
                cboColumn.ValueMember = "Table_Id";

                DataGridViewComboBoxColumn cboColumnConfirmacion = dgvDocumento.Columns["IdTipoConfirmacion"] as DataGridViewComboBoxColumn;
                TableBaseBE.Table_Parent_Id = System.Configuration.ConfigurationManager.AppSettings["TbTipoConfirmacion"].ToString(); //Tipo Confirmacion
                DataTable dt1 = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                DataRow dr1;
                dr1 = dt1.NewRow();
                dr1["Table_Name"] = "--Seleccionar--";
                dr1["Table_Id"] = "";
                dt1.Rows.InsertAt(dr1, 0);

                cboColumnConfirmacion.DataSource = dt1;
                cboColumnConfirmacion.DisplayMember = "Table_Name";
                cboColumnConfirmacion.ValueMember = "Table_Id";
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
                /* Cargando los datos de la Linea */
                DataSet dsLinea = new DataSet();
                SocioLineaBE SocioLineaBE = new SocioLineaBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLinea = txtIdLinea.Text
                };

                dsLinea = SocioLineaBL.ProcesarSocioLinea(SocioLineaBE);

                if (dsLinea.Tables[0].Rows.Count > 0)
                {
                    txtIdSocio.Text = dsLinea.Tables[0].Rows[0]["IdSocio"].ToString();
                    txtRazonSocialSocio.Text = dsLinea.Tables[0].Rows[0]["IdSocio_Dsc"].ToString();
                    cboIdTipoLinea_tt.SelectedValue = dsLinea.Tables[0].Rows[0]["IdTipoLinea_tt"].ToString();
                    dtRegistro.Value = Convert.ToDateTime(dsLinea.Tables[0].Rows[0]["dtRegistro"].ToString());
                    dtVencimiento.Value = Convert.ToDateTime(dsLinea.Tables[0].Rows[0]["dtVencimiento"].ToString());
                    cboIdMoneda_tt.SelectedValue = dsLinea.Tables[0].Rows[0]["IdMoneda_tt"].ToString();
                    txtnImporte.Text = Convert.ToDecimal(dsLinea.Tables[0].Rows[0]["nImporte"]).ToString("N2");
                    txtvCodigoAnexo.Text = dsLinea.Tables[0].Rows[0]["vCodigoAnexo"].ToString();
                }

                /* Cargando los Detalles */
               
                DataSet dsPagadoras = new DataSet();
             
                
                SocioLineaPagadoraBE SocioLineaPagadoraBE = new SocioLineaPagadoraBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLinea = txtIdLinea.Text
                };
                dsPagadoras = SocioLineaPagadoraBL.ProcesarSocioLineaPagadora(SocioLineaPagadoraBE);

                if (dsPagadoras.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dsPagadoras.Tables[0].Rows.Count; i++)
                    {

                        SocioLineaPagadoraBE oPagadoraBE = new SocioLineaPagadoraBE()
                        {
                            IdPagadora = dsPagadoras.Tables[0].Rows[i]["IdPagadora"].ToString(),
                            vcPagadora = dsPagadoras.Tables[0].Rows[i]["vcPagadora"].ToString(),
                            IdGestionCobranza_tt = dsPagadoras.Tables[0].Rows[i]["IdGestionCobranza_tt"].ToString(),
                          
                        };
                        SocioLineaPagadoraBE oPagadoraLBE = new SocioLineaPagadoraBE()
                        {
                            IdPagadora = dsPagadoras.Tables[0].Rows[i]["IdPagadora"].ToString(),
                            Confirmacionl = Convert.ToInt32(dsPagadoras.Tables[0].Rows[i]["Confirmacion"])
                        };

                        LstSocioLineaPagadora.Add(oPagadoraBE);
                      
                        LstLSocioLineaPagadora.Add(oPagadoraLBE);
                    }

                    dgvPagadoras.DataSource = LstSocioLineaPagadora;
                  

                    foreach (DataGridViewRow row in dgvPagadoras.Rows)
                    {

                        row.Cells["Confirmacion"].Value = LstLSocioLineaPagadora[count].Confirmacionl;
                        count++;
                    }

                    dgvPagadoras.Columns["Confirmacionl"].Visible = false;

                    dgvPagadoras.Refresh();
                }

                DataSet dsDocumento = new DataSet();
                SocioLineaPagDocBE SocioLineaPagDocBE = new SocioLineaPagDocBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLinea = txtIdLinea.Text
                };
                dsDocumento = SocioLineaPagDocBL.ProcesarSocioLineaPagDoc(SocioLineaPagDocBE);

                if (dsDocumento.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dsDocumento.Tables[0].Rows.Count; i++)
                    {
                        SocioLineaPagDocBE oSocioLineaPagDocBE = new SocioLineaPagDocBE()
                        {
                            IdPagadora = dsDocumento.Tables[0].Rows[i]["IdPagadora"].ToString(),
                            IdDocumento = dsDocumento.Tables[0].Rows[i]["IdDocumento"].ToString(),
                            vDocumento = dsDocumento.Tables[0].Rows[i]["vDocumento"].ToString(),
                            nFondoGarantia = Decimal.Parse(dsDocumento.Tables[0].Rows[i]["nFondoGarantia"].ToString()),
                            bInteres = bool.Parse(dsDocumento.Tables[0].Rows[i]["bInteres"].ToString()),
                            IdTipoConfirmacion = dsDocumento.Tables[0].Rows[i]["IdTipoConfirmacion"].ToString(),
                        };
                        LstSocioLineaPagDoc.Add(oSocioLineaPagDocBE);
                    }
                }
                //dgvDocumento.DataSource = LstSocioLineaPagDoc;
                

                DataSet dsPlazo = new DataSet();
                SocioLineaPagPlazoBE SocioLineaPagPlazoBE = new SocioLineaPagPlazoBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLinea = txtIdLinea.Text
                };
                dsPlazo = SocioLineaPagPlazoBL.ProcesarSocioLineaPagPlazo(SocioLineaPagPlazoBE);

                if (dsPlazo.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dsPlazo.Tables[0].Rows.Count; i++)
                    {
                        SocioLineaPagPlazoBE oSocioLineaPagPlazoBE = new SocioLineaPagPlazoBE()
                        {
                            IdItem = dsPlazo.Tables[0].Rows[i]["IdItem"].ToString(),
                            IdPagadora = dsPlazo.Tables[0].Rows[i]["IdPagadora"].ToString(),
                            IdDocumento = dsPlazo.Tables[0].Rows[i]["IdDocumento"].ToString(),
                            nPlazo = Decimal.Parse(dsPlazo.Tables[0].Rows[i]["nPlazo"].ToString()),
                            nTasa = Decimal.Parse(dsPlazo.Tables[0].Rows[i]["nTasa"].ToString()),
                            nTasaSobregiro = Decimal.Parse(dsPlazo.Tables[0].Rows[i]["nTasaSobregiro"].ToString())
                        };
                        LstSocioLineaPagPlazo.Add(oSocioLineaPagPlazoBE);
                    }
                }

                DataSet dsRetencion = new DataSet();
                SocioLineaPagRetencionBE SocioLineaPagRetencionBE = new SocioLineaPagRetencionBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLinea = txtIdLinea.Text
                };
                dsRetencion = SocioLineaPagRetencionBL.ProcesarSocioLineaPagRetencion(SocioLineaPagRetencionBE);

                if (dsRetencion.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dsRetencion.Tables[0].Rows.Count; i++)
                    {
                        SocioLineaPagRetencionBE oSocioLineaPagRetencionBE = new SocioLineaPagRetencionBE()
                        {
                            IdItem = dsRetencion.Tables[0].Rows[i]["IdItem"].ToString(),
                            IdPagadora = dsRetencion.Tables[0].Rows[i]["IdPagadora"].ToString(),
                            IdDocumento = dsRetencion.Tables[0].Rows[i]["IdDocumento"].ToString(),
                            nRetencion = Decimal.Parse(dsRetencion.Tables[0].Rows[i]["nRetencion"].ToString())
                        };
                        LstSocioLineaPagRetencion.Add(oSocioLineaPagRetencionBE);
                    }
                }

                if (dgvPagadoras.Rows.Count > 0)
                {
                    dgvPagadoras.Columns["IdPagadora"].DisplayIndex = 0;
                    //dgvPagadoras_CellContentClick(new object(), null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarDocumentos()
        {
            try
            {
                DataSet ds = new DataSet();
                SocioLineaGarantiaBE SocioLineaGarantiaBE = new SocioLineaGarantiaBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdLinea = txtIdLinea.Text
                };
                ds = SocioLineaGarantiaBL.ProcesarSocioLineaGarantia(SocioLineaGarantiaBE);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        SocioLineaGarantiaBE oSocioLineaGarantiaBE = new SocioLineaGarantiaBE()
                        {
                            IdLinea = ds.Tables[0].Rows[i]["IdLinea"].ToString(),
                            IdPagadora = ds.Tables[0].Rows[i]["IdPagadora"].ToString(),
                            IdDocumento = ds.Tables[0].Rows[i]["IdDocumento"].ToString(),
                            IdTipo_Documento_tt = ds.Tables[0].Rows[i]["IdTipo_Documento_tt"].ToString(),
                            IdTipo_Documento_tt_Dsc = ds.Tables[0].Rows[i]["IdTipo_Documento_tt_Dsc"].ToString(),
                            Documento = ds.Tables[0].Rows[i]["Documento"].ToString(),
                            Archivo = (byte[])ds.Tables[0].Rows[i]["Archivo"],
                            files = ds.Tables[0].Rows[i]["files"].ToString(),
                        };
                        LstSocioLineaGarantia.Add(oSocioLineaGarantiaBE);

                    }
                }
                dgvPagadoras_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        #endregion

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntLineasAutorizadasLog ofrmMntLineasAutorizadasLog = new frmMntLineasAutorizadasLog();
                ofrmMntLineasAutorizadasLog.pIdLinea = txtIdLinea.Text;
                ofrmMntLineasAutorizadasLog.pIdSocio_Dsc = txtRazonSocialSocio.Text;
                ofrmMntLineasAutorizadasLog.pnImporte = txtnImporte.Text;
                ofrmMntLineasAutorizadasLog.pIdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString();
                ofrmMntLineasAutorizadasLog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtnPlazo.Text);
        }

        private void txtnTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtnTasa.Text);
        }

        private void txtnTasaSobregiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtnTasaSobregiro.Text);
        }

        private void btnIncrementa_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(txtIdLinea.Text.Trim()))
            {
                MessageBox.Show("Guardar cambios antes de realizar esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Formula.Registros.frmMntLineaControl ofrmMntLineaControl = new Formula.Registros.frmMntLineaControl();
            ofrmMntLineaControl.IdLinea = txtIdLinea.Text;
            ofrmMntLineaControl.TipoOperacion = "I";
            ofrmMntLineaControl.ShowDialog();
            CargarCabecera();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(txtIdLinea.Text.Trim()))
            {
                MessageBox.Show("Guardar cambios antes de realizar esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Formula.Registros.frmMntLineaControl ofrmMntLineaControl = new Formula.Registros.frmMntLineaControl();
            ofrmMntLineaControl.IdLinea = txtIdLinea.Text;
            ofrmMntLineaControl.TipoOperacion = "R";
            ofrmMntLineaControl.ShowDialog();
            CargarCabecera();
        }

        private void CargarCabecera()
        {
            try
            {
                /* Cargando los datos de la Linea */
                DataSet dsLinea = new DataSet();
                SocioLineaBE SocioLineaBE = new SocioLineaBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLinea = txtIdLinea.Text
                };

                dsLinea = SocioLineaBL.ProcesarSocioLinea(SocioLineaBE);

                if (dsLinea.Tables[0].Rows.Count > 0)
                {
                    txtIdSocio.Text = dsLinea.Tables[0].Rows[0]["IdSocio"].ToString();
                    txtRazonSocialSocio.Text = dsLinea.Tables[0].Rows[0]["IdSocio_Dsc"].ToString();
                    cboIdTipoLinea_tt.SelectedValue = dsLinea.Tables[0].Rows[0]["IdTipoLinea_tt"].ToString();
                    dtRegistro.Value = Convert.ToDateTime(dsLinea.Tables[0].Rows[0]["dtRegistro"].ToString());
                    dtVencimiento.Value = Convert.ToDateTime(dsLinea.Tables[0].Rows[0]["dtVencimiento"].ToString());
                    cboIdMoneda_tt.SelectedValue = dsLinea.Tables[0].Rows[0]["IdMoneda_tt"].ToString();
                    txtnImporte.Text = Convert.ToDecimal(dsLinea.Tables[0].Rows[0]["nImporte"]).ToString("N2");
                    txtvCodigoAnexo.Text = dsLinea.Tables[0].Rows[0]["vCodigoAnexo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocumento_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string varIdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                string varIdDocumento = dgvDocumento.CurrentRow.Cells["IdDocument"].Value.ToString();
                //txtPagadora_PT.Text = dgvPagadoras.CurrentRow.Cells["vcPagadora"].Value.ToString();
                //txtDocumento_Dsc_PT.Text = dgvDocumento.CurrentRow.Cells["vDocumento"].Value.ToString();
                //TabPlazosTasa.Enabled = true;

                BindingList<SocioLineaGarantiaBE> lstSocioLineaGarantia = new BindingList<SocioLineaGarantiaBE>();
                foreach (var item in LstSocioLineaGarantia)
                {
                    if (item.IdPagadora.Equals(varIdPagadora) && item.IdDocumento.Equals(varIdDocumento))
                    {
                        lstSocioLineaGarantia.Add(item);
                    }
                }
                dgvSocioLineaGarantia.DataSource = lstSocioLineaGarantia;

                BindingList<SocioLineaPagPlazoBE> lstPlazo = new BindingList<SocioLineaPagPlazoBE>();
                foreach (var item in LstSocioLineaPagPlazo)
                {
                    if (item.IdPagadora.Equals(varIdPagadora) && item.IdDocumento.Equals(varIdDocumento))
                    {
                        lstPlazo.Add(item);
                    }
                }
                dgvPlazos.DataSource = lstPlazo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSocioLineaGarantia_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) { return; }
                if (dgvSocioLineaGarantia.Columns[e.ColumnIndex].Name == "files")
                {
                    if (dgvSocioLineaGarantia.CurrentRow.Cells["files"].Value.ToString().Equals("Ver Archivo"))
                    {
                        string filename = "xx.pdf";
                        var tempFolder = System.IO.Path.GetTempPath();
                        filename = System.IO.Path.Combine(tempFolder, filename);
                        System.IO.File.WriteAllBytes(filename, (byte[])dgvSocioLineaGarantia.CurrentRow.Cells["Archivo"].Value);
                        System.Diagnostics.Process.Start(filename);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPagadoras_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BindingList<SocioLineaPagPlazoBE> lstPlazo = new BindingList<SocioLineaPagPlazoBE>();
                BindingList<SocioLineaGarantiaBE> lstSocioLineaGarantia = new BindingList<SocioLineaGarantiaBE>();

                if (dgvPagadoras.RowCount > 0)
                {
                    var _IdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                    var _vcPagadora = dgvPagadoras.CurrentRow.Cells["vcPagadora"].Value.ToString();
                    txtIdPagadora.Text = _IdPagadora.Trim();
                    txtvcPagadora.Text = _vcPagadora.Trim();

                    BindingList<SocioLineaPagDocBE> lst = new BindingList<SocioLineaPagDocBE>();
                    foreach (var item in LstSocioLineaPagDoc)
                    {
                        if (item.IdPagadora.Equals(_IdPagadora))
                        {
                            lst.Add(item);
                        }
                    }

                    dgvDocumento.DataSource = lst;
                    dgvDocumento.Refresh();

                    if (lst.Count > 0)
                    {
                        //TabPlazosTasa.Enabled = true;
                        //dgvDocumento.Columns["IdDocument"].DisplayIndex = 0;
                        string varIdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                        string varIdDocumento = lst[0].IdDocumento; //dgvDocumento.CurrentRow.Cells["IdDocument"].Value.ToString();
                        //txtPagadora_PT.Text = dgvPagadoras.CurrentRow.Cells["vcPagadora"].Value.ToString();
                        //txtDocumento_Dsc_PT.Text = lst[0].vDocumento; //dgvDocumento.CurrentRow.Cells["vDocumento"].Value.ToString();

                        foreach (var item in LstSocioLineaPagPlazo)
                        {
                            if (item.IdPagadora.Equals(_IdPagadora) && item.IdDocumento.Equals(varIdDocumento))
                            {
                                lstPlazo.Add(item);
                            }
                        }
                        dgvPlazos.DataSource = lstPlazo;

                        foreach (var item in LstSocioLineaGarantia)
                        {
                            if (item.IdPagadora.Equals(varIdPagadora) && item.IdDocumento.Equals(varIdDocumento))
                            {
                                lstSocioLineaGarantia.Add(item);
                            }
                        }
                        dgvSocioLineaGarantia.DataSource = lstSocioLineaGarantia;

                    }
                    else
                    {
                        dgvPlazos.DataSource = lstPlazo;
                        dgvSocioLineaGarantia.DataSource = lstSocioLineaGarantia;
                        //TabPlazosTasa.Enabled = false;
                        //txtPagadora_PT.Clear();
                        //txtDocumento_Dsc_PT.Clear();
                    }
                    txtPagadoraDsc_TD.Text = _vcPagadora.Trim();
                    TabTipoDocumentos.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvPagadoras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
	        {	        
		
                if (e.ColumnIndex == 1 && e.RowIndex >= 0)
                {
                    this.dgvPagadoras.CommitEdit(DataGridViewDataErrorContexts.Commit);

                    //Check the value of cell
                    if ((bool)this.dgvPagadoras.CurrentCell.Value == true)
                    {

                        LstLSocioLineaPagadora[e.RowIndex].Confirmacionl = 1;

                    }
                    else
                    {
                        LstLSocioLineaPagadora[e.RowIndex].Confirmacionl = 0;
                    }
                }
            }
               catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}