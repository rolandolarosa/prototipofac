namespace EfideFactoring.Formula.Registros
{
    partial class frmGeneracionLote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnProcesar = new DevComponents.DotNetBar.ButtonItem();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.lblGrilla = new DevComponents.DotNetBar.LabelX();
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.dgvLote = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.FlgSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlazoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcRetencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoRetencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inconsistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMensaje = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
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
            this.btnProcesar,
            this.btnSalir});
            this.RibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.RibbonBar1.Name = "RibbonBar1";
            this.RibbonBar1.Size = new System.Drawing.Size(1248, 40);
            this.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.RibbonBar1.TabIndex = 18;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnProcesar
            // 
            this.btnProcesar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnProcesar.Image = global::EfideFactoring.Properties.Resources.refresh;
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.SubItemsExpandWidth = 14;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
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
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrilla.Location = new System.Drawing.Point(0, 100);
            this.lblGrilla.Name = "lblGrilla";
            this.lblGrilla.Size = new System.Drawing.Size(108, 23);
            this.lblGrilla.TabIndex = 24;
            this.lblGrilla.Text = "Datos";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistros.Location = new System.Drawing.Point(1072, 100);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(176, 22);
            this.lblRegistros.TabIndex = 23;
            this.lblRegistros.Text = "0  registro(s)";
            this.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(459, 30);
            this.TextBoxX1.Name = "TextBoxX1";
            this.TextBoxX1.Size = new System.Drawing.Size(105, 20);
            this.TextBoxX1.TabIndex = 1;
            this.TextBoxX1.Visible = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelX1.Location = new System.Drawing.Point(459, 6);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(59, 23);
            this.LabelX1.TabIndex = 0;
            this.LabelX1.Text = "Socio";
            this.LabelX1.Visible = false;
            // 
            // PanelEx1
            // 
            this.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.PanelEx1.Controls.Add(this.buttonX1);
            this.PanelEx1.Controls.Add(this.btnLimpiar);
            this.PanelEx1.Controls.Add(this.btnBuscar);
            this.PanelEx1.Controls.Add(this.TextBoxX1);
            this.PanelEx1.Controls.Add(this.LabelX1);
            this.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx1.Location = new System.Drawing.Point(0, 40);
            this.PanelEx1.Name = "PanelEx1";
            this.PanelEx1.Size = new System.Drawing.Size(1248, 54);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.TabIndex = 22;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::EfideFactoring.Properties.Resources.refresh;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX1.Location = new System.Drawing.Point(210, 4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(208, 44);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "Actualiza Nuevos Socios en la Web";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(570, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 44);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Visible = false;

            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = global::EfideFactoring.Properties.Resources.buscar;
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(13, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 44);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.FlgSelect,
            this.IdMovimiento,
            this.Pagadora,
            this.Socio,
            this.Documento,
            this.NumeroDocumento,
            this.PlazoPago,
            this.Fecha_Registro,
            this.Fecha_Emision,
            this.Fecha_Vencimiento,
            this.Moneda,
            this.ImporteOriginal,
            this.TipoCambio,
            this.PorcRetencion,
            this.MontoRetencion,
            this.Descuentos,
            this.IdLote,
            this.Inconsistencia,
            this.btnMensaje});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLote.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLote.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLote.Location = new System.Drawing.Point(0, 128);
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.RowHeadersWidth = 10;
            this.dgvLote.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLote.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLote.Size = new System.Drawing.Size(1248, 268);
            this.dgvLote.TabIndex = 25;
            this.dgvLote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLote_CellClick);
            this.dgvLote.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvLote_CurrentCellDirtyStateChanged);
            // 
            // FlgSelect
            // 
            this.FlgSelect.DataPropertyName = "FlgSelect";
            this.FlgSelect.HeaderText = "";
            this.FlgSelect.Name = "FlgSelect";
            this.FlgSelect.Width = 40;
            // 
            // IdMovimiento
            // 
            this.IdMovimiento.DataPropertyName = "IdMovimiento";
            this.IdMovimiento.HeaderText = "IdMovimiento";
            this.IdMovimiento.Name = "IdMovimiento";
            this.IdMovimiento.ReadOnly = true;
            this.IdMovimiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdMovimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdMovimiento.Visible = false;
            // 
            // Pagadora
            // 
            this.Pagadora.DataPropertyName = "Pagadora";
            this.Pagadora.HeaderText = "Pagadora";
            this.Pagadora.Name = "Pagadora";
            this.Pagadora.ReadOnly = true;
            this.Pagadora.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pagadora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Pagadora.Width = 120;
            // 
            // Socio
            // 
            this.Socio.DataPropertyName = "Socio";
            this.Socio.HeaderText = "Socio";
            this.Socio.Name = "Socio";
            this.Socio.ReadOnly = true;
            this.Socio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Socio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Socio.Width = 120;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Doc";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Documento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Documento.Width = 40;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.NumeroDocumento.HeaderText = "N° Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NumeroDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NumeroDocumento.Width = 120;
            // 
            // PlazoPago
            // 
            this.PlazoPago.DataPropertyName = "PlazoPago";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PlazoPago.DefaultCellStyle = dataGridViewCellStyle1;
            this.PlazoPago.HeaderText = "Plazo";
            this.PlazoPago.Name = "PlazoPago";
            this.PlazoPago.ReadOnly = true;
            this.PlazoPago.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PlazoPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PlazoPago.Width = 40;
            // 
            // Fecha_Registro
            // 
            this.Fecha_Registro.DataPropertyName = "Fecha_Registro";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha_Registro.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha_Registro.HeaderText = "Fecha Registro";
            this.Fecha_Registro.Name = "Fecha_Registro";
            this.Fecha_Registro.ReadOnly = true;
            this.Fecha_Registro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fecha_Registro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha_Registro.Width = 70;
            // 
            // Fecha_Emision
            // 
            this.Fecha_Emision.DataPropertyName = "Fecha_Emision";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Fecha_Emision.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha_Emision.HeaderText = "Fecha Emision";
            this.Fecha_Emision.Name = "Fecha_Emision";
            this.Fecha_Emision.ReadOnly = true;
            this.Fecha_Emision.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fecha_Emision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha_Emision.Width = 70;
            // 
            // Fecha_Vencimiento
            // 
            this.Fecha_Vencimiento.DataPropertyName = "Fecha_Vencimiento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Fecha_Vencimiento.DefaultCellStyle = dataGridViewCellStyle4;
            this.Fecha_Vencimiento.HeaderText = "Fecha Vencimiento";
            this.Fecha_Vencimiento.Name = "Fecha_Vencimiento";
            this.Fecha_Vencimiento.ReadOnly = true;
            this.Fecha_Vencimiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fecha_Vencimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha_Vencimiento.Width = 70;
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "Moneda";
            this.Moneda.HeaderText = "Mon";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            this.Moneda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Moneda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Moneda.Width = 30;
            // 
            // ImporteOriginal
            // 
            this.ImporteOriginal.DataPropertyName = "ImporteOriginal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.ImporteOriginal.DefaultCellStyle = dataGridViewCellStyle5;
            this.ImporteOriginal.HeaderText = "V. Nominal";
            this.ImporteOriginal.Name = "ImporteOriginal";
            this.ImporteOriginal.ReadOnly = true;
            this.ImporteOriginal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TipoCambio
            // 
            this.TipoCambio.DataPropertyName = "TipoCambio";
            this.TipoCambio.HeaderText = "Tipo Cambio";
            this.TipoCambio.Name = "TipoCambio";
            this.TipoCambio.ReadOnly = true;
            this.TipoCambio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoCambio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TipoCambio.Visible = false;
            // 
            // PorcRetencion
            // 
            this.PorcRetencion.DataPropertyName = "PorcRetencion";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PorcRetencion.DefaultCellStyle = dataGridViewCellStyle6;
            this.PorcRetencion.HeaderText = "% Retencion";
            this.PorcRetencion.Name = "PorcRetencion";
            this.PorcRetencion.ReadOnly = true;
            this.PorcRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PorcRetencion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PorcRetencion.Visible = false;
            // 
            // MontoRetencion
            // 
            this.MontoRetencion.DataPropertyName = "MontoRetencion";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.MontoRetencion.DefaultCellStyle = dataGridViewCellStyle7;
            this.MontoRetencion.HeaderText = "Retencion";
            this.MontoRetencion.Name = "MontoRetencion";
            this.MontoRetencion.ReadOnly = true;
            this.MontoRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MontoRetencion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MontoRetencion.Width = 70;
            // 
            // Descuentos
            // 
            this.Descuentos.DataPropertyName = "Descuentos";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.Descuentos.DefaultCellStyle = dataGridViewCellStyle8;
            this.Descuentos.HeaderText = "Descuento";
            this.Descuentos.Name = "Descuentos";
            this.Descuentos.ReadOnly = true;
            this.Descuentos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descuentos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Descuentos.Width = 90;
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "IdLote";
            this.IdLote.HeaderText = "Lote";
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            this.IdLote.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdLote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Inconsistencia
            // 
            this.Inconsistencia.DataPropertyName = "Inconsistencia";
            this.Inconsistencia.HeaderText = "Inconsistencia";
            this.Inconsistencia.Name = "Inconsistencia";
            this.Inconsistencia.Visible = false;
            // 
            // btnMensaje
            // 
            this.btnMensaje.HeaderText = "";
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Text = "Ver Inconsistencias";
            this.btnMensaje.UseColumnTextForButtonValue = true;
            // 
            // frmGeneracionLote
            // 
            this.ClientSize = new System.Drawing.Size(1248, 408);
            this.Controls.Add(this.dgvLote);
            this.Controls.Add(this.lblGrilla);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.PanelEx1);
            this.Controls.Add(this.RibbonBar1);
            this.DoubleBuffered = true;
            this.Name = "frmGeneracionLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generación de Lotes de Factoring Web";
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.RibbonBar RibbonBar1;
        protected DevComponents.DotNetBar.ButtonItem btnSalir;
        protected DevComponents.DotNetBar.LabelX lblGrilla;
        protected DevComponents.DotNetBar.LabelX lblRegistros;
        protected DevComponents.DotNetBar.ButtonX btnLimpiar;
        protected DevComponents.DotNetBar.ButtonX btnBuscar;
        protected DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1;
        protected DevComponents.DotNetBar.LabelX LabelX1;
        protected DevComponents.DotNetBar.PanelEx PanelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLote;
        protected DevComponents.DotNetBar.ButtonItem btnProcesar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FlgSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlazoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Emision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcRetencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoRetencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inconsistencia;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btnMensaje;
        protected DevComponents.DotNetBar.ButtonX buttonX1;
    }
}