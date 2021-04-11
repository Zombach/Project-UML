using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML._Core._Arrows
{
    public class AggregationArrow : AbstractArrow
    {
        public AggregationArrow()
        {
            _pen = new Pen(Color.Black, 1);
            SetEndCap();
        }
        public AggregationArrow(Color color, int width)
        {
            _pen = new Pen(color, width);
            SetEndCap();
        }
        public AggregationArrow(Point startPoint, Point endPoint, Axises startDirectionAxis, Axises endDirectionAxis)
        {
            _pen = new Pen(Color.Black, 1);
            Points = GetPoints(startPoint, endPoint);
            StartDirectionAxis = startDirectionAxis;
            EndDirectionAxis = endDirectionAxis;
            SetEndCap();
        }

        private void SetEndCap()
        {
            GraphicsPath _graphicsPath = new GraphicsPath();
            _graphicsPath.AddLine(new Point(0, 0), new Point(8, -12));
            _graphicsPath.AddLine(new Point(8, -12), new Point(0, -24));
            _graphicsPath.AddLine(new Point(0, -24), new Point(-8, -12));
            _graphicsPath.AddLine(new Point(-8, -12), new Point(0, 0));            
            _pen.CustomEndCap = new CustomLineCap(null, _graphicsPath, LineCap.Custom, 24);
        }
    }
}
