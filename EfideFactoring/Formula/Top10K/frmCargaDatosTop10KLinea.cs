using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.OleDb;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Top10K
{
    public partial class frmCargaDatosTop10KLinea : DevComponents.DotNetBar.OfficeForm
    {
        OleDbConnection cnExcel;

        public frmCargaDatosTop10KLinea()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                string srutaArchivo = string.Empty;
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Filter = "Archivos de Excel (*.xls) |*.xlsx";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.FileName = "";
                List<Tuple<string, string, string>> LstNoEncontrados = new List<Tuple<string, string, string>>();

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    srutaArchivo = openFileDialog1.FileName;

                    try
                    {
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
                        "From [Datos$A1:E20000] ", cnExcel);

                        DataTable dtTable = new DataTable();
                        daExcel.Fill(dtTable);

                        pbCargaTop10K.Value = 0;
                        pbCargaTop10K.Minimum = 0;
                        pbCargaTop10K.Maximum = dtTable.Rows.Count;
                        pbCargaTop10K.Step = 1;

                        int Count = 0;
                        int CountRegCargados = 0;
                        int CountRegNoCargados = 0;
                        lblRegistros.Text = CountRegCargados.ToString() + " registro(s) cargado(s)";
                        foreach (DataRow row in dtTable.Rows)
                        {
                            Count = 0;
                            EmpresaTopLineaBE IEntity = new EmpresaTopLineaBE();
                            string RUC = row[Count].ToString().Trim(); Count++;
                            string RazonSocial = row[Count].ToString().Trim(); Count++;
                            string Observacion = row[Count].ToString().Trim(); Count++;
                            string Linea = row[Count].ToString().Trim(); Count++;
                            string Estado = row[Count].ToString().Trim();
                            if (string.IsNullOrEmpty(RUC))
                            {
                                break;
                            }
                            IEntity.OPCION = 2;
                            IEntity.USUARIO = General.General.GetUsuario;
                            IEntity.vRuc = RUC;
                            IEntity.vRazonSocial = RazonSocial;
                            IEntity.vObservacion = Observacion;
                            IEntity.nLinea = string.IsNullOrEmpty(Linea) ? 0 : Convert.ToDecimal(Linea);
                            IEntity.cEstado = Estado;
                            try
                            {
                                new EmpresaTopLineaBL().ProcesarEmpresaTopLinea(IEntity);
                                CountRegCargados++;
                                lblRegistros.Text = CountRegCargados.ToString() + " registro(s) cargado(s)";
                            }
                            catch (Exception ex)
                            {
                                LstNoEncontrados.Add(new Tuple<string, string, string>(RUC, RazonSocial, ex.Message));
                                CountRegNoCargados++;
                            }
                            pbCargaTop10K.PerformStep();
                        }

                        cnExcel.Close();
                        dgvRegistrosNoCargados.DataSource = LstNoEncontrados;
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cnExcel.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
    }
}