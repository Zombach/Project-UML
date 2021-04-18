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
            AddPoints(X, Y);
            X += RectangleWidth;
            AddPoints(X, Y);
            Y += RectangleHeight;
            AddPoints(X, Y);
            X -= RectangleWidth;
            AddPoints(X, Y);                      

            _pen = new Pen(Color.Blue, 6);
        }

        private void AddPoints(int X, int Y)
        {
            Point point = new Point(X, Y);
            PointsBox.Add(point);
        }
        
        
        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, PointsBox[0].X, PointsBox[0].Y, RectangleWidth, RectangleHeight);
        }
    }
}
