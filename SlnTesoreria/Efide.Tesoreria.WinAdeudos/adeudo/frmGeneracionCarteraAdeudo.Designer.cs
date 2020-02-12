namespace Efide.Tesoreria.WinAdeudos.adeudo
{
    partial class frmGeneracionCarteraAdeudo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnGenerar = new DevComponents.DotNetBar.ButtonItem();
            this.btnExportar = new DevComponents.DotNetBar.ButtonItem();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.pnlFiltro = new DevComponents.DotNetBar.PanelEx();
            this.cboMes = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboAnio = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvCartera = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ucLoadingBar1 = new Efide.ControlsComponent.ucLoadingBar();
            this.ucMsgBox1 = new Efide.ControlsComponent.ucMsgBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartera)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnGenerar,
            this.btnExportar,
            this.btnSalir});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(585, 39);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 23;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnGenerar
            // 
            this.btnGenerar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnGenerar.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.refresh;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.SubItemsExpandWidth = 14;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExportar.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.buscar;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.SubItemsExpandWidth = 14;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSalir.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.cerrar;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.SubItemsExpandWidth = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlFiltro.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlFiltro.Controls.Add(this.cboMes);
            this.pnlFiltro.Controls.Add(this.labelX2);
            this.pnlFiltro.Controls.Add(this.cboAnio);
            this.pnlFiltro.Controls.Add(this.labelX1);
            this.pnlFiltro.Location = new System.Drawing.Point(0, 45);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(584, 46);
            this.pnlFiltro.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlFiltro.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlFiltro.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlFiltro.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlFiltro.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlFiltro.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlFiltro.Style.GradientAngle = 90;
            this.pnlFiltro.TabIndex = 24;
            // 
            // cboMes
            // 
            this.cboMes.DisplayMember = "Text";
            this.cboMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.ItemHeight = 14;
            this.cboMes.Location = new System.Drawing.Point(372, 14);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(186, 20);
            this.cboMes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMes.TabIndex = 56;
            this.cboMes.SelectedIndexChanged += new System.EventHandler(this.cboMes_SelectedIndexChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(296, 11);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 23);
            this.labelX2.TabIndex = 55;
            this.labelX2.Text = "Mes:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboAnio
            // 
            this.cboAnio.DisplayMember = "Text";
            this.cboAnio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.ItemHeight = 14;
            this.cboAnio.Location = new System.Drawing.Point(85, 14);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(186, 20);
            this.cboAnio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboAnio.TabIndex = 54;
            this.cboAnio.SelectedIndexChanged += new System.EventHandler(this.cboAnio_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(9, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(70, 23);
            this.labelX1.TabIndex = 53;
            this.labelX1.Text = "Periodo:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvCartera
            // 
            this.dgvCartera.AllowUserToAddRows = false;
            this.dgvCartera.AllowUserToDeleteRows = false;
            this.dgvCartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCartera.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCartera.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCartera.Location = new System.Drawing.Point(0, 97);
            this.dgvCartera.MultiSelect = false;
            this.dgvCartera.Name = "dgvCartera";
            this.dgvCartera.ReadOnly = true;
            this.dgvCartera.RowHeadersVisible = false;
            this.dgvCartera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartera.Size = new System.Drawing.Size(584, 214);
            this.dgvCartera.TabIndex = 25;
            // 
            // ucLoadingBar1
            // 
            this.ucLoadingBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadingBar1.Location = new System.Drawing.Point(405, 315);
            this.ucLoadingBar1.Name = "ucLoadingBar1";
            this.ucLoadingBar1.Size = new System.Drawing.Size(179, 26);
            this.ucLoadingBar1.TabIndex = 26;
            // 
            // ucMsgBox1
            // 
            this.ucMsgBox1.Location = new System.Drawing.Point(0, 317);
            this.ucMsgBox1.Name = "ucMsgBox1";
            this.ucMsgBox1.Size = new System.Drawing.Size(10, 10);
            this.ucMsgBox1.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idProceso";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "fechaProceso";
            this.Column2.HeaderText = "Fecha de Proceso";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "anio";
            this.Column3.HeaderText = "Año";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mes";
            this.Column4.HeaderText = "Mes";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cantAdeudos";
            this.Column5.HeaderText = "Cant. Adeudo.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // frmGeneracionCarteraAdeudo
            // 
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.ucMsgBox1);
            this.Controls.Add(this.ucLoadingBar1);
            this.Controls.Add(this.dgvCartera);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.ribbonBar1);
            this.DoubleBuffered = true;
            this.Name = "frmGeneracionCarteraAdeudo";
            this.Text = "Generación de Cartera";
            this.Load += new System.EventHandler(this.frmGeneracionCarteraAdeudo_Load);
            this.pnlFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnGenerar;
        private DevComponents.DotNetBar.ButtonItem btnSalir;
        public DevComponents.DotNetBar.PanelEx pnlFiltro;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCartera;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMes;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboAnio;
        private DevComponents.DotNetBar.LabelX labelX1;
        private ControlsComponent.ucLoadingBar ucLoadingBar1;
        private ControlsComponent.ucMsgBox ucMsgBox1;
        private DevComponents.DotNetBar.ButtonItem btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}