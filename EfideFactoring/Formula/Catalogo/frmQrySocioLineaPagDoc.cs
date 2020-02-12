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
    public partial class frmQrySocioLineaPagDoc : FormulaBase.frmMntDato
    {
        public string _IdPagadora = string.Empty;
        public string _IdPagadora_Dsc = string.Empty;
        public string _IdSocio = string.Empty;
        public string _IdSocio_Dsc = string.Empty;
        private BindingList<SocioLineaPagPlazoBE> LstSocioLineaPagPlazo = new BindingList<SocioLineaPagPlazoBE>();
        public frmQrySocioLineaPagDoc()
        {
            InitializeComponent();
        }

        private void frmQrySocioLineaPagDoc_Load(object sender, EventArgs e)
        {
            try
            {
                lblSocio.Text = "SOCIO: " + _IdSocio_Dsc.ToUpper();
                lblPagadora.Text = "PAGADORA: " + _IdPagadora_Dsc.ToUpper();
                CargarLineas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarLineas()
        {
            try
            {
                SocioLineaBE SocioLineaBE = new SocioLineaBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetUsuario,
                    IdSocio = _IdSocio
                };

                DataSet ds = new SocioLineaBL().ProcesarSocioLinea(SocioLineaBE);
                cboIdLinea.DataSource = ds.Tables[0];
                cboIdLinea.DisplayMember = "Descripcion";
                cboIdLinea.ValueMember = "IdLinea";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    CargarDatos();
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
                DataSet dsDocumento = new DataSet();
                SocioLineaPagDocBE SocioLineaPagDocBE = new SocioLineaPagDocBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLinea = cboIdLinea.SelectedValue.ToString(),
                    IdPagadora = _IdPagadora
                };
                dsDocumento = new SocioLineaPagDocBL().ProcesarSocioLineaPagDoc(SocioLineaPagDocBE);
                dgvDocumento.DataSource = dsDocumento.Tables[0];

                ////Plazos y Tasas
                DataSet dsPlazo = new DataSet();
                LstSocioLineaPagPlazo = new BindingList<SocioLineaPagPlazoBE>();
                SocioLineaPagPlazoBE SocioLineaPagPlazoBE = new SocioLineaPagPlazoBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLinea = cboIdLinea.SelectedValue.ToString()
                };
                dsPlazo = new SocioLineaPagPlazoBL().ProcesarSocioLineaPagPlazo(SocioLineaPagPlazoBE);

                if (dsPlazo.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dsPlazo.Tables[0].Rows.Count; i++)
                    {
                        SocioLineaPagPlazoBE oSocioLineaPagPlazoBE = new SocioLineaPagPlazoBE()
                        {
                            IdItem = dsPlazo.Tables[0].Rows[i]["IdItem"].ToString(),
                            IdPagadora = dsPlazo.Tables[0].Rows[i]["IdPagadora"].ToString(),
                            IdDocumento = dsPlazo.Tables[0].Rows[i]["IdDocumento"].ToString(),
                            nPlazo = Decimal.Parse(dsPlazo.Tables[0].Rows[i]["nPlazo"].ToString()),
                            nTasa = Decimal.Parse(dsPlazo.Tables[0].Rows[i]["nTasa"].ToString()),
                            nTasaSobregiro = Decimal.Parse(dsPlazo.Tables[0].Rows[i]["nTasaSobregiro"].ToString())
                        };
                        LstSocioLineaPagPlazo.Add(oSocioLineaPagPlazoBE);
                    }
                }

                dgvDocumento_CellClick(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string varIdPagadora = _IdPagadora;
                string varIdDocumento = dgvDocumento.Rows.Count > 0 ? dgvDocumento.CurrentRow.Cells["IdDocument"].Value.ToString(): string.Empty;

                BindingList<SocioLineaPagPlazoBE> lstPlazo = new BindingList<SocioLineaPagPlazoBE>();
                foreach (var item in LstSocioLineaPagPlazo)
                {
                    if (item.IdPagadora.Equals(varIdPagadora) && item.IdDocumento.Equals(varIdDocumento))
                    {
                        lstPlazo.Add(item);
                    }
                }
                dgvPlazos.DataSource = lstPlazo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!cboIdLinea.SelectedValue.ToString().Equals("System.Data.DataRowView"))
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}