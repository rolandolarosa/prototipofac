namespace EfideFactoring.Formula.Seguridad
{
    partial class frmMntMenu
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
            this.components = new System.ComponentModel.Container();
            this.ssBotones = new System.Windows.Forms.StatusStrip();
            this.tssbAgregar = new System.Windows.Forms.ToolStripSplitButton();
            this.tssbQuitar = new System.Windows.Forms.ToolStripSplitButton();
            this.btnSalir = new System.Windows.Forms.ToolStripSplitButton();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arribaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvwOpciones = new Sloppycode.UI.TreeViewDragDrop();
            this.ssBotones.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssBotones
            // 
            this.ssBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbAgregar,
            this.tssbQuitar,
            this.btnSalir});
            this.ssBotones.Location = new System.Drawing.Point(0, 388);
            this.ssBotones.Name = "ssBotones";
            this.ssBotones.Size = new System.Drawing.Size(402, 22);
            this.ssBotones.TabIndex = 0;
            this.ssBotones.Text = "statusStrip1";
            // 
            // tssbAgregar
            // 
            this.tssbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbAgregar.Image = global::EfideFactoring.Properties.Resources.add;
            this.tssbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbAgregar.Name = "tssbAgregar";
            this.tssbAgregar.Size = new System.Drawing.Size(32, 20);
            this.tssbAgregar.Text = "toolStripSplitButton1";
            // 
            // tssbQuitar
            // 
            this.tssbQuitar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbQuitar.Image = global::EfideFactoring.Properties.Resources.del;
            this.tssbQuitar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbQuitar.Name = "tssbQuitar";
            this.tssbQuitar.Size = new System.Drawing.Size(32, 20);
            this.tssbQuitar.Text = "toolStripSplitButton1";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = global::EfideFactoring.Properties.Resources._1363997768_folder_open_document_text;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 20);
            this.btnSalir.Text = "toolStripSplitButton1";
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
            this.arribaToolStripMenuItem.Image = global::EfideFactoring.Properties.Resources.arrow_up;
            this.arribaToolStripMenuItem.Name = "arribaToolStripMenuItem";
            this.arribaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.arribaToolStripMenuItem.Text = "Arriba";
            // 
            // abajoToolStripMenuItem
            // 
            this.abajoToolStripMenuItem.Image = global::EfideFactoring.Properties.Resources.arrow_down;
            this.abajoToolStripMenuItem.Name = "abajoToolStripMenuItem";
            this.abajoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abajoToolStripMenuItem.Text = "Abajo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Image = global::EfideFactoring.Properties.Resources.add;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // quitarToolStripMenuItem
            // 
            this.quitarToolStripMenuItem.Image = global::EfideFactoring.Properties.Resources.del;
            this.quitarToolStripMenuItem.Name = "quitarToolStripMenuItem";
            this.quitarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.quitarToolStripMenuItem.Text = "Quitar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::EfideFactoring.Properties.Resources.modifica;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // detallarToolStripMenuItem
            // 
            this.detallarToolStripMenuItem.Image = global::EfideFactoring.Properties.Resources._1363997768_folder_open_document_text;
            this.detallarToolStripMenuItem.Name = "detallarToolStripMenuItem";
            this.detallarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.detallarToolStripMenuItem.Text = "Detallar";
            // 
            // tvwOpciones
            // 
            this.tvwOpciones.AllowDrop = true;
            this.tvwOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwOpciones.DragCursor = null;
            this.tvwOpciones.DragCursorType = Sloppycode.UI.DragCursorType.None;
            this.tvwOpciones.DragImageIndex = 0;
            this.tvwOpciones.DragMode = System.Windows.Forms.DragDropEffects.Move;
            this.tvwOpciones.DragNodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwOpciones.DragNodeOpacity = 0.3D;
            this.tvwOpciones.DragOverNodeBackColor = System.Drawing.SystemColors.Highlight;
            this.tvwOpciones.DragOverNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.tvwOpciones.Location = new System.Drawing.Point(0, 0);
            this.tvwOpciones.Name = "tvwOpciones";
            this.tvwOpciones.Size = new System.Drawing.Size(402, 388);
            this.tvwOpciones.TabIndex = 2;
            // 
            // frmMntMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 410);
            this.Controls.Add(this.tvwOpciones);
            this.Controls.Add(this.ssBotones);
            this.Name = "frmMntMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMntMenu_Load);
            this.ssBotones.ResumeLayout(false);
            this.ssBotones.PerformLayout();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssBotones;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem arribaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tssbAgregar;
        private System.Windows.Forms.ToolStripSplitButton tssbQuitar;
        private System.Windows.Forms.ToolStripSplitButton btnSalir;
        private Sloppycode.UI.TreeViewDragDrop tvwOpciones;
    }
}