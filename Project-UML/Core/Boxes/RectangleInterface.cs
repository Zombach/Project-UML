﻿using Project_UML.Core.DataProject.Structure;
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
            RectangleF rectField = new RectangleF(Points[0].X, Points[0].Y + RectNameHeight, RectangleWidth, RectangleHeight - RectNameHeight);


            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectNameHeight);

            graphics.DrawString(RectangleText[0], font, brush, rectName);
            graphics.DrawRectangle(_pen, Rectangle.Round(rectName));

            graphics.DrawString(RectangleText[1], font, brush, rectField);
            graphics.DrawRectangle(_pen, Rectangle.Round(rectField));
        }
    }
}
