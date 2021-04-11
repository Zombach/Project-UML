using Project_UML.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_UML
{
    public abstract class AbstractBox : IDraw, IChangeColor, IChangeWidth, ISelect, IisHovered, IMove
    {
        protected Pen _pen = new Pen(Color.Blue, 5);

        private int widthFigure { get; set; }
        private int heightFigure { get; set; }
        public Point Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private List<Point> Points { set; get; }

        public void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, Location.X, Location.Y, GetWidth(widthFigure), GetHeight(heightFigure));

        }
        public void ChangeColor(Color color)
        {
            _pen.Color = color;
        }

        public void ChangeWidth(int width)
        {
            _pen.Width = width;
        }

        public int GetHeight(int heightFigure)
        {
            return heightFigure;
        }

        public int GetWidth(int widthFigure)
        {
            return widthFigure;
        }

        public void IsHovered(Point point)
        {
            throw new NotImplementedException();
        }

        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }

        public void Select()
        {
            throw new NotImplementedException();
        }


    }
}
