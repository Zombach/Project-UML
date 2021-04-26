using Project_UML.Core.DataProject.Structure;
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
    [Serializable]
    public class RectangleInterface : AbstractBox
    {
        public RectangleInterface(Color color, int width) : base(color, width)
        {
        }

        public RectangleInterface(StructBox box) : base(box)
        {
        }

        public RectangleInterface(IFigure figure) : base(figure)
        {
        }

        public override void Draw(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            RectangleWidth = WidthOfRectangle(graphics, RectangleText, Font) + 5;

            RectNameHeight = CounterOfTextLinesInSpecificRectangle(RectangleText[0]) * Font.Height;

            if (RectNameHeight < 25)
            {
                RectNameHeight = 25;
            }

            RectFieldHeight = CounterOfTextLinesInSpecificRectangle(RectangleText[1]) * Font.Height;

            if (RectFieldHeight < 50)
            {
                RectFieldHeight = 50;
            }

            

            RectangleHeight = RectNameHeight + RectFieldHeight;

            RectangleF rectName = new RectangleF(Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);
            RectangleF rectField = new RectangleF(Points[0].X, Points[0].Y + RectNameHeight, RectangleWidth, RectFieldHeight);

            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);

            DrawSpecificRectangle(graphics, RectangleText[0], _pen, Font, brush, rectName);
            DrawSpecificRectangle(graphics, RectangleText[1], _pen, Font, brush, rectField);
        }
    }
}
