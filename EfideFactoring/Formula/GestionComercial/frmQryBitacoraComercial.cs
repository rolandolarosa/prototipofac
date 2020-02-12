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
    public partial class frmQryBitacoraComercial : FormulaBase.frmMntDato
    {
        public string _vcSocio = string.Empty;
        public frmQryBitacoraComercial()
        {
            InitializeComponent();
        }

        private void frmQryBitacoraComercial_Load(object sender, EventArgs e)
        {
            try
            {
                lblSocio.Text = "Socio: " + Codigo.Trim() + " - " + _vcSocio.Trim();
                CargarDatos();
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
                BitacoraComercialBE oEntity = new BitacoraComercialBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.IdSocio = Codigo;
                DataSet ds = new BitacoraComercialBL().ProcesarBitacoraComercial(oEntity);

                if (ds.Tables.Count > 0)
                {
                    dgvReporteDetalle.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}