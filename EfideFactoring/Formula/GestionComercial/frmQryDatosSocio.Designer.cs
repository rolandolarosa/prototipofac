namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmQryDatosSocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.btnEliminarCorreo = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarCorreo = new DevComponents.DotNetBar.ButtonX();
            this.dgvCorreos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tbCorreos = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.brnEliminarTelefono = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarTelefono = new DevComponents.DotNetBar.ButtonX();
            this.dgvTelefonos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.valorCodigoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.btnEliminarContacto = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarContactos = new DevComponents.DotNetBar.ButtonX();
            this.dgvContactos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos)).BeginInit();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.superTabControl1);
            this.grpDato.Size = new System.Drawing.Size(825, 272);
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
            this.btnCancelar.Location = new System.Drawing.Point(744, 293);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(653, 293);
            this.btnAceptar.Visible = false;
            // 
            // superTabControl1
            // 
            this.superTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Location = new System.Drawing.Point(5, 9);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 2;
            this.superTabControl1.Size = new System.Drawing.Size(812, 254);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 66;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2,
            this.tbCorreos});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.btnEliminarCorreo);
            this.superTabControlPanel3.Controls.Add(this.btnAgregarCorreo);
            this.superTabControlPanel3.Controls.Add(this.dgvCorreos);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(812, 229);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.tbCorreos;
            // 
            // btnEliminarCorreo
            // 
            this.btnEliminarCorreo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCorreo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminarCorreo.Image = global::EfideFactoring.Properties.Resources.elimina;
            this.btnEliminarCorreo.Location = new System.Drawing.Point(726, 0);
            this.btnEliminarCorreo.Name = "btnEliminarCorreo";
            this.btnEliminarCorreo.Size = new System.Drawing.Size(83, 24);
            this.btnEliminarCorreo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminarCorreo.TabIndex = 71;
            this.btnEliminarCorreo.Text = "&Eliminar";
            this.btnEliminarCorreo.Click += new System.EventHandler(this.btnEliminarCorreo_Click);
            // 
            // btnAgregarCorreo
            // 
            this.btnAgregarCorreo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCorreo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregarCorreo.Image = global::EfideFactoring.Properties.Resources.add;
            this.btnAgregarCorreo.Location = new System.Drawing.Point(641, 0);
            this.btnAgregarCorreo.Name = "btnAgregarCorreo";
            this.btnAgregarCorreo.Size = new System.Drawing.Size(83, 24);
            this.btnAgregarCorreo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregarCorreo.TabIndex = 70;
            this.btnAgregarCorreo.Text = "&Agregar";
            this.btnAgregarCorreo.Click += new System.EventHandler(this.btnAgregarCorreo_Click);
            // 
            // dgvCorreos
            // 
            this.dgvCorreos.AllowUserToAddRows = false;
            this.dgvCorreos.AllowUserToDeleteRows = false;
            this.dgvCorreos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCorreos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCorreos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCorreos.Location = new System.Drawing.Point(3, 27);
            this.dgvCorreos.Name = "dgvCorreos";
            this.dgvCorreos.ReadOnly = true;
            this.dgvCorreos.RowHeadersWidth = 10;
            this.dgvCorreos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCorreos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCorreos.Size = new System.Drawing.Size(806, 199);
            this.dgvCorreos.TabIndex = 65;
            // 
            // tbCorreos
            // 
            this.tbCorreos.AttachedControl = this.superTabControlPanel3;
            this.tbCorreos.GlobalItem = false;
            this.tbCorreos.Name = "tbCorreos";
            this.tbCorreos.Text = "Correos Eletrónicos";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.brnEliminarTelefono);
            this.superTabControlPanel2.Controls.Add(this.btnAgregarTelefono);
            this.superTabControlPanel2.Controls.Add(this.dgvTelefonos);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(812, 229);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // brnEliminarTelefono
            // 
            this.brnEliminarTelefono.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.brnEliminarTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnEliminarTelefono.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.brnEliminarTelefono.Image = global::EfideFactoring.Properties.Resources.elimina;
            this.brnEliminarTelefono.Location = new System.Drawing.Point(726, 2);
            this.brnEliminarTelefono.Name = "brnEliminarTelefono";
            this.brnEliminarTelefono.Size = new System.Drawing.Size(83, 24);
            this.brnEliminarTelefono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.brnEliminarTelefono.TabIndex = 72;
            this.brnEliminarTelefono.Text = "&Eliminar";
            this.brnEliminarTelefono.Click += new System.EventHandler(this.brnEliminarTelefono_Click);
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarTelefono.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregarTelefono.Image = global::EfideFactoring.Properties.Resources.add;
            this.btnAgregarTelefono.Location = new System.Drawing.Point(641, 2);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Size = new System.Drawing.Size(83, 24);
            this.btnAgregarTelefono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregarTelefono.TabIndex = 69;
            this.btnAgregarTelefono.Text = "&Agregar";
            this.btnAgregarTelefono.Click += new System.EventHandler(this.btnAgregarTelefono_Click);
            // 
            // dgvTelefonos
            // 
            this.dgvTelefonos.AllowUserToAddRows = false;
            this.dgvTelefonos.AllowUserToDeleteRows = false;
            this.dgvTelefonos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valorCodigoID,
            this.Origen,
            this.Tipo,
            this.Telefono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTelefonos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTelefonos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTelefonos.Location = new System.Drawing.Point(3, 26);
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.ReadOnly = true;
            this.dgvTelefonos.RowHeadersWidth = 10;
            this.dgvTelefonos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTelefonos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTelefonos.Size = new System.Drawing.Size(806, 200);
            this.dgvTelefonos.TabIndex = 65;
            // 
            // valorCodigoID
            // 
            this.valorCodigoID.DataPropertyName = "valorCodigoID";
            this.valorCodigoID.HeaderText = "valorCodigoID";
            this.valorCodigoID.Name = "valorCodigoID";
            this.valorCodigoID.ReadOnly = true;
            this.valorCodigoID.Visible = false;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "Origen";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Width = 60;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 70;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 150;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "Teléfonos";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.btnEliminarContacto);
            this.superTabControlPanel1.Controls.Add(this.btnAgregarContactos);
            this.superTabControlPanel1.Controls.Add(this.dgvContactos);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(812, 229);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarContacto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminarContacto.Image = global::EfideFactoring.Properties.Resources.elimina;
            this.btnEliminarContacto.Location = new System.Drawing.Point(726, 1);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(83, 24);
            this.btnEliminarContacto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminarContacto.TabIndex = 73;
            this.btnEliminarContacto.Text = "&Eliminar";
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // btnAgregarContactos
            // 
            this.btnAgregarContactos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarContactos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregarContactos.Image = global::EfideFactoring.Properties.Resources.add;
            this.btnAgregarContactos.Location = new System.Drawing.Point(641, 1);
            this.btnAgregarContactos.Name = "btnAgregarContactos";
            this.btnAgregarContactos.Size = new System.Drawing.Size(83, 24);
            this.btnAgregarContactos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregarContactos.TabIndex = 68;
            this.btnAgregarContactos.Text = "&Agregar";
            this.btnAgregarContactos.Click += new System.EventHandler(this.btnAgregarContactos_Click);
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContactos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContactos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvContactos.Location = new System.Drawing.Point(3, 26);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.RowHeadersWidth = 10;
            this.dgvContactos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvContactos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvContactos.Size = new System.Drawing.Size(806, 200);
            this.dgvContactos.TabIndex = 65;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Contactos";
            // 
            // frmQryDatosSocio
            // 
            this.ClientSize = new System.Drawing.Size(833, 329);
            this.DoubleBuffered = true;
            this.Name = "frmQryDatosSocio";
            this.Text = "Datos del Socio";
            this.Load += new System.EventHandler(this.frmQryDatosSocio_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos)).EndInit();
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.ButtonX btnEliminarContacto;
        private DevComponents.DotNetBar.ButtonX btnAgregarContactos;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvContactos;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.ButtonX brnEliminarTelefono;
        private DevComponents.DotNetBar.ButtonX btnAgregarTelefono;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTelefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCodigoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.ButtonX btnEliminarCorreo;
        private DevComponents.DotNetBar.ButtonX btnAgregarCorreo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCorreos;
        private DevComponents.DotNetBar.SuperTabItem tbCorreos;
    }
}