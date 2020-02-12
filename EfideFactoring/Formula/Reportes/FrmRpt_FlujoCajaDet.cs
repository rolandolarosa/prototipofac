using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Reportes
{
    public partial class FrmRpt_FlujoCajaDet : FormulaBase.frmMntDato
    {
        public int _Opcion = 3;
        public string _Concepto = string.Empty;
        public int _ConceptoId = 0;
        public string _Columna = string.Empty;
        public int _ValorMonedaId = 0;
        public int _FlgSBS = 0;
        public FrmRpt_FlujoCajaDet()
        {
            InitializeComponent();
        }

        private void FrmRpt_FlujoCajaDet_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "DETALLE DE " + _Concepto.ToUpper();
                CargarDatos();
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

                ds = new ReporteBL().ProcesarReporte(_Opcion, General.General.GetCodigoUsuario, _ConceptoId, _Columna, _ValorMonedaId, _FlgSBS);
                dgvDatos.DataSource = ds.Tables[0];

                DataTable dt = ds.Tables[0];

                Decimal Total = 0;
                Decimal ImporteDPF = 0;
                Decimal Aporte = 0;
                Decimal TIntFecha = 0;

                if (_ConceptoId == 8)
                {
                    foreach (DataGridViewRow dr in dgvDatos.Rows)
                    {

                        Total = Total + Convert.ToDecimal(dr.Cells["Total"].Value.ToString());
                        ImporteDPF = ImporteDPF + Convert.ToDecimal(dr.Cells["Importe DPF"].Value.ToString());
                        Aporte = Aporte + Convert.ToDecimal(dr.Cells["Aporte"].Value.ToString());
                    }

                    dgvDatos.Columns["Importe DPF"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDatos.Columns["Importe DPF"].DefaultCellStyle.Format = "N0";

                    dgvDatos.Columns["Aporte"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDatos.Columns["Aporte"].DefaultCellStyle.Format = "N0";

                    dgvDatos.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDatos.Columns["Total"].DefaultCellStyle.Format = "N0";
                }
                else if (_ConceptoId == 16)
                {
                    foreach (DataGridViewRow dr in dgvDatos.Rows)
                    {
                        Total = Total + Convert.ToDecimal(dr.Cells["Total"].Value.ToString());
                        TIntFecha = TIntFecha + Convert.ToDecimal(dr.Cells["Intereses a las Fecha"].Value.ToString());
                    }

                    dgvDatos.Columns["Importe DPF"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDatos.Columns["Importe DPF"].DefaultCellStyle.Format = "N0";

                    //dgvDatos.Columns["Aporte"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //dgvDatos.Columns["Aporte"].DefaultCellStyle.Format = "N0";

                    dgvDatos.Columns["Días"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvDatos.Columns["Días Transcurridos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvDatos.Columns["Intereses a las Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDatos.Columns["Intereses a las Fecha"].DefaultCellStyle.Format = "N2";

                    dgvDatos.Columns["TEA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDatos.Columns["TEA"].DefaultCellStyle.Format = "N2";

                    //dgvDatos.Columns["TEA Fasial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //dgvDatos.Columns["TEA Fasial"].DefaultCellStyle.Format = "N2";

                    dgvDatos.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDatos.Columns["Total"].DefaultCellStyle.Format = "N0";

                    lblInteresDPF.Visible = true;
                    txtTotalInteresDPF.Visible = true;
                }
                else
                {
                    foreach (DataGridViewRow dr in dgvDatos.Rows)
                    {
                        Total = Total + Convert.ToDecimal(dr.Cells["Importe"].Value.ToString());
                    }

                    dgvDatos.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDatos.Columns["Importe"].DefaultCellStyle.Format = "N0";

                    if (dt.Columns.Contains("TEA"))
                    {
                        dgvDatos.Columns["TEA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvDatos.Columns["TEA"].DefaultCellStyle.Format = "N2";
                    }

                    if (dt.Columns.Contains("Plazo"))
                    {
                        dgvDatos.Columns["Plazo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvDatos.Columns["Plazo"].DefaultCellStyle.Format = "N0";
                    }
                }

                txtImporteTotal.Text = Total.ToString("N0");
                txtTotalInteresDPF.Text = TIntFecha.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}