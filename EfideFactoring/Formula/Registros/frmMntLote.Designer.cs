namespace EfideFactoring.Formula.Registros
{
    partial class frmMntLote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMntLote));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLote = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnVisorFirma = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdAprobacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdDesembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDesembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITransito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOperacion_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFormaDesembolso_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioConfirmadoPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtConfirmadoPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlgActualizarFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEnvioCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioEnvioCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroEnvioCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNumRenovaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dtDesembolsoInicio = new System.Windows.Forms.DateTimePicker();
            this.dtDesembolsoFin = new System.Windows.Forms.DateTimePicker();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lblFinanciera = new DevComponents.DotNetBar.LabelX();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(1398, 40);
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.Controls.Add(this.lblFinanciera);
            this.PanelEx1.Controls.Add(this.labelX3);
            this.PanelEx1.Controls.Add(this.dtDesembolsoFin);
            this.PanelEx1.Controls.Add(this.dtDesembolsoInicio);
            this.PanelEx1.Controls.Add(this.labelX2);
            this.PanelEx1.Size = new System.Drawing.Size(1398, 93);
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
            this.PanelEx1.Controls.SetChildIndex(this.labelX2, 0);
            this.PanelEx1.Controls.SetChildIndex(this.dtDesembolsoInicio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.dtDesembolsoFin, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX3, 0);
            this.PanelEx1.Controls.SetChildIndex(this.lblFinanciera, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(894, 6);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(815, 6);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(59, 16);
            this.TextBoxX1.Size = new System.Drawing.Size(291, 20);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Size = new System.Drawing.Size(40, 23);
            this.LabelX1.Text = "Socio";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Location = new System.Drawing.Point(0, 139);
            this.lblGrilla.Text = "Lotes";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(1222, 139);
            // 
            // dgvLote
            // 
            this.dgvLote.AllowUserToAddRows = false;
            this.dgvLote.AllowUserToDeleteRows = false;
            this.dgvLote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnVisorFirma,
            this.IdLote,
            this.IdSocio,
            this.IdMoneda_tt,
            this.sdAprobacion,
            this.IdSocio_Dsc,
            this.NLinea,
            this.sdDesembolso,
            this.FechaVencimiento,
            this.TipoLinea,
            this.Moneda,
            this.nDesembolso,
            this.Importe,
            this.Saldo,
            this.ITransito,
            this.SaldoDisponible,
            this.IdEstado_tt_Dsc,
            this.IdOperacion_tt,
            this.IdFormaDesembolso_tt,
            this.UserNew,
            this.UsuarioConfirmadoPagadora,
            this.dtConfirmadoPagadora,
            this.IdEstado_tt,
            this.FlgActualizarFecha,
            this.dtEnvioCorreo,
            this.UsuarioEnvioCorreo,
            this.NroEnvioCorreo,
            this.iNumRenovaciones});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLote.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLote.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLote.Location = new System.Drawing.Point(0, 167);
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.ReadOnly = true;
            this.dgvLote.RowHeadersWidth = 10;
            this.dgvLote.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLote.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLote.Size = new System.Drawing.Size(1398, 482);
            this.dgvLote.TabIndex = 22;
            this.dgvLote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLote_CellClick);
            // 
            // btnVisorFirma
            // 
            this.btnVisorFirma.HeaderText = "";
            this.btnVisorFirma.Image = ((System.Drawing.Image)(resources.GetObject("btnVisorFirma.Image")));
            this.btnVisorFirma.Name = "btnVisorFirma";
            this.btnVisorFirma.ReadOnly = true;
            this.btnVisorFirma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnVisorFirma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnVisorFirma.Text = null;
            this.btnVisorFirma.Width = 40;
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "IdLote";
            this.IdLote.HeaderText = "Nro. Planilla";
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Visible = false;
            this.IdSocio.Width = 150;
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
            // sdAprobacion
            // 
            this.sdAprobacion.DataPropertyName = "sdAprobacion";
            this.sdAprobacion.HeaderText = "sdAprobacion";
            this.sdAprobacion.Name = "sdAprobacion";
            this.sdAprobacion.ReadOnly = true;
            this.sdAprobacion.Visible = false;
            this.sdAprobacion.Width = 97;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 160;
            // 
            // NLinea
            // 
            this.NLinea.DataPropertyName = "IdLinea";
            this.NLinea.HeaderText = "Nro. Línea";
            this.NLinea.Name = "NLinea";
            this.NLinea.ReadOnly = true;
            this.NLinea.Width = 80;
            // 
            // sdDesembolso
            // 
            this.sdDesembolso.DataPropertyName = "sdDesembolso";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.sdDesembolso.DefaultCellStyle = dataGridViewCellStyle1;
            this.sdDesembolso.HeaderText = "Fecha Desembolso";
            this.sdDesembolso.Name = "sdDesembolso";
            this.sdDesembolso.ReadOnly = true;
            this.sdDesembolso.Width = 75;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.DataPropertyName = "dtVencimiento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaVencimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            this.FechaVencimiento.Visible = false;
            this.FechaVencimiento.Width = 75;
            // 
            // TipoLinea
            // 
            this.TipoLinea.DataPropertyName = "IdTipoLinea_tt_Dsc";
            this.TipoLinea.HeaderText = "Tipo de Línea";
            this.TipoLinea.Name = "TipoLinea";
            this.TipoLinea.ReadOnly = true;
            this.TipoLinea.Width = 90;
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "IdMoneda_tt_Dsc";
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            this.Moneda.Width = 60;
            // 
            // nDesembolso
            // 
            this.nDesembolso.DataPropertyName = "nDesembolso";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.nDesembolso.DefaultCellStyle = dataGridViewCellStyle3;
            this.nDesembolso.HeaderText = "Desembolso";
            this.nDesembolso.Name = "nDesembolso";
            this.nDesembolso.ReadOnly = true;
            this.nDesembolso.Width = 70;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "nImporte";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.Importe.DefaultCellStyle = dataGridViewCellStyle4;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Visible = false;
            this.Importe.Width = 80;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle5;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Visible = false;
            this.Saldo.Width = 80;
            // 
            // ITransito
            // 
            this.ITransito.DataPropertyName = "Transito";
            this.ITransito.HeaderText = "I. Transito";
            this.ITransito.Name = "ITransito";
            this.ITransito.ReadOnly = true;
            this.ITransito.Visible = false;
            this.ITransito.Width = 80;
            // 
            // SaldoDisponible
            // 
            this.SaldoDisponible.DataPropertyName = "SaldoDisponible";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.SaldoDisponible.DefaultCellStyle = dataGridViewCellStyle6;
            this.SaldoDisponible.HeaderText = "Saldo Disponible";
            this.SaldoDisponible.Name = "SaldoDisponible";
            this.SaldoDisponible.ReadOnly = true;
            this.SaldoDisponible.Visible = false;
            this.SaldoDisponible.Width = 80;
            // 
            // IdEstado_tt_Dsc
            // 
            this.IdEstado_tt_Dsc.DataPropertyName = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.HeaderText = "Estado";
            this.IdEstado_tt_Dsc.Name = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.ReadOnly = true;
            this.IdEstado_tt_Dsc.Width = 80;
            // 
            // IdOperacion_tt
            // 
            this.IdOperacion_tt.DataPropertyName = "IdOperacion_tt";
            this.IdOperacion_tt.HeaderText = "IdOperacion_tt";
            this.IdOperacion_tt.Name = "IdOperacion_tt";
            this.IdOperacion_tt.ReadOnly = true;
            this.IdOperacion_tt.Visible = false;
            // 
            // IdFormaDesembolso_tt
            // 
            this.IdFormaDesembolso_tt.DataPropertyName = "IdFormaDesembolso";
            this.IdFormaDesembolso_tt.HeaderText = "IdFormaDesembolso_tt";
            this.IdFormaDesembolso_tt.Name = "IdFormaDesembolso_tt";
            this.IdFormaDesembolso_tt.ReadOnly = true;
            this.IdFormaDesembolso_tt.Visible = false;
            // 
            // UserNew
            // 
            this.UserNew.DataPropertyName = "UserNew";
            this.UserNew.HeaderText = "Usuario Registro";
            this.UserNew.Name = "UserNew";
            this.UserNew.ReadOnly = true;
            // 
            // UsuarioConfirmadoPagadora
            // 
            this.UsuarioConfirmadoPagadora.DataPropertyName = "UsuarioConfirmadoPagadora";
            this.UsuarioConfirmadoPagadora.HeaderText = "Usuario Confirmación";
            this.UsuarioConfirmadoPagadora.Name = "UsuarioConfirmadoPagadora";
            this.UsuarioConfirmadoPagadora.ReadOnly = true;
            // 
            // dtConfirmadoPagadora
            // 
            this.dtConfirmadoPagadora.DataPropertyName = "dtConfirmadoPagadora";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "g";
            dataGridViewCellStyle7.NullValue = null;
            this.dtConfirmadoPagadora.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtConfirmadoPagadora.HeaderText = "Fecha Confirmación";
            this.dtConfirmadoPagadora.Name = "dtConfirmadoPagadora";
            this.dtConfirmadoPagadora.ReadOnly = true;
            this.dtConfirmadoPagadora.Width = 120;
            // 
            // IdEstado_tt
            // 
            this.IdEstado_tt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IdEstado_tt.DataPropertyName = "IdEstado_tt";
            this.IdEstado_tt.HeaderText = "IdEstado_tt";
            this.IdEstado_tt.Name = "IdEstado_tt";
            this.IdEstado_tt.ReadOnly = true;
            this.IdEstado_tt.Visible = false;
            // 
            // FlgActualizarFecha
            // 
            this.FlgActualizarFecha.DataPropertyName = "FlgActualizarFecha";
            this.FlgActualizarFecha.HeaderText = "FlgActualizarFecha";
            this.FlgActualizarFecha.Name = "FlgActualizarFecha";
            this.FlgActualizarFecha.ReadOnly = true;
            this.FlgActualizarFecha.Visible = false;
            // 
            // dtEnvioCorreo
            // 
            this.dtEnvioCorreo.DataPropertyName = "dtEnvioCorreo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.dtEnvioCorreo.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtEnvioCorreo.HeaderText = "Fecha Último Envío";
            this.dtEnvioCorreo.Name = "dtEnvioCorreo";
            this.dtEnvioCorreo.ReadOnly = true;
            // 
            // UsuarioEnvioCorreo
            // 
            this.UsuarioEnvioCorreo.DataPropertyName = "UsuarioEnvioCorreo";
            this.UsuarioEnvioCorreo.HeaderText = "Usuario Último Envío";
            this.UsuarioEnvioCorreo.Name = "UsuarioEnvioCorreo";
            this.UsuarioEnvioCorreo.ReadOnly = true;
            // 
            // NroEnvioCorreo
            // 
            this.NroEnvioCorreo.DataPropertyName = "NroEnvioCorreo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NroEnvioCorreo.DefaultCellStyle = dataGridViewCellStyle9;
            this.NroEnvioCorreo.HeaderText = "# Envíos";
            this.NroEnvioCorreo.Name = "NroEnvioCorreo";
            this.NroEnvioCorreo.ReadOnly = true;
            this.NroEnvioCorreo.Width = 60;
            // 
            // iNumRenovaciones
            // 
            this.iNumRenovaciones.DataPropertyName = "iNumRenovaciones";
            this.iNumRenovaciones.HeaderText = "iNumRenovaciones";
            this.iNumRenovaciones.Name = "iNumRenovaciones";
            this.iNumRenovaciones.ReadOnly = true;
            this.iNumRenovaciones.Visible = false;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 45);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(40, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Fecha";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dtDesembolsoInicio
            // 
            this.dtDesembolsoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesembolsoInicio.Location = new System.Drawing.Point(59, 46);
            this.dtDesembolsoInicio.Name = "dtDesembolsoInicio";
            this.dtDesembolsoInicio.Size = new System.Drawing.Size(102, 20);
            this.dtDesembolsoInicio.TabIndex = 8;
            // 
            // dtDesembolsoFin
            // 
            this.dtDesembolsoFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesembolsoFin.Location = new System.Drawing.Point(195, 46);
            this.dtDesembolsoFin.Name = "dtDesembolsoFin";
            this.dtDesembolsoFin.Size = new System.Drawing.Size(102, 20);
            this.dtDesembolsoFin.TabIndex = 9;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(162, 46);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(23, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Al";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblFinanciera
            // 
            // 
            // 
            // 
            this.lblFinanciera.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFinanciera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinanciera.Location = new System.Drawing.Point(383, 16);
            this.lblFinanciera.Name = "lblFinanciera";
            this.lblFinanciera.Size = new System.Drawing.Size(372, 23);
            this.lblFinanciera.TabIndex = 11;
            // 
            // frmMntLote
            // 
            this.ClientSize = new System.Drawing.Size(1398, 659);
            this.Controls.Add(this.dgvLote);
            this.DoubleBuffered = true;
            this.Name = "frmMntLote";
            this.Text = "Registro de Planillas";
            this.Load += new System.EventHandler(this.frmMntLote_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvLote, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLote;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DateTimePicker dtDesembolsoFin;
        private System.Windows.Forms.DateTimePicker dtDesembolsoInicio;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btnVisorFirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdAprobacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdDesembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDesembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITransito;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOperacion_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFormaDesembolso_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioConfirmadoPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtConfirmadoPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlgActualizarFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEnvioCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioEnvioCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroEnvioCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNumRenovaciones;
        private DevComponents.DotNetBar.LabelX lblFinanciera;
    }
}