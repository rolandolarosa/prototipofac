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
    public partial class frmMntBovedaComentario : FormulaBase.frmMntDato
    {
        public string IdBoveda = string.Empty;
        public string IdFormatoDocLegal_tt = string.Empty;

        public frmMntBovedaComentario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMotivo.Text.Trim()))
                {
                    MessageBox.Show("Ingrese el motivo del extorno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult dialogResult = 0;
                dialogResult = MessageBox.Show("Seguro de extornar el documento: " + IdBoveda, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    BovedaDetalleBE oEntity = new BovedaDetalleBE();
                    oEntity.OPCION = 3;
                    oEntity.IdBoveda = IdBoveda;
                    oEntity.IdFormatoDocLegal_tt = IdFormatoDocLegal_tt;
                    oEntity.USUARIO = General.General.GetCodigoUsuario;
                    oEntity.Comentario = txtMotivo.Text.Trim();
                    new BovedaDetalleBL().ProcesarBovedaDetalle(oEntity);
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