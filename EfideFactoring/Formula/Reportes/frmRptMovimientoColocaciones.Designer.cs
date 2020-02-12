namespace EfideFactoring.Formula.Reportes
{
    partial class frmRptMovimientoColocaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptMovimientoColocaciones));
            this.btnProcesar = new DevComponents.DotNetBar.ButtonX();
            this.dtFechaCorte = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnGenerarCorte = new DevComponents.DotNetBar.ButtonX();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCorte)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.btnGenerarCorte);
            this.grpDato.Controls.Add(this.btnProcesar);
            this.grpDato.Controls.Add(this.dtFechaCorte);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Size = new System.Drawing.Size(389, 93);
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
            this.btnCancelar.Location = new System.Drawing.Point(308, 114);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(217, 114);
            this.btnAceptar.Visible = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProcesar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.Image")));
            this.btnProcesar.Location = new System.Drawing.Point(248, 31);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(127, 23);
            this.btnProcesar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Generar Preliminar";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dtFechaCorte
            // 
            // 
            // 
            // 
            this.dtFechaCorte.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaCorte.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCorte.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaCorte.ButtonDropDown.Visible = true;
            this.dtFechaCorte.IsPopupCalendarOpen = false;
            this.dtFechaCorte.Location = new System.Drawing.Point(104, 31);
            // 
            // 
            // 
            this.dtFechaCorte.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaCorte.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCorte.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaCorte.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaCorte.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaCorte.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaCorte.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaCorte.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaCorte.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaCorte.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaCorte.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCorte.MonthCalendar.DisplayMonth = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this.dtFechaCorte.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtFechaCorte.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaCorte.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaCorte.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaCorte.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaCorte.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaCorte.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCorte.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaCorte.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaCorte.Name = "dtFechaCorte";
            this.dtFechaCorte.Size = new System.Drawing.Size(133, 20);
            this.dtFechaCorte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaCorte.TabIndex = 4;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX1.Location = new System.Drawing.Point(23, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Fecha Corte";
            // 
            // btnGenerarCorte
            // 
            this.btnGenerarCorte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerarCorte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGenerarCorte.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarCorte.Image")));
            this.btnGenerarCorte.Location = new System.Drawing.Point(248, 2);
            this.btnGenerarCorte.Name = "btnGenerarCorte";
            this.btnGenerarCorte.Size = new System.Drawing.Size(127, 23);
            this.btnGenerarCorte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGenerarCorte.TabIndex = 6;
            this.btnGenerarCorte.Text = "Generar Definitivo";
            this.btnGenerarCorte.Click += new System.EventHandler(this.btnGenerarCorte_Click);
            // 
            // frmRptMovimientoColocaciones
            // 
            this.ClientSize = new System.Drawing.Size(397, 150);
            this.DoubleBuffered = true;
            this.Name = "frmRptMovimientoColocaciones";
            this.Text = "Mov. Colocaciones y Captaciones";
            this.Load += new System.EventHandler(this.frmRptMovimientoColocaciones_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCorte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnGenerarCorte;
        private DevComponents.DotNetBar.ButtonX btnProcesar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaCorte;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}