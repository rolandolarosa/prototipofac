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

namespace EfideFactoring.Formula.Registros
{
    public partial class frmMntLote : FormulaBase.frmMntFiltro
    {
        LoteBL LoteBL = new LoteBL();
        TableBaseBL TableBaseBL = new TableBaseBL();
        public string Fase = "1";
        public string _IdFinancieraPar = string.Empty;
        public string _IdFinanciera_Dsc = string.Empty;
        public string _IdMoneda_tt = string.Empty;
        public string _IdMoneda_tt_Dsc = string.Empty;
        int nopc=1 ;
        public frmMntLote()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Fase.Equals("1"))
                    nopc=28; 
                else
                    nopc = 1;

                if (!string.IsNullOrEmpty(_IdFinanciera_Dsc))
                {
                    lblFinanciera.Text = _IdFinanciera_Dsc.Trim() + " - " + _IdMoneda_tt_Dsc.Trim();
                    btnNuevo.Visible = false;
                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                    nopc = 33;
                }

                DataSet ds = new DataSet();
                LoteBE LoteBE = new LoteBE()
                {
                    OPCION = nopc,
                    USUARIO = General.General.GetUsuario,
                    IdSocio_Dsc = TextBoxX1.Text.Trim(),
                    sdDesembolso = dtDesembolsoInicio.Value,
                    sdAprobacion = dtDesembolsoFin.Value,
                    IdEstado_tt = Fase == "0" ? "00058" : string.Empty,
                    IdFinanciera = _IdFinancieraPar,
                    IdMoneda_tt = _IdMoneda_tt
                };

                ds = LoteBL.ProcesarLote(LoteBE);
                dgvLote.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";

                foreach (DataGridViewRow row in dgvLote.Rows)
                {
                    if (row.Cells["IdEstado_tt"].Value.Equals("00078")) // Anulado
                    {
                        row.DefaultCellStyle.ForeColor = Color.FromName(General.General.GetColorAnulado);
                    }
                }
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
                General.General.ValidarTipoCambio();
                frmMntLoteDato ofrmMntLoteDato = new frmMntLoteDato();
                ofrmMntLoteDato.Operacion = "N";
                ofrmMntLoteDato.Fase = Fase;
                ofrmMntLoteDato.ShowDialog();
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
                General.General.ValidarTipoCambio();
                if (dgvLote.RowCount > 0)
                {
                    frmMntLoteDato ofrmMntLoteDato = new frmMntLoteDato();
                    ofrmMntLoteDato.Operacion = "M";
                    ofrmMntLoteDato.Fase = Fase;
                    ofrmMntLoteDato.Codigo = dgvLote.CurrentRow.Cells["IdLote"].Value.ToString();
                    ofrmMntLoteDato.ShowDialog();
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvLote.RowCount > 0)
                {
                    if (dgvLote.CurrentRow.Cells["IdEstado_tt"].Value.ToString().Equals("00078")) return;

                    if (!dgvLote.CurrentRow.Cells["IdEstado_tt"].Value.ToString().Equals("00058")) //Registrado
                    {
                        MessageBox.Show("No se puede anular este Lote", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dialogResult = MessageBox.Show("Seguro de Anular: " + dgvLote.CurrentRow.Cells["IdLote"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LoteBE LoteBE = new LoteBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdLote = dgvLote.CurrentRow.Cells["IdLote"].Value.ToString(),
                        };
                        LoteBL.ProcesarLote(LoteBE);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMntLote_Load(object sender, EventArgs e)
        {
            dtDesembolsoInicio.Value = General.General.gFechaOp;
            dtDesembolsoFin.Value = General.General.gFechaOp;

            if (Fase.Equals("1"))
            {
                //btnNuevo.Visible = false;
            }
            else
            {
                this.Text = "Registro de Planillas :: FASE 0";
            }

            if (!string.IsNullOrEmpty(_IdFinanciera_Dsc))
            {
                lblFinanciera.Text = _IdFinanciera_Dsc.Trim() + " - " + _IdMoneda_tt_Dsc.Trim();
                btnNuevo.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                nopc = 33;
                //btnBuscar.PerformClick();

                DataSet ds = new DataSet();
                LoteBE LoteBE = new LoteBE()
                {
                    OPCION = nopc,
                    USUARIO = General.General.GetUsuario,
                    IdSocio_Dsc = TextBoxX1.Text.Trim(),
                    sdDesembolso = dtDesembolsoInicio.Value,
                    sdAprobacion = dtDesembolsoFin.Value,
                    IdEstado_tt = Fase == "0" ? "00058" : string.Empty,
                    IdFinanciera = _IdFinancieraPar,
                    IdMoneda_tt = _IdMoneda_tt
                };

                ds = LoteBL.ProcesarLote(LoteBE);
                dgvLote.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";

                foreach (DataGridViewRow row in dgvLote.Rows)
                {
                    if (row.Cells["IdEstado_tt"].Value.Equals("00078")) // Anulado
                    {
                        row.DefaultCellStyle.ForeColor = Color.FromName(General.General.GetColorAnulado);
                    }
                }
            }

        }

        private void dgvLote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvLote.Columns[e.ColumnIndex].Name.Equals("btnVisorFirma"))
                {
                    Legal.frmVisorFirmaLote ofrm = new Legal.frmVisorFirmaLote();
                    ofrm.Codigo = dgvLote.CurrentRow.Cells["IdLote"].Value.ToString();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}