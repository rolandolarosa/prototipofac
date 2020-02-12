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
    public partial class frmCompromiso : FormulaBase.frmMntFiltro
    {
        public int _OPCION = 1;
        public string _NombreSocio = string.Empty;
        public string _IdSocio = string.Empty;
        public string _NombreGestor = string.Empty;
        public string _IdGestor = string.Empty;
        public string _IdMoneda_tt = string.Empty;
        public DateTime _FechaFin = DateTime.Now;
        public DataSet dsPagadoras = new DataSet();

        CompromisoComBL CompromisoComBL = new CompromisoComBL();

        public frmCompromiso()
        {
            InitializeComponent();
        }

        private void frmCompromiso_Load(object sender, EventArgs e)
        {
            try
            {
                lblSocio.Text = "Socio: " + _IdSocio.Trim() + " - " + _NombreSocio.Trim();
                lblEjecutivo.Text = "Ejecutivo: " + _NombreGestor.Trim();
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                CompromisoComBE CompromisoComBE = new CompromisoComBE()
                {
                    OPCION = _OPCION,
                    USUARIO = General.General.GetUsuario,
                    IdSocio = _IdSocio,
                    IdGestor = _IdGestor,
                    sdFechaFin = _FechaFin,
                    IdMoneda_tt = _IdMoneda_tt,
                };

                ds = CompromisoComBL.ProcesarCompromisoCom(CompromisoComBE);
                dgvCompromisoCom.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmCompromisoDato ofrmMntCompromisoComDato = new frmCompromisoDato();
                ofrmMntCompromisoComDato.Operacion = "N";
                ofrmMntCompromisoComDato.Codigo = string.Empty;
                ofrmMntCompromisoComDato._IdSocio = _IdSocio;
                ofrmMntCompromisoComDato._dsPagadoras = dsPagadoras;
                ofrmMntCompromisoComDato._IdGestor = _IdGestor;
                ofrmMntCompromisoComDato._NombreGestor = _NombreGestor;
                ofrmMntCompromisoComDato.ShowDialog();
                btnBuscar.PerformClick();
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
                if (dgvCompromisoCom.RowCount > 0)
                {
                    if (dgvCompromisoCom.CurrentRow.Cells["UserNew"].Value.ToString().Equals(General.General.GetUsuario))
                    {
                        frmCompromisoDato ofrmMntCompromisoComDato = new frmCompromisoDato();
                        ofrmMntCompromisoComDato.Operacion = "M";
                        ofrmMntCompromisoComDato.Codigo = dgvCompromisoCom.CurrentRow.Cells["IdCompromiso"].Value.ToString();
                        ofrmMntCompromisoComDato._IdSocio = _IdSocio;
                        ofrmMntCompromisoComDato._IdGestor = _IdGestor;
                        ofrmMntCompromisoComDato._NombreGestor = _NombreGestor;
                        ofrmMntCompromisoComDato.ShowDialog();
                        btnBuscar.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Usted no puede editar este compromiso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvCompromisoCom.RowCount > 0)
                {
                    if (dgvCompromisoCom.CurrentRow.Cells["UserNew"].Value.ToString().Equals(General.General.GetUsuario))
                    {
                        dialogResult = MessageBox.Show("Seguro de elimnar el compromiso " + dgvCompromisoCom.CurrentRow.Cells["IdCompromiso"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            CompromisoComBE CompromisoComBE = new CompromisoComBE()
                            {
                                OPCION = 3,
                                USUARIO = General.General.GetUsuario,
                                IdCompromiso = dgvCompromisoCom.CurrentRow.Cells["IdCompromiso"].Value.ToString(),
                            };

                            CompromisoComBL.ProcesarCompromisoCom(CompromisoComBE);
                            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnBuscar.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usted no puede eliminar este compromiso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}