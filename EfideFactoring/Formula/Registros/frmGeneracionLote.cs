using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Registros
{
    public partial class frmGeneracionLote : DevComponents.DotNetBar.OfficeForm
    {
        public frmGeneracionLote()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            General.msgHelper.Wait("Actualizando nuevos registros, espere un momento ...");
            try
            {
                DataSet ds = new DataSet();
                LoteBL LoteBL = new LoteBL();
                LoteBE LoteBE = new LoteBE()
                {
                    OPCION = 15,
                    USUARIO = General.General.GetUsuario,
                    IdSocio_Dsc = TextBoxX1.Text.Trim()
                };

                ds = LoteBL.ProcesarLote(LoteBE);
                dgvLote.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";

                foreach (DataGridViewRow row in dgvLote.Rows)
                {
                    if (row.Cells["Inconsistencia"].Value.ToString() != "0")
                    {
                        row.DefaultCellStyle.ForeColor = Color.FromName(General.General.GetColorAnulado);
                    }

                    if (!String.IsNullOrEmpty(row.Cells["IdLote"].Value.ToString()))
                    {
                        row.DefaultCellStyle.ForeColor = Color.FromName(General.General.GetColorLoteAprobado);
                    }
                }
                dgvLote.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                General.msgHelper.Wait();
            }
        }

        private void dgvLote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;
                if (dgvLote.Columns[e.ColumnIndex].Name == "btnMensaje")
                {
                    frmGeneracionLoteMensaje ofrm = new frmGeneracionLoteMensaje();
                    ofrm._IdLote = dgvLote.CurrentRow.Cells["IdLote"].Value.ToString();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            General.General.ValidarTipoCambio();
            General.msgHelper.Wait("Actualizando nuevos registros, espere un momento ...");
            try
            {
                LoteBE LoteBE = new LoteBE();
                foreach (DataGridViewRow row in dgvLote.Rows)
                {
                    LoteBE.OPCION = 18;
                    LoteBE.USUARIO = General.General.GetUsuario;
                    LoteBE.IdLote = row.Cells["IdMovimiento"].Value.ToString();
                    LoteBE.IdSocio_Dsc = row.Cells["NumeroDocumento"].Value.ToString();
                    new LoteBL().ProcesarLote(LoteBE);
                }
                int Procesar = 0;
                foreach (DataGridViewRow row in dgvLote.Rows)
                {
                    if (row.Cells["FlgSelect"].Value != null)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["FlgSelect"];
                        if (chk.Value.ToString() == "1")
                        {
                            Procesar = 1;
                            LoteBE.OPCION = 16;
                            LoteBE.USUARIO = General.General.GetUsuario;
                            LoteBE.IdLote = row.Cells["IdMovimiento"].Value.ToString();
                            LoteBE.IdSocio_Dsc = row.Cells["NumeroDocumento"].Value.ToString();
                            new LoteBL().ProcesarLote(LoteBE);
                        }
                    }
                }

                if (Procesar == 1)
                {
                    LoteBE.OPCION = 17;
                    LoteBE.USUARIO = General.General.GetUsuario;
                    LoteBE.gFechaOp = General.General.gFechaOp;
                    new LoteBL().ProcesarLote(LoteBE);
                    MessageBox.Show("Se proceso correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar_Click(new object(), new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                General.msgHelper.Wait();
            }
        }

        private void dgvLote_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvLote.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            General.msgHelper.Wait("Actualizando Web, espere un momento ...");
            try
            {
                DataSet ds = new DataSet();
                LoteBL LoteBL = new LoteBL();
                LoteBE LoteBE = new LoteBE()
                {
                    OPCION = 29,
                    USUARIO = General.General.GetUsuario
                };

                ds = LoteBL.ProcesarLote(LoteBE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                General.msgHelper.Wait();
            }
        }

        public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
        {
            public DataGridViewDisableButtonColumn()
            {
                this.CellTemplate = new DataGridViewDisableButtonCell();
            }
        }

        public class DataGridViewDisableButtonCell : DataGridViewButtonCell
        {
            private bool enabledValue;
            public bool Enabled
            {
                get
                {
                    return enabledValue;
                }
                set
                {
                    enabledValue = value;
                }
            }
        }

    }
}