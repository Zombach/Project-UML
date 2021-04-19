using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Boxes
{
    class RectangleClass : AbstractBox
    {
        public RectangleClass(Color color, int width)
        {
            _pen = new Pen(color, width);
        }


        public override void Draw(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectangleHeight);
            graphics.DrawString("Class", font, brush, Points[0].X + 5, Points[0].Y + 5);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, _rectNameHeight);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + _rectNameHeight, RectangleWidth, _rectFieldHeight);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + _rectNameHeight + _rectFieldHeight, RectangleWidth, _rectPropertyHeight);
            _rectMethodsHeight = RectangleHeight - (_rectNameHeight + _rectFieldHeight + _rectPropertyHeight);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + _rectNameHeight + _rectFieldHeight + _rectPropertyHeight, RectangleWidth, _rectMethodsHeight);
        }
    }
}
