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
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace EfideFactoring.Formula.Renovacion
{
    public partial class frmRenovacionDato : FormulaBase.frmMntDato
    {
        BindingList<RenovacionDetBE> LstRenovacionDet = new BindingList<RenovacionDetBE>();
        string Tipo = "P";
        TableBaseBL TableBaseBL = new TableBaseBL();
        PagadoraBL PagadoraBL = new PagadoraBL();
        DetaLoteBL DetaLoteBL = new DetaLoteBL();
        RenovacionBL RenovacionBL = new RenovacionBL();
        RenovacionDetBL RenovacionDetBL = new RenovacionDetBL();

        public frmRenovacionDato()
        {
            InitializeComponent();
        }

        private void frmRenovacionDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                if (Operacion.Equals("N"))
                {
                    btnBusquedaPagadora.Enabled = true;
                    dtRenovacion.Value = DateTime.Now;
                }
                else if (Operacion.Equals("M"))
                {
                    rdbPagadora.Enabled = false;
                    rdbSocio.Enabled = false;
                    btnBusquedaSocio.Enabled = false;
                    btnBusquedaPagadora.Enabled = false;
                    cboIdMoneda_tt.Enabled = false;
                    dtRenovacion.Enabled = true;
                    txtIdRenovacion.Text = Codigo;
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
                String Table_Id = "00035"; //Moneda
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdMoneda_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
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
                DataSet dsRenovacion = new DataSet();
                RenovacionBE RenovacionBE = new RenovacionBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    gSesionID = General.General.gSesionID,
                    gPlazaID = General.General.gPlazaID,
                    gFechaOp = General.General.gFechaOp,
                    IdRenovacion = txtIdRenovacion.Text.Trim()
                };

                dsRenovacion = RenovacionBL.ProcesarRenovacion(RenovacionBE);

                if (dsRenovacion.Tables[0].Rows.Count > 0)
                {
                    string IdEstado_tt = dsRenovacion.Tables[0].Rows[0]["IdEstado_tt"].ToString();
                    cboIdMoneda_tt.SelectedValue = dsRenovacion.Tables[0].Rows[0]["IdMoneda_tt"].ToString();
                    dtRenovacion.Value = !String.IsNullOrEmpty(dsRenovacion.Tables[0].Rows[0]["dtRenovacion"].ToString()) ? Convert.ToDateTime(dsRenovacion.Tables[0].Rows[0]["dtRenovacion"]) : Convert.ToDateTime("01/01/1900");
                    if (dsRenovacion.Tables[0].Rows[0]["TipoRenovacion"].ToString().Equals("P"))
                    {
                        rdbPagadora.Checked = true;
                        txtIdPagadora.Text = dsRenovacion.Tables[0].Rows[0]["Entidad_Id"].ToString();
                        txtIdPagadora_Dsc.Text = dsRenovacion.Tables[0].Rows[0]["Entidad"].ToString();
                    }
                    else
                    {
                        rdbSocio.Checked = true;
                        txtIdSocio.Text = dsRenovacion.Tables[0].Rows[0]["Entidad_Id"].ToString();
                        txtIdSocio_Dsc.Text = dsRenovacion.Tables[0].Rows[0]["Entidad"].ToString();
                    }

                    DataSet dsDet = new DataSet();
                    RenovacionDetBE RenovacionDetBE = new RenovacionDetBE()
                    {
                        OPCION = 1,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdRenovacion = txtIdRenovacion.Text,
                    };
                    dsDet = RenovacionDetBL.ProcesarRenovacionDet(RenovacionDetBE);
                    if (dsDet.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < dsDet.Tables[0].Rows.Count; i++)
                        {
                            RenovacionDetBE oRenovacionDetBE = new RenovacionDetBE()
                            {
                                IdRenovacion = dsDet.Tables[0].Rows[i]["IdRenovacion"].ToString(),
                                IdEntidad = dsDet.Tables[0].Rows[i]["IdEntidad"].ToString(),
                                IdEntidad_Dsc = dsDet.Tables[0].Rows[i]["IdEntidad_Dsc"].ToString(),
                                IdLote = dsDet.Tables[0].Rows[i]["IdLote"].ToString(),
                                cItem = dsDet.Tables[0].Rows[i]["cItem"].ToString(),
                                IdDocumento = dsDet.Tables[0].Rows[i]["IdDocumento"].ToString(),
                                cNumDoc =  dsDet.Tables[0].Rows[i]["cNumDoc"].ToString(),
                                IdPagadora = dsDet.Tables[0].Rows[i]["IdPagadora"].ToString(),
                                IdSocio = dsDet.Tables[0].Rows[i]["IdSocio"].ToString(),
                                sdVencimiento = !string.IsNullOrEmpty(dsDet.Tables[0].Rows[i]["sdVencimiento"].ToString()) ? DateTime.Parse(dsDet.Tables[0].Rows[i]["sdVencimiento"].ToString()) : DateTime.MinValue,
                                iVencimiento = int.Parse(dsDet.Tables[0].Rows[i]["iVencimiento"].ToString()),
                                nvNominal = Decimal.Parse(dsDet.Tables[0].Rows[i]["nvNominal"].ToString()),
                                nvNegociable = Decimal.Parse(dsDet.Tables[0].Rows[i]["nvNegociable"].ToString()),
                                nPorAmortizacion = Decimal.Parse(dsDet.Tables[0].Rows[i]["nPorAmortizacion"].ToString()),
                                nvImporteAm = Decimal.Parse(dsDet.Tables[0].Rows[i]["nvImporteAm"].ToString()),
                                nvImporteN = !string.IsNullOrEmpty(dsDet.Tables[0].Rows[i]["nvImporteN"].ToString()) ? decimal.Parse(dsDet.Tables[0].Rows[i]["nvImporteN"].ToString()) : 0,
                                iPlazoVencimientoN = int.Parse(dsDet.Tables[0].Rows[i]["iPlazoVencimientoN"].ToString()),
                                sdVencimientoN = !string.IsNullOrEmpty(dsDet.Tables[0].Rows[i]["sdVencimientoN"].ToString()) ? DateTime.Parse(dsDet.Tables[0].Rows[i]["sdVencimientoN"].ToString()) : DateTime.MinValue,
                                nPorTEA = Decimal.Parse(dsDet.Tables[0].Rows[i]["nPorTEA"].ToString()),
                                nGastosAdm = Decimal.Parse(dsDet.Tables[0].Rows[i]["nGastosAdm"].ToString()),
                                nGastosReno = Decimal.Parse(dsDet.Tables[0].Rows[i]["nGastosReno"].ToString()),
                                nInteresVencidos = Double.Parse(dsDet.Tables[0].Rows[i]["nInteresVencidos"].ToString()),
                                nInteresReno = Double.Parse(dsDet.Tables[0].Rows[i]["nInteresReno"].ToString()),
                                nImporte = Decimal.Parse(dsDet.Tables[0].Rows[i]["nImporte"].ToString()),
                                IdEstado_tt = dsDet.Tables[0].Rows[i]["IdEstado_tt"].ToString(),
                                TEAOrigen = Decimal.Parse(dsDet.Tables[0].Rows[i]["TEAOrigen"].ToString()),
                            };
                            LstRenovacionDet.Add(oRenovacionDetBE);
                        }
                        dgvRenovacionDet.DataSource = LstRenovacionDet;
                        Totalizar();
                    }

                    if (IdEstado_tt != "00110") //Pendiente
                    {
                        btnBusquedaPagadora.Enabled = false;
                        btnBusquedaSocio.Enabled = false;
                        btnAgregar.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnAceptar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Este Grupo no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusquedaPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaPagadora ofrmBusquedaPagadora = new Formula.Consulta.frmBusquedaPagadora();
                ofrmBusquedaPagadora.ShowDialog();

                DataSet dsPagadora = new DataSet();
                PagadoraBE PagadoraBE = new PagadoraBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = ofrmBusquedaPagadora.CodigoPagadora.ToString()
                };

                dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);

                if (dsPagadora.Tables[0].Rows.Count > 0)
                {
                    txtIdPagadora.Text = dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString();
                    txtIdPagadora_Dsc.Text = dsPagadora.Tables[0].Rows[0]["vcPagadora"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusquedaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio.ShowDialog();

                if (!string.IsNullOrEmpty(ofrmBusquedaSocio.CodSocio))
                {
                    txtIdSocio.Text = ofrmBusquedaSocio.CodSocio.Trim();
                    txtIdSocio_Dsc.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboIdMoneda_tt.SelectedIndex == 0)
                {
                    MessageBox.Show("Se debe seleccionar una Moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (rdbPagadora.Checked == true && string.IsNullOrEmpty(txtIdPagadora.Text))
                {
                    MessageBox.Show("Debe seleccionar una Pagadora", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (rdbSocio.Checked == true && string.IsNullOrEmpty(txtIdSocio.Text))
                {
                    MessageBox.Show("Debe seleccionar un Socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string dtRenova = dtRenovacion.Value.ToString().Substring(0, 10);
                string dtNow = General.General.gFechaOp.ToString().Substring(0, 10);

                //if (DateTime.Parse(dtRenova.ToString()) < DateTime.Parse(dtNow.ToString()))
                //{
                //    MessageBox.Show("La fecha de Renovación no puede ser menor que el día actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}


                frmRenovacionDocAdd Ofrm = new frmRenovacionDocAdd();
                Ofrm._IdEntidad = Tipo.Equals("P") ? txtIdPagadora.Text : txtIdSocio.Text;
                Ofrm._IdEntidad_Dsc = Tipo.Equals("P") ? txtIdPagadora_Dsc.Text : txtIdSocio_Dsc.Text;
                Ofrm._IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString();
                Ofrm._IdMoneda_tt_Dsc = cboIdMoneda_tt.Text;
                Ofrm._dtRenovacion = dtRenovacion.Text;
                Ofrm._Tipo = Tipo;
                Ofrm.ShowDialog();


                    DataSet ds = new DataSet();

                    foreach (var item in Ofrm.LstEntidadTmpLote)
                    {

                        DetaLoteBE DetaLoteBE = new DetaLoteBE()
                        {
                            OPCION = 8,
                            USUARIO = General.General.GetCodigoUsuario,
                            IdLote =  item.IdLote,
                            cItem = item.cItem,
                            dtRenovacion = dtRenovacion.Value,
                            Tipo = Tipo
                        };
                        ds = DetaLoteBL.ProcesarDetaLote(DetaLoteBE);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                RenovacionDetBE oRenovacionBE = new RenovacionDetBE()
                                {
                                    IdLote = ds.Tables[0].Rows[i]["IdLote"].ToString(),
                                    cItem = ds.Tables[0].Rows[i]["cItem"].ToString(),
                                    IdDocumento = ds.Tables[0].Rows[i]["IdDocumento"].ToString(),
                                    cNumDoc = ds.Tables[0].Rows[i]["cNumDoc"].ToString(),
                                    IdEntidad = ds.Tables[0].Rows[i]["IdEntidad"].ToString(),
                                    IdEntidad_Dsc = ds.Tables[0].Rows[i]["IdEntidad_Dsc"].ToString(),
                                    sdVencimiento = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["sdVencimiento"].ToString()) ? DateTime.Parse(ds.Tables[0].Rows[i]["sdVencimiento"].ToString()) : DateTime.MinValue,
                                    iVencimiento = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["DiasVenc"].ToString()) ? int.Parse(ds.Tables[0].Rows[i]["DiasVenc"].ToString()) : 0,
                                    nvNominal = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["nvNominal"].ToString()) ? Decimal.Parse(ds.Tables[0].Rows[i]["nvNominal"].ToString()) : 0,
                                    nvNegociable = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["nvNegociable"].ToString()) ? Decimal.Parse(ds.Tables[0].Rows[i]["nvNegociable"].ToString()) : 0,
                                    TEAOrigen = !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["TEAOrigen"].ToString()) ? Decimal.Parse(ds.Tables[0].Rows[i]["TEAOrigen"].ToString()) : 0,
                                    nPorTEA = 18,
                                    nGastosAdm = 30,
                                    nGastosReno = 30,
                                    iPlazoVencimientoN = 30,
                                    sdVencimientoN = dtRenovacion.Value.AddDays(30),
                                    nFondoGarantia =  !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["nFondoGarantia"].ToString()) ? Decimal.Parse(ds.Tables[0].Rows[i]["nFondoGarantia"].ToString()) : 0,   
                                };
                                //LstRenovacionDet.Add(oRenovacionBE);

                                // Validar
                                bool IsVal = true;
                                foreach (var oRenovacionDet in LstRenovacionDet)
                                {
                                    if (oRenovacionDet.IdEntidad == oRenovacionBE.IdEntidad && oRenovacionDet.IdDocumento == oRenovacionBE.IdDocumento && oRenovacionDet.cNumDoc == oRenovacionBE.cNumDoc)
                                    {
                                        IsVal = false;
                                        MessageBox.Show("El documento " + oRenovacionBE.cNumDoc.Trim() + " ya existe, seleccione otro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                if (IsVal) { LstRenovacionDet.Add(oRenovacionBE); }
                            }
                        }

                        dgvRenovacionDet.DataSource = LstRenovacionDet;
                        foreach (DataGridViewRow row in dgvRenovacionDet.Rows)
                        {
                            dtRenova = row.Cells["sdVencimiento"].Value.ToString().Substring(0, 10);
                            if (DateTime.Parse(dtRenova.ToString()) >= DateTime.Parse(dtNow.ToString()))
                            {
                            }
                            else // Vencido
                            {
                                row.DefaultCellStyle.ForeColor = Color.FromName(General.General.GetColorAnulado);
                            }
                        }
                        
                        Totalizar();
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Totalizar()
        {
            try
            {
                Decimal AcVnominal = 0;
                foreach (var item in LstRenovacionDet)
                {
                    AcVnominal += item.nImporte;
                }
                txtTotal.Text = AcVnominal.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvRenovacionDet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal VnvNominal = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["nvNominal"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["nvNominal"].Value.ToString());
                decimal VnvNegociable = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["nvNegociable"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["nvNegociable"].Value.ToString());
                decimal VnPorAmortizacion = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["nPorAmortizacion"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["nPorAmortizacion"].Value.ToString());
                decimal VnvImporteAm = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteAm"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteAm"].Value.ToString());
                decimal VnPorTEA = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["nPorTEA"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["nPorTEA"].Value.ToString());
                decimal VnPoTEAOrigen = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["TEAOrigen"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["TEAOrigen"].Value.ToString());

                decimal ViVencimiento = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["iVencimiento"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["iVencimiento"].Value.ToString());
                decimal VDiasVencidos = 0;
                decimal VPlazoRenov = 0;
                int iPlazoVencimientoN = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["iPlazoVencimientoN"].Value.ToString()) ? 0 : int.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["iPlazoVencimientoN"].Value.ToString());
                DateTime dtsdVencimiento = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["sdVencimiento"].Value.ToString()) ? DateTime.MinValue : DateTime.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["sdVencimiento"].Value.ToString());
                DateTime dtsdVencimientoN = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["sdVencimientoN"].Value.ToString()) ? DateTime.MinValue : DateTime.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["sdVencimientoN"].Value.ToString());
                DateTime dtVencimientoN = dtRenovacion.Value;


                // Por Plazo
                if (dgvRenovacionDet.Rows[e.RowIndex].Cells["iPlazoVencimientoN"].ColumnIndex == e.ColumnIndex && iPlazoVencimientoN != 0)
                {
                    dtVencimientoN = dtVencimientoN.AddDays(iPlazoVencimientoN);
                    dgvRenovacionDet.Rows[e.RowIndex].Cells["sdVencimientoN"].Value = dtVencimientoN;
                }
                else if (dgvRenovacionDet.Rows[e.RowIndex].Cells["sdVencimientoN"].ColumnIndex == e.ColumnIndex && dtsdVencimientoN != DateTime.MinValue)
                {
                    int iPlazo = (dtsdVencimientoN.Date - dtRenovacion.Value.Date).Days;
                    VPlazoRenov = iPlazo;
                    //TimeSpan tsPlazo = dtsdVencimientoN - dtRenovacion.Value;
                    dgvRenovacionDet.Rows[e.RowIndex].Cells["iPlazoVencimientoN"].Value = iPlazo; //tsPlazo.Days + 1;
                }
                
                if (dtsdVencimientoN != DateTime.MinValue && dtsdVencimiento != DateTime.MinValue)
                {
                    int iPlazo = (dtsdVencimientoN.Date - dtRenovacion.Value.Date).Days;
                    VPlazoRenov = iPlazo;
                    //int iPlazo = (dtRenovacion.Value.Date - dtsdVencimiento.Date).Days; nuevo
                    //TimeSpan ts = dtsdVencimientoN.Date - dtRenovacion.Value.Date;
                    //VDiasVencidos = iPlazo;//ts.Days +1;
                    VDiasVencidos = (dtRenovacion.Value.Date - dtsdVencimiento.Date).Days;

                    dgvRenovacionDet.Rows[e.RowIndex].Cells["iPlazoVencimientoN"].Value = iPlazo;
                    dgvRenovacionDet.Rows[e.RowIndex].Cells["iVencimiento"].Value = VDiasVencidos;

                    //*************************
                    //Agregado 28/08/2018
                    //*************************
                    //iPlazo = (dtsdVencimientoN.Date - dtRenovacion.Value.Date).Days;
                    //dgvRenovacionDet.Rows[e.RowIndex].Cells["iPlazoVencimientoN"].Value = iPlazo; //tsPlazo.Days + 1;

                    //dtVencimientoN = dtRenovacion.Value.AddDays(iPlazo);
                    //dgvRenovacionDet.Rows[e.RowIndex].Cells["sdVencimientoN"].Value = dtVencimientoN;
                    //*************************
                }

                // Por porcentaje
                decimal VnCero = 0;
                if (dgvRenovacionDet.Rows[e.RowIndex].Cells["nPorAmortizacion"].ColumnIndex == e.ColumnIndex)
                {
                    if (VnPorAmortizacion >= 0)
                    {
                        dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteAm"].Value = VnvNominal * (VnPorAmortizacion / 100);
                        decimal ImpAmor = Math.Round(decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteAm"].Value.ToString()), 2, MidpointRounding.AwayFromZero);
                        dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteN"].Value = VnvNominal - ImpAmor;
                    }
                    else {
                        dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteAm"].Value = VnCero;
                        dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteN"].Value = VnCero;
                    }
                }
                else if (dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteAm"].ColumnIndex == e.ColumnIndex) // Por monto
                {
                    if (VnvImporteAm > 0)
                    {
                        dgvRenovacionDet.Rows[e.RowIndex].Cells["nPorAmortizacion"].Value = (VnvImporteAm / VnvNominal) * 100;
                        dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteN"].Value = VnvNominal - Math.Round(VnvImporteAm, 2);
                    }
                    else
                    {
                        dgvRenovacionDet.Rows[e.RowIndex].Cells["nPorAmortizacion"].Value = VnCero;
                        dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteN"].Value = VnCero;
                    }
                }

               // if(VDiasVencidos != 0){ // comentado el 20180920
                    /* INTERESES VENCIDOS
                     * ((((K20/100)+1)^((G20)/360))-1)*(J20)
                     * ((((VnPorTEA/100)+1)^((ViVencimiento)/360))-1)*(VnvNominal) */
                    double InteresVen100 = Convert.ToDouble((VnPoTEAOrigen / 100) + 1);
                    double DiasVen360 = Convert.ToDouble((VDiasVencidos / 360)); 
                    //double Interes = ((Math.Pow(InteresVen100, DiasVen360)) - 1) * Convert.ToDouble(VNegociable);
                    dgvRenovacionDet.Rows[e.RowIndex].Cells["nInteresVencidos"].Value = ((Math.Pow(InteresVen100, DiasVen360)) - 1) * Convert.ToDouble(VnvNominal); ;

                    //+REDONDEAR(((((19.99/100)+1)^((G21)/360))-1)*(J21*1),2)

                    /* INTERESES POR RENOVACION
                     * C29*(1-(1/((1+(K29/100))^((G29)/360)))) 
                     * VnvNominal*(1-(1/((1+(VnPorTEA/100))^((ViVencimiento)/360)))) */
                    double InteresReno100 = Convert.ToDouble(1 + (VnPorTEA / 100));
                    double DiasReno360 = Convert.ToDouble(VPlazoRenov / 360);
                    double ImporteN = Convert.ToDouble(dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteN"].Value);
                    dgvRenovacionDet.Rows[e.RowIndex].Cells["nInteresReno"].Value = Convert.ToDouble(ImporteN) * (1 - (1 / (Math.Pow(InteresReno100, DiasReno360))));
                    //'=+C31*(1-(1/((1+19.99%)^((G31)/360))))
                //}

                /* IMPORTE TOTAL */
                decimal VnvImporteAmT = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteAm"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["nvImporteAm"].Value.ToString());
                decimal VInteresReno = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["nInteresReno"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["nInteresReno"].Value.ToString());
                decimal VInteresVen = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["nInteresVencidos"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["nInteresVencidos"].Value.ToString());
                decimal VnGastosReno = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["nGastosReno"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["nGastosReno"].Value.ToString());
                decimal VnGastosAdm = string.IsNullOrEmpty(dgvRenovacionDet.Rows[e.RowIndex].Cells["nGastosAdm"].Value.ToString()) ? 0 : decimal.Parse(dgvRenovacionDet.Rows[e.RowIndex].Cells["nGastosAdm"].Value.ToString());
                dgvRenovacionDet.Rows[e.RowIndex].Cells["nImporte"].Value = VnvImporteAmT + Math.Round(VInteresReno, 2) + Math.Round(VInteresVen, 2) + VnGastosReno + VnGastosAdm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRenovacionDet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Totalizar();
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
                if (!ValidadDatos()) { return; }
                RenovacionBE RenovacionBE = new RenovacionBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    gSesionID = General.General.gSesionID,
                    gPlazaID = General.General.gPlazaID,
                    gFechaOp = General.General.gFechaOp,
                    IdRenovacion = txtIdRenovacion.Text,
                    dtRenovacion = dtRenovacion.Value,
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    TipoRenovacion = Tipo
                };

                DataSet dsRenovacion = new DataSet();
                dsRenovacion = RenovacionBL.ProcesarRenovacion(RenovacionBE);

                if (dsRenovacion.Tables[0].Rows.Count > 0)
                {

                    this.txtIdRenovacion.Text = dsRenovacion.Tables[0].Rows[0]["IdRenovacion"].ToString();

                    /* Deshabilita los registros */
                    RenovacionDetBE oRenovacionDetBE = new RenovacionDetBE()
                    {
                        USUARIO = General.General.GetCodigoUsuario,
                        OPCION = 3,
                        IdRenovacion = txtIdRenovacion.Text
                    };
                    RenovacionDetBL.ProcesarRenovacionDet(oRenovacionDetBE);

                    /* Documentos */
                    foreach (var item in LstRenovacionDet)
                    {
                        item.USUARIO = General.General.GetCodigoUsuario;
                        item.OPCION = 2;
                        item.IdRenovacion = txtIdRenovacion.Text;
                        item.IdEstado_tt = "00110"; //Pendiente
                        item.IdPagadora = Tipo.Equals("P") ? txtIdPagadora.Text : item.IdEntidad;
                        item.IdSocio = Tipo.Equals("S") ? txtIdSocio.Text : item.IdEntidad;
                        RenovacionDetBL.ProcesarRenovacionDet(item);
                    }
                }
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidadDatos()
        {
            bool bResult = true;
            try
            {
                if (cboIdMoneda_tt.SelectedIndex == 0)
                {
                    MessageBox.Show("Se debe seleccionar una Moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdMoneda_tt.Focus();
                    return bResult = false ;
                }

                //if (dtRenovacion.Value.Date < DateTime.Now.Date)
                //{
                //    MessageBox.Show("La fecha de renovación no puede ser menor a la fecha actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    dtRenovacion.Focus();
                //    return bResult = false;
                //}

                if (LstRenovacionDet.Count == 0)
                {
                    MessageBox.Show("Ingresar al menos un documento a renovar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return bResult = false;
                }

                foreach (RenovacionDetBE oEntity in LstRenovacionDet)
                {
                    //if (oEntity.sdVencimientoN < DateTime.Now.Date)
                    //{
                    //    MessageBox.Show("La fecha del nuevo vencimiento no puede ser menor a la fecha actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    return bResult = false;
                    //}

                    if (oEntity.nPorTEA == 0)
                    {
                        MessageBox.Show("El porcentaje de la TEA a renovar no puede ser 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return bResult = false;
                    }

                    //if (oEntity.nvImporteAm == 0)
                    //{
                    //    MessageBox.Show("Ingrese un importe a amortizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    return bResult = false;
                    //}
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bResult;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRenovacionDet.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Está Ud. seguro de eliminar el documento " + dgvRenovacionDet.CurrentRow.Cells["cNumDoc"].Value.ToString().Trim() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int index = dgvRenovacionDet.CurrentRow.Index;
                        LstRenovacionDet.RemoveAt(index);
                        dgvRenovacionDet.DataSource = LstRenovacionDet;
                        Totalizar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbPagadora_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                btnBusquedaSocio.Enabled = false;
                btnBusquedaPagadora.Enabled = false;
                txtIdPagadora.Clear();
                txtIdPagadora_Dsc.Clear();
                txtIdSocio.Clear();
                txtIdSocio_Dsc.Clear();

                if (rdbPagadora.Checked)
                {
                    btnBusquedaPagadora.Enabled = true;
                    Tipo = "P";
                }
                else
                {
                    btnBusquedaSocio.Enabled = true;
                    Tipo = "S";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirLote_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsRenovacion = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("Rpt_Renovacion", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.Parameters.AddWithValue("@IdRenovacion", txtIdRenovacion.Text.Trim());
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsRenovacion, "Renovacion");

                    SqlCommand cmd2 = new SqlCommand("Rpt_Renovacion", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@Opcion", 2);
                    cmd2.Parameters.AddWithValue("@IdRenovacion", txtIdRenovacion.Text.Trim());
                    SqlDataAdapter daCab2 = new SqlDataAdapter(cmd2);
                    daCab2.Fill(dsRenovacion, "RenovacionDet1");

                    SqlCommand cmd3 = new SqlCommand("Rpt_Renovacion", con);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@Opcion", 3);
                    cmd3.Parameters.AddWithValue("@IdRenovacion", txtIdRenovacion.Text.Trim());
                    SqlDataAdapter daCab3 = new SqlDataAdapter(cmd3);
                    daCab3.Fill(dsRenovacion, "RenovacionDet2");
                    con.Close();
                }

                Crystal.crRptRenovacion ocrRptRenovacion = new Crystal.crRptRenovacion();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrRptRenovacion;
                ocrRptRenovacion.SetDataSource(dsRenovacion);
                ocrRptRenovacion.SetParameterValue("usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtRenovacion_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvRenovacionDet.Rows)
                {
                    dgvRenovacionDet_CellEndEdit(new object(), new DataGridViewCellEventArgs(1, row.Index));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}