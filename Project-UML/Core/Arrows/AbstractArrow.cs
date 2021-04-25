using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Boxes;
using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Interfaces.Get;

namespace Project_UML.Core.Arrows
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public abstract class AbstractArrow : IFigure
    {
        protected Pen _pen;
        protected Pen _selectionPen = new Pen(Color.DodgerBlue, 3);
        public Axis StartDirectionAxis { get; set; } = Axis.X;
        public Axis EndDirectionAxis { get; set; } = Axis.X;
        public List<Point> Points { get; set; } = new List<Point>();
        public List<DataCommon> DataCommon { get; set; } = new List<DataCommon>();

        public Link SelectedLink { get; set; }

        public AbstractArrow()
        {
            _pen = new Pen(Color.Black, 1);
            SetEndCap();
        }
        public AbstractArrow(Color color, int width)
        {
            _pen = new Pen(color, width);
            SetEndCap();
        }
        public AbstractArrow(Point startPoint, Point endPoint, Axis startDirectionAxis, Axis endDirectionAxis)
        {
            _pen = new Pen(Color.Black, 1);
            Points = GetPoints(startPoint, endPoint);
            StartDirectionAxis = startDirectionAxis;
            EndDirectionAxis = endDirectionAxis;
            SetEndCap();
        }
        public AbstractArrow(IFigure figure)
        {
            AbstractArrow arrow = (AbstractArrow)figure;
            Points = new List<Point>();
            _pen = new Pen(arrow._pen.Color, arrow._pen.Width);
            for (int i = 0; i < arrow.Points.Count; i++)
            {
                Point point = new Point(arrow.Points[i].X, arrow.Points[i].Y);
                Points.Add(point);
            }
            DataCommon = new List<DataCommon>();
            StartDirectionAxis = arrow.StartDirectionAxis;
            EndDirectionAxis = arrow.EndDirectionAxis;
            SelectedLink = new Link();
            SetEndCap();
        }

        /// <summary>
        /// Создание стрелы по предоставленным данным структуры
        /// </summary>
        /// <param name="arrow">Структура данных стрелы</param>
        public AbstractArrow(StructArrow arrow)
        {
            _pen = new Pen(arrow.Color, arrow.Width);
            for (int i = 0; i < arrow.Points.Count; i++)
            {
                Point point = new Point(arrow.Points[i].Point_X, arrow.Points[i].Point_Y);
                Points.Add(point);
            }
            SetEndCap();
            //Необходимо дописать конструктор стрелы
        }

        public virtual void SetEndCap()
        {
        }

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
                if (StartDirectionAxis == Axis.X)
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
                if (StartDirectionAxis == Axis.X)
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
            CoreUML coreUML = CoreUML.GetCoreUML();
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
                    Axis axis;
                    if (Points[i - 1].X == Points[i].X)
                    {
                        axis = Axis.X;
                    }
                    else
                    {
                        axis = Axis.Y;
                    }
                    LinkType linkType;
                    if (i - 1 == 0)
                    {
                        linkType = LinkType.First;
                    }
                    else if (i == Points.Count - 1)
                    {
                        linkType = LinkType.Last;
                    }
                    else
                    {
                        linkType = LinkType.Middle;
                    }
                    SelectedLink = new Link(i - 1, i, axis, linkType);
                    return selected;
                }
            }
            return selected;
        }

        public void Transform(Point e)
        {
            if (SelectedLink.IndexOfEndPoint != Points.Count - 1 && SelectedLink.IndexOfStartPoint != 0 && SelectedLink.LinkType == LinkType.Middle)
            {
                if (SelectedLink.Axis == Axis.X)
                {
                    Points[SelectedLink.IndexOfStartPoint] = new Point(e.X, Points[SelectedLink.IndexOfStartPoint].Y);
                    Points[SelectedLink.IndexOfEndPoint] = new Point(e.X, Points[SelectedLink.IndexOfEndPoint].Y);
                }
                else
                {
                    Points[SelectedLink.IndexOfStartPoint] = new Point(Points[SelectedLink.IndexOfStartPoint].X, e.Y);
                    Points[SelectedLink.IndexOfEndPoint] = new Point(Points[SelectedLink.IndexOfEndPoint].X, e.Y);
                }
            }
            else if (SelectedLink.LinkType == LinkType.Last)
            {
                HookEndPointToFigure(e);
                //GetPoints(Points[0], e);
            }
            else if (SelectedLink.LinkType == LinkType.First)
            {
                //GetPoints(e, Points[Points.Count - 1]);
                HookStartPointToFigure(e);
            }
        }

        public void Select(Graphics graphics)
        {
            foreach (Point point in Points)
            {
                graphics.DrawEllipse(_selectionPen, point.X - (_pen.Width * 3) / 2, point.Y - (_pen.Width * 3) / 2, _pen.Width * 3, _pen.Width * 3);
            }
        }

        public void UpdArrow()
        {
            if (DataCommon.Count != 0)
            {
                Point startPoint = Points[0];

                if (!(DataCommon[0].LastBox is null))
                {
                    UpdStartPoint(DataCommon[0].LastBox.GetMiddlePoint());
                }
                else
                {
                    UpdStartPoint(DataCommon[0].LastPoint);
                }
                UpdEndPoint(DataCommon[0].FirstPoint);
            }
            GetPoints(DataCommon[0].FirstPoint, DataCommon[0].LastPoint);
        }

        public void HookStartPointToFigure(Point e)
        {
            if (DataCommon.Count == 0)
            {
                DataCommon.Add(new DataCommon(this));
            }
            DataCommon[0].FirstPoint = e;
            foreach (IFigure figure in CoreUML.GetCoreUML().Figures)
            {
                if (figure is AbstractBox && figure != DataCommon[0].LastBox)
                {
                    if (figure.CheckSelection(e, e, 0))
                    {
                        UpdEndPoint(figure.GetMiddlePoint());
                        DataCommon[0].FirstBox = figure;
                        ConnectionPoint startConnectionPoint = figure.GetConnectionPoint(Points[Points.Count - 1]);
                        DataCommon[0].FirstPoint = startConnectionPoint.Point;
                        GetPoints(startConnectionPoint.Point, Points[Points.Count - 1]);
                        StartDirectionAxis = startConnectionPoint.Axis;
                        return;
                    }
                }
            }
            if (!(DataCommon[0].FirstBox is null))
            {
                DataCommon[0].FirstBox.DataCommon.Remove(DataCommon[0]);
                DataCommon[0].FirstBox = null;
            }
            UpdEndPoint(e);
            GetPoints(e, Points[Points.Count - 1]);
        }
        public void HookEndPointToFigure(Point e)
        {
            if (DataCommon.Count == 0)
            {
                DataCommon.Add(new DataCommon(this));
            }
            DataCommon[0].LastPoint = e;
            foreach (IFigure figure in CoreUML.GetCoreUML().Figures)
            {
                if (figure is AbstractBox && figure != DataCommon[0].FirstBox)
                {
                    if (figure.CheckSelection(e, e, 0))
                    {
                        UpdStartPoint(figure.GetMiddlePoint());
                        DataCommon[0].LastBox = figure;
                        ConnectionPoint endConnectionPoint = figure.GetConnectionPoint(Points[0]);
                        DataCommon[0].LastPoint = endConnectionPoint.Point;
                        GetPoints(Points[0], endConnectionPoint.Point);
                        EndDirectionAxis = endConnectionPoint.Axis;
                        return;
                    }
                }
            }
            if (!(DataCommon[0].LastBox is null))
            {
                DataCommon[0].LastBox.DataCommon.Remove(DataCommon[0]);
                DataCommon[0].LastBox = null;
            }
            UpdStartPoint(e);
            GetPoints(Points[0], e);
        }

        public void UpdStartPoint(Point e)
        {
            if (!(DataCommon[0].FirstBox is null))
            {
                ConnectionPoint connectionPoint = DataCommon[0].FirstBox.GetConnectionPoint(e);
                Points[0] = connectionPoint.Point;
                DataCommon[0].FirstPoint = connectionPoint.Point;
                StartDirectionAxis = connectionPoint.Axis;
            }
        }
        public void UpdEndPoint(Point e)
        {
            if (!(DataCommon[0].LastBox is null))
            {
                ConnectionPoint connectionPoint = DataCommon[0].LastBox.GetConnectionPoint(e);
                Points[Points.Count - 1] = connectionPoint.Point;
                DataCommon[0].LastPoint = connectionPoint.Point;
                EndDirectionAxis = connectionPoint.Axis;
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

        public Color GetColor()
        {
            return _pen.Color;
        }

        public float GetSize()
        {
            return 1f;
        }

        public float GetWidth()
        {
            return _pen.Width;
        }

        public int GetHeight()
        {
            throw new NotImplementedException();
        }

        public ConnectionPoint GetConnectionPoint(Point point)
        {
            throw new NotImplementedException();
        }

        public Point GetMiddlePoint()
        {
            throw new NotImplementedException();
        }
    }
}
