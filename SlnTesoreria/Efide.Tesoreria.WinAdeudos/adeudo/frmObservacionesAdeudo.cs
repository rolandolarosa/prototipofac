using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Efide.Tesoreria.Util;
using Efide.Tesoreria.WinAdeudos.frmBase;

namespace Efide.Tesoreria.WinAdeudos.adeudo
{
    public partial class frmObservacionesAdeudo : frmRegistroBase
    {
        public frmObservacionesAdeudo()
        {
            InitializeComponent();
        }

        public string contenido { get; set; }
        public string id { get; set; }
        public GetEnum.Eventos Evento { get; set; }
        public string frmParentName { get; set; }

        private void configButon(GetEnum.Eventos evento)
        {
            this.Invoke((MethodInvoker)delegate
            {
                foreach (ButtonItem item in toolBar.Items)
                {
                    if (item.GetType().Name == "ButtonItem")
                        item.Visible = false;
                }
                switch (evento)
                {
                    case GetEnum.Eventos.view:
                        btnSalir.Visible = true;
                        break;
                    case GetEnum.Eventos.insert:
                        btnGuardar.Visible = true;
                        btnLimpiar.Visible = true;
                        btnSalir.Visible = true;
                        break;
                    case GetEnum.Eventos.edit:
                        btnGuardar.Visible = true;
                        btnCancelar.Visible = true;
                        break;
                    case GetEnum.Eventos.delete:
                        break;
                    default:
                        break;
                }
            });
        }

        private void frmObservacionesAdeudo_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(contenido))
                    txtObservaciones.Text = contenido;

                configButon(Evento);
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar observaciones - Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al guardar observaciones - Error: " + ex.Message);
            }
        }
    }
}