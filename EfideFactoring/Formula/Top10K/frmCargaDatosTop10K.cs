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

namespace EfideFactoring.Formula.Top10K
{
    public partial class frmCargaDatosTop10K : DevComponents.DotNetBar.OfficeForm
    {
        OleDbConnection cnExcel;

        public frmCargaDatosTop10K()
        {
            InitializeComponent();
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
                        "From [Sheet1$A1:CH20000] ", cnExcel);

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
                            EmpresaTopBE IEntity = new EmpresaTopBE();
                            //RUC	Razón Social	Nombre Comercial	Ciiu	Ciiu 5dig	Sector Esp	Sector Ing	Subsector Esp	Ciiu Esp Detalle	Ciiu Ing Detalle
                            //Productos Servicios	Grupo	Partgrupo	Listada Bolsa	Regulada Sbs
                            string RUC = row[Count].ToString().Trim(); Count++;
                            string RazonSocial = row[Count].ToString().Trim(); Count++;
                            if (string.IsNullOrEmpty(RUC))
                            {
                                break;
                            }
                            IEntity.OPCION = 2;
                            IEntity.USUARIO = General.General.GetUsuario;
                            IEntity.Year = txtYear.Text.Trim();
                            IEntity.RUC = RUC;
                            IEntity.RazonSocial = RazonSocial;
                            IEntity.NombreComercial = row[Count].ToString().Trim(); Count++;
                            IEntity.CIIU = row[Count].ToString().Trim(); Count++;
                            IEntity.CIIU5 = row[Count].ToString().Trim(); Count++;
                            IEntity.SectorEsp = row[Count].ToString().Trim(); Count++;
                            IEntity.SectorIng = row[Count].ToString().Trim(); Count++;
                            IEntity.SubsectorEsp = row[Count].ToString().Trim(); Count++;
                            IEntity.CIIUEspDetalle = row[Count].ToString().Trim(); Count++;
                            IEntity.CIIUIngDetalle = row[Count].ToString().Trim(); Count++;
                            IEntity.ProductosServicios = row[Count].ToString().Trim(); Count++;
                            IEntity.Grupo = row[Count].ToString().Trim(); Count++;
                            IEntity.Partgrupo = row[Count].ToString().Trim(); Count++;
                            IEntity.ListadaBolsa = row[Count].ToString().Trim(); Count++;
                            IEntity.ReguladaSbs = row[Count].ToString().Trim(); Count++;
                            //N Trabajadores,	N Sucursales,	Fecha Fundacion, AÑos De Funcionamiento,Tamano De Empresa,	Extranjera,	Porcextranjera,	Estatal,
                            //Porcestatal,	Situación,	Direccion,	Distrito,	Provincia,	Departamento,	Telefono1,
                            IEntity.NTrabajadores = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : int.Parse(row[Count].ToString()); Count++;
                            IEntity.NSucursales = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : int.Parse(row[Count].ToString()); Count++;
                            IEntity.FechaFundacion = row[Count].ToString().Trim(); Count++;
                            IEntity.AniosFuncionamiento = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.TamanoEmpresa = row[Count].ToString().Trim(); Count++;
                            IEntity.Extranjera = row[Count].ToString().Trim(); Count++;
                            IEntity.PorcExtranjera = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.Estatal = row[Count].ToString().Trim(); Count++;
                            IEntity.PorcEstatal = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.Situacion = row[Count].ToString().Trim(); Count++;
                            IEntity.Direccion = row[Count].ToString().Trim(); Count++;
                            IEntity.Distrito = row[Count].ToString().Trim(); Count++;
                            IEntity.Provincia = row[Count].ToString().Trim(); Count++;
                            IEntity.Departamento = row[Count].ToString().Trim(); Count++;
                            IEntity.Telefono1 = row[Count].ToString().Trim(); Count++;
                            //Telefono2,	Telefono3,	Celular 1,	Celular 2,	Fax1,	 Fax2,	Email Corp,	Pagweb,	Ranking 2016,	Ranking 2015,	Ranking 2014,
                            //Facturado 2016 Soles Minimo,	Facturado 2016 Soles Maximo,	Facturado 2016 Usd Minimo,	Facturado 2016 Usd Maximo,
                            IEntity.Telefono2 = row[Count].ToString().Trim(); Count++;
                            IEntity.Telefono3 = row[Count].ToString().Trim(); Count++;
                            IEntity.Celular1 = row[Count].ToString().Trim(); Count++;
                            IEntity.Celular2 = row[Count].ToString().Trim(); Count++;
                            IEntity.Fax1 = row[Count].ToString().Trim(); Count++;
                            IEntity.Fax2 = row[Count].ToString().Trim(); Count++;
                            IEntity.EmailCorp = row[Count].ToString().Trim(); Count++;
                            IEntity.PaginaWeb = row[Count].ToString().Trim(); Count++;
                            IEntity.RankingY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.RankingY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.RankingY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.FacturadoMinSolY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.FacturadoMaxSolY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.FacturadoMinUsdY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.FacturadoMaxUsdY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            //Facturado 2015 Soles Minimo,	Facturado 2015 Soles Maximo,	Facturado 2015 Usd Minimo,	Facturado 2015 Usd Maximo,	
                            //Facturado 2014 Soles Minimo,	Facturado 2014 Soles Maximo,	Facturado 2014 Usd Minimo,	Facturado 2014 Usd Maximo,	
                            //Priv Publ,	Ingresos2016,	Utilidad Neta 2016,	Activos 2016,	Patrimonio 2016,	Pasivo Total 2016,	Ingresos2015,
                            IEntity.FacturadoMinSolY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.FacturadoMaxSolY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.FacturadoMinUsdY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.FacturadoMaxUsdY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.FacturadoMinSolY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.FacturadoMaxSolY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.FacturadoMinUsdY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.FacturadoMaxUsdY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.TipoPrivadaPublica = row[Count].ToString().Trim(); Count++;
                            IEntity.IngresosY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.UtilidadNetaY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.ActivosY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.PatrimonioY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.PasivoTotalY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.IngresosY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            //Utilidad Neta 2015,	Activos 2015,	Patrimonio 2015,	Pasivo Total 2015,	
                            //Ingresos 2014,	Utilidad Neta 2014,	Activos 2014,	Patrimonio 2014,	Pasivo Total 2014,	
                            //Exportadora,	Porcexpo Vtas2016,	Importadora,	Usdexpo2016,	Usdexpo2015,	Usdexpo2014,
                            IEntity.UtilidadNetaY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.ActivosY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.PatrimonioY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.PasivoTotalY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.IngresosY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.UtilidadNetaY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.ActivosY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.PatrimonioY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.PasivoTotalY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.TipoExportadora = row[Count].ToString().Trim(); Count++;
                            IEntity.PorExpoVtasY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.Importadora = row[Count].ToString().Trim(); Count++;
                            IEntity.USDExpoY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDExpoY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDExpoY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            //Usdexpo2013,	Usdexpo2012,	Usdexpo2011,	Usdexpo2010,	Usdimpo2016,
                            //Usdimpo2015,	Usdimpo2014,	Usdimpo2013,	Usdimpo2012,	Usdimpo2011,	Usdimpo2010
                            IEntity.USDExpoY_3 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDExpoY_4 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDExpoY_5 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDExpoY_6 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDImpoY = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDImpoY_1 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDImpoY_2 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDImpoY_3 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDImpoY_4 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDImpoY_5 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString()); Count++;
                            IEntity.USDImpoY_6 = string.IsNullOrEmpty(row[Count].ToString().Trim()) ? 0 : Convert.ToDecimal(row[Count].ToString());Count++;
                            try
                            {
                                new EmpresaTopBL().ProcesarEmpresaTop(IEntity);
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
                throw ex;
            }
        }
    }
}