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
using System.IO;

namespace EfideFactoring.Formula.Legal
{
    public partial class frmMntSolicitud : FormulaBase.frmMntFiltro
    {
        public int FlgLegal = 0;
        public int Opcion = 4;
        public frmMntSolicitud()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmMntSolicitud_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();

                if (FlgLegal == 1)
                {
                    btnEvaluacion.Visible = true;
                    Opcion = 11;
                    chkVerHistoricos.Visible = true;
                }
                else
                {
                    chkVerHistoricos.Visible = true;
                    chkVerHistoricos.Checked = true;
                    btnNuevo.Visible = true;
                    btnEditar.Visible = true;
                    btnEliminar.Visible = true;
                    cboIdEstado_tt.SelectedValue = "00312";

                    //string[] ArrayString  = string["KBOCANEGRA","DGONZALES","ADMIN"];

                    //if (General.General.GetCodigoUsuario.ToString().Contains(ArrayString))
                    //{
                    cboIdPersonaSolicitud.SelectedValue = General.General.GetCodigoUsuario.ToString();
                    //}
                }
                btnBuscar.PerformClick();
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
                String Table_Id = "00311"; // Estados Solicitud
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdEstado_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0], true);

                UsuarioGestorBE oEntity = new UsuarioGestorBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetCodigoUsuario
                };

                DataTable dt = new DataTable();
                dt = new UsuarioGestorBL().ProcesarUsuarioGestor(oEntity).Tables[0];

                DataRow dr;
                dr = dt.NewRow();
                dr["usuarioID"] = "<<Todos>>";
                //dr["usuarioID"] = "<<Todos>>";
                dt.Rows.InsertAt(dr, 0);

                cboIdPersonaSolicitud.DataSource = dt;
                cboIdPersonaSolicitud.DisplayMember = "usuarioID";
                cboIdPersonaSolicitud.ValueMember = "usuarioID";
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
                SolicitudBE oEntity = new SolicitudBE();
                oEntity.OPCION = Opcion;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.dtSolicitud = dtSolicitudInput.Value;
                oEntity.IdEstado_tt = cboIdEstado_tt.SelectedValue.ToString();  //FlgLegal == 0 ? "00312" : "00313";
                oEntity.IdPersonaSolicitud = cboIdPersonaSolicitud.SelectedValue.ToString().Equals("<<Todos>>") ? string.Empty : cboIdPersonaSolicitud.SelectedValue.ToString();
                oEntity.FlgVerHistoricos = chkVerHistoricos.Checked ? 1 : 0;
                oEntity.vRazonSocialSocio = txtvRazonSocialSocio.Text;
                DataSet ds = new SolicitudBL().ProcesarSolicitud(oEntity);
                dgvSolicitud.DataSource = ds.Tables[0];
                lblRegistros.Text = dgvSolicitud.Rows.Count + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmMntSolicitudDato ofrm = new frmMntSolicitudDato();
                ofrm.Operacion = "N";
                ofrm.ShowDialog();
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
                if (dgvSolicitud.Rows.Count > 0)
                {
                    if (dgvSolicitud.CurrentRow.Cells["IdEstado_tt"].Value.ToString().Equals("00312"))
                    {
                        frmMntSolicitudDato frmMntPagadoraDato = new frmMntSolicitudDato();
                        frmMntPagadoraDato.Operacion = "M";
                        frmMntPagadoraDato.Codigo = dgvSolicitud.CurrentRow.Cells["IdSolicitud"].Value.ToString();
                        frmMntPagadoraDato.ShowDialog();
                        btnBuscar.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("No se puede editar esta solicitud", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                if (dgvSolicitud.RowCount > 0)
                {
                    if (dgvSolicitud.CurrentRow.Cells["IdEstado_tt"].Value.ToString().Equals("00312"))
                    {
                        dialogResult = MessageBox.Show("Seguro de eliminar a la solicitud: " + dgvSolicitud.CurrentRow.Cells["IdSolicitud"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            SolicitudBE oEntity = new SolicitudBE();
                            oEntity.OPCION = 3;
                            oEntity.USUARIO = General.General.GetCodigoUsuario;
                            oEntity.IdSolicitud = dgvSolicitud.CurrentRow.Cells["IdSolicitud"].Value.ToString();
                            new SolicitudBL().ProcesarSolicitud(oEntity);
                            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnBuscar.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar esta solicitud", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEvaluacion_Click(object sender, EventArgs e)
        {
            try
            {
                string IdEstado_tt = dgvSolicitud.CurrentRow.Cells["IdEstado_tt"].Value.ToString();
                frmMntSolicitudEvaluacion frmMntPagadoraDato = new frmMntSolicitudEvaluacion();
                frmMntPagadoraDato.Operacion = IdEstado_tt.Equals("00313")? "M": "C";
                frmMntPagadoraDato.Codigo = dgvSolicitud.CurrentRow.Cells["IdSolicitud"].Value.ToString();
                frmMntPagadoraDato.ShowDialog();
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            try
            {
                //DataSet dsDatos = new DataSet();
                //SolicitudBE oEntityDatos = new SolicitudBE();
                //oEntityDatos.USUARIO = General.General.GetCodigoUsuario;
                //oEntityDatos.OPCION = 13;
                //oEntityDatos.IdSolicitud = "0000000109";
                //dsDatos = new SolicitudBL().ProcesarSolicitud(oEntityDatos);

                //DataSet ds = new DataSet();
                //SolicitudBE oEntity = new SolicitudBE();
                //oEntity.USUARIO = General.General.GetCodigoUsuario;
                //oEntity.OPCION = 12;
                //oEntity.IdSolicitud = "0000000109";
                //ds = new SolicitudBL().ProcesarSolicitud(oEntity);

                //if (ds.Tables.Count > 0)
                //{
                //    foreach (DataRow dr in ds.Tables[0].Rows)
                //    {
                //        General.WordDocumentWrite WD = new General.WordDocumentWrite();
                //        WD.WordDocument(dr["Archivo"].ToString());

                //        foreach (DataColumn dc in dsDatos.Tables[0].Columns)
                //        {
                //            WD.FindAndReplace(dc.ColumnName.ToString(), dsDatos.Tables[0].Rows[0][dc.ColumnName].ToString());
                //        }

                //        WD.SaveDocument();
                //        WD.CloseDocument();
                //    }
                //}
               

                //General.WordDocumentWrite WD = new General.WordDocumentWrite();
                //WD.WordDocument("Proyecto_Modif_ContratoRP.doc");
                //WD.FindAndReplace("<RepresentanteEfide1>", "MONICA PATRICIA YONG GONZALEZ");
                //WD.FindAndReplace("<RepresentanteEfide2>", "BERARDO PEREZ ACUÑA");
                //WD.FindAndReplace("<RazonSocialSocio>", "MELITON BERMUDEZ");
                //WD.FindAndReplace("<DomicilioSocio>", "AV. LARCO 6890");
                //WD.FindAndReplace("<RucSocio>", "1122336655440");
                //WD.SaveDocument();
                //WD.CloseDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}