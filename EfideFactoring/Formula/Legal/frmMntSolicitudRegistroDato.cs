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

namespace EfideFactoring.Formula.Legal
{
    public partial class frmMntSolicitudRegistroDato : FormulaBase.frmMntDato
    {
        public string _IdTipoRegistro_tt = string.Empty;
        public frmMntSolicitudRegistroDato()
        {
            InitializeComponent();
        }

        private void frmMntSolicitudRegistroDato_Load(object sender, EventArgs e)
        {
            try
            {
                dtRegistro.Value = DateTime.Now;
                LLenarCombos();

                if (Operacion.Equals("M"))
                {
                    cboIdTipoRegistro_tt.Enabled = false;
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LLenarCombos()
        {
            try
            {
                String Table_Id = "00329"; // Solicitud Registro
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdTipoRegistro_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
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
                SolicitudRegistroBE oEntity = new SolicitudRegistroBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.IdSolicitud = Codigo;
                oEntity.IdTipoRegistro_tt = _IdTipoRegistro_tt;
                DataSet ds = new SolicitudRegistroBL().ProcesarSolicitudRegistro(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cboIdTipoRegistro_tt.SelectedValue = ds.Tables[0].Rows[0]["IdTipoRegistro_tt"].ToString();
                    txtvTomo.Text = ds.Tables[0].Rows[0]["vTomo"].ToString();
                    txtvFicha.Text = ds.Tables[0].Rows[0]["vFicha"].ToString();
                    txtvPartida.Text = ds.Tables[0].Rows[0]["vPartida"].ToString();
                    dtRegistro.Value = DateTime.Parse(ds.Tables[0].Rows[0]["dtRegistro"].ToString());
                    txtvLugar.Text = ds.Tables[0].Rows[0]["vLugar"].ToString();
                    txtvNroPagina.Text = ds.Tables[0].Rows[0]["vNroPagina"].ToString();
                    txtvCC.Text = ds.Tables[0].Rows[0]["vCC"].ToString();
                    txtvEP.Text = ds.Tables[0].Rows[0]["vEP"].ToString();
                    txtvOtro.Text = ds.Tables[0].Rows[0]["vOtro"].ToString();
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
                if (string.IsNullOrEmpty(cboIdTipoRegistro_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Seleccionar el tipo de registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (dtRegistro.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Se debe ingresar una fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SolicitudRegistroBE oEntity = new SolicitudRegistroBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSolicitud = Codigo;
                oEntity.IdTipoRegistro_tt = cboIdTipoRegistro_tt.SelectedValue.ToString();
                oEntity.vTomo = txtvTomo.Text;
                oEntity.vFicha = txtvFicha.Text;
                oEntity.vPartida = txtvPartida.Text;
                oEntity.dtRegistro = dtRegistro.Value;
                oEntity.vLugar = txtvLugar.Text;
                oEntity.vNroPagina = txtvNroPagina.Text;
                oEntity.vCC = txtvCC.Text;
                oEntity.vEP = txtvEP.Text.Trim();
                oEntity.vOtro = txtvOtro.Text;
                new SolicitudRegistroBL().ProcesarSolicitudRegistro(oEntity);
                MessageBox.Show("Se Guardo Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}