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

namespace EfideFactoring.Formula.Registros
{
    public partial class frmSocioLineaPagDocDato : FormulaBase.frmMntDato
    {
        PagadoraDocumentoBL PagadoraDocumentoBL = new PagadoraDocumentoBL();
        public string _IdPagadora = string.Empty;
        public string _IdDocumento = string.Empty;
        public string _vDocumento = string.Empty;
        public string _IdTipoConfirmacion = string.Empty;
        public string _IdTipoConfirmacion_Dsc = string.Empty;
        public decimal _FondoGarantia = 0;
        public bool _Interes;
        public frmSocioLineaPagDocDato()
        {
            InitializeComponent();
        }

        private void SocioLineaPagDocDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
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
                DataSet ds = new DataSet();
                PagadoraDocumentoBE PagadoraDocumentoBE = new PagadoraDocumentoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdPagadora = _IdPagadora
                };

                General.General.LlenarCombobox(cboDocumentos, "IdDocumento_Dsc", "IdDocumento", PagadoraDocumentoBL.ProcesarPagadoraDocumento(PagadoraDocumentoBE).Tables[0]);

                String Table_Id = System.Configuration.ConfigurationManager.AppSettings["TbTipoConfirmacion"].ToString(); //Tipo Confirmacion
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdTipoConfirmacion, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                //cboIdTipoConfirmacion.SelectedValue = "00434"; //Email
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFondoGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtFondoGarantia.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cboDocumentos.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtFondoGarantia.Text.Trim()))
                {
                    MessageBox.Show("Ingrese un fonde de garantia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Decimal.Parse(txtFondoGarantia.Text.Trim()) > 100)
                {
                    MessageBox.Show("Ingrese un nro. porcentaje correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(cboIdTipoConfirmacion.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un tipo de confirmación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                } 

                _IdDocumento = cboDocumentos.SelectedValue.ToString();
                _vDocumento = cboDocumentos.Text;
                _FondoGarantia = string.IsNullOrEmpty(txtFondoGarantia.Text.Trim()) ? 0 : Convert.ToDecimal(txtFondoGarantia.Text.Trim());
                _IdTipoConfirmacion = cboIdTipoConfirmacion.SelectedValue.ToString();
                _IdTipoConfirmacion_Dsc = cboIdTipoConfirmacion.Text.ToString();
                _Interes = chkInteres.Checked ? true : false;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}