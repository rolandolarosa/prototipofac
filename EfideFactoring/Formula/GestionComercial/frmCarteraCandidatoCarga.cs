using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoring.General;
using System.Data.OleDb;
using EfideFactoringBE;
using EfideFactoringBL;
using System.Reflection;
using System.IO;

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmCarteraCandidatoCarga : FormulaBase.frmMntDato
    {
        OleDbConnection cnExcel;
        public BindingList<CarteraCandidatoBE> LstCarteraCandidatoTmp = new BindingList<CarteraCandidatoBE>();
        public BindingList<CarteraCandidatoBE> LstCarteraCandidatoExitsTmp = new BindingList<CarteraCandidatoBE>();
        public int _FlgPagadora = 0;
        public frmCarteraCandidatoCarga()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string srutaArchivo = string.Empty;
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Archivos de Excel (*.xls) |*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            LstCarteraCandidatoTmp = new BindingList<CarteraCandidatoBE>();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                srutaArchivo = openFileDialog1.FileName;

                try
                {
                    msgHelper.Wait("Cargando registros, espere un momento ...");
                    cnExcel = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + srutaArchivo + ";Extended Properties='Excel 12.0 Xml;HDR=YES';");

                    if (cnExcel.State == ConnectionState.Closed)
                    {
                        cnExcel.Open();
                    }

                    if (!System.IO.File.Exists(srutaArchivo))
                    {
                        MessageBox.Show("No se encontró el Libro: " + srutaArchivo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    OleDbDataAdapter daExcel = new OleDbDataAdapter("Select * " +
                    "From [Candidatos$A1:T20000] ", cnExcel);

                    DataTable dtTable = new DataTable();
                    daExcel.Fill(dtTable);
                    int CountNuevos = 0;
                    int CountExistentes = 0;

                    foreach (DataRow row in dtTable.Rows)
                    {
                        if (!string.IsNullOrEmpty(row["UsuarioID"].ToString().Trim()))
                        {
                            CarteraCandidatoBE oCarteraCandidatoBE = new CarteraCandidatoBE()
                            {
                                OPCION = 2,
                                USUARIO = General.General.GetUsuario,
                                cRucPagadora = row["RucPagadora"].ToString().Trim(),
                                vApePaterno = row["ApePaterno"].ToString().Trim(),
                                vApeMaterno = row["ApeMaterno"].ToString().Trim(),
                                vNombre = row["Nombre"].ToString().Trim(),
                                IdTipoDocumento_tt = row["IdTipoDocumento_tt"].ToString().Trim(),
                                IdTipoDocumento_tt_Dsc = row["Documento"].ToString().Trim(),
                                vNroDocumento = row["NroDocumento"].ToString().Trim(),
                                IdTipoPersona_tt = row["IdTipoPersona_tt"].ToString().Trim(),
                                cGlobal_TipoEmpresa = string.IsNullOrEmpty(row["TipoProveedor"].ToString().Trim()) ? 0 : int.Parse(row["cGlobal_TipoEmpresa"].ToString()),
                                cGlobal_TipoRiesgo = string.IsNullOrEmpty(row["CalificacionExterna"].ToString().Trim()) ? 0 : int.Parse(row["cGlobal_TipoRiesgo"].ToString()),
                                IdTipoPersona_tt_Dsc = row["TipoPersona"].ToString().Trim(),
                                vContacto = row["Contacto"].ToString().Trim(),
                                vCargo = row["Cargo"].ToString().Trim(),
                                vTelefono1 = row["Telefono1"].ToString().Trim(),
                                vTelefono2 = row["Telefono2"].ToString().Trim(),
                                vTelefono3 = row["Telefono3"].ToString().Trim(),
                                vCorreo = row["Correo"].ToString().Trim(),
                                FlgPagadora = _FlgPagadora,
                                UsuarioID = row["UsuarioID"].ToString().Trim(),
                            };

                            DataSet ds = new CarteraCandidatoBL().ProcesarCarteraCandidato(oCarteraCandidatoBE);

                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                if (ds.Tables[0].Rows[0]["Status"].ToString().Equals("E"))
                                {
                                    CountExistentes = CountExistentes + 1;
                                    LstCarteraCandidatoExitsTmp.Add(oCarteraCandidatoBE);
                                }
                                else
                                {
                                    CountNuevos = CountNuevos + 1;
                                    LstCarteraCandidatoTmp.Add(oCarteraCandidatoBE);
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    lblProspectosNuevos.Text = "Prospectos que subieron correctamente " + CountNuevos.ToString();
                    lblExistentes.Text = "Prospectos que ya existen en la cartera " + CountExistentes.ToString();
                    dgvCandidatosExistentes.DataSource = LstCarteraCandidatoExitsTmp;
                    dgvCargaCandidato.DataSource = LstCarteraCandidatoTmp;
                    cnExcel.Close();
                    btnImportar.Enabled = false;
                    msgHelper.Wait();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cnExcel.Close();
                    msgHelper.Wait();
                }
            }
        }

        private void btnPlantilla_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.FileName = "CargaProspectos";
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx |All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string MyFileName = System.Configuration.ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "Plantillas//Plantilla_CargaCandidatos.xlsx";
                    string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    var filePath = Path.Combine(execPath, MyFileName);
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook book = app.Workbooks.Open(filePath);
                    book.SaveAs(saveFileDialog.FileName); //Save
                    book.Close();

                    MessageBox.Show("Se guardó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}