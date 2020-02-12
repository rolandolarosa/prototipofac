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

namespace EfideFactoring.Formula.Registros
{
    public partial class frmMantDocumentoSocio : FormulaBase.frmMntDato
    {
        public frmMantDocumentoSocio()
        {
            InitializeComponent();
        }

        #region " PROPERTIES "
        public string detOrdenID { get; set; }
        public string ordenBancoID { get; set; }
        bool ind = false;
        #endregion

        #region " FUNCTION "
        private void obtenerOrdenBanco(){
            CuentaBancoBE oCuentaBancoBE = new CuentaBancoBE();
            SocioBL oSocioBL = new SocioBL();
            oCuentaBancoBE = oSocioBL.obtenerDocumnetoSocio(detOrdenID, ordenBancoID);

            if (oCuentaBancoBE == null)
                throw new Exception("No se puede obtener los datos, favor de revisar los datos ingresados");

            lblCodSocio.Text = oCuentaBancoBE.CodPersonaSocio;
            lblSocio.Text = oCuentaBancoBE.NombreSocio;
            lblTercerSocio.Text = oCuentaBancoBE.NombreRepresenta;
            lblTipoOperacion.Text = oCuentaBancoBE.TipoOpeBanco;
            lblGlosa.Text = oCuentaBancoBE.comGlosa;
            lblBancoDestino.Text = oCuentaBancoBE.BancoDestino;
            lblNroCuenta.Text = oCuentaBancoBE.NroCuenta;
            //lblBeneficiario.Text = oCuentaBancoBE.Beneficiario;
            //lblTipoBeneficiario.Text = oCuentaBancoBE.TipoBeneficiario;

            lblBeneficiario.Text = (!string.IsNullOrEmpty(lblTercerSocio.Text) ? lblTercerSocio.Text : lblSocio.Text);
            lblTipoBeneficiario.Text = (lblSocio.Text == lblBeneficiario.Text ? "Titular" : "Tercero");

            if (oCuentaBancoBE.origen == 2)
            {
                lblTipoBeneficiario.Text = "Tercero";
                if (!string.IsNullOrEmpty(oCuentaBancoBE.CodPersonaAux))
                {
                    lblTipoDocumento.Text = oCuentaBancoBE.TipoDocumentoAux;
                    lblNroDocumento.Text = oCuentaBancoBE.NroDocumentoAux;
                }
                else if (!string.IsNullOrEmpty(oCuentaBancoBE.NroDocumentoTerceraPersona))
                {
                    lblTipoDocumento.Text = oCuentaBancoBE.TipoDocumentoTerceraPersona;
                    lblNroDocumento.Text = oCuentaBancoBE.NroDocumentoTerceraPersona;
                    //lblBeneficiario.Text = oCuentaBancoBE.NombreRepresenta;
                }
                else if (!string.IsNullOrEmpty(oCuentaBancoBE.NroDocumentoRepresenta))
                {
                    lblTipoDocumento.Text = oCuentaBancoBE.TipoDocumentoRepresenta;
                    lblNroDocumento.Text = oCuentaBancoBE.NroDocumentoRepresenta;
                    lblBeneficiario.Text = oCuentaBancoBE.NombreRepresenta;
                }
                else
                {
                    lblTipoDocumento.Text = oCuentaBancoBE.TipoDocumentoSocio;
                    lblNroDocumento.Text = oCuentaBancoBE.NroDocumentoSocio;
                    lblBeneficiario.Text = oCuentaBancoBE.NombreSocio;
                }
                if (!string.IsNullOrEmpty(oCuentaBancoBE.CodPersonaExcel))
                    lblBeneficiario.Text = oCuentaBancoBE.NombreExcel;
            }
            else
            {
                if (!string.IsNullOrEmpty(oCuentaBancoBE.CodPersonaAux))
                {
                    lblTipoDocumento.Text = oCuentaBancoBE.TipoDocumentoAux;
                    lblNroDocumento.Text = oCuentaBancoBE.NroDocumentoAux;
                }
                else
                {
                    lblTipoDocumento.Text = oCuentaBancoBE.TipoDocumentoSocio;
                    lblNroDocumento.Text = oCuentaBancoBE.NroDocumentoSocio;
                    lblBeneficiario.Text = oCuentaBancoBE.NombreSocio;
                }
            }

            lblOrigen.Text =  oCuentaBancoBE.origen == 2? "Tercero": "";
            validaActivacionBotonCambio(oCuentaBancoBE);
        }

