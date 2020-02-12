namespace EfideFactoring.Formula.Seguridad
{
    partial class frmMntPermiso
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMntPermiso));
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arribaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssbAgregar = new System.Windows.Forms.ToolStripSplitButton();
            this.tssbQuitar = new System.Windows.Forms.ToolStripSplitButton();
            this.btnSalir = new System.Windows.Forms.ToolStripSplitButton();
            this.grpDato.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.trvMenu);
            this.grpDato.Location = new System.Drawing.Point(4, 12);
            this.grpDato.Size = new System.Drawing.Size(387, 392);
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
            this.btnCancelar.Location = new System.Drawing.Point(376, 426);
            this.btnCancelar.Size = new System.Drawing.Size(15, 16);
            this.btnCancelar.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(356, 426);
            this.btnAceptar.Size = new System.Drawing.Size(14, 16);
            this.btnAceptar.Visible = false;
            // 
            // trvMenu
            // 
            this.trvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvMenu.CheckBoxes = true;
            this.trvMenu.Location = new System.Drawing.Point(5, 3);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.Size = new System.Drawing.Size(373, 380);
            this.trvMenu.TabIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbAgregar,
            this.tssbQuitar,
            this.btnSalir});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(397, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arribaToolStripMenuItem,
            this.abajoToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.quitarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.detallarToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(117, 136);
            // 
            // arribaToolStripMenuItem
            // 
            this.arribaToolStripMenuItem.Name = "arribaToolStripMenuItem";
            this.arribaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.arribaToolStripMenuItem.Text = "Arriba";
            // 
            // abajoToolStripMenuItem
            // 
            this.abajoToolStripMenuItem.Name = "abajoToolStripMenuItem";
            this.abajoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abajoToolStripMenuItem.Text = "Abajo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // quitarToolStripMenuItem
            // 
            this.quitarToolStripMenuItem.Name = "quitarToolStripMenuItem";
            this.quitarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.quitarToolStripMenuItem.Text = "Quitar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // detallarToolStripMenuItem
            // 
            this.detallarToolStripMenuItem.Name = "detallarToolStripMenuItem";
            this.detallarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.detallarToolStripMenuItem.Text = "Detallar";
            // 
            // tssbAgregar
            // 
            this.tssbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tssbAgregar.Image")));
            this.tssbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbAgregar.Name = "tssbAgregar";
            this.tssbAgregar.Size = new System.Drawing.Size(32, 20);
            this.tssbAgregar.Text = "toolStripSplitButton1";
            // 
            // tssbQuitar
            // 
            this.tssbQuitar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbQuitar.Image = ((System.Drawing.Image)(resources.GetObject("tssbQuitar.Image")));
            this.tssbQuitar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbQuitar.Name = "tssbQuitar";
            this.tssbQuitar.Size = new System.Drawing.Size(32, 20);
            this.tssbQuitar.Text = "toolStripSplitButton1";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 20);
            this.btnSalir.Text = "toolStripSplitButton1";
            // 
            // frmMntPermiso
            // 
            this.ClientSize = new System.Drawing.Size(397, 440);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Name = "frmMntPermiso";
            this.Controls.SetChildIndex(this.grpDato, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.grpDato.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton tssbAgregar;
        private System.Windows.Forms.ToolStripSplitButton tssbQuitar;
        private System.Windows.Forms.ToolStripSplitButton btnSalir;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem arribaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallarToolStripMenuItem;
    }
}
