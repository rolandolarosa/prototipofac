namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmCarteraSocioCarga
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
            this.btnImportar = new DevComponents.DotNetBar.ButtonX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvCargaSocios = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.dgvCargaSocios);
            this.grpDato.Controls.Add(this.btnImportar);
            this.grpDato.Size = new System.Drawing.Size(720, 323);
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
            this.btnCancelar.Location = new System.Drawing.Point(639, 344);
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.Tooltip = "Salir";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(548, 344);
            this.btnAceptar.Visible = false;
            // 
            // btnImportar
            // 
            this.btnImportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportar.Image = global::EfideFactoring.Properties.Resources.excel_2013;
            this.btnImportar.Location = new System.Drawing.Point(14, 31);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(87, 24);
            this.btnImportar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportar.TabIndex = 12;
            this.btnImportar.Text = "&Importar";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvCargaSocios
            // 
            this.dgvCargaSocios.AllowUserToAddRows = false;
            this.dgvCargaSocios.AllowUserToDeleteRows = false;
            this.dgvCargaSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCargaSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargaSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSocio,
            this.IdSocio_Dsc,
            this.UsuarioID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCargaSocios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCargaSocios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCargaSocios.Location = new System.Drawing.Point(14, 74);
            this.dgvCargaSocios.Name = "dgvCargaSocios";
            this.dgvCargaSocios.ReadOnly = true;
            this.dgvCargaSocios.RowTemplate.Height = 24;
            this.dgvCargaSocios.Size = new System.Drawing.Size(683, 221);
            this.dgvCargaSocios.TabIndex = 13;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "Código Socio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Width = 130;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 300;
            // 
            // UsuarioID
            // 
            this.UsuarioID.DataPropertyName = "UsuarioID";
            this.UsuarioID.HeaderText = "Usuario";
            this.UsuarioID.Name = "UsuarioID";
            this.UsuarioID.ReadOnly = true;
            this.UsuarioID.Width = 120;
            // 
            // frmCarteraSocioCarga
            // 
            this.ClientSize = new System.Drawing.Size(728, 380);
            this.DoubleBuffered = true;
            this.Name = "frmCarteraSocioCarga";
            this.Text = "Asignación de Cartera: Carga de Socios";
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnImportar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCargaSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioID;
    }
}