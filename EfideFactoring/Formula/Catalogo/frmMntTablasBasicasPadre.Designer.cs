namespace EfideFactoring.Formula.Catalogo
{
    partial class frmMntTablasBasicasPadre
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
            this.txtTable_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtTable_Id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.txtTable_Name);
            this.grpDato.Controls.Add(this.LabelX2);
            this.grpDato.Controls.Add(this.txtTable_Id);
            this.grpDato.Controls.Add(this.LabelX1);
            this.grpDato.Size = new System.Drawing.Size(297, 90);
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
            this.btnCancelar.Location = new System.Drawing.Point(216, 111);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(125, 111);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTable_Name
            // 
            // 
            // 
            // 
            this.txtTable_Name.Border.Class = "TextBoxBorder";
            this.txtTable_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTable_Name.Location = new System.Drawing.Point(103, 44);
            this.txtTable_Name.Name = "txtTable_Name";
            this.txtTable_Name.Size = new System.Drawing.Size(170, 20);
            this.txtTable_Name.TabIndex = 16;
            // 
            // LabelX2
            // 
            this.LabelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX2.Location = new System.Drawing.Point(30, 44);
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Size = new System.Drawing.Size(63, 23);
            this.LabelX2.TabIndex = 15;
            this.LabelX2.Text = "Descripcion";
            this.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtTable_Id
            // 
            // 
            // 
            // 
            this.txtTable_Id.Border.Class = "TextBoxBorder";
            this.txtTable_Id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTable_Id.Enabled = false;
            this.txtTable_Id.Location = new System.Drawing.Point(103, 18);
            this.txtTable_Id.Name = "txtTable_Id";
            this.txtTable_Id.ReadOnly = true;
            this.txtTable_Id.Size = new System.Drawing.Size(100, 20);
            this.txtTable_Id.TabIndex = 14;
            this.txtTable_Id.TabStop = false;
            // 
            // LabelX1
            // 
            this.LabelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(30, 15);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(63, 23);
            this.LabelX1.TabIndex = 13;
            this.LabelX1.Text = "Codigo";
            this.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmMntTablasBasicasPadre
            // 
            this.ClientSize = new System.Drawing.Size(305, 147);
            this.DoubleBuffered = true;
            this.Name = "frmMntTablasBasicasPadre";
            this.Text = "Tablas Básicas - Dato";
            this.Load += new System.EventHandler(this.frmMntTablasBasicasPadre_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.Controls.TextBoxX txtTable_Name;
        internal DevComponents.DotNetBar.LabelX LabelX2;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtTable_Id;
        internal DevComponents.DotNetBar.LabelX LabelX1;
    }
}