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
    public class BestRectangles : AbstractBox
    {


        public BestRectangles(int X, int Y)
        {
            StartPoint_X = X;
            StartPoint_Y = Y;
            _pen = new Pen(Color.Blue, 6);
            RectangleWidth = 100;
            RectangleHeight = 150;
        }
        public BestRectangles(Color color, int width)
        {
            StartPoint_X = 0;
            StartPoint_Y = 0;
            _pen = new Pen(color, width);
            RectangleWidth = 100;
            RectangleHeight = 150;
        }
        
        
        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, StartPoint_X, StartPoint_Y, RectangleWidth, RectangleHeight);
        }


    }
}
