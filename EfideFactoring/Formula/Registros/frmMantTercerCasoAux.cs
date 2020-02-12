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
    public partial class frmMantTercerCasoAux : FormulaBase.frmMntDato
    {
        public string CodSocio { get; set; }
        public string NroCuenta { get; set; }

        #region "FUNCTION"
        private void actualizaTercerCaso()
        {
            SocioBL oSocioBL = new SocioBL();
            TercerCasoAuxBE oTercerCasoAuxBE = new TercerCasoAuxBE();

            oTercerCasoAuxBE.CodSocio = lblSocio.Text;
            oTercerCasoAuxBE.TipoDoc = cboTipoDocumento.Text;
            oTercerCasoAuxBE.NumDoc = txtNroDocumento.Text;
            oTercerCasoAuxBE.RUC = txtRuc.Text;
            oTercerCasoAuxBE.Beneficiario = txtBeneficiario.Text;
            oTercerCasoAuxBE.NumCuentaLocal = txtNroCuentaLocal.Text;
            oTercerCasoAuxBE.CodInterbancario = txtCodInterbancario.Text;

            oSocioBL.actualizaTercerCaso(oTercerCasoAuxBE);
        }

        private void obtieneTercerCaso(string codSocio, string NroCuenta)
        {
            SocioBL oSocioBL = new SocioBL();
            TercerCasoAuxBE oTercerCasoAuxBE = new TercerCasoAuxBE();

            oTercerCasoAuxBE = oSocioBL.obtenerTercerCaso(codSocio, NroCuenta);

            if (oTercerCasoAuxBE != null)
            {
                lblSocio.Text = oTercerCasoAuxBE.CodSocio;
                cboTipoDocumento.Text = oTercerCasoAuxBE.TipoDoc;
                txtNroDocumento.Text = oTercerCasoAuxBE.NumDoc;
                txtRuc.Text = oTercerCasoAuxBE.RUC;
                txtBeneficiario.Text = oTercerCasoAuxBE.Beneficiario;
                txtNroCuentaLocal.Text = oTercerCasoAuxBE.NumCuentaLocal;
                txtCodInterbancario.Text = oTercerCasoAuxBE.CodInterbancario;

                txtNroCuentaLocal.ReadOnly = true;
                txtCodInterbancario.ReadOnly = true;
            }
            else
            {
                txtNroCuentaLocal.ReadOnly = false;
                txtCodInterbancario.ReadOnly = false;
            }
        }
        #endregion

        public frmMantTercerCasoAux()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                actualizaTercerCaso();
                this.Close();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Ocurrió un error al cargar los datos - Error: " + ex.Message);
            }
        }

        private void frmMantTercerCasoAux_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoDocumento.SelectedIndex = 0;
                obtieneTercerCaso(CodSocio, NroCuenta);
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Ocurrió un error al cargar actualizar los datos de tercer caso - Error: " + ex.Message);
            }
        }
    }
}