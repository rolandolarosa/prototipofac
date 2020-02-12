using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmEnvioVencimientoDocumento : FormulaBase.frmMntFiltro
    {
        public frmEnvioVencimientoDocumento()
        {
            InitializeComponent();
        }

        private void frmEnvioVencimientoDocumento_Load(object sender, EventArgs e)
        {
            try
            {
                dtFechaFilter.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbFecha.Checked && dtFechaFilter.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Debe ingresar una fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtFechaFilter.Focus();
                    return;
                }

                if (rdbPagadora.Checked && txtIdPagadora.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Seleccione una pagadora", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnBuscarPagadora.Focus();
                    return;
                }

                DataSet ds = new DataSet();
                CobranzaDetalleBE CobranzaDetalleBE = new CobranzaDetalleBE()
                {
                    OPCION = 9,
                    USUARIO = General.General.GetUsuario,
                    sdVencimiento = rdbFecha.Checked ? dtFechaFilter.Value : DateTime.MinValue,
                    IdPagadora = rdbPagadora.Checked ? txtIdPagadora.Text.Trim(): string.Empty
                };

                CobranzaDetalleBL CobranzaDetalleBL = new CobranzaDetalleBL();
                ds = CobranzaDetalleBL.ProcesarCobranzaDetalle(CobranzaDetalleBE);
                dgvDatos.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtFechaFilter.Text = string.Empty;
            txtIdPagadora.Clear();
            txtDescripcion.Clear();
        }

        private void btnBuscarPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaPagadora ofrmBusquedaPagadora = new Formula.Consulta.frmBusquedaPagadora();
                ofrmBusquedaPagadora.ShowDialog();

                DataSet dsPagadora = new DataSet();
                PagadoraBL PagadoraBL = new PagadoraBL();
                PagadoraBE PagadoraBE = new PagadoraBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = ofrmBusquedaPagadora.CodigoPagadora.ToString()
                };

                dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);

                if (dsPagadora.Tables[0].Rows.Count > 0)
                {
                    txtIdPagadora.Text = dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString();
                    txtDescripcion.Text = dsPagadora.Tables[0].Rows[0]["vcPagadora"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Generar
            try
            {
                StringBuilder strHTMLContent = new StringBuilder();
                strHTMLContent.Append("<html>");
                strHTMLContent.Append("<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>");
                strHTMLContent.Append("<body>");

                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    string strFechaVenc = string.IsNullOrEmpty(row.Cells["sdVencimiento"].Value.ToString()) ? "" : Convert.ToDateTime(row.Cells["sdVencimiento"].Value.ToString().Trim()).ToString("d");

                    if (row.Cells["FlgEnviar"].Value.ToString().Equals("1"))
                    {
                        int CountRow = 0;
                        while (CountRow < 2)
                        {
                            strHTMLContent.Append("<table width='100%' style='font-size: 11px;' border='0' cellpadding='0' cellspacing='0'><tr><td width='50%'>");
                            strHTMLContent.Append("<div><img src='D:\\Fuentes\\Efide\\EfideFactoring\\EfideFactoring\\Resources\\logoEfide2.jpg' style='width:100px;height:30px;'></div>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div>COOPAC EFIDE</div>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div>Señores</div>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div>" + row.Cells["IdSocio_Dsc"].Value.ToString().Trim() + "</div>");
                            strHTMLContent.Append("<div>" + row.Cells["DireccionSocio"].Value.ToString().Trim() + "</div>");
                            strHTMLContent.Append("<div>Lima 10</div>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div><b>Documento:</b></div>");
                            ////strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div style='text-align:center'><b>" + row.Cells["cNumDoc"].Value.ToString().Trim() + " (LOTE - " + row.Cells["IdLote"].Value.ToString().Trim() + ")</b></div>");
                            strHTMLContent.Append("<div><b>Doc. Ident. Aceptante:</b> " + row.Cells["RucAceptante"].Value.ToString().Trim() + "</div>");
                            strHTMLContent.Append("<div><b>Importe de la Letra:</b> " + row.Cells["IdMoneda_tt_Dsc"].Value.ToString().Trim() + " " + Convert.ToDecimal(row.Cells["nvNegociable"].Value).ToString("N2").Trim() + "</div>");
                            strHTMLContent.Append("<div><b>Fecha de Vencimiento:</b> " + strFechaVenc.Trim() + "</div>");
                            strHTMLContent.Append("<div><b>Girador:</b> " + row.Cells["IdPagadora_Dsc"].Value.ToString().Trim() + "</div>");
                            strHTMLContent.Append("<div><b>Tipo de Cartera:</b> " + row.Cells["TipoCartera"].Value.ToString().Trim() + "</div>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div style='text-align:center'>CESION DOCUMENTARIA</div>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div>Oficina: Av. El Derby N°254 Of.1106 - Santiago de Surco</div>");
                            strHTMLContent.Append("<div>Atención: L-V 8:30 a 5:00 p.m. Horario Corrido</div>");
                            strHTMLContent.Append("<div>Central Telefónica: 208-5900</div>");
                            strHTMLContent.Append("<div>Email: jcobranzas@efide.com.pe joperaciones@efide.com.pe</div>");
                            strHTMLContent.Append("</td>");
                            strHTMLContent.Append("<td width='50%'>");
                            strHTMLContent.Append("<div style='text-align:center'>AVISO DE VENCIMIENTO</div>");
                            strHTMLContent.Append("<div>");
                            strHTMLContent.Append("<table width='100%' style='font-size: 9px;' border='1' cellpadding='0' cellspacing='0' bordercolor='#000000'>");
                            strHTMLContent.Append("<tr><td colspan='4' align='center'> <b>MONTO ESTIMADO A PAGAR DESPUES DEL VENCIMIENTO </b></td></tr>");
                            strHTMLContent.Append("<tr align='center'><td><b>DIA</b></td><td><b>FECHA VT O.</b></td><td><b>ABONOS/TRANF</b></td><td><b>CON CHEQUE</b></td></tr>");

                            DataSet ds = new DataSet();
                            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                            {
                                SqlCommand cmd1 = new SqlCommand("Rpt_AvisoCobranza", con);
                                cmd1.CommandType = CommandType.StoredProcedure;
                                cmd1.Parameters.AddWithValue("@IdLote", row.Cells["IdLote"].Value.ToString().Trim());
                                cmd1.Parameters.AddWithValue("@cItem", row.Cells["cItem"].Value.ToString().Trim());
                                cmd1.Parameters.AddWithValue("@Opcion", 1);
                                SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                                daCab.Fill(ds, "dtAvisoCobranzaCab");
                                con.Close();
                            }

                            foreach (DataRow item in ds.Tables[0].Rows)
                            {
                                strHTMLContent.Append("<tr><td align='center'>" + item["Dia"].ToString() + "</td><td align='center'>" + item["FechaVencimiento"].ToString() + "</td><td align='right'>" + Convert.ToDecimal(item["Abono"]).ToString("N2") + "</td><td align='right'>" + Convert.ToDecimal(item["AbonoCheque"]).ToString("N2") + "</td></tr>");
                            }

                            strHTMLContent.Append("</table>");
                            strHTMLContent.Append("</div>");
                            strHTMLContent.Append("<div>- El pago después de la fecha de vencimiento considerará los gastos notariales e intereses y las tasas estarán sujetas a variación.</div>");
                            strHTMLContent.Append("<div>- De acuerdo a lo establecido en el artículo 1257 del Código Civil, los pagos efectuados después de su vencimiento, se aplicarán: 1° A los gastos, 2° A los intereses pactados y 3° al capital.</div>");
                            strHTMLContent.Append("<div>- Prodrá cancelarlo en nuestras Oficinas o en bancos:</div>");

                            if (row.Cells["IdMoneda_tt"].Value.ToString().Equals("00037"))
                            {
                                strHTMLContent.Append("<div style='text-align:center'><b>BCP CTA.CTE. ME. 193-1471927-1-57</b></div>");
                                strHTMLContent.Append("<div style='text-align:center'><b>Scotiabank CTA.CTE. ME. 000-3730219</b></div>");
                            }
                            else
                            {
                                strHTMLContent.Append("<div style='text-align:center'><b>BCP CTA.CTE. S/. 193-1461392-0-34</b></div>");
                                strHTMLContent.Append("<div style='text-align:center'><b>Scotiabank CTA.CTE. S/. 000-8245959</b></div>");
                            }
                            
                            strHTMLContent.Append("<div>- Luego de Efectuar el abano/tranf debe enviar la bolera via email.</div>");
                            strHTMLContent.Append("<div>- La letra de cambio pasará a protesto al 6to día de su vencimiento.</div>");
                            strHTMLContent.Append("</td>");
                            strHTMLContent.Append("</tr>");
                            strHTMLContent.Append("<br><br><br><br><br>");
                            strHTMLContent.Append("</table>");
                            strHTMLContent.Append("<br><br>");
                            CountRow++;
                        }
                    }
                }

                strHTMLContent.Append("</body></html>");

                string strPath = "d:\\doc2.doc";
                FileStream fStream = File.Create(strPath);
                fStream.Close();
                StreamWriter sWriter = new StreamWriter(strPath);
                sWriter.Write(strHTMLContent);
                sWriter.Close();

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "winword.EXE";
                startInfo.Arguments = strPath;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Definitivo
            try
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells["FlgEnviar"].Value.ToString().Equals("1"))
                    {
                        //CobranzaDetalleBE CobranzaDetalleBE = new CobranzaDetalleBE()
                        //{
                        //    OPCION = 6,
                        //    USUARIO = General.General.GetUsuario,
                        //    sdFechaOp = General.General.gFechaOp,
                        //    IdCobranza = row.Cells["IdCobranza"].Value.ToString(),
                        //    IdDocumento = row.Cells["IdDocumento"].Value.ToString(),
                        //    cNumDoc = row.Cells["cNumDoc"].Value.ToString(),
                        //};

                        //CobranzaDetalleBL CobranzaDetalleBL = new CobranzaDetalleBL();
                        //CobranzaDetalleBL.ProcesarCobranzaDetalle(CobranzaDetalleBE);
                    }
                }
                //MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //btnBuscar_Click(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}