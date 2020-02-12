namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmUsuarioXTipoDato
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
            this.cboUsuarios = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboGestor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboIdTipoGestor_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.cboIdTipoGestor_tt);
            this.grpDato.Controls.Add(this.labelX3);
            this.grpDato.Controls.Add(this.cboGestor);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.cboUsuarios);
            this.grpDato.Size = new System.Drawing.Size(312, 106);
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
            this.btnCancelar.Location = new System.Drawing.Point(231, 127);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(140, 127);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DisplayMember = "Text";
            this.cboUsuarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.ItemHeight = 16;
            this.cboUsuarios.Location = new System.Drawing.Point(105, 17);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(176, 22);
            this.cboUsuarios.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboUsuarios.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(18, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(59, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Usuario";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(18, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(59, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Gestor";
            // 
            // cboGestor
            // 
            this.cboGestor.DisplayMember = "Text";
            this.cboGestor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGestor.FormattingEnabled = true;
            this.cboGestor.ItemHeight = 16;
            this.cboGestor.Location = new System.Drawing.Point(105, 41);
            this.cboGestor.Name = "cboGestor";
            this.cboGestor.Size = new System.Drawing.Size(176, 22);
            this.cboGestor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboGestor.TabIndex = 3;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(18, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Tipo";
            // 
            // cboIdTipoGestor_tt
            // 
            this.cboIdTipoGestor_tt.DisplayMember = "Text";
            this.cboIdTipoGestor_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdTipoGestor_tt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdTipoGestor_tt.FormattingEnabled = true;
            this.cboIdTipoGestor_tt.ItemHeight = 16;
            this.cboIdTipoGestor_tt.Location = new System.Drawing.Point(105, 65);
            this.cboIdTipoGestor_tt.Name = "cboIdTipoGestor_tt";
            this.cboIdTipoGestor_tt.Size = new System.Drawing.Size(176, 22);
            this.cboIdTipoGestor_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdTipoGestor_tt.TabIndex = 5;
            // 
            // frmUsuarioXTipoDato
            // 
            this.ClientSize = new System.Drawing.Size(320, 163);
            this.DoubleBuffered = true;
            this.Name = "frmUsuarioXTipoDato";
            this.Text = "Usuarios Gestores - Dato";
            this.Load += new System.EventHandler(this.frmUsuarioXTipoDato_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboUsuarios;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGestor;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdTipoGestor_tt;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}