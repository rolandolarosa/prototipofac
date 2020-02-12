namespace EfideFactoring.Formula.GestionPagadora
{
    partial class frmAsignarGestorPagadora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.lblNRegistros = new DevComponents.DotNetBar.LabelX();
            this.dgvPagadoras = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdEstadoLinea_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGestor_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBuscarPagadora = new DevComponents.DotNetBar.ButtonX();
            this.txtIdPagadora = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ChkInactivos = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cboEjecutivo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.dtFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtFechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.ChkBloqueados = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnAgregarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.dgvUsuarios = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.gestorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboUsuarios = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.PanelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagadoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(1143, 40);
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
            this.btnNuevo.Text = "&Asignar Pagadoras";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Text = "Eliminar Asignación";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.Controls.Add(this.ChkBloqueados);
            this.PanelEx1.Controls.Add(this.labelX2);
            this.PanelEx1.Controls.Add(this.ChkInactivos);
            this.PanelEx1.Controls.Add(this.cboEjecutivo);
            this.PanelEx1.Controls.Add(this.labelX9);
            this.PanelEx1.Controls.Add(this.labelX8);
            this.PanelEx1.Controls.Add(this.dtFechaFin);
            this.PanelEx1.Controls.Add(this.dtFechaInicio);
            this.PanelEx1.Controls.Add(this.labelX7);
            this.PanelEx1.Controls.Add(this.labelX5);
            this.PanelEx1.Controls.Add(this.labelX4);
            this.PanelEx1.Controls.Add(this.txtDescripcion);
            this.PanelEx1.Controls.Add(this.btnBuscarPagadora);
            this.PanelEx1.Controls.Add(this.txtIdPagadora);
            this.PanelEx1.Controls.Add(this.line1);
            this.PanelEx1.Controls.Add(this.labelX6);
            this.PanelEx1.Size = new System.Drawing.Size(1143, 124);
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
            this.PanelEx1.Controls.SetChildIndex(this.labelX6, 0);
            this.PanelEx1.Controls.SetChildIndex(this.line1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtIdPagadora, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscarPagadora, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX4, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX5, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX7, 0);
            this.PanelEx1.Controls.SetChildIndex(this.dtFechaInicio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.dtFechaFin, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX8, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX9, 0);
            this.PanelEx1.Controls.SetChildIndex(this.cboEjecutivo, 0);
            this.PanelEx1.Controls.SetChildIndex(this.ChkInactivos, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX2, 0);
            this.PanelEx1.Controls.SetChildIndex(this.ChkBloqueados, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(588, 70);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(511, 70);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(776, 74);
            this.TextBoxX1.Size = new System.Drawing.Size(27, 20);
            this.TextBoxX1.Visible = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(695, 74);
            this.LabelX1.Visible = false;
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Location = new System.Drawing.Point(0, 169);
            this.lblGrilla.Visible = false;
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(967, 170);
            this.lblRegistros.Visible = false;
            // 
            // panelEx3
            // 
            this.panelEx3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.lblNRegistros);
            this.panelEx3.Controls.Add(this.dgvPagadoras);
            this.panelEx3.Location = new System.Drawing.Point(0, 180);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(762, 380);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 30;
            // 
            // lblNRegistros
            // 
            this.lblNRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblNRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNRegistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNRegistros.Location = new System.Drawing.Point(467, 15);
            this.lblNRegistros.Name = "lblNRegistros";
            this.lblNRegistros.Size = new System.Drawing.Size(281, 23);
            this.lblNRegistros.TabIndex = 23;
            this.lblNRegistros.Text = "0  registro(s)";
            this.lblNRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvPagadoras
            // 
            this.dgvPagadoras.AllowUserToAddRows = false;
            this.dgvPagadoras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvPagadoras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagadoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagadoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEstadoLinea_tt_Dsc,
            this.IdPagadora,
            this.vcPagadora,
            this.IdGestor_Dsc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagadoras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagadoras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPagadoras.Location = new System.Drawing.Point(17, 40);
            this.dgvPagadoras.Name = "dgvPagadoras";
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvPagadoras.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPagadoras.RowTemplate.Height = 24;
            this.dgvPagadoras.Size = new System.Drawing.Size(731, 328);
            this.dgvPagadoras.TabIndex = 22;
            this.dgvPagadoras.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPagadoras_CurrentCellDirtyStateChanged);
            // 
            // IdEstadoLinea_tt_Dsc
            // 
            this.IdEstadoLinea_tt_Dsc.DataPropertyName = "IdEstadoLinea_tt_Dsc";
            this.IdEstadoLinea_tt_Dsc.HeaderText = "Estado Línea";
            this.IdEstadoLinea_tt_Dsc.Name = "IdEstadoLinea_tt_Dsc";
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "Código";
            this.IdPagadora.Name = "IdPagadora";
            // 
            // vcPagadora
            // 
            this.vcPagadora.DataPropertyName = "vcPagadora";
            this.vcPagadora.HeaderText = "Pagadora";
            this.vcPagadora.Name = "vcPagadora";
            this.vcPagadora.Width = 200;
            // 
            // IdGestor_Dsc
            // 
            this.IdGestor_Dsc.DataPropertyName = "IdGestor_Dsc";
            this.IdGestor_Dsc.HeaderText = "Ejecutivo";
            this.IdGestor_Dsc.Name = "IdGestor_Dsc";
            this.IdGestor_Dsc.Width = 200;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(17, 21);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(735, 10);
            this.line1.TabIndex = 33;
            this.line1.Text = "line1";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(17, 5);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(148, 20);
            this.labelX6.TabIndex = 32;
            this.labelX6.Text = "FILTROS DE BUSQUEDA";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX4.Location = new System.Drawing.Point(17, 31);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(67, 23);
            this.labelX4.TabIndex = 37;
            this.labelX4.Text = "Pagadora";
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Location = new System.Drawing.Point(247, 31);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(328, 20);
            this.txtDescripcion.TabIndex = 36;
            // 
            // btnBuscarPagadora
            // 
            this.btnBuscarPagadora.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarPagadora.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscarPagadora.Location = new System.Drawing.Point(108, 31);
            this.btnBuscarPagadora.Name = "btnBuscarPagadora";
            this.btnBuscarPagadora.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarPagadora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarPagadora.TabIndex = 34;
            this.btnBuscarPagadora.Text = "...";
            this.btnBuscarPagadora.Click += new System.EventHandler(this.btnBuscarPagadora_Click);
            // 
            // txtIdPagadora
            // 
            // 
            // 
            // 
            this.txtIdPagadora.Border.Class = "TextBoxBorder";
            this.txtIdPagadora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdPagadora.Location = new System.Drawing.Point(141, 31);
            this.txtIdPagadora.Name = "txtIdPagadora";
            this.txtIdPagadora.Size = new System.Drawing.Size(100, 20);
            this.txtIdPagadora.TabIndex = 35;
            // 
            // ChkInactivos
            // 
            // 
            // 
            // 
            this.ChkInactivos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ChkInactivos.Location = new System.Drawing.Point(141, 95);
            this.ChkInactivos.Name = "ChkInactivos";
            this.ChkInactivos.Size = new System.Drawing.Size(24, 23);
            this.ChkInactivos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ChkInactivos.TabIndex = 50;
            // 
            // cboEjecutivo
            // 
            this.cboEjecutivo.DisplayMember = "Text";
            this.cboEjecutivo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEjecutivo.FormattingEnabled = true;
            this.cboEjecutivo.ItemHeight = 14;
            this.cboEjecutivo.Location = new System.Drawing.Point(141, 52);
            this.cboEjecutivo.Name = "cboEjecutivo";
            this.cboEjecutivo.Size = new System.Drawing.Size(268, 20);
            this.cboEjecutivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEjecutivo.TabIndex = 49;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX9.Location = new System.Drawing.Point(17, 50);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(78, 23);
            this.labelX9.TabIndex = 48;
            this.labelX9.Text = "Ejecutivo";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX8.Location = new System.Drawing.Point(247, 70);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(56, 23);
            this.labelX8.TabIndex = 47;
            this.labelX8.Text = "Hasta";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dtFechaFin
            // 
            // 
            // 
            // 
            this.dtFechaFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaFin.ButtonDropDown.Visible = true;
            this.dtFechaFin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaFin.IsPopupCalendarOpen = false;
            this.dtFechaFin.Location = new System.Drawing.Point(309, 73);
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaFin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.MonthCalendar.DisplayMonth = new System.DateTime(2018, 3, 1, 0, 0, 0, 0);
            this.dtFechaFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtFechaFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtFechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaFin.TabIndex = 46;
            // 
            // dtFechaInicio
            // 
            // 
            // 
            // 
            this.dtFechaInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaInicio.ButtonDropDown.Visible = true;
            this.dtFechaInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaInicio.IsPopupCalendarOpen = false;
            this.dtFechaInicio.Location = new System.Drawing.Point(141, 73);
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
            this.dtFechaInicio.MonthCalendar.DisplayMonth = new System.DateTime(2018, 3, 1, 0, 0, 0, 0);
            this.dtFechaInicio.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
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
            this.dtFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dtFechaInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaInicio.TabIndex = 45;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX7.Location = new System.Drawing.Point(17, 74);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(78, 23);
            this.labelX7.TabIndex = 44;
            this.labelX7.Text = "Fecha Ingreso";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX5.Location = new System.Drawing.Point(17, 96);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(118, 23);
            this.labelX5.TabIndex = 43;
            this.labelX5.Text = "Inactivos";
            // 
            // ChkBloqueados
            // 
            // 
            // 
            // 
            this.ChkBloqueados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ChkBloqueados.Location = new System.Drawing.Point(309, 95);
            this.ChkBloqueados.Name = "ChkBloqueados";
            this.ChkBloqueados.Size = new System.Drawing.Size(24, 23);
            this.ChkBloqueados.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ChkBloqueados.TabIndex = 52;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(185, 96);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(118, 23);
            this.labelX2.TabIndex = 51;
            this.labelX2.Text = "Bloqueados";
            // 
            // panelEx2
            // 
            this.panelEx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btnAgregarUsuario);
            this.panelEx2.Controls.Add(this.dgvUsuarios);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.Controls.Add(this.cboUsuarios);
            this.panelEx2.Location = new System.Drawing.Point(768, 180);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(372, 379);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 31;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregarUsuario.Image = global::EfideFactoring.Properties.Resources.add;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(273, 12);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(87, 24);
            this.btnAgregarUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregarUsuario.TabIndex = 27;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gestorID,
            this.nombreCompleto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(16, 42);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(344, 323);
            this.dgvUsuarios.TabIndex = 24;
            // 
            // gestorID
            // 
            this.gestorID.DataPropertyName = "gestorID";
            this.gestorID.HeaderText = "gestorID";
            this.gestorID.Name = "gestorID";
            this.gestorID.ReadOnly = true;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.DataPropertyName = "nombreCompleto";
            this.nombreCompleto.HeaderText = "Ejecutivo";
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            this.nombreCompleto.Width = 180;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(16, 14);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(67, 23);
            this.labelX3.TabIndex = 25;
            this.labelX3.Text = "Ejecutivo";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DisplayMember = "Text";
            this.cboUsuarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.ItemHeight = 16;
            this.cboUsuarios.Location = new System.Drawing.Point(89, 15);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(178, 22);
            this.cboUsuarios.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboUsuarios.TabIndex = 26;
            // 
            // frmAsignarGestorPagadora
            // 
            this.ClientSize = new System.Drawing.Size(1143, 581);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx3);
            this.DoubleBuffered = true;
            this.Name = "frmAsignarGestorPagadora";
            this.Text = "Asignación de Pagadoras / Gestor";
            this.Load += new System.EventHandler(this.frmAsignarGestorPagadora_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.panelEx3, 0);
            this.Controls.SetChildIndex(this.panelEx2, 0);
            this.PanelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagadoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio)).EndInit();
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX lblNRegistros;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPagadoras;
        private DevComponents.DotNetBar.Controls.Line line1;
        protected DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.ButtonX btnBuscarPagadora;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdPagadora;
        private DevComponents.DotNetBar.Controls.CheckBoxX ChkBloqueados;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX ChkInactivos;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEjecutivo;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaFin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaInicio;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btnAgregarUsuario;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstadoLinea_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGestor_Dsc;
    }
}