        private void validaActivacionBotonCambio(CuentaBancoBE oCuentaBancoBE)
        {
            if (lblTipoBeneficiario.Text == "Titular" && lblCodSocio.Text.Contains("PJ"))
                btnCambioDocumento.Enabled = false;
            else if (lblTipoBeneficiario.Text == "Tercero" && lblTipoDocumento.Text == "RUC" && oCuentaBancoBE.NroDocumentoTerceraPersona == lblNroDocumento.Text && lblCodSocio.Text.Contains("PN"))
                btnCambioDocumento.Enabled = false;
            else
                btnCambioDocumento.Enabled = true;
        }
        private void actualizaDocumnetoSocio()
        {
            CuentaBancoBE oCuentaBancoBE = new CuentaBancoBE();
            SocioBL oSocioBL = new SocioBL();
            int tipo = 1;

            if (lblTipoDocumento.Text.ToUpper() == "DNI")
                tipo = 2;
            else
                tipo = 1;

            oSocioBL.actualizaDocumnetoSocio(detOrdenID, ordenBancoID, tipo, lblOrigen.Text == "Tercero"?2:0, lblNroCuenta.Text);
        }
        private void showNotification(string message)
        {
            ToastNotification.Show(this, message, null, -1, eToastGlowColor.Blue, 3, 450);
        }
        #endregion

        private void btnCambioDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblOrigen.Text == "Tercero")
                {
                    //SocioBL oSocioBL = new SocioBL();
                    //TercerCasoAuxBE oTercerCasoAuxBE = new TercerCasoAuxBE();

                    //oTercerCasoAuxBE = oSocioBL.obtenerTercerCaso(lblCodSocio.Text);

                    //if (oTercerCasoAuxBE == null)
                    //{
                    
                    frmMantTercerCasoAux frm = new frmMantTercerCasoAux();
                    frm.CodSocio = lblCodSocio.Text;  //"0010000020040PJ";
                    frm.NroCuenta = lblNroCuenta.Text;
                    frm.ShowDialog();

                    //}
                    //else if (string.IsNullOrEmpty(oTercerCasoAuxBE.NumDoc))
                    //{
                    //    frmMantTercerCasoAux frm = new frmMantTercerCasoAux();
                    //    frm.codSocio = lblCodSocio.Text;  //"0010000020040PJ";
                    //    frm.ShowDialog();
                    //}
                }

                actualizaDocumnetoSocio();
                obtenerOrdenBanco();

                ucMsgBox1.ShowMessageSuccess("Se Actualizó satisfactoriamente el tipo y nro de documento");
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al realizar el cambio de documento - Error: " + ex.Message);
            }
        }

        private void frmMantDocumentoSocio_Load(object sender, EventArgs e)
        {
            try
            {
                obtenerOrdenBanco();
                validaInformacion();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar el formulario - Error: " + ex.Message);
            }
        }

        private void validaInformacion()
        {
            if (string.IsNullOrEmpty(lblNroDocumento.Text) && string.IsNullOrEmpty(lblTipoDocumento.Text))
            {
                showNotification("Debe completar la información para poder cambiar de documento");
                btnCambioDocumento.Enabled = false;
            }
        }

        private void frmMantDocumentoSocio_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null && !ind)
            {
                ind = true;
                this.Owner.Close();
            }
        }
    }
}