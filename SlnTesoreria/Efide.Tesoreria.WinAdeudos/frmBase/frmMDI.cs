using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessLogic;
using Efide.Tesoreria.Util;

namespace Efide.Tesoreria.WinAdeudos.frmBase
{
    public partial class frmMenu : DevComponents.DotNetBar.OfficeForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                //validaActivacionMenu();
                muestraControles();
                this.Text = ".::" + this.Text + "::.";

                //ucMsgBox1.ShowMessageWarnnig("Debe completar los datos para poder grabar", "Warning");
                //ucMsgBox1.ShowMessageInformation("Se grabará de todas formas", "Information");
                //ucMsgBox1.ShowMessageSuccess("Se grabó satisfactoriamente");

                //throw new Exception("Me caí probrando U_U");
            }   
            catch (Exception ex)
            {
                //MessageBox.Show("Error al cargar el formulario, Error: " + ex.Message);
                ucMsgBox1.ShowMessageError("Error al cargar la información - Error: " + ex.Message);
            }
        }

        #region FUNCTION
        private void muestraControles()
        {
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = System.Drawing.Color.LightGray;
                    lblusuario.Text = General.GetUsuario;
                    lblFecha.Text = General.gFechaOp.ToString().Substring(0, 10);

                    lblusuario1.Text = "Usuario: " + General.GetUsuario.Trim() + " | " + General.gRol_Dsc.Trim();
                    lblFecha1.Text = "Fecha: " + General.gFechaOp.ToString().Substring(0, 10);
                    break;
                }
            }
        }

        private void validaActivacionMenu()
        {
            if (validaUsuarioActivacionMenu())
            {
                TableBaseBL oTableBaseBL = new TableBaseBL();
                TableBaseBE oTableBaseBE = new TableBaseBE();
                string indActivador = string.Empty;
                //DataSet ds = null;
                List<TableBaseBE> lstTableBaseBE = new List<TableBaseBE>();

                oTableBaseBE.Table_Id = AppSettings.activadorMenuDinamico;
                oTableBaseBE.OPCION = 1;
                lstTableBaseBE = oTableBaseBL.ProcesarTableBase(oTableBaseBE);
                indActivador = lstTableBaseBE[0].Table_Value; //ds.Tables[0].Rows[0]["Table_Value"].ToString();

                if (indActivador == "1")
                {
                    //mnuDinamico.Visible = false;
                    mnuDinamico.Items.Clear();
                    mnuDinamico.Visible = true;
                    loadMenu();
                }
                else
                    mnuDinamico.Visible = true;
            }
            else
                mnuDinamico.Visible = true;
        }

        private bool validaUsuarioActivacionMenu()
        {
            TableBaseBL oTableBaseBL = new TableBaseBL();
            TableBaseBE oTableBaseBE = new TableBaseBE();
            string indActivador = string.Empty;
            //DataSet ds = null;
            List<TableBaseBE> lstTableBase = new List<TableBaseBE>();

            oTableBaseBE.Table_Parent_Id = AppSettings.listaUsuariosMenuDinamico;
            oTableBaseBE.OPCION = 1;
            lstTableBase = oTableBaseBL.ProcesarTableBase(oTableBaseBE);

            if (lstTableBase.Count > 0)
            {
                foreach (TableBaseBE tableBase in lstTableBase)
                {
                    if (tableBase.Table_Value == General.GetCodigoUsuario.Trim())
                        return true;
                }
            }

            return false;
        }

        private void loadMenu()
        {
            List<AccesoGlobalBE> lstAccesoGlobalBE = new List<AccesoGlobalBE>();
            List<AccesoGlobalBE> lstAccesoGlobalBEPadre = new List<AccesoGlobalBE>();
            List<AccesoGlobalBE> lstAccesoGlobalBEHijo = new List<AccesoGlobalBE>();
            AccesoGlobalBL oAccesoGlobalBL = new AccesoGlobalBL();

            ToolStripMenuItem subMenuPadre;
            ToolStripMenuItem subMenuHijo;

            if (mnuDinamico.Items.Count > 0)
                return;

            string rolID = General.gRol;
            string usuarioID = General.GetUsuario;
            string plataformaID = "0010000000005PT     ";
            string moduloID = "0010000000001MD     ";

            PermisoBE oPermisoBE = new PermisoBE();
            oPermisoBE.rolID = rolID.ToString();
            oPermisoBE.usuarioID = usuarioID.ToString();
            oPermisoBE.plataformaID = plataformaID.Trim();
            oPermisoBE.moduloID = moduloID.Trim();

            lstAccesoGlobalBE = oAccesoGlobalBL.ListaAccesos(oPermisoBE);

            lstAccesoGlobalBEPadre = lstAccesoGlobalBE.FindAll(x => x.menPadre == 0 && x.perEstado);
            lstAccesoGlobalBEPadre.Sort((x, y) => x.menPosicion.CompareTo(y.menPosicion));

            mnuDinamico.Items.Clear();
            foreach (AccesoGlobalBE item in lstAccesoGlobalBEPadre)
            {
                lstAccesoGlobalBEHijo = lstAccesoGlobalBE.FindAll(x => x.menPadre == item.menPosicion && x.perEstado);
                lstAccesoGlobalBEHijo.Sort((x, y) => x.menPosicion.CompareTo(y.menPosicion));
                subMenuPadre = new ToolStripMenuItem() { Text = item.menNomPublico, Name = item.menNomInterno, Tag = item.menNomInterno };

                foreach (AccesoGlobalBE itemHijo in lstAccesoGlobalBEHijo)
                {
                    subMenuHijo = new ToolStripMenuItem() { Text = itemHijo.menNomPublico, Name = itemHijo.menNomInterno, Tag = itemHijo.menNomInterno };
                    subMenuHijo.Click += new System.EventHandler(abrirFormulario);

                    subMenuPadre.DropDownItems.Add(subMenuHijo);
                }

                mnuDinamico.Items.Add(subMenuPadre);
            }
        }

        private void abrirFormulario(object sender, System.EventArgs e)
        {
            try
            {
                string strForm = ((System.Windows.Forms.ToolStripMenuItem)sender).Tag.ToString();

                Type frmType = null;
                object frm = null;

                /*
                switch (strForm)
                {
                    case "mnuSalir": this.Dispose();
                        break;
                    case "mnuReporteFENACREP":
                        ProcessStartInfo info = new ProcessStartInfo();
                        info.UseShellExecute = true;
                        info.FileName = "Efide.Fenacrep.Winfenacrep.appref-ms";
                        info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\";
                        info.Arguments = "HLOPEZ|123|2018/06/15";
                        Process.Start(info);
                        return;
                }
                
                if (strForm.LastIndexOf("_1") > 0)
                    frmType = Type.GetType("EfideFactoring." + strForm.Substring(0, strForm.LastIndexOf("_1")));
                else
                    frmType = Type.GetType("EfideFactoring." + strForm);

                object frm = Activator.CreateInstance(frmType);
                switch (strForm)
                {
                    case "Formula.Reportes.frmRptCreditos":
                        break;
                    case "Formula.Reportes.frmRptCobranza":
                        break;
                    case "Formula.Registros.frmQryOperacionesProceso":
                        Formula.Registros.frmQryOperacionesProceso ofrm1 = new Formula.Registros.frmQryOperacionesProceso();
                        ofrm1.Tipo = 1;
                        ofrm1.MdiParent = this;
                        frm = ofrm1;
                        break;
                    case "Formula.Registros.frmMntLote":
                        Formula.Registros.frmMntLote ofrm2 = new Formula.Registros.frmMntLote();
                        ofrm2.Fase = "0";
                        ofrm2.MdiParent = this;
                        frm = ofrm2;
                        break;
                    case "Formula.Registros.frmQryOperacionesProceso_1":
                        Formula.Registros.frmQryOperacionesProceso ofrm3 = new Formula.Registros.frmQryOperacionesProceso();
                        ofrm3.Tipo = 2;
                        ofrm3.MdiParent = this;
                        frm = ofrm3;
                        break;
                    case "Formula.Renovacion.frmRenovacion_1":
                        Formula.Renovacion.frmRenovacion ofrm4 = new Formula.Renovacion.frmRenovacion();
                        ofrm4.FlgAsistente = 1;
                        ofrm4.MdiParent = this;
                        frm = ofrm4;
                        break;
                    default: ((Form)frm).MdiParent = this;
                        break;
                }
                */

                frmType.InvokeMember("Show", System.Reflection.BindingFlags.InvokeMethod, null, frm, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario, Error: " + ex.Message);
            }
        }
        #endregion

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adeudo.frmAdeudo frm = new adeudo.frmAdeudo();
            frm.Evento = GetEnum.Eventos.insert;
            frm.MdiParent = this;
            frm.Show();
        }

        private void rescisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adeudo.frmRescisionAdeudo frm = new adeudo.frmRescisionAdeudo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void inversiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista.frmListaAdeudo frm = new lista.frmListaAdeudo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void confirmaciónDeInversiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adeudo.frmConfirmacionAdeudo frm = new adeudo.frmConfirmacionAdeudo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void confirmaciónDeRescisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adeudo.frmConfirmacionRescisionAdeudo frm = new adeudo.frmConfirmacionRescisionAdeudo();
            frm.MdiParent = this;
            //frm.tipo = frmBase.frmConfirmacionBase.TipoOperacionAdeInv.inversion;
            frm.Show();
        }

        private void inversiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            busqueda.frmBusquedaAdeudo frm = new busqueda.frmBusquedaAdeudo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rescisiónToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            busqueda.frmBusquedaRescisionAdeudo frm = new busqueda.frmBusquedaRescisionAdeudo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void renovaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            busqueda.frmBusquedaRenovacionAdeudo frm = new busqueda.frmBusquedaRenovacionAdeudo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rescisiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lista.frmListaRescisionAdeudo frm = new lista.frmListaRescisionAdeudo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void generaciónDeCarteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adeudo.frmGeneracionCarteraAdeudo frm = new adeudo.frmGeneracionCarteraAdeudo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void búsquedaTransDeposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busqueda.frmBusquedaTransfDepo frm = new busqueda.frmBusquedaTransfDepo();
            frm.MdiParent = this;
            frm.Evento = GetEnum.Eventos.view;
            frm.Show();
        }

        private void cuentaDeBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuentaBancos.frmListCuentaBancos frm = new cuentaBancos.frmListCuentaBancos();
            frm.MdiParent = this;
            frm.Evento = GetEnum.Eventos.view;
            frm.Show();
        }

        private void renovaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adeudo.frmRenovacionAdeudo frm = new adeudo.frmRenovacionAdeudo();
            frm.MdiParent = this;
            frm.Evento = GetEnum.Eventos.insert;
            frm.Show();
        }

        private void confirmaciónDeRenovasiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adeudo.frmConfirmacionRenovacionAdeudo frm = new adeudo.frmConfirmacionRenovacionAdeudo();
            frm.MdiParent = this;
            frm.Evento = GetEnum.Eventos.confirmar;
            frm.Show();
        }

        private void adeudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adeudo.frmAdeudo frm = new adeudo.frmAdeudo();
            frm.MdiParent = this;
            frm.Evento = GetEnum.Eventos.insert;
            frm.Show();
        }

        private void rescisiónCancelaciónADEUDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adeudo.frmRescisionAdeudo frm = new adeudo.frmRescisionAdeudo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void confirmaciónDeAdeudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adeudo.frmConfirmacionAdeudo frm = new adeudo.frmConfirmacionAdeudo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void adeudoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            busqueda.frmBusquedaAdeudo frm = new busqueda.frmBusquedaAdeudo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aplicaciónDeRescisiónAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adeudo.frmConfirmacionRescisionAdeudo frm = new adeudo.frmConfirmacionRescisionAdeudo();
            frm.MdiParent = this;
            frm.tipo = frmBase.frmConfirmacionBase.TipoOperacionAdeInv.adeudo;
            frm.Show();
        }
    }
}