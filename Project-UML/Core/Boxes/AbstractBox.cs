using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using Project_UML.Core.Interfaces.Get;
using Project_UML.Core.Interfaces.Logics;
using Project_UML.Core.Arrows;
using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.Interfaces.Draws;
using Project_UML.Core.Enum;
using Project_UML.Core.DataProject.Interfaces;

namespace Project_UML.Core.Boxes
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public abstract class AbstractBox : IFigure, IGetFont, IChangeFont, IGetWidth
    {
        /// <summary>
        /// Жестко заданы точки [0] - левая верхняя точка, [1] - правая нижняя точка
        /// </summary>
        protected Pen _pen;
        protected static Pen _selectionPen = new Pen(Color.DodgerBlue, 3);
        public List<Point> Points { get; set; } = new List<Point>();
        public List<DataCommon> DataCommon { get; set; } = new List<DataCommon>();
        public List<DataText> DataText { get; set; } = new List<DataText>();
        public List<IDataCommon> IDataCommon { get; set; } = new List<IDataCommon>();
        protected Font[] Font { get; set; } = new Font[]
        {
                CoreUML.GetCoreUML().DefaultFont,
                CoreUML.GetCoreUML().DefaultFont,
                CoreUML.GetCoreUML().DefaultFont,
                CoreUML.GetCoreUML().DefaultFont
        };
        protected SolidBrush[] Brushs { get; set; } = new SolidBrush[]
        {
                new SolidBrush(CoreUML.GetCoreUML().DefaultColor),
                new SolidBrush(CoreUML.GetCoreUML().DefaultColor),
                new SolidBrush(CoreUML.GetCoreUML().DefaultColor),
                new SolidBrush(CoreUML.GetCoreUML().DefaultColor)
        };
        public int RectangleWidth { get; set; }
        public int RectangleHeight { get; set; }
        protected int RectNameHeight { get; set; }
        protected int RectFieldHeight { get; set; }
        protected int RectPropertyHeight { get; set; }
        protected int RectMethodsHeight { get; set; }
        
        ///// <summary>
        /// List<string> RectangleText
        /// RectangleText[0] - name
        /// RectangleText[1] - field
        /// RectangleText[2] - property
        /// RectangleText[3] - methods
        /// </summary>
        public List<string> RectangleText = new List<string> {"Name", "Filed", "Property", "Methods"};
        
        public BoxZones crntZone;

        public AbstractBox(Color color, int width)
        {
            _pen = new Pen(color, width); 
            RectangleWidth = 105;
        }
        public AbstractBox(IFigure figure)
        {
            AbstractBox box = (AbstractBox)figure;
            _pen = new Pen(box._pen.Color, box._pen.Width);
            for (int i = 0; i < box.Points.Count; i++)
            {
                Point point = new Point(box.Points[i].X, box.Points[i].Y);
                Points.Add(point);
            }
            Font = box.Font;
            RectangleWidth = box.RectangleWidth;
            RectangleHeight = box.RectangleHeight;
            RectNameHeight = box.RectNameHeight;
            RectFieldHeight = box.RectFieldHeight;
            RectPropertyHeight = box.RectPropertyHeight;
            RectMethodsHeight = box.RectMethodsHeight;
        }

        /// <summary>
        /// Конструктор для развертывания фигуры по структуре
        /// </summary>
        /// <param name="box"></param>
        public AbstractBox(StructBox box)
        {
            _pen = new Pen(box.Color, box.Width);
            for (int i = 0; i < box.Points.Count; i++)
            {
                Point point = new Point(box.Points[i].Point_X, box.Points[i].Point_Y);
                Points.Add(point);
            }
            Font = box.Font;
            RectangleWidth = SizeWidth();
            RectangleHeight = SizeHeight();
            IDataCommon = box.Data;
        }


        public virtual void AddPoints(Point point)
        {
            Points.Add(point);
            Point pointTmp = new Point(point.X + RectangleWidth, point.Y + RectangleHeight);
            Points.Add(pointTmp);
        }

        public virtual void UpdatePoints()
        {
            Points[1] = new Point(Points[0].X + RectangleWidth, Points[0].Y + RectangleHeight);
        }

        public virtual void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectangleHeight);
        }

        public void ChangeFont(Font font, string name = "Name")
        {
            switch(name)
            {
                case "Name":
                    Font[0] = font;
                    break;
                case "Field":
                    Font[1] = font;
                    break;
                case "Property":
                    Font[2] = font;
                    break;
                case "Methods":
                    Font[3] = font;
                    break;
            }
          
        }
        public void ChangeColorText(Color color, string name = "Name")
        {
            switch (name)
            {
                case "Name":
                    Brushs[0] = new SolidBrush(color);
                    break;
                case "Field":
                    Brushs[1] = new SolidBrush(color);
                    break;
                case "Property":
                    Brushs[2] = new SolidBrush(color);
                    break;
                case "Methods":
                    Brushs[3] = new SolidBrush(color);
                    break;
            }

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

        public static void DrawConnectionPoint(Graphics graphics, Point point)
        {
            graphics.DrawEllipse(_selectionPen, point.X - 3 / 2, point.Y - 5 / 2, 3, 3);
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
            foreach (DataCommon dataCommon in DataCommon)
            {
                AbstractArrow arrow = (AbstractArrow)dataCommon.Arrow;
                arrow.UpdArrow();
            }
        }

        public int SizeHeight()
        {
            return Points[1].Y - Points[0].Y;
        }
        public int SizeWidth()
        {
            return Points[1].X - Points[0].X;
        }

        public Color GetColor()
        {
            return _pen.Color;
        }

        public bool CheckSelection(Point startPoint, Point endPoint, int inaccuracy)
        {
            bool selected = false;

            if (!(startPoint.X > Points[1].X + inaccuracy
                ||
                startPoint.Y > Points[1].Y + inaccuracy
                ||
                endPoint.X < Points[0].X - inaccuracy
                ||
                endPoint.Y < Points[0].Y - inaccuracy
                ))
            {
                selected = true;
                if (!(startPoint.X > Points[1].X + inaccuracy
                ||
                startPoint.Y > Points[0].Y + inaccuracy
                ||
                endPoint.X < Points[0].X - inaccuracy
                ||
                endPoint.Y < Points[0].Y - inaccuracy
                ))
                {
                    crntZone = BoxZones.Top;
                }
                else if (!(startPoint.X > Points[1].X + inaccuracy
                ||
                startPoint.Y > Points[1].Y + inaccuracy
                ||
                endPoint.X < Points[1].X - inaccuracy
                ||
                endPoint.Y < Points[0].Y - inaccuracy
                ))
                {
                    crntZone = BoxZones.Right;
                }
                else if (!(startPoint.X > Points[1].X + inaccuracy
                ||
                startPoint.Y > Points[1].Y + inaccuracy
                ||
                endPoint.X < Points[0].X - inaccuracy
                ||
                endPoint.Y < Points[1].Y - inaccuracy
                ))
                {
                    crntZone = BoxZones.Bottom;
                }
                else if (!(startPoint.X > Points[0].X + inaccuracy
                ||
                startPoint.Y > Points[1].Y + inaccuracy
                ||
                endPoint.X < Points[0].X - inaccuracy
                ||
                endPoint.Y < Points[0].Y - inaccuracy
                ))
                {
                    crntZone = BoxZones.Left;
                }
                else
                {
                    crntZone = BoxZones.Center;
                }
            }

            return selected;
        }

        public float GetWidth()
        {
            return _pen.Width;
        }

        public Font[] GetFont()
        {
            return Font;
        }

        public int GetHeight()
        {
            throw new NotImplementedException();
        }

        public Point GetMiddlePoint()
        {
            return new Point((Points[0].X + Points[1].X) / 2, (Points[0].Y + Points[1].Y) / 2);
        }

        public ConnectionPoint GetConnectionPoint(Point crntPoint, Point oppositePoint)
        {
            ConnectionPoint connectionPoint = new ConnectionPoint();
            connectionPoint.Zone = crntZone;
            int distance;
            if (crntZone == BoxZones.Bottom || crntZone == BoxZones.Top)
            {
                connectionPoint.Axis = Axis.Y;
                if (crntPoint.X < Points[0].X + 5)
                {
                    distance = 5;
                }
                else if (crntPoint.X > Points[1].X - 5)
                {
                    distance = RectangleWidth - 5;
                }
                else
                {
                    distance = crntPoint.X - Points[0].X;
                }
                connectionPoint.DistanceInPercents = distance * 100 / RectangleWidth;
            }
            else if (crntZone == BoxZones.Right || crntZone == BoxZones.Left)
            {
                connectionPoint.Axis = Axis.X;
                if (crntPoint.Y < Points[0].Y + 5)
                {
                    distance = 5;
                }
                else if (crntPoint.Y > Points[1].Y - 5)
                {
                    distance = RectangleHeight - 5;
                }
                else
                {
                    distance = crntPoint.Y - Points[0].Y;
                }
                connectionPoint.DistanceInPercents = distance * 100 / RectangleHeight;
            }
            else
            {
                Point Middle = GetMiddlePoint();
                int tmpX = Middle.X - oppositePoint.X;
                int tmpY = Middle.Y - oppositePoint.Y;
                connectionPoint.DistanceInPercents = 50;
                if (Math.Abs(tmpX) < Math.Abs(tmpY))
                {
                    connectionPoint.Axis = Axis.Y;
                    if (tmpY > 0)
                    {
                        connectionPoint.Zone = BoxZones.Top;
                    }
                    else
                    {
                        connectionPoint.Zone = BoxZones.Bottom;
                    }
                }
                else
                {
                    connectionPoint.Axis = Axis.X;
                    if (tmpX > 0)
                    {
                        connectionPoint.Zone = BoxZones.Left;
                    }
                    else
                    {
                        connectionPoint.Zone = BoxZones.Right;
                    }
                }
            }

            return connectionPoint;
        }

        public Point GetCordinatsOfConnectionPoint(ConnectionPoint connectionPoint)
        {
            Point point = new Point();
            switch (connectionPoint.Zone)
            {
                case BoxZones.Bottom:
                    point.X = Points[0].X + RectangleWidth * connectionPoint.DistanceInPercents / 100;
                    point.Y = Points[1].Y;
                    break;
                case BoxZones.Top:
                    point.X = Points[0].X + RectangleWidth * connectionPoint.DistanceInPercents / 100;
                    point.Y = Points[0].Y;
                    break;
                case BoxZones.Right:
                    point.X = Points[1].X;
                    point.Y = Points[0].Y + RectangleHeight * connectionPoint.DistanceInPercents / 100;
                    break;
                case BoxZones.Left:
                    point.X = Points[0].X;
                    point.Y = Points[0].Y + RectangleHeight * connectionPoint.DistanceInPercents / 100;
                    break;
            }
            return point;
        }

        #region OLD CODE
        //public ConnectionPoint GetConnectionPoint(Point point)
        //{
        //    Point Middle = GetMiddlePoint();
        //    ConnectionPoint connectionPoint = new ConnectionPoint();
        //    int tmpX = Middle.X - point.X;
        //    int tmpY = Middle.Y - point.Y;

        //    if (Math.Abs(tmpX) < Math.Abs(tmpY))
        //    {
        //        connectionPoint.Axis = Axis.Y;
        //        if (tmpY > 0)
        //        {
        //            connectionPoint.Point = new Point(Middle.X, Points[0].Y);
        //        }
        //        else
        //        {
        //            connectionPoint.Point = new Point(Middle.X, Points[1].Y);
        //        }
        //    }
        //    else
        //    {
        //        connectionPoint.Axis = Axis.X;
        //        if (tmpX > 0)
        //        {
        //            connectionPoint.Point = new Point(Points[0].X, Middle.Y);
        //        }
        //        else
        //        {
        //            connectionPoint.Point = new Point(Points[1].X, Middle.Y);
        //        }

        //    }
        //    return connectionPoint;
        //}
        #endregion

        public void DrawSpecificRectangle(Graphics graphics, string rectText, Pen _pen, Font font, Brush brush, RectangleF rectF)
        {
            graphics.DrawString(rectText, font, brush, rectF);
            graphics.DrawRectangle(_pen, Rectangle.Round(rectF));
        }

        public int CounterOfTextLinesInSpecificRectangle(string textFromSpecificRect)
        {
            string phrase = textFromSpecificRect;
            string[] separateLines = phrase.Split('\n');
            return separateLines.Length;
        }
        public int WidthOfRectangle(Graphics graphics, List<string> RectangleText, Font[] font)
        {
            string phraseName = RectangleText[0];
            string[] separateLinesName = phraseName.Split('\n');

            SizeF stringNameSize = graphics.MeasureString(separateLinesName[0], font[0]);
            int longestSizeName = (int)stringNameSize.Width;

            if (separateLinesName.Length > 0)
            {
                for (int i = 0; i < separateLinesName.Length; i++)
                {
                    stringNameSize = graphics.MeasureString(separateLinesName[i], font[0]);

                    if (stringNameSize.Width > longestSizeName)
                    {
                        longestSizeName = (int)stringNameSize.Width;
                    }
                }
            }            

            string phraseField = RectangleText[1];
            string[] separateLinesField = phraseField.Split('\n');

            SizeF stringFieldSize = graphics.MeasureString(separateLinesField[0], font[1]);
            int longestSizeField = (int)stringFieldSize.Width;

            if (separateLinesField.Length > 0)
            {
                for (int i = 0; i < separateLinesField.Length; i++)
                {
                    stringFieldSize = graphics.MeasureString(separateLinesField[i], font[1]);

                    if (stringFieldSize.Width > longestSizeField)
                    {
                        longestSizeField = (int)stringFieldSize.Width;
                    }
                }
            }
            
            
            string phraseProperty = RectangleText[2];
            string[] separateLinesProperty = phraseProperty.Split('\n');

            SizeF stringPropertySize = graphics.MeasureString(separateLinesProperty[0], font[2]);
            int longestSizeProperty = (int)stringPropertySize.Width;

            if (separateLinesProperty.Length > 0)
            {
                for (int i = 0; i < separateLinesProperty.Length; i++)
                {
                    stringPropertySize = graphics.MeasureString(separateLinesProperty[i], font[2]);

                    if (stringPropertySize.Width > longestSizeProperty)
                    {
                        longestSizeProperty = (int)stringPropertySize.Width;
                    }
                }
            }
                        
            string phraseMethods = RectangleText[3];
            string[] separateLinesMethods = phraseMethods.Split('\n');

            SizeF stringMethodsSize = graphics.MeasureString(separateLinesMethods[0], font[3]);
            int longestSizeMethods = (int)stringMethodsSize.Width;

            if (separateLinesMethods.Length > 0)
            {
                for (int i = 0; i < separateLinesMethods.Length; i++)
                {
                    stringMethodsSize = graphics.MeasureString(separateLinesMethods[i], font[3]);

                    if (stringMethodsSize.Width > longestSizeMethods)
                    {
                        longestSizeMethods = (int)stringMethodsSize.Width;
                    }
                }
            }

            RectangleWidth = 100;

            if (RectangleWidth < longestSizeName)
            {
                RectangleWidth = longestSizeName;
            }
            if (RectangleWidth < longestSizeField)
            {
                RectangleWidth = longestSizeField;
            }
            if (RectangleWidth < longestSizeProperty)
            {
                RectangleWidth = longestSizeProperty;
            }
            if (RectangleWidth < longestSizeMethods)
            {
                RectangleWidth = longestSizeMethods;
            }

            return RectangleWidth;
        }

        public void Transform(Point e)
        {
            //if (Points.Count[0].X = e.X
        }

        public bool IsHovered(Point point)
        {
            throw new NotImplementedException();
        }

        public void Select()
        {
            throw new NotImplementedException();
        }
    }
}
