namespace EfideFactoring.Formula.Movimiento
{
    partial class frmMntMovimientoDatoEgreso
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
            this.txtComentario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtImporte = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboIdMoneda_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dtFechaMovimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.txtComentario);
            this.grpDato.Controls.Add(this.txtImporte);
            this.grpDato.Controls.Add(this.cboIdMoneda_tt);
            this.grpDato.Controls.Add(this.labelX7);
            this.grpDato.Controls.Add(this.labelX6);
            this.grpDato.Controls.Add(this.labelX5);
            this.grpDato.Controls.Add(this.labelX4);
            this.grpDato.Controls.Add(this.dtFechaMovimiento);
            this.grpDato.Size = new System.Drawing.Size(494, 258);
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
            this.btnCancelar.Location = new System.Drawing.Point(413, 279);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(322, 279);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtComentario
            // 
            // 
            // 
            // 
            this.txtComentario.Border.Class = "TextBoxBorder";
            this.txtComentario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComentario.Location = new System.Drawing.Point(166, 97);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(300, 141);
            this.txtComentario.TabIndex = 21;
            // 
            // txtImporte
            // 
            // 
            // 
            // 
            this.txtImporte.Border.Class = "TextBoxBorder";
            this.txtImporte.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtImporte.Location = new System.Drawing.Point(166, 73);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(110, 20);
            this.txtImporte.TabIndex = 20;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // cboIdMoneda_tt
            // 
            this.cboIdMoneda_tt.DisplayMember = "Text";
            this.cboIdMoneda_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdMoneda_tt.FormattingEnabled = true;
            this.cboIdMoneda_tt.ItemHeight = 14;
            this.cboIdMoneda_tt.Location = new System.Drawing.Point(166, 49);
            this.cboIdMoneda_tt.Name = "cboIdMoneda_tt";
            this.cboIdMoneda_tt.Size = new System.Drawing.Size(110, 20);
            this.cboIdMoneda_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdMoneda_tt.TabIndex = 19;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(20, 94);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(125, 23);
            this.labelX7.TabIndex = 18;
            this.labelX7.Text = "Comentario/Observación";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(20, 70);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(124, 23);
            this.labelX6.TabIndex = 17;
            this.labelX6.Text = "Importe";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(20, 46);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(124, 23);
            this.labelX5.TabIndex = 16;
            this.labelX5.Text = "Moneda";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(20, 22);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(124, 23);
            this.labelX4.TabIndex = 15;
            this.labelX4.Text = "Fecha Movimiento";
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
            this.dtFechaMovimiento.Location = new System.Drawing.Point(166, 25);
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
            this.dtFechaMovimiento.TabIndex = 14;
            // 
            // frmMntMovimientoDatoEgreso
            // 
            this.ClientSize = new System.Drawing.Size(502, 315);
            this.DoubleBuffered = true;
            this.Name = "frmMntMovimientoDatoEgreso";
            this.Text = "Registrar Movimiento";
            this.Load += new System.EventHandler(this.frmMntMovimientoDatoEgreso_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaMovimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtComentario;
        private DevComponents.DotNetBar.Controls.TextBoxX txtImporte;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdMoneda_tt;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaMovimiento;
    }
}