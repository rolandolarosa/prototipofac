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
using System.Data.OleDb;

namespace EfideFactoring.Formula.Top10K
{
    public partial class frmCargaDatosTop : FormulaBase.frmMntDato
    {
        OleDbConnection cnExcel;
        public frmCargaDatosTop()
        {
            InitializeComponent();
        }

        private void frmCargaDatosTop_Load(object sender, EventArgs e)
        {
            try
            {
                txtYear.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtYear.Text))
                {
                    MessageBox.Show("Ingresar un año a cargar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                if (txtYear.Text.Trim().Length != 4)
                {
                    MessageBox.Show("El año debe ser de 4 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                try
                {
                    DateTime dt = new DateTime(int.Parse(txtYear.Text), 1, 1);
                }
                catch
                {
                    MessageBox.Show("Ingresar un año valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string srutaArchivo = string.Empty;
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Filter = "Archivos de Excel (*.xls) |*.xlsx";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.FileName = "";
                List<Tuple<string, string>> LstNoEncontrados = new List<Tuple<string, string>>();

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
                        "From [Sheet1$A1:AN20000] ", cnExcel);

                        DataTable dtTable = new DataTable();
                        daExcel.Fill(dtTable);

                        pbCargaTop10K.Value = 0;
                        pbCargaTop10K.Minimum = 0;
                        pbCargaTop10K.Maximum = dtTable.Rows.Count;
                        pbCargaTop10K.Step = 1;

                        int CountRegCargados = 0;
                        int Count = 0;
                        int CountRegNoCargados = 0;
                        lblRegistros.Text = CountRegCargados.ToString() + " registro(s) cargado(s)";
                        foreach (DataRow row in dtTable.Rows)
                        {
                            if (Count == 0)
                            {
                                Count++;
                                continue;
                            }

                            RepositorioTopBE IEntity = new RepositorioTopBE();
                            string RUC = row[0].ToString().Trim();
                            string RazonSocial = row[1].ToString().Trim();
                            if (string.IsNullOrEmpty(RUC))
                            {
                                break;
                            }
                            IEntity.OPCION = 2;
                            IEntity.USUARIO = General.General.GetUsuario;
                            IEntity.Year = txtYear.Text.Trim();
                            IEntity.cRuc = RUC;
				            IEntity.vSectorEsp = row[7].ToString().Trim();
				            IEntity.vMagnitudEmpresa = row[8].ToString().Trim();
				            IEntity.vRanking = row[9].ToString().Trim();
				            IEntity.nFacturadoMax = string.IsNullOrEmpty(row[12].ToString()) ? 0 : Convert.ToDecimal(row[12].ToString());
				            IEntity.vTipoEmpresa = row[15].ToString().Trim();
				            IEntity.vPagWeb = row[27].ToString().Trim();
				            IEntity.vNroTrabajador = row[29].ToString().Trim();
				            IEntity.vNroSucursales = row[30].ToString().Trim();
				            IEntity.vResolucionContribuyente = row[31].ToString().Trim();
                            IEntity.nUtilidadNeta = string.IsNullOrEmpty(row[32].ToString()) ? 0 : Convert.ToDecimal(row[32].ToString());
                            IEntity.nTotalActivo = string.IsNullOrEmpty(row[33].ToString()) ? 0 : Convert.ToDecimal(row[33].ToString());
                            IEntity.nPatrimonio = string.IsNullOrEmpty(row[34].ToString()) ? 0 : Convert.ToDecimal(row[34].ToString());
                            IEntity.nTotalPasivo = string.IsNullOrEmpty(row[35].ToString()) ? 0 : Convert.ToDecimal(row[35].ToString());
                            IEntity.nTotalVenta = string.IsNullOrEmpty(row[37].ToString()) ? 0 : Convert.ToDecimal(row[37].ToString());
				            IEntity.vFacebook = row[38].ToString().Trim();
                            IEntity.vTwitter = row[39].ToString().Trim();

                            try
                            {
                                new RepositorioTopBL().ProcesarRepositorioTop(IEntity);
                                CountRegCargados++;
                                lblRegistros.Text = CountRegCargados.ToString() + " registro(s) cargado(s)";
                            }
                            catch (Exception ex)
                            {
                                LstNoEncontrados.Add(new Tuple<string, string>(RUC, RazonSocial));
                                CountRegNoCargados++;
                            }
                            pbCargaTop10K.PerformStep();
                            Count++;
                        }

                        cnExcel.Close();
                        lblRegNoCargados.Text = CountRegNoCargados.ToString() + " registro(s) que no se cargaron";
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
            }
        }
    }
}