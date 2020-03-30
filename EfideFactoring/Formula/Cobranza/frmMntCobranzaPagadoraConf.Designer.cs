namespace EfideFactoring.Formula.Cobranza
{
    partial class frmMntCobranzaPagadoraConf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnConsultar = new DevComponents.DotNetBar.ButtonItem();
            this.btnConfirmar = new DevComponents.DotNetBar.ButtonItem();
            this.btnExtornar = new DevComponents.DotNetBar.ButtonItem();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cboIdEstado_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dtRegistroFiltro = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblGrilla = new DevComponents.DotNetBar.LabelX();
            this.dgvCobranza = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdCobranza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoCobranza_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoCobranza_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CtasBancariasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOperacion_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoAbono_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatosAdicionales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socioBancoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRegistroFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobranza)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonBar1
            // 
            this.RibbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar1.ContainerControlProcessDialogKey = true;
            this.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.RibbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnConsultar,
            this.btnConfirmar,
            this.btnExtornar,
            this.btnSalir});
            this.RibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.RibbonBar1.Name = "RibbonBar1";
            this.RibbonBar1.Size = new System.Drawing.Size(735, 40);
            this.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.RibbonBar1.TabIndex = 26;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnConsultar
            // 
            this.btnConsultar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnConsultar.Image = global::EfideFactoring.Properties.Resources.Binocular;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.SubItemsExpandWidth = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnConfirmar.Image = global::EfideFactoring.Properties.Resources.btn_ok;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.SubItemsExpandWidth = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnExtornar
            // 
            this.btnExtornar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExtornar.Image = global::EfideFactoring.Properties.Resources.elimina;
            this.btnExtornar.Name = "btnExtornar";
            this.btnExtornar.SubItemsExpandWidth = 14;
            this.btnExtornar.Text = "Extornar";
            this.btnExtornar.Visible = false;
            this.btnExtornar.Click += new System.EventHandler(this.btnExtornar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSalir.Image = global::EfideFactoring.Properties.Resources.cerrar;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.SubItemsExpandWidth = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.PanelEx1.Controls.Add(this.cboIdEstado_tt);
            this.PanelEx1.Controls.Add(this.labelX2);
            this.PanelEx1.Controls.Add(this.dtRegistroFiltro);
            this.PanelEx1.Controls.Add(this.btnLimpiar);
            this.PanelEx1.Controls.Add(this.btnBuscar);
            this.PanelEx1.Controls.Add(this.LabelX1);
            this.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx1.Location = new System.Drawing.Point(0, 40);
            this.PanelEx1.Name = "PanelEx1";
            this.PanelEx1.Size = new System.Drawing.Size(735, 56);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.TabIndex = 27;
            // 
            // cboIdEstado_tt
            // 
            this.cboIdEstado_tt.DisplayMember = "Text";
            this.cboIdEstado_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdEstado_tt.FormattingEnabled = true;
            this.cboIdEstado_tt.ItemHeight = 14;
            this.cboIdEstado_tt.Location = new System.Drawing.Point(281, 16);
            this.cboIdEstado_tt.Name = "cboIdEstado_tt";
            this.cboIdEstado_tt.Size = new System.Drawing.Size(179, 20);
            this.cboIdEstado_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdEstado_tt.TabIndex = 11;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(224, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(51, 23);
            this.labelX2.TabIndex = 10;
            this.labelX2.Text = "Estado";
            // 
            // dtRegistroFiltro
            // 
            // 
            // 
            // 
            this.dtRegistroFiltro.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtRegistroFiltro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtRegistroFiltro.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtRegistroFiltro.ButtonDropDown.Visible = true;
            this.dtRegistroFiltro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtRegistroFiltro.IsPopupCalendarOpen = false;
            this.dtRegistroFiltro.Location = new System.Drawing.Point(75, 16);
            // 
            // 
            // 
            this.dtRegistroFiltro.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtRegistroFiltro.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtRegistroFiltro.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtRegistroFiltro.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtRegistroFiltro.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtRegistroFiltro.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtRegistroFiltro.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtRegistroFiltro.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtRegistroFiltro.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtRegistroFiltro.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtRegistroFiltro.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtRegistroFiltro.MonthCalendar.DisplayMonth = new System.DateTime(2014, 10, 1, 0, 0, 0, 0);
            this.dtRegistroFiltro.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtRegistroFiltro.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtRegistroFiltro.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtRegistroFiltro.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtRegistroFiltro.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtRegistroFiltro.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtRegistroFiltro.MonthCalendar.TodayButtonVisible = true;
            this.dtRegistroFiltro.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtRegistroFiltro.Name = "dtRegistroFiltro";
            this.dtRegistroFiltro.Size = new System.Drawing.Size(106, 20);
            this.dtRegistroFiltro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtRegistroFiltro.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(653, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 44);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = global::EfideFactoring.Properties.Resources.buscar;
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(574, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 44);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelX1.Location = new System.Drawing.Point(21, 16);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(59, 23);
            this.LabelX1.TabIndex = 0;
            this.LabelX1.Text = "Fecha";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrilla.Location = new System.Drawing.Point(0, 102);
            this.lblGrilla.Name = "lblGrilla";
            this.lblGrilla.Size = new System.Drawing.Size(149, 23);
            this.lblGrilla.TabIndex = 29;
            this.lblGrilla.Text = "Confirmación de Cobranza";
            // 
            // dgvCobranza
            // 
            this.dgvCobranza.AllowUserToAddRows = false;
            this.dgvCobranza.AllowUserToDeleteRows = false;
            this.dgvCobranza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCobranza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCobranza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobranza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCobranza,
            this.IdTipoCobranza_tt_Dsc,
            this.Entidad,
            this.Fecha,
            this.IdTipoCobranza_tt,
            this.Moneda,
            this.IdMoneda_tt,
            this.CtasBancariasID,
            this.Importe,
            this.IdOperacion_tt,
            this.IdTipoAbono_tt,
            this.DatosAdicionales,
            this.socioBancoID,
            this.Status,
            this.Estado});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCobranza.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCobranza.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCobranza.Location = new System.Drawing.Point(0, 130);
            this.dgvCobranza.Name = "dgvCobranza";
            this.dgvCobranza.ReadOnly = true;
            this.dgvCobranza.RowHeadersWidth = 10;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCobranza.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCobranza.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCobranza.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCobranza.Size = new System.Drawing.Size(735, 272);
            this.dgvCobranza.TabIndex = 30;
            // 
            // IdCobranza
            // 
            this.IdCobranza.DataPropertyName = "IdCobranza";
            this.IdCobranza.HeaderText = "Nro. Cobranza";
            this.IdCobranza.Name = "IdCobranza";
            this.IdCobranza.ReadOnly = true;
            // 
            // IdTipoCobranza_tt_Dsc
            // 
            this.IdTipoCobranza_tt_Dsc.DataPropertyName = "IdTipoCobranza_tt_Dsc";
            this.IdTipoCobranza_tt_Dsc.HeaderText = "Tipo";
            this.IdTipoCobranza_tt_Dsc.Name = "IdTipoCobranza_tt_Dsc";
            this.IdTipoCobranza_tt_Dsc.ReadOnly = true;
            this.IdTipoCobranza_tt_Dsc.Width = 53;
            // 
            // Entidad
            // 
            this.Entidad.DataPropertyName = "Entidad";
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.Name = "Entidad";
            this.Entidad.ReadOnly = true;
            this.Entidad.Width = 68;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "dtRegistro";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
            // 
            // IdTipoCobranza_tt
            // 
            this.IdTipoCobranza_tt.DataPropertyName = "IdTipoCobranza_tt";
            this.IdTipoCobranza_tt.HeaderText = "IdTipoCobranza_tt";
            this.IdTipoCobranza_tt.Name = "IdTipoCobranza_tt";
            this.IdTipoCobranza_tt.ReadOnly = true;
            this.IdTipoCobranza_tt.Visible = false;
            this.IdTipoCobranza_tt.Width = 119;
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "IdMoneda_tt_Dsc";
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            this.Moneda.Width = 71;
            // 
            // IdMoneda_tt
            // 
            this.IdMoneda_tt.DataPropertyName = "IdMoneda_tt";
            this.IdMoneda_tt.HeaderText = "IdMoneda_tt";
            this.IdMoneda_tt.Name = "IdMoneda_tt";
            this.IdMoneda_tt.ReadOnly = true;
            this.IdMoneda_tt.Visible = false;
            this.IdMoneda_tt.Width = 92;
            // 
            // CtasBancariasID
            // 
            this.CtasBancariasID.DataPropertyName = "CtasBancariasID";
            this.CtasBancariasID.HeaderText = "CtasBancariasID";
            this.CtasBancariasID.Name = "CtasBancariasID";
            this.CtasBancariasID.ReadOnly = true;
            this.CtasBancariasID.Visible = false;
            this.CtasBancariasID.Width = 111;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "nTotal";
            this.Importe.HeaderText = "Total";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 56;
            // 
            // IdOperacion_tt
            // 
            this.IdOperacion_tt.DataPropertyName = "IdOperacion_tt";
            this.IdOperacion_tt.HeaderText = "IdOperacion_tt";
            this.IdOperacion_tt.Name = "IdOperacion_tt";
            this.IdOperacion_tt.ReadOnly = true;
            this.IdOperacion_tt.Visible = false;
            this.IdOperacion_tt.Width = 102;
            // 
            // IdTipoAbono_tt
            // 
            this.IdTipoAbono_tt.DataPropertyName = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.HeaderText = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.Name = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.ReadOnly = true;
            this.IdTipoAbono_tt.Visible = false;
            this.IdTipoAbono_tt.Width = 105;
            // 
            // DatosAdicionales
            // 
            this.DatosAdicionales.DataPropertyName = "DatosAdicionales";
            this.DatosAdicionales.HeaderText = "DatosAdicionales";
            this.DatosAdicionales.Name = "DatosAdicionales";
            this.DatosAdicionales.ReadOnly = true;
            this.DatosAdicionales.Visible = false;
            this.DatosAdicionales.Width = 114;
            // 
            // socioBancoID
            // 
            this.socioBancoID.DataPropertyName = "socioBancoID";
            this.socioBancoID.HeaderText = "socioBancoID";
            this.socioBancoID.Name = "socioBancoID";
            this.socioBancoID.ReadOnly = true;
            this.socioBancoID.Visible = false;
            this.socioBancoID.Width = 99;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            this.Status.Width = 62;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistros.Location = new System.Drawing.Point(639, 102);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(96, 23);
            this.lblRegistros.TabIndex = 31;
            this.lblRegistros.Text = "0  registro(s)";
            // 
            // frmMntCobranzaPagadoraConf
            // 
            this.ClientSize = new System.Drawing.Size(735, 414);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.dgvCobranza);
            this.Controls.Add(this.lblGrilla);
            this.Controls.Add(this.PanelEx1);
            this.Controls.Add(this.RibbonBar1);
            this.DoubleBuffered = true;
            this.Name = "frmMntCobranzaPagadoraConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación de Cobranza";
            this.Load += new System.EventHandler(this.frmMntCobranzaPagadoraConf_Load);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtRegistroFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobranza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.RibbonBar RibbonBar1;
        protected DevComponents.DotNetBar.ButtonItem btnConfirmar;
        protected DevComponents.DotNetBar.ButtonItem btnExtornar;
        protected DevComponents.DotNetBar.ButtonItem btnSalir;
        protected DevComponents.DotNetBar.PanelEx PanelEx1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtRegistroFiltro;
        protected DevComponents.DotNetBar.ButtonX btnLimpiar;
        protected DevComponents.DotNetBar.ButtonX btnBuscar;
        protected DevComponents.DotNetBar.LabelX LabelX1;
        protected DevComponents.DotNetBar.LabelX lblGrilla;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCobranza;
        protected DevComponents.DotNetBar.LabelX lblRegistros;
        protected DevComponents.DotNetBar.ButtonItem btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCobranza;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoCobranza_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoCobranza_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CtasBancariasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOperacion_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoAbono_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosAdicionales;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioBancoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdEstado_tt;
        protected DevComponents.DotNetBar.LabelX labelX2;
    }
}