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
    public partial class frmUsuarioXTipoDato : FormulaBase.frmMntDato
    {
        public frmUsuarioXTipoDato()
        {
            InitializeComponent();
        }

        private void frmUsuarioXTipoDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();

                if (Operacion.Equals("M"))
                {
                    cboUsuarios.Enabled = false;
                    cboGestor.Enabled = false;
                    CargaDatos();
                }
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
                UsuarioGestorBE oEntity = new UsuarioGestorBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario
                };
                
                if (Operacion.Equals("M")) { oEntity.OPCION = 5; }
                DataTable dt = new DataTable();
                dt = new UsuarioGestorBL().ProcesarUsuarioGestor(oEntity).Tables[0];

                DataRow dr;
                dr = dt.NewRow();
                dr["usuarioID"] = "--Seleccionar--";
                dr["usuarioID"] = "--Seleccionar--";
                dt.Rows.InsertAt(dr, 0);

                cboUsuarios.DataSource = dt;
                cboUsuarios.DisplayMember = "usuarioID";
                cboUsuarios.ValueMember = "usuarioID";

                DataSet dsGestor = new GestionComercialBL().ProcesarGestionComercial(0, 0, "", "", 0, 7);
                General.General.LlenarCombobox(cboGestor, "nombreCompleto", "gestorID", dsGestor.Tables[0]);

                TableBaseBE oEntityTB = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    Table_Parent_Id = "00246" //Tipo Gestor
                };
                General.General.LlenarCombobox(cboIdTipoGestor_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(oEntityTB).Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaDatos()
        {
            try
            {
                DataSet ds = new DataSet();

                UsuarioGestorBE oEntity = new UsuarioGestorBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 1,
                    UsuarioID = Codigo.Trim()
                };
                ds = new UsuarioGestorBL().ProcesarUsuarioGestor(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cboUsuarios.SelectedValue = ds.Tables[0].Rows[0]["UsuarioID"].ToString().Trim();
                    cboGestor.SelectedValue = ds.Tables[0].Rows[0]["IdGestor"].ToString();
                    cboIdTipoGestor_tt.SelectedValue = ds.Tables[0].Rows[0]["IdTipoGestor_tt"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cboUsuarios.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboUsuarios.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cboGestor.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un gestor a asignar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboGestor.Focus();
                    return;
                }

                UsuarioGestorBE oEntity = new UsuarioGestorBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    UsuarioID = cboUsuarios.SelectedValue.ToString(),
                    IdGestor = cboGestor.SelectedValue.ToString(),
                    IdTipoGestor_tt = cboIdTipoGestor_tt.SelectedValue.ToString()
                };
                new UsuarioGestorBL().ProcesarUsuarioGestor(oEntity);

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}