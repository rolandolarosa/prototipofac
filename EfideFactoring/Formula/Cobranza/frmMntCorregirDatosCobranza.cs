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

namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmMntCorregirDatosCobranza : FormulaBase.frmMntDato
    {
        public string _IdLote = string.Empty;
        public string _cItem = string.Empty;
        public string _Socio = string.Empty;
        public string _Documento = string.Empty;
        public System.DateTime _dtVencimiento = DateTime.MinValue;
        public decimal _nImportOriginal = 0;
        public frmMntCorregirDatosCobranza()
        {
            InitializeComponent();
        }

        private void frmMntCorregirDatosCobranza_Load(object sender, EventArgs e)
        {
            try
            {
                txtSocio.Text = _Socio;
                txtDocumento.Text = _Documento;
                dtVencimiento.Value = _dtVencimiento;
                txtnImportOriginal.Text = _nImportOriginal.ToString("N2");
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
                if (string.IsNullOrEmpty(txtnImportOriginal.Text.Trim()))
                {
                    MessageBox.Show("Ingrese un importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (dtVencimiento.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Ingrese una fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DetaLoteBE oEntity = new DetaLoteBE();
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.OPCION = 14;
                oEntity.IdLote = _IdLote;
                oEntity.cItem = _cItem;
                oEntity.sdVencimiento = dtVencimiento.Value;
                oEntity.nvNegociable = Convert.ToDecimal(txtnImportOriginal.Text);
                new DetaLoteBL().ProcesarDetaLote(oEntity);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}