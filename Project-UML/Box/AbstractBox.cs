using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Project.Box
{
    abstract class AbstractBox : IFigure
    {
        private Pen _pen;

        public Point Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private List<Point> Points { set; get; }

        public void ChangeColor(Color color)
        {
            throw new NotImplementedException();
        }

        public void ChangeWidth(int width)
        {
            throw new NotImplementedException();
        }

        public int GetHeight()
        {
            throw new NotImplementedException();
        }

        public int GetWidth()
        {
            throw new NotImplementedException();
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

        void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, Location.X, Location.Y, GetWidth(), GetHeight());

        }

        void IFigure.Draw(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
