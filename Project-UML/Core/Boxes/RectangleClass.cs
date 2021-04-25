using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.Boxes
{
    class RectangleClass : AbstractBox
    {
        public RectangleClass(Color color, int width) : base(color, width)
        {            
        }
        public RectangleClass(StructBox box) : base(box)
        {
        }

        public RectangleClass(IFigure figure) : base(figure)
        {
        }


        public override void Draw(Graphics graphics)
        {
            
            SolidBrush brush = new SolidBrush(Color.Black);

            SizeF stringSize = new SizeF();
            stringSize = graphics.MeasureString(RectangleText[0], font);
            RectNameHeight = font.Height;

            while (stringSize.Width > RectangleWidth)
            {
                RectNameHeight += font.Height;
                stringSize.Width -= RectangleWidth;
            }
            RectNameHeight += font.Height;

            RectangleF rectName = new RectangleF(Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);
            RectangleF rectField = new RectangleF(Points[0].X, Points[0].Y + RectNameHeight, RectangleWidth, RectFieldHeight);
            RectangleF rectProperty = new RectangleF(Points[0].X, Points[0].Y + RectNameHeight + RectFieldHeight, RectangleWidth, RectPropertyHeight);
            RectMethodsHeight = RectangleHeight - (RectNameHeight + RectFieldHeight + RectPropertyHeight);
            RectangleF rectMethods = new RectangleF(Points[0].X, Points[0].Y + RectNameHeight + RectFieldHeight + RectPropertyHeight, RectangleWidth, RectMethodsHeight);


            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);

            graphics.DrawString(RectangleText[0], font, brush, rectName);
            graphics.DrawRectangle(_pen, Rectangle.Round(rectName));

            graphics.DrawString(RectangleText[1], font, brush, rectField);
            graphics.DrawRectangle(_pen, Rectangle.Round(rectField));

            graphics.DrawString(RectangleText[2], font, brush, rectProperty);
            graphics.DrawRectangle(_pen, Rectangle.Round(rectProperty));

            graphics.DrawString(RectangleText[3], font, brush, rectMethods);
            graphics.DrawRectangle(_pen, Rectangle.Round(rectMethods));
        }
    }
}
