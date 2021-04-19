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
    public class BestRectangles : AbstractBox
    {
        public BestRectangles(Color color, int width)
        {
            _pen = new Pen(color, width);
        }


        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectangleHeight);
        }
    }
}
