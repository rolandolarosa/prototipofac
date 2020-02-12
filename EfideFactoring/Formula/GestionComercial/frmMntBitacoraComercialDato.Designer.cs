namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmMntBitacoraComercialDato
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
            this.lblSocio = new DevComponents.DotNetBar.LabelX();
            this.cboIdTipoBitacora_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtFechaAlerta = new System.Windows.Forms.DateTimePicker();
            this.btnAtender = new DevComponents.DotNetBar.ButtonX();
            this.btnAtenderProgramar = new DevComponents.DotNetBar.ButtonX();
            this.btnVerDatosSocio = new DevComponents.DotNetBar.ButtonX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.btnVerDatosSocio);
            this.grpDato.Controls.Add(this.dtFechaAlerta);
            this.grpDato.Controls.Add(this.labelX3);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.txtDescripcion);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.cboIdTipoBitacora_tt);
            this.grpDato.Controls.Add(this.lblSocio);
            this.grpDato.Size = new System.Drawing.Size(658, 213);
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
            this.btnCancelar.Location = new System.Drawing.Point(577, 234);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(486, 234);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblSocio
            // 
            this.lblSocio.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSocio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.ForeColor = System.Drawing.Color.Black;
            this.lblSocio.Location = new System.Drawing.Point(18, 21);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(533, 20);
            this.lblSocio.TabIndex = 14;
            this.lblSocio.Text = "Socio";
            // 
            // cboIdTipoBitacora_tt
            // 
            this.cboIdTipoBitacora_tt.DisplayMember = "Text";
            this.cboIdTipoBitacora_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdTipoBitacora_tt.DropDownHeight = 600;
            this.cboIdTipoBitacora_tt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdTipoBitacora_tt.FormattingEnabled = true;
            this.cboIdTipoBitacora_tt.IntegralHeight = false;
            this.cboIdTipoBitacora_tt.ItemHeight = 14;
            this.cboIdTipoBitacora_tt.Location = new System.Drawing.Point(130, 47);
            this.cboIdTipoBitacora_tt.Name = "cboIdTipoBitacora_tt";
            this.cboIdTipoBitacora_tt.Size = new System.Drawing.Size(497, 20);
            this.cboIdTipoBitacora_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdTipoBitacora_tt.TabIndex = 15;
            this.cboIdTipoBitacora_tt.SelectedIndexChanged += new System.EventHandler(this.cboIdTipoBitacora_tt_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(18, 43);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 23);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "Tipo";
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Location = new System.Drawing.Point(130, 73);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(497, 80);
            this.txtDescripcion.TabIndex = 17;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(18, 73);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(93, 23);
            this.labelX2.TabIndex = 18;
            this.labelX2.Text = "Descripción";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(18, 159);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(105, 32);
            this.labelX3.TabIndex = 19;
            this.labelX3.Text = "Fecha Programación";
            // 
            // dtFechaAlerta
            // 
            this.dtFechaAlerta.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtFechaAlerta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaAlerta.Location = new System.Drawing.Point(130, 162);
            this.dtFechaAlerta.Name = "dtFechaAlerta";
            this.dtFechaAlerta.Size = new System.Drawing.Size(200, 20);
            this.dtFechaAlerta.TabIndex = 21;
            this.dtFechaAlerta.ValueChanged += new System.EventHandler(this.dtFechaAlerta_ValueChanged);
            // 
            // btnAtender
            // 
            this.btnAtender.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAtender.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAtender.Image = global::EfideFactoring.Properties.Resources.btn_ok;
            this.btnAtender.Location = new System.Drawing.Point(390, 234);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(90, 30);
            this.btnAtender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAtender.TabIndex = 14;
            this.btnAtender.Text = "Atender y Salir";
            this.btnAtender.Visible = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnAtenderProgramar
            // 
            this.btnAtenderProgramar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAtenderProgramar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAtenderProgramar.Image = global::EfideFactoring.Properties.Resources.btn_ok;
            this.btnAtenderProgramar.Location = new System.Drawing.Point(294, 234);
            this.btnAtenderProgramar.Name = "btnAtenderProgramar";
            this.btnAtenderProgramar.Size = new System.Drawing.Size(90, 30);
            this.btnAtenderProgramar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAtenderProgramar.TabIndex = 15;
            this.btnAtenderProgramar.Text = "Atender y Programar";
            this.btnAtenderProgramar.Visible = false;
            this.btnAtenderProgramar.Click += new System.EventHandler(this.btnAtenderProgramar_Click);
            // 
            // btnVerDatosSocio
            // 
            this.btnVerDatosSocio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerDatosSocio.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVerDatosSocio.Image = global::EfideFactoring.Properties.Resources.Binocular;
            this.btnVerDatosSocio.Location = new System.Drawing.Point(524, 21);
            this.btnVerDatosSocio.Name = "btnVerDatosSocio";
            this.btnVerDatosSocio.Size = new System.Drawing.Size(102, 23);
            this.btnVerDatosSocio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVerDatosSocio.TabIndex = 22;
            this.btnVerDatosSocio.Text = "Datos Socio";
            this.btnVerDatosSocio.Visible = false;
            this.btnVerDatosSocio.Click += new System.EventHandler(this.btnVerDatosSocio_Click);
            // 
            // frmMntBitacoraComercialDato
            // 
            this.ClientSize = new System.Drawing.Size(666, 270);
            this.Controls.Add(this.btnAtenderProgramar);
            this.Controls.Add(this.btnAtender);
            this.DoubleBuffered = true;
            this.Name = "frmMntBitacoraComercialDato";
            this.Text = "Bitacora Comercial - Dato";
            this.Load += new System.EventHandler(this.frmMntBitacoraComercialDato_Load);
            this.Controls.SetChildIndex(this.grpDato, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnAtender, 0);
            this.Controls.SetChildIndex(this.btnAtenderProgramar, 0);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.LabelX lblSocio;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdTipoBitacora_tt;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DateTimePicker dtFechaAlerta;
        private DevComponents.DotNetBar.ButtonX btnAtender;
        private DevComponents.DotNetBar.ButtonX btnAtenderProgramar;
        private DevComponents.DotNetBar.ButtonX btnVerDatosSocio;
    }
}