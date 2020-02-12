namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmCompromiso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCompromisoCom = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblSocio = new DevComponents.DotNetBar.LabelX();
            this.lblEjecutivo = new DevComponents.DotNetBar.LabelX();
            this.IdCompromiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdFechaReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RucPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsector_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsector_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoLin_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoLin_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nLineaDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoSer_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcDescServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nImporteFIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nImporteAte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcargo_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoanx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailcorp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoSer_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcargo_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisoCom)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(1722, 40);
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
            this.PanelEx1.Controls.Add(this.lblEjecutivo);
            this.PanelEx1.Controls.Add(this.lblSocio);
            this.PanelEx1.Size = new System.Drawing.Size(1722, 54);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.Controls.SetChildIndex(this.LabelX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.TextBoxX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.lblSocio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.lblEjecutivo, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(987, 7);
            this.btnLimpiar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(910, 7);
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(889, 19);
            this.TextBoxX1.Size = new System.Drawing.Size(15, 20);
            this.TextBoxX1.Visible = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(824, 19);
            this.LabelX1.Visible = false;
            // 
            // lblGrilla
            // 
            this.lblGrilla.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrilla.Size = new System.Drawing.Size(244, 23);
            this.lblGrilla.Text = "Compromisos de Financiamiento";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(1546, 97);
            // 
            // dgvCompromisoCom
            // 
            this.dgvCompromisoCom.AllowUserToAddRows = false;
            this.dgvCompromisoCom.AllowUserToDeleteRows = false;
            this.dgvCompromisoCom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompromisoCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromisoCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCompromiso,
            this.Cliente,
            this.sdFechaReg,
            this.IdPagadora,
            this.RucPagadora,
            this.vcPagadora,
            this.Origen,
            this.idsector_tt_Dsc,
            this.idsector_tt,
            this.IdTipoLin_tt_Dsc,
            this.IdTipoLin_tt,
            this.nLineaDisp,
            this.IdTipoSer_tt_Dsc,
            this.vcDescServicio,
            this.IdMoneda_tt_Dsc,
            this.nImporteFIn,
            this.sdFechaFin,
            this.nImporteAte,
            this.IdLote,
            this.cItem,
            this.vcContacto,
            this.idcargo_tt_Dsc,
            this.telefonoanx,
            this.celular,
            this.emailcorp,
            this.IdTipoSer_tt,
            this.IdMoneda_tt,
            this.idcargo_tt,
            this.UserNew});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompromisoCom.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCompromisoCom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCompromisoCom.Location = new System.Drawing.Point(0, 125);
            this.dgvCompromisoCom.Name = "dgvCompromisoCom";
            this.dgvCompromisoCom.ReadOnly = true;
            this.dgvCompromisoCom.Size = new System.Drawing.Size(1722, 457);
            this.dgvCompromisoCom.TabIndex = 22;
            // 
            // lblSocio
            // 
            // 
            // 
            // 
            this.lblSocio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.ForeColor = System.Drawing.Color.Black;
            this.lblSocio.Location = new System.Drawing.Point(23, 19);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(352, 20);
            this.lblSocio.TabIndex = 7;
            this.lblSocio.Text = "Socio";
            // 
            // lblEjecutivo
            // 
            // 
            // 
            // 
            this.lblEjecutivo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEjecutivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjecutivo.ForeColor = System.Drawing.Color.Black;
            this.lblEjecutivo.Location = new System.Drawing.Point(403, 18);
            this.lblEjecutivo.Name = "lblEjecutivo";
            this.lblEjecutivo.Size = new System.Drawing.Size(352, 20);
            this.lblEjecutivo.TabIndex = 8;
            this.lblEjecutivo.Text = "Ejecutivo";
            // 
            // IdCompromiso
            // 
            this.IdCompromiso.DataPropertyName = "IdCompromiso";
            this.IdCompromiso.HeaderText = "Código";
            this.IdCompromiso.Name = "IdCompromiso";
            this.IdCompromiso.ReadOnly = true;
            this.IdCompromiso.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Socio / Prospecto";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 150;
            // 
            // sdFechaReg
            // 
            this.sdFechaReg.DataPropertyName = "sdFechaReg";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.sdFechaReg.DefaultCellStyle = dataGridViewCellStyle1;
            this.sdFechaReg.HeaderText = "Fecha Registro";
            this.sdFechaReg.Name = "sdFechaReg";
            this.sdFechaReg.ReadOnly = true;
            this.sdFechaReg.Width = 80;
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "IdPagadora";
            this.IdPagadora.Name = "IdPagadora";
            this.IdPagadora.ReadOnly = true;
            this.IdPagadora.Visible = false;
            // 
            // RucPagadora
            // 
            this.RucPagadora.DataPropertyName = "RucPagadora";
            this.RucPagadora.HeaderText = "Ruc Pagadora";
            this.RucPagadora.Name = "RucPagadora";
            this.RucPagadora.ReadOnly = true;
            // 
            // vcPagadora
            // 
            this.vcPagadora.DataPropertyName = "vcPagadora";
            this.vcPagadora.HeaderText = "Pagadora";
            this.vcPagadora.Name = "vcPagadora";
            this.vcPagadora.ReadOnly = true;
            this.vcPagadora.Width = 150;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "Origen";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            // 
            // idsector_tt_Dsc
            // 
            this.idsector_tt_Dsc.DataPropertyName = "idsector_tt_Dsc";
            this.idsector_tt_Dsc.HeaderText = "Sector";
            this.idsector_tt_Dsc.Name = "idsector_tt_Dsc";
            this.idsector_tt_Dsc.ReadOnly = true;
            this.idsector_tt_Dsc.Width = 80;
            // 
            // idsector_tt
            // 
            this.idsector_tt.DataPropertyName = "idsector_tt";
            this.idsector_tt.HeaderText = "idsector_tt";
            this.idsector_tt.Name = "idsector_tt";
            this.idsector_tt.ReadOnly = true;
            this.idsector_tt.Visible = false;
            // 
            // IdTipoLin_tt_Dsc
            // 
            this.IdTipoLin_tt_Dsc.DataPropertyName = "IdTipoLin_tt_Dsc";
            this.IdTipoLin_tt_Dsc.HeaderText = "Tipo Línea";
            this.IdTipoLin_tt_Dsc.Name = "IdTipoLin_tt_Dsc";
            this.IdTipoLin_tt_Dsc.ReadOnly = true;
            this.IdTipoLin_tt_Dsc.Visible = false;
            this.IdTipoLin_tt_Dsc.Width = 80;
            // 
            // IdTipoLin_tt
            // 
            this.IdTipoLin_tt.DataPropertyName = "IdTipoLin_tt";
            this.IdTipoLin_tt.HeaderText = "IdTipoLin_tt";
            this.IdTipoLin_tt.Name = "IdTipoLin_tt";
            this.IdTipoLin_tt.ReadOnly = true;
            this.IdTipoLin_tt.Visible = false;
            // 
            // nLineaDisp
            // 
            this.nLineaDisp.DataPropertyName = "nLineaDisp";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.nLineaDisp.DefaultCellStyle = dataGridViewCellStyle2;
            this.nLineaDisp.HeaderText = "Línea Disponible";
            this.nLineaDisp.Name = "nLineaDisp";
            this.nLineaDisp.ReadOnly = true;
            this.nLineaDisp.Width = 80;
            // 
            // IdTipoSer_tt_Dsc
            // 
            this.IdTipoSer_tt_Dsc.DataPropertyName = "IdTipoSer_tt_Dsc";
            this.IdTipoSer_tt_Dsc.HeaderText = "Tipo Servicio";
            this.IdTipoSer_tt_Dsc.Name = "IdTipoSer_tt_Dsc";
            this.IdTipoSer_tt_Dsc.ReadOnly = true;
            // 
            // vcDescServicio
            // 
            this.vcDescServicio.DataPropertyName = "vcDescServicio";
            this.vcDescServicio.HeaderText = "Descripción Servicio";
            this.vcDescServicio.Name = "vcDescServicio";
            this.vcDescServicio.ReadOnly = true;
            // 
            // IdMoneda_tt_Dsc
            // 
            this.IdMoneda_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.HeaderText = "Mon.";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            this.IdMoneda_tt_Dsc.Width = 60;
            // 
            // nImporteFIn
            // 
            this.nImporteFIn.DataPropertyName = "nImporteFIn";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.nImporteFIn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nImporteFIn.HeaderText = "Impote Finac.";
            this.nImporteFIn.Name = "nImporteFIn";
            this.nImporteFIn.ReadOnly = true;
            this.nImporteFIn.Width = 80;
            // 
            // sdFechaFin
            // 
            this.sdFechaFin.DataPropertyName = "sdFechaFin";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.sdFechaFin.DefaultCellStyle = dataGridViewCellStyle4;
            this.sdFechaFin.HeaderText = "Fecha Financ.";
            this.sdFechaFin.Name = "sdFechaFin";
            this.sdFechaFin.ReadOnly = true;
            this.sdFechaFin.Width = 80;
            // 
            // nImporteAte
            // 
            this.nImporteAte.DataPropertyName = "nImporteAte";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.nImporteAte.DefaultCellStyle = dataGridViewCellStyle5;
            this.nImporteAte.HeaderText = "Importe Aten.";
            this.nImporteAte.Name = "nImporteAte";
            this.nImporteAte.ReadOnly = true;
            this.nImporteAte.Width = 80;
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "IdLote";
            this.IdLote.HeaderText = "IdLote";
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            this.IdLote.Visible = false;
            // 
            // cItem
            // 
            this.cItem.DataPropertyName = "cItem";
            this.cItem.HeaderText = "cItem";
            this.cItem.Name = "cItem";
            this.cItem.ReadOnly = true;
            this.cItem.Visible = false;
            // 
            // vcContacto
            // 
            this.vcContacto.DataPropertyName = "vcContacto";
            this.vcContacto.HeaderText = "Contacto";
            this.vcContacto.Name = "vcContacto";
            this.vcContacto.ReadOnly = true;
            // 
            // idcargo_tt_Dsc
            // 
            this.idcargo_tt_Dsc.DataPropertyName = "idcargo_tt_Dsc";
            this.idcargo_tt_Dsc.HeaderText = "Cargo";
            this.idcargo_tt_Dsc.Name = "idcargo_tt_Dsc";
            this.idcargo_tt_Dsc.ReadOnly = true;
            this.idcargo_tt_Dsc.Width = 80;
            // 
            // telefonoanx
            // 
            this.telefonoanx.DataPropertyName = "telefonoanx";
            this.telefonoanx.HeaderText = "Teléfono";
            this.telefonoanx.Name = "telefonoanx";
            this.telefonoanx.ReadOnly = true;
            this.telefonoanx.Width = 60;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 60;
            // 
            // emailcorp
            // 
            this.emailcorp.DataPropertyName = "emailcorp";
            this.emailcorp.HeaderText = "Email";
            this.emailcorp.Name = "emailcorp";
            this.emailcorp.ReadOnly = true;
            // 
            // IdTipoSer_tt
            // 
            this.IdTipoSer_tt.DataPropertyName = "IdTipoSer_tt";
            this.IdTipoSer_tt.HeaderText = "IdTipoSer_tt";
            this.IdTipoSer_tt.Name = "IdTipoSer_tt";
            this.IdTipoSer_tt.ReadOnly = true;
            this.IdTipoSer_tt.Visible = false;
            // 
            // IdMoneda_tt
            // 
            this.IdMoneda_tt.DataPropertyName = "IdMoneda_tt";
            this.IdMoneda_tt.HeaderText = "IdMoneda_tt";
            this.IdMoneda_tt.Name = "IdMoneda_tt";
            this.IdMoneda_tt.ReadOnly = true;
            this.IdMoneda_tt.Visible = false;
            // 
            // idcargo_tt
            // 
            this.idcargo_tt.DataPropertyName = "idcargo_tt";
            this.idcargo_tt.HeaderText = "idcargo_tt";
            this.idcargo_tt.Name = "idcargo_tt";
            this.idcargo_tt.ReadOnly = true;
            this.idcargo_tt.Visible = false;
            // 
            // UserNew
            // 
            this.UserNew.DataPropertyName = "UserNew";
            this.UserNew.HeaderText = "UserNew";
            this.UserNew.Name = "UserNew";
            this.UserNew.ReadOnly = true;
            this.UserNew.Visible = false;
            // 
            // frmCompromiso
            // 
            this.ClientSize = new System.Drawing.Size(1722, 594);
            this.Controls.Add(this.dgvCompromisoCom);
            this.DoubleBuffered = true;
            this.Name = "frmCompromiso";
            this.Text = "Compromisos";
            this.Load += new System.EventHandler(this.frmCompromiso_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvCompromisoCom, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisoCom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCompromisoCom;
        protected DevComponents.DotNetBar.LabelX lblSocio;
        protected DevComponents.DotNetBar.LabelX lblEjecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompromiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdFechaReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn RucPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsector_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsector_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoLin_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoLin_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nLineaDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoSer_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcDescServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nImporteFIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nImporteAte;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcargo_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoanx;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcorp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoSer_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcargo_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNew;
    }
}