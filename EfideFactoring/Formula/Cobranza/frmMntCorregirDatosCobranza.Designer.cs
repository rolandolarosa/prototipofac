namespace EfideFactoring.Formula.Cobranza
{
    partial class frmMntCorregirDatosCobranza
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
            this.dtVencimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtnImportOriginal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblSocio = new DevComponents.DotNetBar.LabelX();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVencimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.dtVencimiento);
            this.grpDato.Controls.Add(this.txtnImportOriginal);
            this.grpDato.Controls.Add(this.txtDocumento);
            this.grpDato.Controls.Add(this.txtSocio);
            this.grpDato.Controls.Add(this.labelX3);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.lblSocio);
            this.grpDato.Size = new System.Drawing.Size(467, 154);
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
            this.btnCancelar.Location = new System.Drawing.Point(386, 175);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(295, 175);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtVencimiento
            // 
            // 
            // 
            // 
            this.dtVencimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtVencimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtVencimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtVencimiento.ButtonDropDown.Visible = true;
            this.dtVencimiento.IsPopupCalendarOpen = false;
            this.dtVencimiento.Location = new System.Drawing.Point(117, 76);
            // 
            // 
            // 
            this.dtVencimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtVencimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtVencimiento.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtVencimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtVencimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtVencimiento.MonthCalendar.DisplayMonth = new System.DateTime(2019, 3, 1, 0, 0, 0, 0);
            this.dtVencimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtVencimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtVencimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtVencimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtVencimiento.MonthCalendar.TodayButtonVisible = true;
            this.dtVencimiento.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtVencimiento.Name = "dtVencimiento";
            this.dtVencimiento.Size = new System.Drawing.Size(114, 20);
            this.dtVencimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtVencimiento.TabIndex = 16;
            // 
            // txtnImportOriginal
            // 
            // 
            // 
            // 
            this.txtnImportOriginal.Border.Class = "TextBoxBorder";
            this.txtnImportOriginal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnImportOriginal.Location = new System.Drawing.Point(117, 102);
            this.txtnImportOriginal.Name = "txtnImportOriginal";
            this.txtnImportOriginal.Size = new System.Drawing.Size(114, 20);
            this.txtnImportOriginal.TabIndex = 15;
            this.txtnImportOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDocumento
            // 
            // 
            // 
            // 
            this.txtDocumento.Border.Class = "TextBoxBorder";
            this.txtDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocumento.Location = new System.Drawing.Point(117, 50);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(183, 20);
            this.txtDocumento.TabIndex = 14;
            // 
            // txtSocio
            // 
            // 
            // 
            // 
            this.txtSocio.Border.Class = "TextBoxBorder";
            this.txtSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSocio.Location = new System.Drawing.Point(117, 24);
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.ReadOnly = true;
            this.txtSocio.Size = new System.Drawing.Size(320, 20);
            this.txtSocio.TabIndex = 13;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(25, 99);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(86, 23);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "Importe de Pago";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(24, 73);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(86, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Fecha de Pago";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(24, 47);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(86, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Documento";
            // 
            // lblSocio
            // 
            this.lblSocio.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSocio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSocio.Location = new System.Drawing.Point(24, 24);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(55, 23);
            this.lblSocio.TabIndex = 9;
            this.lblSocio.Text = "Socio";
            // 
            // frmMntCorregirDatosCobranza
            // 
            this.ClientSize = new System.Drawing.Size(475, 211);
            this.DoubleBuffered = true;
            this.Name = "frmMntCorregirDatosCobranza";
            this.Text = "Corregir Datos del Documento";
            this.Load += new System.EventHandler(this.frmMntCorregirDatosCobranza_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtVencimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtVencimiento;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnImportOriginal;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDocumento;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSocio;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblSocio;
    }
}