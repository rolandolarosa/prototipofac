namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmGestionDato
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
            this.rbtnCompromiso = new System.Windows.Forms.RadioButton();
            this.gpCompromiso = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtComentario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtFechaCompromiso = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cboIdTipoCompromiso_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboIdAccion_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.rbtnNoInteresado = new System.Windows.Forms.RadioButton();
            this.gpNoInteresado = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtComentarioNI = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cboIdMotivo_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtIdEntidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEntidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBuscarSocioCandidato = new DevComponents.DotNetBar.ButtonX();
            this.grpDato.SuspendLayout();
            this.gpCompromiso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCompromiso)).BeginInit();
            this.gpNoInteresado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.btnBuscarSocioCandidato);
            this.grpDato.Controls.Add(this.txtEntidad);
            this.grpDato.Controls.Add(this.txtIdEntidad);
            this.grpDato.Controls.Add(this.labelX7);
            this.grpDato.Controls.Add(this.gpNoInteresado);
            this.grpDato.Controls.Add(this.rbtnNoInteresado);
            this.grpDato.Controls.Add(this.gpCompromiso);
            this.grpDato.Controls.Add(this.rbtnCompromiso);
            this.grpDato.Size = new System.Drawing.Size(717, 549);
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
            this.btnCancelar.Location = new System.Drawing.Point(636, 570);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(545, 570);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbtnCompromiso
            // 
            this.rbtnCompromiso.AutoSize = true;
            this.rbtnCompromiso.BackColor = System.Drawing.Color.Transparent;
            this.rbtnCompromiso.Location = new System.Drawing.Point(17, 68);
            this.rbtnCompromiso.Name = "rbtnCompromiso";
            this.rbtnCompromiso.Size = new System.Drawing.Size(82, 17);
            this.rbtnCompromiso.TabIndex = 0;
            this.rbtnCompromiso.TabStop = true;
            this.rbtnCompromiso.Text = "Compromiso";
            this.rbtnCompromiso.UseVisualStyleBackColor = false;
            this.rbtnCompromiso.CheckedChanged += new System.EventHandler(this.rbtnCompromiso_CheckedChanged);
            // 
            // gpCompromiso
            // 
            this.gpCompromiso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpCompromiso.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpCompromiso.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpCompromiso.Controls.Add(this.txtComentario);
            this.gpCompromiso.Controls.Add(this.dtFechaCompromiso);
            this.gpCompromiso.Controls.Add(this.cboIdTipoCompromiso_tt);
            this.gpCompromiso.Controls.Add(this.cboIdAccion_tt);
            this.gpCompromiso.Controls.Add(this.labelX4);
            this.gpCompromiso.Controls.Add(this.labelX3);
            this.gpCompromiso.Controls.Add(this.labelX2);
            this.gpCompromiso.Controls.Add(this.labelX1);
            this.gpCompromiso.Location = new System.Drawing.Point(17, 104);
            this.gpCompromiso.Name = "gpCompromiso";
            this.gpCompromiso.Size = new System.Drawing.Size(678, 209);
            // 
            // 
            // 
            this.gpCompromiso.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpCompromiso.Style.BackColorGradientAngle = 90;
            this.gpCompromiso.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpCompromiso.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCompromiso.Style.BorderBottomWidth = 1;
            this.gpCompromiso.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpCompromiso.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCompromiso.Style.BorderLeftWidth = 1;
            this.gpCompromiso.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCompromiso.Style.BorderRightWidth = 1;
            this.gpCompromiso.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCompromiso.Style.BorderTopWidth = 1;
            this.gpCompromiso.Style.CornerDiameter = 4;
            this.gpCompromiso.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpCompromiso.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpCompromiso.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpCompromiso.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpCompromiso.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpCompromiso.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpCompromiso.TabIndex = 1;
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtComentario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComentario.Location = new System.Drawing.Point(154, 111);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(460, 63);
            this.txtComentario.TabIndex = 7;
            // 
            // dtFechaCompromiso
            // 
            // 
            // 
            // 
            this.dtFechaCompromiso.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaCompromiso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCompromiso.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaCompromiso.ButtonDropDown.Visible = true;
            this.dtFechaCompromiso.IsPopupCalendarOpen = false;
            this.dtFechaCompromiso.Location = new System.Drawing.Point(154, 81);
            // 
            // 
            // 
            this.dtFechaCompromiso.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaCompromiso.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCompromiso.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaCompromiso.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaCompromiso.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaCompromiso.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaCompromiso.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaCompromiso.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaCompromiso.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaCompromiso.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaCompromiso.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCompromiso.MonthCalendar.DisplayMonth = new System.DateTime(2017, 3, 1, 0, 0, 0, 0);
            this.dtFechaCompromiso.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaCompromiso.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaCompromiso.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaCompromiso.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaCompromiso.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaCompromiso.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaCompromiso.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaCompromiso.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaCompromiso.Name = "dtFechaCompromiso";
            this.dtFechaCompromiso.Size = new System.Drawing.Size(160, 20);
            this.dtFechaCompromiso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaCompromiso.TabIndex = 6;
            // 
            // cboIdTipoCompromiso_tt
            // 
            this.cboIdTipoCompromiso_tt.DisplayMember = "Text";
            this.cboIdTipoCompromiso_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdTipoCompromiso_tt.FormattingEnabled = true;
            this.cboIdTipoCompromiso_tt.ItemHeight = 16;
            this.cboIdTipoCompromiso_tt.Location = new System.Drawing.Point(154, 51);
            this.cboIdTipoCompromiso_tt.Name = "cboIdTipoCompromiso_tt";
            this.cboIdTipoCompromiso_tt.Size = new System.Drawing.Size(160, 22);
            this.cboIdTipoCompromiso_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdTipoCompromiso_tt.TabIndex = 5;
            // 
            // cboIdAccion_tt
            // 
            this.cboIdAccion_tt.DisplayMember = "Text";
            this.cboIdAccion_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdAccion_tt.FormattingEnabled = true;
            this.cboIdAccion_tt.ItemHeight = 16;
            this.cboIdAccion_tt.Location = new System.Drawing.Point(154, 21);
            this.cboIdAccion_tt.Name = "cboIdAccion_tt";
            this.cboIdAccion_tt.Size = new System.Drawing.Size(160, 22);
            this.cboIdAccion_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdAccion_tt.TabIndex = 4;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(29, 111);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(110, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Comentario";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(29, 82);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(110, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Fecha y Hora";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(29, 53);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(110, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tipo Compromiso";
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
            this.labelX1.Size = new System.Drawing.Size(110, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Acción";
            // 
            // rbtnNoInteresado
            // 
            this.rbtnNoInteresado.AutoSize = true;
            this.rbtnNoInteresado.BackColor = System.Drawing.Color.Transparent;
            this.rbtnNoInteresado.Location = new System.Drawing.Point(17, 336);
            this.rbtnNoInteresado.Name = "rbtnNoInteresado";
            this.rbtnNoInteresado.Size = new System.Drawing.Size(92, 17);
            this.rbtnNoInteresado.TabIndex = 2;
            this.rbtnNoInteresado.TabStop = true;
            this.rbtnNoInteresado.Text = "No Interesado";
            this.rbtnNoInteresado.UseVisualStyleBackColor = false;
            this.rbtnNoInteresado.CheckedChanged += new System.EventHandler(this.rbtnNoInteresado_CheckedChanged);
            // 
            // gpNoInteresado
            // 
            this.gpNoInteresado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpNoInteresado.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpNoInteresado.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpNoInteresado.Controls.Add(this.txtComentarioNI);
            this.gpNoInteresado.Controls.Add(this.labelX6);
            this.gpNoInteresado.Controls.Add(this.cboIdMotivo_tt);
            this.gpNoInteresado.Controls.Add(this.labelX5);
            this.gpNoInteresado.Location = new System.Drawing.Point(17, 363);
            this.gpNoInteresado.Name = "gpNoInteresado";
            this.gpNoInteresado.Size = new System.Drawing.Size(678, 159);
            // 
            // 
            // 
            this.gpNoInteresado.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpNoInteresado.Style.BackColorGradientAngle = 90;
            this.gpNoInteresado.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpNoInteresado.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpNoInteresado.Style.BorderBottomWidth = 1;
            this.gpNoInteresado.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpNoInteresado.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpNoInteresado.Style.BorderLeftWidth = 1;
            this.gpNoInteresado.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpNoInteresado.Style.BorderRightWidth = 1;
            this.gpNoInteresado.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpNoInteresado.Style.BorderTopWidth = 1;
            this.gpNoInteresado.Style.CornerDiameter = 4;
            this.gpNoInteresado.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpNoInteresado.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpNoInteresado.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpNoInteresado.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpNoInteresado.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpNoInteresado.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpNoInteresado.TabIndex = 2;
            // 
            // txtComentarioNI
            // 
            this.txtComentarioNI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtComentarioNI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComentarioNI.Location = new System.Drawing.Point(154, 56);
            this.txtComentarioNI.Multiline = true;
            this.txtComentarioNI.Name = "txtComentarioNI";
            this.txtComentarioNI.Size = new System.Drawing.Size(460, 67);
            this.txtComentarioNI.TabIndex = 9;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(29, 56);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(110, 23);
            this.labelX6.TabIndex = 8;
            this.labelX6.Text = "Comentario";
            // 
            // cboIdMotivo_tt
            // 
            this.cboIdMotivo_tt.DisplayMember = "Text";
            this.cboIdMotivo_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdMotivo_tt.FormattingEnabled = true;
            this.cboIdMotivo_tt.ItemHeight = 16;
            this.cboIdMotivo_tt.Location = new System.Drawing.Point(154, 19);
            this.cboIdMotivo_tt.Name = "cboIdMotivo_tt";
            this.cboIdMotivo_tt.Size = new System.Drawing.Size(160, 22);
            this.cboIdMotivo_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdMotivo_tt.TabIndex = 6;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(29, 22);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(110, 23);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "Motivo";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(17, 27);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(110, 23);
            this.labelX7.TabIndex = 3;
            this.labelX7.Text = "Socio/ Candidato";
            // 
            // txtIdEntidad
            // 
            // 
            // 
            // 
            this.txtIdEntidad.Border.Class = "TextBoxBorder";
            this.txtIdEntidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdEntidad.Enabled = false;
            this.txtIdEntidad.Location = new System.Drawing.Point(174, 27);
            this.txtIdEntidad.Name = "txtIdEntidad";
            this.txtIdEntidad.Size = new System.Drawing.Size(160, 20);
            this.txtIdEntidad.TabIndex = 4;
            // 
            // txtEntidad
            // 
            // 
            // 
            // 
            this.txtEntidad.Border.Class = "TextBoxBorder";
            this.txtEntidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEntidad.Enabled = false;
            this.txtEntidad.Location = new System.Drawing.Point(340, 27);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(318, 20);
            this.txtEntidad.TabIndex = 5;
            // 
            // btnBuscarSocioCandidato
            // 
            this.btnBuscarSocioCandidato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarSocioCandidato.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscarSocioCandidato.Location = new System.Drawing.Point(668, 27);
            this.btnBuscarSocioCandidato.Name = "btnBuscarSocioCandidato";
            this.btnBuscarSocioCandidato.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarSocioCandidato.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarSocioCandidato.TabIndex = 6;
            this.btnBuscarSocioCandidato.Text = "...";
            this.btnBuscarSocioCandidato.Click += new System.EventHandler(this.btnBuscarSocioCandidato_Click);
            // 
            // frmGestionDato
            // 
            this.ClientSize = new System.Drawing.Size(725, 606);
            this.DoubleBuffered = true;
            this.Name = "frmGestionDato";
            this.Text = "Nueva Gestión";
            this.Load += new System.EventHandler(this.frmGestionDato_Load);
            this.grpDato.ResumeLayout(false);
            this.grpDato.PerformLayout();
            this.gpCompromiso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCompromiso)).EndInit();
            this.gpNoInteresado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpCompromiso;
        private System.Windows.Forms.RadioButton rbtnCompromiso;
        private System.Windows.Forms.RadioButton rbtnNoInteresado;
        private DevComponents.DotNetBar.Controls.GroupPanel gpNoInteresado;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaCompromiso;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdTipoCompromiso_tt;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdAccion_tt;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComentario;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComentarioNI;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdMotivo_tt;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEntidad;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdEntidad;
        private DevComponents.DotNetBar.ButtonX btnBuscarSocioCandidato;
    }
}