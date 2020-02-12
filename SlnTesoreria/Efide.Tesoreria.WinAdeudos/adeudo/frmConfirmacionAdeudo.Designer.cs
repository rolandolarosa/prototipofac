namespace Efide.Tesoreria.WinAdeudos.adeudo
{
    partial class frmConfirmacionAdeudo
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
            this.components = new System.ComponentModel.Container();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtImporteInversion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtTasaInversion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboBanco = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboTipoInversion = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.ucLoadingBar1 = new Efide.ControlsComponent.ucLoadingBar();
            this.ucMsgBox1 = new Efide.ControlsComponent.ucMsgBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cboTipoEntidadFinanciera = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboPlazo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.dtFechaVencimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.dtFechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtImporteRescision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboPlazoRescision = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtObservaciones = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTasaRescision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.groupDetalle.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            // 
            // 
            // 
            this.txtBusqueda.Border.Class = "TextBoxBorder";
            this.txtBusqueda.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBusqueda.Location = new System.Drawing.Point(145, 15);
            this.txtBusqueda.MaxLength = 10;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(32, 15);
            this.labelX10.Text = "Código de Adeudo:";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(386, 9);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(438, 9);
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.Location = new System.Drawing.Point(12, 53);
            this.panelEx1.Size = new System.Drawing.Size(805, 50);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            // 
            // ribbonBar1
            // 
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.Size = new System.Drawing.Size(829, 39);
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSelTransDepo
            // 
            this.btnSelTransDepo.Location = new System.Drawing.Point(835, 53);
            this.btnSelTransDepo.Size = new System.Drawing.Size(47, 23);
            this.btnSelTransDepo.Text = "Seleccionar Transferencias";
            this.btnSelTransDepo.Visible = false;
            // 
            // groupDetalle
            // 
            this.groupDetalle.Controls.Add(this.dtFechaVencimiento);
            this.groupDetalle.Controls.Add(this.labelX18);
            this.groupDetalle.Controls.Add(this.dtFechaInicio);
            this.groupDetalle.Controls.Add(this.labelX17);
            this.groupDetalle.Controls.Add(this.cboPlazo);
            this.groupDetalle.Controls.Add(this.labelX16);
            this.groupDetalle.Controls.Add(this.cboTipoEntidadFinanciera);
            this.groupDetalle.Controls.Add(this.labelX5);
            this.groupDetalle.Controls.Add(this.txtImporteInversion);
            this.groupDetalle.Controls.Add(this.labelX8);
            this.groupDetalle.Controls.Add(this.txtTasaInversion);
            this.groupDetalle.Controls.Add(this.labelX3);
            this.groupDetalle.Controls.Add(this.cboMoneda);
            this.groupDetalle.Controls.Add(this.cboBanco);
            this.groupDetalle.Controls.Add(this.cboTipoInversion);
            this.groupDetalle.Controls.Add(this.labelX9);
            this.groupDetalle.Controls.Add(this.labelX7);
            this.groupDetalle.Controls.Add(this.labelX4);
            this.groupDetalle.Location = new System.Drawing.Point(12, 109);
            this.groupDetalle.Size = new System.Drawing.Size(805, 150);
            // 
            // 
            // 
            this.groupDetalle.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupDetalle.Style.BackColorGradientAngle = 90;
            this.groupDetalle.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupDetalle.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderBottomWidth = 1;
            this.groupDetalle.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupDetalle.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderLeftWidth = 1;
            this.groupDetalle.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderRightWidth = 1;
            this.groupDetalle.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderTopWidth = 1;
            this.groupDetalle.Style.CornerDiameter = 4;
            this.groupDetalle.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupDetalle.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupDetalle.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupDetalle.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupDetalle.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupDetalle.Text = "Datos de Adeudo";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.Controls.Add(this.groupPanel1);
            this.panelEx2.Controls.Add(this.ucMsgBox1);
            this.panelEx2.Controls.Add(this.ucLoadingBar1);
            this.panelEx2.Size = new System.Drawing.Size(829, 414);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(25, 11);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(95, 23);
            this.labelX6.TabIndex = 27;
            this.labelX6.Text = "Tipo de Inversión:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 23);
            this.labelX1.TabIndex = 41;
            this.labelX1.Text = "Código de Inversión: ";
            // 
            // txtImporteInversion
            // 
            // 
            // 
            // 
            this.txtImporteInversion.Border.Class = "TextBoxBorder";
            this.txtImporteInversion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtImporteInversion.Enabled = false;
            this.txtImporteInversion.Location = new System.Drawing.Point(551, 35);
            this.txtImporteInversion.MaxLength = 14;
            this.txtImporteInversion.Name = "txtImporteInversion";
            this.txtImporteInversion.Size = new System.Drawing.Size(238, 20);
            this.txtImporteInversion.TabIndex = 45;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(446, 33);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(99, 23);
            this.labelX8.TabIndex = 44;
            this.labelX8.Text = "Importe:";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtTasaInversion
            // 
            // 
            // 
            // 
            this.txtTasaInversion.Border.Class = "TextBoxBorder";
            this.txtTasaInversion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTasaInversion.Enabled = false;
            this.txtTasaInversion.Location = new System.Drawing.Point(551, 56);
            this.txtTasaInversion.MaxLength = 10;
            this.txtTasaInversion.Name = "txtTasaInversion";
            this.txtTasaInversion.Size = new System.Drawing.Size(238, 20);
            this.txtTasaInversion.TabIndex = 43;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(446, 53);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(99, 23);
            this.labelX3.TabIndex = 42;
            this.labelX3.Text = "Tasa:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboMoneda
            // 
            this.cboMoneda.DisplayMember = "Text";
            this.cboMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMoneda.Enabled = false;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.ItemHeight = 14;
            this.cboMoneda.Location = new System.Drawing.Point(551, 14);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(238, 20);
            this.cboMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMoneda.TabIndex = 41;
            // 
            // cboBanco
            // 
            this.cboBanco.DisplayMember = "Text";
            this.cboBanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBanco.Enabled = false;
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.ItemHeight = 14;
            this.cboBanco.Location = new System.Drawing.Point(142, 56);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(238, 20);
            this.cboBanco.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBanco.TabIndex = 40;
            // 
            // cboTipoInversion
            // 
            this.cboTipoInversion.DisplayMember = "Text";
            this.cboTipoInversion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoInversion.Enabled = false;
            this.cboTipoInversion.FormattingEnabled = true;
            this.cboTipoInversion.ItemHeight = 14;
            this.cboTipoInversion.Location = new System.Drawing.Point(142, 14);
            this.cboTipoInversion.Name = "cboTipoInversion";
            this.cboTipoInversion.Size = new System.Drawing.Size(238, 20);
            this.cboTipoInversion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoInversion.TabIndex = 39;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(450, 14);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(95, 23);
            this.labelX9.TabIndex = 38;
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
            this.labelX7.Location = new System.Drawing.Point(41, 54);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(95, 23);
            this.labelX7.TabIndex = 37;
            this.labelX7.Text = "Banco:";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(41, 11);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(95, 23);
            this.labelX4.TabIndex = 36;
            this.labelX4.Text = "Tipo de Adeudo:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // ucLoadingBar1
            // 
            this.ucLoadingBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadingBar1.Location = new System.Drawing.Point(650, 382);
            this.ucLoadingBar1.Name = "ucLoadingBar1";
            this.ucLoadingBar1.Size = new System.Drawing.Size(167, 26);
            this.ucLoadingBar1.TabIndex = 0;
            // 
            // ucMsgBox1
            // 
            this.ucMsgBox1.Location = new System.Drawing.Point(12, 479);
            this.ucMsgBox1.Name = "ucMsgBox1";
            this.ucMsgBox1.Size = new System.Drawing.Size(10, 10);
            this.ucMsgBox1.TabIndex = 1;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(14, 33);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(122, 23);
            this.labelX5.TabIndex = 48;
            this.labelX5.Text = "Tipo Entidad Financera:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboTipoEntidadFinanciera
            // 
            this.cboTipoEntidadFinanciera.DisplayMember = "Text";
            this.cboTipoEntidadFinanciera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoEntidadFinanciera.Enabled = false;
            this.cboTipoEntidadFinanciera.FormattingEnabled = true;
            this.cboTipoEntidadFinanciera.ItemHeight = 14;
            this.cboTipoEntidadFinanciera.Location = new System.Drawing.Point(142, 35);
            this.cboTipoEntidadFinanciera.Name = "cboTipoEntidadFinanciera";
            this.cboTipoEntidadFinanciera.Size = new System.Drawing.Size(238, 20);
            this.cboTipoEntidadFinanciera.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoEntidadFinanciera.TabIndex = 49;
            this.cboTipoEntidadFinanciera.SelectedIndexChanged += new System.EventHandler(this.cboTipoEntidadFinanciera_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cboPlazo
            // 
            this.cboPlazo.DisplayMember = "Text";
            this.cboPlazo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPlazo.Enabled = false;
            this.cboPlazo.FormattingEnabled = true;
            this.cboPlazo.ItemHeight = 14;
            this.cboPlazo.Location = new System.Drawing.Point(551, 77);
            this.cboPlazo.Name = "cboPlazo";
            this.cboPlazo.Size = new System.Drawing.Size(238, 20);
            this.cboPlazo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboPlazo.TabIndex = 50;
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(429, 75);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(115, 23);
            this.labelX16.TabIndex = 51;
            this.labelX16.Text = "Plazo:";
            this.labelX16.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dtFechaVencimiento
            // 
            // 
            // 
            // 
            this.dtFechaVencimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaVencimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaVencimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaVencimiento.ButtonDropDown.Visible = true;
            this.dtFechaVencimiento.Enabled = false;
            this.dtFechaVencimiento.IsPopupCalendarOpen = false;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(551, 98);
            // 
            // 
            // 
            this.dtFechaVencimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaVencimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaVencimiento.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaVencimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaVencimiento.MonthCalendar.DisplayMonth = new System.DateTime(2018, 8, 1, 0, 0, 0, 0);
            this.dtFechaVencimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaVencimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaVencimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaVencimiento.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaVencimiento.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Size = new System.Drawing.Size(238, 20);
            this.dtFechaVencimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaVencimiento.TabIndex = 53;
            this.dtFechaVencimiento.Tag = "Reqrired, Fecha";
            // 
            // labelX18
            // 
            this.labelX18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Location = new System.Drawing.Point(419, 95);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(125, 23);
            this.labelX18.TabIndex = 55;
            this.labelX18.Text = "Fecha Vencimiento:";
            this.labelX18.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dtFechaInicio
            // 
            // 
            // 
            // 
            this.dtFechaInicio.BackgroundStyle.BorderBottomWidth = 1;
            this.dtFechaInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaInicio.ButtonDropDown.Visible = true;
            this.dtFechaInicio.Enabled = false;
            this.dtFechaInicio.IsPopupCalendarOpen = false;
            this.dtFechaInicio.Location = new System.Drawing.Point(142, 98);
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaInicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.DisplayMonth = new System.DateTime(2018, 8, 1, 0, 0, 0, 0);
            this.dtFechaInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaInicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(238, 20);
            this.dtFechaInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaInicio.TabIndex = 52;
            this.dtFechaInicio.Tag = "Reqrired, Fecha";
            // 
            // labelX17
            // 
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(20, 96);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(115, 23);
            this.labelX17.TabIndex = 54;
            this.labelX17.Text = "Fecha Inicio:";
            this.labelX17.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtImporteRescision);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.cboPlazoRescision);
            this.groupPanel1.Controls.Add(this.txtObservaciones);
            this.groupPanel1.Controls.Add(this.txtTasaRescision);
            this.groupPanel1.Controls.Add(this.labelX14);
            this.groupPanel1.Controls.Add(this.labelX13);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.Location = new System.Drawing.Point(12, 265);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(805, 113);
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
            this.groupPanel1.TabIndex = 48;
            this.groupPanel1.Text = "Datos de Adeudo";
            // 
            // txtImporteRescision
            // 
            // 
            // 
            // 
            this.txtImporteRescision.Border.Class = "TextBoxBorder";
            this.txtImporteRescision.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtImporteRescision.Enabled = false;
            this.txtImporteRescision.Location = new System.Drawing.Point(142, 59);
            this.txtImporteRescision.MaxLength = 14;
            this.txtImporteRescision.Name = "txtImporteRescision";
            this.txtImporteRescision.Size = new System.Drawing.Size(238, 20);
            this.txtImporteRescision.TabIndex = 49;
            this.txtImporteRescision.Tag = "Reqrired, Decimales";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(37, 57);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(99, 23);
            this.labelX2.TabIndex = 48;
            this.labelX2.Text = "Importe Rescision:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboPlazoRescision
            // 
            this.cboPlazoRescision.DisplayMember = "Text";
            this.cboPlazoRescision.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPlazoRescision.Enabled = false;
            this.cboPlazoRescision.FormattingEnabled = true;
            this.cboPlazoRescision.ItemHeight = 14;
            this.cboPlazoRescision.Location = new System.Drawing.Point(142, 38);
            this.cboPlazoRescision.Name = "cboPlazoRescision";
            this.cboPlazoRescision.Size = new System.Drawing.Size(238, 20);
            this.cboPlazoRescision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboPlazoRescision.TabIndex = 13;
            // 
            // txtObservaciones
            // 
            // 
            // 
            // 
            this.txtObservaciones.Border.Class = "TextBoxBorder";
            this.txtObservaciones.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Location = new System.Drawing.Point(551, 17);
            this.txtObservaciones.MaxLength = 250;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(238, 62);
            this.txtObservaciones.TabIndex = 14;
            // 
            // txtTasaRescision
            // 
            // 
            // 
            // 
            this.txtTasaRescision.Border.Class = "TextBoxBorder";
            this.txtTasaRescision.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTasaRescision.Enabled = false;
            this.txtTasaRescision.Location = new System.Drawing.Point(142, 17);
            this.txtTasaRescision.MaxLength = 10;
            this.txtTasaRescision.Name = "txtTasaRescision";
            this.txtTasaRescision.Size = new System.Drawing.Size(238, 20);
            this.txtTasaRescision.TabIndex = 12;
            this.txtTasaRescision.Tag = "Reqrired, Decimales";
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(421, 17);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(122, 23);
            this.labelX14.TabIndex = 20;
            this.labelX14.Text = "Observaciones:";
            this.labelX14.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(26, 35);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(108, 23);
            this.labelX13.TabIndex = 19;
            this.labelX13.Text = "Plazo mínimo:";
            this.labelX13.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(12, 14);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(122, 23);
            this.labelX11.TabIndex = 18;
            this.labelX11.Text = "Tasa de Rescisión:";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // frmConfirmacionAdeudo
            // 
            this.ClientSize = new System.Drawing.Size(829, 414);
            this.DoubleBuffered = true;
            this.Name = "frmConfirmacionAdeudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Confirmación Adeudo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmConfirmacionAdeudo_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupDetalle.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtImporteInversion;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTasaInversion;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMoneda;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBanco;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoInversion;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX4;
        private ControlsComponent.ucLoadingBar ucLoadingBar1;
        private ControlsComponent.ucMsgBox ucMsgBox1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoEntidadFinanciera;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboPlazo;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaVencimiento;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaInicio;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtImporteRescision;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboPlazoRescision;
        private DevComponents.DotNetBar.Controls.TextBoxX txtObservaciones;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTasaRescision;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX11;
    }
}