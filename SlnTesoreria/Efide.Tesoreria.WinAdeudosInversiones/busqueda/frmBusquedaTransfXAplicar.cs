using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.inversion;
using Efide.Tesoreria.BusinessLogic;
using Efide.Tesoreria.BusinessLogic.inversion;
using Efide.Tesoreria.Util;

namespace Efide.Tesoreria.WinAdeudosInversiones.busqueda
{
    public partial class frmBusquedaTransfXAplicar : DevComponents.DotNetBar.OfficeForm
    {
        #region "ENTITY"
        private SocioBancoBL _SocioBancoBL;
        private SocioBancoBL oSocioBancoBL
        {
            get { return (_SocioBancoBL == null ? _SocioBancoBL = new SocioBancoBL() : _SocioBancoBL); }
        }

        private ValoresGeneralesBL _ValoresGeneralesBL;
        private ValoresGeneralesBL oValoresGeneralesBL
        {
            get { return (_ValoresGeneralesBL == null ? _ValoresGeneralesBL = new ValoresGeneralesBL() : _ValoresGeneralesBL); }
        }
        #endregion

        #region "PROPERTIES"
        public enum Movimiento
        {
            Ingreso = 1,
            Egreso = 2
        }
        bool isLoad = false;
        public Movimiento movimiento { get; set; }
        public GetEnum.Eventos Evento { get; set; }
        public string frmParentName { get; set; }
        public List<SocioBancoBE> lstSocioBancoBESel { get; set; }

        public string _entFinancieraID { get; set; }
        public string _valorMonedaID { get; set; }
        #endregion
        
        #region " FUNCTION "
        public void listSocioBancos()
        {
            SocioBancoBE oSocioBancoBE = new SocioBancoBE();
            List<SocioBancoBE> lstSocioBancoBE = new List<SocioBancoBE>();

            this.Invoke((MethodInvoker)delegate
            {
                if (!isLoad)
                {
                    oSocioBancoBE.entFinancieraID = _entFinancieraID;
                    oSocioBancoBE.valorMonedaID = _valorMonedaID;
                    //oSocioBancoBE

                    lstSocioBancoBE = oSocioBancoBL.listSocioBanco(oSocioBancoBE);
                    dgvDepositosxAplicar.DataSource = lstSocioBancoBE;
                }
            });
        }
        #endregion
        
        public frmBusquedaTransfXAplicar()
        {
            InitializeComponent();
        }

        private void frmBusquedaTransfXAplicar_Load(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    dgvDepositosxAplicar.AutoGenerateColumns = false;
                    listSocioBancos();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
                
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar la información - Error: " + ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //Task.Factory.StartNew(() =>
                //{
                    //Util.Util.SetLoading(this, ucLoadingBar1, true);

                    List<SocioBancoBE> lstSocioBancoBE = new List<SocioBancoBE>();
                    if (lstSocioBancoBESel == null)
                        lstSocioBancoBESel = new List<SocioBancoBE>();

                    foreach (DataGridViewRow row in dgvDepositosxAplicar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            lstSocioBancoBE.Add(new SocioBancoBE()
                            {
                                socioBancoID = Convert.ToString(row.Cells["socioBancoID"].Value),
                                pagar_personaID = Convert.ToString(row.Cells["pagar_personaID"].Value),
                                soc_razonSocial = Convert.ToString(row.Cells["soc_razonSocial"].Value),
                                soc_tipoPersona = Convert.ToString(row.Cells["soc_tipoPersona"].Value),
                                tipoOperacion = Convert.ToString(row.Cells["tipoOperacion"].Value),
                                sbFechaOperacion = Convert.ToDateTime(row.Cells["sbFechaOperacion"].Value),
                                valorTipoMpagoID = Convert.ToString(row.Cells["valorTipoMpagoID"].Value),
                                TipoMpago = Convert.ToString(row.Cells["TipoMpago"].Value),
                                valorMonedaID = Convert.ToString(row.Cells["valorMonedaID"].Value),
                                ent_emprRazonSocial = Convert.ToString(row.Cells["ent_emprRazonSocial"].Value),
                                ctasBancariaID = Convert.ToString(row.Cells["ctasBancariaID"].Value),
                                valorMonedaID_Dsc = Convert.ToString(row.Cells["valorMonedaID_Dsc"].Value),
                                sbImporte = Convert.ToDecimal(row.Cells["sbImporte"].Value),
                                Saldo = Convert.ToDecimal(row.Cells["Saldo"].Value),
                                sbGlosa = Convert.ToString(row.Cells["sbGlosa"].Value),
                                ctasBanNumCta = Convert.ToString(row.Cells["ctasBanNumCta"].Value)
                            });
                        }
                    }

                    lstSocioBancoBESel.AddRange(lstSocioBancoBE);

                    //Util.Util.SetLoading(this, ucLoadingBar1, false);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    //this.Invoke((MethodInvoker)delegate
                    //{
                        this.Close();
                    //});
                //});
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al seleccionar las transferencias/depósitos - Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void frmBusquedaTransfXAplicar_Enter(object sender, EventArgs e)
        {

        }
    }
}