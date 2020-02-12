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

namespace EfideFactoring.Formula.Catalogo
{
    public partial class frmMntTablasBasicasPadre : FormulaBase.frmMntDato
    {
        TableBaseBL TableBaseBL = new TableBaseBL();
        public frmMntTablasBasicasPadre()
        {
            InitializeComponent();
        }

        private void frmMntTablasBasicasPadre_Load(object sender, EventArgs e)
        {
            try
            {
                if (Operacion.Equals("N"))
                {
                    /* Evaluar - Llenar datos por defecto si es necesario....*/
                }
                else if (Operacion.Equals("M"))
                {
                    txtTable_Id.Text = Codigo;
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
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    Table_Id = txtTable_Id.Text,
                    Table_Name = txtTable_Name.Text
                };

                DataSet dsTableBase = new DataSet();
                dsTableBase = TableBaseBL.ProcesarTableBase(TableBaseBE);

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
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
                DataSet dsTableBase = new DataSet();
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Id = txtTable_Id.Text,
                };

                dsTableBase = TableBaseBL.ProcesarTableBase(TableBaseBE);
                
                if (dsTableBase.Tables[0].Rows.Count > 0)
                {
                    txtTable_Name.Text = dsTableBase.Tables[0].Rows[0]["Table_Name"].ToString();
                }
                else
                {
                    MessageBox.Show("Esta Tabla no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}