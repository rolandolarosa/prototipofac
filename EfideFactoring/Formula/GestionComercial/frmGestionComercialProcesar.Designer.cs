namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmGestionComercialProcesar
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
            this.cboMes = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtAño = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnProcesar = new DevComponents.DotNetBar.ButtonX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.btnProcesar);
            this.grpDato.Controls.Add(this.cboMes);
            this.grpDato.Controls.Add(this.labelX3);
            this.grpDato.Controls.Add(this.txtAño);
            this.grpDato.Controls.Add(this.LabelX1);
            this.grpDato.Size = new System.Drawing.Size(324, 128);
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
            this.btnCancelar.Location = new System.Drawing.Point(243, 149);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(152, 149);
            this.btnAceptar.Visible = false;
            // 
            // cboMes
            // 
            this.cboMes.DisplayMember = "Text";
            this.cboMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.ItemHeight = 14;
            this.cboMes.Items.AddRange(new object[] {
            this.comboItem2});
            this.cboMes.Location = new System.Drawing.Point(99, 55);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(141, 20);
            this.cboMes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMes.TabIndex = 19;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "<< Todos >>";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(34, 55);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 20);
            this.labelX3.TabIndex = 18;
            this.labelX3.Text = "Mes";
            // 
            // txtAño
            // 
            // 
            // 
            // 
            this.txtAño.Border.Class = "TextBoxBorder";
            this.txtAño.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAño.Location = new System.Drawing.Point(99, 29);
            this.txtAño.Name = "txtAño";
            this.txtAño.ReadOnly = true;
            this.txtAño.Size = new System.Drawing.Size(77, 20);
            this.txtAño.TabIndex = 17;
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelX1
            // 
            this.LabelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelX1.Location = new System.Drawing.Point(34, 29);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(59, 20);
            this.LabelX1.TabIndex = 16;
            this.LabelX1.Text = "Año";
            // 
            // btnProcesar
            // 
            this.btnProcesar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProcesar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnProcesar.Image = global::EfideFactoring.Properties.Resources.refresh;
            this.btnProcesar.Location = new System.Drawing.Point(99, 81);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(104, 23);
            this.btnProcesar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnProcesar.TabIndex = 20;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // frmGestionComercialProcesar
            // 
            this.ClientSize = new System.Drawing.Size(332, 185);
            this.DoubleBuffered = true;
            this.Name = "frmGestionComercialProcesar";
            this.Text = "Procesar Mes - Gestión Comercial";
            this.Load += new System.EventHandler(this.frmGestionComercialProcesar_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMes;
        private DevComponents.Editors.ComboItem comboItem2;
        protected DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAño;
        protected DevComponents.DotNetBar.LabelX LabelX1;
        private DevComponents.DotNetBar.ButtonX btnProcesar;
    }
}