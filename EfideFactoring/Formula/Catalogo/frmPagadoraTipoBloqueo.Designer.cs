namespace EfideFactoring.Formula.Catalogo
{
    partial class frmPagadoraTipoBloqueo
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
            this.cboIdEstadoLinea_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtMotivo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.txtMotivo);
            this.grpDato.Controls.Add(this.cboIdEstadoLinea_tt);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Size = new System.Drawing.Size(509, 256);
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
            this.btnCancelar.Location = new System.Drawing.Point(428, 277);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(337, 277);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(18, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(89, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tipo Bloqueo";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(18, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(89, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Motivo";
            // 
            // cboIdEstadoLinea_tt
            // 
            this.cboIdEstadoLinea_tt.DisplayMember = "Text";
            this.cboIdEstadoLinea_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdEstadoLinea_tt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdEstadoLinea_tt.FormattingEnabled = true;
            this.cboIdEstadoLinea_tt.ItemHeight = 14;
            this.cboIdEstadoLinea_tt.Location = new System.Drawing.Point(113, 20);
            this.cboIdEstadoLinea_tt.Name = "cboIdEstadoLinea_tt";
            this.cboIdEstadoLinea_tt.Size = new System.Drawing.Size(178, 20);
            this.cboIdEstadoLinea_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdEstadoLinea_tt.TabIndex = 2;
            // 
            // txtMotivo
            // 
            // 
            // 
            // 
            this.txtMotivo.Border.Class = "TextBoxBorder";
            this.txtMotivo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMotivo.Location = new System.Drawing.Point(113, 46);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(364, 192);
            this.txtMotivo.TabIndex = 3;
            // 
            // frmPagadoraTipoBloqueo
            // 
            this.ClientSize = new System.Drawing.Size(517, 313);
            this.DoubleBuffered = true;
            this.Name = "frmPagadoraTipoBloqueo";
            this.Text = "Tipo de Bloqueo";
            this.Load += new System.EventHandler(this.frmPagadoraTipoBloqueo_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMotivo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdEstadoLinea_tt;
    }
}