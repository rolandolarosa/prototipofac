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
    public partial class frmGestion : FormulaBase.frmMntFiltro
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        private void frmGestion_Load(object sender, EventArgs e)
        {
            try
            {
                dtFechaInicio.Value = DateTime.Now;
                dtFechaFin.Value = DateTime.Now;
                LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                GestionBE GestionBE = new GestionBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    FechaInicio = dtFechaInicio.Value,
                    FechaFin = dtFechaFin.Value,
                    IdEstado_tt = cboIdEstado_tt.SelectedValue.ToString()
                };
                ds = new GestionBL().ProcesarGestion(GestionBE);
                dgvGestion.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";

                DataSet dsDoc = new DataSet();
                GestionBE.OPCION = 5;
                dsDoc = new GestionBL().ProcesarGestion(GestionBE);
                dgvDocumentos.DataSource = dsDoc.Tables[0];
                lblRegistrosDocumentos.Text = dsDoc.Tables[0].Rows.Count.ToString() + " registro(s)";
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
                String Table_Id = "00152"; //Estado Gestion
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdEstado_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionComercial.frmGestionDato ofrmGestionDato = new Formula.GestionComercial.frmGestionDato();
                ofrmGestionDato.Operacion = "N";
                ofrmGestionDato.ShowDialog();
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGestion.RowCount > 0)
                {
                    if (!dgvGestion.CurrentRow.Cells["IdEstado_tt"].Value.ToString().Equals("00154"))
                    {
                        MessageBox.Show("Solo se pueden gestionar los compromisos vigentes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Formula.GestionComercial.frmGestionDato ofrmGestionDato = new Formula.GestionComercial.frmGestionDato();
                    ofrmGestionDato.Operacion = "M";
                    ofrmGestionDato.IdGestionAtendida = dgvGestion.CurrentRow.Cells["IdGestion"].Value.ToString();
                    ofrmGestionDato.IdEntidad = dgvGestion.CurrentRow.Cells["IdEntidad"].Value.ToString();
                    ofrmGestionDato.Entidad = dgvGestion.CurrentRow.Cells["Entidad"].Value.ToString();
                    ofrmGestionDato.FlgSocio = int.Parse(dgvGestion.CurrentRow.Cells["FlgSocio"].Value.ToString());
                    ofrmGestionDato.ShowDialog();
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDocumentos.RowCount > 0)
                {
                    DataSet ds = new DataSet();
                    GestionBE GestionBE = new GestionBE()
                    {
                        OPCION = 6,
                        USUARIO = General.General.GetUsuario,
                        IdEntidad = dgvDocumentos.CurrentRow.Cells["IdSocio"].Value.ToString(),
                        FechaInicio = dtFechaInicio.Value,
                        FechaFin = dtFechaFin.Value,
                    };
                    ds = new GestionBL().ProcesarGestion(GestionBE);
                    dgvGestionSocio.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDocumentos.RowCount > 0)
                {
                    Formula.GestionComercial.frmConsultaDocumento ofrmConsultaDocumento = new Formula.GestionComercial.frmConsultaDocumento();
                    ofrmConsultaDocumento.Codigo = dgvDocumentos.CurrentRow.Cells["IdSocio"].Value.ToString();
                    ofrmConsultaDocumento._Socio = dgvDocumentos.CurrentRow.Cells["Socio"].Value.ToString();
                    ofrmConsultaDocumento._FechaFin = dtFechaFin.Value;
                    ofrmConsultaDocumento.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}