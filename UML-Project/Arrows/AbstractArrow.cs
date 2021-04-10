using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Project.Arrows
{
    public abstract class AbstractArrow : IFigure
    {
        protected Pen _pen;
        public Axises StartDirectionAxis;
        public Axises EndDirectionAxis;
        public List<Point> Points;

        public Point Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void Draw(Graphics graphics)
        {
            graphics.DrawLines(_pen, Points.ToArray());
        }
        public virtual List<Point> GetPoints(Point startPoint, Point endPoint)
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
                    Points.Add(endPoint);
                }
                else
                {                    
                    int middleY = (startPoint.Y + endPoint.Y) / 2;
                    Points.Add(new Point(startPoint.X, middleY));
                    Points.Add(new Point(endPoint.X, middleY));
                    Points.Add(endPoint);
                }
            }
            else
            {
                if (StartDirectionAxis == Axises.X)
                {
                    Points.Add(new Point(endPoint.X, startPoint.Y));
                    Points.Add(endPoint);
                }
                else
                {
                    Points.Add(new Point(startPoint.X, endPoint.Y));
                    Points.Add(endPoint);
                }
            }
            return Points;
        }

        public void ChangeColor(Color color)
        {
            _pen.Color = color;
        }
        public void ChangeWidth(int width)
        {
            _pen.Width = width;
        }

        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }

        public void Select()
        {
            throw new NotImplementedException();
        }

        public void IsHovered(Point point)
        {
            throw new NotImplementedException();
        }

        public int GetWidth()
        {
            throw new NotImplementedException();
        }

        public int GetHeight()
        {
            throw new NotImplementedException();
        }



        //protected virtual Point GetPoint(Point currentPoint, int currentWay)
        //{
        //    Point newPoint = new Point();
        //    if (currentWay == (int)Axises.Left)
        //    {
        //        if (currentPoint.X <= EndPoint.X)
        //        {
        //            newPoint.X = currentPoint.X - 15;
        //            newPoint.Y = currentPoint.Y;
        //        }
        //        else
        //        {
        //            if (currentPoint.Y == EndPoint.Y)
        //            {
        //                newPoint = EndPoint;
        //            }
        //            else
        //            {
        //                newPoint.Y = currentPoint.Y;
        //                newPoint.X = (currentPoint.X + EndPoint.X) / 2;
        //            }
        //        }
        //    }

        //    if (currentWay == (int)Axises.Right)
        //    {
        //        if (currentPoint.X >= EndPoint.X)
        //        {
        //            newPoint.X = currentPoint.X + 15;
        //            newPoint.Y = currentPoint.Y;
        //        }
        //        else
        //        {
        //            if (currentPoint.Y == EndPoint.Y)
        //            {
        //                newPoint = EndPoint;
        //            }
        //            else
        //            {
        //                newPoint.Y = currentPoint.Y;
        //                newPoint.X = (currentPoint.X + EndPoint.X) / 2;
        //            }
        //        }
        //    }

        //    if (currentWay == (int)Axises.Up)
        //    {
        //        if (currentPoint.Y <= EndPoint.Y)
        //        {
        //            newPoint.X = currentPoint.X;
        //            newPoint.Y = currentPoint.Y - 15;
        //        }
        //        else
        //        {
        //            if (currentPoint.X == EndPoint.X)
        //            {
        //                newPoint = EndPoint;
        //            }
        //            else
        //            {
        //                newPoint.X = currentPoint.X;
        //                newPoint.Y = (currentPoint.Y + EndPoint.Y) / 2;
        //            }
        //        }

        //    }
        //    if (currentWay == (int)Axises.Down)
        //    {
        //        if (currentPoint.X >= EndPoint.X)
        //        {
        //            newPoint.X = currentPoint.X;
        //            newPoint.Y = currentPoint.Y + 15;
        //        }
        //        else
        //        {
        //            if (currentPoint.X == EndPoint.X)
        //            {
        //                newPoint = EndPoint;
        //            }
        //            else
        //            {
        //                newPoint.X = currentPoint.X;
        //                newPoint.Y = (currentPoint.Y + EndPoint.Y) / 2;
        //            }
        //        }
        //    }
        //    return newPoint;
        //}

        //protected virtual int ChooseWay(Point currentPoint, int currentWay)
        //{
        //    if (currentWay == (int)Axises.Left || currentWay == (int)Axises.Right)
        //    {
        //        if (currentPoint.Y < EndPoint.Y)
        //        {
        //            return (int)Axises.Down;
        //        }
        //        else
        //        {
        //            return (int)Axises.Up;
        //        }
        //    }
        //    else
        //    {
        //        if (currentPoint.X < EndPoint.X)
        //        {
        //            return (int)Axises.Right;
        //        }
        //        else
        //        {
        //            return (int)Axises.Left;
        //        }
        //    }
        //}

    }
}
