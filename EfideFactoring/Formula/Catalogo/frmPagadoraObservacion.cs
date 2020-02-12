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
    public partial class frmPagadoraObservacion : FormulaBase.frmMntDato
    {
        public string _IdObservacion;
        PagadoraObservacionBL PagadoraObservacionBL = new PagadoraObservacionBL();
        public frmPagadoraObservacion()
        {
            InitializeComponent();
        }

        private void frmPagadoraObservacion_Load(object sender, EventArgs e)
        {
            txtdtFecha.Text = DateTime.Now.ToString();
            txtIdObservacion.Text = _IdObservacion;
            if (Operacion == "M")
            {
                CargarDatos();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtComentario.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar una observación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtComentario.Focus();
                    return;
                }

                PagadoraObservacionBE PagadoraObservacionBE = new PagadoraObservacionBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = Codigo,
                    IdObservacion = txtIdObservacion.Text.Trim(),
                    dtFecha = DateTime.Parse(txtdtFecha.Text),
                    vcComentario = txtComentario.Text.Trim(),
                    vcUsuario = General.General.GetUsuario,
                };

                PagadoraObservacionBL.ProcesarPagadoraObservacion(PagadoraObservacionBE);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
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
                PagadoraObservacionBE PagadoraObservacionBE = new PagadoraObservacionBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = Codigo,
                    IdObservacion = txtIdObservacion.Text
                };

                ds = PagadoraObservacionBL.ProcesarPagadoraObservacion(PagadoraObservacionBE);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtComentario.Text = ds.Tables[0].Rows[0]["vcComentario"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}