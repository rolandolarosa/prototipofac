namespace Efide.Tesoreria.WinAdeudosInversiones.frmBase
{
    partial class frmListaBase
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
            this.toolBar = new DevComponents.DotNetBar.RibbonBar();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnEditar = new DevComponents.DotNetBar.ButtonItem();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonItem();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.pnlFiltro = new DevComponents.DotNetBar.PanelEx();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.toolBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolBar.ContainerControlProcessDialogKey = true;
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnBuscar,
            this.btnLimpiar,
            this.btnSalir});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(840, 39);
            this.toolBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolBar.TabIndex = 21;
            // 
            // 
            // 
            this.toolBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnNuevo
            // 
            this.btnNuevo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNuevo.Image = global::Efide.Tesoreria.WinAdeudosInversiones.Properties.Resources.nuevo;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.SubItemsExpandWidth = 14;
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnEditar
            // 
            this.btnEditar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnEditar.Image = global::Efide.Tesoreria.WinAdeudosInversiones.Properties.Resources.modifica;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.SubItemsExpandWidth = 14;
            this.btnEditar.Text = "Editar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnBuscar.Image = global::Efide.Tesoreria.WinAdeudosInversiones.Properties.Resources.buscar;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.SubItemsExpandWidth = 14;
            this.btnBuscar.Text = "Buscar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLimpiar.Image = global::Efide.Tesoreria.WinAdeudosInversiones.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.SubItemsExpandWidth = 14;
            this.btnLimpiar.Text = "Limpiar";
            // 
            // btnSalir
            // 
            this.btnSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSalir.Image = global::Efide.Tesoreria.WinAdeudosInversiones.Properties.Resources.cerrar;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.SubItemsExpandWidth = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlFiltro.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 53);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(840, 100);
            this.pnlFiltro.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlFiltro.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlFiltro.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlFiltro.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlFiltro.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlFiltro.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlFiltro.Style.GradientAngle = 90;
            this.pnlFiltro.TabIndex = 22;
            // 
            // frmListaBase
            // 
            this.ClientSize = new System.Drawing.Size(840, 435);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.toolBar);
            this.DoubleBuffered = true;
            this.Name = "frmListaBase";
            this.Text = "frmListaBase";
            this.Load += new System.EventHandler(this.frmListaBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.RibbonBar toolBar;
        public DevComponents.DotNetBar.PanelEx pnlFiltro;
        public DevComponents.DotNetBar.ButtonItem btnEditar;
        public DevComponents.DotNetBar.ButtonItem btnBuscar;
        public DevComponents.DotNetBar.ButtonItem btnLimpiar;
        public DevComponents.DotNetBar.ButtonItem btnSalir;
        public DevComponents.DotNetBar.ButtonItem btnNuevo;
    }
}