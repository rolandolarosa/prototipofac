namespace EfideFactoring.Formula.Legal
{
    partial class frmQryGestionNPO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQryGestionNPO));
            this.dtSolicitudInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dgvSolicitud = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chkVerHistoricos = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.IdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdArea_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoSolicitud_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRazonSocialSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRazonSocialPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersonaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEjecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersonaLegal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoLegal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerSolicitud = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
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
            this.RibbonBar1.Size = new System.Drawing.Size(1633, 40);
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
            // 
            // btnEditar
            // 
            this.btnEditar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Visible = false;
            // 
            // PanelEx1
            // 
            this.PanelEx1.Controls.Add(this.chkVerHistoricos);
            this.PanelEx1.Controls.Add(this.dtSolicitudInput);
            this.PanelEx1.Size = new System.Drawing.Size(1633, 54);
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
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(603, 3);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(526, 3);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(1416, 6);
            this.TextBoxX1.Size = new System.Drawing.Size(49, 20);
            this.TextBoxX1.Visible = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Size = new System.Drawing.Size(111, 23);
            this.LabelX1.Text = "Fecha Solicitud";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Visible = false;
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(1457, 97);
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
            this.dtSolicitudInput.Location = new System.Drawing.Point(104, 16);
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
            this.dtSolicitudInput.Size = new System.Drawing.Size(116, 20);
            this.dtSolicitudInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtSolicitudInput.TabIndex = 8;
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
            this.IdArea_tt_Dsc,
            this.IdTipoSolicitud_tt_Dsc,
            this.vRazonSocialSocio,
            this.vRazonSocialPagadora,
            this.nImporte,
            this.IdPersonaSolicitud,
            this.TiempoEjecutivo,
            this.IdPersonaLegal,
            this.TiempoLegal,
            this.IdEstado_tt,
            this.IdEstado_tt_Dsc,
            this.btnVerSolicitud});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitud.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSolicitud.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSolicitud.Location = new System.Drawing.Point(0, 124);
            this.dgvSolicitud.Name = "dgvSolicitud";
            this.dgvSolicitud.ReadOnly = true;
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvSolicitud.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSolicitud.Size = new System.Drawing.Size(1633, 417);
            this.dgvSolicitud.TabIndex = 22;
            this.dgvSolicitud.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitud_CellClick);
            // 
            // chkVerHistoricos
            // 
            // 
            // 
            // 
            this.chkVerHistoricos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkVerHistoricos.Location = new System.Drawing.Point(254, 13);
            this.chkVerHistoricos.Name = "chkVerHistoricos";
            this.chkVerHistoricos.Size = new System.Drawing.Size(100, 23);
            this.chkVerHistoricos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkVerHistoricos.TabIndex = 9;
            this.chkVerHistoricos.Text = "Ver Historicos";
            // 
            // IdSolicitud
            // 
            this.IdSolicitud.DataPropertyName = "IdSolicitud";
            this.IdSolicitud.HeaderText = "Nro. Solicitud";
            this.IdSolicitud.Name = "IdSolicitud";
            this.IdSolicitud.ReadOnly = true;
            this.IdSolicitud.Width = 80;
            // 
            // dtSolicitud
            // 
            this.dtSolicitud.DataPropertyName = "dtSolicitud";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dtSolicitud.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtSolicitud.HeaderText = "Fecha";
            this.dtSolicitud.Name = "dtSolicitud";
            this.dtSolicitud.ReadOnly = true;
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
            this.nImporte.HeaderText = "Importe Operación";
            this.nImporte.Name = "nImporte";
            this.nImporte.ReadOnly = true;
            this.nImporte.Width = 80;
            // 
            // IdPersonaSolicitud
            // 
            this.IdPersonaSolicitud.DataPropertyName = "IdPersonaSolicitud";
            this.IdPersonaSolicitud.HeaderText = "Usuario Ejecutivo";
            this.IdPersonaSolicitud.Name = "IdPersonaSolicitud";
            this.IdPersonaSolicitud.ReadOnly = true;
            this.IdPersonaSolicitud.Width = 80;
            // 
            // TiempoEjecutivo
            // 
            this.TiempoEjecutivo.DataPropertyName = "TiempoEjecutivo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TiempoEjecutivo.DefaultCellStyle = dataGridViewCellStyle4;
            this.TiempoEjecutivo.FillWeight = 80F;
            this.TiempoEjecutivo.HeaderText = "Tiempo Ejecutivo (d)";
            this.TiempoEjecutivo.Name = "TiempoEjecutivo";
            this.TiempoEjecutivo.ReadOnly = true;
            // 
            // IdPersonaLegal
            // 
            this.IdPersonaLegal.DataPropertyName = "IdPersonaLegal";
            this.IdPersonaLegal.HeaderText = "Usuario Legal";
            this.IdPersonaLegal.Name = "IdPersonaLegal";
            this.IdPersonaLegal.ReadOnly = true;
            this.IdPersonaLegal.Width = 80;
            // 
            // TiempoLegal
            // 
            this.TiempoLegal.DataPropertyName = "TiempoLegal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TiempoLegal.DefaultCellStyle = dataGridViewCellStyle5;
            this.TiempoLegal.FillWeight = 80F;
            this.TiempoLegal.HeaderText = "Tiempo Legal (d)";
            this.TiempoLegal.Name = "TiempoLegal";
            this.TiempoLegal.ReadOnly = true;
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
            // btnVerSolicitud
            // 
            this.btnVerSolicitud.HeaderText = "";
            this.btnVerSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btnVerSolicitud.Image")));
            this.btnVerSolicitud.Name = "btnVerSolicitud";
            this.btnVerSolicitud.ReadOnly = true;
            this.btnVerSolicitud.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnVerSolicitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnVerSolicitud.Text = null;
            this.btnVerSolicitud.Width = 40;
            // 
            // frmQryGestionNPO
            // 
            this.ClientSize = new System.Drawing.Size(1633, 554);
            this.Controls.Add(this.dgvSolicitud);
            this.DoubleBuffered = true;
            this.Name = "frmQryGestionNPO";
            this.Text = "Gestión de Nuevos Prospectos de Operaciones";
            this.Load += new System.EventHandler(this.frmQryGestionNPO_Load);
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
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSolicitud;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkVerHistoricos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArea_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoSolicitud_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRazonSocialSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRazonSocialPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersonaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEjecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersonaLegal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoLegal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btnVerSolicitud;
    }
}