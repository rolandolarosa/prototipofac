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
    public partial class frmMntSaldoSocio : FormulaBase.frmMntDato
    {
        public frmMntSaldoSocio()
        {
            InitializeComponent();
        }

        #region " PROPERTIES "
        public string creditoID { get; set; }
        public string anio { get; set; }
        public string mes { get; set; }

        bool ind = false;
        #endregion

        #region " FUNCTIONS "
        private void GetEvaluacionCartera(string creditoID, string anio, string mes)
        {
            EvaluacionCarteraBL oEvalueacionCarteraBL = new EvaluacionCarteraBL();
            EvaluacionCarteraBE oEvaluacionCarteraBE = new EvaluacionCarteraBE();

            oEvaluacionCarteraBE = oEvalueacionCarteraBL.ObtenerEvaluacionCartera(creditoID, anio, mes);

            lblRazonSocial.Text = oEvaluacionCarteraBE.RazonSocial;
            lblNroCredito.Text = oEvaluacionCarteraBE.NroCredito;
            lblCategoria.Text = oEvaluacionCarteraBE.Categoria;
            lblProducto.Text = oEvaluacionCarteraBE.Producto;
            lblImporteOriginal.Text = oEvaluacionCarteraBE.ImporteOriginal.ToString("N");

            lblSaldoVigente.Text = oEvaluacionCarteraBE.evaCarteraVigente.ToString("N");
            lblSaldoVencido.Text = oEvaluacionCarteraBE.evaCarteraVencida.ToString("N");
            
            //lblCalificacion.Text = oEvaluacionCarteraBE.Calificacion + "     " + oEvaluacionCarteraBE.PorcCalificacion + " %";
            lblCalificacion.Text = ((oEvaluacionCarteraBE.ProvisionEspecifica / (oEvaluacionCarteraBE.evaCarteraVigente + oEvaluacionCarteraBE.evaCarteraVencida)) * 100).ToString("N") + " %";

            lblProvisionEspecifica.Text = oEvaluacionCarteraBE.ProvisionEspecifica.ToString("N");
            chkIndAltoRiesgo.Checked = oEvaluacionCarteraBE.indAltoRiesgo;
        }
        private void saveEvaluacionCartera(string creditoID, string anio, string mes)
        {
            EvaluacionCarteraBL oEvalueacionCarteraBL = new EvaluacionCarteraBL();
            EvaluacionCarteraBE oEvaluacionCarteraBE = new EvaluacionCarteraBE();

            oEvaluacionCarteraBE.CreditoID = creditoID;
            oEvaluacionCarteraBE.anio = Convert.ToInt32(anio);
            oEvaluacionCarteraBE.mes = Convert.ToInt32(mes);
            
            if(string.IsNullOrEmpty(txtAjusteVigente.Text))
                oEvaluacionCarteraBE.evaCarteraVigente = Convert.ToDecimal(lblSaldoVigente.Text);
            else
                oEvaluacionCarteraBE.evaCarteraVigente = Convert.ToDecimal(txtAjusteVigente.Text);

            if(string.IsNullOrEmpty(txtAjusteVencido.Text))
                oEvaluacionCarteraBE.evaCarteraVencida = Convert.ToDecimal(lblSaldoVencido.Text);
            else
                oEvaluacionCarteraBE.evaCarteraVencida = Convert.ToDecimal(txtAjusteVencido.Text);

            if(string.IsNullOrEmpty(lblAjusteProvision.Text))
                oEvaluacionCarteraBE.ProvisionEspecifica = Convert.ToDecimal(lblProvisionEspecifica.Text);
            else
                oEvaluacionCarteraBE.ProvisionEspecifica = Convert.ToDecimal(lblAjusteProvision.Text);

            if(string.IsNullOrEmpty(txtAjusteCalificacion.Text))
                oEvaluacionCarteraBE.PorcCalificacion = Convert.ToDecimal(lblCalificacion.Text.Replace("%", "").Trim());
            else
                oEvaluacionCarteraBE.PorcCalificacion = Convert.ToDecimal(txtAjusteCalificacion.Text.Replace("%", "").Trim());

            oEvaluacionCarteraBE.indAltoRiesgo = chkIndAltoRiesgo.Checked;

            oEvalueacionCarteraBL.UpdateEvaluacionCartera(oEvaluacionCarteraBE);
        }
        private bool validEvaluacionCartera()
        {
            bool rpta =false;
            if (string.IsNullOrEmpty(txtAjusteVigente.Text) || string.IsNullOrEmpty(txtAjusteVencido.Text) || string.IsNullOrEmpty(txtAjusteCalificacion.Text))
            {
                ucMsgBox1.ShowMessageError("Debe completar todos los campos");
                rpta = false;
            }
            else
                rpta = true;
            return rpta;
        }
        private void calculoImporteVigente()
        {
            decimal saldoVigente = 0;
            decimal saldoVencido = 0;
            decimal ajusteVigente = 0;
            decimal ajusteVencido = 0;

            decimal totalSaldo = 0;
            decimal totalAjuste = 0;

            saldoVigente = string.IsNullOrEmpty(lblSaldoVigente.Text) ? 0 : Convert.ToDecimal(lblSaldoVigente.Text);
            saldoVencido = string.IsNullOrEmpty(lblSaldoVencido.Text) ? 0 : Convert.ToDecimal(lblSaldoVencido.Text);
            ajusteVigente = string.IsNullOrEmpty(txtAjusteVigente.Text) ? 0 : Convert.ToDecimal(txtAjusteVigente.Text);
            ajusteVencido = string.IsNullOrEmpty(txtAjusteVencido.Text) ? 0 : Convert.ToDecimal(txtAjusteVencido.Text);

            totalSaldo = saldoVigente + saldoVencido;
            totalAjuste = ajusteVigente + ajusteVencido;

            txtAjusteVencido.Text = (totalSaldo - ajusteVigente).ToString("N");
            txtAjusteVigente.Text = string.IsNullOrEmpty(txtAjusteVigente.Text) ? "0" : Convert.ToDecimal(txtAjusteVigente.Text).ToString("N");
        }

        private void calculoImporteVencido()
        {
            decimal saldoVigente = 0;
            decimal saldoVencido = 0;
            decimal ajusteVigente = 0;
            decimal ajusteVencido = 0;

            decimal totalSaldo = 0;
            decimal totalAjuste = 0;

            saldoVigente = string.IsNullOrEmpty(lblSaldoVigente.Text) ? 0 : Convert.ToDecimal(lblSaldoVigente.Text);
            saldoVencido = string.IsNullOrEmpty(lblSaldoVencido.Text) ? 0 : Convert.ToDecimal(lblSaldoVencido.Text);
            ajusteVigente = string.IsNullOrEmpty(txtAjusteVigente.Text) ? 0 : Convert.ToDecimal(txtAjusteVigente.Text);
            ajusteVencido = string.IsNullOrEmpty(txtAjusteVencido.Text) ? 0 : Convert.ToDecimal(txtAjusteVencido.Text);

            totalSaldo = saldoVigente + saldoVencido;
            totalAjuste = ajusteVigente + ajusteVencido;

            txtAjusteVigente.Text = (totalSaldo - ajusteVencido).ToString("N");
            txtAjusteVencido.Text = string.IsNullOrEmpty(txtAjusteVencido.Text) ? "0" : Convert.ToDecimal(txtAjusteVencido.Text).ToString("N");
        }
        #endregion

        private void frmMntSaldoSocio_Load(object sender, EventArgs e)
        {
            try
            {
                GetEvaluacionCartera(creditoID, anio, mes);
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar el formulario - Error: " + ex.Message);
            }
        }

        private void frmMntSaldoSocio_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null && !ind)
            {
                ind = true;
                this.Owner.Close();
            }
        }

        private void txtAjusteVigente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    calculoImporteVigente();
                }
                else
                {
                    General.General.Validar_Decimal(e, ((TextBox)(sender)).Text);
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al ingresar el valor vigente - Error: " + ex.Message);
            }
        }

        private void txtAjusteVencido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    calculoImporteVencido();
                }
                else
                {
                    General.General.Validar_Decimal(e, ((TextBox)(sender)).Text);
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al ingresar el valor vencido - Error: " + ex.Message);
            }
        }

        private void txtAjusteCalificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    decimal ajusteCalificacion = string.IsNullOrEmpty(txtAjusteCalificacion.Text) ? 0 : Convert.ToDecimal(txtAjusteCalificacion.Text);
                    decimal ajusteVigente = string.IsNullOrEmpty(txtAjusteVigente.Text) ? 0 : Convert.ToDecimal(txtAjusteVigente.Text);
                    decimal ajusteVencido = string.IsNullOrEmpty(txtAjusteVencido.Text) ? 0 : Convert.ToDecimal(txtAjusteVencido.Text);
                    decimal totalAjuste = ajusteVigente + ajusteVencido;

                    lblAjusteProvision.Text = Convert.ToDecimal(totalAjuste * (ajusteCalificacion / 100)).ToString("N");
                }
                else
                {
                    General.General.Validar_Decimal(e, ((TextBox)(sender)).Text);
                }
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al ingresar la calificación - Error: " + ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (validEvaluacionCartera())
                //{
                    saveEvaluacionCartera(creditoID, anio, mes);
                    GetEvaluacionCartera(creditoID, anio, mes);
                    ucMsgBox1.ShowMessageSuccess("Se actualizaron los valores satisfactoriamente");
                    this.Close();
                //}
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al actualizar la cartera - Error: " + ex.Message);
            }
        }

        private void txtAjusteVigente_Leave(object sender, EventArgs e)
        {
            calculoImporteVigente();
        }

        private void txtAjusteVencido_Leave(object sender, EventArgs e)
        {
            calculoImporteVencido();
        }
    }
}