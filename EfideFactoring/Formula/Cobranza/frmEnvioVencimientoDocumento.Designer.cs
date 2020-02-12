namespace EfideFactoring.Formula.Cobranza
{
    partial class frmEnvioVencimientoDocumento
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
            this.dgvDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dtFechaFilter = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtIdPagadora = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBuscarPagadora = new DevComponents.DotNetBar.ButtonX();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbPagadora = new System.Windows.Forms.RadioButton();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RucAceptante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvNegociable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCartera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlgEnviar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
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
            this.btnNuevo.Text = "&Generar";
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
            this.PanelEx1.Controls.Add(this.txtDescripcion);
            this.PanelEx1.Controls.Add(this.btnBuscarPagadora);
            this.PanelEx1.Controls.Add(this.dtFechaFilter);
            this.PanelEx1.Controls.Add(this.txtIdPagadora);
            this.PanelEx1.Size = new System.Drawing.Size(966, 80);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.Controls.SetChildIndex(this.txtIdPagadora, 0);
            this.PanelEx1.Controls.SetChildIndex(this.LabelX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.TextBoxX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.dtFechaFilter, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscarPagadora, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.PanelEx1.Controls.SetChildIndex(this.rdbFecha, 0);
            this.PanelEx1.Controls.SetChildIndex(this.rdbPagadora, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(632, 20);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(555, 20);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(882, 6);
            this.TextBoxX1.Size = new System.Drawing.Size(26, 20);
            this.TextBoxX1.Visible = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(863, 38);
            this.LabelX1.Size = new System.Drawing.Size(45, 23);
            this.LabelX1.Text = "Fecha";
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
            this.IdMoneda_tt,
            this.nvNegociable,
            this.dtRegistro,
            this.IdPagadora_Dsc,
            this.TipoCartera,
            this.sdVencimiento,
            this.FlgEnviar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatos.Location = new System.Drawing.Point(-28, 167);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 10;
            this.dgvDatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDatos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatos.Size = new System.Drawing.Size(994, 309);
            this.dgvDatos.TabIndex = 22;
            this.dgvDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDatos_CurrentCellDirtyStateChanged);
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
            this.dtFechaFilter.Location = new System.Drawing.Point(141, 17);
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
            this.dtFechaFilter.TabIndex = 7;
            // 
            // txtIdPagadora
            // 
            // 
            // 
            // 
            this.txtIdPagadora.Border.Class = "TextBoxBorder";
            this.txtIdPagadora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdPagadora.Location = new System.Drawing.Point(171, 41);
            this.txtIdPagadora.Name = "txtIdPagadora";
            this.txtIdPagadora.ReadOnly = true;
            this.txtIdPagadora.Size = new System.Drawing.Size(100, 20);
            this.txtIdPagadora.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Location = new System.Drawing.Point(273, 41);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(244, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // btnBuscarPagadora
            // 
            this.btnBuscarPagadora.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarPagadora.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscarPagadora.Location = new System.Drawing.Point(141, 39);
            this.btnBuscarPagadora.Name = "btnBuscarPagadora";
            this.btnBuscarPagadora.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarPagadora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarPagadora.TabIndex = 11;
            this.btnBuscarPagadora.Text = "...";
            this.btnBuscarPagadora.Click += new System.EventHandler(this.btnBuscarPagadora_Click);
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Checked = true;
            this.rdbFecha.Location = new System.Drawing.Point(36, 20);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(55, 17);
            this.rdbFecha.TabIndex = 14;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // rdbPagadora
            // 
            this.rdbPagadora.AutoSize = true;
            this.rdbPagadora.Location = new System.Drawing.Point(36, 45);
            this.rdbPagadora.Name = "rdbPagadora";
            this.rdbPagadora.Size = new System.Drawing.Size(71, 17);
            this.rdbPagadora.TabIndex = 15;
            this.rdbPagadora.Text = "Pagadora";
            this.rdbPagadora.UseVisualStyleBackColor = true;
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
            // IdMoneda_tt
            // 
            this.IdMoneda_tt.DataPropertyName = "IdMoneda_tt";
            this.IdMoneda_tt.HeaderText = "IdMoneda_tt";
            this.IdMoneda_tt.Name = "IdMoneda_tt";
            this.IdMoneda_tt.Visible = false;
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
            this.dtRegistro.HeaderText = "Emisión";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            this.dtRegistro.Width = 80;
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
            // frmEnvioVencimientoDocumento
            // 
            this.ClientSize = new System.Drawing.Size(966, 475);
            this.Controls.Add(this.dgvDatos);
            this.DoubleBuffered = true;
            this.Name = "frmEnvioVencimientoDocumento";
            this.Text = "+";
            this.Load += new System.EventHandler(this.frmEnvioVencimientoDocumento_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvDatos, 0);
            this.PanelEx1.ResumeLayout(false);
            this.PanelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDatos;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaFilter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdPagadora;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.ButtonX btnBuscarPagadora;
        private System.Windows.Forms.RadioButton rdbPagadora;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn RucAceptante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvNegociable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCartera;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdVencimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FlgEnviar;
    }
}