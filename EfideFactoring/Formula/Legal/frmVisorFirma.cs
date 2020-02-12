using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Legal
{
    public partial class frmVisorFirma : FormulaBase.frmMntDato
    {
        public string _IdTipo_tt = string.Empty;
        public string _Entidad = string.Empty;
        public string _NroIdentidadEntidad = string.Empty;
        public frmVisorFirma()
        {
            InitializeComponent();
        }

        private void frmVisorFirma_Load(object sender, EventArgs e)
        {
            try
            {
                lblFacultad.Text = _Entidad.ToUpper(); //"Combinación de Firmas " + (_IdTipo_tt.Equals("00321") ? "Socio" : "Pagador");
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
                string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + _NroIdentidadEntidad.Trim() + "//Firmas//";
                string filepathBlanco = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//blanco.png";
                List<SolicitudFacultadGridBE> lsEntity = new List<SolicitudFacultadGridBE>();
                SolicitudFacultadBE oConsulta = new SolicitudFacultadBE();
                oConsulta.OPCION = 4;
                oConsulta.USUARIO = General.General.GetUsuario;
                oConsulta.IdSolicitud = Codigo;
                oConsulta.IdTipo_tt = _IdTipo_tt;
                DataSet ds = new SolicitudFacultadBL().ProcesarSolicitudFacultad(oConsulta);

                SolicitudFacultadGridBE oEntity;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    oEntity = new SolicitudFacultadGridBE();
                    oEntity.NroFila = Convert.ToInt32(row["NroFila"].ToString());
                    oEntity.IdFacultad_tt_Dsc = row["IdFacultad_tt_Dsc"].ToString();
                    oEntity.IdRepresentanteF1_Dsc = row["IdRepresentanteF1_Dsc"].ToString();
                    oEntity.IdRepresentanteF2_Dsc = row["IdRepresentanteF2_Dsc"].ToString();
                    oEntity.ImageFirma1 = !string.IsNullOrEmpty(row["vFirmaAdjunta1"].ToString()) ? System.IO.File.ReadAllBytes(filepath + row["vFirmaAdjunta1"].ToString()) : System.IO.File.ReadAllBytes(filepathBlanco);
                    oEntity.ImageFirma2 = !string.IsNullOrEmpty(row["vFirmaAdjunta2"].ToString()) ? System.IO.File.ReadAllBytes(filepath + row["vFirmaAdjunta2"].ToString()) : System.IO.File.ReadAllBytes(filepathBlanco);
                    //oEntity.nMontoMaximo = !string.IsNullOrEmpty(row["nMontoMaximo"].ToString()) ? Convert.ToDecimal(row["nMontoMaximo"].ToString()) : 0;
                    lsEntity.Add(oEntity);
                }

                dgvFacultad.DataSource = lsEntity;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}