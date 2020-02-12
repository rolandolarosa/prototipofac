namespace EfideFactoring.Formula.Catalogo
{
    partial class frmMntTablasBasicas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTablasHijos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Table_IdH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Parent_IdH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_NameH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_ValueH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_OrderH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTablasPadre = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Table_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Parent_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblregdet = new DevComponents.DotNetBar.LabelX();
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnEditarHijo = new DevComponents.DotNetBar.ButtonX();
            this.btnNuevoHijo = new DevComponents.DotNetBar.ButtonX();
            this.btnModificarPadre = new DevComponents.DotNetBar.ButtonX();
            this.btnNuevoPadre = new DevComponents.DotNetBar.ButtonX();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.txtTabla = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDetalle = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablasHijos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablasPadre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablasHijos
            // 
            this.dgvTablasHijos.AllowUserToAddRows = false;
            this.dgvTablasHijos.AllowUserToDeleteRows = false;
            this.dgvTablasHijos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablasHijos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTablasHijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablasHijos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table_IdH,
            this.Table_Parent_IdH,
            this.Table_NameH,
            this.Table_ValueH,
            this.Table_OrderH});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablasHijos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTablasHijos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTablasHijos.Location = new System.Drawing.Point(339, 38);
            this.dgvTablasHijos.Name = "dgvTablasHijos";
            this.dgvTablasHijos.ReadOnly = true;
            this.dgvTablasHijos.RowHeadersWidth = 10;
            this.dgvTablasHijos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTablasHijos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTablasHijos.Size = new System.Drawing.Size(523, 358);
            this.dgvTablasHijos.TabIndex = 34;
            // 
            // Table_IdH
            // 
            this.Table_IdH.DataPropertyName = "Table_Id";
            this.Table_IdH.HeaderText = "Código";
            this.Table_IdH.Name = "Table_IdH";
            this.Table_IdH.ReadOnly = true;
            this.Table_IdH.Width = 65;
            // 
            // Table_Parent_IdH
            // 
            this.Table_Parent_IdH.DataPropertyName = "Table_Parent_Id";
            this.Table_Parent_IdH.HeaderText = "Table_Parent_Id";
            this.Table_Parent_IdH.Name = "Table_Parent_IdH";
            this.Table_Parent_IdH.ReadOnly = true;
            this.Table_Parent_IdH.Visible = false;
            this.Table_Parent_IdH.Width = 111;
            // 
            // Table_NameH
            // 
            this.Table_NameH.DataPropertyName = "Table_Name";
            this.Table_NameH.HeaderText = "Descripción";
            this.Table_NameH.Name = "Table_NameH";
            this.Table_NameH.ReadOnly = true;
            this.Table_NameH.Width = 88;
            // 
            // Table_ValueH
            // 
            this.Table_ValueH.DataPropertyName = "Table_Value";
            this.Table_ValueH.HeaderText = "Valor";
            this.Table_ValueH.Name = "Table_ValueH";
            this.Table_ValueH.ReadOnly = true;
            this.Table_ValueH.Width = 56;
            // 
            // Table_OrderH
            // 
            this.Table_OrderH.DataPropertyName = "Table_Order";
            this.Table_OrderH.HeaderText = "Orden";
            this.Table_OrderH.Name = "Table_OrderH";
            this.Table_OrderH.ReadOnly = true;
            this.Table_OrderH.Width = 61;
            // 
            // dgvTablasPadre
            // 
            this.dgvTablasPadre.AllowUserToAddRows = false;
            this.dgvTablasPadre.AllowUserToDeleteRows = false;
            this.dgvTablasPadre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTablasPadre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTablasPadre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablasPadre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table_Id,
            this.Table_Parent_Id,
            this.Table_Name,
            this.Table_Order,
            this.Table_Value});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablasPadre.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTablasPadre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTablasPadre.Location = new System.Drawing.Point(10, 38);
            this.dgvTablasPadre.Name = "dgvTablasPadre";
            this.dgvTablasPadre.ReadOnly = true;
            this.dgvTablasPadre.RowHeadersWidth = 10;
            this.dgvTablasPadre.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTablasPadre.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTablasPadre.Size = new System.Drawing.Size(313, 358);
            this.dgvTablasPadre.TabIndex = 33;
            this.dgvTablasPadre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablasPadre_CellClick);
            this.dgvTablasPadre.SelectionChanged += new System.EventHandler(this.dgvTablasPadre_SelectionChanged);
            // 
            // Table_Id
            // 
            this.Table_Id.DataPropertyName = "Table_Id";
            this.Table_Id.HeaderText = "Código";
            this.Table_Id.Name = "Table_Id";
            this.Table_Id.ReadOnly = true;
            this.Table_Id.Width = 65;
            // 
            // Table_Parent_Id
            // 
            this.Table_Parent_Id.DataPropertyName = "Table_Parent_Id";
            this.Table_Parent_Id.HeaderText = "Table_Parent_Id";
            this.Table_Parent_Id.Name = "Table_Parent_Id";
            this.Table_Parent_Id.ReadOnly = true;
            this.Table_Parent_Id.Visible = false;
            this.Table_Parent_Id.Width = 111;
            // 
            // Table_Name
            // 
            this.Table_Name.DataPropertyName = "Table_Name";
            this.Table_Name.HeaderText = "Descripción";
            this.Table_Name.Name = "Table_Name";
            this.Table_Name.ReadOnly = true;
            this.Table_Name.Width = 88;
            // 
            // Table_Order
            // 
            this.Table_Order.DataPropertyName = "Table_Order";
            this.Table_Order.HeaderText = "Table_Order";
            this.Table_Order.Name = "Table_Order";
            this.Table_Order.ReadOnly = true;
            this.Table_Order.Visible = false;
            this.Table_Order.Width = 91;
            // 
            // Table_Value
            // 
            this.Table_Value.DataPropertyName = "Table_Value";
            this.Table_Value.HeaderText = "Table_Value";
            this.Table_Value.Name = "Table_Value";
            this.Table_Value.ReadOnly = true;
            this.Table_Value.Visible = false;
            this.Table_Value.Width = 92;
            // 
            // lblregdet
            // 
            this.lblregdet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblregdet.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblregdet.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblregdet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblregdet.Location = new System.Drawing.Point(784, 11);
            this.lblregdet.Name = "lblregdet";
            this.lblregdet.Size = new System.Drawing.Size(75, 25);
            this.lblregdet.TabIndex = 32;
            this.lblregdet.Text = "0 registro(s)";
            this.lblregdet.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblRegistros
            // 
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistros.Location = new System.Drawing.Point(234, 12);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(89, 23);
            this.lblRegistros.TabIndex = 31;
            this.lblRegistros.Text = "0 registro(s)";
            this.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // LabelX2
            // 
            this.LabelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelX2.Location = new System.Drawing.Point(339, 11);
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Size = new System.Drawing.Size(75, 23);
            this.LabelX2.TabIndex = 30;
            this.LabelX2.Text = "Detalle";
            // 
            // LabelX1
            // 
            this.LabelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelX1.Location = new System.Drawing.Point(10, 11);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(75, 23);
            this.LabelX1.TabIndex = 29;
            this.LabelX1.Text = "Tablas";
            // 
            // btnEditarHijo
            // 
            this.btnEditarHijo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarHijo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditarHijo.Image = global::EfideFactoring.Properties.Resources.modifica;
            this.btnEditarHijo.Location = new System.Drawing.Point(408, 401);
            this.btnEditarHijo.Name = "btnEditarHijo";
            this.btnEditarHijo.Size = new System.Drawing.Size(63, 26);
            this.btnEditarHijo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditarHijo.TabIndex = 39;
            this.btnEditarHijo.Text = "Editar";
            this.btnEditarHijo.Click += new System.EventHandler(this.btnEditarHijo_Click);
            // 
            // btnNuevoHijo
            // 
            this.btnNuevoHijo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNuevoHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoHijo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNuevoHijo.Image = global::EfideFactoring.Properties.Resources.nuevo;
            this.btnNuevoHijo.Location = new System.Drawing.Point(339, 401);
            this.btnNuevoHijo.Name = "btnNuevoHijo";
            this.btnNuevoHijo.Size = new System.Drawing.Size(63, 26);
            this.btnNuevoHijo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNuevoHijo.TabIndex = 38;
            this.btnNuevoHijo.Text = "Nuevo";
            this.btnNuevoHijo.Click += new System.EventHandler(this.btnNuevoHijo_Click);
            // 
            // btnModificarPadre
            // 
            this.btnModificarPadre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModificarPadre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarPadre.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnModificarPadre.Image = global::EfideFactoring.Properties.Resources.modifica;
            this.btnModificarPadre.Location = new System.Drawing.Point(79, 401);
            this.btnModificarPadre.Name = "btnModificarPadre";
            this.btnModificarPadre.Size = new System.Drawing.Size(63, 26);
            this.btnModificarPadre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnModificarPadre.TabIndex = 37;
            this.btnModificarPadre.Text = "Editar";
            this.btnModificarPadre.Click += new System.EventHandler(this.btnModificarPadre_Click);
            // 
            // btnNuevoPadre
            // 
            this.btnNuevoPadre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNuevoPadre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoPadre.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNuevoPadre.Image = global::EfideFactoring.Properties.Resources.nuevo;
            this.btnNuevoPadre.Location = new System.Drawing.Point(10, 401);
            this.btnNuevoPadre.Name = "btnNuevoPadre";
            this.btnNuevoPadre.Size = new System.Drawing.Size(63, 26);
            this.btnNuevoPadre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNuevoPadre.TabIndex = 36;
            this.btnNuevoPadre.Text = "Nuevo";
            this.btnNuevoPadre.Click += new System.EventHandler(this.btnNuevoPadre_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalir.Image = global::EfideFactoring.Properties.Resources.cerrar;
            this.btnSalir.Location = new System.Drawing.Point(784, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 30);
            this.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtTabla
            // 
            // 
            // 
            // 
            this.txtTabla.Border.Class = "TextBoxBorder";
            this.txtTabla.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTabla.Location = new System.Drawing.Point(49, 11);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(203, 20);
            this.txtTabla.TabIndex = 40;
            this.txtTabla.TextChanged += new System.EventHandler(this.txtTabla_TextChanged);
            // 
            // txtDetalle
            // 
            // 
            // 
            // 
            this.txtDetalle.Border.Class = "TextBoxBorder";
            this.txtDetalle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDetalle.Location = new System.Drawing.Point(378, 10);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(415, 20);
            this.txtDetalle.TabIndex = 41;
            this.txtDetalle.TextChanged += new System.EventHandler(this.txtDetalle_TextChanged);
            // 
            // frmMntTablasBasicas
            // 
            this.ClientSize = new System.Drawing.Size(873, 466);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.btnEditarHijo);
            this.Controls.Add(this.btnNuevoHijo);
            this.Controls.Add(this.btnModificarPadre);
            this.Controls.Add(this.btnNuevoPadre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvTablasHijos);
            this.Controls.Add(this.dgvTablasPadre);
            this.Controls.Add(this.lblregdet);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.LabelX2);
            this.Controls.Add(this.LabelX1);
            this.DoubleBuffered = true;
            this.Name = "frmMntTablasBasicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablas Básicas";
            this.Load += new System.EventHandler(this.frmMntTablasBasicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablasHijos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablasPadre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.ButtonX btnEditarHijo;
        internal DevComponents.DotNetBar.ButtonX btnNuevoHijo;
        internal DevComponents.DotNetBar.ButtonX btnModificarPadre;
        internal DevComponents.DotNetBar.ButtonX btnNuevoPadre;
        internal DevComponents.DotNetBar.ButtonX btnSalir;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvTablasHijos;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvTablasPadre;
        internal DevComponents.DotNetBar.LabelX lblregdet;
        internal DevComponents.DotNetBar.LabelX lblRegistros;
        internal DevComponents.DotNetBar.LabelX LabelX2;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Parent_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_IdH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Parent_IdH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_NameH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_ValueH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_OrderH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTabla;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDetalle;
    }
}