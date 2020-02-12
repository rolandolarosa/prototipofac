namespace Efide.Tesoreria.WinAdeudosInversiones.cuentaBancos
{
    partial class frmListCuentaBancos
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
            this.ucLoadingBar1 = new Efide.ControlsComponent.ucLoadingBar();
            this.ucMsgBox1 = new Efide.ControlsComponent.ucMsgBox();
            this.cboTipoEntidadFinanciera = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dgvCuentaBancos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaBancos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            // 
            // 
            // 
            this.toolBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolBar.Size = new System.Drawing.Size(1023, 39);
            // 
            // 
            // 
            this.toolBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.cboTipoEntidadFinanciera);
            this.pnlFiltro.Controls.Add(this.labelX6);
            this.pnlFiltro.Location = new System.Drawing.Point(0, 45);
            this.pnlFiltro.Size = new System.Drawing.Size(1022, 43);
            this.pnlFiltro.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlFiltro.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlFiltro.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlFiltro.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlFiltro.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlFiltro.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlFiltro.Style.GradientAngle = 90;
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ucLoadingBar1
            // 
            this.ucLoadingBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadingBar1.Location = new System.Drawing.Point(672, 390);
            this.ucLoadingBar1.Name = "ucLoadingBar1";
            this.ucLoadingBar1.Size = new System.Drawing.Size(167, 26);
            this.ucLoadingBar1.TabIndex = 24;
            // 
            // ucMsgBox1
            // 
            this.ucMsgBox1.Location = new System.Drawing.Point(85, 393);
            this.ucMsgBox1.Name = "ucMsgBox1";
            this.ucMsgBox1.Size = new System.Drawing.Size(10, 10);
            this.ucMsgBox1.TabIndex = 25;
            // 
            // cboTipoEntidadFinanciera
            // 
            this.cboTipoEntidadFinanciera.DisplayMember = "Text";
            this.cboTipoEntidadFinanciera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoEntidadFinanciera.FormattingEnabled = true;
            this.cboTipoEntidadFinanciera.ItemHeight = 14;
            this.cboTipoEntidadFinanciera.Location = new System.Drawing.Point(110, 12);
            this.cboTipoEntidadFinanciera.Name = "cboTipoEntidadFinanciera";
            this.cboTipoEntidadFinanciera.Size = new System.Drawing.Size(238, 20);
            this.cboTipoEntidadFinanciera.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoEntidadFinanciera.TabIndex = 60;
            this.cboTipoEntidadFinanciera.SelectedIndexChanged += new System.EventHandler(this.cboTipoEntidadFinanciera_SelectedIndexChanged);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(13, 10);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(91, 23);
            this.labelX6.TabIndex = 59;
            this.labelX6.Text = "Tipo Financiera:";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvCuentaBancos
            // 
            this.dgvCuentaBancos.AllowUserToAddRows = false;
            this.dgvCuentaBancos.AllowUserToDeleteRows = false;
            this.dgvCuentaBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentaBancos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuentaBancos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentaBancos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCuentaBancos.Location = new System.Drawing.Point(0, 94);
            this.dgvCuentaBancos.MultiSelect = false;
            this.dgvCuentaBancos.Name = "dgvCuentaBancos";
            this.dgvCuentaBancos.ReadOnly = true;
            this.dgvCuentaBancos.RowHeadersVisible = false;
            this.dgvCuentaBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentaBancos.Size = new System.Drawing.Size(1022, 290);
            this.dgvCuentaBancos.TabIndex = 26;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nomTipoEntidadFinanciera";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Tipo Financiera";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "emprRazonSocial";
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "Banco";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 250;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "nomMoneda";
            this.Column11.Frozen = true;
            this.Column11.HeaderText = "Moneda";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "nomTipoCuenta";
            this.Column12.Frozen = true;
            this.Column12.HeaderText = "Tipo Cuenta";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 150;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "cuentaLocal";
            this.Column13.Frozen = true;
            this.Column13.HeaderText = "Local";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "cuentaCCI";
            this.Column14.Frozen = true;
            this.Column14.HeaderText = "CCI";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 200;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "cuentaBancoID";
            this.Column15.HeaderText = "cuentaBancoID";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            this.Column15.Width = 200;
            // 
            // frmListCuentaBancos
            // 
            this.ClientSize = new System.Drawing.Size(1023, 413);
            this.Controls.Add(this.dgvCuentaBancos);
            this.Controls.Add(this.ucMsgBox1);
            this.Controls.Add(this.ucLoadingBar1);
            this.DoubleBuffered = true;
            this.Name = "frmListCuentaBancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmListCuentaBancos";
            this.Load += new System.EventHandler(this.frmListCuentaBancos_Load);
            this.Controls.SetChildIndex(this.ucLoadingBar1, 0);
            this.Controls.SetChildIndex(this.ucMsgBox1, 0);
            this.Controls.SetChildIndex(this.dgvCuentaBancos, 0);
            this.Controls.SetChildIndex(this.toolBar, 0);
            this.Controls.SetChildIndex(this.pnlFiltro, 0);
            this.pnlFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaBancos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsComponent.ucLoadingBar ucLoadingBar1;
        private ControlsComponent.ucMsgBox ucMsgBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoEntidadFinanciera;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCuentaBancos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}