using Project_UML.Core.Interfaces;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Project_UML.Core.MousHandlers
{
    public class MouseHandlerOnSelection : IMouseHandler
    {
        private Pen _pen = new Pen(Color.Black, 1) { DashStyle = DashStyle.Dash };
        public bool IsTapped { get; set; }
        public CoreUML CoreUML { get; set; } = CoreUML.GetCoreUML();
        public Point StartPoint { get; set; }
        public void MouseDown(Point e)
        {
            StartPoint = new Point(e.X, e.Y);
            IsTapped = true;
            CoreUML.SelectedFigures.Clear();
            //CoreUML.SelectedFigures.f
            foreach (IFigure figure in CoreUML.Figures)
            {
                if (figure.CheckSelection(StartPoint, StartPoint, 2))
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
            if (IsTapped)
            {
                int minX;
                int maxX;
                int minY;
                int maxY;
                if (StartPoint.X > e.X)
                {
                    maxX = StartPoint.X;
                    minX = e.X;
                }
                else
                {
                    minX = StartPoint.X;
                    maxX = e.X;
                }
                if (StartPoint.Y > e.Y)
                {
                    maxY = StartPoint.Y;
                    minY = e.Y;
                }
                else
                {
                    minY = StartPoint.Y;
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
            IsTapped = false;
        }

        private void DrawRectangleOfSelection(Point e)
        {
            Point startPoint = new Point();
            if (StartPoint.X > e.X)
            {
                startPoint.X = e.X;
            }
            else
            {
                startPoint.X = StartPoint.X;
            }
            if (StartPoint.Y > e.Y)
            {
                startPoint.Y = e.Y;
            }
            else
            {
                startPoint.Y = StartPoint.Y;
            }

            CoreUML.Graphics.DrawRectangle(_pen, startPoint.X, startPoint.Y, Math.Abs(e.X - StartPoint.X), Math.Abs(e.Y - StartPoint.Y));
        }

    }
}

