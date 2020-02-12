using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoring.General;
using System.IO;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.CargaDatos
{
    public partial class frmCargaDatos : FormulaBase.frmMntDato
    {
        public frmCargaDatos()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            try
            {
                DataSet ds = new DataSet();
                DatosLoadBE oEntity = new DatosLoadBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                };
                ds = new DatosLoadBL().ProcesarDatosLoad(oEntity);

                dgvCargaDatos.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarDatosTabla()
        {
            try
            {
                DatosLoadBE oEntity = new DatosLoadBE()
                {
                    OPCION = 3,
                    USUARIO = General.General.GetCodigoUsuario,
                };
               new DatosLoadBL().ProcesarDatosLoad(oEntity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Archivos CSV (*.csv) |*.csv";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = ""; 

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                EliminarDatosTabla();
                String fileName = openFileDialog1.FileName;
                msgHelper.Wait("Cargando registros, espere un momento ...");
                try
                {
                    foreach (var line in File.ReadAllLines(fileName))
                    {
                       string[] Array = line.Split(',');
                       if (Array.Length >= 12)
                       {
                           DatosLoadBE oEntity = new DatosLoadBE()
                           {
                               OPCION = 2,
                               USUARIO = General.General.GetCodigoUsuario,
                               Codigo = Array[0].Replace("\"", ""),
                               Descripcion = Array[1].Replace("\"", ""),
                               Columna1 = Array[2].Replace("\"", ""),
                               Columna2 = Array[3].Replace("\"", ""),
                               Columna3 = Array[4].Replace("\"", ""),
                               Columna4 = Array[5].Replace("\"", ""),
                               Columna5 = Array[6].Replace("\"", ""),
                               Columna6 = Array[7].Replace("\"", ""),
                               Columna7 = Array[8].Replace("\"", ""),
                               Columna8 = Array[9].Replace("\"", ""),
                               Columna9 = Array[10].Replace("\"", ""),
                               Columna10 = Array[11].Replace("\"", ""),
                           };
                           new DatosLoadBL().ProcesarDatosLoad(oEntity);
                       }
                    }
                    CargarDatos();
                    msgHelper.Wait();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msgHelper.Wait();
                }
            }
        }
    }
}