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
    public partial class frmQrySociosNuevos : FormulaBase.frmMntDato
    {
        public string _MesText = string.Empty;
        public string _Mes = string.Empty;
        public string _Annio = string.Empty;
        public string _IdGestor = string.Empty;
        public string _IdGestor_Dsc = string.Empty;
        public frmQrySociosNuevos()
        {
            InitializeComponent();
        }

        private void frmQrySociosNuevos_Load(object sender, EventArgs e)
        {
            try
            {
                lblMes.Text = "Periodo: " + _Annio + " - " + _MesText;
                lblGestor.Text = _IdGestor_Dsc;
                CargarDatos();
                Totalizar();
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
                DataSet ds = new DataSet();
                ds = new GestionComercialBL().ProcesarRpt_PagadoraDesembolsoGC(_Annio, _Mes, _IdGestor, 1);
                dgvDatos.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Totalizar()
        {
            try
            {
                Decimal TotalS = 0;
                Decimal TotalD = 0;
                Decimal TotalSoles = 0;
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells["IdMoneda_tt"].Value.Equals("00036")) //Soles
                    {
                        TotalS = TotalS + Convert.ToDecimal(row.Cells["Desembolso"].Value);
                        TotalSoles = TotalSoles + Convert.ToDecimal(row.Cells["Desembolso"].Value);
                    }
                    else
                    {
                        TotalD = TotalD + Convert.ToDecimal(row.Cells["Desembolso"].Value);
                        TotalSoles = TotalSoles + (Convert.ToDecimal(row.Cells["Desembolso"].Value) * Convert.ToDecimal(row.Cells["TipoCambio"].Value));
                    }
                }

                txtTSoles.Text = TotalS.ToString("N2");
                txtTDolares.Text = TotalD.ToString("N2");
                txtTotalSoles.Text = TotalSoles.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}