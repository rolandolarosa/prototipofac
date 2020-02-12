using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace EfideFactoring.General
{
    public class WordDocumentWrite
    {
        private Word.Application wordApp;
        private Word.Document aDoc;
        private object missing = Missing.Value;
        private object filename;

        public void WordDocument(string Document, string DirectorioPCUsert)
        {
            try
            {
                //string DirectorioPCUsert = ConfigurationManager.AppSettings["RutaPCUsertTmp"].ToString();
                string strFechaActual = DateTime.Now.ToString("yyyyddMHHss");
                string DocumentTemp = Path.GetFileNameWithoutExtension(Document) + strFechaActual + Path.GetExtension(Document);
                DocumentTemp = DocumentTemp.Replace(" ", "");
                if (!Directory.Exists(DirectorioPCUsert))
                    System.IO.Directory.CreateDirectory(DirectorioPCUsert);

                File.Copy(ConfigurationManager.AppSettings["RutaFormatoLegal"].ToString() + Document, Path.Combine(Application.StartupPath, DirectorioPCUsert + DocumentTemp), true);
                wordApp = new Word.Application();
                filename = Path.Combine(Application.StartupPath, DirectorioPCUsert + DocumentTemp);

                if (File.Exists((string)filename))
                {
                    object readOnly = false;
                    object isVisible = false;
                    wordApp.Visible = false;
                    aDoc = wordApp.Documents.Open(ref filename, ref missing,
                    ref readOnly, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref isVisible, ref missing, ref missing,
                    ref missing, ref missing);
                    aDoc.Activate();
                }
                else
                {
                    MessageBox.Show("El archivo no existe.", "Sin archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante el proceso. Descripcion: " + ex.Message, "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveDocument()
        {
            try
            {
                aDoc.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante el proceso. Descripcion: " + ex.Message, "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseDocument()
        {
            try
            {
                object saveChanges = Word.WdSaveOptions.wdSaveChanges;
                wordApp.Quit(ref saveChanges, ref missing, ref missing);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante el proceso. Descripcion: " + ex.Message, "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FindAndReplace(object findText, object replaceText)
        {
            try
            {
                this.findAndReplace(wordApp, findText, replaceText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void findAndReplace(Word.Application wordApp, object findText, object replaceText)
        {
            try
            {
                object matchCase = true;
                object matchWholeWord = true;
                object matchWildCards = false;
                object matchSoundsLike = false;
                object matchAllWordForms = false;
                object forward = true;
                object format = false;
                object matchKashida = false;
                object matchDiacritics = false;
                object matchAlefHamza = false;
                object matchControl = false;
                object read_only = false;
                object visible = true;
                object replace = 2;
                object wrap = 1;
                wordApp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms,
                ref forward, ref wrap, ref format, ref replaceText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
    }
}
