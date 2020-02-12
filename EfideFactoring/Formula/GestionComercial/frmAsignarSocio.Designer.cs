namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmAsignarSocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSocios = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ColorRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestorCuentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestorCuentaID_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasUltDesem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarios = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.gestorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboUsuarios = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnAgregarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.txtIdPagadora = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBuscarPagadora = new DevComponents.DotNetBar.ButtonX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.lblNRegistros = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtRazonSocialSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBusquedaSocio = new DevComponents.DotNetBar.ButtonX();
            this.txtIdSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.dtFechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.cboEjecutivo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chkSociosInactivos = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.dtFechaInactivo2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtFechaInactivo1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInactivo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInactivo1)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(1238, 40);
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
            this.btnNuevo.Text = "&Asginar Socios";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Text = "Eliminar Asignación";
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.Controls.Add(this.labelX11);
            this.PanelEx1.Controls.Add(this.dtFechaInactivo2);
            this.PanelEx1.Controls.Add(this.dtFechaInactivo1);
            this.PanelEx1.Controls.Add(this.labelX10);
            this.PanelEx1.Controls.Add(this.chkSociosInactivos);
            this.PanelEx1.Controls.Add(this.cboEjecutivo);
            this.PanelEx1.Controls.Add(this.labelX9);
            this.PanelEx1.Controls.Add(this.labelX8);
            this.PanelEx1.Controls.Add(this.dtFechaFin);
            this.PanelEx1.Controls.Add(this.dtFechaInicio);
            this.PanelEx1.Controls.Add(this.labelX7);
            this.PanelEx1.Controls.Add(this.labelX2);
            this.PanelEx1.Controls.Add(this.txtRazonSocialSocio);
            this.PanelEx1.Controls.Add(this.btnBusquedaSocio);
            this.PanelEx1.Controls.Add(this.txtIdSocio);
            this.PanelEx1.Controls.Add(this.line1);
            this.PanelEx1.Controls.Add(this.labelX6);
            this.PanelEx1.Controls.Add(this.labelX5);
            this.PanelEx1.Controls.Add(this.labelX4);
            this.PanelEx1.Controls.Add(this.txtDescripcion);
            this.PanelEx1.Controls.Add(this.btnBuscarPagadora);
            this.PanelEx1.Controls.Add(this.txtIdPagadora);
            this.PanelEx1.Size = new System.Drawing.Size(1238, 172);
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
            this.PanelEx1.Controls.SetChildIndex(this.txtIdPagadora, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscarPagadora, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX4, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX5, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX6, 0);
            this.PanelEx1.Controls.SetChildIndex(this.line1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtIdSocio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBusquedaSocio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtRazonSocialSocio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX2, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX7, 0);
            this.PanelEx1.Controls.SetChildIndex(this.dtFechaInicio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.dtFechaFin, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX8, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX9, 0);
            this.PanelEx1.Controls.SetChildIndex(this.cboEjecutivo, 0);
            this.PanelEx1.Controls.SetChildIndex(this.chkSociosInactivos, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX10, 0);
            this.PanelEx1.Controls.SetChildIndex(this.dtFechaInactivo1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.dtFechaInactivo2, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX11, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(687, 33);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(608, 33);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(838, 21);
            this.TextBoxX1.Size = new System.Drawing.Size(34, 20);
            this.TextBoxX1.Visible = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(808, 17);
            this.LabelX1.Size = new System.Drawing.Size(24, 23);
            this.LabelX1.Text = "Pagadora";
            this.LabelX1.Visible = false;
            // 
            // lblGrilla
            // 
            this.lblGrilla.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Location = new System.Drawing.Point(617, 163);
            this.lblGrilla.Size = new System.Drawing.Size(187, 23);
            this.lblGrilla.Text = "Resultados de la Busqueda";
            this.lblGrilla.Visible = false;
            // 
            // lblRegistros
            // 
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(618, 140);
            this.lblRegistros.Size = new System.Drawing.Size(228, 22);
            this.lblRegistros.Visible = false;
            // 
            // dgvSocios
            // 
            this.dgvSocios.AllowUserToAddRows = false;
            this.dgvSocios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvSocios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColorRow,
            this.Orden,
            this.Clasificacion,
            this.IdSocio,
            this.IdSocio_Dsc,
            this.gestorCuentaID,
            this.gestorCuentaID_Dsc,
            this.DiasUltDesem});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSocios.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSocios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSocios.Location = new System.Drawing.Point(3, 42);
            this.dgvSocios.Name = "dgvSocios";
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvSocios.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSocios.RowTemplate.Height = 24;
            this.dgvSocios.Size = new System.Drawing.Size(843, 344);
            this.dgvSocios.TabIndex = 22;
            this.dgvSocios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSocios_CellFormatting);
            this.dgvSocios.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSocios_CurrentCellDirtyStateChanged);
            // 
            // ColorRow
            // 
            this.ColorRow.DataPropertyName = "ColorRow";
            this.ColorRow.HeaderText = "ColorRow";
            this.ColorRow.Name = "ColorRow";
            this.ColorRow.Visible = false;
            // 
            // Orden
            // 
            this.Orden.DataPropertyName = "Orden";
            this.Orden.HeaderText = "Orden";
            this.Orden.Name = "Orden";
            this.Orden.Visible = false;
            // 
            // Clasificacion
            // 
            this.Clasificacion.DataPropertyName = "Clasificacion";
            this.Clasificacion.HeaderText = "Clasificación";
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.Width = 150;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "Código";
            this.IdSocio.Name = "IdSocio";
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.Width = 200;
            // 
            // gestorCuentaID
            // 
            this.gestorCuentaID.DataPropertyName = "gestorCuentaID";
            this.gestorCuentaID.HeaderText = "gestorCuentaID_Dsc";
            this.gestorCuentaID.Name = "gestorCuentaID";
            this.gestorCuentaID.Visible = false;
            this.gestorCuentaID.Width = 200;
            // 
            // gestorCuentaID_Dsc
            // 
            this.gestorCuentaID_Dsc.DataPropertyName = "gestorCuentaID_Dsc";
            this.gestorCuentaID_Dsc.HeaderText = "Ejecutivo";
            this.gestorCuentaID_Dsc.Name = "gestorCuentaID_Dsc";
            this.gestorCuentaID_Dsc.Width = 200;
            // 
            // DiasUltDesem
            // 
            this.DiasUltDesem.DataPropertyName = "DiasUltDesem";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DiasUltDesem.DefaultCellStyle = dataGridViewCellStyle8;
            this.DiasUltDesem.HeaderText = "# Días Ult. Desem.";
            this.DiasUltDesem.Name = "DiasUltDesem";
            this.DiasUltDesem.Width = 90;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gestorID,
            this.nombreCompleto});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(16, 42);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(344, 344);
            this.dgvUsuarios.TabIndex = 24;
            // 
            // gestorID
            // 
            this.gestorID.DataPropertyName = "gestorID";
            this.gestorID.HeaderText = "gestorID";
            this.gestorID.Name = "gestorID";
            this.gestorID.ReadOnly = true;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.DataPropertyName = "nombreCompleto";
            this.nombreCompleto.HeaderText = "Ejecutivo";
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            this.nombreCompleto.Width = 180;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(16, 14);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(67, 23);
            this.labelX3.TabIndex = 25;
            this.labelX3.Text = "Ejecutivo";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DisplayMember = "Text";
            this.cboUsuarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.ItemHeight = 16;
            this.cboUsuarios.Location = new System.Drawing.Point(89, 15);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(178, 22);
            this.cboUsuarios.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboUsuarios.TabIndex = 26;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregarUsuario.Image = global::EfideFactoring.Properties.Resources.add;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(273, 12);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(87, 24);
            this.btnAgregarUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregarUsuario.TabIndex = 27;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtIdPagadora
            // 
            // 
            // 
            // 
            this.txtIdPagadora.Border.Class = "TextBoxBorder";
            this.txtIdPagadora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdPagadora.Location = new System.Drawing.Point(149, 33);
            this.txtIdPagadora.Name = "txtIdPagadora";
            this.txtIdPagadora.Size = new System.Drawing.Size(100, 20);
            this.txtIdPagadora.TabIndex = 12;
            // 
            // btnBuscarPagadora
            // 
            this.btnBuscarPagadora.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarPagadora.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscarPagadora.Location = new System.Drawing.Point(116, 33);
            this.btnBuscarPagadora.Name = "btnBuscarPagadora";
            this.btnBuscarPagadora.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarPagadora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarPagadora.TabIndex = 11;
            this.btnBuscarPagadora.Text = "...";
            this.btnBuscarPagadora.Click += new System.EventHandler(this.btnBuscarPagadora_Click);
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Location = new System.Drawing.Point(255, 33);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(328, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX4.Location = new System.Drawing.Point(25, 33);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(67, 23);
            this.labelX4.TabIndex = 27;
            this.labelX4.Text = "Pagadora";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX5.Location = new System.Drawing.Point(25, 135);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(118, 23);
            this.labelX5.TabIndex = 28;
            this.labelX5.Text = "Socios Inactivos";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(25, 21);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(735, 10);
            this.line1.TabIndex = 31;
            this.line1.Text = "line1";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(25, 5);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(148, 20);
            this.labelX6.TabIndex = 30;
            this.labelX6.Text = "FILTROS DE BUSQUEDA";
            // 
            // panelEx2
            // 
            this.panelEx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btnAgregarUsuario);
            this.panelEx2.Controls.Add(this.dgvUsuarios);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.Controls.Add(this.cboUsuarios);
            this.panelEx2.Location = new System.Drawing.Point(865, 224);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(372, 400);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 28;
            // 
            // panelEx3
            // 
            this.panelEx3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.lblNRegistros);
            this.panelEx3.Controls.Add(this.dgvSocios);
            this.panelEx3.Location = new System.Drawing.Point(0, 224);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(860, 400);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 29;
            // 
            // lblNRegistros
            // 
            this.lblNRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblNRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNRegistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNRegistros.Location = new System.Drawing.Point(565, 15);
            this.lblNRegistros.Name = "lblNRegistros";
            this.lblNRegistros.Size = new System.Drawing.Size(281, 23);
            this.lblNRegistros.TabIndex = 23;
            this.lblNRegistros.Text = "0  registro(s)";
            this.lblNRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(25, 58);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(85, 23);
            this.labelX2.TabIndex = 35;
            this.labelX2.Text = "Socio/Prospecto";
            // 
            // txtRazonSocialSocio
            // 
            // 
            // 
            // 
            this.txtRazonSocialSocio.Border.Class = "TextBoxBorder";
            this.txtRazonSocialSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRazonSocialSocio.Location = new System.Drawing.Point(255, 58);
            this.txtRazonSocialSocio.Name = "txtRazonSocialSocio";
            this.txtRazonSocialSocio.Size = new System.Drawing.Size(328, 20);
            this.txtRazonSocialSocio.TabIndex = 34;
            // 
            // btnBusquedaSocio
            // 
            this.btnBusquedaSocio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBusquedaSocio.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBusquedaSocio.Location = new System.Drawing.Point(116, 58);
            this.btnBusquedaSocio.Name = "btnBusquedaSocio";
            this.btnBusquedaSocio.Size = new System.Drawing.Size(27, 23);
            this.btnBusquedaSocio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBusquedaSocio.TabIndex = 32;
            this.btnBusquedaSocio.Text = "...";
            this.btnBusquedaSocio.Click += new System.EventHandler(this.btnBusquedaSocio_Click);
            // 
            // txtIdSocio
            // 
            // 
            // 
            // 
            this.txtIdSocio.Border.Class = "TextBoxBorder";
            this.txtIdSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdSocio.Location = new System.Drawing.Point(149, 58);
            this.txtIdSocio.Name = "txtIdSocio";
            this.txtIdSocio.Size = new System.Drawing.Size(100, 20);
            this.txtIdSocio.TabIndex = 33;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX7.Location = new System.Drawing.Point(25, 110);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(78, 23);
            this.labelX7.TabIndex = 36;
            this.labelX7.Text = "Fecha Ingreso";
            // 
            // dtFechaInicio
            // 
            // 
            // 
            // 
            this.dtFechaInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaInicio.ButtonDropDown.Visible = true;
            this.dtFechaInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaInicio.IsPopupCalendarOpen = false;
            this.dtFechaInicio.Location = new System.Drawing.Point(149, 109);
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaInicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.DisplayMonth = new System.DateTime(2018, 3, 1, 0, 0, 0, 0);
            this.dtFechaInicio.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtFechaInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaInicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dtFechaInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaInicio.TabIndex = 37;
            // 
            // dtFechaFin
            // 
            // 
            // 
            // 
            this.dtFechaFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaFin.ButtonDropDown.Visible = true;
            this.dtFechaFin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaFin.IsPopupCalendarOpen = false;
            this.dtFechaFin.Location = new System.Drawing.Point(317, 109);
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaFin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.MonthCalendar.DisplayMonth = new System.DateTime(2018, 3, 1, 0, 0, 0, 0);
            this.dtFechaFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtFechaFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtFechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaFin.TabIndex = 38;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX8.Location = new System.Drawing.Point(255, 106);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(56, 23);
            this.labelX8.TabIndex = 39;
            this.labelX8.Text = "Hasta";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX9.Location = new System.Drawing.Point(25, 81);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(78, 23);
            this.labelX9.TabIndex = 40;
            this.labelX9.Text = "Ejecutivo";
            // 
            // cboEjecutivo
            // 
            this.cboEjecutivo.DisplayMember = "Text";
            this.cboEjecutivo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEjecutivo.FormattingEnabled = true;
            this.cboEjecutivo.ItemHeight = 14;
            this.cboEjecutivo.Location = new System.Drawing.Point(149, 83);
            this.cboEjecutivo.Name = "cboEjecutivo";
            this.cboEjecutivo.Size = new System.Drawing.Size(268, 20);
            this.cboEjecutivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEjecutivo.TabIndex = 41;
            // 
            // chkSociosInactivos
            // 
            // 
            // 
            // 
            this.chkSociosInactivos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkSociosInactivos.Location = new System.Drawing.Point(149, 134);
            this.chkSociosInactivos.Name = "chkSociosInactivos";
            this.chkSociosInactivos.Size = new System.Drawing.Size(24, 23);
            this.chkSociosInactivos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkSociosInactivos.TabIndex = 42;
            this.chkSociosInactivos.CheckedChanged += new System.EventHandler(this.chkSociosInactivos_CheckedChanged);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX10.Location = new System.Drawing.Point(186, 134);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(20, 23);
            this.labelX10.TabIndex = 43;
            this.labelX10.Text = "Del";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX11.Location = new System.Drawing.Point(310, 134);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(16, 23);
            this.labelX11.TabIndex = 46;
            this.labelX11.Text = "Al";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dtFechaInactivo2
            // 
            // 
            // 
            // 
            this.dtFechaInactivo2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaInactivo2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInactivo2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaInactivo2.ButtonDropDown.Visible = true;
            this.dtFechaInactivo2.Enabled = false;
            this.dtFechaInactivo2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaInactivo2.IsPopupCalendarOpen = false;
            this.dtFechaInactivo2.Location = new System.Drawing.Point(329, 135);
            // 
            // 
            // 
            this.dtFechaInactivo2.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInactivo2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInactivo2.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaInactivo2.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaInactivo2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaInactivo2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInactivo2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaInactivo2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaInactivo2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaInactivo2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaInactivo2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInactivo2.MonthCalendar.DisplayMonth = new System.DateTime(2018, 3, 1, 0, 0, 0, 0);
            this.dtFechaInactivo2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtFechaInactivo2.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaInactivo2.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInactivo2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaInactivo2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInactivo2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaInactivo2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInactivo2.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaInactivo2.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaInactivo2.Name = "dtFechaInactivo2";
            this.dtFechaInactivo2.Size = new System.Drawing.Size(100, 20);
            this.dtFechaInactivo2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaInactivo2.TabIndex = 45;
            // 
            // dtFechaInactivo1
            // 
            // 
            // 
            // 
            this.dtFechaInactivo1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaInactivo1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInactivo1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaInactivo1.ButtonDropDown.Visible = true;
            this.dtFechaInactivo1.Enabled = false;
            this.dtFechaInactivo1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaInactivo1.IsPopupCalendarOpen = false;
            this.dtFechaInactivo1.Location = new System.Drawing.Point(208, 135);
            // 
            // 
            // 
            this.dtFechaInactivo1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInactivo1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInactivo1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaInactivo1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaInactivo1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaInactivo1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInactivo1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaInactivo1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaInactivo1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaInactivo1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaInactivo1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInactivo1.MonthCalendar.DisplayMonth = new System.DateTime(2018, 3, 1, 0, 0, 0, 0);
            this.dtFechaInactivo1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtFechaInactivo1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaInactivo1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInactivo1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaInactivo1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInactivo1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaInactivo1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInactivo1.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaInactivo1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaInactivo1.Name = "dtFechaInactivo1";
            this.dtFechaInactivo1.Size = new System.Drawing.Size(100, 20);
            this.dtFechaInactivo1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaInactivo1.TabIndex = 44;
            // 
            // frmAsignarSocio
            // 
            this.AcceptButton = this.btnBuscar;
            this.ClientSize = new System.Drawing.Size(1238, 640);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.DoubleBuffered = true;
            this.Name = "frmAsignarSocio";
            this.Text = "Asignacion Cartera / Ejecutivo";
            this.Load += new System.EventHandler(this.frmAsignarSocio_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.panelEx2, 0);
            this.Controls.SetChildIndex(this.panelEx3, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInactivo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInactivo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSocios;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUsuarios;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboUsuarios;
        private DevComponents.DotNetBar.ButtonX btnAgregarUsuario;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.ButtonX btnBuscarPagadora;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdPagadora;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.Line line1;
        protected DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRazonSocialSocio;
        private DevComponents.DotNetBar.ButtonX btnBusquedaSocio;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdSocio;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaFin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaInicio;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEjecutivo;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX lblNRegistros;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkSociosInactivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestorCuentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestorCuentaID_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasUltDesem;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaInactivo2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaInactivo1;
        private DevComponents.DotNetBar.LabelX labelX10;
    }
}