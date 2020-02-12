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
using System.IO;

namespace EfideFactoring.Formula.Legal
{
    public partial class frmMntBovedaDetalleDato : FormulaBase.frmMntDato
    {
        public string _IdFormatoDocLegal_tt = string.Empty;
        public string _IdFormatoDocLegal_tt_Dsc = string.Empty;
        public frmMntBovedaDetalleDato()
        {
            InitializeComponent();
        }

        private void frmMntBovedaDetalleDato_Load(object sender, EventArgs e)
        {
            try
            {
                lblDocumento.Text = _IdFormatoDocLegal_tt_Dsc;
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Filter = "Files(*.jpg; *.jpeg)|*.jpg; *.jpeg | Pdf Files|*.pdf";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string strFechaActual = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                    string fileName = Codigo.Trim() + _IdFormatoDocLegal_tt + strFechaActual + Path.GetExtension(openFileDialog1.FileName);
                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//Boveda//" + Codigo + "//";
                    if (!Directory.Exists(filepath))
                        System.IO.Directory.CreateDirectory(filepath);
                    System.IO.File.Copy(openFileDialog1.FileName, filepath + fileName);
                    txtvDocumento.Text = fileName;
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
                if (string.IsNullOrEmpty(txtvDocumento.Text.Trim()))
                {
                    MessageBox.Show("Se seleccionar el documento adjunto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                BovedaDetalleBE oEntity = new BovedaDetalleBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdBoveda = Codigo;
                oEntity.IdFormatoDocLegal_tt = _IdFormatoDocLegal_tt;
                oEntity.vArchivoAdjunto = txtvDocumento.Text.Trim();
                oEntity.dtAdjunto = DateTime.Now;
                new BovedaDetalleBL().ProcesarBovedaDetalle(oEntity);
                MessageBox.Show("Se Guardo Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}