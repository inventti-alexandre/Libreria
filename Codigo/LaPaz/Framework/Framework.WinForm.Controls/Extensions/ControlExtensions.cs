using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace Framework.WinForm.Controls.Extensions
{
    public static class ControlExtensions
    {
        public static void ToggleEnableDisabled(this RadButton radButton,bool isEnable)
        {
            radButton.Enabled = isEnable;
            radButton.ButtonElement.ButtonFillElement.Opacity = isEnable ? 1 : 0.3;
        }
    }
}
