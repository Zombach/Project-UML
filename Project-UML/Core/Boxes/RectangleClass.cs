using Project_UML.Core.DataProject.Structure;
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
        public RectangleClass(Color color, int width) : base(color, width)
        {            
        }
        public RectangleClass(StructBox box) : base(box)
        {
        }


        public override void Draw(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectangleHeight);
            graphics.DrawString("Class", font, brush, Points[0].X + 5, Points[0].Y + 5);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + RectNameHeight, RectangleWidth, RectFieldHeight);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + RectNameHeight + RectFieldHeight, RectangleWidth, RectPropertyHeight);
            RectMethodsHeight = RectangleHeight - (RectNameHeight + RectFieldHeight + RectPropertyHeight);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y + RectNameHeight + RectFieldHeight + RectPropertyHeight, RectangleWidth, RectMethodsHeight);
        }
    }
}
