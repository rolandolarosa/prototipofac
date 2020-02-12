namespace EfideFactoring.Formula.Registros
{
    partial class frmMntLoteDatoArchivo
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
            this.btnAdjuntarArchivo1 = new DevComponents.DotNetBar.ButtonX();
            this.btnAdjuntarArchivo2 = new DevComponents.DotNetBar.ButtonX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.buttonX2);
            this.grpDato.Controls.Add(this.buttonX1);
            this.grpDato.Controls.Add(this.btnAdjuntarArchivo2);
            this.grpDato.Controls.Add(this.btnAdjuntarArchivo1);
            this.grpDato.Size = new System.Drawing.Size(723, 190);
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
            this.btnCancelar.Location = new System.Drawing.Point(642, 211);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(551, 211);
            this.btnAceptar.Visible = false;
            // 
            // btnAdjuntarArchivo1
            // 
            this.btnAdjuntarArchivo1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdjuntarArchivo1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdjuntarArchivo1.Image = global::EfideFactoring.Properties.Resources.carpeta;
            this.btnAdjuntarArchivo1.Location = new System.Drawing.Point(26, 44);
            this.btnAdjuntarArchivo1.Name = "btnAdjuntarArchivo1";
            this.btnAdjuntarArchivo1.Size = new System.Drawing.Size(85, 30);
            this.btnAdjuntarArchivo1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdjuntarArchivo1.TabIndex = 13;
            this.btnAdjuntarArchivo1.Text = "Adjuntar Arhivo 1";
            this.btnAdjuntarArchivo1.Click += new System.EventHandler(this.btnAdjuntarArchivo1_Click);
            // 
            // btnAdjuntarArchivo2
            // 
            this.btnAdjuntarArchivo2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdjuntarArchivo2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdjuntarArchivo2.Image = global::EfideFactoring.Properties.Resources.carpeta;
            this.btnAdjuntarArchivo2.Location = new System.Drawing.Point(26, 114);
            this.btnAdjuntarArchivo2.Name = "btnAdjuntarArchivo2";
            this.btnAdjuntarArchivo2.Size = new System.Drawing.Size(85, 30);
            this.btnAdjuntarArchivo2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdjuntarArchivo2.TabIndex = 14;
            this.btnAdjuntarArchivo2.Text = "Adjuntar Arhivo 2";
            this.btnAdjuntarArchivo2.Click += new System.EventHandler(this.btnAdjuntarArchivo2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::EfideFactoring.Properties.Resources.carpeta;
            this.buttonX1.Location = new System.Drawing.Point(171, 44);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(85, 30);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 15;
            this.buttonX1.Text = "Ver Archivo";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::EfideFactoring.Properties.Resources.carpeta;
            this.buttonX2.Location = new System.Drawing.Point(171, 114);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(85, 30);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 16;
            this.buttonX2.Text = "Ver Archivo";
            // 
            // frmMntLoteDatoArchivo
            // 
            this.ClientSize = new System.Drawing.Size(731, 247);
            this.DoubleBuffered = true;
            this.Name = "frmMntLoteDatoArchivo";
            this.Text = "Adjuntar Archivos";
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.ButtonX btnAdjuntarArchivo2;
        protected DevComponents.DotNetBar.ButtonX btnAdjuntarArchivo1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected DevComponents.DotNetBar.ButtonX buttonX1;
        protected DevComponents.DotNetBar.ButtonX buttonX2;
    }
}