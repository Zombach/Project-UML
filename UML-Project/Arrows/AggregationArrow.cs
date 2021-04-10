using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Project.Arrows
{
    public class AggregationArrow : AbstractArrow
    {
        public AggregationArrow()
        {
            _pen = new Pen(Color.Black, 2);
            SetEndCap();
        }
        public AggregationArrow(Point startPoint, Point endPoint, Axises startDirectionAxis, Axises endDirectionAxis)
        {
            _pen = new Pen(Color.Black, 2);
            Points = GetPoints(startPoint, endPoint);
            StartDirectionAxis = startDirectionAxis;
            EndDirectionAxis = endDirectionAxis;
            SetEndCap();
        }

        private void SetEndCap()
        {
            GraphicsPath _graphicsPath = new GraphicsPath();
            _graphicsPath.AddLine(new Point(0, 0), new Point((int)(_pen.Width * 4), -(int)_pen.Width * 6));
            _graphicsPath.AddLine(new Point((int)(_pen.Width * 4), -(int)_pen.Width * 6), new Point(0, -(int)_pen.Width * 12));
            _graphicsPath.AddLine(new Point(0, -(int)_pen.Width * 12), new Point(-(int)(_pen.Width * 4), -(int)_pen.Width * 6));
            _graphicsPath.AddLine(new Point(-(int)(_pen.Width * 4), -(int)_pen.Width * 6), new Point(0, 0));
            
            _pen.CustomEndCap = new CustomLineCap(null, _graphicsPath, LineCap.Custom, 24);
        }
    }
}
