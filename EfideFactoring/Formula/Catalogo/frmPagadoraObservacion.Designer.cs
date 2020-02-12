namespace EfideFactoring.Formula.Catalogo
{
    partial class frmPagadoraObservacion
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
            this.txtIdObservacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPagadora = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.txtdtFecha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtComentario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.txtComentario);
            this.grpDato.Controls.Add(this.txtdtFecha);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.txtIdObservacion);
            this.grpDato.Controls.Add(this.lblPagadora);
            this.grpDato.Size = new System.Drawing.Size(405, 194);
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
            this.btnCancelar.Location = new System.Drawing.Point(324, 215);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(233, 215);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtIdObservacion
            // 
            this.txtIdObservacion.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.txtIdObservacion.Border.Class = "TextBoxBorder";
            this.txtIdObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdObservacion.Enabled = false;
            this.txtIdObservacion.Location = new System.Drawing.Point(110, 18);
            this.txtIdObservacion.Name = "txtIdObservacion";
            this.txtIdObservacion.Size = new System.Drawing.Size(131, 20);
            this.txtIdObservacion.TabIndex = 17;
            // 
            // lblPagadora
            // 
            this.lblPagadora.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPagadora.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPagadora.Location = new System.Drawing.Point(20, 17);
            this.lblPagadora.Name = "lblPagadora";
            this.lblPagadora.Size = new System.Drawing.Size(75, 23);
            this.lblPagadora.TabIndex = 16;
            this.lblPagadora.Text = "Código";
            this.lblPagadora.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(20, 46);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 18;
            this.labelX1.Text = "Fecha";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(20, 75);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "Observación";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtdtFecha
            // 
            // 
            // 
            // 
            this.txtdtFecha.Border.Class = "TextBoxBorder";
            this.txtdtFecha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdtFecha.Location = new System.Drawing.Point(110, 48);
            this.txtdtFecha.Name = "txtdtFecha";
            this.txtdtFecha.ReadOnly = true;
            this.txtdtFecha.Size = new System.Drawing.Size(131, 20);
            this.txtdtFecha.TabIndex = 20;
            // 
            // txtComentario
            // 
            // 
            // 
            // 
            this.txtComentario.Border.Class = "TextBoxBorder";
            this.txtComentario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComentario.Location = new System.Drawing.Point(110, 78);
            this.txtComentario.MaxLength = 500;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(249, 95);
            this.txtComentario.TabIndex = 21;
            // 
            // frmPagadoraObservacion
            // 
            this.ClientSize = new System.Drawing.Size(413, 251);
            this.DoubleBuffered = true;
            this.Name = "frmPagadoraObservacion";
            this.Text = "Observación / Vitacora";
            this.Load += new System.EventHandler(this.frmPagadoraObservacion_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdObservacion;
        private DevComponents.DotNetBar.LabelX lblPagadora;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComentario;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdtFecha;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}