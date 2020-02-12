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
using System.Configuration;

namespace EfideFactoring.Formula.Legal
{
    public partial class frmVisorFirmaLote : FormulaBase.frmMntDato
    {
        public string _IdPagadora = string.Empty;
        public string _IdPagadora_Dsc = string.Empty;
        public string _IdSocio = string.Empty;
        public string _IdSocio_Dsc = string.Empty;
        public frmVisorFirmaLote()
        {
            InitializeComponent();
        }

        private void frmVisorFirmaLote_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Codigo))
                {
                    lblTitulo.Text = "VISOR DE FIRMAS DE LA LIQUIDACIÓN NRO. " + Codigo;
                    CargarDatos();
                }
                else if (!string.IsNullOrEmpty(_IdPagadora_Dsc))
                {
                    lblTitulo.Text = "VISOR DE FIRMAS DE LA PAGADORA " + _IdPagadora_Dsc.ToUpper();
                    dgvFacultad.Columns["vcPagadora"].Visible = false;
                    CargarDatos();
                }
                else
                {
                    lblTitulo.Text = "VISOR DE FIRMAS DEL SOCIO " + _IdSocio_Dsc.ToUpper();
                    dgvFacultad.Columns["vcPagadora"].Visible = false;
                    CargarDatosSocio();
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
                string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//";
                string filepathBlanco = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//blanco.png";
                List<SolicitudFacultadGridBE> lsEntity = new List<SolicitudFacultadGridBE>();
                SolicitudFacultadBE oConsulta = new SolicitudFacultadBE();
                oConsulta.OPCION = 5;
                oConsulta.USUARIO = General.General.GetUsuario;
                oConsulta.IdLote = Codigo;
                oConsulta.IdPagadora = _IdPagadora;
                DataSet ds = new SolicitudFacultadBL().ProcesarSolicitudFacultad(oConsulta);

                SolicitudFacultadGridBE oEntity;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    oEntity = new SolicitudFacultadGridBE();
                    oEntity.NroFila = Convert.ToInt32(row["NroFila"].ToString());
                    oEntity.vcPagadora = row["vcPagadora"].ToString();
                    oEntity.IdFacultad_tt_Dsc = row["IdFacultad_tt_Dsc"].ToString();
                    oEntity.IdRepresentanteF1_Dsc = row["IdRepresentanteF1_Dsc"].ToString();
                    oEntity.IdRepresentanteF2_Dsc = row["IdRepresentanteF2_Dsc"].ToString();
                    oEntity.ImageFirma1 = !string.IsNullOrEmpty(row["vFirmaAdjunta1"].ToString()) ? System.IO.File.ReadAllBytes(filepath + row["vcRuc"].ToString().Trim() + "//Firmas//" + row["vFirmaAdjunta1"].ToString()) : System.IO.File.ReadAllBytes(filepathBlanco);
                    oEntity.ImageFirma2 = !string.IsNullOrEmpty(row["vFirmaAdjunta2"].ToString()) ? System.IO.File.ReadAllBytes(filepath + row["vcRuc"].ToString().Trim() + "//Firmas//" + row["vFirmaAdjunta2"].ToString()) : System.IO.File.ReadAllBytes(filepathBlanco);
                    lsEntity.Add(oEntity);
                }

                dgvFacultad.DataSource = lsEntity;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosSocio()
        {
            try
            {
                string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//";
                string filepathBlanco = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//blanco.png";
                List<SolicitudFacultadGridBE> lsEntity = new List<SolicitudFacultadGridBE>();
                SolicitudFacultadBE oConsulta = new SolicitudFacultadBE();
                oConsulta.OPCION = 6;
                oConsulta.USUARIO = General.General.GetUsuario;
                oConsulta.IdSocio = _IdSocio;
                DataSet ds = new SolicitudFacultadBL().ProcesarSolicitudFacultad(oConsulta);

                SolicitudFacultadGridBE oEntity;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    oEntity = new SolicitudFacultadGridBE();
                    oEntity.NroFila = Convert.ToInt32(row["NroFila"].ToString());
                    oEntity.vcPagadora = row["razonSocial"].ToString();
                    oEntity.IdFacultad_tt_Dsc = row["IdFacultad_tt_Dsc"].ToString();
                    oEntity.IdRepresentanteF1_Dsc = row["IdRepresentanteF1_Dsc"].ToString();
                    oEntity.IdRepresentanteF2_Dsc = row["IdRepresentanteF2_Dsc"].ToString();
                    oEntity.ImageFirma1 = !string.IsNullOrEmpty(row["vFirmaAdjunta1"].ToString()) ? System.IO.File.ReadAllBytes(filepath + row["vcRuc"].ToString().Trim() + "//Firmas//" + row["vFirmaAdjunta1"].ToString()) : System.IO.File.ReadAllBytes(filepathBlanco);
                    oEntity.ImageFirma2 = !string.IsNullOrEmpty(row["vFirmaAdjunta2"].ToString()) ? System.IO.File.ReadAllBytes(filepath + row["vcRuc"].ToString().Trim() + "//Firmas//" + row["vFirmaAdjunta2"].ToString()) : System.IO.File.ReadAllBytes(filepathBlanco);
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