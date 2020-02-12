namespace Efide.Tesoreria.WinAdeudos.lista
{
    partial class frmListaRescisionAdeudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaRescisionAdeudo));
            this.ucLoadingBar1 = new Efide.ControlsComponent.ucLoadingBar();
            this.cboTipoInversion = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX24 = new DevComponents.DotNetBar.LabelX();
            this.txtCodigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtpFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtpInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkFiltroFecha = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cboTipoFecha = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.fecInicio = new DevComponents.Editors.ComboItem();
            this.fecVencimiento = new DevComponents.Editors.ComboItem();
            this.cboMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.cboBanco = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboTipoEntidadFinanciera = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dgvRescision = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ucMsgBox1 = new Efide.ControlsComponent.ucMsgBox();
            this.cboEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.Column16 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRescision)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            // 
            // 
            // 
            this.toolBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolBar.Size = new System.Drawing.Size(1266, 39);
            // 
            // 
            // 
            this.toolBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.cboEstado);
            this.pnlFiltro.Controls.Add(this.labelX2);
            this.pnlFiltro.Controls.Add(this.cboTipoInversion);
            this.pnlFiltro.Controls.Add(this.labelX24);
            this.pnlFiltro.Controls.Add(this.txtCodigo);
            this.pnlFiltro.Controls.Add(this.labelX1);
            this.pnlFiltro.Controls.Add(this.dtpFin);
            this.pnlFiltro.Controls.Add(this.dtpInicio);
            this.pnlFiltro.Controls.Add(this.chkFiltroFecha);
            this.pnlFiltro.Controls.Add(this.cboTipoFecha);
            this.pnlFiltro.Controls.Add(this.cboMoneda);
            this.pnlFiltro.Controls.Add(this.cboBanco);
            this.pnlFiltro.Controls.Add(this.cboTipoEntidadFinanciera);
            this.pnlFiltro.Controls.Add(this.labelX9);
            this.pnlFiltro.Controls.Add(this.labelX7);
            this.pnlFiltro.Controls.Add(this.labelX6);
            this.pnlFiltro.Location = new System.Drawing.Point(0, 45);
            this.pnlFiltro.Size = new System.Drawing.Size(1263, 66);
            this.pnlFiltro.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlFiltro.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlFiltro.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlFiltro.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlFiltro.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlFiltro.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlFiltro.Style.GradientAngle = 90;
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ucLoadingBar1
            // 
            this.ucLoadingBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadingBar1.Location = new System.Drawing.Point(1045, 395);
            this.ucLoadingBar1.Name = "ucLoadingBar1";
            this.ucLoadingBar1.Size = new System.Drawing.Size(167, 26);
            this.ucLoadingBar1.TabIndex = 25;
            // 
            // cboTipoInversion
            // 
            this.cboTipoInversion.DisplayMember = "Text";
            this.cboTipoInversion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoInversion.FormattingEnabled = true;
            this.cboTipoInversion.ItemHeight = 14;
            this.cboTipoInversion.Location = new System.Drawing.Point(113, 32);
            this.cboTipoInversion.Name = "cboTipoInversion";
            this.cboTipoInversion.Size = new System.Drawing.Size(192, 20);
            this.cboTipoInversion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoInversion.TabIndex = 81;
            this.cboTipoInversion.SelectedIndexChanged += new System.EventHandler(this.cboTipoInversion_SelectedIndexChanged);
            // 
            // labelX24
            // 
            this.labelX24.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX24.Location = new System.Drawing.Point(11, 29);
            this.labelX24.Name = "labelX24";
            this.labelX24.Size = new System.Drawing.Size(96, 23);
            this.labelX24.TabIndex = 82;
            this.labelX24.Text = "Tipo de Inversión:";
            this.labelX24.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.Border.Class = "TextBoxBorder";
            this.txtCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodigo.Location = new System.Drawing.Point(113, 10);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(192, 20);
            this.txtCodigo.TabIndex = 80;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(62, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(45, 23);
            this.labelX1.TabIndex = 79;
            this.labelX1.Text = "Código:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dtpFin
            // 
            // 
            // 
            // 
            this.dtpFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFin.ButtonDropDown.Visible = true;
            this.dtpFin.IsPopupCalendarOpen = false;
            this.dtpFin.Location = new System.Drawing.Point(1126, 31);
            // 
            // 
            // 
            this.dtpFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFin.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpFin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFin.MonthCalendar.DisplayMonth = new System.DateTime(2018, 8, 1, 0, 0, 0, 0);
            this.dtpFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFin.MonthCalendar.TodayButtonVisible = true;
            this.dtpFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(125, 20);
            this.dtpFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFin.TabIndex = 78;
            // 
            // dtpInicio
            // 
            // 
            // 
            // 
            this.dtpInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpInicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpInicio.ButtonDropDown.Visible = true;
            this.dtpInicio.IsPopupCalendarOpen = false;
            this.dtpInicio.Location = new System.Drawing.Point(1000, 31);
            // 
            // 
            // 
            this.dtpInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpInicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpInicio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpInicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpInicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpInicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpInicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpInicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpInicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpInicio.MonthCalendar.DisplayMonth = new System.DateTime(2018, 8, 1, 0, 0, 0, 0);
            this.dtpInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpInicio.MonthCalendar.TodayButtonVisible = true;
            this.dtpInicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(125, 20);
            this.dtpInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpInicio.TabIndex = 75;
            // 
            // chkFiltroFecha
            // 
            // 
            // 
            // 
            this.chkFiltroFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFiltroFecha.Location = new System.Drawing.Point(787, 29);
            this.chkFiltroFecha.Name = "chkFiltroFecha";
            this.chkFiltroFecha.Size = new System.Drawing.Size(18, 23);
            this.chkFiltroFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFiltroFecha.TabIndex = 77;
            this.chkFiltroFecha.CheckedChanged += new System.EventHandler(this.chkFiltroFecha_CheckedChanged);
            // 
            // cboTipoFecha
            // 
            this.cboTipoFecha.DisplayMember = "Text";
            this.cboTipoFecha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoFecha.FormattingEnabled = true;
            this.cboTipoFecha.ItemHeight = 14;
            this.cboTipoFecha.Items.AddRange(new object[] {
            this.fecInicio,
            this.fecVencimiento});
            this.cboTipoFecha.Location = new System.Drawing.Point(811, 31);
            this.cboTipoFecha.Name = "cboTipoFecha";
            this.cboTipoFecha.Size = new System.Drawing.Size(186, 20);
            this.cboTipoFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoFecha.TabIndex = 76;
            // 
            // fecInicio
            // 
            this.fecInicio.Text = "Fecha de Inicio";
            // 
            // fecVencimiento
            // 
            this.fecVencimiento.Text = "Fecha de Vencimiento";
            // 
            // cboMoneda
            // 
            this.cboMoneda.DisplayMember = "Text";
            this.cboMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.ItemHeight = 14;
            this.cboMoneda.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cboMoneda.Location = new System.Drawing.Point(811, 10);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(186, 20);
            this.cboMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMoneda.TabIndex = 74;
            this.cboMoneda.SelectedIndexChanged += new System.EventHandler(this.cboMoneda_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Fecha de Inicio";
            this.comboItem1.Value = "0";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Fecha de vencimiento";
            this.comboItem2.Value = "1";
            // 
            // cboBanco
            // 
            this.cboBanco.DisplayMember = "Text";
            this.cboBanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.ItemHeight = 14;
            this.cboBanco.Location = new System.Drawing.Point(453, 31);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(238, 20);
            this.cboBanco.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBanco.TabIndex = 73;
            this.cboBanco.SelectedIndexChanged += new System.EventHandler(this.cboBanco_SelectedIndexChanged);
            // 
            // cboTipoEntidadFinanciera
            // 
            this.cboTipoEntidadFinanciera.DisplayMember = "Text";
            this.cboTipoEntidadFinanciera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoEntidadFinanciera.FormattingEnabled = true;
            this.cboTipoEntidadFinanciera.ItemHeight = 14;
            this.cboTipoEntidadFinanciera.Location = new System.Drawing.Point(453, 10);
            this.cboTipoEntidadFinanciera.Name = "cboTipoEntidadFinanciera";
            this.cboTipoEntidadFinanciera.Size = new System.Drawing.Size(238, 20);
            this.cboTipoEntidadFinanciera.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoEntidadFinanciera.TabIndex = 72;
            this.cboTipoEntidadFinanciera.SelectedIndexChanged += new System.EventHandler(this.cboTipoEntidadFinanciera_SelectedIndexChanged);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(735, 7);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(70, 23);
            this.labelX9.TabIndex = 71;
            this.labelX9.Text = "Moneda:";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(369, 31);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(78, 23);
            this.labelX7.TabIndex = 70;
            this.labelX7.Text = "Instituciones:";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(356, 10);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(91, 23);
            this.labelX6.TabIndex = 69;
            this.labelX6.Text = "Tipo Financiera:";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvRescision
            // 
            this.dgvRescision.AllowUserToAddRows = false;
            this.dgvRescision.AllowUserToDeleteRows = false;
            this.dgvRescision.AllowUserToResizeColumns = false;
            this.dgvRescision.AllowUserToResizeRows = false;
            this.dgvRescision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRescision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column11,
            this.Column8,
            this.Column12,
            this.Column9,
            this.Column7,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRescision.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRescision.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRescision.Location = new System.Drawing.Point(1, 117);
            this.dgvRescision.MultiSelect = false;
            this.dgvRescision.Name = "dgvRescision";
            this.dgvRescision.ReadOnly = true;
            this.dgvRescision.RowHeadersVisible = false;
            this.dgvRescision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRescision.Size = new System.Drawing.Size(1262, 274);
            this.dgvRescision.TabIndex = 26;
            this.dgvRescision.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRescision_CellContentClick);
            this.dgvRescision.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRescision_CellDoubleClick);
            // 
            // ucMsgBox1
            // 
            this.ucMsgBox1.Location = new System.Drawing.Point(1, 402);
            this.ucMsgBox1.Name = "ucMsgBox1";
            this.ucMsgBox1.Size = new System.Drawing.Size(10, 10);
            this.ucMsgBox1.TabIndex = 27;
            // 
            // cboEstado
            // 
            this.cboEstado.DisplayMember = "Text";
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 14;
            this.cboEstado.Location = new System.Drawing.Point(1126, 10);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(125, 20);
            this.cboEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEstado.TabIndex = 84;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(1066, 7);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 23);
            this.labelX2.TabIndex = 83;
            this.labelX2.Text = "Estado:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "idRescision";
            this.Column10.HeaderText = "Cod. Rescisión";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column10.Width = 110;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idAdeudo";
            this.Column1.HeaderText = "Cod. Adeudo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nomTipoAdeudo";
            this.Column2.HeaderText = "Tipo de Adeudo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nomEntidadFinanciera";
            this.Column3.HeaderText = "Banco";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 175;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nomMoneda";
            this.Column4.HeaderText = "Moneda";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "importe";
            this.Column5.HeaderText = "Importe";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tasa";
            this.Column6.HeaderText = "Tasa";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "interes";
            this.Column11.HeaderText = "Interés";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 90;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "plazo";
            this.Column8.HeaderText = "Plazo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 70;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "total";
            this.Column12.HeaderText = "Total a Pagar";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "tasaCerrada";
            this.Column9.HeaderText = "Tasa Cerrada";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "nomEstado";
            this.Column7.HeaderText = "Estado";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "fechaCrecion";
            this.Column13.HeaderText = "Fec. Operación";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 110;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "idEstado";
            this.Column14.HeaderText = "idEstado";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Anu";
            this.Column15.Image = ((System.Drawing.Image)(resources.GetObject("Column15.Image")));
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Text = null;
            this.Column15.Width = 30;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Ext";
            this.Column16.Image = ((System.Drawing.Image)(resources.GetObject("Column16.Image")));
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Text = null;
            this.Column16.Width = 30;
            // 
            // frmListaRescisionAdeudo
            // 
            this.ClientSize = new System.Drawing.Size(1266, 418);
            this.Controls.Add(this.ucMsgBox1);
            this.Controls.Add(this.dgvRescision);
            this.Controls.Add(this.ucLoadingBar1);
            this.DoubleBuffered = true;
            this.Name = "frmListaRescisionAdeudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lista de Rescisión";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmListaRescision_Load);
            this.Controls.SetChildIndex(this.toolBar, 0);
            this.Controls.SetChildIndex(this.pnlFiltro, 0);
            this.Controls.SetChildIndex(this.ucLoadingBar1, 0);
            this.Controls.SetChildIndex(this.dgvRescision, 0);
            this.Controls.SetChildIndex(this.ucMsgBox1, 0);
            this.pnlFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRescision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsComponent.ucLoadingBar ucLoadingBar1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoInversion;
        private DevComponents.DotNetBar.LabelX labelX24;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodigo;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpInicio;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFiltroFecha;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoFecha;
        private DevComponents.Editors.ComboItem fecInicio;
        private DevComponents.Editors.ComboItem fecVencimiento;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMoneda;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBanco;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoEntidadFinanciera;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRescision;
        private ControlsComponent.ucMsgBox ucMsgBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEstado;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Column15;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Column16;
    }
}