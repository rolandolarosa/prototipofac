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
    public partial class frmGrupoPagadoraLog : DevComponents.DotNetBar.OfficeForm
    {
        public string IdGrupoPagadora = string.Empty;
        public string GrupoPagadora = string.Empty;
        GrupoPagadoraLogBL GrupoPagadoraLogBL = new GrupoPagadoraLogBL();

        public frmGrupoPagadoraLog()
        {
            InitializeComponent();
        }

        #region Eventos ---------------------------------------------
        private void frmGrupoPagadoraLog_Load(object sender, EventArgs e)
        {
            txtGrupoPagadora.Text = GrupoPagadora.Trim();
            BuscarHistorial();
        }
        #endregion

        #region Metodos ---------------------------------------------
        private void BuscarHistorial()
        {
            DataSet dsPagadoraLineaLog = new DataSet();
            GrupoPagadoraLogBE GrupoPagadoraLogBE = new GrupoPagadoraLogBE()
            {
                OPCION = 1,
                USUARIO = General.General.GetCodigoUsuario,
                IdGrupoPagadora = IdGrupoPagadora.ToString()
            };

            dsPagadoraLineaLog = GrupoPagadoraLogBL.ProcesarGrupoPagadoraLog(GrupoPagadoraLogBE);

            dgvHistorial.DataSource = dsPagadoraLineaLog.Tables[0];
            lblRegistros.Text = dsPagadoraLineaLog.Tables[0].Rows.Count.ToString() + " registro(s)";
        }
        #endregion
    }
}