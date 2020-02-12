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
    public partial class frmCarteraCandidatoDato : FormulaBase.frmMntDato
    {
        public int _OrigenGestion = 0;
        public int _FlgPagadora = 0;
        public frmCarteraCandidatoDato()
        {
            InitializeComponent();
        }

        private void frmCarteraCandidatoDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                if (Operacion.Equals("M"))
                {
                    txtIdCartera.Text = Codigo;
                    CargarDatos();
                    if (_OrigenGestion == 1)
                    {
                        cboUsuarioID.Enabled = false;
                    }
                }
                else if (Operacion.Equals("N"))
                {
                    txtdtRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    if (_OrigenGestion == 1)
                    {
                        cboUsuarioID.SelectedValue = General.General.GetUsuario;
                        cboUsuarioID.Enabled = false;
                    }
                }
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
                DataSet dsCartera = new DataSet();
                CarteraCandidatoBE CarteraCandidatoBE = new CarteraCandidatoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdCartera = txtIdCartera.Text,
                };

                dsCartera = new CarteraCandidatoBL().ProcesarCarteraCandidato(CarteraCandidatoBE);

                if (dsCartera.Tables[0].Rows.Count > 0)
                {
                    txtdtRegistro.Text = dsCartera.Tables[0].Rows[0]["strdtRegistro"].ToString();
                    txtvApePaterno.Text = dsCartera.Tables[0].Rows[0]["vApePaterno"].ToString();
                    txtvApeMaterno.Text = dsCartera.Tables[0].Rows[0]["vApeMaterno"].ToString();
                    txtvNombre.Text = dsCartera.Tables[0].Rows[0]["vNombre"].ToString();
                    cboIdTipoDocumento_tt.SelectedValue = dsCartera.Tables[0].Rows[0]["IdTipoDocumento_tt"].ToString();
                    txtvNroDocumento.Text = dsCartera.Tables[0].Rows[0]["vNroDocumento"].ToString();
                    cboIdTipoPersona_tt.SelectedValue = dsCartera.Tables[0].Rows[0]["IdTipoPersona_tt"].ToString();
                    cbocGlobal_TipoEmpresa.SelectedValue = dsCartera.Tables[0].Rows[0]["cGlobal_TipoEmpresa"].ToString();
                    cbocGlobal_TipoRiesgo.SelectedValue = dsCartera.Tables[0].Rows[0]["cGlobal_TipoRiesgo"].ToString();
                    txtvContacto.Text = dsCartera.Tables[0].Rows[0]["vContacto"].ToString();
                    txtvCargo.Text = dsCartera.Tables[0].Rows[0]["vCargo"].ToString();
                    txtvTelefono1.Text = dsCartera.Tables[0].Rows[0]["vTelefono1"].ToString();
                    txtvTelefono2.Text = dsCartera.Tables[0].Rows[0]["vTelefono2"].ToString();
                    txtvTelefono3.Text = dsCartera.Tables[0].Rows[0]["vTelefono3"].ToString();
                    txtvCorreo.Text = dsCartera.Tables[0].Rows[0]["vCorreo"].ToString();
                    cboUsuarioID.SelectedValue = !string.IsNullOrEmpty(dsCartera.Tables[0].Rows[0]["UsuarioID"].ToString()) ? dsCartera.Tables[0].Rows[0]["UsuarioID"].ToString() : "--Seleccionar--";
                }
                else
                {
                    MessageBox.Show("Este candidato no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                String Table_Id = "00134"; //Tipo Documento
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdTipoDocumento_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00138"; //Tipo Persona
                General.General.LlenarCombobox(cboIdTipoPersona_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                UsuarioGestorBE oEntity = new UsuarioGestorBE()
                {
                    OPCION = 8,
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

                cboUsuarioID.DataSource = dt;
                cboUsuarioID.DisplayMember = "usuarioID";
                cboUsuarioID.ValueMember = "usuarioID";

                TableBaseBE.OPCION = 8;
                TableBaseBE.Table_Parent_Id = "129"; //Tipo Riesgo
                DataTable dtTipoRiesgo = new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0];
                cbocGlobal_TipoRiesgo.DataSource = dtTipoRiesgo;
                cbocGlobal_TipoRiesgo.DisplayMember = "varDescripcion";
                cbocGlobal_TipoRiesgo.ValueMember = "varCodigo";
                cbocGlobal_TipoRiesgo.SelectedValue = 0;
                
                TableBaseBE.OPCION = 8;
                TableBaseBE.Table_Parent_Id = "21"; //Tipo Empresa
                DataTable dtTipoEmpresa = new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0];
                cbocGlobal_TipoEmpresa.DataSource = dtTipoEmpresa;
                cbocGlobal_TipoEmpresa.DisplayMember = "varDescripcion";
                cbocGlobal_TipoEmpresa.ValueMember = "varCodigo";
                cbocGlobal_TipoEmpresa.SelectedValue = 0;

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
                if (string.IsNullOrEmpty(txtvApePaterno.Text.Trim()))
                {
                    MessageBox.Show("Ingresar un apellido paterno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvApePaterno.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cboIdTipoDocumento_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un tipo de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdTipoDocumento_tt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtvNroDocumento.Text.Trim()))
                {
                    MessageBox.Show("Ingresar un número de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvNroDocumento.Focus();
                    return;
                }

                if (cboUsuarioID.SelectedValue.ToString().Equals("--Seleccionar--"))
                {
                    MessageBox.Show("Seleccione un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvContacto.Focus();
                    return;
                }

                //if (string.IsNullOrEmpty(txtvTelefono1.Text.Trim()))
                //{
                //    MessageBox.Show("Ingresar un número de teléfono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txtvTelefono1.Focus();
                //    return;
                //}

                CarteraCandidatoBE CarteraCandidatoBE = new CarteraCandidatoBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdCartera = txtIdCartera.Text,
                    vApePaterno = txtvApePaterno.Text,
                    vApeMaterno = txtvApeMaterno.Text,
                    vNombre = txtvNombre.Text,
                    IdTipoDocumento_tt = cboIdTipoDocumento_tt.SelectedValue.ToString(),
                    vNroDocumento = txtvNroDocumento.Text,
                    IdTipoPersona_tt = cboIdTipoPersona_tt.SelectedValue.ToString(),
                    cGlobal_TipoEmpresa = int.Parse(cbocGlobal_TipoEmpresa.SelectedValue.ToString()),
                    cGlobal_TipoRiesgo = int.Parse(cbocGlobal_TipoRiesgo.SelectedValue.ToString()),
                    vContacto = txtvContacto.Text,
                    vCargo = txtvCargo.Text,
                    vTelefono1 = txtvTelefono1.Text,
                    vTelefono2 = txtvTelefono2.Text,
                    vTelefono3 = txtvTelefono3.Text,
                    vCorreo = txtvCorreo.Text,
                    FlgPagadora = _FlgPagadora,
                    UsuarioID = cboUsuarioID.SelectedValue.ToString(),
                };
                new CarteraCandidatoBL().ProcesarCarteraCandidato(CarteraCandidatoBE);

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