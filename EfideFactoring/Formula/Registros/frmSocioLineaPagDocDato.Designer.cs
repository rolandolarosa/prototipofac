namespace EfideFactoring.Formula.Registros
{
    partial class frmSocioLineaPagDocDato
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboDocumentos = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtFondoGarantia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkInteres = new System.Windows.Forms.CheckBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cboIdTipoConfirmacion = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.cboIdTipoConfirmacion);
            this.grpDato.Controls.Add(this.labelX5);
            this.grpDato.Controls.Add(this.labelX4);
            this.grpDato.Controls.Add(this.chkInteres);
            this.grpDato.Controls.Add(this.txtFondoGarantia);
            this.grpDato.Controls.Add(this.cboDocumentos);
            this.grpDato.Controls.Add(this.labelX3);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Size = new System.Drawing.Size(325, 112);
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
            this.btnCancelar.Location = new System.Drawing.Point(244, 133);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(153, 133);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(27, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 26;
            this.labelX2.Text = "Documento";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(8, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 23);
            this.labelX1.TabIndex = 27;
            this.labelX1.Text = "Fondo Garantia";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(17, 76);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(85, 23);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "Interes?";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboDocumentos
            // 
            this.cboDocumentos.DisplayMember = "Text";
            this.cboDocumentos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumentos.FormattingEnabled = true;
            this.cboDocumentos.ItemHeight = 14;
            this.cboDocumentos.Location = new System.Drawing.Point(113, 3);
            this.cboDocumentos.Name = "cboDocumentos";
            this.cboDocumentos.Size = new System.Drawing.Size(197, 20);
            this.cboDocumentos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboDocumentos.TabIndex = 29;
            // 
            // txtFondoGarantia
            // 
            // 
            // 
            // 
            this.txtFondoGarantia.Border.Class = "TextBoxBorder";
            this.txtFondoGarantia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFondoGarantia.Location = new System.Drawing.Point(113, 26);
            this.txtFondoGarantia.Name = "txtFondoGarantia";
            this.txtFondoGarantia.Size = new System.Drawing.Size(52, 20);
            this.txtFondoGarantia.TabIndex = 30;
            this.txtFondoGarantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFondoGarantia_KeyPress);
            // 
            // chkInteres
            // 
            this.chkInteres.AutoSize = true;
            this.chkInteres.Location = new System.Drawing.Point(113, 82);
            this.chkInteres.Name = "chkInteres";
            this.chkInteres.Size = new System.Drawing.Size(15, 14);
            this.chkInteres.TabIndex = 31;
            this.chkInteres.UseVisualStyleBackColor = true;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(181, 26);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(37, 23);
            this.labelX4.TabIndex = 32;
            this.labelX4.Text = "%";
            // 
            // cboIdTipoConfirmacion
            // 
            this.cboIdTipoConfirmacion.DisplayMember = "Text";
            this.cboIdTipoConfirmacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdTipoConfirmacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdTipoConfirmacion.FormattingEnabled = true;
            this.cboIdTipoConfirmacion.ItemHeight = 14;
            this.cboIdTipoConfirmacion.Location = new System.Drawing.Point(113, 52);
            this.cboIdTipoConfirmacion.Name = "cboIdTipoConfirmacion";
            this.cboIdTipoConfirmacion.Size = new System.Drawing.Size(197, 20);
            this.cboIdTipoConfirmacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdTipoConfirmacion.TabIndex = 34;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(8, 52);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(94, 23);
            this.labelX5.TabIndex = 33;
            this.labelX5.Text = "Tipo Confirmación";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // frmSocioLineaPagDocDato
            // 
            this.ClientSize = new System.Drawing.Size(333, 169);
            this.DoubleBuffered = true;
            this.Name = "frmSocioLineaPagDocDato";
            this.Text = "Documentos";
            this.Load += new System.EventHandler(this.SocioLineaPagDocDato_Load);
            this.grpDato.ResumeLayout(false);
            this.grpDato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboDocumentos;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFondoGarantia;
        private System.Windows.Forms.CheckBox chkInteres;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdTipoConfirmacion;
        private DevComponents.DotNetBar.LabelX labelX5;


    }
}