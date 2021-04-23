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
            string text1 = "Class1 Class2 Class3 Class4 Class5 Class6";
            SolidBrush brush = new SolidBrush(Color.Black);

            SizeF stringSize = new SizeF();
            stringSize = graphics.MeasureString(text1, font);
            RectNameHeight = font.Height;

            while (stringSize.Width > RectangleWidth)
            {
                RectNameHeight += font.Height;
                stringSize.Width -= RectangleWidth;
            }
            RectNameHeight += font.Height;

            RectangleF rectF1 = new RectangleF(Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);

            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);
            graphics.DrawString(text1, font, brush, rectF1);
            graphics.DrawRectangle(_pen, Rectangle.Round(rectF1));
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + RectNameHeight, RectangleWidth, RectFieldHeight);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + RectNameHeight + RectFieldHeight, RectangleWidth, RectPropertyHeight);
            RectMethodsHeight = RectangleHeight - (RectNameHeight + RectFieldHeight + RectPropertyHeight);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + RectNameHeight + RectFieldHeight + RectPropertyHeight, RectangleWidth, RectMethodsHeight);
        }
    }
}
