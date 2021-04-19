using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Interfaces.Get;

namespace Project_UML.Core.Arrows
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public abstract class AbstractArrow : IFigure, IGetArrowType
    {
        protected Pen _pen;
        protected Pen _selectionPen = new Pen(Color.DodgerBlue, 3);
        public Axises StartDirectionAxis { get; set; }
        public Axises EndDirectionAxis { get; set; }
        public List<Point> Points { get; set; }
        public List<DataCommon> DataCommon { get; set; } = new List<DataCommon>();

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

        public void Reverse()
        {
            Points.Reverse();
        }

        public void ChangeColor(Color color)
        {
            _pen.Color = color;
        }
        public virtual void ChangeWidth(int width)
        {
            _pen.Width = width;
        }

        public bool IsHovered(Point point)
        {
            bool selected = false;
            //int maxX;
            //int minX;
            //int maxY;
            //int minY;
            //for (int i = 1; i < Points.Count; i++)
            //{
            //    if (Points[i - 1].X > Points[i].X)
            //    {
            //        maxX = Points[i - 1].X + 2;
            //        minX = Points[i].X - 2;
            //    }
            //    else
            //    {
            //        minX = Points[i - 1].X - 2;
            //        maxX = Points[i].X + 2;
            //    }
            //    if (Points[i - 1].Y > Points[i].Y)
            //    {
            //        maxY = Points[i - 1].Y + 2;
            //        minY = Points[i].Y - 2;
            //    }
            //    else
            //    {
            //        minY = Points[i - 1].Y - 2;
            //        maxY = Points[i].Y + 2;
            //    }
            //    if (point.X <= maxX &&
            //        point.X >= minX &&
            //        point.Y <= maxY &&
            //        point.Y >= minY)
            //    {
            //        selected = true;
            //        return selected;
            //    }
            //}
            return selected;

        }

        public bool CheckSelection(Point startPoint, Point endPoint, int inaccuracy = 0)
        {
            bool selected = false;
            int maxX;
            int minX;
            int maxY;
            int minY;
            for (int i = 1; i < Points.Count; i++)
            {
                if (Points[i - 1].X > Points[i].X)
                {
                    maxX = Points[i - 1].X + inaccuracy;
                    minX = Points[i].X - inaccuracy;
                }
                else
                {
                    minX = Points[i - 1].X - inaccuracy;
                    maxX = Points[i].X + inaccuracy;
                }
                if (Points[i - 1].Y > Points[i].Y)
                {
                    maxY = Points[i - 1].Y + inaccuracy;
                    minY = Points[i].Y - inaccuracy;
                }
                else
                {
                    minY = Points[i - 1].Y - inaccuracy;
                    maxY = Points[i].Y + inaccuracy;
                }
                if (!(startPoint.X > maxX
                    ||
                    startPoint.Y > maxY
                    ||
                    endPoint.X < minX
                    ||
                    endPoint.Y < minY
                    ))
                {
                    selected = true;
                    return selected;
                }
            }
            return selected;
        }



        public void Select(Graphics graphics)
        {
            foreach (Point point in Points)
            {
                graphics.DrawEllipse(_selectionPen, point.X - (_pen.Width * 3) / 2, point.Y - (_pen.Width * 3) / 2, _pen.Width * 3, _pen.Width * 3);
            }
        }

        public void Move(int deltaX, int deltaY)
        {
            List<Point> newPoints = new List<Point>();
            foreach (Point point in Points)
            {
                Point currentPoint = point;
                currentPoint.X += deltaX;
                currentPoint.Y += deltaY;
                newPoints.Add(currentPoint);
            }
            Points = newPoints;
        }

        public void Select()
        {
            throw new NotImplementedException();
        }
        public void IsHovered(Point point)
        {
            throw new NotImplementedException();
        }

        public Color GetColor()
        {
            return _pen.Color;
        }

        public float GetSize()
        {
            throw new NotImplementedException();
        }

        public float GetWidth()
        {
            return _pen.Width;
        }

        public ArrowType GetArrowType()
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
