namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmEstadisticaPagadora
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.lblPagadora = new DevComponents.DotNetBar.LabelX();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.superGridControl1);
            this.grpDato.Controls.Add(this.lblPagadora);
            this.grpDato.Size = new System.Drawing.Size(917, 454);
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
            this.btnCancelar.Image = global::EfideFactoring.Properties.Resources.cerrar;
            this.btnCancelar.Location = new System.Drawing.Point(836, 475);
            this.btnCancelar.Text = "Salir";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(745, 475);
            this.btnAceptar.Visible = false;
            // 
            // lblPagadora
            // 
            this.lblPagadora.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPagadora.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPagadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagadora.ForeColor = System.Drawing.Color.Black;
            this.lblPagadora.Location = new System.Drawing.Point(16, 17);
            this.lblPagadora.Name = "lblPagadora";
            this.lblPagadora.Size = new System.Drawing.Size(511, 20);
            this.lblPagadora.TabIndex = 1;
            this.lblPagadora.Text = "Pagadora";
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(16, 43);
            this.superGridControl1.Name = "superGridControl1";
            gridColumn1.AllowEdit = false;
            gridColumn1.DataPropertyName = "Orden";
            gridColumn1.Name = "";
            gridColumn1.ReadOnly = true;
            gridColumn1.Visible = false;
            gridColumn2.AllowEdit = false;
            gridColumn2.DataPropertyName = "PK";
            gridColumn2.Name = "";
            gridColumn2.ReadOnly = true;
            gridColumn2.Width = 200;
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.Size = new System.Drawing.Size(879, 389);
            this.superGridControl1.TabIndex = 4;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // frmEstadisticaPagadora
            // 
            this.ClientSize = new System.Drawing.Size(925, 511);
            this.DoubleBuffered = true;
            this.Name = "frmEstadisticaPagadora";
            this.Text = "Estadística Pagadora";
            this.Load += new System.EventHandler(this.frmEstadisticaPagadora_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.LabelX lblPagadora;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
    }
}