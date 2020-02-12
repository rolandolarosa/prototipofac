namespace EfideFactoring.Formula.Registros
{
    partial class frmLoteAprobacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnAprobacion = new DevComponents.DotNetBar.ButtonItem();
            this.btnExtornar = new DevComponents.DotNetBar.ButtonItem();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.lblGrilla = new DevComponents.DotNetBar.LabelX();
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cboIdEstado_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dtFechaRegistro = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvLote = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CheckSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdDesembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdAprobacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nValorNegociable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDesembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITransito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLiquidacion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonBar1
            // 
            this.RibbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar1.ContainerControlProcessDialogKey = true;
            this.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.RibbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAprobacion,
            this.btnExtornar,
            this.btnSalir});
            this.RibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.RibbonBar1.Name = "RibbonBar1";
            this.RibbonBar1.Size = new System.Drawing.Size(899, 34);
            this.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.RibbonBar1.TabIndex = 41;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnAprobacion
            // 
            this.btnAprobacion.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAprobacion.Image = global::EfideFactoring.Properties.Resources.btn_ok;
            this.btnAprobacion.Name = "btnAprobacion";
            this.btnAprobacion.SubItemsExpandWidth = 14;
            this.btnAprobacion.Text = "Aprobación";
            this.btnAprobacion.Click += new System.EventHandler(this.btnAprobacion_Click);
            // 
            // btnExtornar
            // 
            this.btnExtornar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExtornar.Image = global::EfideFactoring.Properties.Resources.elimina;
            this.btnExtornar.Name = "btnExtornar";
            this.btnExtornar.SubItemsExpandWidth = 14;
            this.btnExtornar.Text = "Extornar";
            this.btnExtornar.Click += new System.EventHandler(this.btnExtornar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSalir.Image = global::EfideFactoring.Properties.Resources.cerrar;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.SubItemsExpandWidth = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrilla.Location = new System.Drawing.Point(2, 86);
            this.lblGrilla.Name = "lblGrilla";
            this.lblGrilla.Size = new System.Drawing.Size(108, 23);
            this.lblGrilla.TabIndex = 47;
            this.lblGrilla.Text = "Lotes";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistros.Location = new System.Drawing.Point(723, 86);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(176, 22);
            this.lblRegistros.TabIndex = 46;
            this.lblRegistros.Text = "0  registro(s)";
            this.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // PanelEx1
            // 
            this.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.PanelEx1.Controls.Add(this.cboIdEstado_tt);
            this.PanelEx1.Controls.Add(this.labelX2);
            this.PanelEx1.Controls.Add(this.dtFechaRegistro);
            this.PanelEx1.Controls.Add(this.btnLimpiar);
            this.PanelEx1.Controls.Add(this.btnBuscar);
            this.PanelEx1.Controls.Add(this.LabelX1);
            this.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx1.Location = new System.Drawing.Point(0, 34);
            this.PanelEx1.Name = "PanelEx1";
            this.PanelEx1.Size = new System.Drawing.Size(899, 54);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.TabIndex = 45;
            // 
            // cboIdEstado_tt
            // 
            this.cboIdEstado_tt.DisplayMember = "Text";
            this.cboIdEstado_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdEstado_tt.FormattingEnabled = true;
            this.cboIdEstado_tt.ItemHeight = 14;
            this.cboIdEstado_tt.Location = new System.Drawing.Point(296, 15);
            this.cboIdEstado_tt.Name = "cboIdEstado_tt";
            this.cboIdEstado_tt.Size = new System.Drawing.Size(162, 20);
            this.cboIdEstado_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdEstado_tt.TabIndex = 9;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(230, 15);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(59, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Estado";
            // 
            // dtFechaRegistro
            // 
            // 
            // 
            // 
            this.dtFechaRegistro.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaRegistro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaRegistro.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaRegistro.ButtonDropDown.Visible = true;
            this.dtFechaRegistro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaRegistro.IsPopupCalendarOpen = false;
            this.dtFechaRegistro.Location = new System.Drawing.Point(64, 15);
            // 
            // 
            // 
            this.dtFechaRegistro.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaRegistro.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaRegistro.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaRegistro.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaRegistro.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaRegistro.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaRegistro.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaRegistro.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaRegistro.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaRegistro.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaRegistro.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaRegistro.MonthCalendar.DisplayMonth = new System.DateTime(2014, 10, 1, 0, 0, 0, 0);
            this.dtFechaRegistro.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaRegistro.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaRegistro.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaRegistro.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaRegistro.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaRegistro.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaRegistro.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaRegistro.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaRegistro.Name = "dtFechaRegistro";
            this.dtFechaRegistro.Size = new System.Drawing.Size(108, 20);
            this.dtFechaRegistro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaRegistro.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(581, 7);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 44);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = global::EfideFactoring.Properties.Resources.buscar;
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(502, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 44);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelX1.Location = new System.Drawing.Point(21, 12);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(59, 23);
            this.LabelX1.TabIndex = 0;
            this.LabelX1.Text = "Fecha";
            // 
            // dgvLote
            // 
            this.dgvLote.AllowUserToAddRows = false;
            this.dgvLote.AllowUserToDeleteRows = false;
            this.dgvLote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSel,
            this.IdLote,
            this.IdSocio,
            this.IdSocio_Dsc,
            this.sdDesembolso,
            this.IdMoneda_tt,
            this.sdAprobacion,
            this.NLinea,
            this.FechaVencimiento,
            this.Moneda,
            this.Importe,
            this.nValorNegociable,
            this.nDesembolso,
            this.Saldo,
            this.ITransito,
            this.SaldoDisponible,
            this.IdEstado_tt_Dsc,
            this.IdEstado_tt,
            this.btnLiquidacion});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLote.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLote.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLote.Location = new System.Drawing.Point(0, 110);
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.RowHeadersWidth = 10;
            this.dgvLote.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLote.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLote.Size = new System.Drawing.Size(899, 302);
            this.dgvLote.TabIndex = 48;
            this.dgvLote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLote_CellClick);
            this.dgvLote.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvLote_CurrentCellDirtyStateChanged);
            // 
            // CheckSel
            // 
            this.CheckSel.HeaderText = "";
            this.CheckSel.Name = "CheckSel";
            this.CheckSel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckSel.Width = 20;
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "IdLote";
            this.IdLote.HeaderText = "Lote";
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            this.IdLote.Width = 80;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.Visible = false;
            this.IdSocio.Width = 68;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 160;
            // 
            // sdDesembolso
            // 
            this.sdDesembolso.DataPropertyName = "sdDesembolso";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.sdDesembolso.DefaultCellStyle = dataGridViewCellStyle1;
            this.sdDesembolso.HeaderText = "Fecha Desembolso";
            this.sdDesembolso.Name = "sdDesembolso";
            this.sdDesembolso.ReadOnly = true;
            this.sdDesembolso.Width = 80;
            // 
            // IdMoneda_tt
            // 
            this.IdMoneda_tt.DataPropertyName = "IdMoneda_tt";
            this.IdMoneda_tt.HeaderText = "IdMoneda_tt";
            this.IdMoneda_tt.Name = "IdMoneda_tt";
            this.IdMoneda_tt.Visible = false;
            this.IdMoneda_tt.Width = 92;
            // 
            // sdAprobacion
            // 
            this.sdAprobacion.DataPropertyName = "sdAprobacion";
            this.sdAprobacion.HeaderText = "sdAprobacion";
            this.sdAprobacion.Name = "sdAprobacion";
            this.sdAprobacion.Visible = false;
            this.sdAprobacion.Width = 97;
            // 
            // NLinea
            // 
            this.NLinea.DataPropertyName = "IdLinea";
            this.NLinea.HeaderText = "Nro. Línea";
            this.NLinea.Name = "NLinea";
            this.NLinea.Visible = false;
            this.NLinea.Width = 77;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.DataPropertyName = "dtVencimiento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaVencimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Visible = false;
            this.FechaVencimiento.Width = 80;
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "IdMoneda_tt_Dsc";
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            this.Moneda.Width = 80;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "nImporte";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Importe.DefaultCellStyle = dataGridViewCellStyle3;
            this.Importe.HeaderText = "nImporte";
            this.Importe.Name = "Importe";
            this.Importe.Visible = false;
            this.Importe.Width = 80;
            // 
            // nValorNegociable
            // 
            this.nValorNegociable.DataPropertyName = "nValorNegociable";
            this.nValorNegociable.HeaderText = "Valor Negociable";
            this.nValorNegociable.Name = "nValorNegociable";
            this.nValorNegociable.ReadOnly = true;
            // 
            // nDesembolso
            // 
            this.nDesembolso.DataPropertyName = "nDesembolso";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.nDesembolso.DefaultCellStyle = dataGridViewCellStyle4;
            this.nDesembolso.HeaderText = "Desembolso";
            this.nDesembolso.Name = "nDesembolso";
            this.nDesembolso.ReadOnly = true;
            this.nDesembolso.Width = 80;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle5;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.Visible = false;
            this.Saldo.Width = 80;
            // 
            // ITransito
            // 
            this.ITransito.DataPropertyName = "Transito";
            this.ITransito.HeaderText = "I. Transito";
            this.ITransito.Name = "ITransito";
            this.ITransito.Visible = false;
            this.ITransito.Width = 73;
            // 
            // SaldoDisponible
            // 
            this.SaldoDisponible.DataPropertyName = "SaldoDisponible";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.SaldoDisponible.DefaultCellStyle = dataGridViewCellStyle6;
            this.SaldoDisponible.HeaderText = "Saldo Disponible";
            this.SaldoDisponible.Name = "SaldoDisponible";
            this.SaldoDisponible.Visible = false;
            this.SaldoDisponible.Width = 102;
            // 
            // IdEstado_tt_Dsc
            // 
            this.IdEstado_tt_Dsc.DataPropertyName = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.HeaderText = "Estado";
            this.IdEstado_tt_Dsc.Name = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.ReadOnly = true;
            // 
            // IdEstado_tt
            // 
            this.IdEstado_tt.DataPropertyName = "IdEstado_tt";
            this.IdEstado_tt.HeaderText = "IdEstado_tt";
            this.IdEstado_tt.Name = "IdEstado_tt";
            this.IdEstado_tt.Visible = false;
            // 
            // btnLiquidacion
            // 
            this.btnLiquidacion.HeaderText = "";
            this.btnLiquidacion.Name = "btnLiquidacion";
            this.btnLiquidacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnLiquidacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnLiquidacion.Text = "Ver Liquidación";
            this.btnLiquidacion.UseColumnTextForLinkValue = true;
            // 
            // frmLoteAprobacion
            // 
            this.ClientSize = new System.Drawing.Size(899, 414);
            this.Controls.Add(this.PanelEx1);
            this.Controls.Add(this.dgvLote);
            this.Controls.Add(this.lblGrilla);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.RibbonBar1);
            this.DoubleBuffered = true;
            this.Name = "frmLoteAprobacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprobación de Planilla";
            this.Load += new System.EventHandler(this.frmLoteAprobacion_Load);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.RibbonBar RibbonBar1;
        protected DevComponents.DotNetBar.ButtonItem btnAprobacion;
        protected DevComponents.DotNetBar.ButtonItem btnExtornar;
        protected DevComponents.DotNetBar.ButtonItem btnSalir;
        protected DevComponents.DotNetBar.LabelX lblGrilla;
        protected DevComponents.DotNetBar.LabelX lblRegistros;
        protected DevComponents.DotNetBar.PanelEx PanelEx1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaRegistro;
        protected DevComponents.DotNetBar.ButtonX btnLimpiar;
        protected DevComponents.DotNetBar.ButtonX btnBuscar;
        protected DevComponents.DotNetBar.LabelX LabelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLote;
        protected DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdEstado_tt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdDesembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdAprobacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn nValorNegociable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDesembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITransito;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt;
        private System.Windows.Forms.DataGridViewLinkColumn btnLiquidacion;
    }
}