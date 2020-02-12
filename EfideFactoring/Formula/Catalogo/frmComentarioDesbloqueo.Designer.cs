namespace EfideFactoring.Formula.Catalogo
{
    partial class frmComentarioDesbloqueo
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
            this.txtvcReferencia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPagadora = new DevComponents.DotNetBar.LabelX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.lblPagadora);
            this.grpDato.Controls.Add(this.txtvcReferencia);
            this.grpDato.Size = new System.Drawing.Size(505, 266);
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
            this.btnCancelar.Location = new System.Drawing.Point(424, 287);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(333, 287);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtvcReferencia
            // 
            // 
            // 
            // 
            this.txtvcReferencia.Border.Class = "TextBoxBorder";
            this.txtvcReferencia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtvcReferencia.Location = new System.Drawing.Point(5, 38);
            this.txtvcReferencia.Multiline = true;
            this.txtvcReferencia.Name = "txtvcReferencia";
            this.txtvcReferencia.Size = new System.Drawing.Size(489, 208);
            this.txtvcReferencia.TabIndex = 0;
            // 
            // lblPagadora
            // 
            this.lblPagadora.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPagadora.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPagadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagadora.Location = new System.Drawing.Point(5, 9);
            this.lblPagadora.Name = "lblPagadora";
            this.lblPagadora.Size = new System.Drawing.Size(489, 23);
            this.lblPagadora.TabIndex = 1;
            this.lblPagadora.Text = "labelX1";
            // 
            // frmComentarioDesbloqueo
            // 
            this.ClientSize = new System.Drawing.Size(513, 323);
            this.DoubleBuffered = true;
            this.Name = "frmComentarioDesbloqueo";
            this.Text = "Desbloqueo";
            this.Load += new System.EventHandler(this.frmComentarioDesbloqueo_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblPagadora;
        private DevComponents.DotNetBar.Controls.TextBoxX txtvcReferencia;
    }
}