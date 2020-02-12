using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using System.Configuration;

namespace EfideFactoring.Formula.Registros
{
    public partial class frmMntLoteDatoArchivo : FormulaBase.frmMntDato
    {
        public frmMntLoteDatoArchivo()
        {
            InitializeComponent();
        }

        private void btnAdjuntarArchivo1_Click(object sender, EventArgs e)
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
                    string fileName = Codigo + "_1" + Path.GetExtension(openFileDialog1.FileName);
                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + Codigo + "//";
                    if (!Directory.Exists(filepath))
                        System.IO.Directory.CreateDirectory(filepath);
                    System.IO.File.Copy(openFileDialog1.FileName, filepath + fileName);

                    //actualizar imagen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdjuntarArchivo2_Click(object sender, EventArgs e)
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
                    string fileName = Codigo + "_2" + Path.GetExtension(openFileDialog1.FileName);
                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + Codigo + "//";
                    if (!Directory.Exists(filepath))
                        System.IO.Directory.CreateDirectory(filepath);
                    System.IO.File.Copy(openFileDialog1.FileName, filepath + fileName);

                    //actualizar imagen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }
    }
}