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
    public partial class frmConsultaDocumento : FormulaBase.frmMntDato
    {
        public string _Socio = string.Empty;
        public DateTime _FechaFin = DateTime.MinValue;
        public frmConsultaDocumento()
        {
            InitializeComponent();
        }

        private void frmConsultaDocumento_Load(object sender, EventArgs e)
        {
            try
            {
                txtIdSocio.Text = Codigo;
                txtSocio.Text = _Socio;
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
                DataSet ds = new DataSet();
                GestionBE GestionBE = new GestionBE()
                {
                    OPCION = 7,
                    USUARIO = General.General.GetUsuario,
                    Entidad = Codigo,
                    FechaFin = _FechaFin,
                };
                ds = new GestionBL().ProcesarGestion(GestionBE);
                dgvDocumentos.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}