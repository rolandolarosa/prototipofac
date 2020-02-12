namespace EfideFactoring.Formula.Registros
{
    partial class frmMntLineasAutorizadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLineasAutorizadas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dtInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnExcel = new DevComponents.DotNetBar.ButtonX();
            this.IdLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoLinea_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoLinea_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCodigoAnexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTransito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUtilizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPorUsoLin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRiesgoUnico_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRiesgoUnico_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineasAutorizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin)).BeginInit();
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
            this.PanelEx1.Controls.Add(this.btnExcel);
            this.PanelEx1.Controls.Add(this.dtFin);
            this.PanelEx1.Controls.Add(this.labelX6);
            this.PanelEx1.Controls.Add(this.dtInicio);
            this.PanelEx1.Controls.Add(this.labelX5);
            this.PanelEx1.Size = new System.Drawing.Size(1146, 54);
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
            this.PanelEx1.Controls.SetChildIndex(this.labelX5, 0);
            this.PanelEx1.Controls.SetChildIndex(this.dtInicio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX6, 0);
            this.PanelEx1.Controls.SetChildIndex(this.dtFin, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnExcel, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(877, 5);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(798, 5);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(60, 16);
            this.TextBoxX1.Size = new System.Drawing.Size(299, 20);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Size = new System.Drawing.Size(96, 23);
            this.LabelX1.Text = "Socio";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Text = "Líneas Autorizadas";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(970, 97);
            // 
            // dgvLineasAutorizadas
            // 
            this.dgvLineasAutorizadas.AllowUserToAddRows = false;
            this.dgvLineasAutorizadas.AllowUserToDeleteRows = false;
            this.dgvLineasAutorizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLineasAutorizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineasAutorizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLinea,
            this.IdSocio,
            this.IdSocio_Dsc,
            this.IdTipoLinea_tt,
            this.IdTipoLinea_tt_Dsc,
            this.dtRegistro,
            this.dtVencimiento,
            this.vCodigoAnexo,
            this.IdMoneda_tt,
            this.IdMoneda_tt_Dsc,
            this.nImporte,
            this.nTransito,
            this.nUtilizado,
            this.Saldo,
            this.nPorUsoLin,
            this.IdRiesgoUnico_tt,
            this.IdRiesgoUnico_tt_Dsc});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLineasAutorizadas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLineasAutorizadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLineasAutorizadas.Location = new System.Drawing.Point(0, 125);
            this.dgvLineasAutorizadas.Name = "dgvLineasAutorizadas";
            this.dgvLineasAutorizadas.ReadOnly = true;
            this.dgvLineasAutorizadas.RowHeadersWidth = 10;
            this.dgvLineasAutorizadas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLineasAutorizadas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLineasAutorizadas.Size = new System.Drawing.Size(1146, 279);
            this.dgvLineasAutorizadas.TabIndex = 22;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(630, 98);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(110, 23);
            this.labelX3.TabIndex = 41;
            this.labelX3.Text = "Menor 75%";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(528, 98);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(60, 23);
            this.labelX2.TabIndex = 40;
            this.labelX2.Text = "Mayor 75% ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(598, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(497, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 38;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX4.Location = new System.Drawing.Point(350, 98);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(133, 23);
            this.labelX4.TabIndex = 42;
            this.labelX4.Text = "Uso de Línea de Crédito : ";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX5.Location = new System.Drawing.Point(394, 12);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "Fecha Inicio";
            // 
            // dtInicio
            // 
            // 
            // 
            // 
            this.dtInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtInicio.ButtonDropDown.Visible = true;
            this.dtInicio.IsPopupCalendarOpen = false;
            this.dtInicio.Location = new System.Drawing.Point(465, 15);
            // 
            // 
            // 
            this.dtInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtInicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInicio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtInicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtInicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtInicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtInicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtInicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInicio.MonthCalendar.DisplayMonth = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            this.dtInicio.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInicio.MonthCalendar.TodayButtonVisible = true;
            this.dtInicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(86, 20);
            this.dtInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtInicio.TabIndex = 8;
            // 
            // dtFin
            // 
            // 
            // 
            // 
            this.dtFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFin.ButtonDropDown.Visible = true;
            this.dtFin.IsPopupCalendarOpen = false;
            this.dtFin.Location = new System.Drawing.Point(654, 16);
            // 
            // 
            // 
            this.dtFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFin.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFin.MonthCalendar.DisplayMonth = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            this.dtFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFin.MonthCalendar.TodayButtonVisible = true;
            this.dtFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(86, 20);
            this.dtFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFin.TabIndex = 10;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX6.Location = new System.Drawing.Point(583, 13);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 9;
            this.labelX6.Text = "Fecha Fin";
            // 
            // btnExcel
            // 
            this.btnExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExcel.Image = global::EfideFactoring.Properties.Resources.excel_2013;
            this.btnExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExcel.Location = new System.Drawing.Point(956, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(73, 44);
            this.btnExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // IdLinea
            // 
            this.IdLinea.DataPropertyName = "IdLinea";
            this.IdLinea.HeaderText = "Línea";
            this.IdLinea.Name = "IdLinea";
            this.IdLinea.ReadOnly = true;
            this.IdLinea.Width = 80;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Visible = false;
            this.IdSocio.Width = 1601;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 160;
            // 
            // IdTipoLinea_tt
            // 
            this.IdTipoLinea_tt.DataPropertyName = "IdTipoLinea_tt";
            this.IdTipoLinea_tt.HeaderText = "IdTipoLinea_tt";
            this.IdTipoLinea_tt.Name = "IdTipoLinea_tt";
            this.IdTipoLinea_tt.ReadOnly = true;
            this.IdTipoLinea_tt.Visible = false;
            // 
            // IdTipoLinea_tt_Dsc
            // 
            this.IdTipoLinea_tt_Dsc.DataPropertyName = "IdTipoLinea_tt_Dsc";
            this.IdTipoLinea_tt_Dsc.HeaderText = "Tipo de Línea";
            this.IdTipoLinea_tt_Dsc.Name = "IdTipoLinea_tt_Dsc";
            this.IdTipoLinea_tt_Dsc.ReadOnly = true;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dtRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtRegistro.HeaderText = "Fecha de Registro";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            this.dtRegistro.Width = 80;
            // 
            // dtVencimiento
            // 
            this.dtVencimiento.DataPropertyName = "dtVencimiento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dtVencimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtVencimiento.HeaderText = "Fecha de Vencimiento";
            this.dtVencimiento.Name = "dtVencimiento";
            this.dtVencimiento.ReadOnly = true;
            this.dtVencimiento.Width = 80;
            // 
            // vCodigoAnexo
            // 
            this.vCodigoAnexo.DataPropertyName = "vCodigoAnexo";
            this.vCodigoAnexo.HeaderText = "Nro. Contrato";
            this.vCodigoAnexo.Name = "vCodigoAnexo";
            this.vCodigoAnexo.ReadOnly = true;
            this.vCodigoAnexo.Visible = false;
            this.vCodigoAnexo.Width = 80;
            // 
            // IdMoneda_tt
            // 
            this.IdMoneda_tt.DataPropertyName = "IdMoneda_tt";
            this.IdMoneda_tt.HeaderText = "IdMoneda_tt";
            this.IdMoneda_tt.Name = "IdMoneda_tt";
            this.IdMoneda_tt.ReadOnly = true;
            this.IdMoneda_tt.Visible = false;
            this.IdMoneda_tt.Width = 92;
            // 
            // IdMoneda_tt_Dsc
            // 
            this.IdMoneda_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.HeaderText = "Moneda";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            this.IdMoneda_tt_Dsc.Width = 80;
            // 
            // nImporte
            // 
            this.nImporte.DataPropertyName = "nImporte";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.nImporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.nImporte.HeaderText = "Importe";
            this.nImporte.Name = "nImporte";
            this.nImporte.ReadOnly = true;
            this.nImporte.Width = 80;
            // 
            // nTransito
            // 
            this.nTransito.DataPropertyName = "nTransito";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.nTransito.DefaultCellStyle = dataGridViewCellStyle4;
            this.nTransito.HeaderText = "Transito";
            this.nTransito.Name = "nTransito";
            this.nTransito.ReadOnly = true;
            // 
            // nUtilizado
            // 
            this.nUtilizado.DataPropertyName = "nUtilizado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.nUtilizado.DefaultCellStyle = dataGridViewCellStyle5;
            this.nUtilizado.HeaderText = "Utilizado";
            this.nUtilizado.Name = "nUtilizado";
            this.nUtilizado.ReadOnly = true;
            this.nUtilizado.Width = 80;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle6;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // nPorUsoLin
            // 
            this.nPorUsoLin.DataPropertyName = "nPorUsoLin";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nPorUsoLin.DefaultCellStyle = dataGridViewCellStyle7;
            this.nPorUsoLin.HeaderText = "% Uso Linea";
            this.nPorUsoLin.Name = "nPorUsoLin";
            this.nPorUsoLin.ReadOnly = true;
            this.nPorUsoLin.Width = 70;
            // 
            // IdRiesgoUnico_tt
            // 
            this.IdRiesgoUnico_tt.DataPropertyName = "IdRiesgoUnico_tt";
            this.IdRiesgoUnico_tt.HeaderText = "IdRiesgoUnico_tt";
            this.IdRiesgoUnico_tt.Name = "IdRiesgoUnico_tt";
            this.IdRiesgoUnico_tt.ReadOnly = true;
            this.IdRiesgoUnico_tt.Visible = false;
            // 
            // IdRiesgoUnico_tt_Dsc
            // 
            this.IdRiesgoUnico_tt_Dsc.DataPropertyName = "IdRiesgoUnico_tt_Dsc";
            this.IdRiesgoUnico_tt_Dsc.HeaderText = "Riesgo Unico";
            this.IdRiesgoUnico_tt_Dsc.Name = "IdRiesgoUnico_tt_Dsc";
            this.IdRiesgoUnico_tt_Dsc.ReadOnly = true;
            this.IdRiesgoUnico_tt_Dsc.Width = 120;
            // 
            // frmMntLineasAutorizadas
            // 
            this.ClientSize = new System.Drawing.Size(1146, 416);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLineasAutorizadas);
            this.DoubleBuffered = true;
            this.Name = "frmMntLineasAutorizadas";
            this.Text = "Lineas Autorizadas";
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvLineasAutorizadas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineasAutorizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLineasAutorizadas;
        protected DevComponents.DotNetBar.LabelX labelX3;
        protected DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFin;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtInicio;
        private DevComponents.DotNetBar.LabelX labelX5;
        protected DevComponents.DotNetBar.ButtonX btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoLinea_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoLinea_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCodigoAnexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTransito;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUtilizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPorUsoLin;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRiesgoUnico_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRiesgoUnico_tt_Dsc;
    }
}