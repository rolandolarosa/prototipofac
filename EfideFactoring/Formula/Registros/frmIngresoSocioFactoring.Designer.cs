namespace EfideFactoring.Formula.Registros
{
    partial class frmIngresoSocio
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtRazonSocial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRuc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtCodT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.txtCodT);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.labelX3);
            this.grpDato.Controls.Add(this.txtRuc);
            this.grpDato.Controls.Add(this.txtRazonSocial);
            this.grpDato.Size = new System.Drawing.Size(480, 120);
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
            this.btnCancelar.Location = new System.Drawing.Point(399, 141);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(308, 141);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtRazonSocial
            // 
            // 
            // 
            // 
            this.txtRazonSocial.Border.Class = "TextBoxBorder";
            this.txtRazonSocial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRazonSocial.Location = new System.Drawing.Point(116, 49);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(300, 20);
            this.txtRazonSocial.TabIndex = 1;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            // 
            // txtRuc
            // 
            // 
            // 
            // 
            this.txtRuc.Border.Class = "TextBoxBorder";
            this.txtRuc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRuc.Location = new System.Drawing.Point(116, 74);
            this.txtRuc.MaxLength = 11;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(122, 20);
            this.txtRuc.TabIndex = 3;
            this.txtRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuc_KeyPress);
            this.txtRuc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRuc_KeyUp);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(26, 46);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Razón Social";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(26, 71);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "RUC";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(26, 23);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Código";
            // 
            // txtCodT
            // 
            this.txtCodT.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtCodT.Border.Class = "TextBoxBorder";
            this.txtCodT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodT.Enabled = false;
            this.txtCodT.Location = new System.Drawing.Point(116, 23);
            this.txtCodT.MaxLength = 11;
            this.txtCodT.Name = "txtCodT";
            this.txtCodT.Size = new System.Drawing.Size(72, 20);
            this.txtCodT.TabIndex = 5;
            // 
            // frmIngresoSocio
            // 
            this.ClientSize = new System.Drawing.Size(488, 177);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmIngresoSocio";
            this.Text = "Mantenimiento - Girador Original";
            this.Load += new System.EventHandler(this.frmIngresoSocio_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRuc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRazonSocial;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodT;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}