namespace Efide.Tesoreria.WinAdeudos.busqueda
{
    partial class frmBusquedaTransfXAplicarAdeudo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDepositosxAplicar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CheckSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.socioBancoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagar_personaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soc_razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soc_tipoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbFechaOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTipoMpagoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMonedaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ent_emprRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctasBancariaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMonedaID_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctasBanNumCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOperacion_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOperacion_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoAbono_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoAbono_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.ucMsgBox1 = new Efide.ControlsComponent.ucMsgBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.ucLoadingBar1 = new Efide.ControlsComponent.ucLoadingBar();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositosxAplicar)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDepositosxAplicar
            // 
            this.dgvDepositosxAplicar.AllowUserToAddRows = false;
            this.dgvDepositosxAplicar.AllowUserToDeleteRows = false;
            this.dgvDepositosxAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepositosxAplicar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositosxAplicar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSel,
            this.socioBancoID,
            this.pagar_personaID,
            this.soc_razonSocial,
            this.soc_tipoPersona,
            this.tipoOperacion,
            this.sbFechaOperacion,
            this.valorTipoMpagoID,
            this.TipoMpago,
            this.valorMonedaID,
            this.ent_emprRazonSocial,
            this.ctasBancariaID,
            this.valorMonedaID_Dsc,
            this.sbImporte,
            this.Saldo,
            this.sbGlosa,
            this.ctasBanNumCta,
            this.IdOperacion_tt,
            this.IdOperacion_tt_Dsc,
            this.IdTipoAbono_tt,
            this.IdTipoAbono_tt_Dsc});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepositosxAplicar.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDepositosxAplicar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDepositosxAplicar.Location = new System.Drawing.Point(12, 12);
            this.dgvDepositosxAplicar.Name = "dgvDepositosxAplicar";
            this.dgvDepositosxAplicar.RowHeadersVisible = false;
            this.dgvDepositosxAplicar.Size = new System.Drawing.Size(909, 316);
            this.dgvDepositosxAplicar.TabIndex = 23;
            // 
            // CheckSel
            // 
            this.CheckSel.DataPropertyName = "CheckSel";
            this.CheckSel.HeaderText = "";
            this.CheckSel.Name = "CheckSel";
            this.CheckSel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckSel.Width = 20;
            // 
            // socioBancoID
            // 
            this.socioBancoID.DataPropertyName = "socioBancoID";
            this.socioBancoID.HeaderText = "socioBancoID";
            this.socioBancoID.Name = "socioBancoID";
            this.socioBancoID.Visible = false;
            // 
            // pagar_personaID
            // 
            this.pagar_personaID.DataPropertyName = "pagar_personaID";
            this.pagar_personaID.HeaderText = "pagar_personaID";
            this.pagar_personaID.Name = "pagar_personaID";
            this.pagar_personaID.Visible = false;
            // 
            // soc_razonSocial
            // 
            this.soc_razonSocial.DataPropertyName = "soc_razonSocial";
            this.soc_razonSocial.HeaderText = "Socio";
            this.soc_razonSocial.Name = "soc_razonSocial";
            this.soc_razonSocial.Visible = false;
            this.soc_razonSocial.Width = 150;
            // 
            // soc_tipoPersona
            // 
            this.soc_tipoPersona.DataPropertyName = "soc_tipoPersona";
            this.soc_tipoPersona.HeaderText = "Tipo Persona";
            this.soc_tipoPersona.Name = "soc_tipoPersona";
            this.soc_tipoPersona.Visible = false;
            // 
            // tipoOperacion
            // 
            this.tipoOperacion.DataPropertyName = "tipoOperacion";
            this.tipoOperacion.HeaderText = "Tipo Operacion";
            this.tipoOperacion.Name = "tipoOperacion";
            // 
            // sbFechaOperacion
            // 
            this.sbFechaOperacion.DataPropertyName = "sbFechaOperacion";
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            this.sbFechaOperacion.DefaultCellStyle = dataGridViewCellStyle16;
            this.sbFechaOperacion.HeaderText = "Fecha Operacion";
            this.sbFechaOperacion.Name = "sbFechaOperacion";
            // 
            // valorTipoMpagoID
            // 
            this.valorTipoMpagoID.DataPropertyName = "valorTipoMpagoID";
            this.valorTipoMpagoID.HeaderText = "valorTipoMpagoID";
            this.valorTipoMpagoID.Name = "valorTipoMpagoID";
            this.valorTipoMpagoID.Visible = false;
            // 
            // TipoMpago
            // 
            this.TipoMpago.DataPropertyName = "TipoMpago";
            this.TipoMpago.HeaderText = "Tipo de Abono";
            this.TipoMpago.Name = "TipoMpago";
            // 
            // valorMonedaID
            // 
            this.valorMonedaID.DataPropertyName = "valorMonedaID";
            this.valorMonedaID.HeaderText = "valorMonedaID";
            this.valorMonedaID.Name = "valorMonedaID";
            this.valorMonedaID.Visible = false;
            // 
            // ent_emprRazonSocial
            // 
            this.ent_emprRazonSocial.DataPropertyName = "ent_emprRazonSocial";
            this.ent_emprRazonSocial.HeaderText = "Banco";
            this.ent_emprRazonSocial.Name = "ent_emprRazonSocial";
            // 
            // ctasBancariaID
            // 
            this.ctasBancariaID.DataPropertyName = "ctasBanNumCta";
            this.ctasBancariaID.HeaderText = "Cuenta Bancaria";
            this.ctasBancariaID.Name = "ctasBancariaID";
            // 
            // valorMonedaID_Dsc
            // 
            this.valorMonedaID_Dsc.DataPropertyName = "valorMonedaID_Dsc";
            this.valorMonedaID_Dsc.HeaderText = "Moneda";
            this.valorMonedaID_Dsc.Name = "valorMonedaID_Dsc";
            this.valorMonedaID_Dsc.Width = 60;
            // 
            // sbImporte
            // 
            this.sbImporte.DataPropertyName = "sbImporte";
            this.sbImporte.HeaderText = "Importe";
            this.sbImporte.Name = "sbImporte";
            this.sbImporte.Width = 60;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = "0";
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle17;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.Width = 60;
            // 
            // sbGlosa
            // 
            this.sbGlosa.DataPropertyName = "sbGlosa";
            this.sbGlosa.HeaderText = "Glosa";
            this.sbGlosa.Name = "sbGlosa";
            this.sbGlosa.Width = 185;
            // 
            // ctasBanNumCta
            // 
            this.ctasBanNumCta.DataPropertyName = "ctasBanNumCta";
            this.ctasBanNumCta.HeaderText = "ctasBanNumCta";
            this.ctasBanNumCta.Name = "ctasBanNumCta";
            this.ctasBanNumCta.Visible = false;
            // 
            // IdOperacion_tt
            // 
            this.IdOperacion_tt.DataPropertyName = "IdOperacion_tt";
            this.IdOperacion_tt.HeaderText = "IdOperacion_tt";
            this.IdOperacion_tt.Name = "IdOperacion_tt";
            this.IdOperacion_tt.Visible = false;
            // 
            // IdOperacion_tt_Dsc
            // 
            this.IdOperacion_tt_Dsc.DataPropertyName = "IdOperacion_tt_Dsc";
            this.IdOperacion_tt_Dsc.HeaderText = "IdOperacion_tt_Dsc";
            this.IdOperacion_tt_Dsc.Name = "IdOperacion_tt_Dsc";
            this.IdOperacion_tt_Dsc.Visible = false;
            // 
            // IdTipoAbono_tt
            // 
            this.IdTipoAbono_tt.DataPropertyName = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.HeaderText = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.Name = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.Visible = false;
            // 
            // IdTipoAbono_tt_Dsc
            // 
            this.IdTipoAbono_tt_Dsc.DataPropertyName = "IdTipoAbono_tt_Dsc";
            this.IdTipoAbono_tt_Dsc.HeaderText = "IdTipoAbono_tt_Dsc";
            this.IdTipoAbono_tt_Dsc.Name = "IdTipoAbono_tt_Dsc";
            this.IdTipoAbono_tt_Dsc.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.btn_ok;
            this.btnAceptar.Location = new System.Drawing.Point(745, 334);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 30);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.elimina;
            this.btnCancelar.Location = new System.Drawing.Point(836, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 30);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            // 
            // ucMsgBox1
            // 
            this.ucMsgBox1.Location = new System.Drawing.Point(309, 303);
            this.ucMsgBox1.Name = "ucMsgBox1";
            this.ucMsgBox1.Size = new System.Drawing.Size(10, 10);
            this.ucMsgBox1.TabIndex = 26;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = global::Efide.Tesoreria.WinAdeudos.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(664, 334);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // ucLoadingBar1
            // 
            this.ucLoadingBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadingBar1.Location = new System.Drawing.Point(12, 334);
            this.ucLoadingBar1.Name = "ucLoadingBar1";
            this.ucLoadingBar1.Size = new System.Drawing.Size(167, 26);
            this.ucLoadingBar1.TabIndex = 30;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnBuscar);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(933, 371);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 31;
            // 
            // frmBusquedaTransfXAplicar
            // 
            this.ClientSize = new System.Drawing.Size(933, 371);
            this.Controls.Add(this.dgvDepositosxAplicar);
            this.Controls.Add(this.ucLoadingBar1);
            this.Controls.Add(this.ucMsgBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "frmBusquedaTransfXAplicar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Búsqueda Depósitos";
            this.Load += new System.EventHandler(this.frmBusquedaTransfXAplicarAdeudo_Load);
            this.Enter += new System.EventHandler(this.frmBusquedaTransfXAplicar_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositosxAplicar)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDepositosxAplicar;
        protected DevComponents.DotNetBar.ButtonX btnAceptar;
        protected DevComponents.DotNetBar.ButtonX btnCancelar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioBancoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagar_personaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn soc_razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn soc_tipoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbFechaOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTipoMpagoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMonedaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ent_emprRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctasBancariaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMonedaID_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctasBanNumCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOperacion_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOperacion_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoAbono_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoAbono_tt_Dsc;
        private ControlsComponent.ucMsgBox ucMsgBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private ControlsComponent.ucLoadingBar ucLoadingBar1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
    }
}