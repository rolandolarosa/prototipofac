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
    public partial class frmMntSolicitudFacultadDato : FormulaBase.frmMntDato
    {
        public string _IdTipo_tt = string.Empty;
        public frmMntSolicitudFacultadDato()
        {
            InitializeComponent();
        }

        private void frmMntSolicitudFacultadDato_Load(object sender, EventArgs e)
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
                String Table_Id = "00323"; // Facultades
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdFacultad_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00035"; //Moneda
                General.General.LlenarCombobox(cboIdMoneda_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                SolicitudRepresentanteBE oEntity = new SolicitudRepresentanteBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSolicitud = Codigo;
                oEntity.IdTipo_tt = _IdTipo_tt;
                DataSet ds = new SolicitudRepresentanteBL().ProcesarSolicitudRepresentante(oEntity);
                DataSet ds1 = new SolicitudRepresentanteBL().ProcesarSolicitudRepresentante(oEntity);

                General.General.LlenarCombobox(cboIdRepresentanteF1, "vNombreRepresentante", "IdRepresentante", ds.Tables[0]);
                General.General.LlenarCombobox(cboIdRepresentanteF2, "vNombreRepresentante", "IdRepresentante", ds1.Tables[0]);
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
                if (string.IsNullOrEmpty(cboIdFacultad_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Seleccione la facultad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(cboIdRepresentanteF1.SelectedValue.ToString()))
                {
                    MessageBox.Show("Seleccione al representante de la facultad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SolicitudFacultadBE oEntity = new SolicitudFacultadBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSolicitud = Codigo;
                oEntity.IdTipo_tt = _IdTipo_tt;
                oEntity.IdItem = string.Empty;
                oEntity.IdFacultad_tt = cboIdFacultad_tt.SelectedValue.ToString();
                oEntity.IdRepresentanteF1 = cboIdRepresentanteF1.SelectedValue.ToString();
                oEntity.IdRepresentanteF2 = cboIdRepresentanteF2.SelectedValue.ToString();
                oEntity.IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString();
                oEntity.nMontoMaximo = !string.IsNullOrEmpty(txtnMontoMaximo.Text.Trim()) ? Convert.ToDecimal(txtnMontoMaximo.Text) : 0;
                oEntity.bFirma = true;
                new SolicitudFacultadBL().ProcesarSolicitudFacultad(oEntity);

                MessageBox.Show("Se Guardo Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}