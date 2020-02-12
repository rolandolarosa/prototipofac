using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.Util
{
    public class Export
    {
        static string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\";
        static bool indHeader { get; set; }

        public static void ExportToExcelDataTable(DataTable dataTable, string ExcelFilePath = null, int anio = 0, string mes = "", string nombreReporte = "", string nombreHoja = "", int nroMes = 0)
        {
            try
            {
                int ColumnsCount;

                if (dataTable == null || (ColumnsCount = dataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();

                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;
                Worksheet.Name = nombreHoja;

                string dia = new DateTime(anio, nroMes, 1).AddMonths(1).AddDays(-1).Day.ToString();

                object[,] HeaderFixed = new object[4, 4];
                HeaderFixed[1, 0] = nombreReporte + " AL " + dia.ToString() + " " + mes + " " + anio;

                Microsoft.Office.Interop.Excel.Range HeaderRangeFixed = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[4, 4]));
                HeaderRangeFixed.Value = HeaderFixed;
                HeaderRangeFixed.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                //HeaderRangeFixed.Cells.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                HeaderRangeFixed.Font.Bold = true;
                HeaderRangeFixed.Cells.Font.Name = "Arial";
                HeaderRangeFixed.Cells.Font.Size = 10;
                //HeaderRangeFixed.Cells.Width = 17;

                object[] Header = new object[ColumnsCount];

                // column headings               
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = dataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[5, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[5, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                HeaderRange.Font.Bold = true;
                HeaderRange.Cells.Font.Name = "Arial";
                HeaderRange.Cells.Font.Size = 8;
                foreach (Microsoft.Office.Interop.Excel.Range cell in HeaderRange.Cells)
                {
                    cell.BorderAround2();
                }

                // DataCells
                int RowsCount = dataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = dataTable.Rows[j][i].ToString().Trim();

                Microsoft.Office.Interop.Excel.Range BodyRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[6, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 5, ColumnsCount]));
                BodyRange.Value = Cells;
                //BodyRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //BodyRange.Font.Bold = true;
                BodyRange.Cells.Font.Name = "Arial";
                BodyRange.Cells.Font.Size = 8;
                foreach (Microsoft.Office.Interop.Excel.Range cell in BodyRange.Cells)
                {
                    if ((cell.Column == 1 && cell.Text.ToString().Length <= 4) || 
                        (cell.Column == 1 && cell.Text.ToString() == "INGRESOS") || (cell.Column == 1 && cell.Text.ToString() == "EGRESOS") ||
                        (cell.Column == 2 && cell.Text.ToString() == "Total Ingresos") || (cell.Column == 2 && cell.Text.ToString() == "Total Egresos")
                    )
                    {
                        Microsoft.Office.Interop.Excel.Range BodyBold = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[cell.Row, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[cell.Row, ColumnsCount]));
                        BodyBold.Cells.Font.Bold = true;
                    }

                    if (cell.Column > 2)
                        cell.NumberFormat = "#,##0";

                    cell.BorderAround2();
                }

                Worksheet.Rows.RowHeight = 13;

                // check fielpath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        //Worksheet.SaveAs(AppSettings.RutaReporteFenacrep + ExcelFilePath);
                        Worksheet.SaveAs(path + ExcelFilePath);
                        Excel.Quit();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Archivo excel no se ha podido generar, Error: " + ex.Message);
                    }
                }
                else// no filepath is given
                {
                    Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }

        public static void ExportToExcel<T>(IList<T> data, string ExcelFilePath = null, int anio = 0, string mes = "", string nombreReporte = "", string nombreHoja = "")
        {
            try
            {
                DataTable dataTable = ConvertToDataTable(data);
                int ColumnsCount;

                if (dataTable == null || (ColumnsCount = dataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();

                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;
                Worksheet.Name = nombreHoja;

                object[,] HeaderFixed = new object[4, 4];
                HeaderFixed[0, 0] = "Institución"; HeaderFixed[0, 3] = "EFIDE";
                HeaderFixed[1, 0] = "Estado Financiero"; HeaderFixed[1, 3] = nombreReporte;
                HeaderFixed[2, 0] = "Año"; HeaderFixed[2, 3] = anio;
                HeaderFixed[3, 0] = "Mes"; HeaderFixed[3, 3] = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mes);

                Microsoft.Office.Interop.Excel.Range HeaderRangeFixed = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[4, 4]));
                HeaderRangeFixed.Value = HeaderFixed;
                HeaderRangeFixed.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                HeaderRangeFixed.Cells.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                HeaderRangeFixed.Font.Bold = true;
                HeaderRangeFixed.Cells.Font.Name = "Arial";
                HeaderRangeFixed.Cells.Font.Size = 10;
                //HeaderRangeFixed.Cells.Width = 17;

                object[] Header = new object[ColumnsCount];

                // column headings               
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = dataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[5, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[5, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                HeaderRange.Font.Bold = true;
                HeaderRange.Cells.Font.Name = "Arial";
                HeaderRange.Cells.Font.Size = 8;
                foreach (Microsoft.Office.Interop.Excel.Range cell in HeaderRange.Cells)
                {
                    cell.BorderAround2();
                }

                // DataCells
                int RowsCount = dataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = dataTable.Rows[j][i].ToString().Trim();

                Microsoft.Office.Interop.Excel.Range BodyRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[6, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 5, ColumnsCount]));
                BodyRange.Value = Cells;
                //BodyRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //BodyRange.Font.Bold = true;
                BodyRange.Cells.Font.Name = "Arial";
                BodyRange.Cells.Font.Size = 8;

                BodyRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                BodyRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

                //foreach (Microsoft.Office.Interop.Excel.Range cell in BodyRange.Cells)
                //{
                //    cell.BorderAround2();
                //}

                Worksheet.Rows.RowHeight = 13;

                // check fielpath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        Excel.Visible = true;
                        //Worksheet.SaveAs(path + ExcelFilePath);
                        //Excel.Quit();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Archivo excel no se ha podido generar, Error: " + ex.Message);
                    }
                }
                else// no filepath is given
                {
                    Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }

        public static void ExportToExcelCartera<T>(IList<T> data, string ExcelFilePath = null, int anio = 0, string mes = "", string nombreReporte = "", string nombreHoja = "")
        {
            try
            {
                DataTable dataTable = ConvertToDataTable(data);
                int ColumnsCount;

                if (dataTable == null || (ColumnsCount = dataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();

                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;
                Worksheet.Name = nombreHoja;

                object[,] HeaderFixed = new object[4, 4];
                HeaderFixed[0, 0] = "Institución"; HeaderFixed[0, 3] = "EFIDE";
                HeaderFixed[1, 0] = "Estado Financiero"; HeaderFixed[1, 3] = nombreReporte;
                HeaderFixed[2, 0] = "Año"; HeaderFixed[2, 3] = anio;
                HeaderFixed[3, 0] = "Mes"; HeaderFixed[3, 3] = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mes);

                Microsoft.Office.Interop.Excel.Range HeaderRangeFixed = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[4, 4]));
                HeaderRangeFixed.Value = HeaderFixed;
                HeaderRangeFixed.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                HeaderRangeFixed.Cells.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                HeaderRangeFixed.Font.Bold = true;
                HeaderRangeFixed.Cells.Font.Name = "Arial";
                HeaderRangeFixed.Cells.Font.Size = 10;
                //HeaderRangeFixed.Cells.Width = 17;

                object[] Header = new object[ColumnsCount];

                // column headings               
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = dataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[5, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[5, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                HeaderRange.Font.Bold = true;
                HeaderRange.Cells.Font.Name = "Arial";
                HeaderRange.Cells.Font.Size = 8;
                foreach (Microsoft.Office.Interop.Excel.Range cell in HeaderRange.Cells)
                {
                    cell.BorderAround2();
                }

                // DataCells
                int RowsCount = dataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                {
                    for (int i = 0; i < ColumnsCount; i++)
                    {
                        if (i == 6 || i == 7 || i == 11)
                        {
                            if (dataTable.Rows[j][i] != DBNull.Value)
                                Cells[j, i] = Convert.ToDouble(dataTable.Rows[j][i]).ToString("N");
                        }
                        else if (i == 9 || i == 10)
                        {
                            if (dataTable.Rows[j][i] != DBNull.Value)
                                Cells[j, i] = Convert.ToDateTime(dataTable.Rows[j][i]).ToString("dd/MM/yyyy");
                        }
                        else
                            Cells[j, i] = dataTable.Rows[j][i].ToString().Trim();
                    }
                }

                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[6, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 5, 1])).NumberFormat = "@";

                //importe
                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[6, 7]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 5, 8])).NumberFormat = "#,##0.00";

                //fecha
                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[6, 10]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 5, 11])).NumberFormat = "@";

                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[6, 12]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 5, 12])).NumberFormat = "#,##0.00";

                Microsoft.Office.Interop.Excel.Range BodyRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[6, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 5, ColumnsCount]));
                BodyRange.Value = Cells;
                //BodyRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //BodyRange.Font.Bold = true;
                BodyRange.Cells.Font.Name = "Arial";
                BodyRange.Cells.Font.Size = 8;

                BodyRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                BodyRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

                //foreach (Microsoft.Office.Interop.Excel.Range cell in BodyRange.Cells)
                //{
                //    cell.BorderAround2();
                //}

                Worksheet.Rows.RowHeight = 13;

                // check fielpath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        Excel.Visible = true;
                        //Worksheet.SaveAs(path + ExcelFilePath);
                        //Excel.Quit();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Archivo excel no se ha podido generar, Error: " + ex.Message);
                    }
                }
                else// no filepath is given
                {
                    Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }

        #region " Util Excel "
        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(
                    prop.Name
                        .Replace("Anio", "Año").Replace("Descripcion", "Descripción").Replace("Categoria", "Categoría").Replace("Denominacion", "Denominación")
                        .Replace("MontoNacional", "M. N.").Replace("MontoExtranjero", "M. E.").Replace("MontoIntegrado", "T. H.")
                        .Replace("_", " ").Replace("Porcentaje", "(%)").Replace("Soless", "(S/.)").Replace("Dolaress", "($/.)")
                        .Replace("Adquisicion", "Adquisición").Replace("Provision", "Provisión").Replace("Unidd", "(Unid.)").Replace("Intt", "Int.")
                        .Replace("Numero", "Número").Replace("Codigo", "Código").Replace("Desvalorizacion", "Desvalorización").Replace("Realizacion", "Realización")
                        .Replace("Credito", "Crédito").Replace("Interes", "Interés").Replace("Garantia", "Garantía").Replace("Calificacion", "Calificación").Replace("Especifica", "Específica")
                        .Replace("_", " ")
                    , Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name
                        .Replace("Anio", "Año").Replace("Descripcion", "Descripción").Replace("Categoria", "Categoría").Replace("Denominacion", "Denominación")
                        .Replace("MontoNacional", "M. N.").Replace("MontoExtranjero", "M. E.").Replace("MontoIntegrado", "T. H.")
                        .Replace("_", " ").Replace("Porcentaje", "(%)").Replace("Soless", "(S/.)").Replace("Dolaress", "($/.)")
                        .Replace("Adquisicion", "Adquisición").Replace("Provision", "Provisión").Replace("Unidd", "(Unid.)").Replace("Intt", "Int.")
                        .Replace("Numero", "Número").Replace("Codigo", "Código").Replace("Desvalorizacion", "Desvalorización").Replace("Realizacion", "Realización")
                        .Replace("Credito", "Crédito").Replace("Interes", "Interés").Replace("Garantia", "Garantía").Replace("Calificacion", "Calificación").Replace("Especifica", "Específica")
                        .Replace("_", " ")
                    ] = prop.GetValue(item) ?? DBNull.Value;

                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data, List<string> headers)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            string name;

            foreach (PropertyDescriptor prop in properties)
            {
                if (prop.Name != "Grupo")
                {
                    name = prop.Name
                        .Replace("Anio", "Año").Replace("Descripcion", "Descripción").Replace("Categoria", "Categoría").Replace("Denominacion", "Denominación")
                        .Replace("MontoNacional", "M. N.").Replace("MontoExtranjero", "M. E.").Replace("MontoIntegrado", "T. H.")
                        .Replace("_", " ").Replace("Porcentaje", "(%)").Replace("Soless", "(S/.)").Replace("Dolaress", "($/.)")
                        .Replace("Adquisicion", "Adquisición").Replace("Provision", "Provisión").Replace("Unidd", "(Unid.)").Replace("Intt", "Int.")
                        .Replace("Numero", "Número").Replace("Codigo", "Código").Replace("Desvalorizacion", "Desvalorización").Replace("Realizacion", "Realización")
                        .Replace("_", " ");

                    foreach (string header in headers)
                    {
                        if (prop.Name == header.Split(',')[0].Trim())
                            name = prop.Name.Replace(header.Split(',')[0].Trim(), header.Split(',')[1].Trim());
                    }

                    table.Columns.Add(name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    if (prop.Name != "Grupo")
                    {

                        name = prop.Name
                            .Replace("Anio", "Año").Replace("Descripcion", "Descripción").Replace("Categoria", "Categoría").Replace("Denominacion", "Denominación")
                            .Replace("MontoNacional", "M. N.").Replace("MontoExtranjero", "M. E.").Replace("MontoIntegrado", "T. H.")
                            .Replace("_", " ").Replace("Porcentaje", "(%)").Replace("Soless", "(S/.)").Replace("Dolaress", "($/.)")
                            .Replace("Adquisicion", "Adquisición").Replace("Provision", "Provisión").Replace("Unidd", "(Unid.)").Replace("Intt", "Int.")
                            .Replace("Numero", "Número").Replace("Codigo", "Código").Replace("Desvalorizacion", "Desvalorización").Replace("Realizacion", "Realización")
                            .Replace("_", " ");

                        foreach (string header in headers)
                        {
                            if (prop.Name == header.Split(',')[0].Trim())
                                name = prop.Name.Replace(header.Split(',')[0].Trim(), header.Split(',')[1].Trim());
                        }
                        row[name] = prop.GetValue(item) ?? DBNull.Value;
                    }
                }

                table.Rows.Add(row);
            }
            return table;

        }

        public static DataTable ConvertTo<T>(IList<T> list)
        {
            DataTable table = CreateTable<T>();
            Type entityType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (T item in list)
            {
                DataRow row = table.NewRow();

                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item);
                }

                table.Rows.Add(row);
            }

            return table;
        }

        public static IList<T> ConvertTo<T>(IList<DataRow> rows)
        {
            IList<T> list = null;

            if (rows != null)
            {
                list = new List<T>();

                foreach (DataRow row in rows)
                {
                    T item = CreateItem<T>(row);
                    list.Add(item);
                }
            }

            return list;
        }

        public static IList<T> ConvertTo<T>(DataTable table)
        {
            if (table == null)
            {
                return null;
            }

            List<DataRow> rows = new List<DataRow>();

            foreach (DataRow row in table.Rows)
            {
                rows.Add(row);
            }

            return ConvertTo<T>(rows);
        }

        public static T CreateItem<T>(DataRow row)
        {
            T obj = default(T);
            if (row != null)
            {
                obj = Activator.CreateInstance<T>();

                foreach (DataColumn column in row.Table.Columns)
                {
                    PropertyInfo prop = obj.GetType().GetProperty(column.ColumnName);
                    if (prop != null)
                    {
                        try
                        {
                            object value;
                            if (row[column.ColumnName] == DBNull.Value)
                                value = string.Empty;
                            else
                                value = row[column.ColumnName];
                            prop.SetValue(obj, value.ToString(), null);
                        }
                        catch
                        {
                            // You can log something here
                            throw;
                        }
                    }
                }
            }

            return obj;
        }

        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, prop.PropertyType);
            }

            return table;
        }

        /// <summary>
        /// Open specified excel document.
        /// </summary>
        public static void OpenFileMicrosoftExcel(string ExcelFilePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "EXCEL.EXE";
            //startInfo.Arguments = AppSettings.RutaReporteFenacrep + ExcelFilePath;
            startInfo.Arguments = path + ExcelFilePath;
            Process.Start(startInfo);
        }
        #endregion
    }
}
