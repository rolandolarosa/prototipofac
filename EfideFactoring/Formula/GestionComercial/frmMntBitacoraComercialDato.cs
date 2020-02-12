using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmMntBitacoraComercialDato : FormulaBase.frmMntDato
    {
        public string _IdSocio = string.Empty;
        public string _NombreSocio = string.Empty;
        public string _NombreGestor = string.Empty;
        public string _IdGestor = string.Empty;
        public int _FlgOrigen = 1;
        public int _FlgBitacoraComercial = 1;
        public int OrigenAtender = 0;
        public string IdBitacoraComercialGenerada = string.Empty;
        private DataTable dt = new DataTable();
        BitacoraComercialBL BitacoraComercialBL = new BitacoraComercialBL();
        public frmMntBitacoraComercialDato()
        {
            InitializeComponent();
        }

        private void frmMntBitacoraComercialDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                if (_FlgOrigen == 1)
                {
                    lblSocio.Text = "Socio: " + _IdSocio.Trim() + " - " + _NombreSocio.Trim();
                }
                else
                {
                    lblSocio.Text = "Pagadora: " + _IdSocio.Trim() + " - " + _NombreSocio.Trim();
                }

                if (Operacion.Equals("M"))
                {
                    if (OrigenAtender == 1 && _FlgOrigen == 1)
                    {
                        btnAtender.Visible = true;
                        btnAtenderProgramar.Visible = true;
                        btnVerDatosSocio.Visible = true;
                        btnAceptar.Enabled = false;
                    }
                    else if (OrigenAtender == 1 && _FlgOrigen == 0) // Gestion Pagadoras
                    {
                        btnAtender.Visible = true;
                        btnAtenderProgramar.Visible = true;
                        btnAceptar.Enabled = false;
                    }
                    else
                    {
                        btnAceptar.Visible = false;
                    }

                    CargarDatos();
                }

                this.Width = 682; /* * Centrar el formulario */
                int boundWidth = Screen.PrimaryScreen.Bounds.Width;
                int boundHeight = Screen.PrimaryScreen.Bounds.Height;
                int x = boundWidth - this.Width;
                int y = boundHeight - (this.Height - 100);
                this.Location = new Point(x / 2, y / 4);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_IdSocio))
                {
                    MessageBox.Show("Se debe Ingresar un IdSocio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (cboIdTipoBitacora_tt.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar un IdTipoBitacora_tt", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Se debe Ingresar un Descripcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (dtFechaAlerta.CustomFormat == " ")
                {
                    MessageBox.Show("Ingrese una fecha de programación.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BitacoraComercialBE BitacoraComercialBE = new BitacoraComercialBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdBitacoraComercial = Codigo,
                    IdSocio = _IdSocio,
                    IdTipoBitacora_tt = cboIdTipoBitacora_tt.SelectedValue.ToString(),
                    Descripcion = txtDescripcion.Text,
                    FechaAlerta = dtFechaAlerta.Value,
                    IdGestor = _IdGestor,
                    IdBitacoraComercialGenerada = IdBitacoraComercialGenerada,
                    FlgOrigen = _FlgOrigen
                };

                DataSet dsBitacoraComercial = new DataSet();
                dsBitacoraComercial = BitacoraComercialBL.ProcesarBitacoraComercial(BitacoraComercialBE);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos()
        {
            try
            {
                DataSet dsBitacoraComercial = new DataSet();
                BitacoraComercialBE BitacoraComercialBE = new BitacoraComercialBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdBitacoraComercial = Codigo,
                };
                
                dsBitacoraComercial = BitacoraComercialBL.ProcesarBitacoraComercial(BitacoraComercialBE);
                
                if (dsBitacoraComercial.Tables[0].Rows.Count > 0)
                {
                    cboIdTipoBitacora_tt.SelectedValue = dsBitacoraComercial.Tables[0].Rows[0]["IdTipoBitacora_tt"].ToString();
                    txtDescripcion.Text = dsBitacoraComercial.Tables[0].Rows[0]["Descripcion"].ToString();
                    dtFechaAlerta.Value = Convert.ToDateTime(dsBitacoraComercial.Tables[0].Rows[0]["FechaAlerta"].ToString());
                }
                else
                {
                    MessageBox.Show("Este .... no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCombos()
        {
            try
            {
                String Table_Id = _FlgBitacoraComercial == 1 ? "00226" : "01029"; //Tipo Bitacora Pagadoras
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                dt = new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0];
                cboIdTipoBitacora_tt.DataSource = dt;
                cboIdTipoBitacora_tt.DisplayMember = "Table_Name";
                cboIdTipoBitacora_tt.ValueMember = "Table_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsBitacoraComercial = new DataSet();
                BitacoraComercialBE BitacoraComercialBE = new BitacoraComercialBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetUsuario,
                    IdBitacoraComercial = Codigo
                };
                new BitacoraComercialBL().ProcesarBitacoraComercial(BitacoraComercialBE);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtenderProgramar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsBitacoraComercial = new DataSet();
                BitacoraComercialBE BitacoraComercialBE = new BitacoraComercialBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetUsuario,
                    IdBitacoraComercial = Codigo
                };
                new BitacoraComercialBL().ProcesarBitacoraComercial(BitacoraComercialBE);

                IdBitacoraComercialGenerada = Codigo;
                Codigo = string.Empty;
                btnAceptar.Enabled = true;
                btnAtenderProgramar.Enabled = false;
                btnAtender.Enabled = false;
                cboIdTipoBitacora_tt.SelectedValue = string.Empty;
                dtFechaAlerta.Value = DateTime.Now;
                txtDescripcion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerDatosSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (_IdSocio.ToString().Trim().Length == 10)
                {
                    frmCarteraCandidatoDato ofrm = new frmCarteraCandidatoDato();
                    ofrm.Operacion = "M";
                    ofrm.Codigo = _IdSocio;
                    ofrm._OrigenGestion = 1;
                    ofrm.ShowDialog();
                }
                else
                {
                    frmQryDatosSocio ofrm = new frmQryDatosSocio();
                    ofrm.Codigo = _IdSocio;
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdTipoBitacora_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cboIdTipoBitacora_tt.SelectedValue.ToString()) && (OrigenAtender == 1 || Operacion == "N"))
                {
                    DataRow[] dr = dt.Select("Table_Id = " + cboIdTipoBitacora_tt.SelectedValue.ToString());

                    if (dr.Length > 0)
                    {
                        if (dr[0]["Table_Value"].ToString().Equals("A"))
                        {
                            dtFechaAlerta.Enabled = true;
                            dtFechaAlerta.CustomFormat = " ";
                            //dtFechaAlerta.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                        }
                        else
                        {
                            dtFechaAlerta.Enabled = false;
                            dtFechaAlerta.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                            dtFechaAlerta.Value = DateTime.Now;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void dtFechaAlerta_ValueChanged(object sender, EventArgs e)
        {
            dtFechaAlerta.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }
    }
}