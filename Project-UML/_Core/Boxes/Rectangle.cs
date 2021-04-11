using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Boxes
{
    public class Rectangle : AbstractBox
    {

        public Rectangle()
        {
            _pen = new Pen(Color.Black, 1);
            int widthFigure = 5;
            int heightFigure = 7;
        }

        public Rectangle(Point startPoint, Point endPoint, int width, int height)
        {
            _pen = new Pen(Color.Green, 4);
        }
        
    }
}
