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
    public class RectangleObject : AbstractBox
    {
        public RectangleObject(Color color, int width) : base(color, width)
        {
            RectangleHeight = 50;
        }

        public RectangleObject(StructBox box) : base(box)
        {
        }
        public RectangleObject(IFigure figure) : base(figure)
        {
        }


        public override void Draw(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            RectangleWidth = WidthOfRectangle(graphics, RectangleText, Font) + 5;

            RectNameHeight = CounterOfTextLinesInSpecificRectangle(RectangleText[0]) * Font.Height;

            if (RectNameHeight < 50)
            {
                RectNameHeight = 50;
            }



            RectangleHeight = RectNameHeight;

            UpdatePoints();

            RectangleF rectName = new RectangleF(Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);

            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);

            DrawSpecificRectangle(graphics, RectangleText[0], _pen, Font, brush, rectName);
        }        
    }
}
