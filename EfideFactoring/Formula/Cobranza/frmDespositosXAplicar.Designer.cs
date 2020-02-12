namespace EfideFactoring.Formula.Cobranza
{
    partial class frmDespositosXAplicar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDepositosxAplicar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositosxAplicar)).BeginInit();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepositosxAplicar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepositosxAplicar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDepositosxAplicar.Location = new System.Drawing.Point(2, 12);
            this.dgvDepositosxAplicar.Name = "dgvDepositosxAplicar";
            this.dgvDepositosxAplicar.Size = new System.Drawing.Size(910, 266);
            this.dgvDepositosxAplicar.TabIndex = 0;
            this.dgvDepositosxAplicar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepositosxAplicar_CellContentDoubleClick);
            this.dgvDepositosxAplicar.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDepositosxAplicar_CurrentCellDirtyStateChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::EfideFactoring.Properties.Resources.elimina;
            this.btnCancelar.Location = new System.Drawing.Point(828, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 30);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Image = global::EfideFactoring.Properties.Resources.btn_ok;
            this.btnAceptar.Location = new System.Drawing.Point(737, 289);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 30);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.sbFechaOperacion.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.ctasBancariaID.DataPropertyName = "ctasBancariaID";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.Width = 60;
            // 
            // sbGlosa
            // 
            this.sbGlosa.DataPropertyName = "sbGlosa";
            this.sbGlosa.HeaderText = "Glosa";
            this.sbGlosa.Name = "sbGlosa";
            this.sbGlosa.Width = 150;
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
            // frmDespositosXAplicar
            // 
            this.ClientSize = new System.Drawing.Size(915, 325);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvDepositosxAplicar);
            this.DoubleBuffered = true;
            this.Name = "frmDespositosXAplicar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Depositos por Aplicar";
            this.Load += new System.EventHandler(this.frmDespositosXAplicar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositosxAplicar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDepositosxAplicar;
        protected DevComponents.DotNetBar.ButtonX btnCancelar;
        protected DevComponents.DotNetBar.ButtonX btnAceptar;
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
    }
}