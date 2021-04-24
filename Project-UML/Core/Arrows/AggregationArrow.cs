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
            _graphicsPath.AddLine(new Point(0, 0), new Point(12 / tmp, -16 / tmp));
            _graphicsPath.AddLine(new Point(12 / tmp, -16 / tmp), new Point(0, -32 / tmp));
            _graphicsPath.AddLine(new Point(0, -32 / tmp), new Point(-12 / tmp, -16 / tmp));
            _graphicsPath.AddLine(new Point(-12 / tmp, -16 / tmp), new Point(0, 0));
            _pen.CustomEndCap = new CustomLineCap(null, _graphicsPath, LineCap.Custom, 32 / tmp);


            //GraphicsPath _graphicsPath = new GraphicsPath();
            //switch ((int)_pen.Width)
            //{

            //    case 1:
            //        _graphicsPath.AddLine(new Point(0, 0), new Point(12 , -15));
            //        _graphicsPath.AddLine(new Point(12 , -15 ), new Point(0, -30));
            //        _graphicsPath.AddLine(new Point(0, -30), new Point(-12, -15));
            //        _graphicsPath.AddLine(new Point(-12, -15), new Point(0, 0));
            //        break;
            //    case 2:
            //        _graphicsPath.AddLine(new Point(0, 0), new Point(6, -8));
            //        _graphicsPath.AddLine(new Point(6, -8), new Point(0, -15));
            //        _graphicsPath.AddLine(new Point(0, -15), new Point(-6, -8));
            //        _graphicsPath.AddLine(new Point(-6, -8), new Point(0, 0));
            //        break;
            //    case 3:
            //        _graphicsPath.AddLine(new Point(0, 0), new Point(4, -5));
            //        _graphicsPath.AddLine(new Point(4, -5), new Point(0, -10));
            //        _graphicsPath.AddLine(new Point(0, -10), new Point(-4, -5));
            //        _graphicsPath.AddLine(new Point(-4, -5), new Point(0, 0));
            //        break;
            //    case 4:
            //        //_graphicsPath.AddLine(new Point(0, 0), new Point(4, -5));
            //        //_graphicsPath.AddLine(new Point(4, -5), new Point(0, -10));
            //        //_graphicsPath.AddLine(new Point(0, -10), new Point(-4, -5));
            //        //_graphicsPath.AddLine(new Point(-4, -5), new Point(0, 0));
            //        _graphicsPath.AddLine(new Point(0, 0), new Point(3, -4));
            //        _graphicsPath.AddLine(new Point(3, -4), new Point(0, -8));
            //        _graphicsPath.AddLine(new Point(0, -8), new Point(-3, -4));
            //        _graphicsPath.AddLine(new Point(-3, -4), new Point(0, 0));
            //        break;
            //    case 5:
            //        _graphicsPath.AddLine(new Point(0, 0), new Point(2, -3));
            //        _graphicsPath.AddLine(new Point(2, -3), new Point(0, -6));
            //        _graphicsPath.AddLine(new Point(0, -6), new Point(-2, -3));
            //        _graphicsPath.AddLine(new Point(-2, -3), new Point(0, 0));
            //        break;

            //}
            //_pen.CustomEndCap = new CustomLineCap(null, _graphicsPath, LineCap.Custom, 30 / (int)_pen.Width);



            ////int tmp = (int)_pen.Width;

            ////GraphicsPath _graphicsPath = new GraphicsPath();
            ////_graphicsPath.AddLine(new Point(0, 0), new Point(8 / tmp, -12 / tmp));
            ////_graphicsPath.AddLine(new Point(8 / tmp, -12 / tmp), new Point(0, -24 / tmp));
            ////_graphicsPath.AddLine(new Point(0, -24 / tmp), new Point(-8 / tmp, -12 / tmp));
            ////_graphicsPath.AddLine(new Point(-8 / tmp, -12 / tmp), new Point(0, 0));
            ////_pen.CustomEndCap = new CustomLineCap(null, _graphicsPath, LineCap.Custom, 24 / tmp);
        }
        public override void ChangeWidth(int width)
        {
            _pen.Width = width;
            SetEndCap();
        }
    }
}
