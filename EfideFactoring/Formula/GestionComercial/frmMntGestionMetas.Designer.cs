namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmMntGestionMetas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvGestionMetas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Annio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GestorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GestorId_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnProcesar = new DevComponents.DotNetBar.ButtonX();
            this.cboMes = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtAnnio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblMes = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionMetas)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvGestionMetas);
            this.groupPanel1.Controls.Add(this.panelEx2);
            this.groupPanel1.Location = new System.Drawing.Point(2, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(701, 340);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // dgvGestionMetas
            // 
            this.dgvGestionMetas.AllowUserToAddRows = false;
            this.dgvGestionMetas.AllowUserToDeleteRows = false;
            this.dgvGestionMetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGestionMetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionMetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Annio,
            this.Mes,
            this.GestorId,
            this.GestorId_Dsc,
            this.Monto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGestionMetas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGestionMetas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvGestionMetas.Location = new System.Drawing.Point(0, 53);
            this.dgvGestionMetas.Name = "dgvGestionMetas";
            this.dgvGestionMetas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGestionMetas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGestionMetas.Size = new System.Drawing.Size(689, 265);
            this.dgvGestionMetas.TabIndex = 61;
            this.dgvGestionMetas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvGestionMetas_CurrentCellDirtyStateChanged);
            // 
            // Annio
            // 
            this.Annio.DataPropertyName = "Annio";
            this.Annio.HeaderText = "Annio";
            this.Annio.Name = "Annio";
            this.Annio.Visible = false;
            // 
            // Mes
            // 
            this.Mes.DataPropertyName = "Mes";
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            this.Mes.Visible = false;
            // 
            // GestorId
            // 
            this.GestorId.DataPropertyName = "GestorId";
            this.GestorId.HeaderText = "Id";
            this.GestorId.Name = "GestorId";
            this.GestorId.ReadOnly = true;
            // 
            // GestorId_Dsc
            // 
            this.GestorId_Dsc.DataPropertyName = "GestorId_Dsc";
            this.GestorId_Dsc.HeaderText = "Ejecutivo";
            this.GestorId_Dsc.Name = "GestorId_Dsc";
            this.GestorId_Dsc.ReadOnly = true;
            this.GestorId_Dsc.Width = 150;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 120;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.panelEx2.Controls.Add(this.btnProcesar);
            this.panelEx2.Controls.Add(this.cboMes);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.Controls.Add(this.txtAnnio);
            this.panelEx2.Controls.Add(this.LabelX1);
            this.panelEx2.Controls.Add(this.lblMes);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(695, 47);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 60;
            // 
            // btnProcesar
            // 
            this.btnProcesar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProcesar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnProcesar.Location = new System.Drawing.Point(376, 13);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnProcesar.TabIndex = 20;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // cboMes
            // 
            this.cboMes.DisplayMember = "Text";
            this.cboMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.ItemHeight = 14;
            this.cboMes.Items.AddRange(new object[] {
            this.comboItem2});
            this.cboMes.Location = new System.Drawing.Point(229, 13);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(103, 20);
            this.cboMes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMes.TabIndex = 19;
            this.cboMes.SelectedIndexChanged += new System.EventHandler(this.cboMes_SelectedIndexChanged);
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "<< Todos >>";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(188, 13);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 20);
            this.labelX3.TabIndex = 18;
            this.labelX3.Text = "Mes";
            // 
            // txtAnnio
            // 
            // 
            // 
            // 
            this.txtAnnio.Border.Class = "TextBoxBorder";
            this.txtAnnio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAnnio.Location = new System.Drawing.Point(65, 13);
            this.txtAnnio.Name = "txtAnnio";
            this.txtAnnio.ReadOnly = true;
            this.txtAnnio.Size = new System.Drawing.Size(77, 20);
            this.txtAnnio.TabIndex = 17;
            this.txtAnnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelX1.Location = new System.Drawing.Point(20, 13);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(59, 20);
            this.LabelX1.TabIndex = 16;
            this.LabelX1.Text = "Año";
            // 
            // lblMes
            // 
            // 
            // 
            // 
            this.lblMes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.Black;
            this.lblMes.Location = new System.Drawing.Point(607, 34);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(238, 20);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mes Procesado:";
            this.lblMes.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // frmMntGestionMetas
            // 
            this.ClientSize = new System.Drawing.Size(705, 357);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmMntGestionMetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metas de los Ejecutivos";
            this.Load += new System.EventHandler(this.frmMntGestionMetas_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionMetas)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        protected DevComponents.DotNetBar.PanelEx panelEx2;
        protected DevComponents.DotNetBar.LabelX lblMes;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvGestionMetas;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMes;
        private DevComponents.Editors.ComboItem comboItem2;
        protected DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAnnio;
        protected DevComponents.DotNetBar.LabelX LabelX1;
        private DevComponents.DotNetBar.ButtonX btnProcesar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Annio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn GestorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GestorId_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;

    }
}