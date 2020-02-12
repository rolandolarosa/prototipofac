namespace EfideFactoring.Formula.Legal
{
    partial class frmMntSolicitudCheckListDato
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cboIdDocumento_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtvDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAdjuntar = new DevComponents.DotNetBar.ButtonX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.btnAdjuntar);
            this.grpDato.Controls.Add(this.txtvDocumento);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.cboIdDocumento_tt);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Size = new System.Drawing.Size(491, 124);
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
            this.btnCancelar.Location = new System.Drawing.Point(410, 145);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(319, 145);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(25, 33);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tipo Documento";
            // 
            // cboIdDocumento_tt
            // 
            this.cboIdDocumento_tt.DisplayMember = "Text";
            this.cboIdDocumento_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdDocumento_tt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdDocumento_tt.Enabled = false;
            this.cboIdDocumento_tt.FormattingEnabled = true;
            this.cboIdDocumento_tt.ItemHeight = 14;
            this.cboIdDocumento_tt.Location = new System.Drawing.Point(149, 33);
            this.cboIdDocumento_tt.Name = "cboIdDocumento_tt";
            this.cboIdDocumento_tt.Size = new System.Drawing.Size(279, 20);
            this.cboIdDocumento_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdDocumento_tt.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(25, 59);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(105, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Documento";
            // 
            // txtvDocumento
            // 
            // 
            // 
            // 
            this.txtvDocumento.Border.Class = "TextBoxBorder";
            this.txtvDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtvDocumento.Location = new System.Drawing.Point(149, 59);
            this.txtvDocumento.Name = "txtvDocumento";
            this.txtvDocumento.ReadOnly = true;
            this.txtvDocumento.Size = new System.Drawing.Size(248, 20);
            this.txtvDocumento.TabIndex = 3;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdjuntar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdjuntar.Location = new System.Drawing.Point(398, 59);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(30, 20);
            this.btnAdjuntar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdjuntar.TabIndex = 4;
            this.btnAdjuntar.Text = "...";
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMntSolicitudCheckListDato
            // 
            this.ClientSize = new System.Drawing.Size(499, 181);
            this.DoubleBuffered = true;
            this.Name = "frmMntSolicitudCheckListDato";
            this.Text = "CheckList Solicitud";
            this.Load += new System.EventHandler(this.frmMntSolicitudCheckListDato_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdDocumento_tt;
        private DevComponents.DotNetBar.Controls.TextBoxX txtvDocumento;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnAdjuntar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}