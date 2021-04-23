using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Arrows
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class AggregationArrow : AbstractArrow
    {
        public AggregationArrow() : base()
        {
        }
        public AggregationArrow(Color color, int width) : base(color, width)
        {
        }
        public AggregationArrow(Point startPoint, Point endPoint, Axis startDirectionAxis
            , Axis endDirectionAxis) : base(startPoint, endPoint, startDirectionAxis, endDirectionAxis)
        {
        }
        public AggregationArrow(StructArrow arrow) : base(arrow)
        {

        }
        public AggregationArrow(IFigure figure) : base(figure)
        {

        }

        public override void SetEndCap()
        {
            
            int tmp = (int)_pen.Width;

            GraphicsPath _graphicsPath = new GraphicsPath();
            _graphicsPath.AddLine(new Point(0, 0), new Point(8 / tmp, -12 / tmp));
            _graphicsPath.AddLine(new Point(8 / tmp, -12 / tmp), new Point(0, -24 / tmp));
            _graphicsPath.AddLine(new Point(0, -24 / tmp), new Point(-8 / tmp, -12 / tmp));
            _graphicsPath.AddLine(new Point(-8 / tmp, -12 / tmp), new Point(0, 0));
            _pen.CustomEndCap = new CustomLineCap(null, _graphicsPath, LineCap.Custom, 24 / tmp);
        }
        public override void ChangeWidth(int width)
        {
            _pen.Width = width;
            SetEndCap();
        }
    }
}
