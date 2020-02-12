namespace Efide.Tesoreria.WinAdeudos.busqueda
{
    partial class frmBusquedaTransfDepo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTransferencia = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column12 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socioBancoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCuentasBancarias = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx4 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtNroOperacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboMovimiento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInput2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cboDestino = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cboIdentificacion = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ucLoadingBar1 = new Efide.ControlsComponent.ucLoadingBar();
            this.ucMsgBox1 = new Efide.ControlsComponent.ucMsgBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.labelX4);
            this.pnlFiltro.Controls.Add(this.cboDestino);
            this.pnlFiltro.Controls.Add(this.labelX5);
            this.pnlFiltro.Controls.Add(this.cboIdentificacion);
            this.pnlFiltro.Controls.Add(this.labelX2);
            this.pnlFiltro.Controls.Add(this.dateTimeInput2);
            this.pnlFiltro.Controls.Add(this.dateTimeInput1);
            this.pnlFiltro.Controls.Add(this.cboMovimiento);
            this.pnlFiltro.Controls.Add(this.txtNroOperacion);
            this.pnlFiltro.Controls.Add(this.labelX1);
            this.pnlFiltro.Controls.Add(this.checkBoxX1);
            this.pnlFiltro.Controls.Add(this.comboBoxEx4);
            this.pnlFiltro.Controls.Add(this.cboCuentasBancarias);
            this.pnlFiltro.Controls.Add(this.labelX7);
            this.pnlFiltro.Location = new System.Drawing.Point(8, 45);
            this.pnlFiltro.Size = new System.Drawing.Size(1290, 64);
            this.pnlFiltro.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlFiltro.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlFiltro.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlFiltro.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlFiltro.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlFiltro.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlFiltro.Style.GradientAngle = 90;
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
            this.toolBar.Size = new System.Drawing.Size(1306, 39);
            // 
            // 
            // 
            this.toolBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvTransferencia
            // 
            this.dgvTransferencia.AllowUserToAddRows = false;
            this.dgvTransferencia.AllowUserToDeleteRows = false;
            this.dgvTransferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column13,
            this.socioBancoID});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransferencia.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTransferencia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTransferencia.Location = new System.Drawing.Point(8, 115);
            this.dgvTransferencia.MultiSelect = false;
            this.dgvTransferencia.Name = "dgvTransferencia";
            this.dgvTransferencia.RowHeadersVisible = false;
            this.dgvTransferencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransferencia.Size = new System.Drawing.Size(1290, 256);
            this.dgvTransferencia.TabIndex = 23;
            // 
            // Column12
            // 
            this.Column12.Checked = true;
            this.Column12.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Column12.CheckValue = "N";
            this.Column12.HeaderText = "Sel";
            this.Column12.Name = "Column12";
            this.Column12.Width = 30;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ctasBanNumCta";
            this.Column1.HeaderText = "N° cuenta bancaria";
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ent_emprRazonSocial";
            this.Column2.HeaderText = "Entidad Financiera";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tipoMoneda";
            this.Column3.HeaderText = "Moneda";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sbFechaOperacion";
            this.Column4.HeaderText = "Fecha";
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sbNumOperacion";
            this.Column5.HeaderText = "N° ope";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tipoOperacion";
            this.Column6.HeaderText = "Tipo";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tipollamada";
            this.Column7.HeaderText = "Identificación";
            this.Column7.Name = "Column7";
            this.Column7.Width = 90;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "pagar_nombreCompleto";
            this.Column8.HeaderText = "Tercero";
            this.Column8.Name = "Column8";
            this.Column8.Width = 130;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "soc_razonSocial";
            this.Column9.HeaderText = "Socio";
            this.Column9.Name = "Column9";
            this.Column9.Width = 130;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "sbImporte";
            this.Column10.HeaderText = "Importe";
            this.Column10.Name = "Column10";
            this.Column10.Width = 90;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Saldo";
            this.Column11.HeaderText = "Saldo Dis.";
            this.Column11.Name = "Column11";
            this.Column11.Width = 90;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "TipoDestino";
            this.Column13.HeaderText = "Destino";
            this.Column13.Name = "Column13";
            // 
            // socioBancoID
            // 
            this.socioBancoID.DataPropertyName = "socioBancoID";
            this.socioBancoID.HeaderText = "socioBancoID";
            this.socioBancoID.Name = "socioBancoID";
            this.socioBancoID.Visible = false;
            // 
            // cboCuentasBancarias
            // 
            this.cboCuentasBancarias.DisplayMember = "Text";
            this.cboCuentasBancarias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCuentasBancarias.FormattingEnabled = true;
            this.cboCuentasBancarias.ItemHeight = 14;
            this.cboCuentasBancarias.Location = new System.Drawing.Point(79, 12);
            this.cboCuentasBancarias.Name = "cboCuentasBancarias";
            this.cboCuentasBancarias.Size = new System.Drawing.Size(580, 20);
            this.cboCuentasBancarias.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboCuentasBancarias.TabIndex = 30;
            this.cboCuentasBancarias.SelectedIndexChanged += new System.EventHandler(this.cboCuentasBancarias_SelectedIndexChanged);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(32, 12);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(41, 23);
            this.labelX7.TabIndex = 29;
            this.labelX7.Text = "Cuenta:";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // comboBoxEx4
            // 
            this.comboBoxEx4.DisplayMember = "Text";
            this.comboBoxEx4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx4.FormattingEnabled = true;
            this.comboBoxEx4.ItemHeight = 14;
            this.comboBoxEx4.Location = new System.Drawing.Point(79, 33);
            this.comboBoxEx4.Name = "comboBoxEx4";
            this.comboBoxEx4.Size = new System.Drawing.Size(150, 20);
            this.comboBoxEx4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx4.TabIndex = 41;
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Location = new System.Drawing.Point(55, 35);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(18, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 42;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(471, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(48, 23);
            this.labelX1.TabIndex = 43;
            this.labelX1.Text = "N° Ope:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtNroOperacion
            // 
            // 
            // 
            // 
            this.txtNroOperacion.Border.Class = "TextBoxBorder";
            this.txtNroOperacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNroOperacion.Location = new System.Drawing.Point(522, 33);
            this.txtNroOperacion.MaxLength = 20;
            this.txtNroOperacion.Name = "txtNroOperacion";
            this.txtNroOperacion.Size = new System.Drawing.Size(137, 20);
            this.txtNroOperacion.TabIndex = 44;
            // 
            // cboMovimiento
            // 
            this.cboMovimiento.DisplayMember = "Text";
            this.cboMovimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMovimiento.FormattingEnabled = true;
            this.cboMovimiento.ItemHeight = 14;
            this.cboMovimiento.Location = new System.Drawing.Point(813, 12);
            this.cboMovimiento.Name = "cboMovimiento";
            this.cboMovimiento.Size = new System.Drawing.Size(158, 20);
            this.cboMovimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMovimiento.TabIndex = 45;
            this.cboMovimiento.SelectedIndexChanged += new System.EventHandler(this.cboMovimiento_SelectedIndexChanged);
            // 
            // dateTimeInput1
            // 
            // 
            // 
            // 
            this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput1.ButtonDropDown.Visible = true;
            this.dateTimeInput1.IsPopupCalendarOpen = false;
            this.dateTimeInput1.Location = new System.Drawing.Point(230, 33);
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInput1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2018, 8, 1, 0, 0, 0, 0);
            this.dateTimeInput1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(112, 20);
            this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput1.TabIndex = 24;
            // 
            // dateTimeInput2
            // 
            // 
            // 
            // 
            this.dateTimeInput2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput2.ButtonDropDown.Visible = true;
            this.dateTimeInput2.IsPopupCalendarOpen = false;
            this.dateTimeInput2.Location = new System.Drawing.Point(342, 33);
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInput2.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.DisplayMonth = new System.DateTime(2018, 8, 1, 0, 0, 0, 0);
            this.dateTimeInput2.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput2.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput2.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput2.Name = "dateTimeInput2";
            this.dateTimeInput2.Size = new System.Drawing.Size(112, 20);
            this.dateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput2.TabIndex = 46;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(740, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(67, 23);
            this.labelX2.TabIndex = 47;
            this.labelX2.Text = "Movimiento:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(1030, 34);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 53;
            this.labelX4.Text = "Destino:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboDestino
            // 
            this.cboDestino.DisplayMember = "Text";
            this.cboDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.ItemHeight = 14;
            this.cboDestino.Location = new System.Drawing.Point(1119, 34);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(150, 20);
            this.cboDestino.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboDestino.TabIndex = 52;
            this.cboDestino.SelectedIndexChanged += new System.EventHandler(this.cboDestino_SelectedIndexChanged);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(1030, 13);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 51;
            this.labelX5.Text = "Identificación:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboIdentificacion
            // 
            this.cboIdentificacion.DisplayMember = "Text";
            this.cboIdentificacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdentificacion.FormattingEnabled = true;
            this.cboIdentificacion.ItemHeight = 14;
            this.cboIdentificacion.Location = new System.Drawing.Point(1119, 13);
            this.cboIdentificacion.Name = "cboIdentificacion";
            this.cboIdentificacion.Size = new System.Drawing.Size(150, 20);
            this.cboIdentificacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdentificacion.TabIndex = 50;
            this.cboIdentificacion.SelectedIndexChanged += new System.EventHandler(this.cboIdentificacion_SelectedIndexChanged);
            // 
            // ucLoadingBar1
            // 
            this.ucLoadingBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadingBar1.Location = new System.Drawing.Point(1131, 377);
            this.ucLoadingBar1.Name = "ucLoadingBar1";
            this.ucLoadingBar1.Size = new System.Drawing.Size(165, 26);
            this.ucLoadingBar1.TabIndex = 25;
            // 
            // ucMsgBox1
            // 
            this.ucMsgBox1.Location = new System.Drawing.Point(0, 380);
            this.ucMsgBox1.Name = "ucMsgBox1";
            this.ucMsgBox1.Size = new System.Drawing.Size(10, 10);
            this.ucMsgBox1.TabIndex = 26;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1306, 408);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 27;
            // 
            // frmBusquedaTransfDepo
            // 
            this.ClientSize = new System.Drawing.Size(1306, 408);
            this.Controls.Add(this.ucMsgBox1);
            this.Controls.Add(this.ucLoadingBar1);
            this.Controls.Add(this.dgvTransferencia);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "frmBusquedaTransfDepo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Búsqueda de Transferencia / Depósito";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmBusquedaTransfDepo_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            this.Controls.SetChildIndex(this.pnlFiltro, 0);
            this.Controls.SetChildIndex(this.toolBar, 0);
            this.Controls.SetChildIndex(this.dgvTransferencia, 0);
            this.Controls.SetChildIndex(this.ucLoadingBar1, 0);
            this.Controls.SetChildIndex(this.ucMsgBox1, 0);
            this.pnlFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTransferencia;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboCuentasBancarias;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx4;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNroOperacion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMovimiento;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboDestino;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdentificacion;
        private ControlsComponent.ucLoadingBar ucLoadingBar1;
        private ControlsComponent.ucMsgBox ucMsgBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioBancoID;
        private DevComponents.DotNetBar.PanelEx panelEx1;
    }
}