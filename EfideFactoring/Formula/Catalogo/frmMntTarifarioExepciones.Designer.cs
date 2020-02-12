namespace EfideFactoring.Formula.Catalogo
{
    partial class frmMntTarifarioExepciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTarifario = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdTarifario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipCxcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCalculo_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorConcepto_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFrecuencia_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMonedaID_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTransferencia = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnBusquedaSocio = new DevComponents.DotNetBar.ButtonX();
            this.txtRazonSocialSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIdSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifario)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonBar1
            // 
            // 
            // 
            // 
            this.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar1.Size = new System.Drawing.Size(1146, 40);
            // 
            // 
            // 
            this.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.Controls.Add(this.labelX6);
            this.PanelEx1.Controls.Add(this.btnBusquedaSocio);
            this.PanelEx1.Controls.Add(this.txtRazonSocialSocio);
            this.PanelEx1.Controls.Add(this.txtIdSocio);
            this.PanelEx1.Size = new System.Drawing.Size(1146, 74);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.Controls.SetChildIndex(this.LabelX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.TextBoxX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtIdSocio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtRazonSocialSocio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBusquedaSocio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX6, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(519, 15);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(442, 15);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(74, 16);
            this.TextBoxX1.Size = new System.Drawing.Size(229, 20);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Text = "Concepto";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Location = new System.Drawing.Point(0, 120);
            this.lblGrilla.Text = "Tarifario";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(970, 121);
            // 
            // dgvTarifario
            // 
            this.dgvTarifario.AllowUserToAddRows = false;
            this.dgvTarifario.AllowUserToDeleteRows = false;
            this.dgvTarifario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTarifario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTarifario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTarifario,
            this.IdSocio,
            this.IdSocio_Dsc,
            this.IdPagadora,
            this.IdPagadora_Dsc,
            this.tipCxcNombre,
            this.IdCalculo_tt_Dsc,
            this.PorConcepto_tt_Dsc,
            this.IdFrecuencia_tt_Dsc,
            this.valorMonedaID_Dsc,
            this.Monto,
            this.PorMonto,
            this.bTransferencia});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarifario.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTarifario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTarifario.Location = new System.Drawing.Point(0, 149);
            this.dgvTarifario.Name = "dgvTarifario";
            this.dgvTarifario.ReadOnly = true;
            this.dgvTarifario.RowHeadersWidth = 10;
            this.dgvTarifario.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTarifario.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTarifario.Size = new System.Drawing.Size(1146, 327);
            this.dgvTarifario.TabIndex = 25;
            // 
            // IdTarifario
            // 
            this.IdTarifario.DataPropertyName = "IdTarifario";
            this.IdTarifario.HeaderText = "Código";
            this.IdTarifario.Name = "IdTarifario";
            this.IdTarifario.ReadOnly = true;
            this.IdTarifario.Width = 65;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Visible = false;
            this.IdSocio.Width = 68;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 59;
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "IdPagadora";
            this.IdPagadora.Name = "IdPagadora";
            this.IdPagadora.ReadOnly = true;
            this.IdPagadora.Visible = false;
            this.IdPagadora.Width = 87;
            // 
            // IdPagadora_Dsc
            // 
            this.IdPagadora_Dsc.DataPropertyName = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.HeaderText = "Pagadora";
            this.IdPagadora_Dsc.Name = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.ReadOnly = true;
            this.IdPagadora_Dsc.Width = 78;
            // 
            // tipCxcNombre
            // 
            this.tipCxcNombre.DataPropertyName = "tipCxcNombre";
            this.tipCxcNombre.HeaderText = "Concepto";
            this.tipCxcNombre.Name = "tipCxcNombre";
            this.tipCxcNombre.ReadOnly = true;
            this.tipCxcNombre.Width = 78;
            // 
            // IdCalculo_tt_Dsc
            // 
            this.IdCalculo_tt_Dsc.DataPropertyName = "IdCalculo_tt_Dsc";
            this.IdCalculo_tt_Dsc.HeaderText = "Cálculo";
            this.IdCalculo_tt_Dsc.Name = "IdCalculo_tt_Dsc";
            this.IdCalculo_tt_Dsc.ReadOnly = true;
            this.IdCalculo_tt_Dsc.Width = 67;
            // 
            // PorConcepto_tt_Dsc
            // 
            this.PorConcepto_tt_Dsc.DataPropertyName = "PorConcepto_tt_Dsc";
            this.PorConcepto_tt_Dsc.HeaderText = "Porcentaje de";
            this.PorConcepto_tt_Dsc.Name = "PorConcepto_tt_Dsc";
            this.PorConcepto_tt_Dsc.ReadOnly = true;
            this.PorConcepto_tt_Dsc.Width = 98;
            // 
            // IdFrecuencia_tt_Dsc
            // 
            this.IdFrecuencia_tt_Dsc.DataPropertyName = "IdFrecuencia_tt_Dsc";
            this.IdFrecuencia_tt_Dsc.HeaderText = "Frecuencia";
            this.IdFrecuencia_tt_Dsc.Name = "IdFrecuencia_tt_Dsc";
            this.IdFrecuencia_tt_Dsc.ReadOnly = true;
            this.IdFrecuencia_tt_Dsc.Width = 85;
            // 
            // valorMonedaID_Dsc
            // 
            this.valorMonedaID_Dsc.DataPropertyName = "valorMonedaID_Dsc";
            this.valorMonedaID_Dsc.HeaderText = "Moneda";
            this.valorMonedaID_Dsc.Name = "valorMonedaID_Dsc";
            this.valorMonedaID_Dsc.ReadOnly = true;
            this.valorMonedaID_Dsc.Width = 71;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle5;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 62;
            // 
            // PorMonto
            // 
            this.PorMonto.DataPropertyName = "PorMonto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PorMonto.DefaultCellStyle = dataGridViewCellStyle6;
            this.PorMonto.HeaderText = "Porcentaje";
            this.PorMonto.Name = "PorMonto";
            this.PorMonto.ReadOnly = true;
            this.PorMonto.Width = 83;
            // 
            // bTransferencia
            // 
            this.bTransferencia.Checked = true;
            this.bTransferencia.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.bTransferencia.CheckValue = "N";
            this.bTransferencia.DataPropertyName = "bTransferencia";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.bTransferencia.DefaultCellStyle = dataGridViewCellStyle7;
            this.bTransferencia.HeaderText = "Transferencia";
            this.bTransferencia.Name = "bTransferencia";
            this.bTransferencia.ReadOnly = true;
            this.bTransferencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bTransferencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bTransferencia.Width = 97;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX6.Location = new System.Drawing.Point(14, 36);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(49, 23);
            this.labelX6.TabIndex = 20;
            this.labelX6.Text = "Socio";
            // 
            // btnBusquedaSocio
            // 
            this.btnBusquedaSocio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBusquedaSocio.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBusquedaSocio.Location = new System.Drawing.Point(400, 39);
            this.btnBusquedaSocio.Name = "btnBusquedaSocio";
            this.btnBusquedaSocio.Size = new System.Drawing.Size(26, 20);
            this.btnBusquedaSocio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBusquedaSocio.TabIndex = 19;
            this.btnBusquedaSocio.Text = "...";
            this.btnBusquedaSocio.Click += new System.EventHandler(this.btnBusquedaSocio_Click);
            // 
            // txtRazonSocialSocio
            // 
            // 
            // 
            // 
            this.txtRazonSocialSocio.Border.Class = "TextBoxBorder";
            this.txtRazonSocialSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRazonSocialSocio.Location = new System.Drawing.Point(193, 39);
            this.txtRazonSocialSocio.Name = "txtRazonSocialSocio";
            this.txtRazonSocialSocio.ReadOnly = true;
            this.txtRazonSocialSocio.Size = new System.Drawing.Size(204, 20);
            this.txtRazonSocialSocio.TabIndex = 18;
            this.txtRazonSocialSocio.TabStop = false;
            // 
            // txtIdSocio
            // 
            // 
            // 
            // 
            this.txtIdSocio.Border.Class = "TextBoxBorder";
            this.txtIdSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdSocio.Location = new System.Drawing.Point(74, 39);
            this.txtIdSocio.Name = "txtIdSocio";
            this.txtIdSocio.ReadOnly = true;
            this.txtIdSocio.Size = new System.Drawing.Size(113, 20);
            this.txtIdSocio.TabIndex = 17;
            this.txtIdSocio.TabStop = false;
            // 
            // frmMntTarifarioExepciones
            // 
            this.ClientSize = new System.Drawing.Size(1146, 477);
            this.Controls.Add(this.dgvTarifario);
            this.DoubleBuffered = true;
            this.Name = "frmMntTarifarioExepciones";
            this.Text = "Mantenimiento de Tarifario por Exepciones";
            this.Load += new System.EventHandler(this.frmMntTarifarioExepciones_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvTarifario, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTarifario;
        protected DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnBusquedaSocio;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRazonSocialSocio;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTarifario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipCxcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCalculo_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorConcepto_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFrecuencia_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMonedaID_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorMonto;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn bTransferencia;
    }
}