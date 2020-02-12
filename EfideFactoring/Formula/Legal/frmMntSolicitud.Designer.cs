namespace EfideFactoring.Formula.Legal
{
    partial class frmMntSolicitud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtSolicitudInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnEvaluacion = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.dgvSolicitud = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersonaSolicitud_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdArea_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoSolicitud_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRazonSocialSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRazonSocialPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoLinea_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoLinea_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkVerHistoricos = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtvRazonSocialSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboIdEstado_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboIdPersonaSolicitud = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSolicitudInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).BeginInit();
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
            this.RibbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnEvaluacion,
            this.buttonItem1});
            this.RibbonBar1.Size = new System.Drawing.Size(1370, 40);
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
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.Controls.Add(this.cboIdPersonaSolicitud);
            this.PanelEx1.Controls.Add(this.labelX4);
            this.PanelEx1.Controls.Add(this.cboIdEstado_tt);
            this.PanelEx1.Controls.Add(this.labelX3);
            this.PanelEx1.Controls.Add(this.txtvRazonSocialSocio);
            this.PanelEx1.Controls.Add(this.labelX2);
            this.PanelEx1.Controls.Add(this.chkVerHistoricos);
            this.PanelEx1.Controls.Add(this.dtSolicitudInput);
            this.PanelEx1.Size = new System.Drawing.Size(1370, 54);
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
            this.PanelEx1.Controls.SetChildIndex(this.dtSolicitudInput, 0);
            this.PanelEx1.Controls.SetChildIndex(this.chkVerHistoricos, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX2, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtvRazonSocialSocio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX3, 0);
            this.PanelEx1.Controls.SetChildIndex(this.cboIdEstado_tt, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX4, 0);
            this.PanelEx1.Controls.SetChildIndex(this.cboIdPersonaSolicitud, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1255, 6);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1178, 6);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(1348, 16);
            this.TextBoxX1.Size = new System.Drawing.Size(10, 20);
            this.TextBoxX1.Visible = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Size = new System.Drawing.Size(94, 23);
            this.LabelX1.Text = "Fecha Solicitud";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Text = "Datos";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(1194, 94);
            // 
            // dtSolicitudInput
            // 
            // 
            // 
            // 
            this.dtSolicitudInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtSolicitudInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSolicitudInput.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtSolicitudInput.ButtonDropDown.Visible = true;
            this.dtSolicitudInput.IsPopupCalendarOpen = false;
            this.dtSolicitudInput.Location = new System.Drawing.Point(115, 16);
            // 
            // 
            // 
            this.dtSolicitudInput.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtSolicitudInput.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSolicitudInput.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtSolicitudInput.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtSolicitudInput.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtSolicitudInput.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtSolicitudInput.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtSolicitudInput.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtSolicitudInput.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtSolicitudInput.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtSolicitudInput.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSolicitudInput.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.dtSolicitudInput.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtSolicitudInput.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtSolicitudInput.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtSolicitudInput.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtSolicitudInput.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtSolicitudInput.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtSolicitudInput.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSolicitudInput.MonthCalendar.TodayButtonVisible = true;
            this.dtSolicitudInput.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtSolicitudInput.Name = "dtSolicitudInput";
            this.dtSolicitudInput.Size = new System.Drawing.Size(100, 20);
            this.dtSolicitudInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtSolicitudInput.TabIndex = 7;
            // 
            // btnEvaluacion
            // 
            this.btnEvaluacion.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnEvaluacion.Image = global::EfideFactoring.Properties.Resources.refresh;
            this.btnEvaluacion.Name = "btnEvaluacion";
            this.btnEvaluacion.SubItemsExpandWidth = 14;
            this.btnEvaluacion.Text = "Evaluación";
            this.btnEvaluacion.Visible = false;
            this.btnEvaluacion.Click += new System.EventHandler(this.btnEvaluacion_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "buttonItem1";
            this.buttonItem1.Visible = false;
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // dgvSolicitud
            // 
            this.dgvSolicitud.AllowUserToAddRows = false;
            this.dgvSolicitud.AllowUserToDeleteRows = false;
            this.dgvSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSolicitud,
            this.dtSolicitud,
            this.TiempoAtencion,
            this.IdPersonaSolicitud_Dsc,
            this.IdArea_tt_Dsc,
            this.IdTipoSolicitud_tt_Dsc,
            this.vRazonSocialSocio,
            this.vRazonSocialPagadora,
            this.nImporte,
            this.IdEstado_tt,
            this.IdEstado_tt_Dsc,
            this.IdTipoLinea_tt,
            this.IdTipoLinea_tt_Dsc,
            this.IdMoneda_tt,
            this.IdMoneda_tt_Dsc});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitud.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSolicitud.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSolicitud.Location = new System.Drawing.Point(0, 116);
            this.dgvSolicitud.Name = "dgvSolicitud";
            this.dgvSolicitud.ReadOnly = true;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvSolicitud.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSolicitud.Size = new System.Drawing.Size(1370, 474);
            this.dgvSolicitud.TabIndex = 22;
            // 
            // IdSolicitud
            // 
            this.IdSolicitud.DataPropertyName = "IdSolicitud";
            this.IdSolicitud.HeaderText = "Solicitud";
            this.IdSolicitud.Name = "IdSolicitud";
            this.IdSolicitud.ReadOnly = true;
            // 
            // dtSolicitud
            // 
            this.dtSolicitud.DataPropertyName = "dtSolicitud";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dtSolicitud.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtSolicitud.HeaderText = "Fecha Solicitud";
            this.dtSolicitud.Name = "dtSolicitud";
            this.dtSolicitud.ReadOnly = true;
            this.dtSolicitud.Width = 80;
            // 
            // TiempoAtencion
            // 
            this.TiempoAtencion.DataPropertyName = "TiempoAtencion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TiempoAtencion.DefaultCellStyle = dataGridViewCellStyle2;
            this.TiempoAtencion.HeaderText = "Tiempo Atención (d)";
            this.TiempoAtencion.Name = "TiempoAtencion";
            this.TiempoAtencion.ReadOnly = true;
            this.TiempoAtencion.Width = 80;
            // 
            // IdPersonaSolicitud_Dsc
            // 
            this.IdPersonaSolicitud_Dsc.DataPropertyName = "IdPersonaSolicitud_Dsc";
            this.IdPersonaSolicitud_Dsc.HeaderText = "Solicitante";
            this.IdPersonaSolicitud_Dsc.Name = "IdPersonaSolicitud_Dsc";
            this.IdPersonaSolicitud_Dsc.ReadOnly = true;
            this.IdPersonaSolicitud_Dsc.Width = 150;
            // 
            // IdArea_tt_Dsc
            // 
            this.IdArea_tt_Dsc.DataPropertyName = "IdArea_tt_Dsc";
            this.IdArea_tt_Dsc.HeaderText = "Area";
            this.IdArea_tt_Dsc.Name = "IdArea_tt_Dsc";
            this.IdArea_tt_Dsc.ReadOnly = true;
            // 
            // IdTipoSolicitud_tt_Dsc
            // 
            this.IdTipoSolicitud_tt_Dsc.DataPropertyName = "IdTipoSolicitud_tt_Dsc";
            this.IdTipoSolicitud_tt_Dsc.HeaderText = "Tipo Solicitud";
            this.IdTipoSolicitud_tt_Dsc.Name = "IdTipoSolicitud_tt_Dsc";
            this.IdTipoSolicitud_tt_Dsc.ReadOnly = true;
            this.IdTipoSolicitud_tt_Dsc.Width = 230;
            // 
            // vRazonSocialSocio
            // 
            this.vRazonSocialSocio.DataPropertyName = "vRazonSocialSocio";
            this.vRazonSocialSocio.HeaderText = "Socio";
            this.vRazonSocialSocio.Name = "vRazonSocialSocio";
            this.vRazonSocialSocio.ReadOnly = true;
            this.vRazonSocialSocio.Width = 180;
            // 
            // vRazonSocialPagadora
            // 
            this.vRazonSocialPagadora.DataPropertyName = "vRazonSocialPagadora";
            this.vRazonSocialPagadora.HeaderText = "Pagadora";
            this.vRazonSocialPagadora.Name = "vRazonSocialPagadora";
            this.vRazonSocialPagadora.ReadOnly = true;
            this.vRazonSocialPagadora.Width = 180;
            // 
            // nImporte
            // 
            this.nImporte.DataPropertyName = "nImporte";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.nImporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.nImporte.HeaderText = "Importe";
            this.nImporte.Name = "nImporte";
            this.nImporte.ReadOnly = true;
            this.nImporte.Width = 70;
            // 
            // IdEstado_tt
            // 
            this.IdEstado_tt.DataPropertyName = "IdEstado_tt";
            this.IdEstado_tt.HeaderText = "IdEstado_tt";
            this.IdEstado_tt.Name = "IdEstado_tt";
            this.IdEstado_tt.ReadOnly = true;
            this.IdEstado_tt.Visible = false;
            // 
            // IdEstado_tt_Dsc
            // 
            this.IdEstado_tt_Dsc.DataPropertyName = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.HeaderText = "Estado";
            this.IdEstado_tt_Dsc.Name = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.ReadOnly = true;
            this.IdEstado_tt_Dsc.Width = 120;
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
            this.IdTipoLinea_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            this.IdTipoLinea_tt_Dsc.HeaderText = "IdTipoLinea_tt_Dsc";
            this.IdTipoLinea_tt_Dsc.Name = "IdTipoLinea_tt_Dsc";
            this.IdTipoLinea_tt_Dsc.ReadOnly = true;
            this.IdTipoLinea_tt_Dsc.Visible = false;
            // 
            // IdMoneda_tt
            // 
            this.IdMoneda_tt.DataPropertyName = "IdMoneda_tt";
            this.IdMoneda_tt.HeaderText = "IdMoneda_tt";
            this.IdMoneda_tt.Name = "IdMoneda_tt";
            this.IdMoneda_tt.ReadOnly = true;
            this.IdMoneda_tt.Visible = false;
            // 
            // IdMoneda_tt_Dsc
            // 
            this.IdMoneda_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.HeaderText = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            this.IdMoneda_tt_Dsc.Visible = false;
            // 
            // chkVerHistoricos
            // 
            // 
            // 
            // 
            this.chkVerHistoricos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkVerHistoricos.Location = new System.Drawing.Point(591, 13);
            this.chkVerHistoricos.Name = "chkVerHistoricos";
            this.chkVerHistoricos.Size = new System.Drawing.Size(100, 23);
            this.chkVerHistoricos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkVerHistoricos.TabIndex = 10;
            this.chkVerHistoricos.Text = "Ver Historicos";
            this.chkVerHistoricos.Visible = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(234, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(90, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Socio/Pagadora";
            // 
            // txtvRazonSocialSocio
            // 
            // 
            // 
            // 
            this.txtvRazonSocialSocio.Border.Class = "TextBoxBorder";
            this.txtvRazonSocialSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtvRazonSocialSocio.Location = new System.Drawing.Point(330, 15);
            this.txtvRazonSocialSocio.Name = "txtvRazonSocialSocio";
            this.txtvRazonSocialSocio.Size = new System.Drawing.Size(245, 20);
            this.txtvRazonSocialSocio.TabIndex = 12;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(712, 15);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(58, 23);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "Estado";
            // 
            // cboIdEstado_tt
            // 
            this.cboIdEstado_tt.DisplayMember = "Text";
            this.cboIdEstado_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdEstado_tt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdEstado_tt.FormattingEnabled = true;
            this.cboIdEstado_tt.ItemHeight = 14;
            this.cboIdEstado_tt.Location = new System.Drawing.Point(764, 16);
            this.cboIdEstado_tt.Name = "cboIdEstado_tt";
            this.cboIdEstado_tt.Size = new System.Drawing.Size(121, 20);
            this.cboIdEstado_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdEstado_tt.TabIndex = 14;
            // 
            // cboIdPersonaSolicitud
            // 
            this.cboIdPersonaSolicitud.DisplayMember = "Text";
            this.cboIdPersonaSolicitud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdPersonaSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdPersonaSolicitud.FormattingEnabled = true;
            this.cboIdPersonaSolicitud.ItemHeight = 14;
            this.cboIdPersonaSolicitud.Location = new System.Drawing.Point(976, 15);
            this.cboIdPersonaSolicitud.Name = "cboIdPersonaSolicitud";
            this.cboIdPersonaSolicitud.Size = new System.Drawing.Size(121, 20);
            this.cboIdPersonaSolicitud.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdPersonaSolicitud.TabIndex = 16;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX4.Location = new System.Drawing.Point(912, 15);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(58, 23);
            this.labelX4.TabIndex = 15;
            this.labelX4.Text = "Solicitante";
            // 
            // frmMntSolicitud
            // 
            this.ClientSize = new System.Drawing.Size(1370, 591);
            this.Controls.Add(this.dgvSolicitud);
            this.DoubleBuffered = true;
            this.Name = "frmMntSolicitud";
            this.Text = "Solicitud";
            this.Load += new System.EventHandler(this.frmMntSolicitud_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvSolicitud, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSolicitudInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtSolicitudInput;
        private DevComponents.DotNetBar.ButtonItem btnEvaluacion;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSolicitud;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkVerHistoricos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersonaSolicitud_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArea_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoSolicitud_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRazonSocialSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRazonSocialPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoLinea_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoLinea_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtvRazonSocialSocio;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdEstado_tt;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdPersonaSolicitud;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}