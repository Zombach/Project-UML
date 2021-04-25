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

            RectangleWidth = WidthOfRectangle(graphics, RectangleText, font) + 5;
            
            RectNameHeight = CounterOfTextLinesInSpecificRectangle(RectangleText[0]) * font.Height;

            if (RectNameHeight < 25)
            {
                RectNameHeight = 25;
            }

            RectFieldHeight = CounterOfTextLinesInSpecificRectangle(RectangleText[1]) * font.Height;

            if (RectFieldHeight < 25)
            {
                RectFieldHeight = 25;
            }

            RectPropertyHeight = CounterOfTextLinesInSpecificRectangle(RectangleText[2]) * font.Height;

            if (RectPropertyHeight < 25)
            {
                RectPropertyHeight = 25;
            }

            RectMethodsHeight = CounterOfTextLinesInSpecificRectangle(RectangleText[3]) * font.Height;

            if (RectMethodsHeight < 50)
            {
                RectMethodsHeight = 50;
            }

            RectangleHeight = RectNameHeight + RectFieldHeight + RectPropertyHeight + RectMethodsHeight;

            RectangleF rectName = new RectangleF(Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);
            RectangleF rectField = new RectangleF(Points[0].X, Points[0].Y + RectNameHeight, RectangleWidth, RectFieldHeight);
            RectangleF rectProperty = new RectangleF(Points[0].X, Points[0].Y + RectNameHeight + RectFieldHeight, RectangleWidth, RectPropertyHeight);            
            RectangleF rectMethods = new RectangleF(Points[0].X, Points[0].Y + RectNameHeight + RectFieldHeight + RectPropertyHeight, RectangleWidth, RectMethodsHeight);


            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);
            
            DrawSpecificRectangle(graphics, RectangleText[0], _pen, font, brush, rectName);
            DrawSpecificRectangle(graphics, RectangleText[1], _pen, font, brush, rectField);
            DrawSpecificRectangle(graphics, RectangleText[2], _pen, font, brush, rectProperty);
            DrawSpecificRectangle(graphics, RectangleText[3], _pen, font, brush, rectMethods);
        }

        
    }
}
