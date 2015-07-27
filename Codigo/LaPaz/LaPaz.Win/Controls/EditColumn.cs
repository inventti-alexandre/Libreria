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
    public class EditCell : DataGridViewButtonCell
    {
        private Image _editImage = Resources.Data_Edit;

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            var buttonRectangle = new Rectangle(cellBounds.X + 2, cellBounds.Y + 2, cellBounds.Width - 4, cellBounds.Height - 4);
            base.Paint(graphics, clipBounds, buttonRectangle, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            var imageRectangle = new Rectangle(cellBounds.X + 6, cellBounds.Y + 6, _editImage.Width, _editImage.Height);
            graphics.DrawImage(_editImage, imageRectangle);
        }

        public class EditColumn : DataGridViewButtonColumn
        {
            public EditColumn()
            {
                this.CellTemplate = new EditCell();
                this.FlatStyle = FlatStyle.Flat;
                this.Width = 30;
            }
        }
    }
}
