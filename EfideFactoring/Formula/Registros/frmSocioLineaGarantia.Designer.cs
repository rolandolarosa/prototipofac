namespace EfideFactoring.Formula.Registros
{
    partial class frmSocioLineaGarantia
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
            this.btnAdjuntarDocumento = new DevComponents.DotNetBar.ButtonX();
            this.txtRutaDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDocumento = new DevComponents.DotNetBar.LabelX();
            this.txtDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboIdTipo_Documento_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.cboIdTipo_Documento_tt);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.txtDocumento);
            this.grpDato.Controls.Add(this.lblDocumento);
            this.grpDato.Controls.Add(this.txtRutaDocumento);
            this.grpDato.Controls.Add(this.btnAdjuntarDocumento);
            this.grpDato.Size = new System.Drawing.Size(488, 102);
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
            this.btnCancelar.Location = new System.Drawing.Point(407, 123);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(316, 123);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAdjuntarDocumento
            // 
            this.btnAdjuntarDocumento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdjuntarDocumento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdjuntarDocumento.Location = new System.Drawing.Point(378, 60);
            this.btnAdjuntarDocumento.Name = "btnAdjuntarDocumento";
            this.btnAdjuntarDocumento.Size = new System.Drawing.Size(80, 23);
            this.btnAdjuntarDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdjuntarDocumento.TabIndex = 0;
            this.btnAdjuntarDocumento.Text = "Examinar...";
            this.btnAdjuntarDocumento.Click += new System.EventHandler(this.btnAdjuntarDocumento_Click);
            // 
            // txtRutaDocumento
            // 
            // 
            // 
            // 
            this.txtRutaDocumento.Border.Class = "TextBoxBorder";
            this.txtRutaDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRutaDocumento.Enabled = false;
            this.txtRutaDocumento.Location = new System.Drawing.Point(122, 61);
            this.txtRutaDocumento.Name = "txtRutaDocumento";
            this.txtRutaDocumento.Size = new System.Drawing.Size(255, 20);
            this.txtRutaDocumento.TabIndex = 1;
            // 
            // lblDocumento
            // 
            this.lblDocumento.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDocumento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDocumento.Location = new System.Drawing.Point(21, 32);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(93, 23);
            this.lblDocumento.TabIndex = 3;
            this.lblDocumento.Text = "Nombre";
            this.lblDocumento.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtDocumento
            // 
            // 
            // 
            // 
            this.txtDocumento.Border.Class = "TextBoxBorder";
            this.txtDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Location = new System.Drawing.Point(122, 32);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(255, 20);
            this.txtDocumento.TabIndex = 5;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX1.Location = new System.Drawing.Point(21, 61);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Adjunto";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(21, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(93, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Tipo Documento";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboIdTipo_Documento_tt
            // 
            this.cboIdTipo_Documento_tt.DisplayMember = "Text";
            this.cboIdTipo_Documento_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdTipo_Documento_tt.FormattingEnabled = true;
            this.cboIdTipo_Documento_tt.ItemHeight = 14;
            this.cboIdTipo_Documento_tt.Location = new System.Drawing.Point(122, 3);
            this.cboIdTipo_Documento_tt.Name = "cboIdTipo_Documento_tt";
            this.cboIdTipo_Documento_tt.Size = new System.Drawing.Size(113, 20);
            this.cboIdTipo_Documento_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdTipo_Documento_tt.TabIndex = 8;
            // 
            // frmSocioLineaGarantia
            // 
            this.ClientSize = new System.Drawing.Size(496, 159);
            this.DoubleBuffered = true;
            this.Name = "frmSocioLineaGarantia";
            this.Text = "Documento Garantia";
            this.Load += new System.EventHandler(this.frmSocioLineaGarantia_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnAdjuntarDocumento;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRutaDocumento;
        protected DevComponents.DotNetBar.LabelX lblDocumento;
        protected DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDocumento;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdTipo_Documento_tt;
        protected DevComponents.DotNetBar.LabelX labelX2;
    }
}