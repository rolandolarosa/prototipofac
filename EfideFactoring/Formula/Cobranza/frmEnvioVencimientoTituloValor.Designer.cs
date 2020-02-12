namespace EfideFactoring.Formula.Cobranza
{
    partial class frmEnvioVencimientoTituloValor
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
            this.rdbPagadora = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.txtIdPagadora = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBuscarPagadora = new DevComponents.DotNetBar.ButtonX();
            this.dtFechaFilter = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dgvDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnGenerarDocumento = new DevComponents.DotNetBar.ButtonItem();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RucAceptante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvNegociable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCartera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlgEnviar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nFondoGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvNegociableInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
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
            this.btnGenerarDocumento});
            this.RibbonBar1.Size = new System.Drawing.Size(966, 40);
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
            this.btnNuevo.Image = global::EfideFactoring.Properties.Resources.previo;
            this.btnNuevo.Text = "&Generar Individual";
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
            this.PanelEx1.Controls.Add(this.rdbPagadora);
            this.PanelEx1.Controls.Add(this.rdbFecha);
            this.PanelEx1.Controls.Add(this.txtIdPagadora);
            this.PanelEx1.Controls.Add(this.txtDescripcion);
            this.PanelEx1.Controls.Add(this.btnBuscarPagadora);
            this.PanelEx1.Controls.Add(this.dtFechaFilter);
            this.PanelEx1.Size = new System.Drawing.Size(966, 80);
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
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscarPagadora, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtIdPagadora, 0);
            this.PanelEx1.Controls.SetChildIndex(this.rdbFecha, 0);
            this.PanelEx1.Controls.SetChildIndex(this.rdbPagadora, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(634, 18);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(557, 18);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(927, 17);
            this.TextBoxX1.Size = new System.Drawing.Size(27, 20);
            this.TextBoxX1.Visible = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(887, 17);
            this.LabelX1.Size = new System.Drawing.Size(34, 23);
            this.LabelX1.Visible = false;
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Location = new System.Drawing.Point(0, 125);
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(790, 126);
            // 
            // rdbPagadora
            // 
            this.rdbPagadora.AutoSize = true;
            this.rdbPagadora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbPagadora.Location = new System.Drawing.Point(33, 45);
            this.rdbPagadora.Name = "rdbPagadora";
            this.rdbPagadora.Size = new System.Drawing.Size(71, 17);
            this.rdbPagadora.TabIndex = 21;
            this.rdbPagadora.Text = "Pagadora";
            this.rdbPagadora.UseVisualStyleBackColor = true;
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Checked = true;
            this.rdbFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbFecha.Location = new System.Drawing.Point(33, 20);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(55, 17);
            this.rdbFecha.TabIndex = 20;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // txtIdPagadora
            // 
            // 
            // 
            // 
            this.txtIdPagadora.Border.Class = "TextBoxBorder";
            this.txtIdPagadora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdPagadora.Location = new System.Drawing.Point(168, 41);
            this.txtIdPagadora.Name = "txtIdPagadora";
            this.txtIdPagadora.ReadOnly = true;
            this.txtIdPagadora.Size = new System.Drawing.Size(100, 20);
            this.txtIdPagadora.TabIndex = 18;
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Location = new System.Drawing.Point(270, 41);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(244, 20);
            this.txtDescripcion.TabIndex = 19;
            // 
            // btnBuscarPagadora
            // 
            this.btnBuscarPagadora.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarPagadora.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscarPagadora.Location = new System.Drawing.Point(138, 39);
            this.btnBuscarPagadora.Name = "btnBuscarPagadora";
            this.btnBuscarPagadora.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarPagadora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarPagadora.TabIndex = 17;
            this.btnBuscarPagadora.Text = "...";
            this.btnBuscarPagadora.Click += new System.EventHandler(this.btnBuscarPagadora_Click);
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
            this.dtFechaFilter.IsPopupCalendarOpen = false;
            this.dtFechaFilter.Location = new System.Drawing.Point(138, 17);
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
            this.dtFechaFilter.MonthCalendar.DisplayMonth = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
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
            this.dtFechaFilter.Size = new System.Drawing.Size(95, 20);
            this.dtFechaFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaFilter.TabIndex = 16;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLote,
            this.cItem,
            this.cNumDoc,
            this.IdSocio_Dsc,
            this.DireccionSocio,
            this.RucAceptante,
            this.IdMoneda_tt_Dsc,
            this.nvNegociable,
            this.dtRegistro,
            this.IdPagadora,
            this.IdPagadora_Dsc,
            this.TipoCartera,
            this.sdVencimiento,
            this.FlgEnviar,
            this.nFondoGarantia,
            this.Distrito,
            this.nvNegociableInteres});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatos.Location = new System.Drawing.Point(0, 154);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 10;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatos.Size = new System.Drawing.Size(966, 309);
            this.dgvDatos.TabIndex = 23;
            this.dgvDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDatos_CurrentCellDirtyStateChanged);
            // 
            // btnGenerarDocumento
            // 
            this.btnGenerarDocumento.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnGenerarDocumento.Image = global::EfideFactoring.Properties.Resources.previo;
            this.btnGenerarDocumento.Name = "btnGenerarDocumento";
            this.btnGenerarDocumento.SubItemsExpandWidth = 14;
            this.btnGenerarDocumento.Text = "Generar Planilla";
            this.btnGenerarDocumento.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "IdLote";
            this.IdLote.HeaderText = "IdPagare";
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            this.IdLote.Width = 80;
            // 
            // cItem
            // 
            this.cItem.DataPropertyName = "cItem";
            this.cItem.HeaderText = "cItem";
            this.cItem.Name = "cItem";
            this.cItem.Visible = false;
            // 
            // cNumDoc
            // 
            this.cNumDoc.DataPropertyName = "cNumDoc";
            this.cNumDoc.HeaderText = "# Documento";
            this.cNumDoc.Name = "cNumDoc";
            this.cNumDoc.ReadOnly = true;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 150;
            // 
            // DireccionSocio
            // 
            this.DireccionSocio.DataPropertyName = "DireccionSocio";
            this.DireccionSocio.HeaderText = "DireccionSocio";
            this.DireccionSocio.Name = "DireccionSocio";
            this.DireccionSocio.Visible = false;
            // 
            // RucAceptante
            // 
            this.RucAceptante.DataPropertyName = "RucAceptante";
            this.RucAceptante.HeaderText = "RucAceptante";
            this.RucAceptante.Name = "RucAceptante";
            this.RucAceptante.Visible = false;
            // 
            // IdMoneda_tt_Dsc
            // 
            this.IdMoneda_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.HeaderText = "Mon.";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            this.IdMoneda_tt_Dsc.Width = 60;
            // 
            // nvNegociable
            // 
            this.nvNegociable.DataPropertyName = "nvNegociable";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.nvNegociable.DefaultCellStyle = dataGridViewCellStyle1;
            this.nvNegociable.HeaderText = "Importe";
            this.nvNegociable.Name = "nvNegociable";
            this.nvNegociable.ReadOnly = true;
            this.nvNegociable.Width = 80;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dtRegistro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtRegistro.HeaderText = "Emisi�n";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            this.dtRegistro.Width = 80;
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "IdPagadora";
            this.IdPagadora.Name = "IdPagadora";
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
            // TipoCartera
            // 
            this.TipoCartera.DataPropertyName = "TipoCartera";
            this.TipoCartera.HeaderText = "TipoCartera";
            this.TipoCartera.Name = "TipoCartera";
            this.TipoCartera.Visible = false;
            // 
            // sdVencimiento
            // 
            this.sdVencimiento.DataPropertyName = "sdVencimiento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.sdVencimiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.sdVencimiento.HeaderText = "Vencimiento";
            this.sdVencimiento.Name = "sdVencimiento";
            this.sdVencimiento.ReadOnly = true;
            this.sdVencimiento.Width = 80;
            // 
            // FlgEnviar
            // 
            this.FlgEnviar.DataPropertyName = "FlgEnviar";
            this.FlgEnviar.HeaderText = "";
            this.FlgEnviar.Name = "FlgEnviar";
            this.FlgEnviar.Width = 40;
            // 
            // nFondoGarantia
            // 
            this.nFondoGarantia.DataPropertyName = "nFondoGarantia";
            this.nFondoGarantia.HeaderText = "nFondoGarantia";
            this.nFondoGarantia.Name = "nFondoGarantia";
            this.nFondoGarantia.Visible = false;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.Visible = false;
            // 
            // nvNegociableInteres
            // 
            this.nvNegociableInteres.DataPropertyName = "nvNegociableInteres";
            this.nvNegociableInteres.HeaderText = "nvNegociableInteres";
            this.nvNegociableInteres.Name = "nvNegociableInteres";
            this.nvNegociableInteres.Visible = false;
            // 
            // frmEnvioVencimientoTituloValor
            // 
            this.ClientSize = new System.Drawing.Size(966, 475);
            this.Controls.Add(this.dgvDatos);
            this.DoubleBuffered = true;
            this.Name = "frmEnvioVencimientoTituloValor";
            this.Text = "Env�o de Notificaci�n  a la Fecha de Vencimiento";
            this.Load += new System.EventHandler(this.frmEnvioVencimientoTituloValor_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvDatos, 0);
            this.PanelEx1.ResumeLayout(false);
            this.PanelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPagadora;
        private System.Windows.Forms.RadioButton rdbFecha;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdPagadora;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.ButtonX btnBuscarPagadora;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaFilter;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDatos;
        private DevComponents.DotNetBar.ButtonItem btnGenerarDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn RucAceptante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvNegociable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCartera;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdVencimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FlgEnviar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFondoGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvNegociableInteres;
    }
}