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
    public partial class frmPagadoraTipoBloqueo : FormulaBase.frmMntDato
    {
        public string _vcPagadora = string.Empty;
        public frmPagadoraTipoBloqueo()
        {
            InitializeComponent();
        }

        private void frmPagadoraTipoBloqueo_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCombos()
        {
            try
            {
                String Table_Id = "00030";

                TableBaseBE TableBaseBE = new TableBaseBE
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                DataTable dt = new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0];
                DataTable dt1;
                //dt.Select("Table_Value = 'B'").Clone(dt1);

                General.General.LlenarCombobox(cboIdEstadoLinea_tt, "Table_Name", "Table_Id", dt);
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
                DialogResult dialogResult = 0;

                if (string.IsNullOrEmpty(cboIdEstadoLinea_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Debe seleccionar el tipo de bloqueo de la línea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdEstadoLinea_tt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtMotivo.Text.Trim()))
                {
                    MessageBox.Show("Ingrese el motivo del bloqueo de la línea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMotivo.Focus();
                    return;
                }

                dialogResult = MessageBox.Show("¿Seguro de bloquear a la Pagadora?" + _vcPagadora, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    PagadoraBE PagadoraBE = new PagadoraBE();
                    PagadoraBE.OPCION = 5;
                    PagadoraBE.USUARIO = General.General.GetCodigoUsuario;
                    PagadoraBE.IdPagadora = Codigo;
                    PagadoraBE.IdEstadoLinea_tt = cboIdEstadoLinea_tt.SelectedValue.ToString();
                    PagadoraBE.vcReferencia = txtMotivo.Text;
                    new PagadoraBL().ProcesarPagadora(PagadoraBE);
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}