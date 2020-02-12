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
    public partial class frmMntSocioConfiguracionECDato : FormulaBase.frmMntDato
    {
        public frmMntSocioConfiguracionECDato()
        {
            InitializeComponent();
        }

        private void frmMntSocioConfiguracionECDato_Load(object sender, EventArgs e)
        {
            try
            {
                if (Operacion.Equals("M")) 
                {
                    btnBusquedaSocio.Enabled = false;
                    CargarDatos();
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
                DataSet dsDatos = new DataSet();
                SocioConfiguracionECBE oEntity = new SocioConfiguracionECBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSocio = Codigo;
                dsDatos = new SocioConfiguracionECBL().ProcesarSocioConfiguracionEC(oEntity);

                if (dsDatos.Tables[0].Rows.Count > 0)
                {
                    txtIdSocio.Text = dsDatos.Tables[0].Rows[0]["IdSocio"].ToString();
                    txtRazonSocialSocio.Text = dsDatos.Tables[0].Rows[0]["IdSocio_Dsc"].ToString();
                    dtInicioProceso.Value = Convert.ToDateTime(dsDatos.Tables[0].Rows[0]["dtInicioProceso"].ToString());
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
                if (string.IsNullOrEmpty(txtIdSocio.Text))
                {
                    MessageBox.Show("Ingrese un socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (dtInicioProceso.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Ingrese una fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SocioConfiguracionECBE oEntity = new SocioConfiguracionECBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSocio = txtIdSocio.Text;
                oEntity.dtInicioProceso = dtInicioProceso.Value;
                new SocioConfiguracionECBL().ProcesarSocioConfiguracionEC(oEntity);

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusquedaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio.ShowDialog();
                txtIdSocio.Text = ofrmBusquedaSocio.CodSocio.Trim();
                txtRazonSocialSocio.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}