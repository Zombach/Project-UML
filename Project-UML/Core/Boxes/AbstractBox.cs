﻿using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces.Get;
using Project_UML.Core.Interfaces.Logics;
using Project_UML.Core.Arrows;
using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.Interfaces.Draws;

namespace Project_UML.Core.Boxes
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public abstract class AbstractBox : IFigure, IGetFont, IChangeFont
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        /// <summary>
        /// Жестко заданы точки [0] - левая верхняя точка, [1] - правая нижняя точка
        /// </summary>
        public List<Point> Points { get; set; } = new List<Point>();
        public List<DataCommon> DataCommon { get; set; } = new List<DataCommon>();
        public List<DataText> DataText { get; set; } = new List<DataText>();
        protected Font Font { get; set; } = CoreUML.GetCoreUML().DefaultFont;
        public int RectangleWidth { get; set; } = 100;
        public int RectangleHeight { get; set; }
        protected int RectNameHeight { get; set; } = 20;
        protected int RectFieldHeight { get; set; } = 20;
        protected int RectPropertyHeight { get; set; } = 20;
        protected int RectMethodsHeight { get; set; } = 40;
        ///// <summary>
        /// List<string> RectangleText
        /// RectangleText[0] - name
        /// RectangleText[1] - field
        /// RectangleText[2] - property
        /// RectangleText[3] - methods
        /// </summary>
        public List<string> RectangleText = new List<string> {"Name", "Filed", "Property", "Methods"};
        protected Font font = new Font("Arial", 10);

        protected Pen _pen;
        protected Pen _selectionPen = new Pen(Color.DodgerBlue, 3);
        

        public AbstractBox(Color color, int width)
        {
            _pen = new Pen(color, width);
            RectangleWidth = 100;
            RectangleHeight = RectMethodsHeight + RectNameHeight + RectFieldHeight + RectPropertyHeight;
        }

        /// <summary>
        /// Конструктор для развертывания фигуры по структуре
        /// </summary>
        /// <param name="box"></param>
        public AbstractBox(StructBox box)
        {

        }

        public AbstractBox(IFigure figure )
        {
            AbstractBox box = (AbstractBox)figure;
            Points = new List<Point>();
            _pen = new Pen(box._pen.Color, box._pen.Width);
            for (int i = 0; i < box.Points.Count; i++)
            {
                Point point = new Point(box.Points[i].X - _coreUML.DefaultStep.X, box.Points[i].Y - _coreUML.DefaultStep.Y);
                Points.Add(point);
            }
            DataCommon = new List<DataCommon>();
            Font = box.Font;
            RectangleWidth = box.RectangleWidth;
            RectangleHeight = box.RectangleHeight;
            RectNameHeight = box.RectNameHeight;
            RectFieldHeight = box.RectFieldHeight;
            RectPropertyHeight = box.RectPropertyHeight;
            RectMethodsHeight = box.RectMethodsHeight;

        }


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

        public void ChangeFont(Font font)
        {
            Font = font;
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

        public float GetSize()
        {
            return 1f;
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

        public Point GetMiddlePoint()
        {
            return new Point((Points[0].X + Points[1].X) / 2, (Points[0].Y + Points[1].Y) / 2);
        }

        public ConnectionPoint GetConnectionPoint(Point point)
        {
            Point Middle = GetMiddlePoint();
            ConnectionPoint connectionPoint = new ConnectionPoint();
            int tmpX = Middle.X - point.X;
            int tmpY = Middle.Y - point.Y;

            if (Math.Abs(tmpX) < Math.Abs(tmpY))
            {
                connectionPoint.Axis = Axis.Y;
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
                connectionPoint.Axis = Axis.X;
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
        public void DrawSpecificRectangle(Graphics graphics, string rectText, Pen _pen, Font font, Brush brush, RectangleF rectF)
        {
            graphics.DrawString(rectText, font, brush, rectF);
            graphics.DrawRectangle(_pen, Rectangle.Round(rectF));
        }
        
        public void Transform(Point e)
        {
            throw new NotImplementedException();
        }

        public int CounterOfTextLinesInSpecificRectangle(string textFromSpecificRect)
        {
            string phrase = textFromSpecificRect;
            string[] separateLines = phrase.Split('\n');
            return separateLines.Length;
        }
        public int WidthOfRectangle(Graphics graphics, List<string> RectangleText, Font font)
        {
            SizeF stringNameSize = new SizeF();

            string phraseName = RectangleText[0];
            string[] separateLinesName = phraseName.Split('\n');

            stringNameSize = graphics.MeasureString(separateLinesName[0], font);
            int longestSizeName = (int)stringNameSize.Width;

            if (separateLinesName.Length > 0)
            {
                for (int i = 0; i < separateLinesName.Length; i++)
                {
                    stringNameSize = graphics.MeasureString(separateLinesName[i], font);

                    if (stringNameSize.Width > longestSizeName)
                    {
                        longestSizeName = (int)stringNameSize.Width;
                    }
                }
            }

            SizeF stringFieldSize = new SizeF();

            string phraseField = RectangleText[1];
            string[] separateLinesField = phraseField.Split('\n');

            stringFieldSize = graphics.MeasureString(separateLinesField[0], font);
            int longestSizeField = (int)stringFieldSize.Width;

            if (separateLinesField.Length > 0)
            {
                for (int i = 0; i < separateLinesField.Length; i++)
                {
                    stringFieldSize = graphics.MeasureString(separateLinesField[i], font);

                    if (stringFieldSize.Width > longestSizeField)
                    {
                        longestSizeField = (int)stringFieldSize.Width;
                    }
                }
            }

            SizeF stringPropertySize = new SizeF();

            string phraseProperty = RectangleText[2];
            string[] separateLinesProperty = phraseProperty.Split('\n');

            stringPropertySize = graphics.MeasureString(separateLinesProperty[0], font);
            int longestSizeProperty = (int)stringPropertySize.Width;

            if (separateLinesProperty.Length > 0)
            {
                for (int i = 0; i < separateLinesProperty.Length; i++)
                {
                    stringPropertySize = graphics.MeasureString(separateLinesProperty[i], font);

                    if (stringPropertySize.Width > longestSizeProperty)
                    {
                        longestSizeProperty = (int)stringPropertySize.Width;
                    }
                }
            }

            SizeF stringMethodsSize = new SizeF();

            string phraseMethods = RectangleText[3];
            string[] separateLinesMethods = phraseMethods.Split('\n');

            stringMethodsSize = graphics.MeasureString(separateLinesMethods[0], font);
            int longestSizeMethods = (int)stringMethodsSize.Width;

            if (separateLinesMethods.Length > 0)
            {
                for (int i = 0; i < separateLinesMethods.Length; i++)
                {
                    stringMethodsSize = graphics.MeasureString(separateLinesMethods[i], font);

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
    }
}
