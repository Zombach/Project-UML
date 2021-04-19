using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Boxes
{
    /// <summary>
    /// 
    /// </summary>
    public class RectangleObject : AbstractBox
    {
        public RectangleObject(Color color, int width)
        {
            _pen = new Pen(color, width);
        }


        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectangleHeight);            
        }

        public void DrawClass(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectangleHeight);
            graphics.DrawString("Object", font, brush, Points[0].X + 5, Points[0].Y + 5);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, _rectNameHeight);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + _rectNameHeight, RectangleWidth, _rectFieldHeight);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + _rectNameHeight + _rectFieldHeight, RectangleWidth, _rectPropertyHeight);
            _rectMethodsHeight = RectangleHeight - (_rectNameHeight + _rectFieldHeight + _rectPropertyHeight);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + _rectNameHeight + _rectFieldHeight + _rectPropertyHeight, RectangleWidth, _rectMethodsHeight);
        }
    }
}
