namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmMntTelefono
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
            this.cbovalorOrigenTeleID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbovalorTipoID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtteleTelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.txtteleTelefono);
            this.grpDato.Controls.Add(this.labelX3);
            this.grpDato.Controls.Add(this.cbovalorTipoID);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.cbovalorOrigenTeleID);
            this.grpDato.Size = new System.Drawing.Size(305, 124);
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
            this.btnCancelar.Location = new System.Drawing.Point(224, 145);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(133, 145);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbovalorOrigenTeleID
            // 
            this.cbovalorOrigenTeleID.DisplayMember = "Text";
            this.cbovalorOrigenTeleID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbovalorOrigenTeleID.FormattingEnabled = true;
            this.cbovalorOrigenTeleID.ItemHeight = 14;
            this.cbovalorOrigenTeleID.Location = new System.Drawing.Point(119, 22);
            this.cbovalorOrigenTeleID.Name = "cbovalorOrigenTeleID";
            this.cbovalorOrigenTeleID.Size = new System.Drawing.Size(148, 20);
            this.cbovalorOrigenTeleID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbovalorOrigenTeleID.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(29, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Origen";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(29, 45);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Tipo";
            // 
            // cbovalorTipoID
            // 
            this.cbovalorTipoID.DisplayMember = "Text";
            this.cbovalorTipoID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbovalorTipoID.FormattingEnabled = true;
            this.cbovalorTipoID.ItemHeight = 14;
            this.cbovalorTipoID.Location = new System.Drawing.Point(119, 47);
            this.cbovalorTipoID.Name = "cbovalorTipoID";
            this.cbovalorTipoID.Size = new System.Drawing.Size(148, 20);
            this.cbovalorTipoID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbovalorTipoID.TabIndex = 3;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(29, 71);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Teléfono";
            // 
            // txtteleTelefono
            // 
            // 
            // 
            // 
            this.txtteleTelefono.Border.Class = "TextBoxBorder";
            this.txtteleTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtteleTelefono.Location = new System.Drawing.Point(119, 71);
            this.txtteleTelefono.Name = "txtteleTelefono";
            this.txtteleTelefono.Size = new System.Drawing.Size(148, 20);
            this.txtteleTelefono.TabIndex = 5;
            // 
            // frmMntTelefono
            // 
            this.ClientSize = new System.Drawing.Size(313, 181);
            this.DoubleBuffered = true;
            this.Name = "frmMntTelefono";
            this.Text = "Mantenimiento Teléfono";
            this.Load += new System.EventHandler(this.frmMntTelefono_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbovalorOrigenTeleID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtteleTelefono;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbovalorTipoID;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}