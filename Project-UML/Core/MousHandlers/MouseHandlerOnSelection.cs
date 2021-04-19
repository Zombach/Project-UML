using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.MousHandlers
{
    public class MouseHandlerOnSelection : IMouseHandler
    {
        private bool _isTapped;
        private Point _pointTmp;
        public CoreUML CoreUML = CoreUML.GetCoreUML();
        Pen _pen = new Pen(Color.Black, 1) { DashStyle = DashStyle.Dash };
        public void MouseDown(Point e)
        {
            _pointTmp = new Point(e.X, e.Y);
            _isTapped = true;
            CoreUML.SelectedFigures.Clear();
            foreach (IFigure figure in CoreUML.Figures)
            {
                if (figure.CheckSelection(_pointTmp, _pointTmp, 2))
                {
                    CoreUML.SelectedFigures.Add(figure);
                    return;
                }
            }
        }

        public void MouseHover(Point e)
        {

        }

        public void MouseMove(Point e)
        {
            if (_isTapped)
            {
                int minX;
                int maxX;
                int minY;
                int maxY;
                if (_pointTmp.X > e.X)
                {
                    maxX = _pointTmp.X;
                    minX = e.X;
                }
                else
                {
                    minX = _pointTmp.X;
                    maxX = e.X;
                }
                if (_pointTmp.Y > e.Y)
                {
                    maxY = _pointTmp.Y;
                    minY = e.Y;
                }
                else
                {
                    minY = _pointTmp.Y;
                    maxY = e.Y;
                }

                CoreUML.SelectedFigures.Clear();
                foreach (IFigure figure in CoreUML.Figures)
                {
                    if (figure.CheckSelection(new Point(minX, minY), new Point(maxX, maxY)))
                    {
                        CoreUML.SelectedFigures.Add(figure);
                    }
                }
                CoreUML.SwitchToDrawInTmp();
                CoreUML.DrawSelectionOfFigures();
                DrawRectangleOfSelection(e);
                CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
            }
        }

        public void MouseUp(Point e)
        {
            CoreUML.SwitchToDrawInTmp();
            CoreUML.DrawSelectionOfFigures();
            CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
            _isTapped = false;
        }

        private void DrawRectangleOfSelection(Point e)
        {
            Point startPoint = new Point();
            if (_pointTmp.X > e.X)
            {
                startPoint.X = e.X;
            }
            else
            {
                startPoint.X = _pointTmp.X;
            }
            if (_pointTmp.Y > e.Y)
            {
                startPoint.Y = e.Y;
            }
            else
            {
                startPoint.Y = _pointTmp.Y;
            }

            CoreUML.Graphics.DrawRectangle(_pen, startPoint.X, startPoint.Y, Math.Abs(e.X - _pointTmp.X), Math.Abs(e.Y - _pointTmp.Y));
        }

    }
}

