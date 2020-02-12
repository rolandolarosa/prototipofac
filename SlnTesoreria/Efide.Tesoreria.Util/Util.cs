using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Efide.ControlsComponent;

namespace Efide.Tesoreria.Util
{
    public class Util
    {
        //set loading
        public static void SetLoading(Control owner, ucLoadingBar loading, bool displayLoader, Control btn = null)
        {
            if (displayLoader)
            {
                owner.Invoke((MethodInvoker)delegate
                {
                    loading.Visible = true;
                    if(btn != null)
                        btn.Visible = false;
                    owner.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                });
            }
            else
            {
                owner.Invoke((MethodInvoker)delegate
                {
                    loading.Visible = false;
                    if (btn != null)
                        btn.Visible = true;
                    owner.Cursor = System.Windows.Forms.Cursors.Default;
                });
            }
        }
    }
}
