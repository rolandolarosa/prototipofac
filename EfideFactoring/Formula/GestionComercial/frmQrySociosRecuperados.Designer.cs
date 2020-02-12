namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmQrySociosRecuperados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.gestorCuentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestorCuentaID_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSector_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credFechaDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credTasaAnual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPlazoFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMes = new DevComponents.DotNetBar.LabelX();
            this.lblGestor = new DevComponents.DotNetBar.LabelX();
            this.txtTotalSoles = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTDolares = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTSoles = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.buttonX3);
            this.grpDato.Controls.Add(this.buttonX2);
            this.grpDato.Controls.Add(this.buttonX1);
            this.grpDato.Controls.Add(this.lblGestor);
            this.grpDato.Controls.Add(this.lblMes);
            this.grpDato.Controls.Add(this.dgvDatos);
            this.grpDato.Size = new System.Drawing.Size(1345, 583);
            // 
            // 
            // 
            this.grpDato.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpDato.Style.BackColorGradientAngle = 90;
            this.grpDato.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpDato.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderBottomWidth = 1;
            this.grpDato.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpDato.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderLeftWidth = 1;
            this.grpDato.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderRightWidth = 1;
            this.grpDato.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderTopWidth = 1;
            this.grpDato.Style.CornerDiameter = 4;
            this.grpDato.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpDato.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpDato.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpDato.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpDato.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpDato.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1264, 604);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1173, 604);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gestorCuentaID,
            this.gestorCuentaID_Dsc,
            this.IdSocio,
            this.IdSocio_Dsc,
            this.IdPagadora,
            this.IdPagadora_Dsc,
            this.IdSector_tt_Dsc,
            this.credFechaDes,
            this.IdLote,
            this.TipoCambio,
            this.IdMoneda_tt,
            this.IdMoneda_tt_Dsc,
            this.Desembolso,
            this.credTasaAnual,
            this.iPlazoFin,
            this.Doc});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatos.Location = new System.Drawing.Point(14, 38);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(1320, 536);
            this.dgvDatos.TabIndex = 1;
            // 
            // gestorCuentaID
            // 
            this.gestorCuentaID.DataPropertyName = "gestorCuentaID";
            this.gestorCuentaID.HeaderText = "gestorCuentaID";
            this.gestorCuentaID.Name = "gestorCuentaID";
            this.gestorCuentaID.ReadOnly = true;
            this.gestorCuentaID.Visible = false;
            // 
            // gestorCuentaID_Dsc
            // 
            this.gestorCuentaID_Dsc.DataPropertyName = "gestorCuentaID_Dsc";
            this.gestorCuentaID_Dsc.HeaderText = "Ejecutivo";
            this.gestorCuentaID_Dsc.Name = "gestorCuentaID_Dsc";
            this.gestorCuentaID_Dsc.ReadOnly = true;
            this.gestorCuentaID_Dsc.Width = 180;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Visible = false;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 180;
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "IdPagadora";
            this.IdPagadora.Name = "IdPagadora";
            this.IdPagadora.ReadOnly = true;
            this.IdPagadora.Visible = false;
            // 
            // IdPagadora_Dsc
            // 
            this.IdPagadora_Dsc.DataPropertyName = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.HeaderText = "Pagadora";
            this.IdPagadora_Dsc.Name = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.ReadOnly = true;
            this.IdPagadora_Dsc.Width = 180;
            // 
            // IdSector_tt_Dsc
            // 
            this.IdSector_tt_Dsc.DataPropertyName = "IdSector_tt_Dsc";
            this.IdSector_tt_Dsc.HeaderText = "Sector";
            this.IdSector_tt_Dsc.Name = "IdSector_tt_Dsc";
            this.IdSector_tt_Dsc.ReadOnly = true;
            // 
            // credFechaDes
            // 
            this.credFechaDes.DataPropertyName = "credFechaDes";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.credFechaDes.DefaultCellStyle = dataGridViewCellStyle1;
            this.credFechaDes.HeaderText = "Fecha Desembolso";
            this.credFechaDes.Name = "credFechaDes";
            this.credFechaDes.ReadOnly = true;
            this.credFechaDes.Width = 80;
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "IdLote";
            this.IdLote.HeaderText = "Nro. Lote";
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            // 
            // TipoCambio
            // 
            this.TipoCambio.DataPropertyName = "TipoCambio";
            this.TipoCambio.HeaderText = "TipoCambio";
            this.TipoCambio.Name = "TipoCambio";
            this.TipoCambio.ReadOnly = true;
            this.TipoCambio.Visible = false;
            // 
            // IdMoneda_tt
            // 
            this.IdMoneda_tt.DataPropertyName = "IdMoneda_tt";
            this.IdMoneda_tt.HeaderText = "IdMoneda_tt";
            this.IdMoneda_tt.Name = "IdMoneda_tt";
            this.IdMoneda_tt.ReadOnly = true;
            this.IdMoneda_tt.Visible = false;
            // 
            // IdMoneda_tt_Dsc
            // 
            this.IdMoneda_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdMoneda_tt_Dsc.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdMoneda_tt_Dsc.HeaderText = "Mon.";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            this.IdMoneda_tt_Dsc.Width = 60;
            // 
            // Desembolso
            // 
            this.Desembolso.DataPropertyName = "Desembolso";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Desembolso.DefaultCellStyle = dataGridViewCellStyle3;
            this.Desembolso.HeaderText = "Desembolso";
            this.Desembolso.Name = "Desembolso";
            this.Desembolso.ReadOnly = true;
            // 
            // credTasaAnual
            // 
            this.credTasaAnual.DataPropertyName = "credTasaAnual";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.credTasaAnual.DefaultCellStyle = dataGridViewCellStyle4;
            this.credTasaAnual.HeaderText = "TEA";
            this.credTasaAnual.Name = "credTasaAnual";
            this.credTasaAnual.ReadOnly = true;
            this.credTasaAnual.Width = 60;
            // 
            // iPlazoFin
            // 
            this.iPlazoFin.DataPropertyName = "iPlazoFin";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iPlazoFin.DefaultCellStyle = dataGridViewCellStyle5;
            this.iPlazoFin.HeaderText = "Plazo";
            this.iPlazoFin.Name = "iPlazoFin";
            this.iPlazoFin.ReadOnly = true;
            this.iPlazoFin.Width = 60;
            // 
            // Doc
            // 
            this.Doc.DataPropertyName = "Doc";
            this.Doc.HeaderText = "Doc";
            this.Doc.Name = "Doc";
            this.Doc.ReadOnly = true;
            this.Doc.Width = 60;
            // 
            // lblMes
            // 
            this.lblMes.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblMes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.Black;
            this.lblMes.Location = new System.Drawing.Point(928, 3);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(253, 23);
            this.lblMes.TabIndex = 2;
            this.lblMes.Text = "lblMes";
            this.lblMes.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblGestor
            // 
            this.lblGestor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblGestor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestor.ForeColor = System.Drawing.Color.Black;
            this.lblGestor.Location = new System.Drawing.Point(14, 3);
            this.lblGestor.Name = "lblGestor";
            this.lblGestor.Size = new System.Drawing.Size(335, 23);
            this.lblGestor.TabIndex = 4;
            this.lblGestor.Text = "lblGestor";
            // 
            // txtTotalSoles
            // 
            // 
            // 
            // 
            this.txtTotalSoles.Border.Class = "TextBoxBorder";
            this.txtTotalSoles.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalSoles.Location = new System.Drawing.Point(606, 610);
            this.txtTotalSoles.Name = "txtTotalSoles";
            this.txtTotalSoles.Size = new System.Drawing.Size(107, 20);
            this.txtTotalSoles.TabIndex = 31;
            this.txtTotalSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTDolares
            // 
            // 
            // 
            // 
            this.txtTDolares.Border.Class = "TextBoxBorder";
            this.txtTDolares.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTDolares.Location = new System.Drawing.Point(389, 610);
            this.txtTDolares.Name = "txtTDolares";
            this.txtTDolares.Size = new System.Drawing.Size(107, 20);
            this.txtTDolares.TabIndex = 30;
            this.txtTDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTSoles
            // 
            // 
            // 
            // 
            this.txtTSoles.Border.Class = "TextBoxBorder";
            this.txtTSoles.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTSoles.Location = new System.Drawing.Point(183, 610);
            this.txtTSoles.Name = "txtTSoles";
            this.txtTSoles.Size = new System.Drawing.Size(107, 20);
            this.txtTSoles.TabIndex = 29;
            this.txtTSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(537, 607);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(60, 23);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "Total en  S/";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(330, 607);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(60, 23);
            this.labelX2.TabIndex = 27;
            this.labelX2.Text = "Total U$$";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(130, 607);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 23);
            this.labelX1.TabIndex = 26;
            this.labelX1.Text = "Total S/";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(560, 4);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(103, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 11;
            this.buttonX3.Text = "Inf.Rend.Producto";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(402, 4);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(152, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 10;
            this.buttonX2.Text = "Inf.Rend.Sector/Pagadoras";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(293, 4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(103, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 9;
            this.buttonX1.Text = "Inf.Rend.Pagadora";
            // 
            // frmQrySociosRecuperados
            // 
            this.ClientSize = new System.Drawing.Size(1353, 640);
            this.Controls.Add(this.txtTotalSoles);
            this.Controls.Add(this.txtTDolares);
            this.Controls.Add(this.txtTSoles);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "frmQrySociosRecuperados";
            this.Text = "Detalle de desembolsos de Proveedores Recuperados";
            this.Load += new System.EventHandler(this.frmQrySociosRecuperados_Load);
            this.Controls.SetChildIndex(this.grpDato, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.txtTSoles, 0);
            this.Controls.SetChildIndex(this.txtTDolares, 0);
            this.Controls.SetChildIndex(this.txtTotalSoles, 0);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDatos;
        private DevComponents.DotNetBar.LabelX lblMes;
        private DevComponents.DotNetBar.LabelX lblGestor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTotalSoles;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTDolares;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTSoles;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestorCuentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestorCuentaID_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSector_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn credFechaDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn credTasaAnual;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPlazoFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}