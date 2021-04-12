using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Arrows
{
    public class ImplementationArrow : AbstractArrow
    {
        public ImplementationArrow()
        {
            _pen = new Pen(Color.Black, 1);
            SetEndCap();
        }

        public ImplementationArrow(Color color, int width)
        {
            _pen = new Pen(color, width);
            SetEndCap();
        }
        public ImplementationArrow(Point startPoint, Point endPoint, Axises startDirectionAxis, Axises endDirectionAxis)
        {
            _pen = new Pen(Color.Black, 1);
            Points = GetPoints(startPoint, endPoint);
            StartDirectionAxis = startDirectionAxis;
            EndDirectionAxis = endDirectionAxis;
            SetEndCap();
        }

        private void SetEndCap()
        {
            int tmp;
            if (_pen.Width == 1)
            {
                tmp = 2;
            }
            else
            {
                tmp = 1;
            }
            GraphicsPath _graphicsPath = new GraphicsPath();
            _graphicsPath.AddLine(new Point(0, 0), new Point(12 / tmp, -24 / tmp));
            _graphicsPath.AddLine(new Point(12 / tmp, -24 / tmp), new Point(-12 / tmp, -24 / tmp));
            _graphicsPath.AddLine(new Point(-12 / tmp, -24 / tmp), new Point(0, 0));
            _pen.CustomEndCap = new CustomLineCap(null, _graphicsPath, LineCap.Custom, 24 / tmp);
            _pen.DashStyle = DashStyle.Dash;
        }

        public override void ChangeWidth(int width)
        {
            _pen.Width = width;
            SetEndCap();
        }
    }
}
