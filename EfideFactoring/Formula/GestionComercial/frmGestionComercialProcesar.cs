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

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmGestionComercialProcesar : FormulaBase.frmMntDato
    {
        public frmGestionComercialProcesar()
        {
            InitializeComponent();
        }

        private void frmGestionComercialProcesar_Load(object sender, EventArgs e)
        {
            try
            {
                txtAño.Text = General.General.gFechaOp.Year.ToString();
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
                String Table_Id = "00213"; //MESES
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                cboMes.DataSource = new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0];
                cboMes.DisplayMember = "Table_Name";
                cboMes.ValueMember = "Table_Value";
                cboMes.SelectedValue = DateTime.Now.Month.ToString().PadLeft(2, '0');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                General.msgHelper.Wait("Procesando, espere un momento ...");
                new GestionComercialBL().Procesar_SocioClasificacionGC(int.Parse(txtAño.Text), int.Parse(cboMes.SelectedValue.ToString()), General.General.GetUsuario ,1);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                General.msgHelper.Wait();
            }
            catch (Exception ex)
            {
                General.msgHelper.Wait();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}