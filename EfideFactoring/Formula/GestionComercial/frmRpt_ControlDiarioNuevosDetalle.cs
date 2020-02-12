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
    public partial class frmRpt_ControlDiarioNuevosDetalle : FormulaBase.frmMntDato
    {
        public string ColumnName = string.Empty;
        public string Clasificacion = string.Empty; // Para los tableros
        public string IdGestor = string.Empty; // Para los tableros
        public string Origen = "Nuevos";
        public frmRpt_ControlDiarioNuevosDetalle()
        {
            InitializeComponent();
        }

        private void frmRpt_ControlDiarioNuevosDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                if (ColumnName.Equals("Meta") || ColumnName.Equals("SinContacto") || ColumnName.Equals("ProspectoConcluido") || ColumnName.StartsWith("Fase"))
                {
                    dgvReporteDetalle.Columns.Clear();
                }

                if (Origen.Equals("Nuevos")) 
                {
                    CargarDatosNuevos();
                }
                else if (Origen.Equals("Mantenimiento"))
                {
                    this.TitleText = "Reporte de Control Diario de Mantenimiento - Detalle";
                    this.Text = "Reporte de Control Diario de Mantenimiento - Detalle";
                    CargarDatosMnt();
                }
                else if (Origen.Equals("TableroNuevos"))
                {
                    this.TitleText = "Tablero de Control Diario de Nuevos - Detalle";
                    this.Text = "Tablero de Control Diario de Nuevos - Detalle";
                    CargarTableroNuevos();
                }
                else if (Origen.Equals("TableroMnt"))
                {
                    this.TitleText = "Tablero de Control Diario de Mantenimiento - Detalle";
                    this.Text = "Tablero de Control Diario de Mantenimiento - Detalle";
                    CargarTableroMnt();
                }
                
                GridFormating();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosNuevos()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = new GestionComercialBL().Procesar_Rpt_ControlDiario(2, Codigo, ColumnName);

                if (ds.Tables.Count > 0)
                {
                    dgvReporteDetalle.DataSource = ds.Tables[0];
                    dgvReporteDetalle.Columns["Socio"].Width = 250;
                    lblRegistros.Text =  ds.Tables[0].Rows.Count +  " registro(s)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosMnt()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = new GestionComercialBL().Procesar_Rpt_ControlDiarioMnt(2, Codigo, ColumnName);

                if (ds.Tables.Count > 0)
                {
                    dgvReporteDetalle.DataSource = ds.Tables[0];
                    dgvReporteDetalle.Columns["Socio"].Width = 250;
                    lblRegistros.Text = ds.Tables[0].Rows.Count + " registro(s)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTableroNuevos()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = new GestionComercialBL().Procesar_Rpt_TableroControlGestionNuevos_Det(IdGestor, Clasificacion, ColumnName);

                if (ds.Tables.Count > 0)
                {
                    dgvReporteDetalle.DataSource = ds.Tables[0];
                    dgvReporteDetalle.Columns["Socio"].Width = 250;
                    lblRegistros.Text = ds.Tables[0].Rows.Count + " registro(s)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTableroMnt()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = new GestionComercialBL().Procesar_Rpt_TableroControlGestionMnt_Det(IdGestor, Clasificacion, ColumnName);

                if (ds.Tables.Count > 0)
                {
                    dgvReporteDetalle.DataSource = ds.Tables[0];
                    dgvReporteDetalle.Columns["Socio"].Width = 250;
                    lblRegistros.Text = ds.Tables[0].Rows.Count + " registro(s)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReporteDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvReporteDetalle.Rows.Count > 0)
                {
                    frmQryBitacoraComercial ofrm = new frmQryBitacoraComercial();
                    ofrm.Codigo = dgvReporteDetalle.CurrentRow.Cells["IdSocio"].Value.ToString();
                    ofrm._vcSocio = dgvReporteDetalle.CurrentRow.Cells["Socio"].Value.ToString();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridFormating()
        {
            try
            {
                if (ColumnName.Equals("Meta") || ColumnName.Equals("SinContacto") || ColumnName.Equals("ProspectoConcluido") || ColumnName.StartsWith("Fase"))
                {
                    return;
                }

                foreach (DataGridViewRow row in dgvReporteDetalle.Rows)
                {
                    if (int.Parse(row.Cells["DiasVencidos"].Value.ToString()) > 0)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReporteDetalle_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridFormating();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}