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
    public partial class frmMntSolicitudRepresentanteDato : FormulaBase.frmMntDato
    {
        public string _IdTipo_tt = string.Empty;
        public string _IdRepresentante = string.Empty;
        public string _NroIdentidadEntidad = string.Empty;
        public frmMntSolicitudRepresentanteDato()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmMntSolicitudRepresentanteDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();

                if (Operacion.Equals("M"))
                {
                    CargarDatos();
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
                if (string.IsNullOrEmpty(txtvNombreRepresentante.Text.Trim()))
                {
                    MessageBox.Show("Ingrese el nombre del representante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(cboIdCargo_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Seleccione el cargo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(cboIdTipoDocumento_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Ingrese el tipo de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtvNroDocumento.Text.Trim()))
                {
                    MessageBox.Show("Ingrese el Nro. de documento de indentidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!cboIdTipoDocumento_tt.SelectedValue.Equals("00429")) // Carnet de Extranjeria
                {
                    if (string.IsNullOrEmpty(txtvFirmaAdjunta.Text.Trim()))
                    {
                        MessageBox.Show("Adjunte la firma escaneada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (!chkSinVigencia.Checked)
                {
                    if (dtVigencia.Value == DateTime.MinValue)
                    {
                        MessageBox.Show("Ingrese una fecha de vigencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    dtVigencia.Value = DateTime.Now.AddYears(50);
                }

                if (cboIdEstadoCivil_tt.SelectedValue.ToString().Equals("00438")) // Casado
                {
                    if (string.IsNullOrEmpty(txtvNombreConyuge.Text.Trim()))
                    {
                        MessageBox.Show("Ingresar el conyuge.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (string.IsNullOrEmpty(cboIdTipoDocumentoConyuge_tt.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Complete los datos del conyuge.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (string.IsNullOrEmpty(txtvNroDocConguge.Text.Trim()))
                    {
                        MessageBox.Show("Complete los datos del conyuge.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                SolicitudRepresentanteBE oEntity = new SolicitudRepresentanteBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSolicitud = Codigo;
                oEntity.IdTipo_tt = _IdTipo_tt;
                oEntity.IdRepresentante = txtIdRepresentante.Text;
                oEntity.vNombreRepresentante = txtvNombreRepresentante.Text;
                oEntity.IdCargo_tt = cboIdCargo_tt.SelectedValue.ToString();
                oEntity.IdTipoDocumento_tt = cboIdTipoDocumento_tt.SelectedValue.ToString();
                oEntity.vNroDocumento = txtvNroDocumento.Text;
                oEntity.IdEstadoCivil_tt = cboIdEstadoCivil_tt.SelectedValue.ToString();
                oEntity.vObjetoSocial = txtvObjetoSocial.Text;
                oEntity.vDomicilio = txtvDomicilio.Text;
                oEntity.IdTipoDocumentoApoderado_tt = cboIdTipoDocumentoApoderado_tt.SelectedValue == null ? "" : cboIdTipoDocumentoApoderado_tt.SelectedValue.ToString();
                oEntity.vNroDocApoderado = txtvNroDocApoderado.Text;
                oEntity.vNombreApoderado = txtvNombreApoderado.Text;
                oEntity.vDomicilioApoderado = txtvDomicilioApoderado.Text;
                oEntity.IdCargoApoderado_tt = cboIdCargoApoderado_tt.SelectedValue == null ? "" : cboIdCargoApoderado_tt.SelectedValue.ToString();
                oEntity.IdTipoDocumentoApoderado1_tt = cboIdTipoDocumentoApoderado1_tt.SelectedValue  == null ? "" : cboIdTipoDocumentoApoderado1_tt.SelectedValue.ToString();
                oEntity.vNroDocApoderado1 = txtvNroDocApoderado1.Text;
                oEntity.vNombreApoderado1 = txtvNombreApoderado1.Text;
                oEntity.vDomicilioApoderado1 = txtvDomicilioApoderado1.Text;
                oEntity.IdCargoApoderado1_tt = cboIdCargoApoderado1_tt.SelectedValue == null ? "" : cboIdCargoApoderado1_tt.SelectedValue.ToString();
                oEntity.IdTipoDocumentoConyuge_tt = cboIdTipoDocumentoConyuge_tt.SelectedValue == null ? "" : cboIdTipoDocumentoConyuge_tt.SelectedValue.ToString();
                oEntity.vNroDocConguge = txtvNroDocConguge.Text;
                oEntity.vNombreConyuge = txtvNombreConyuge.Text;
                oEntity.vDomicilioConyuge = txtvDomicilioConyuge.Text;
                oEntity.dtVigencia = dtVigencia.Value;
                oEntity.vFirmaAdjunta = txtvFirmaAdjunta.Text;
                oEntity.vFirmaAdjunta1 = txtvFirmaAdjunta1.Text;
                oEntity.vFirmaAdjunta2 = txtvFirmaAdjunta2.Text;
                oEntity.vObservacion = txtvObservacion.Text;
                new SolicitudRepresentanteBL().ProcesarSolicitudRepresentante(oEntity);

                MessageBox.Show("Se Guardo Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
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
                openFileDialog1.Filter = "Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string strFechaActual = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                    string fileName = Codigo.Trim() + _IdTipo_tt + strFechaActual + Path.GetExtension(openFileDialog1.FileName);
                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + _NroIdentidadEntidad + "//Firmas//";
                    if (!Directory.Exists(filepath))
                        System.IO.Directory.CreateDirectory(filepath);
                    System.IO.File.Copy(openFileDialog1.FileName, filepath + fileName);
                    pictureBox1.Image = Image.FromFile(filepath + fileName);
                    txtvFirmaAdjunta.Text = fileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdTipoDocumento_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtvNroDocApoderado.ReadOnly = true;
                txtvNombreApoderado.ReadOnly = true;
                txtvDomicilioApoderado.ReadOnly = true;
                txtvObjetoSocial.ReadOnly = true;
                Tab1.Visible = false;
                Tab2.Visible = false;
                cboIdEstadoCivil_tt.Enabled = true;
                STControlApoderados.Enabled = false;

                if (cboIdTipoDocumento_tt.SelectedValue.ToString().Equals("00136")) //RUC
                {
                    Tab1.Visible = true;
                    Tab2.Visible = true;
                    STControlApoderados.Enabled = true;
                    txtvNroDocApoderado.ReadOnly = false;
                    txtvNombreApoderado.ReadOnly = false;
                    txtvDomicilioApoderado.ReadOnly = false;
                    txtvObjetoSocial.ReadOnly = false;
                    cboIdEstadoCivil_tt.SelectedValue = string.Empty;
                    cboIdEstadoCivil_tt.Enabled = false;
                }
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
                String Table_Id = "00009"; // Cargos
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdCargo_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
                General.General.LlenarCombobox(cboIdCargoApoderado_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
                General.General.LlenarCombobox(cboIdCargoApoderado1_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00134"; // Tipos de Documentos
                General.General.LlenarCombobox(cboIdTipoDocumento_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                General.General.LlenarCombobox(cboIdTipoDocumentoApoderado_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
                General.General.LlenarCombobox(cboIdTipoDocumentoApoderado1_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
                General.General.LlenarCombobox(cboIdTipoDocumentoConyuge_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00436"; //Estado Civil
                General.General.LlenarCombobox(cboIdEstadoCivil_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos()
        {
            try
            {
                SolicitudRepresentanteBE oEntity = new SolicitudRepresentanteBE();
                oEntity.OPCION = 1;
                oEntity.IdSolicitud = Codigo;
                oEntity.IdTipo_tt = _IdTipo_tt;
                oEntity.IdRepresentante = _IdRepresentante;
                DataSet ds = new SolicitudRepresentanteBL().ProcesarSolicitudRepresentante(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtIdRepresentante.Text = ds.Tables[0].Rows[0]["IdRepresentante"].ToString();
                    txtvNombreRepresentante.Text = ds.Tables[0].Rows[0]["vNombreRepresentante"].ToString();
                    cboIdCargo_tt.SelectedValue = ds.Tables[0].Rows[0]["IdCargo_tt"].ToString();
                    cboIdTipoDocumento_tt.SelectedValue = ds.Tables[0].Rows[0]["IdTipoDocumento_tt"].ToString();
                    txtvNroDocumento.Text = ds.Tables[0].Rows[0]["vNroDocumento"].ToString();
                    cboIdEstadoCivil_tt.SelectedValue = ds.Tables[0].Rows[0]["IdEstadoCivil_tt"].ToString();
                    txtvObjetoSocial.Text = ds.Tables[0].Rows[0]["vObjetoSocial"].ToString();
                    txtvDomicilio.Text = ds.Tables[0].Rows[0]["vDomicilio"].ToString();
                    cboIdTipoDocumentoApoderado_tt.SelectedValue = ds.Tables[0].Rows[0]["IdTipoDocumentoApoderado_tt"].ToString();
                    txtvNroDocApoderado.Text = ds.Tables[0].Rows[0]["vNroDocApoderado"].ToString();
                    txtvNombreApoderado.Text = ds.Tables[0].Rows[0]["vNombreApoderado"].ToString();
                    txtvDomicilioApoderado.Text = ds.Tables[0].Rows[0]["vDomicilioApoderado"].ToString();
                    cboIdCargoApoderado_tt.SelectedValue = ds.Tables[0].Rows[0]["IdCargoApoderado_tt"].ToString();
                    cboIdTipoDocumentoApoderado1_tt.SelectedValue = ds.Tables[0].Rows[0]["IdTipoDocumentoApoderado1_tt"].ToString();
                    txtvNroDocApoderado1.Text = ds.Tables[0].Rows[0]["vNroDocApoderado1"].ToString();
                    txtvNombreApoderado1.Text = ds.Tables[0].Rows[0]["vNombreApoderado1"].ToString();
                    txtvDomicilioApoderado1.Text = ds.Tables[0].Rows[0]["vDomicilioApoderado1"].ToString();
                    cboIdCargoApoderado1_tt.SelectedValue = ds.Tables[0].Rows[0]["IdCargoApoderado1_tt"].ToString();
                    cboIdTipoDocumentoConyuge_tt.SelectedValue = ds.Tables[0].Rows[0]["IdTipoDocumentoConyuge_tt"].ToString();
                    txtvNroDocConguge.Text = ds.Tables[0].Rows[0]["vNroDocConguge"].ToString();
                    txtvNombreConyuge.Text = ds.Tables[0].Rows[0]["vNombreConyuge"].ToString();
                    txtvDomicilioConyuge.Text = ds.Tables[0].Rows[0]["vDomicilioConyuge"].ToString();

                    //txtvDomicilioApoderado.Text = ds.Tables[0].Rows[0]["vDomicilioApoderado"].ToString();

                    txtvDomicilio.Text = ds.Tables[0].Rows[0]["vDomicilio"].ToString();
                    dtVigencia.Value = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["dtVigencia"].ToString()) ? DateTime.MinValue : DateTime.Parse(ds.Tables[0].Rows[0]["dtVigencia"].ToString());
                    chkSinVigencia.Checked = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["dtVigencia"].ToString()) ? true : false;
                    txtvFirmaAdjunta.Text = ds.Tables[0].Rows[0]["vFirmaAdjunta"].ToString();
                    txtvFirmaAdjunta1.Text = ds.Tables[0].Rows[0]["vFirmaAdjunta1"].ToString();
                    txtvFirmaAdjunta2.Text = ds.Tables[0].Rows[0]["vFirmaAdjunta2"].ToString();
                    txtvObservacion.Text = ds.Tables[0].Rows[0]["vObservacion"].ToString();

                    if (!string.IsNullOrEmpty(txtvFirmaAdjunta.Text))
                    {
                        string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + _NroIdentidadEntidad + "//Firmas//";
                        pictureBox1.Image = Image.FromFile(filepath + txtvFirmaAdjunta.Text.Trim());
                    }

                    if (!string.IsNullOrEmpty(txtvFirmaAdjunta1.Text))
                    {
                        string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + _NroIdentidadEntidad + "//Firmas//";
                        pictureBox2.Image = Image.FromFile(filepath + txtvFirmaAdjunta1.Text.Trim());
                    }

                    if (!string.IsNullOrEmpty(txtvFirmaAdjunta2.Text))
                    {
                        string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + _NroIdentidadEntidad + "//Firmas//";
                        pictureBox3.Image = Image.FromFile(filepath + txtvFirmaAdjunta2.Text.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void cboIdEstadoCivil_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Tab3.Visible = false;
                STControlApoderados.Enabled = false;
                if (cboIdEstadoCivil_tt.SelectedValue.ToString().Equals("00438")) //Casado
                {
                    Tab3.Visible = true;
                    STControlApoderados.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdjuntar1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Filter = "Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string strFechaActual = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                    string fileName = Codigo.Trim() + _IdTipo_tt + strFechaActual + Path.GetExtension(openFileDialog1.FileName);
                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + _NroIdentidadEntidad + "//Firmas//";
                    if (!Directory.Exists(filepath))
                        System.IO.Directory.CreateDirectory(filepath);
                    System.IO.File.Copy(openFileDialog1.FileName, filepath + fileName);
                    pictureBox2.Image = Image.FromFile(filepath + fileName);
                    txtvFirmaAdjunta1.Text = fileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdjuntar2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Filter = "Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string strFechaActual = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                    string fileName = Codigo.Trim() + _IdTipo_tt + strFechaActual + Path.GetExtension(openFileDialog1.FileName);
                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + _NroIdentidadEntidad + "//Firmas//";
                    if (!Directory.Exists(filepath))
                        System.IO.Directory.CreateDirectory(filepath);
                    System.IO.File.Copy(openFileDialog1.FileName, filepath + fileName);
                    pictureBox3.Image = Image.FromFile(filepath + fileName);
                    txtvFirmaAdjunta2.Text = fileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarImg1_Click(object sender, EventArgs e)
        {
            try
            {
                txtvFirmaAdjunta.Clear();
                pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarImg2_Click(object sender, EventArgs e)
        {
            try
            {
                txtvFirmaAdjunta1.Clear();
                pictureBox2.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarImg3_Click(object sender, EventArgs e)
        {
            try
            {
                txtvFirmaAdjunta2.Clear();
                pictureBox3.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}