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

namespace EfideFactoring.Formula.Catalogo
{
    public partial class frmMntDocumentoDato : FormulaBase.frmMntDato
    {
        DocumentoBL DocumentoBL = new DocumentoBL();

        public frmMntDocumentoDato()
        {
            InitializeComponent();
        }

        #region Eventos ---------------------------------------------
        private void frmMntDocumentoDato_Load(object sender, EventArgs e)
        {
            if (Operacion.Equals("N"))
            {
            }
            else if (Operacion.Equals("M"))
            {
                txtCodigo.Text = Codigo;
                CargarDatos();
            }
            else
            {
                txtCodigo.Text = Codigo;
                txtDocumento.ReadOnly = true;
                txtAbreviatura.ReadOnly = true;
                txtMascara.ReadOnly = true;
                CheckTituloValor.Enabled = false;
                CargarDatos();
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDocumento.Text.Trim()))
                {
                    MessageBox.Show("Se debe Ingresar un Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtAbreviatura.Text.Trim()))
                {
                    MessageBox.Show("Se debe Ingresar una Abreviatura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string FlgFisicoElectronico = string.Empty;
                if (rdbFisico.Checked){ FlgFisicoElectronico = "1"; } else if (rdbElectronico.Checked){ FlgFisicoElectronico = "2";}

                DocumentoBE DocumentoBE = new DocumentoBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetUsuario,
                    IdDocumento = txtCodigo.Text.Trim(),
                    vDocumento = txtDocumento.Text.Trim(),
                    cAbreviatura = txtAbreviatura.Text.Trim(),
                    vMascara = txtMascara.Text.Trim(),
                    bTituloValor = CheckTituloValor.Checked == true ? true : false,
                    FlgFisicoElectronico = FlgFisicoElectronico,
                    FlgImportePago = chkFlgImportePago.Checked == true ? "1" : "0",
                };

                DocumentoBL.ProcesarDocumento(DocumentoBE);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Metodos ---------------------------------------------
        private void CargarDatos()
        {
            try
            {
                DataSet ds = new DataSet();
                DocumentoBE DocumentoBE = new DocumentoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdDocumento = txtCodigo.Text.Trim()
                };

                ds = DocumentoBL.ProcesarDocumento(DocumentoBE);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtDocumento.Text = ds.Tables[0].Rows[0]["vDocumento"].ToString();
                    txtAbreviatura.Text = ds.Tables[0].Rows[0]["cAbreviatura"].ToString();
                    txtMascara.Text = ds.Tables[0].Rows[0]["vMascara"].ToString();
                    CheckTituloValor.CheckValue = ds.Tables[0].Rows[0]["bTituloValor"];
                    if (ds.Tables[0].Rows[0]["FlgFisicoElectronico"].ToString().Equals("1")) { rdbFisico.Checked = true; } else if (ds.Tables[0].Rows[0]["FlgFisicoElectronico"].ToString().Equals("2")) { rdbElectronico.Checked = true; }
                    if (ds.Tables[0].Rows[0]["FlgImportePago"].ToString().Equals("1")) { chkFlgImportePago.Checked = true; } 
                }
                else
                {
                    MessageBox.Show("Este Documento no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}