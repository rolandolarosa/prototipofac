namespace Efide.Tesoreria.WinAdeudos.frmBase
{
    partial class frmConfirmacionBase
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
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnConfirmar = new DevComponents.DotNetBar.ButtonItem();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonItem();
            this.btnConfirmar2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnActualizar = new DevComponents.DotNetBar.ButtonItem();
            this.btnEnviarAcuerdo = new DevComponents.DotNetBar.ButtonItem();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonItem();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.txtBusqueda = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnDetalle = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.groupDetalle = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnSelTransDepo = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnConfirmar,
            this.btnCancelar,
            this.btnConfirmar2,
            this.btnActualizar,
            this.btnEnviarAcuerdo,
            this.btnLimpiar,
            this.btnSalir});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(831, 39);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 20;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnConfirmar.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.btn_ok;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.SubItemsExpandWidth = 14;
            this.btnConfirmar.Text = "Confirmar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCancelar.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.elimina;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.SubItemsExpandWidth = 14;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnConfirmar2
            // 
            this.btnConfirmar2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnConfirmar2.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.btn_ok;
            this.btnConfirmar2.Name = "btnConfirmar2";
            this.btnConfirmar2.SubItemsExpandWidth = 14;
            this.btnConfirmar2.Text = "Confirmar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnActualizar.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.refresh;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.SubItemsExpandWidth = 14;
            this.btnActualizar.Text = "Actualizar";
            // 
            // btnEnviarAcuerdo
            // 
            this.btnEnviarAcuerdo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnEnviarAcuerdo.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.arrow_up;
            this.btnEnviarAcuerdo.Name = "btnEnviarAcuerdo";
            this.btnEnviarAcuerdo.SubItemsExpandWidth = 14;
            this.btnEnviarAcuerdo.Text = "Enviar Acuerdo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLimpiar.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.SubItemsExpandWidth = 14;
            this.btnLimpiar.Text = "Limpiar";
            // 
            // btnSalir
            // 
            this.btnSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSalir.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.cerrar;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.SubItemsExpandWidth = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtBusqueda
            // 
            // 
            // 
            // 
            this.txtBusqueda.Border.Class = "TextBoxBorder";
            this.txtBusqueda.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBusqueda.Location = new System.Drawing.Point(126, 15);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(238, 20);
            this.txtBusqueda.TabIndex = 26;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(13, 15);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(107, 23);
            this.labelX10.TabIndex = 25;
            this.labelX10.Text = "Código de Inversión:";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.txtBusqueda);
            this.panelEx1.Controls.Add(this.btnDetalle);
            this.panelEx1.Controls.Add(this.labelX10);
            this.panelEx1.Controls.Add(this.btnBuscar);
            this.panelEx1.Location = new System.Drawing.Point(8, 53);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(815, 50);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 29;
            // 
            // btnDetalle
            // 
            this.btnDetalle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDetalle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDetalle.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.buscar;
            this.btnDetalle.Location = new System.Drawing.Point(423, 9);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(46, 32);
            this.btnDetalle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDetalle.TabIndex = 28;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.Binocular;
            this.btnBuscar.Location = new System.Drawing.Point(367, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 32);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 27;
            // 
            // groupDetalle
            // 
            this.groupDetalle.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupDetalle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupDetalle.Location = new System.Drawing.Point(8, 112);
            this.groupDetalle.Name = "groupDetalle";
            this.groupDetalle.Size = new System.Drawing.Size(815, 137);
            // 
            // 
            // 
            this.groupDetalle.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupDetalle.Style.BackColorGradientAngle = 90;
            this.groupDetalle.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupDetalle.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderBottomWidth = 1;
            this.groupDetalle.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupDetalle.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderLeftWidth = 1;
            this.groupDetalle.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderRightWidth = 1;
            this.groupDetalle.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderTopWidth = 1;
            this.groupDetalle.Style.CornerDiameter = 4;
            this.groupDetalle.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupDetalle.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupDetalle.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupDetalle.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupDetalle.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupDetalle.TabIndex = 1;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(831, 301);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 40;
            // 
            // btnSelTransDepo
            // 
            this.btnSelTransDepo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSelTransDepo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSelTransDepo.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.add;
            this.btnSelTransDepo.Location = new System.Drawing.Point(8, 269);
            this.btnSelTransDepo.Name = "btnSelTransDepo";
            this.btnSelTransDepo.Size = new System.Drawing.Size(167, 23);
            this.btnSelTransDepo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSelTransDepo.TabIndex = 39;
            this.btnSelTransDepo.Text = "Seleccionar Tranferiencias";
            // 
            // frmConfirmacionBase
            // 
            this.ClientSize = new System.Drawing.Size(831, 301);
            this.Controls.Add(this.btnSelTransDepo);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.ribbonBar1);
            this.Controls.Add(this.groupDetalle);
            this.Controls.Add(this.panelEx2);
            this.DoubleBuffered = true;
            this.Name = "frmConfirmacionBase";
            this.Text = "Confirmación";
            this.Load += new System.EventHandler(this.frmConfirmacionBase_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.TextBoxX txtBusqueda;
        public DevComponents.DotNetBar.LabelX labelX10;
        public DevComponents.DotNetBar.ButtonX btnBuscar;
        public DevComponents.DotNetBar.ButtonX btnDetalle;
        public DevComponents.DotNetBar.PanelEx panelEx1;
        public DevComponents.DotNetBar.RibbonBar ribbonBar1;
        public DevComponents.DotNetBar.ButtonX btnSelTransDepo;
        public DevComponents.DotNetBar.Controls.GroupPanel groupDetalle;
        public DevComponents.DotNetBar.ButtonItem btnConfirmar;
        public DevComponents.DotNetBar.ButtonItem btnCancelar;
        public DevComponents.DotNetBar.ButtonItem btnSalir;
        public DevComponents.DotNetBar.ButtonItem btnLimpiar;
        public DevComponents.DotNetBar.PanelEx panelEx2;
        public DevComponents.DotNetBar.ButtonItem btnConfirmar2;
        public DevComponents.DotNetBar.ButtonItem btnActualizar;
        public DevComponents.DotNetBar.ButtonItem btnEnviarAcuerdo;

    }
}