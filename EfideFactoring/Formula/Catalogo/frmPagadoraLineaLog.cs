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
    public partial class frmPagadoraLineaLog : DevComponents.DotNetBar.OfficeForm
    {
        PagadoraLineaBL PagadoraLineaBL = new PagadoraLineaBL();
        PagadoraLineaLogBL PagadoraLineaLogBL = new PagadoraLineaLogBL();
        public String IdPagadora = String.Empty;
        public String Pagadora = String.Empty;

        public frmPagadoraLineaLog()
        {
            InitializeComponent();
        }

        #region Eventos ---------------------------------------------
        private void frmPagadoraLineaLog_Load(object sender, EventArgs e)
        {
            txtPagadora.Text = Pagadora.ToString();
            BuscarLinea();
            BuscarHistorial();
        }
        #endregion

        #region Metodos ---------------------------------------------
        private void BuscarLinea()
        {
            try
            {
                DataSet dsPagadoraLinea = new DataSet();
                PagadoraLineaBE PagadoraLineaBE = new PagadoraLineaBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = IdPagadora
                };

                dsPagadoraLinea = PagadoraLineaBL.ProcesarPagadoraLinea(PagadoraLineaBE);

                if (dsPagadoraLinea.Tables[0].Rows.Count > 0)
                {
                    txtLineaActual.Text = Convert.ToDecimal(dsPagadoraLinea.Tables[0].Rows[0]["nLinea"]).ToString("N2");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarHistorial()
        {
            DataSet dsPagadoraLineaLog = new DataSet();
            PagadoraLineaLogBE PagadoraLineaLogBE = new PagadoraLineaLogBE()
            {
                OPCION = 1,
                USUARIO = General.General.GetCodigoUsuario,
                IdPagadora = IdPagadora.ToString()
            };

            dsPagadoraLineaLog = PagadoraLineaLogBL.ProcesarPagadoraLineaLog(PagadoraLineaLogBE);

            dgvHistorial.DataSource = dsPagadoraLineaLog.Tables[0];
        }
        #endregion 
    }
}