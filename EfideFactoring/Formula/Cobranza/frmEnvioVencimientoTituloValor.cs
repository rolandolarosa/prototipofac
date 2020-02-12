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
using iTextSharp.text.pdf;
using iTextSharp.text;
using Word = Microsoft.Office.Interop.Word;
using  Microsoft.Office.Interop.Word;
using CrystalDecisions.Shared;


namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmEnvioVencimientoTituloValor : FormulaBase.frmMntFiltro
    {

        public Microsoft.Office.Interop.Word.Document wordDocument { get; set; }
        public frmEnvioVencimientoTituloValor()
        {
            InitializeComponent();
        }

        private void frmEnvioVencimientoTituloValor_Load(object sender, EventArgs e)
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
                    OPCION = 8,
                    USUARIO = General.General.GetUsuario,
                    sdVencimiento = rdbFecha.Checked ? dtFechaFilter.Value : DateTime.MinValue,
                    IdPagadora = rdbPagadora.Checked ? txtIdPagadora.Text.Trim() : string.Empty
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
            Word.Application appWord = new Word.Application();
            appWord.ScreenUpdating = false;
            appWord.DisplayAlerts =   0;  
            appWord.Visible = false;
            try
            {
                StringBuilder strHTMLContent = new StringBuilder();
                //strHTMLContent.Append("<html>");
                //strHTMLContent.Append("<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>");
                //strHTMLContent.Append("<body>");

                //iTextSharp.text.Document oDoc = new iTextSharp.text.Document();
                //PdfWriter.GetInstance(oDoc, new FileStream("HelloWorld.pdf", FileMode.Create));
                //oDoc.Open();
                //oDoc.Add(new Paragraph("Hello World!"));
                //oDoc.Close();

                //Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                int count = 0;
                bool flg = false;
                string IdPagadoraOld = string.Empty;
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells["FlgEnviar"].Value.ToString().Equals("1"))
                    {
                        count++;
                        if (count == 1)
                        {
                            IdPagadoraOld = row.Cells["IdPagadora"].Value.ToString().Trim();
                            //Instanciando un nuevo documento
                            strHTMLContent = new StringBuilder();
                            strHTMLContent.Append("<html>");
                            strHTMLContent.Append("<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>");
                            strHTMLContent.Append("<body>");
                            flg = true;

                        }

                        if (IdPagadoraOld != row.Cells["IdPagadora"].Value.ToString().Trim())
                        {

                            strHTMLContent.Append("</body></html>");
                            string strPath = "d:\\" + IdPagadoraOld + ".doc";
                            FileStream fStream = File.Create(strPath);
                            fStream.Close();
                            fStream = null;
                            //fStream.Dispose();

                            StreamWriter sWriter = new StreamWriter(strPath);
                            sWriter.Write(strHTMLContent);
                            sWriter.Close();
                            wordDocument = appWord.Documents.Open(@"D:\" + IdPagadoraOld + ".doc");
                            wordDocument.ExportAsFixedFormat(@"D:\" + IdPagadoraOld + ".pdf", WdExportFormat.wdExportFormatPDF);
                            wordDocument.Close(SaveChanges = false);
                            //appWord.Documents.Close();
                            //appWord = null;
                            //appWord = new Microsoft.Office.Interop.Word.Application();

                            flg = false;

                            //Instanciando un nuevo documento
                            strHTMLContent = new StringBuilder();
                            strHTMLContent.Append("<html>");
                            strHTMLContent.Append("<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>");
                            strHTMLContent.Append("<body>");
                        }

                        int CountRow = 0;
                        while (CountRow < 2)
                        {
                            string dir0 = row.Cells["DireccionSocio"].Value.ToString().Trim();
                            string dir1 = "";
                            string dir2 = "";
                            string dir3 = "";

                            string strFechaVenc = string.IsNullOrEmpty(row.Cells["sdVencimiento"].Value.ToString()) ? "" : Convert.ToDateTime(row.Cells["sdVencimiento"].Value.ToString().Trim()).ToString("d");

                            //if (dir0.Length > 60)
                            //{
                            //    dir1 = dir0.Substring(0, 60);
                            //    dir2 = dir0.Substring(60, dir0.Length-61);
                            //    dir3 = row.Cells["Distrito"].Value.ToString().Trim();
                            //}
                            //else
                            //{
                                dir1 = dir0;
                                dir2 = row.Cells["Distrito"].Value.ToString().Trim();
                                dir3 = "";
                            //}

                            flg = true;
                            strHTMLContent.Append("<table width='100%' style='font-size: 11px;' border='0' cellpadding='0' cellspacing='0'><tr><td width='48%'>");
                            strHTMLContent.Append("<div><img src='J:\\Imagen\\logoEfide2.jpg' style='width:100px;height:30px;'></div>");
                            //strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div></div>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div>Señores</div>");
                            //strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div>" + row.Cells["IdPagadora_Dsc"].Value.ToString().Trim()   + "</div>");
                            strHTMLContent.Append("<div>" + dir1 + "</div>");
                            strHTMLContent.Append("<div>" + dir2 + "</div>");
                            strHTMLContent.Append("<div>" + dir3 + "</div>");

                            //strHTMLContent.Append("<div>" + row.Cells["DireccionSocio"].Value.ToString().Trim().Substring(51) + "</div>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div><b>Documento:</b></div>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div style='text-align:center'><b>" + row.Cells["cNumDoc"].Value.ToString().Trim() + " (LOTE - " + row.Cells["IdLote"].Value.ToString().Trim() + ")</b></div>");
                            strHTMLContent.Append("<div><b>Doc. Ident. Aceptante:</b> " + row.Cells["RucAceptante"].Value.ToString().Trim() + "</div>");
                            //strHTMLContent.Append("<div><b>Importe:</b> " + row.Cells["IdMoneda_tt_Dsc"].Value.ToString().Trim() + " " + (Convert.ToDecimal(row.Cells["nvNegociable"].Value) + Convert.ToDecimal(row.Cells["nFondoGarantia"].Value)).ToString("N2").Trim() + "</div>"); -- Comentado 20190314, ya viene incluido el fondo garantia desde el query
                            strHTMLContent.Append("<div><b>Importe:</b> " + row.Cells["IdMoneda_tt_Dsc"].Value.ToString().Trim() + " " + (Convert.ToDecimal(row.Cells["nvNegociableInteres"].Value)).ToString("N2").Trim() + "</div>");
                            strHTMLContent.Append("<div><b>Fecha de Vencimiento:</b> " + strFechaVenc + "</div>");
                            strHTMLContent.Append("<div><b>Girador:</b> " + row.Cells["IdSocio_Dsc"].Value.ToString().Trim() + "</div>");
                            strHTMLContent.Append("<div><b>Tipo de Cartera:</b> " + row.Cells["TipoCartera"].Value.ToString().Trim() + "</div>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div style='text-align:center'>CESION DOCUMENTARIA</div>");
                            strHTMLContent.Append("<br>");
                            strHTMLContent.Append("<div>Oficina: Av. El Derby N°254 Of.1106 - Santiago de Surco</div>");
                            strHTMLContent.Append("<div>Atención: L-V 8:30 a 5:00 p.m. Horario Corrido</div>");
                            strHTMLContent.Append("<div>Central Telefónica: 208-5900</div>");
                            strHTMLContent.Append("<div>Email: jcobranzas@efide.com.pe joperaciones@efide.com.pe</div>");
                            strHTMLContent.Append("</td>");
                            strHTMLContent.Append("<td width='4%'>");
                            strHTMLContent.Append("</td>");
                            strHTMLContent.Append("<td width='48%'>");
                            strHTMLContent.Append("<div style='text-align:center'>AVISO DE VENCIMIENTO</div>");
                            strHTMLContent.Append("<div>");
                            strHTMLContent.Append("<table width='100%' style='font-size: 9px;' border='1' cellpadding='0' cellspacing='0' bordercolor='#000000'>");
                            strHTMLContent.Append("<tr><td colspan='4' align='center'> <b>MONTO ESTIMADO A PAGAR DESPUES DEL VENCIMIENTO </b></td></tr>");
                            strHTMLContent.Append("<tr align='center'><td><b>DIA</b></td><td><b>FECHA VTO.</b></td><td><b>ABONOS/TRANF</b></td><td><b>CON CHEQUE</b></td></tr>");

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

         
                            int ifilas = 0;
                            foreach (DataRow item in ds.Tables[0].Rows)
                            {
                                strHTMLContent.Append("<tr><td align='center'>" + item["Dia"].ToString() + "</td><td align='center'>" + item["FechaVencimiento"].ToString() + "</td><td align='right'>" + Convert.ToDecimal(item["Abono"]).ToString("N2") + "</td><td align='right'>" + Convert.ToDecimal(item["AbonoCheque"]).ToString("N2") + "</td></tr>");
                                ifilas = ifilas + 1;
                            }

                            for (int i = 1; i <= (9-ifilas) ; i++)
                            {
                                strHTMLContent.Append("<tr><td align='center'> &nbsp" + "</td><td align='center'> &nbsp" + "</td><td align='right'> &nbsp" + "</td><td align='right'> &nbsp" + "</td></tr>");
                            }

                            strHTMLContent.Append("</table>");
                            strHTMLContent.Append("</div>");

                            strHTMLContent.Append("<div>- El pago después de la fecha de vencimiento considerará los gastos notariales e intereses y las tasas estarán sujetas a variación.</div>");
                            strHTMLContent.Append("<div>- De acuerdo a lo establecido en el artículo 1257 del Código Civil, los pagos efectuados después de su vencimiento, se aplicarán: 1° A los gastos, 2° A los intereses pactados y 3° al capital.</div>");
                            strHTMLContent.Append("<div>- Prodrá cancelarlo en bancos:</div>");

                            if (row.Cells["IdMoneda_tt_Dsc"].Value.ToString().Trim().Equals("S/.")) //Soles
                            { 
                                strHTMLContent.Append("<div style='text-align:center'><b>BCP CTA.CTE. S/. 193-1461392-0-34</b></div>");
                                strHTMLContent.Append("<div style='text-align:center'><b>Scotiabank CTA.CTE. S/. 000-8245959</b></div>");
                            }
                            else //Dolares
                            {
                                strHTMLContent.Append("<div style='text-align:center'><b>BCP CTA.CTE. US$ 193-1471927-1-57</b></div>");
                                strHTMLContent.Append("<div style='text-align:center'><b>Scotiabank CTA.CTE. US$ 000-3730219</b></div>");
                            }
                            
                            strHTMLContent.Append("<div>- Luego de efectuar el abono/tranf debe enviar la boleta via email.</div>");
                            strHTMLContent.Append("<div>- La letra de cambio pasará a protesto al 6to día de su vencimiento.</div>");
                            strHTMLContent.Append("</td>");
                            strHTMLContent.Append("</tr>");
                            strHTMLContent.Append("<br><br><br><br><br> <br><br>");
                            strHTMLContent.Append("</table>");
                             
                            CountRow++;
                        }
                    
                    IdPagadoraOld = row.Cells["IdPagadora"].Value.ToString().Trim();



                    //strHTMLContent.Append("</body></html>");
                    //string strPath = "d:\\" + IdPagadoraOld + ".doc";
                    //FileStream fStream = File.Create(strPath);
                    //fStream.Close();
                    //fStream = null;
                    ////fStream.Dispose();
                    
                    //StreamWriter sWriter = new StreamWriter(strPath);
                    //sWriter.Write(strHTMLContent);
                    //sWriter.Close();
                    //wordDocument = appWord.Documents.Open(@"D:\" + IdPagadoraOld + ".doc");
                    //wordDocument.ExportAsFixedFormat(@"D:\" + IdPagadoraOld + ".pdf", WdExportFormat.wdExportFormatPDF);
                    //appWord.Documents.Close();
                    //appWord = null;
                    //appWord = new Microsoft.Office.Interop.Word.Application();

                   }
                }

                //appWord.Documents.Close();

                if (flg == true)
                {

                    strHTMLContent.Append("</body></html>");
                    string strPath = "d:\\" + IdPagadoraOld + ".doc";
                    FileStream fStream = File.Create(strPath);
                    fStream.Close();
                    fStream = null;
                    //fStream.Dispose();

                    StreamWriter sWriter = new StreamWriter(strPath);
                    sWriter.Write(strHTMLContent);
                    sWriter.Close();
                    wordDocument = appWord.Documents.Open(@"D:\" + IdPagadoraOld + ".doc");
                    wordDocument.ExportAsFixedFormat(@"D:\" + IdPagadoraOld + ".pdf",WdExportFormat.wdExportFormatPDF);
   
                    //appWord.Documents.Close(SaveChanges=false);

                    wordDocument.Close(SaveChanges = false);
                    //appWord.Quit(SaveChanges = false);
                    //appWord = null;
                    //appWord = new Word.Application();
                }




                //foreach (Word.Document Doc in appWord.Documents)
                //{
                //    Doc.Close(SaveChanges = false);
                //}

                    //appWord.Documents.Close(SaveChanges=false);
        appWord.Quit(SaveChanges = false);
        appWord = null;



                if (appWord != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(appWord);
                appWord = null;
                GC.Collect(); 

                MessageBox.Show("Se grabo en d:/DocTo.pdf");

                //ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.FileName = "winword.EXE";
                //startInfo.Arguments = "d:\\doc1.doc";
                //Process.Start(startInfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try //Definitivo
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

                    //if (dgvDatos.CurrentRow.Cells["FlgEnviar"].Value.ToString().Equals("1"))
                    //{
                    //    dgvDatos.Sort(dgvDatos.Columns["IdPagadora_Dsc"], ListSortDirection.Ascending);
                    //    dgvDatos.Refresh();
                    //}
                    //else
                    //{
                    //    dgvDatos.Sort(dgvDatos.Columns["sdVencimiento"], ListSortDirection.Ascending);
                    //    dgvDatos.Refresh();
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool SaveChanges { get; set; }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            try
            {
                General.msgHelper.Wait("Procesando, espere un momento ...");
                string IdPagadoraOld = string.Empty;
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("IdPagadora");
                dt.Columns.Add("IdLote");
                dt.Columns.Add("cItem");
                dt.Columns.Add("Pagadora");
                string IdPagadora_Old = string.Empty;
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells["FlgEnviar"].Value.ToString().Equals("1"))
                    {
                        DataRow dr = dt.NewRow();
                        dr["IdPagadora"] = row.Cells["IdPagadora"].Value;
                        dr["IdLote"] = row.Cells["IdLote"].Value;
                        dr["cItem"] = row.Cells["cItem"].Value;
                        dr["Pagadora"] = row.Cells["IdPagadora_Dsc"].Value;
                        dt.Rows.Add(dr);
                    }
                }

                DataView View = new DataView(dt);
                System.Data.DataTable dtDistinctPagadoras = View.ToTable(true, "IdPagadora", "Pagadora");

                string StrDocumento = string.Empty;
                System.Data.DataTable dtDocumentos = new System.Data.DataTable();
                foreach (DataRow dr in dtDistinctPagadoras.Rows)
                {
                    DataRow[] drDocumentos = dt.Select("IdPagadora = '" + dr["IdPagadora"].ToString() + "'");

                    foreach (DataRow item in drDocumentos)
                    {
                        StrDocumento = StrDocumento + item[1].ToString().Trim() + "_" + item[2].ToString().Trim() + "&";
                    }

                    DataSet dsDatos = new DataSet();
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("dbo.Rpt_AvisoVencTituloValor", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Opcion", 1);
                        cmd1.Parameters.AddWithValue("@IdPagadora", dr["IdPagadora"].ToString());
                        cmd1.Parameters.AddWithValue("@StrDocumento", StrDocumento);
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsDatos, "dtVencTituloValor");
                        con.Close();
                    }

                    Crystal.crRptVencTituloValor oRpt = new Crystal.crRptVencTituloValor();
                    oRpt.SetDataSource(dsDatos);
                    oRpt.SetParameterValue("Pagadora", dr["Pagadora"].ToString());
                    oRpt.ExportToDisk(ExportFormatType.PortableDocFormat, "D:\\" + dr["IdPagadora"].ToString().Trim() + ".pdf");
                    StrDocumento = string.Empty;
                }
                General.msgHelper.Wait();
                MessageBox.Show("Se generaron los archivos correctamente en el disco D:\\", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                General.msgHelper.Wait();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}