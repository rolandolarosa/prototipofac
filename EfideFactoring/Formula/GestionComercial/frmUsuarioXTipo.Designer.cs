namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmUsuarioXTipo
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
            this.dgvUsuarios = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.UsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGestor_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoGestor_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoGestor_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bAdmLineaPag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bAdmBloqueoPag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bAdmContactos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(940, 40);
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.Size = new System.Drawing.Size(940, 54);
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Size = new System.Drawing.Size(147, 20);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Text = "Usuario";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Text = "Usuarios";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(764, 97);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioID,
            this.IdGestor,
            this.IdGestor_Dsc,
            this.IdTipoGestor_tt,
            this.IdTipoGestor_tt_Dsc,
            this.Column1,
            this.Column2,
            this.bAdmLineaPag,
            this.bAdmBloqueoPag,
            this.bAdmContactos});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 125);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(940, 409);
            this.dgvUsuarios.TabIndex = 22;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            this.dgvUsuarios.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellEndEdit);
            // 
            // UsuarioID
            // 
            this.UsuarioID.DataPropertyName = "UsuarioID";
            this.UsuarioID.HeaderText = "Usuario";
            this.UsuarioID.Name = "UsuarioID";
            this.UsuarioID.ReadOnly = true;
            // 
            // IdGestor
            // 
            this.IdGestor.DataPropertyName = "IdGestor";
            this.IdGestor.HeaderText = "IdGestor";
            this.IdGestor.Name = "IdGestor";
            this.IdGestor.ReadOnly = true;
            this.IdGestor.Visible = false;
            // 
            // IdGestor_Dsc
            // 
            this.IdGestor_Dsc.DataPropertyName = "IdGestor_Dsc";
            this.IdGestor_Dsc.HeaderText = "Gestor";
            this.IdGestor_Dsc.Name = "IdGestor_Dsc";
            this.IdGestor_Dsc.ReadOnly = true;
            this.IdGestor_Dsc.Width = 200;
            // 
            // IdTipoGestor_tt
            // 
            this.IdTipoGestor_tt.DataPropertyName = "IdTipoGestor_tt";
            this.IdTipoGestor_tt.HeaderText = "IdTipoGestor_tt";
            this.IdTipoGestor_tt.Name = "IdTipoGestor_tt";
            this.IdTipoGestor_tt.ReadOnly = true;
            this.IdTipoGestor_tt.Visible = false;
            // 
            // IdTipoGestor_tt_Dsc
            // 
            this.IdTipoGestor_tt_Dsc.DataPropertyName = "IdTipoGestor_tt_Dsc";
            this.IdTipoGestor_tt_Dsc.HeaderText = "Tipo";
            this.IdTipoGestor_tt_Dsc.Name = "IdTipoGestor_tt_Dsc";
            this.IdTipoGestor_tt_Dsc.ReadOnly = true;
            this.IdTipoGestor_tt_Dsc.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IndPrint";
            this.Column1.HeaderText = "Imprimir";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IndExport";
            this.Column2.HeaderText = "Exportar";
            this.Column2.Name = "Column2";
            // 
            // bAdmLineaPag
            // 
            this.bAdmLineaPag.DataPropertyName = "bAdmLineaPag";
            this.bAdmLineaPag.HeaderText = "Incr/Reduc Linea Pag.";
            this.bAdmLineaPag.Name = "bAdmLineaPag";
            this.bAdmLineaPag.Width = 80;
            // 
            // bAdmBloqueoPag
            // 
            this.bAdmBloqueoPag.DataPropertyName = "bAdmBloqueoPag";
            this.bAdmBloqueoPag.HeaderText = "Pagadora B/D";
            this.bAdmBloqueoPag.Name = "bAdmBloqueoPag";
            this.bAdmBloqueoPag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bAdmBloqueoPag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bAdmBloqueoPag.Width = 60;
            // 
            // bAdmContactos
            // 
            this.bAdmContactos.DataPropertyName = "bAdmContactos";
            this.bAdmContactos.HeaderText = "Adm / Contactos";
            this.bAdmContactos.Name = "bAdmContactos";
            this.bAdmContactos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bAdmContactos.Width = 60;
            // 
            // frmUsuarioXTipo
            // 
            this.ClientSize = new System.Drawing.Size(940, 546);
            this.Controls.Add(this.dgvUsuarios);
            this.DoubleBuffered = true;
            this.Name = "frmUsuarioXTipo";
            this.Text = "Usuarios Gestores";
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvUsuarios, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGestor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGestor_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoGestor_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoGestor_tt_Dsc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bAdmLineaPag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bAdmBloqueoPag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bAdmContactos;
    }
}