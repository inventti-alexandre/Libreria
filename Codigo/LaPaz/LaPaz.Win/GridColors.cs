using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace LaPaz.Win
{
    public static class GridColors
    {
        public static Color TituloConsignado = Color.LimeGreen;

        public static void MarcarComoConsignado(this GridRowElement row)
        {
            row.DrawFill = true;
            row.GradientStyle = GradientStyles.Solid;
            row.BackColor = GridColors.TituloConsignado;
        }
    }
}
