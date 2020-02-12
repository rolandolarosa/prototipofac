namespace EfideFactoring.Formula.Catalogo
{
    partial class frmMntMagnitudDato
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtcodCliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtrazonSocial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboMagnitudId = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.cboMagnitudId);
            this.grpDato.Controls.Add(this.txtrazonSocial);
            this.grpDato.Controls.Add(this.txtcodCliente);
            this.grpDato.Controls.Add(this.labelX3);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Size = new System.Drawing.Size(508, 111);
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
            this.btnCancelar.Location = new System.Drawing.Point(427, 132);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(336, 132);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(40, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Código";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(40, 47);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Razón Social";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(40, 65);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Magnitud";
            // 
            // txtcodCliente
            // 
            // 
            // 
            // 
            this.txtcodCliente.Border.Class = "TextBoxBorder";
            this.txtcodCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcodCliente.Enabled = false;
            this.txtcodCliente.Location = new System.Drawing.Point(139, 22);
            this.txtcodCliente.Name = "txtcodCliente";
            this.txtcodCliente.Size = new System.Drawing.Size(125, 20);
            this.txtcodCliente.TabIndex = 3;
            // 
            // txtrazonSocial
            // 
            // 
            // 
            // 
            this.txtrazonSocial.Border.Class = "TextBoxBorder";
            this.txtrazonSocial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtrazonSocial.Enabled = false;
            this.txtrazonSocial.Location = new System.Drawing.Point(139, 44);
            this.txtrazonSocial.Name = "txtrazonSocial";
            this.txtrazonSocial.Size = new System.Drawing.Size(337, 20);
            this.txtrazonSocial.TabIndex = 4;
            // 
            // cboMagnitudId
            // 
            this.cboMagnitudId.DisplayMember = "Text";
            this.cboMagnitudId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMagnitudId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMagnitudId.FormattingEnabled = true;
            this.cboMagnitudId.ItemHeight = 14;
            this.cboMagnitudId.Location = new System.Drawing.Point(139, 66);
            this.cboMagnitudId.Name = "cboMagnitudId";
            this.cboMagnitudId.Size = new System.Drawing.Size(170, 20);
            this.cboMagnitudId.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMagnitudId.TabIndex = 5;
            // 
            // frmMntMagnitudDato
            // 
            this.ClientSize = new System.Drawing.Size(516, 168);
            this.DoubleBuffered = true;
            this.Name = "frmMntMagnitudDato";
            this.Text = "Mantenimiento de Magnitud";
            this.Load += new System.EventHandler(this.frmMntMagnitudDato_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMagnitudId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtrazonSocial;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcodCliente;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}