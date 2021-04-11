using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Project.Arrows
{
    public class InheritanceArrow : AbstractArrow
    {
        public InheritanceArrow()
        {
            _pen = new Pen(Color.Black, 4);
        }
        
        private int _const;
        private int _tmp = 50;
        public override List<Point> GetPoints(Point startPoint, Point endPoint)
        {
            Point currentPoint = startPoint;
            Points = new List<Point>() { currentPoint };
            if (StartDirectionAxis == EndDirectionAxis)
            {
                if (StartDirectionAxis == Axises.X)
                {
                    int middleX = (startPoint.X + endPoint.X) / 2;
                    Points.Add(new Point(middleX, startPoint.Y));
                    Points.Add(new Point(middleX, endPoint.Y));
                    if (startPoint.X<endPoint.X)
                    {
                        _const = _tmp;
                        Tip1(endPoint);
                    }
                    else
                    {
                        _const = _tmp*-1;
                        Tip1(endPoint);
                    }    
                }
                else
                {
                    int middleY = (startPoint.Y + endPoint.Y) / 2;
                    Points.Add(new Point(startPoint.X, middleY));
                    Points.Add(new Point(endPoint.X, middleY));
                    if (startPoint.Y < endPoint.Y)
                    {
                        _const = _tmp;
                        Tip2(endPoint);
                    }
                    else
                    {
                        _const = _tmp * -1;
                        Tip2(endPoint);
                    }
                }
            }
            else
            {
                if (StartDirectionAxis == Axises.X)
                {
                    Points.Add(new Point(endPoint.X, startPoint.Y));
                    if (startPoint.Y < endPoint.Y)
                    {
                        _const = _tmp;
                        Tip2(endPoint);
                    }
                    else
                    {
                        _const = _tmp * -1;
                        Tip2(endPoint);
                    }
                }
                else
                {
                    Points.Add(new Point(startPoint.X, endPoint.Y));
                    if (startPoint.X < endPoint.X)
                    {
                        _const = _tmp;
                        Tip1(endPoint);
                    }
                    else
                    {
                        _const = _tmp * -1;
                        Tip1(endPoint);
                    }
                }
            }
            return Points;
        }


        public void Tip1(Point endPoint)
        {
            Points.Add(new Point(endPoint.X - _const, endPoint.Y));
            Points.Add(new Point(endPoint.X - _const, endPoint.Y - _const));
            Points.Add(endPoint);
            Points.Add(new Point(endPoint.X - _const, endPoint.Y + _const));
            Points.Add(new Point(endPoint.X - _const, endPoint.Y));
        }

        public void Tip2(Point endPoint)
        {
            Points.Add(new Point(endPoint.X, endPoint.Y - _const));
            Points.Add(new Point(endPoint.X + _const, endPoint.Y - _const));
            Points.Add(endPoint);
            Points.Add(new Point(endPoint.X - _const, endPoint.Y - _const));
            Points.Add(new Point(endPoint.X, endPoint.Y - _const));
        }
    }
}
