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
    public partial class frmQrySolicitudCheckList : FormulaBase.frmMntDato
    {
        public string _IdTipo_tt = string.Empty;
        public string _RUC = string.Empty;
        public string _Entidad = string.Empty;
        public frmQrySolicitudCheckList()
        {
            InitializeComponent();
        }

        private void frmQrySolicitudCheckList_Load(object sender, EventArgs e)
        {
            try
            {
                lblEntidad.Text = _RUC.Trim() + " - " + _Entidad;
                CargarSolicitudCheckList(_IdTipo_tt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarSolicitudCheckList(string IdTipo_tt)
        {
            try
            {
                SolicitudCheckListBE oEntity = new SolicitudCheckListBE();
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.OPCION = 1;
                oEntity.IdSolicitud = Codigo;
                oEntity.IdTipo_tt = IdTipo_tt;

                DataSet ds = new SolicitudCheckListBL().ProcesarSolicitudCheckList(oEntity);
                dgvCheckList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCheckList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvCheckList.Columns[e.ColumnIndex].Name.Equals("btnVerDoc"))
                {
                    //string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//Solicitud//" + Codigo + "//" + dgvCheckList.CurrentRow.Cells["vDocumento"].Value.ToString();
                    string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//" + _RUC.Trim() + "//Adjuntos//" + Codigo + "//" + dgvCheckList.CurrentRow.Cells["vDocumento"].Value.ToString();
                    System.Diagnostics.Process.Start(filepath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}