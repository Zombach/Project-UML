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
    public class InheritanceArrow : AbstractArrow
    {
        public InheritanceArrow() : base()
        {
        }

        public InheritanceArrow(Color color, int width) : base(color, width)
        {
        }

        public InheritanceArrow(Point startPoint, Point endPoint, Axis startDirectionAxis
            , Axis endDirectionAxis) : base(startPoint, endPoint, startDirectionAxis, endDirectionAxis)
        {
        }

        public InheritanceArrow(StructArrow arrow) : base(arrow)
        {

        }
        public InheritanceArrow(IFigure figure) : base(figure)
        {

        }

        public override void SetEndCap()
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
        }

        public override void ChangeWidth(int width)
        {
            _pen.Width = width;
            SetEndCap();
        }




        //public InheritanceArrow()
        //{
        //    _pen = new Pen(Color.Black, 4);
        //}

        //private int _const;
        //private int _tmp = 50;
        //public override List<Point> GetPoints(Point startPoint, Point endPoint)
        //{
        //    Point currentPoint = startPoint;
        //    Points = new List<Point>() { currentPoint };
        //    if (StartDirectionAxis == EndDirectionAxis)
        //    {
        //        if (StartDirectionAxis == Axises.X)
        //        {
        //            int middleX = (startPoint.X + endPoint.X) / 2;
        //            Points.Add(new Point(middleX, startPoint.Y));
        //            Points.Add(new Point(middleX, endPoint.Y));
        //            if (startPoint.X<endPoint.X)
        //            {
        //                _const = _tmp;
        //                Tip1(endPoint);
        //            }
        //            else
        //            {
        //                _const = _tmp*-1;
        //                Tip1(endPoint);
        //            }    
        //        }
        //        else
        //        {
        //            int middleY = (startPoint.Y + endPoint.Y) / 2;
        //            Points.Add(new Point(startPoint.X, middleY));
        //            Points.Add(new Point(endPoint.X, middleY));
        //            if (startPoint.Y < endPoint.Y)
        //            {
        //                _const = _tmp;
        //                Tip2(endPoint);
        //            }
        //            else
        //            {
        //                _const = _tmp * -1;
        //                Tip2(endPoint);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (StartDirectionAxis == Axises.X)
        //        {
        //            Points.Add(new Point(endPoint.X, startPoint.Y));
        //            if (startPoint.Y < endPoint.Y)
        //            {
        //                _const = _tmp;
        //                Tip2(endPoint);
        //            }
        //            else
        //            {
        //                _const = _tmp * -1;
        //                Tip2(endPoint);
        //            }
        //        }
        //        else
        //        {
        //            Points.Add(new Point(startPoint.X, endPoint.Y));
        //            if (startPoint.X < endPoint.X)
        //            {
        //                _const = _tmp;
        //                Tip1(endPoint);
        //            }
        //            else
        //            {
        //                _const = _tmp * -1;
        //                Tip1(endPoint);
        //            }
        //        }
        //    }
        //    return Points;
        //}


        //public void Tip1(Point endPoint)
        //{
        //    Points.Add(new Point(endPoint.X - _const, endPoint.Y));
        //    Points.Add(new Point(endPoint.X - _const, endPoint.Y - _const));
        //    Points.Add(endPoint);
        //    Points.Add(new Point(endPoint.X - _const, endPoint.Y + _const));
        //    Points.Add(new Point(endPoint.X - _const, endPoint.Y));
        //}

        //public void Tip2(Point endPoint)
        //{
        //    Points.Add(new Point(endPoint.X, endPoint.Y - _const));
        //    Points.Add(new Point(endPoint.X + _const, endPoint.Y - _const));
        //    Points.Add(endPoint);
        //    Points.Add(new Point(endPoint.X - _const, endPoint.Y - _const));
        //    Points.Add(new Point(endPoint.X, endPoint.Y - _const));
        //}
    }
}
