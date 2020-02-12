namespace EfideFactoring.Formula.Movimiento
{
    partial class frmMntMovimientoDato
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtFechaMovimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtRazonSocial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNroDoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboIdMoneda_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtImporte = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtComentario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBusquedaSocio = new DevComponents.DotNetBar.ButtonX();
            this.cboTipoDocumento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.cboTipoDocumento);
            this.grpDato.Controls.Add(this.btnBusquedaSocio);
            this.grpDato.Controls.Add(this.txtComentario);
            this.grpDato.Controls.Add(this.txtImporte);
            this.grpDato.Controls.Add(this.cboIdMoneda_tt);
            this.grpDato.Controls.Add(this.txtNroDoc);
            this.grpDato.Controls.Add(this.txtRazonSocial);
            this.grpDato.Controls.Add(this.labelX7);
            this.grpDato.Controls.Add(this.labelX6);
            this.grpDato.Controls.Add(this.labelX5);
            this.grpDato.Controls.Add(this.labelX4);
            this.grpDato.Controls.Add(this.dtFechaMovimiento);
            this.grpDato.Controls.Add(this.labelX3);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Size = new System.Drawing.Size(533, 326);
            // 
            // 
            // 
            this.grpDato.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpDato.Style.BackColorGradientAngle = 90;
            this.grpDato.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpDato.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderBottomWidth = 1;
            this.grpDato.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpDato.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderLeftWidth = 1;
            this.grpDato.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderRightWidth = 1;
            this.grpDato.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderTopWidth = 1;
            this.grpDato.Style.CornerDiameter = 4;
            this.grpDato.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpDato.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpDato.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpDato.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpDato.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpDato.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(452, 347);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(361, 347);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(29, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(124, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nombre/Razón Social";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(29, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(124, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tipo Documento";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(29, 68);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(124, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Nro. Documento";
            // 
            // dtFechaMovimiento
            // 
            // 
            // 
            // 
            this.dtFechaMovimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaMovimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaMovimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaMovimiento.ButtonDropDown.Visible = true;
            this.dtFechaMovimiento.IsPopupCalendarOpen = false;
            this.dtFechaMovimiento.Location = new System.Drawing.Point(175, 94);
            // 
            // 
            // 
            this.dtFechaMovimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaMovimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaMovimiento.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaMovimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaMovimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaMovimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaMovimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaMovimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaMovimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaMovimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaMovimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaMovimiento.MonthCalendar.DisplayMonth = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            this.dtFechaMovimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtFechaMovimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaMovimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaMovimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaMovimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaMovimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaMovimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaMovimiento.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaMovimiento.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaMovimiento.Name = "dtFechaMovimiento";
            this.dtFechaMovimiento.Size = new System.Drawing.Size(110, 20);
            this.dtFechaMovimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaMovimiento.TabIndex = 3;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(29, 91);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(124, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "Fecha Depósito";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(29, 115);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(124, 23);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "Moneda";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(29, 139);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(124, 23);
            this.labelX6.TabIndex = 6;
            this.labelX6.Text = "Importe";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(29, 163);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(125, 23);
            this.labelX7.TabIndex = 7;
            this.labelX7.Text = "Comentario/Observación";
            // 
            // txtRazonSocial
            // 
            // 
            // 
            // 
            this.txtRazonSocial.Border.Class = "TextBoxBorder";
            this.txtRazonSocial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRazonSocial.Location = new System.Drawing.Point(175, 24);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(300, 20);
            this.txtRazonSocial.TabIndex = 8;
            // 
            // txtNroDoc
            // 
            // 
            // 
            // 
            this.txtNroDoc.Border.Class = "TextBoxBorder";
            this.txtNroDoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNroDoc.Location = new System.Drawing.Point(175, 71);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(110, 20);
            this.txtNroDoc.TabIndex = 10;
            // 
            // cboIdMoneda_tt
            // 
            this.cboIdMoneda_tt.DisplayMember = "Text";
            this.cboIdMoneda_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdMoneda_tt.FormattingEnabled = true;
            this.cboIdMoneda_tt.ItemHeight = 14;
            this.cboIdMoneda_tt.Location = new System.Drawing.Point(175, 118);
            this.cboIdMoneda_tt.Name = "cboIdMoneda_tt";
            this.cboIdMoneda_tt.Size = new System.Drawing.Size(110, 20);
            this.cboIdMoneda_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdMoneda_tt.TabIndex = 11;
            // 
            // txtImporte
            // 
            // 
            // 
            // 
            this.txtImporte.Border.Class = "TextBoxBorder";
            this.txtImporte.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtImporte.Location = new System.Drawing.Point(175, 142);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(110, 20);
            this.txtImporte.TabIndex = 12;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // txtComentario
            // 
            // 
            // 
            // 
            this.txtComentario.Border.Class = "TextBoxBorder";
            this.txtComentario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComentario.Location = new System.Drawing.Point(175, 166);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(300, 141);
            this.txtComentario.TabIndex = 13;
            // 
            // btnBusquedaSocio
            // 
            this.btnBusquedaSocio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBusquedaSocio.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBusquedaSocio.Location = new System.Drawing.Point(481, 24);
            this.btnBusquedaSocio.Name = "btnBusquedaSocio";
            this.btnBusquedaSocio.Size = new System.Drawing.Size(31, 20);
            this.btnBusquedaSocio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBusquedaSocio.TabIndex = 14;
            this.btnBusquedaSocio.Text = "...";
            this.btnBusquedaSocio.Click += new System.EventHandler(this.btnBusquedaSocio_Click);
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DisplayMember = "Text";
            this.cboTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.ItemHeight = 14;
            this.cboTipoDocumento.Location = new System.Drawing.Point(175, 47);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(110, 20);
            this.cboTipoDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoDocumento.TabIndex = 15;
            // 
            // frmMntMovimientoDato
            // 
            this.ClientSize = new System.Drawing.Size(541, 383);
            this.DoubleBuffered = true;
            this.Name = "frmMntMovimientoDato";
            this.Text = "Registrar Nuevo Depósito";
            this.Load += new System.EventHandler(this.frmMntMovimientoDato_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaMovimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtComentario;
        private DevComponents.DotNetBar.Controls.TextBoxX txtImporte;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdMoneda_tt;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNroDoc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRazonSocial;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaMovimiento;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnBusquedaSocio;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoDocumento;
    }
}