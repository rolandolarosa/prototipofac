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
using EfideFactoring.General;
using System.Data.OleDb;

namespace EfideFactoring.Formula.Top10K
{
    public partial class frmCargaDatosSentinel : DevComponents.DotNetBar.OfficeForm
    {
        OleDbConnection cnExcel;

        public frmCargaDatosSentinel()
        {
            InitializeComponent();
        }

        private void frmCargaDatosSentinel_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCombos()
        {
            try
            {
                EmpresaSentinelBE IEntity = new EmpresaSentinelBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                };
                General.General.LlenarCombobox(cboPeriodo, "Descripcion", "Periodo", new EmpresaSentinelBL().ProcesarEmpresaSentinel(IEntity).Tables[0]);
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
                if (string.IsNullOrEmpty(cboPeriodo.SelectedValue.ToString()))
                {
                    MessageBox.Show("Seleccione un Periodo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                string srutaArchivo = string.Empty;
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Filter = "Archivos de Excel (*.xls) |*.xlsx";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.FileName = "";
                List<Tuple<string, string>> LstNoCargados = new List<Tuple<string, string>>();

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
                        "From [Hoja1$A1:H20000] ", cnExcel);

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
                            EmpresaSentinelBE IEntity = new EmpresaSentinelBE();
                            //TDoc,	NDoc,	Calificacion24Meses,	Endeudamiento DD Y DI,	RangoEndeudamiento DD Y DI,	DeudasCoactivasSunat,
                            //ProtestosNoRegularisados (mayores a 365 días), Creditos(DCastigada,Reestructurado,Refinanciado)
                            Count++;
                            string RUC = row[Count].ToString().Trim(); Count++;
                            if (string.IsNullOrEmpty(RUC))
                            {
                                break;
                            }
                            IEntity.OPCION = 2;
                            IEntity.USUARIO = General.General.GetUsuario;
                            IEntity.Periodo = cboPeriodo.SelectedValue.ToString();
                            IEntity.RUC = RUC;
                            IEntity.CalificacionNormal = row[Count].ToString().Trim(); Count++;
                            IEntity.DeudaDirectoIndirecto = row[Count].ToString().Trim(); Count++;
                            IEntity.RangoDeuda = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.DeudaCoativa = row[Count].ToString().Trim(); Count++;
                            IEntity.ProtestoNoRegularisado = row[Count].ToString().Trim(); Count++;
                            IEntity.Creditos = row[Count].ToString().Trim(); Count++;

                            try
                            {
                                new EmpresaSentinelBL().ProcesarEmpresaSentinel(IEntity);
                                CountRegCargados++;
                                lblRegistros.Text = CountRegCargados.ToString() + " registro(s) cargado(s)";
                            }
                            catch (Exception ex)
                            {
                                LstNoCargados.Add(new Tuple<string, string>(RUC, ex.Message));
                                CountRegNoCargados++;
                            }
                            pbCargaTop10K.PerformStep();
                        }

                        cnExcel.Close();
                        lblRegNoCargados.Text = CountRegNoCargados.ToString() + " registro(s) que no se cargaron";
                        dgvRegistrosNoCargados.DataSource = LstNoCargados;
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