using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace Efide.Tesoreria.Util
{
    public class Validation
    {
        public static bool ValidateRequired(Control contenedor, ErrorProvider errorProvider)
        {
            ToolTip tt;
            bool hasError = false;
            //errorProvider.Clear();
            CleanValidate(contenedor);

            foreach (Control ctrl in contenedor.Controls)
            {
                if ((ctrl.GetType().ToString() == "DevComponents.Editors.DateTimeAdv.DateTimeInput"))
                {
                    if (((DateTimeInput)ctrl).Tag != null && ((DateTimeInput)ctrl).Tag.ToString().Contains("Reqrired"))
                    {
                        if (((DateTimeInput)ctrl).Value == DateTime.MinValue)
                        {
                            //errorProvider.SetError((TextBoxX)ctrl, "El campo es obligatorio");

                            //tt = new ToolTip();
                            //tt.InitialDelay = 0;
                            //tt.IsBalloon = true;
                            //tt.Show(string.Empty, (TextBox)ctrl);
                            //tt.Show("I need help", (TextBox)ctrl);

                            ((DateTimeInput)ctrl).BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                            ((DateTimeInput)ctrl).BackgroundStyle.BorderBottomColor = System.Drawing.Color.Crimson;
                            ((DateTimeInput)ctrl).BackgroundStyle.BorderBottomWidth = 2;

                            //Borde toda la caja
                            //((DateTimeInput)ctrl).BackgroundStyle.Border = DevComponents.DotNetBar.eStyleBorderType.Solid;
                            //((DateTimeInput)ctrl).BackgroundStyle.BorderColor = System.Drawing.Color.Crimson;
                            //((DateTimeInput)ctrl).BackgroundStyle.BorderWidth = 2;

                            hasError = true;
                        }
                    }
                    if (((DateTimeInput)ctrl).Tag != null && ((DateTimeInput)ctrl).Tag.ToString().Contains("Fecha"))
                    {
                        if (!string.IsNullOrWhiteSpace(((DateTimeInput)ctrl).Text))
                        {
                            if (!Regex.IsMatch(Convert.ToString(((DateTimeInput)ctrl).Text), @"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$")) //@"^(?:3[01]|[12][0-9]|0?[1-9])([\-/.])(0?[1-9]|1[1-2])\1\d{4}$"))
                            {
                                //errorProvider.SetError((DateTimeInput)ctrl, "No tiene el formato correcto");

                                //((DateTimeInput)ctrl).BackgroundStyle.Border = DevComponents.DotNetBar.eStyleBorderType.Solid;
                                //((DateTimeInput)ctrl).BackgroundStyle.BorderColor = System.Drawing.Color.Crimson;
                                //((DateTimeInput)ctrl).BackgroundStyle.BorderWidth = 2;

                                ((DateTimeInput)ctrl).BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                                ((DateTimeInput)ctrl).BackgroundStyle.BorderBottomColor = System.Drawing.Color.Crimson;
                                ((DateTimeInput)ctrl).BackgroundStyle.BorderBottomWidth = 2;

                                hasError = true;
                            }
                        }
                    }
                }
                if ((ctrl.GetType().ToString() == "DevComponents.DotNetBar.Controls.TextBoxX"))
                {
                    if (((TextBoxX)ctrl).Tag != null && ((TextBoxX)ctrl).Tag.ToString().Contains("Reqrired"))
                    {
                        if (string.IsNullOrWhiteSpace(((TextBoxX)ctrl).Text))
                        {
                            //errorProvider.SetError((TextBoxX)ctrl, "El campo es obligatorio");

                            //tt = new ToolTip();
                            //tt.InitialDelay = 0;
                            //tt.IsBalloon = true;
                            //tt.Show(string.Empty, (TextBox)ctrl);
                            //tt.Show("I need help", (TextBox)ctrl);

                            //((TextBoxX)ctrl).Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                            //((TextBoxX)ctrl).Border.BorderBottomColor = System.Drawing.Color.Crimson;
                            //((TextBoxX)ctrl).Border.BorderBottomWidth = 2;

                            ((TextBoxX)ctrl).Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                            ((TextBoxX)ctrl).Border.BorderBottomColor = System.Drawing.Color.Crimson;
                            ((TextBoxX)ctrl).Border.BorderBottomWidth = 2;

                            hasError = true;
                        }
                    }
                    if (((TextBox)ctrl).Tag != null && ((TextBox)ctrl).Tag.ToString().Contains("LetrasNumero"))
                    {
                        if (!string.IsNullOrWhiteSpace(((TextBox)ctrl).Text))
                        {
                            if (!Regex.IsMatch(Convert.ToString(((TextBox)ctrl).Text), @"^([A-Za-zÑñáéíóúÁÉÍÓÚ,.0-9 ]+)$"))
                            {
                                //errorProvider.SetError((TextBox)ctrl, "Solo se permiten números y letras");
                                ((TextBoxX)ctrl).Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                                ((TextBoxX)ctrl).Border.BorderBottomColor = System.Drawing.Color.Crimson;
                                ((TextBoxX)ctrl).Border.BorderBottomWidth = 2;
                                hasError = true;
                            }
                        }
                    }
                    if (((TextBox)ctrl).Tag != null && ((TextBox)ctrl).Tag.ToString().Contains("Numeros"))
                    {
                        if (!string.IsNullOrWhiteSpace(((TextBox)ctrl).Text))
                        {
                            if (!Regex.IsMatch(Convert.ToString(((TextBox)ctrl).Text), @"^\d+$"))
                            {
                                //errorProvider.SetError((TextBox)ctrl, "Solo se permiten números");
                                ((TextBoxX)ctrl).Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                                ((TextBoxX)ctrl).Border.BorderBottomColor = System.Drawing.Color.Crimson;
                                ((TextBoxX)ctrl).Border.BorderBottomWidth = 2;
                                hasError = true;
                            }
                        }
                    }
                    if (((TextBox)ctrl).Tag != null && ((TextBox)ctrl).Tag.ToString().Contains("Decimales"))
                    {
                        if (!string.IsNullOrWhiteSpace(((TextBox)ctrl).Text))
                        {
                            if (!Regex.IsMatch(Convert.ToString(((TextBox)ctrl).Text), @"^[0-9]+(\.[0-9]{1,2})?$"))
                            {
                                //errorProvider.SetError((TextBox)ctrl, "Solo se permiten números y decimal (dos decimáles)");
                                ((TextBoxX)ctrl).Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                                ((TextBoxX)ctrl).Border.BorderBottomColor = System.Drawing.Color.Crimson;
                                ((TextBoxX)ctrl).Border.BorderBottomWidth = 2;
                                hasError = true;
                            }
                        }
                    }
                    if (((TextBox)ctrl).Tag != null && ((TextBox)ctrl).Tag.ToString().Contains("DecNegativos"))
                    {
                        if (!string.IsNullOrWhiteSpace(((TextBox)ctrl).Text))
                        {
                            if (!Regex.IsMatch(Convert.ToString(((TextBox)ctrl).Text), @"^-?[0-9]+(\,[0-9]{1,2})?$"))
                            {
                                //errorProvider.SetError((TextBox)ctrl, "Solo se permiten números y decimal (dos decimáles)");
                                ((TextBoxX)ctrl).Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                                ((TextBoxX)ctrl).Border.BorderBottomColor = System.Drawing.Color.Crimson;
                                ((TextBoxX)ctrl).Border.BorderBottomWidth = 2;
                                hasError = true;
                            }
                        }
                    }
                    if (((TextBox)ctrl).Tag != null && ((TextBox)ctrl).Tag.ToString().Contains("Correo"))
                    {
                        if (!string.IsNullOrWhiteSpace(((TextBox)ctrl).Text))
                        {
                            if (!Regex.IsMatch(Convert.ToString(((TextBox)ctrl).Text), @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                            {
                                //errorProvider.SetError((TextBox)ctrl, "No tiene el formato correcto");
                                ((TextBoxX)ctrl).Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                                ((TextBoxX)ctrl).Border.BorderBottomColor = System.Drawing.Color.Crimson;
                                ((TextBoxX)ctrl).Border.BorderBottomWidth = 2;
                                hasError = true;
                            }
                        }
                    }
                    if (((TextBox)ctrl).Tag != null && ((TextBox)ctrl).Tag.ToString().Contains("IP"))
                    {
                        if (!string.IsNullOrWhiteSpace(((TextBox)ctrl).Text))
                        {
                            if (!Regex.IsMatch(Convert.ToString(((TextBox)ctrl).Text), @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"))
                            {
                                //errorProvider.SetError((TextBox)ctrl, "No tiene el formato correcto");
                                ((TextBoxX)ctrl).Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                                ((TextBoxX)ctrl).Border.BorderBottomColor = System.Drawing.Color.Crimson;
                                ((TextBoxX)ctrl).Border.BorderBottomWidth = 2;
                                hasError = true;
                            }
                        }
                    }
                    if (((TextBox)ctrl).Tag != null && ((TextBox)ctrl).Tag.ToString().Contains("MAC"))
                    {
                        if (!string.IsNullOrWhiteSpace(((TextBox)ctrl).Text))
                        {
                            if (!Regex.IsMatch(Convert.ToString(((TextBox)ctrl).Text), @"^(([a-fA-F0-9]{2}-){5}[a-fA-F0-9]{2}|([a-fA-F0-9]{2}:){5}[a-fA-F0-9]{2}|([0-9A-Fa-f]{4}\.){2}[0-9A-Fa-f]{4})?$"))
                            {
                                //errorProvider.SetError((TextBox)ctrl, "No tiene el formato correcto");
                                ((TextBoxX)ctrl).Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                                ((TextBoxX)ctrl).Border.BorderBottomColor = System.Drawing.Color.Crimson;
                                ((TextBoxX)ctrl).Border.BorderBottomWidth = 2;
                                hasError = true;
                            }
                        }
                    }
                    if (((TextBox)ctrl).Tag != null && ((TextBox)ctrl).Tag.ToString().Contains("Fecha"))
                    {
                        if (!string.IsNullOrWhiteSpace(((TextBox)ctrl).Text))
                        {
                            if (!Regex.IsMatch(Convert.ToString(((TextBox)ctrl).Text), @"^(?:3[01]|[12][0-9]|0?[1-9])([\-/.])(0?[1-9]|1[1-2])\1\d{4}$"))
                            {
                                //errorProvider.SetError((TextBox)ctrl, "No tiene el formato correcto");
                                ((TextBoxX)ctrl).Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                                ((TextBoxX)ctrl).Border.BorderBottomColor = System.Drawing.Color.Crimson;
                                ((TextBoxX)ctrl).Border.BorderBottomWidth = 2;
                                hasError = true;
                            }
                        }
                    }
                }
            }

            return !hasError;
        }
    
        public static void CleanValidate(Control contenedor){
            foreach (Control ctrl in contenedor.Controls)
            {
                if ((ctrl.GetType().ToString() == "DevComponents.Editors.DateTimeAdv.DateTimeInput"))
                {
                    ((DateTimeInput)ctrl).BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.None;
                    ((DateTimeInput)ctrl).BackgroundStyle.BorderBottomColor = System.Drawing.Color.Transparent;
                    ((DateTimeInput)ctrl).BackgroundStyle.BorderBottomWidth = 1;
                }
                if ((ctrl.GetType().ToString() == "DevComponents.DotNetBar.Controls.TextBoxX"))
                {
                    ((TextBoxX)ctrl).Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.None;
                    ((TextBoxX)ctrl).Border.BorderBottomColor = System.Drawing.Color.Transparent;
                    ((TextBoxX)ctrl).Border.BorderBottomWidth = 1;
                }
            }
        }
    }
}
