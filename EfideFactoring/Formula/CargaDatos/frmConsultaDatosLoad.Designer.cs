namespace EfideFactoring.Formula.CargaDatos
{
    partial class frmConsultaDatosLoad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaDatosLoad));
            this.dgvCargaDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnImprimir = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocialNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatosAdicionales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonBar1
            // 
            // 
            // 
            // 
            this.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar1.Size = new System.Drawing.Size(1043, 40);
            // 
            // 
            // 
            this.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::EfideFactoring.Properties.Resources.previo;
            this.btnNuevo.Text = "&Imprimir";
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Visible = false;
            // 
            // PanelEx1
            // 
            this.PanelEx1.Size = new System.Drawing.Size(1043, 54);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(430, 4);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(353, 4);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Size = new System.Drawing.Size(242, 22);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Text = "Descripción";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Text = "Datos";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(867, 97);
            // 
            // dgvCargaDatos
            // 
            this.dgvCargaDatos.AllowUserToAddRows = false;
            this.dgvCargaDatos.AllowUserToDeleteRows = false;
            this.dgvCargaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCargaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnImprimir,
            this.Codigo,
            this.RazonSocialNombres,
            this.DatosAdicionales});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCargaDatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCargaDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCargaDatos.Location = new System.Drawing.Point(0, 122);
            this.dgvCargaDatos.Name = "dgvCargaDatos";
            this.dgvCargaDatos.ReadOnly = true;
            this.dgvCargaDatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCargaDatos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCargaDatos.RowTemplate.Height = 24;
            this.dgvCargaDatos.Size = new System.Drawing.Size(1043, 323);
            this.dgvCargaDatos.TabIndex = 22;
            this.dgvCargaDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargaDatos_CellClick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.HeaderText = "";
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ReadOnly = true;
            this.btnImprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnImprimir.Text = null;
            this.btnImprimir.Width = 50;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // RazonSocialNombres
            // 
            this.RazonSocialNombres.DataPropertyName = "RazonSocialNombres";
            this.RazonSocialNombres.HeaderText = "RazonSocial/Nombres";
            this.RazonSocialNombres.Name = "RazonSocialNombres";
            this.RazonSocialNombres.ReadOnly = true;
            this.RazonSocialNombres.Width = 200;
            // 
            // DatosAdicionales
            // 
            this.DatosAdicionales.DataPropertyName = "DatosAdicionales";
            this.DatosAdicionales.HeaderText = "Datos Adicionales";
            this.DatosAdicionales.Name = "DatosAdicionales";
            this.DatosAdicionales.ReadOnly = true;
            this.DatosAdicionales.Width = 600;
            // 
            // frmConsultaDatosLoad
            // 
            this.ClientSize = new System.Drawing.Size(1043, 460);
            this.Controls.Add(this.dgvCargaDatos);
            this.DoubleBuffered = true;
            this.Name = "frmConsultaDatosLoad";
            this.Text = "Consulta de Datos";
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvCargaDatos, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCargaDatos;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocialNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosAdicionales;
    }
}