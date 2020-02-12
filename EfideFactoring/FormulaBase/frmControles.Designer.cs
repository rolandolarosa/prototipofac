namespace EfideFactoring.FormulaBase
{
    partial class frmControles
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
            this.TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvPagadoras = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcNComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcNombreCPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNacional = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboIdCargo_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtDesembolsoFin = new System.Windows.Forms.DateTimePicker();
            this.dtDesembolsoInicio = new System.Windows.Forms.DateTimePicker();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagadoras)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(28, 52);
            this.TextBoxX1.Name = "TextBoxX1";
            this.TextBoxX1.Size = new System.Drawing.Size(210, 20);
            this.TextBoxX1.TabIndex = 8;
            // 
            // LabelX1
            // 
            this.LabelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelX1.Location = new System.Drawing.Point(28, 23);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(59, 23);
            this.LabelX1.TabIndex = 7;
            this.LabelX1.Text = "LabelX1";
            // 
            // dgvPagadoras
            // 
            this.dgvPagadoras.AllowUserToAddRows = false;
            this.dgvPagadoras.AllowUserToDeleteRows = false;
            this.dgvPagadoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagadoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPagadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagadoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPagadora,
            this.vcPagadora,
            this.vcNComercial,
            this.vcNombreCPagadora,
            this.bNacional});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagadoras.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagadoras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPagadoras.Location = new System.Drawing.Point(28, 139);
            this.dgvPagadoras.Name = "dgvPagadoras";
            this.dgvPagadoras.ReadOnly = true;
            this.dgvPagadoras.RowHeadersWidth = 10;
            this.dgvPagadoras.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPagadoras.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPagadoras.Size = new System.Drawing.Size(371, 148);
            this.dgvPagadoras.TabIndex = 23;
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "Código";
            this.IdPagadora.Name = "IdPagadora";
            this.IdPagadora.ReadOnly = true;
            this.IdPagadora.Width = 65;
            // 
            // vcPagadora
            // 
            this.vcPagadora.DataPropertyName = "vcPagadora";
            this.vcPagadora.HeaderText = "Pagadora";
            this.vcPagadora.Name = "vcPagadora";
            this.vcPagadora.ReadOnly = true;
            this.vcPagadora.Width = 78;
            // 
            // vcNComercial
            // 
            this.vcNComercial.DataPropertyName = "vcNComercial";
            this.vcNComercial.HeaderText = "Nombre Comercial";
            this.vcNComercial.Name = "vcNComercial";
            this.vcNComercial.ReadOnly = true;
            this.vcNComercial.Width = 108;
            // 
            // vcNombreCPagadora
            // 
            this.vcNombreCPagadora.DataPropertyName = "vcNombreCPagadora";
            this.vcNombreCPagadora.HeaderText = "Nombre Corto";
            this.vcNombreCPagadora.Name = "vcNombreCPagadora";
            this.vcNombreCPagadora.ReadOnly = true;
            this.vcNombreCPagadora.Visible = false;
            this.vcNombreCPagadora.Width = 89;
            // 
            // bNacional
            // 
            this.bNacional.DataPropertyName = "bNacional";
            this.bNacional.HeaderText = "Nacional";
            this.bNacional.Name = "bNacional";
            this.bNacional.ReadOnly = true;
            this.bNacional.Width = 55;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Location = new System.Drawing.Point(433, 139);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(200, 81);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 24;
            this.groupPanel1.Text = "groupPanel1";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(107, 22);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(59, 23);
            this.labelX2.TabIndex = 25;
            this.labelX2.Text = "labelX2";
            // 
            // cboIdCargo_tt
            // 
            this.cboIdCargo_tt.DisplayMember = "Text";
            this.cboIdCargo_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdCargo_tt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdCargo_tt.FormattingEnabled = true;
            this.cboIdCargo_tt.ItemHeight = 14;
            this.cboIdCargo_tt.Location = new System.Drawing.Point(276, 52);
            this.cboIdCargo_tt.Name = "cboIdCargo_tt";
            this.cboIdCargo_tt.Size = new System.Drawing.Size(219, 20);
            this.cboIdCargo_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdCargo_tt.TabIndex = 73;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(107, 78);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 44);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = global::EfideFactoring.Properties.Resources.buscar;
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(28, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 44);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Location = new System.Drawing.Point(447, 263);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(100, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 74;
            this.checkBoxX1.Text = "checkBoxX1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(15, 312);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 75;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(15, 336);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 76;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // switchButton1
            // 
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Location = new System.Drawing.Point(394, 312);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffText = "Apagado";
            this.switchButton1.OnText = "Encendido";
            this.switchButton1.Size = new System.Drawing.Size(128, 22);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 77;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(388, 90);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(23, 23);
            this.labelX3.TabIndex = 81;
            this.labelX3.Text = "Al";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dtDesembolsoFin
            // 
            this.dtDesembolsoFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesembolsoFin.Location = new System.Drawing.Point(421, 90);
            this.dtDesembolsoFin.Name = "dtDesembolsoFin";
            this.dtDesembolsoFin.Size = new System.Drawing.Size(102, 20);
            this.dtDesembolsoFin.TabIndex = 80;
            // 
            // dtDesembolsoInicio
            // 
            this.dtDesembolsoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesembolsoInicio.Location = new System.Drawing.Point(285, 90);
            this.dtDesembolsoInicio.Name = "dtDesembolsoInicio";
            this.dtDesembolsoInicio.Size = new System.Drawing.Size(102, 20);
            this.dtDesembolsoInicio.TabIndex = 79;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(240, 89);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(40, 23);
            this.labelX4.TabIndex = 78;
            this.labelX4.Text = "Fecha";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // frmControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 389);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.dtDesembolsoFin);
            this.Controls.Add(this.dtDesembolsoInicio);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.switchButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBoxX1);
            this.Controls.Add(this.cboIdCargo_tt);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dgvPagadoras);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.TextBoxX1);
            this.Controls.Add(this.LabelX1);
            this.Name = "frmControles";
            this.Text = "frmControles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagadoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevComponents.DotNetBar.ButtonX btnLimpiar;
        protected DevComponents.DotNetBar.ButtonX btnBuscar;
        protected DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1;
        protected DevComponents.DotNetBar.LabelX LabelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPagadoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcNComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcNombreCPagadora;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bNacional;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        protected DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdCargo_tt;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DateTimePicker dtDesembolsoFin;
        private System.Windows.Forms.DateTimePicker dtDesembolsoInicio;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}