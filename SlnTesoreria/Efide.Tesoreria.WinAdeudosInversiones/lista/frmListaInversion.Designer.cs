namespace Efide.Tesoreria.WinAdeudosInversiones.lista
{
    partial class frmListaInversion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaInversion));
            this.ucMsgBox1 = new Efide.ControlsComponent.ucMsgBox();
            this.ucLoadingBar2 = new Efide.ControlsComponent.ucLoadingBar();
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
            this.ucLoadingBar1 = new Efide.ControlsComponent.ucLoadingBar();
            this.dgvInversion = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFinanciera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.Column12 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.cboEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInversion)).BeginInit();
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
            this.toolBar.Size = new System.Drawing.Size(1225, 39);
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
            this.pnlFiltro.Size = new System.Drawing.Size(1224, 66);
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
            // btnSalir
            // 
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ucMsgBox1
            // 
            this.ucMsgBox1.Location = new System.Drawing.Point(0, 338);
            this.ucMsgBox1.Name = "ucMsgBox1";
            this.ucMsgBox1.Size = new System.Drawing.Size(10, 10);
            this.ucMsgBox1.TabIndex = 24;
            // 
            // ucLoadingBar2
            // 
            this.ucLoadingBar2.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadingBar2.Location = new System.Drawing.Point(627, 355);
            this.ucLoadingBar2.Name = "ucLoadingBar2";
            this.ucLoadingBar2.Size = new System.Drawing.Size(168, 26);
            this.ucLoadingBar2.TabIndex = 25;
            // 
            // cboTipoInversion
            // 
            this.cboTipoInversion.DisplayMember = "Text";
            this.cboTipoInversion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoInversion.FormattingEnabled = true;
            this.cboTipoInversion.ItemHeight = 14;
            this.cboTipoInversion.Location = new System.Drawing.Point(113, 34);
            this.cboTipoInversion.Name = "cboTipoInversion";
            this.cboTipoInversion.Size = new System.Drawing.Size(192, 20);
            this.cboTipoInversion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoInversion.TabIndex = 67;
            this.cboTipoInversion.SelectedIndexChanged += new System.EventHandler(this.cboTipoInversion_SelectedIndexChanged);
            // 
            // labelX24
            // 
            this.labelX24.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX24.Location = new System.Drawing.Point(11, 31);
            this.labelX24.Name = "labelX24";
            this.labelX24.Size = new System.Drawing.Size(96, 23);
            this.labelX24.TabIndex = 68;
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
            this.txtCodigo.TabIndex = 66;
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
            this.labelX1.TabIndex = 65;
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
            this.dtpFin.Location = new System.Drawing.Point(1087, 31);
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
            this.dtpFin.TabIndex = 64;
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
            this.dtpInicio.Location = new System.Drawing.Point(959, 31);
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
            this.dtpInicio.TabIndex = 61;
            // 
            // chkFiltroFecha
            // 
            // 
            // 
            // 
            this.chkFiltroFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFiltroFecha.Location = new System.Drawing.Point(748, 29);
            this.chkFiltroFecha.Name = "chkFiltroFecha";
            this.chkFiltroFecha.Size = new System.Drawing.Size(18, 23);
            this.chkFiltroFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFiltroFecha.TabIndex = 63;
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
            this.cboTipoFecha.Location = new System.Drawing.Point(772, 31);
            this.cboTipoFecha.Name = "cboTipoFecha";
            this.cboTipoFecha.Size = new System.Drawing.Size(186, 20);
            this.cboTipoFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoFecha.TabIndex = 62;
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
            this.cboMoneda.Location = new System.Drawing.Point(772, 10);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(186, 20);
            this.cboMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMoneda.TabIndex = 60;
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
            this.cboBanco.Location = new System.Drawing.Point(436, 31);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(238, 20);
            this.cboBanco.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBanco.TabIndex = 59;
            this.cboBanco.SelectedIndexChanged += new System.EventHandler(this.cboBanco_SelectedIndexChanged);
            // 
            // cboTipoEntidadFinanciera
            // 
            this.cboTipoEntidadFinanciera.DisplayMember = "Text";
            this.cboTipoEntidadFinanciera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoEntidadFinanciera.FormattingEnabled = true;
            this.cboTipoEntidadFinanciera.ItemHeight = 14;
            this.cboTipoEntidadFinanciera.Location = new System.Drawing.Point(436, 10);
            this.cboTipoEntidadFinanciera.Name = "cboTipoEntidadFinanciera";
            this.cboTipoEntidadFinanciera.Size = new System.Drawing.Size(238, 20);
            this.cboTipoEntidadFinanciera.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoEntidadFinanciera.TabIndex = 58;
            this.cboTipoEntidadFinanciera.SelectedIndexChanged += new System.EventHandler(this.cboTipoEntidadFinanciera_SelectedIndexChanged);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(696, 7);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(70, 23);
            this.labelX9.TabIndex = 57;
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
            this.labelX7.Location = new System.Drawing.Point(352, 31);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(78, 23);
            this.labelX7.TabIndex = 56;
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
            this.labelX6.Location = new System.Drawing.Point(339, 10);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(91, 23);
            this.labelX6.TabIndex = 55;
            this.labelX6.Text = "Tipo Financiera:";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // ucLoadingBar1
            // 
            this.ucLoadingBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadingBar1.Location = new System.Drawing.Point(1020, 397);
            this.ucLoadingBar1.Name = "ucLoadingBar1";
            this.ucLoadingBar1.Size = new System.Drawing.Size(167, 26);
            this.ucLoadingBar1.TabIndex = 26;
            // 
            // dgvInversion
            // 
            this.dgvInversion.AllowUserToAddRows = false;
            this.dgvInversion.AllowUserToDeleteRows = false;
            this.dgvInversion.AllowUserToResizeColumns = false;
            this.dgvInversion.AllowUserToResizeRows = false;
            this.dgvInversion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInversion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.TipoFinanciera,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column7,
            this.Column10,
            this.Column11,
            this.Column12});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInversion.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInversion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInversion.Location = new System.Drawing.Point(0, 117);
            this.dgvInversion.MultiSelect = false;
            this.dgvInversion.Name = "dgvInversion";
            this.dgvInversion.ReadOnly = true;
            this.dgvInversion.RowHeadersVisible = false;
            this.dgvInversion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInversion.Size = new System.Drawing.Size(1224, 274);
            this.dgvInversion.TabIndex = 27;
            this.dgvInversion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInversion_CellContentClick);
            this.dgvInversion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInversion_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idInversion";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nomTipoInversion";
            this.Column2.HeaderText = "Tipo de Inversión";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // TipoFinanciera
            // 
            this.TipoFinanciera.DataPropertyName = "nomTipoEntidadFinanciera";
            this.TipoFinanciera.HeaderText = "Tipo Financiera";
            this.TipoFinanciera.Name = "TipoFinanciera";
            this.TipoFinanciera.ReadOnly = true;
            this.TipoFinanciera.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nomEntidadFinanciera";
            this.Column3.HeaderText = "Banco";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 195;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nomMoneda";
            this.Column4.HeaderText = "Moneda";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "importe";
            this.Column5.HeaderText = "Importe";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tasa";
            this.Column6.HeaderText = "Tasa";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "fechaInicio";
            this.Column8.HeaderText = "Fec. Inicio";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 90;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "fechaVencimiento";
            this.Column9.HeaderText = "Fec. Vencimiento";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 120;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "nomEstado";
            this.Column7.HeaderText = "Estado";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "idEstado";
            this.Column10.HeaderText = "idEstado";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Anu";
            this.Column11.Image = ((System.Drawing.Image)(resources.GetObject("Column11.Image")));
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Text = null;
            this.Column11.Width = 30;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Ext";
            this.Column12.Image = ((System.Drawing.Image)(resources.GetObject("Column12.Image")));
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Text = null;
            this.Column12.Width = 30;
            // 
            // cboEstado
            // 
            this.cboEstado.DisplayMember = "Text";
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 14;
            this.cboEstado.Location = new System.Drawing.Point(1087, 10);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(125, 20);
            this.cboEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEstado.TabIndex = 70;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(1027, 7);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 23);
            this.labelX2.TabIndex = 69;
            this.labelX2.Text = "Estado:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // frmListaInversion
            // 
            this.ClientSize = new System.Drawing.Size(1225, 424);
            this.Controls.Add(this.dgvInversion);
            this.Controls.Add(this.ucLoadingBar1);
            this.Controls.Add(this.ucLoadingBar2);
            this.Controls.Add(this.ucMsgBox1);
            this.DoubleBuffered = true;
            this.Name = "frmListaInversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lista de Inversión";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmListaInversion_Load);
            this.Controls.SetChildIndex(this.ucMsgBox1, 0);
            this.Controls.SetChildIndex(this.toolBar, 0);
            this.Controls.SetChildIndex(this.pnlFiltro, 0);
            this.Controls.SetChildIndex(this.ucLoadingBar2, 0);
            this.Controls.SetChildIndex(this.ucLoadingBar1, 0);
            this.Controls.SetChildIndex(this.dgvInversion, 0);
            this.pnlFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInversion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsComponent.ucMsgBox ucMsgBox1;
        private ControlsComponent.ucLoadingBar ucLoadingBar2;
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
        private ControlsComponent.ucLoadingBar ucLoadingBar1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFinanciera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Column11;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Column12;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEstado;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}