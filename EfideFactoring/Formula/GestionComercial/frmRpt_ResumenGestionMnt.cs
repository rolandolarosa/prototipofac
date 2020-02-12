using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBL;

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmRpt_ResumenGestionMnt : FormulaBase.frmMntDato
    {
        public frmRpt_ResumenGestionMnt()
        {
            InitializeComponent();
        }

        private void frmRpt_ResumenGestionMnt_Load(object sender, EventArgs e)
        {
            try
            {
                CargarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarReporte()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = new GestionComercialBL().Procesar_Rpt_ResumenGestionNuevosMnt("", "", 2);

                dgvResumenGestion.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}