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
    public partial class frmMntPagadora : FormulaBase.frmMntFiltro
    {
        PagadoraBL PagadoraBL = new PagadoraBL();

        public frmMntPagadora()
        {
            InitializeComponent();
        }

        #region Eventos ---------------------------------------------
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                SentinelWS02.ExecuteRequest IEntity = new SentinelWS02.ExecuteRequest();
                IEntity.Usuario = "06680788";
                IEntity.Password = "efide10";
                IEntity.Servicio = long.Parse("92");
                IEntity.Tipodoc = "R";
                IEntity.Nrodoc = "20101951872";

                SentinelWS02.CNSDTConRapWS oEntity = new SentinelWS02.CNSDTConRapWS();
                SentinelWS02.SentinelWS02SoapPortClient oServices = new SentinelWS02.SentinelWS02SoapPortClient("SentinelWS02SoapPort");
                oEntity = oServices.Execute(IEntity.Usuario, IEntity.Password, IEntity.Servicio, IEntity.Tipodoc, IEntity.Nrodoc);
                */

                Formula.Catalogo.frmMntPagadoraDato frmMntPagadoraDato = new Formula.Catalogo.frmMntPagadoraDato();
                frmMntPagadoraDato.Operacion = "N";
                frmMntPagadoraDato.ShowDialog();
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
                Formula.Catalogo.frmMntPagadoraDato frmMntPagadoraDato = new Formula.Catalogo.frmMntPagadoraDato();
                frmMntPagadoraDato.Operacion = "M";
                frmMntPagadoraDato.Codigo = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                frmMntPagadoraDato.ShowDialog();
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Catalogo.frmMntPagadoraDato frmMntPagadoraDato = new Formula.Catalogo.frmMntPagadoraDato();
                frmMntPagadoraDato.Operacion = "C";
                frmMntPagadoraDato.Codigo = dgvPagadoras.CurrentRow.Cells["Codigo"].Value.ToString();
                frmMntPagadoraDato.ShowDialog();

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
                if (dgvPagadoras.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar a la Pagadora: " + dgvPagadoras.CurrentRow.Cells["vcPagadora"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        PagadoraBE PagadoraBE = new PagadoraBE();
                        PagadoraBE.OPCION = 3;
                        PagadoraBE.USUARIO = General.General.GetCodigoUsuario;
                        PagadoraBE.IdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                        PagadoraBL.ProcesarPagadora(PagadoraBE);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsPagadora = new DataSet();
                PagadoraBE PagadoraBE = new PagadoraBE();
                PagadoraBE.OPCION = 1;
                PagadoraBE.USUARIO = General.General.GetCodigoUsuario;
                PagadoraBE.vcPagadora = TextBoxX1.Text.Trim();
                PagadoraBE.vcRuc = txtRuc.Text.Trim();
                dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);
                dgvPagadoras.DataSource = dsPagadora.Tables[0];

                lblRegistros.Text = dsPagadora.Tables[0].Rows.Count + " registro(s)";
                GridFormating();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TextBoxX1.Clear();
        }

        #endregion

        private void dgvPagadoras_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void GridFormating()
        {
            try
            {
                foreach (DataGridViewRow row in dgvPagadoras.Rows)
                {
                    if (row.Cells["Status"].Value.Equals("B")) // Anulado
                    {
                        row.DefaultCellStyle.ForeColor = Color.FromName(General.General.GetColorAnulado);
                    }

                    if (row.Cells["Status"].Value.Equals("I")) // Inactivo
                    {
                        row.DefaultCellStyle.ForeColor = Color.Blue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}