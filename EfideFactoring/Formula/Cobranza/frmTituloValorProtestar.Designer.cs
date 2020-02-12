namespace EfideFactoring.Formula.Cobranza
{
    partial class frmTituloValorProtestar
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
            this.dtFechaFiltro = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dgvCobranzaDetalle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvNegociable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcTelefonoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcDireccionSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcTelefonoPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcDireccionPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobranzaDetalle)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(1300, 40);
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
            this.btnNuevo.Text = "&Generar Reporte";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.PanelEx1.Controls.Add(this.dtFechaFiltro);
            this.PanelEx1.Size = new System.Drawing.Size(1300, 54);
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
            this.PanelEx1.Controls.SetChildIndex(this.dtFechaFiltro, 0);
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
            this.TextBoxX1.Location = new System.Drawing.Point(672, 6);
            this.TextBoxX1.Size = new System.Drawing.Size(28, 20);
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
            this.lblGrilla.Text = "Datos";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(1124, 97);
            // 
            // dtFechaFiltro
            // 
            // 
            // 
            // 
            this.dtFechaFiltro.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaFiltro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFiltro.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaFiltro.ButtonDropDown.Visible = true;
            this.dtFechaFiltro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaFiltro.IsPopupCalendarOpen = false;
            this.dtFechaFiltro.Location = new System.Drawing.Point(79, 16);
            // 
            // 
            // 
            this.dtFechaFiltro.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaFiltro.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFiltro.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaFiltro.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaFiltro.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaFiltro.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaFiltro.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaFiltro.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaFiltro.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaFiltro.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaFiltro.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFiltro.MonthCalendar.DisplayMonth = new System.DateTime(2014, 10, 1, 0, 0, 0, 0);
            this.dtFechaFiltro.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaFiltro.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaFiltro.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaFiltro.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaFiltro.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaFiltro.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFiltro.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaFiltro.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaFiltro.Name = "dtFechaFiltro";
            this.dtFechaFiltro.Size = new System.Drawing.Size(108, 20);
            this.dtFechaFiltro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaFiltro.TabIndex = 8;
            // 
            // dgvCobranzaDetalle
            // 
            this.dgvCobranzaDetalle.AllowUserToAddRows = false;
            this.dgvCobranzaDetalle.AllowUserToDeleteRows = false;
            this.dgvCobranzaDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCobranzaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobranzaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNumDoc,
            this.sdVencimiento,
            this.Dias,
            this.IdMoneda_tt_Dsc,
            this.nvNegociable,
            this.IdSocio_Dsc,
            this.vcTelefonoSocio,
            this.vcDireccionSocio,
            this.vcPagadora,
            this.vcContacto,
            this.vcTelefonoPagadora,
            this.vcDireccionPagadora});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCobranzaDetalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCobranzaDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCobranzaDetalle.Location = new System.Drawing.Point(0, 125);
            this.dgvCobranzaDetalle.Name = "dgvCobranzaDetalle";
            this.dgvCobranzaDetalle.ReadOnly = true;
            this.dgvCobranzaDetalle.RowHeadersWidth = 10;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCobranzaDetalle.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCobranzaDetalle.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCobranzaDetalle.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCobranzaDetalle.Size = new System.Drawing.Size(1300, 277);
            this.dgvCobranzaDetalle.TabIndex = 22;
            // 
            // cNumDoc
            // 
            this.cNumDoc.DataPropertyName = "cNumDoc";
            this.cNumDoc.HeaderText = "Nro. Documento";
            this.cNumDoc.Name = "cNumDoc";
            this.cNumDoc.ReadOnly = true;
            this.cNumDoc.Width = 80;
            // 
            // sdVencimiento
            // 
            this.sdVencimiento.DataPropertyName = "sdVencimiento";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.sdVencimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.sdVencimiento.HeaderText = "Fecha Vencimiento";
            this.sdVencimiento.Name = "sdVencimiento";
            this.sdVencimiento.ReadOnly = true;
            this.sdVencimiento.Width = 80;
            // 
            // Dias
            // 
            this.Dias.DataPropertyName = "Dias";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Dias.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            this.Dias.Width = 50;
            // 
            // IdMoneda_tt_Dsc
            // 
            this.IdMoneda_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.HeaderText = "Mon";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            this.IdMoneda_tt_Dsc.Width = 50;
            // 
            // nvNegociable
            // 
            this.nvNegociable.DataPropertyName = "nvNegociable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.nvNegociable.DefaultCellStyle = dataGridViewCellStyle3;
            this.nvNegociable.HeaderText = "Importe";
            this.nvNegociable.Name = "nvNegociable";
            this.nvNegociable.ReadOnly = true;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 150;
            // 
            // vcTelefonoSocio
            // 
            this.vcTelefonoSocio.DataPropertyName = "vcTelefonoSocio";
            this.vcTelefonoSocio.HeaderText = "Teléfono";
            this.vcTelefonoSocio.Name = "vcTelefonoSocio";
            this.vcTelefonoSocio.ReadOnly = true;
            // 
            // vcDireccionSocio
            // 
            this.vcDireccionSocio.DataPropertyName = "vcDireccionSocio";
            this.vcDireccionSocio.HeaderText = "Dirección";
            this.vcDireccionSocio.Name = "vcDireccionSocio";
            this.vcDireccionSocio.ReadOnly = true;
            // 
            // vcPagadora
            // 
            this.vcPagadora.DataPropertyName = "vcPagadora";
            this.vcPagadora.HeaderText = "Pagadora";
            this.vcPagadora.Name = "vcPagadora";
            this.vcPagadora.ReadOnly = true;
            this.vcPagadora.Width = 150;
            // 
            // vcContacto
            // 
            this.vcContacto.DataPropertyName = "vcContacto";
            this.vcContacto.HeaderText = "Contacto";
            this.vcContacto.Name = "vcContacto";
            this.vcContacto.ReadOnly = true;
            this.vcContacto.Width = 150;
            // 
            // vcTelefonoPagadora
            // 
            this.vcTelefonoPagadora.DataPropertyName = "vcTelefonoPagadora";
            this.vcTelefonoPagadora.HeaderText = "Teléfono";
            this.vcTelefonoPagadora.Name = "vcTelefonoPagadora";
            this.vcTelefonoPagadora.ReadOnly = true;
            // 
            // vcDireccionPagadora
            // 
            this.vcDireccionPagadora.DataPropertyName = "vcDireccionPagadora";
            this.vcDireccionPagadora.HeaderText = "Dirección";
            this.vcDireccionPagadora.Name = "vcDireccionPagadora";
            this.vcDireccionPagadora.ReadOnly = true;
            // 
            // frmTituloValorProtestar
            // 
            this.ClientSize = new System.Drawing.Size(1300, 414);
            this.Controls.Add(this.dgvCobranzaDetalle);
            this.DoubleBuffered = true;
            this.Name = "frmTituloValorProtestar";
            this.Text = "Relación de Titulo Valor a Protestar";
            this.Load += new System.EventHandler(this.frmTituloValorProtestar_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvCobranzaDetalle, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobranzaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaFiltro;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCobranzaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvNegociable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcTelefonoSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcDireccionSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcTelefonoPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcDireccionPagadora;
    }
}