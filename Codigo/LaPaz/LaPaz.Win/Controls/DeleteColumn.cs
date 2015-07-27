using LaPaz.Win.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPaz.Win.Controls
{
    public class DeleteCell : DataGridViewButtonCell
    {
        private Image _deleteImage = Resources.Garbage_Closed;

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            var buttonRectangle = new Rectangle(cellBounds.X + 2, cellBounds.Y + 2, cellBounds.Width - 4, cellBounds.Height - 4);
            base.Paint(graphics, clipBounds, buttonRectangle, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            var imageRectangle = new Rectangle(cellBounds.X + 6, cellBounds.Y + 6, _deleteImage.Width, _deleteImage.Height);
            graphics.DrawImage(_deleteImage, imageRectangle);
        }

        public class DeleteColumn : DataGridViewButtonColumn
        {
            public DeleteColumn()
            {
                this.CellTemplate = new DeleteCell();
                this.Width = 30;
            }
        }
    }
}
