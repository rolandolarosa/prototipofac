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

namespace EfideFactoring.Formula.Reportes
{
    public partial class frmRpt_OperacionNoRetornaronDetalle : FormulaBase.frmMntDato
    {
        public string _IdSocio_Dsc = string.Empty;
        public frmRpt_OperacionNoRetornaronDetalle()
        {
            InitializeComponent();
        }

        private void frmRpt_OperacionNoRetornaronDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                lblSocio.Text = Codigo.Trim() + " - " + _IdSocio_Dsc.Trim();
                CargarDatos();
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
                ds = new GestionComercialBL().Procesar_Rpt_OperacionNoRetornaron(2, Codigo, string.Empty, 7);
                dgvCobrado.DataSource = ds.Tables[0];

                DataSet ds1 = new DataSet();
                ds1 = new GestionComercialBL().Procesar_Rpt_OperacionNoRetornaron(2, Codigo, string.Empty, 6);
                dgvDesembolsado.DataSource = ds1.Tables[0];

                Decimal dCNominal = 0;
                Decimal dCDesembolso = 0; 
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dCNominal += Convert.ToDecimal(dr["nvNominal"].ToString());
                    dCDesembolso += Convert.ToDecimal(dr["nvNegociable"].ToString());
                }
                txtCNominal.Text = dCNominal.ToString("N2");
                txtCNegociable.Text = dCDesembolso.ToString("N2");


                Decimal dDNominal = 0;
                Decimal dDDesembolso = 0; 
                foreach (DataRow dr in ds1.Tables[0].Rows)
                {
                    dDNominal += Convert.ToDecimal(dr["nvNominal"].ToString());
                    dDDesembolso += Convert.ToDecimal(dr["nvNegociable"].ToString());
                }
                txtDNominal.Text = dDNominal.ToString("N2");
                txtDNegociable.Text = dDDesembolso.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerBitacora_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionComercial.frmQryBitacoraComercial ofrm = new GestionComercial.frmQryBitacoraComercial();
                ofrm.Codigo = Codigo;
                ofrm._vcSocio = _IdSocio_Dsc;
                ofrm.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}