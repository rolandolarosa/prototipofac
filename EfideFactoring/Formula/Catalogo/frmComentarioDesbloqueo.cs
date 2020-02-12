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
    public partial class frmComentarioDesbloqueo : FormulaBase.frmMntDato
    {
        public string _IdPagadora = string.Empty;
        public string _IdPagadora_Dsc = string.Empty;
        public string _Result = string.Empty;
        public frmComentarioDesbloqueo()
        {
            InitializeComponent();
        }

        private void frmComentarioDesbloqueo_Load(object sender, EventArgs e)
        {
            try
            {
                lblPagadora.Text = _IdPagadora_Dsc;
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
                if (string.IsNullOrEmpty(txtvcReferencia.Text.Trim()))
                {
                    MessageBox.Show("Debe ingresar un comentario para el desbloqueo de la pagadora.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvcReferencia.Focus();
                    return;
                }

                if (txtvcReferencia.Text.Trim().Length <= 30)
                {
                    MessageBox.Show("El comentario debe tener más de 30 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvcReferencia.Focus();
                    return;
                }

                DialogResult dialogResult = 0;
                dialogResult = MessageBox.Show("Seguro de desbloquear a la pagadora: " + _IdPagadora_Dsc, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    PagadoraBE PagadoraBE = new PagadoraBE();
                    PagadoraBE.OPCION = 6;
                    PagadoraBE.USUARIO = General.General.GetCodigoUsuario;
                    PagadoraBE.IdPagadora = _IdPagadora;
                    PagadoraBE.vcReferencia = txtvcReferencia.Text;
                    new PagadoraBL().ProcesarPagadora(PagadoraBE);
                    _Result = "OK";
                    this.Dispose();
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}