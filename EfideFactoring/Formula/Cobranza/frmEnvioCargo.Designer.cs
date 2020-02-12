namespace EfideFactoring.Formula.Cobranza
{
    partial class frmEnvioCargo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEnvioCargo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdCobranza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocumento_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechaFilter = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvioCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFilter)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(886, 40);
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
            this.btnNuevo.Text = "&Generar Cartas";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::EfideFactoring.Properties.Resources.carpeta;
            this.btnEditar.Text = "Definitivo";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Visible = false;
            // 
            // PanelEx1
            // 
            this.PanelEx1.Controls.Add(this.dtFechaFilter);
            this.PanelEx1.Size = new System.Drawing.Size(886, 54);
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
            this.PanelEx1.Controls.SetChildIndex(this.dtFechaFilter, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(660, 16);
            this.TextBoxX1.Size = new System.Drawing.Size(17, 20);
            this.TextBoxX1.Visible = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Text = "Fecha";
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
            this.lblRegistros.Location = new System.Drawing.Point(710, 97);
            // 
            // dgvEnvioCargo
            // 
            this.dgvEnvioCargo.AllowUserToAddRows = false;
            this.dgvEnvioCargo.AllowUserToDeleteRows = false;
            this.dgvEnvioCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEnvioCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvioCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCobranza,
            this.IdDocumento,
            this.IdDocumento_Dsc,
            this.cNumDoc,
            this.IdPagadora,
            this.IdPagadora_Dsc,
            this.IdSocio,
            this.IdSocio_Dsc,
            this.IdMoneda_tt,
            this.IdMoneda_tt_Dsc,
            this.nvImporte,
            this.sdVencimiento,
            this.dtRegistro});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEnvioCargo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEnvioCargo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvEnvioCargo.Location = new System.Drawing.Point(0, 125);
            this.dgvEnvioCargo.Name = "dgvEnvioCargo";
            this.dgvEnvioCargo.ReadOnly = true;
            this.dgvEnvioCargo.RowHeadersWidth = 10;
            this.dgvEnvioCargo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEnvioCargo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEnvioCargo.Size = new System.Drawing.Size(886, 277);
            this.dgvEnvioCargo.TabIndex = 22;
            // 
            // IdCobranza
            // 
            this.IdCobranza.DataPropertyName = "IdCobranza";
            this.IdCobranza.HeaderText = "IdCobranza";
            this.IdCobranza.Name = "IdCobranza";
            this.IdCobranza.ReadOnly = true;
            this.IdCobranza.Visible = false;
            // 
            // IdDocumento
            // 
            this.IdDocumento.DataPropertyName = "IdDocumento";
            this.IdDocumento.HeaderText = "IdDocumento";
            this.IdDocumento.Name = "IdDocumento";
            this.IdDocumento.ReadOnly = true;
            this.IdDocumento.Visible = false;
            // 
            // IdDocumento_Dsc
            // 
            this.IdDocumento_Dsc.DataPropertyName = "IdDocumento_Dsc";
            this.IdDocumento_Dsc.HeaderText = "Documento";
            this.IdDocumento_Dsc.Name = "IdDocumento_Dsc";
            this.IdDocumento_Dsc.ReadOnly = true;
            this.IdDocumento_Dsc.Width = 80;
            // 
            // cNumDoc
            // 
            this.cNumDoc.DataPropertyName = "cNumDoc";
            this.cNumDoc.HeaderText = "Número";
            this.cNumDoc.Name = "cNumDoc";
            this.cNumDoc.ReadOnly = true;
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "IdPagadora";
            this.IdPagadora.Name = "IdPagadora";
            this.IdPagadora.ReadOnly = true;
            this.IdPagadora.Visible = false;
            // 
            // IdPagadora_Dsc
            // 
            this.IdPagadora_Dsc.DataPropertyName = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.HeaderText = "Pagadora";
            this.IdPagadora_Dsc.Name = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.ReadOnly = true;
            this.IdPagadora_Dsc.Width = 150;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Visible = false;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 150;
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
            this.IdMoneda_tt_Dsc.HeaderText = "Moneda";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            this.IdMoneda_tt_Dsc.Width = 60;
            // 
            // nvImporte
            // 
            this.nvImporte.DataPropertyName = "nvImporte";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.nvImporte.DefaultCellStyle = dataGridViewCellStyle1;
            this.nvImporte.HeaderText = "Importe";
            this.nvImporte.Name = "nvImporte";
            this.nvImporte.ReadOnly = true;
            this.nvImporte.Width = 80;
            // 
            // sdVencimiento
            // 
            this.sdVencimiento.DataPropertyName = "sdVencimiento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.sdVencimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.sdVencimiento.HeaderText = "Fecha Vencimiento";
            this.sdVencimiento.Name = "sdVencimiento";
            this.sdVencimiento.ReadOnly = true;
            this.sdVencimiento.Width = 80;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dtRegistro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtRegistro.HeaderText = "Fecha Pago";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            this.dtRegistro.Width = 80;
            // 
            // dtFechaFilter
            // 
            // 
            // 
            // 
            this.dtFechaFilter.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaFilter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFilter.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaFilter.ButtonDropDown.Visible = true;
            this.dtFechaFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaFilter.IsPopupCalendarOpen = false;
            this.dtFechaFilter.Location = new System.Drawing.Point(79, 16);
            // 
            // 
            // 
            this.dtFechaFilter.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaFilter.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFilter.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaFilter.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaFilter.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaFilter.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaFilter.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaFilter.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaFilter.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaFilter.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaFilter.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFilter.MonthCalendar.DisplayMonth = new System.DateTime(2014, 10, 1, 0, 0, 0, 0);
            this.dtFechaFilter.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaFilter.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaFilter.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaFilter.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaFilter.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaFilter.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFilter.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaFilter.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaFilter.Name = "dtFechaFilter";
            this.dtFechaFilter.Size = new System.Drawing.Size(108, 20);
            this.dtFechaFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaFilter.TabIndex = 8;
            // 
            // frmEnvioCargo
            // 
            this.ClientSize = new System.Drawing.Size(886, 414);
            this.Controls.Add(this.dgvEnvioCargo);
            this.DoubleBuffered = true;
            this.Name = "frmEnvioCargo";
            this.Text = "Envío de Cargos Cancelados";
            this.Load += new System.EventHandler(this.frmEnvioCargo_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvEnvioCargo, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvioCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvEnvioCargo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCobranza;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
    }
}