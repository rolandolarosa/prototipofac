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

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmCarteraSocioCarga : FormulaBase.frmMntDato
    {
        OleDbConnection cnExcel;
        public BindingList<CarteraSocioBE> LstCarteraSocioTmp = new BindingList<CarteraSocioBE>();
        public frmCarteraSocioCarga()
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
            LstCarteraSocioTmp = new BindingList<CarteraSocioBE>();

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
                    "From [Datos$A1:C20000] ", cnExcel);

                    DataTable dtTable = new DataTable();
                    daExcel.Fill(dtTable);

                    foreach (DataRow row in dtTable.Rows)
                    {
                        if (!string.IsNullOrEmpty(row["IdSocio"].ToString().Trim()) && !string.IsNullOrEmpty(row["UsuarioID"].ToString().Trim()))
                        {
                            CarteraSocioBE oCarteraSocioBE = new CarteraSocioBE()
                            {
                                OPCION = 2,
                                USUARIO = General.General.GetUsuario,
                                IdSocio = row["IdSocio"].ToString().Trim(),
                                UsuarioID = row["UsuarioID"].ToString().Trim(),
                                IdSocio_Dsc = row["Socio"].ToString().Trim(),
                            };
                            
                            if (new CarteraSocioBL().ProcesarCarteraSocio(oCarteraSocioBE).Tables[0].Rows.Count > 0)
                            {
                                LstCarteraSocioTmp.Add(oCarteraSocioBE);
                            }
                        }
                    }

                    dgvCargaSocios.DataSource = LstCarteraSocioTmp;
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
    }
}