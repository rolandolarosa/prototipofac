namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmMntEmail
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
            this.txtmailCorreo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.txtmailCorreo);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Size = new System.Drawing.Size(389, 86);
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
            this.btnCancelar.Location = new System.Drawing.Point(308, 107);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(217, 107);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 31);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Correo";
            // 
            // txtmailCorreo
            // 
            // 
            // 
            // 
            this.txtmailCorreo.Border.Class = "TextBoxBorder";
            this.txtmailCorreo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmailCorreo.Location = new System.Drawing.Point(98, 34);
            this.txtmailCorreo.Name = "txtmailCorreo";
            this.txtmailCorreo.Size = new System.Drawing.Size(244, 20);
            this.txtmailCorreo.TabIndex = 1;
            // 
            // frmMntEmail
            // 
            this.ClientSize = new System.Drawing.Size(397, 143);
            this.DoubleBuffered = true;
            this.Name = "frmMntEmail";
            this.Text = "Mantenimiento Email";
            this.Load += new System.EventHandler(this.frmMntEmail_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtmailCorreo;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}