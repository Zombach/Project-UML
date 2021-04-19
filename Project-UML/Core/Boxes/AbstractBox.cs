using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces.Get;
using Project_UML.Core.Interfaces.Logics;
using Project_UML.Core.Arrows;

namespace Project_UML.Core.Boxes
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public abstract class AbstractBox : IFigure, IGetFont
    {
        /// <summary>
        /// Жестко заданы точки [0] - левая верхняя точка, [1] - правая нижняя точка
        /// </summary>
        public List<Point> Points { get; set; } = new List<Point>();
        public List<DataCommon> DataCommon { get; set; } = new List<DataCommon>();
        public List<DataText> DataText { get; set; } = new List<DataText>();
        protected Font Font { get; set; } = CoreUML.GetCoreUML().DefaultFont;
        protected int RectangleWidth { get; set; } = 100;
        protected int RectangleHeight { get; set; } = 150;

        protected Pen _pen;
        protected Pen _selectionPen = new Pen(Color.DodgerBlue, 3);


        public virtual void AddPoints(Point point)
        {
            Points.Add(point);
            Point pointTmp = new Point(point.X + RectangleWidth, point.Y + RectangleHeight);
            Points.Add(pointTmp);
        }
        public virtual void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectangleHeight);
        }


        public void ChangeColor(Color color)
        {
            _pen.Color = color;
        }
        public virtual void ChangeWidth(int width)
        {
            _pen.Width = width;
        }

        public void WriteCommonPoints(DataCommon dataPoints)
        {
            DataCommon.Add(dataPoints);
        }

        public void RemoveCommonPoints(DataCommon dataPoints)
        {
            DataCommon.Remove(dataPoints);
        }

        public void IsHovered(Point point)
        {
            throw new NotImplementedException();
        }

        public void Select()
        {
            throw new NotImplementedException();
        }

        public void Select(Graphics graphics)
        {
            List<Point> pointsOfSelection = new List<Point> { Points[0], Points[1] };
            pointsOfSelection.Add(new Point(Points[1].X, Points[0].Y));
            pointsOfSelection.Add(new Point(Points[0].X, Points[1].Y));
            foreach (Point point in pointsOfSelection)
            {
                graphics.DrawEllipse(_selectionPen, point.X - (_pen.Width * 3) / 2, point.Y - (_pen.Width * 3) / 2, _pen.Width * 3, _pen.Width * 3);
            }
        }

        public void Move(int deltaX, int deltaY)
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

        public bool CheckSelection(Point startPoint, Point endPoint, int inaccuracy)
        {
            bool selected = false;

            if (!(startPoint.X > Points[Points.Count - 1].X
                ||
                startPoint.Y > Points[Points.Count - 1].Y
                ||
                endPoint.X < Points[0].X
                ||
                endPoint.Y < Points[0].Y
                ))
            {
                selected = true;
                return selected;
            }

            return selected;
        }

        public float GetWidth()
        {
            return _pen.Width;
        }

        public Font GetFont()
        {
            return Font;
        }

        public int GetHeight()
        {
            throw new NotImplementedException();
        }

        bool IIsHovered.IsHovered(Point point)
        {
            throw new NotImplementedException();
        }

        public ConnectionPoint GetConnectionPoint(Point point)
        {
            Point Middle = new Point((Points[0].X + Points[1].X) / 2, (Points[0].Y + Points[1].Y) / 2);
            ConnectionPoint connectionPoint = new ConnectionPoint();
            int tmpX = Middle.X - point.X;
            int tmpY = Middle.Y - point.Y;

            if (Math.Abs(tmpX) < Math.Abs(tmpY))
            {
                connectionPoint.Axis = Axises.Y;
                if (tmpY > 0)
                {
                    connectionPoint.Point = new Point(Middle.X, Points[0].Y);
                }
                else
                {
                    connectionPoint.Point = new Point(Middle.X, Points[1].Y);
                }
            }
            else
            {
                connectionPoint.Axis = Axises.X;
                if (tmpX > 0)
                {
                    connectionPoint.Point = new Point(Points[0].X, Middle.Y);
                }
                else
                {
                    connectionPoint.Point = new Point(Points[1].X, Middle.Y);
                }

            }
            return connectionPoint;
        }






        //protected Pen _pen = new Pen(Color.Blue, 5);

        //private int widthFigure { get; set; }
        //private int heightFigure { get; set; }
        //public Point Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //private List<Point> Points { set; get; }

        //public void Draw(Graphics graphics)
        //{
        //    graphics.DrawRectangle(_pen, Location.X, Location.Y, GetWidth(widthFigure), GetHeight(heightFigure));

        //}
        //public void ChangeColor(Color color)
        //{
        //    _pen.Color = color;
        //}

        //public void ChangeWidth(int width)
        //{
        //    _pen.Width = width;
        //}

        //public int GetHeight(int heightFigure)
        //{
        //    return heightFigure;
        //}

        //public int GetWidth(int widthFigure)
        //{
        //    return widthFigure;
        //}

        //public void IsHovered(Point point)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Move(int deltaX, int deltaY)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Select()
        //{
        //    throw new NotImplementedException();
        //}


    }
}
