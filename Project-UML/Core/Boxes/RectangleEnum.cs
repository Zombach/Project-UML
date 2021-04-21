using Project_UML.Core.DataProject.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Boxes
{
    class RectangleEnum : AbstractBox
    {     
        
        public RectangleEnum(Color color, int width) : base(color, width)
        {
        }

        public RectangleEnum(StructBox box) : base(box)
        {
        }

        public override void Draw(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectangleHeight);
            graphics.DrawString("enum", font, brush, Points[0].X + 5, Points[0].Y + 5);
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);
        }
    }
}
