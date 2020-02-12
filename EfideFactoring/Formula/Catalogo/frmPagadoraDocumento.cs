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
    public partial class frmPagadoraDocumento : FormulaBase.frmMntDato
    {
        PagadoraDocumentoBL PagadoraDocumentoBL = new PagadoraDocumentoBL();
        DocumentoBL DocumentoBL = new DocumentoBL();
        TableBaseBL TableBaseBL = new TableBaseBL();
        public String IdPagadora = string.Empty;
        public string IdItemDoc = string.Empty;

        public frmPagadoraDocumento()
        {
            InitializeComponent();
        }

        #region Eventos ---------------------------------------------
        private void frmPagadoraDocumento_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                txtIdPagadora.Text = IdPagadora.ToString().Trim();

                if (Operacion.Equals("M"))
                {
                    CargarDatos();
                }
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
                if (string.IsNullOrEmpty(cboIdDocumento.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdDocumento.Focus();
                    return;
                }

                PagadoraDocumentoBE PagadoraDocumentoBE = new PagadoraDocumentoBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = txtIdPagadora.Text.Trim(),
                    IdItemDoc = IdItemDoc,
                    IdDocumento = cboIdDocumento.SelectedValue.ToString(),
                    IdTipoConfirmacion_tt = cboIdTipoConfirmacion_tt.SelectedValue.ToString(),
                    IdTipoTransferencia_tt = cboIdTipoTransferencia_tt.SelectedValue.ToString(),
                    IdTipoCartaP_tt = cboIdTipoCartaP_tt.SelectedValue.ToString(),
                    IdTipoCartaE_tt = cboIdTipoCartaE_tt.SelectedValue.ToString(),
                    vFrecuencia = txtvFrecuencia.Text,
                    IdFrecuencia_tt = cboIdFrecuencia_tt.SelectedValue.ToString(),
                    IdDiasPagoFrecuencia_tt = cboIdDiasPagoFrecuencia_tt.SelectedValue.ToString(),
                    vDia = txtvDia.Text,
                    iPlazo = !String.IsNullOrEmpty(txtiPlazo.Text.Trim()) ? int.Parse(txtiPlazo.Text.Trim()) : 0,
                    iDiaPago = !String.IsNullOrEmpty(txtiDiaPago.Text.Trim()) ? int.Parse(txtiDiaPago.Text.Trim()) : 0,
                    IdFormaPago_tt = cboIdFormaPago_tt.SelectedValue.ToString(),
                    vcLugardePago = txtvcLugardePago.Text.Trim()
                };

                PagadoraDocumentoBL.ProcesarPagadoraDocumento(PagadoraDocumentoBE);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos ---------------------------------------------
        private void LlenarCombos()
        {
            DocumentoBE DocumentoBE = new DocumentoBE()
            {
                OPCION = 1,
                USUARIO = General.General.GetCodigoUsuario
            };

            General.General.LlenarCombobox(cboIdDocumento, "vDocumento", "IdDocumento", DocumentoBL.ProcesarDocumento(DocumentoBE).Tables[0]);
            //cboIdDocumento.DataSource = DocumentoBL.ProcesarDocumento(DocumentoBE).Tables[0];
            //cboIdDocumento.DisplayMember = "vDocumento";
            //cboIdDocumento.ValueMember = "IdDocumento";

            String Table_Id = "00012";
            TableBaseBE TableBaseBE = new TableBaseBE()
            {
                OPCION = 1,
                USUARIO = General.General.GetCodigoUsuario,
                Table_Parent_Id = Table_Id
            };
            General.General.LlenarCombobox(cboIdFormaPago_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

            TableBaseBE.Table_Parent_Id = "00433"; //Tipo Confirmacion
            General.General.LlenarCombobox(cboIdTipoConfirmacion_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

            TableBaseBE.Table_Parent_Id = "00999"; //Tipo Transferencia Titularidad
            General.General.LlenarCombobox(cboIdTipoTransferencia_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

            TableBaseBE.Table_Parent_Id = "01003"; //Tipo Carta/Documentos Pagadora
            General.General.LlenarCombobox(cboIdTipoCartaP_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

            TableBaseBE.Table_Parent_Id = "01003"; //Tipo Carta/Documentos Pagadora
            General.General.LlenarCombobox(cboIdTipoCartaE_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

            TableBaseBE.Table_Parent_Id = "01057"; //Frecuencia
            General.General.LlenarCombobox(cboIdFrecuencia_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

            TableBaseBE.Table_Parent_Id = "01060"; //Días de Pago Frecuencia
            General.General.LlenarCombobox(cboIdDiasPagoFrecuencia_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

            //cboIdFormaPago_tt.DataSource = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
            //cboIdFormaPago_tt.DisplayMember = "Table_Name";
            //cboIdFormaPago_tt.ValueMember = "Table_Id";
        }

        private void CargarDatos()
        {
            try
            {
                PagadoraDocumentoBE IEnity = new PagadoraDocumentoBE();
                IEnity.OPCION = 1;
                IEnity.USUARIO = General.General.GetUsuario.ToString();
                IEnity.IdPagadora = IdPagadora;
                IEnity.IdItemDoc = IdItemDoc;
                DataSet ds = new PagadoraDocumentoBL().ProcesarPagadoraDocumento(IEnity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cboIdDocumento.SelectedValue = ds.Tables[0].Rows[0]["IdDocumento"].ToString();
                    cboIdTipoConfirmacion_tt.SelectedValue = ds.Tables[0].Rows[0]["IdTipoConfirmacion_tt"].ToString();
                    cboIdTipoTransferencia_tt.SelectedValue = ds.Tables[0].Rows[0]["IdTipoTransferencia_tt"].ToString();
                    cboIdTipoCartaP_tt.SelectedValue = ds.Tables[0].Rows[0]["IdTipoCartaP_tt"].ToString();
                    cboIdTipoCartaE_tt.SelectedValue = ds.Tables[0].Rows[0]["IdTipoCartaE_tt"].ToString();
                    txtiPlazo.Text = ds.Tables[0].Rows[0]["iPlazo"].ToString();
                    cboIdFrecuencia_tt.SelectedValue = ds.Tables[0].Rows[0]["IdFrecuencia_tt"].ToString();
                    cboIdDiasPagoFrecuencia_tt.SelectedValue = ds.Tables[0].Rows[0]["IdDiasPagoFrecuencia_tt"].ToString();
                    txtiDiaPago.Text = ds.Tables[0].Rows[0]["iDiaPago"].ToString();
                    cboIdFormaPago_tt.SelectedValue = ds.Tables[0].Rows[0]["IdFormaPago_tt"].ToString();
                    txtvcLugardePago.Text = ds.Tables[0].Rows[0]["vcLugardePago"].ToString();
                }
            }
            catch (Exception ex)
            {    
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}