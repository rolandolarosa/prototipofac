using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EfideFactoring.Formula.Legal
{
    public partial class frmMntSolicitudCheckListDato : FormulaBase.frmMntDato
    {
        public string _IdTipo_tt = string.Empty;
        public string _IdTipoSolicitud_tt = string.Empty;
        public string _NroIdentidadEntidad = string.Empty;
        public string _IdDocumento_tt = string.Empty;
        public frmMntSolicitudCheckListDato()
        {
            InitializeComponent();
        }

        #region eventos
        private void frmMntSolicitudCheckListDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                CargaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos
        private void LlenarCombos()
        {
            try
            {
                String Table_Id = "00301"; // Tipo CheckList
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 7,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id,
                    Table_Id = _IdTipoSolicitud_tt
                };
                General.General.LlenarCombobox(cboIdDocumento_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaDatos()
        {
            try
            {
                SolicitudCheckListBE oEntity = new SolicitudCheckListBE();
                oEntity.OPCION = 1;
                oEntity.IdSolicitud = Codigo;
                oEntity.IdDocumento_tt = _IdDocumento_tt;
                oEntity.IdTipo_tt = _IdTipo_tt;
                DataSet ds = new DataSet();
                ds = new SolicitudCheckListBL().ProcesarSolicitudCheckList(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cboIdDocumento_tt.SelectedValue = ds.Tables[0].Rows[0]["IdDocumento_tt"].ToString();
                    txtvDocumento.Text = ds.Tables[0].Rows[0]["vDocumento"].ToString();
                }
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
                    string fileName = cboIdDocumento_tt.SelectedValue.ToString().Trim() + _IdTipo_tt + strFechaActual + Path.GetExtension(openFileDialog1.FileName);
                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + _NroIdentidadEntidad + "//Adjuntos//" + Codigo + "//";
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
                if (string.IsNullOrEmpty(cboIdDocumento_tt.SelectedValue.ToString().Trim()))
                {
                    MessageBox.Show("Seleccione el tipo de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtvDocumento.Text.Trim()))
                {
                    MessageBox.Show("Se seleccionar el documento adjunto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SolicitudCheckListBE oEntity = new SolicitudCheckListBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSolicitud = Codigo;
                oEntity.IdDocumento_tt = cboIdDocumento_tt.SelectedValue.ToString();
                oEntity.IdTipo_tt = _IdTipo_tt;
                oEntity.vDocumento = txtvDocumento.Text.Trim();
                new SolicitudCheckListBL().ProcesarSolicitudCheckList(oEntity);
                MessageBox.Show("Se Guardo Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}