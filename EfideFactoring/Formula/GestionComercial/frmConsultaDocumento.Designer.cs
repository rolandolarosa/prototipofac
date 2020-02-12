namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmConsultaDocumento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIdSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.dgvDocumentos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdPagadora_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocumento_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdDesembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvNegociable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.dgvDocumentos);
            this.grpDato.Controls.Add(this.txtSocio);
            this.grpDato.Controls.Add(this.txtIdSocio);
            this.grpDato.Controls.Add(this.labelX7);
            this.grpDato.Size = new System.Drawing.Size(940, 450);
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
            this.btnCancelar.Location = new System.Drawing.Point(859, 471);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(768, 471);
            this.btnAceptar.Visible = false;
            // 
            // txtSocio
            // 
            // 
            // 
            // 
            this.txtSocio.Border.Class = "TextBoxBorder";
            this.txtSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSocio.Enabled = false;
            this.txtSocio.Location = new System.Drawing.Point(280, 26);
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(318, 22);
            this.txtSocio.TabIndex = 8;
            // 
            // txtIdSocio
            // 
            // 
            // 
            // 
            this.txtIdSocio.Border.Class = "TextBoxBorder";
            this.txtIdSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdSocio.Enabled = false;
            this.txtIdSocio.Location = new System.Drawing.Point(114, 27);
            this.txtIdSocio.Name = "txtIdSocio";
            this.txtIdSocio.Size = new System.Drawing.Size(160, 22);
            this.txtIdSocio.TabIndex = 7;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(18, 26);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(79, 23);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "Socio";
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.AllowUserToDeleteRows = false;
            this.dgvDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPagadora_Dsc,
            this.IdMoneda_tt_Dsc,
            this.IdDocumento_Dsc,
            this.sdVencimiento,
            this.sdDesembolso,
            this.nvNegociable,
            this.IdEstado_tt_Dsc});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocumentos.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDocumentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDocumentos.Location = new System.Drawing.Point(18, 70);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.ReadOnly = true;
            this.dgvDocumentos.RowTemplate.Height = 24;
            this.dgvDocumentos.Size = new System.Drawing.Size(895, 351);
            this.dgvDocumentos.TabIndex = 9;
            // 
            // IdPagadora_Dsc
            // 
            this.IdPagadora_Dsc.DataPropertyName = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.HeaderText = "Pagadora";
            this.IdPagadora_Dsc.Name = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.ReadOnly = true;
            this.IdPagadora_Dsc.Width = 120;
            // 
            // IdMoneda_tt_Dsc
            // 
            this.IdMoneda_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.HeaderText = "Moneda";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            // 
            // IdDocumento_Dsc
            // 
            this.IdDocumento_Dsc.DataPropertyName = "IdDocumento_Dsc";
            this.IdDocumento_Dsc.HeaderText = "Documento";
            this.IdDocumento_Dsc.Name = "IdDocumento_Dsc";
            this.IdDocumento_Dsc.ReadOnly = true;
            // 
            // sdVencimiento
            // 
            this.sdVencimiento.DataPropertyName = "sdVencimiento";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.sdVencimiento.DefaultCellStyle = dataGridViewCellStyle9;
            this.sdVencimiento.HeaderText = "Fecha Venc.";
            this.sdVencimiento.Name = "sdVencimiento";
            this.sdVencimiento.ReadOnly = true;
            // 
            // sdDesembolso
            // 
            this.sdDesembolso.DataPropertyName = "sdDesembolso";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.sdDesembolso.DefaultCellStyle = dataGridViewCellStyle10;
            this.sdDesembolso.HeaderText = "Fecha Desembolso";
            this.sdDesembolso.Name = "sdDesembolso";
            this.sdDesembolso.ReadOnly = true;
            // 
            // nvNegociable
            // 
            this.nvNegociable.DataPropertyName = "nvNegociable";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.nvNegociable.DefaultCellStyle = dataGridViewCellStyle11;
            this.nvNegociable.HeaderText = "V. Negociable";
            this.nvNegociable.Name = "nvNegociable";
            this.nvNegociable.ReadOnly = true;
            // 
            // IdEstado_tt_Dsc
            // 
            this.IdEstado_tt_Dsc.DataPropertyName = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.HeaderText = "Estado";
            this.IdEstado_tt_Dsc.Name = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.ReadOnly = true;
            // 
            // frmConsultaDocumento
            // 
            this.ClientSize = new System.Drawing.Size(948, 507);
            this.DoubleBuffered = true;
            this.Name = "frmConsultaDocumento";
            this.Text = "Consulta de Documentos";
            this.Load += new System.EventHandler(this.frmConsultaDocumento_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDocumentos;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSocio;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdSocio;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdDesembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvNegociable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc;
    }
}