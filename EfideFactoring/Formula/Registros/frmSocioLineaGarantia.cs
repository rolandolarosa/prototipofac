using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Registros
{
    public partial class frmSocioLineaGarantia : FormulaBase.frmMntDato
    {
        private TableBaseBL TableBaseBL = new TableBaseBL();
        SocioLineaGarantiaBL SocioLineaGarantiaBL = new SocioLineaGarantiaBL();
        public BindingList<SocioLineaGarantiaBE> _LstSocioLineaGarantia = new BindingList<SocioLineaGarantiaBE>();
        public string _IdPagadora = string.Empty;
        public string _IdLinea = string.Empty;
        public string _IdDocumento = string.Empty;
        public int IsLoadDocument = 0;
        byte[] bytes = null;

        public frmSocioLineaGarantia()
        {
            InitializeComponent();
        }

        private void frmSocioLineaGarantia_Load(object sender, EventArgs e)
        {
            String Table_Id = "00067";

            TableBaseBE TableBaseBE = new TableBaseBE
            {
                OPCION = 1,
                USUARIO = General.General.GetCodigoUsuario,
                Table_Parent_Id = Table_Id
            };

            General.General.LlenarCombobox(cboIdTipo_Documento_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
        }

        private void btnAdjuntarDocumento_Click(object sender, EventArgs e)
        {
            String curFileName = string.Empty;

            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "All PDF files|*.pdf";
            String filter = openDlg.Filter;
            openDlg.Title = "Open a PDF File";

            if (openDlg.ShowDialog() == DialogResult.OK) {
                curFileName = openDlg.FileName;
                txtRutaDocumento.Text = curFileName;
                //axAcroPDF1.src = curFileName;
                String strOnlyFileName = System.IO.Path.GetFileName(curFileName);
                txtDocumento.Text = strOnlyFileName;
                bytes = System.IO.File.ReadAllBytes(curFileName);

                //var tempFolder = System.IO.Path.GetTempPath();
                //strOnlyFileName = System.IO.Path.Combine(tempFolder, strOnlyFileName);
                //System.IO.File.WriteAllBytes(strOnlyFileName, bytes);
                //System.Diagnostics.Process.Start(strOnlyFileName);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bytes == null)
                {
                    MessageBox.Show("Debe adjuntar un documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(cboIdTipo_Documento_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Debe seleccionar un tipo de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdTipo_Documento_tt.Focus();
                    return;
                }

                SocioLineaGarantiaBE SocioLineaGarantiaBE = new SocioLineaGarantiaBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdLinea = _IdLinea,
                    IdPagadora = _IdPagadora,
                    IdDocumento = _IdDocumento,
                    IdTipo_Documento_tt = cboIdTipo_Documento_tt.SelectedValue.ToString(),
                    IdTipo_Documento_tt_Dsc = cboIdTipo_Documento_tt.Text,
                    Documento = txtDocumento.Text,
                    Archivo = bytes,
                    files = bytes.Length > 0 ? "Ver Archivo" : ""
                };

                _LstSocioLineaGarantia.Add(SocioLineaGarantiaBE);
                IsLoadDocument = 1;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}