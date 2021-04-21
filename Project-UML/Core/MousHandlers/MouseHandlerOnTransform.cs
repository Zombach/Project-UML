using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Project_UML.Core.MousHandlers
{
    public class MouseHandlerOnTransform : IMouseHandler
    {
        public bool IsTapped { get; set; }
        public CoreUML CoreUML { get; set; } = CoreUML.GetCoreUML();
        public Point StartPoint { get; set; }
        public void MouseDown(Point e)
        {
            IsTapped = true;
            StartPoint = e;
            foreach (IFigure figure in CoreUML.SelectedFigures)
            {
                if (figure.CheckSelection(e, e, 2))
                {
                    CoreUML.Figures.Remove(figure);
                }
            }
            CoreUML.UpdPicture();
            CoreUML.SwitchToDrawInTmp();
            foreach (IFigure figure in CoreUML.SelectedFigures)
            {
                figure.Draw(CoreUML.Graphics);
            }
        }

        public void MouseHover(Point e)
        {
        }

        public void MouseMove(Point e)
        {
            if (IsTapped)
            {
                CoreUML.SwitchToDrawInTmp();
                foreach (IFigure figure in CoreUML.SelectedFigures)
                {
                    figure.Transform(e);
                    figure.Draw(CoreUML.Graphics);
                    figure.Select(CoreUML.Graphics);
                }
                CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
            }
            //if (!IsTapped)
            //{
            //foreach (IFigure figure in CoreUML.Figures)
            //{
            //    for (int i = 0; i < figure.Points.Count; i++)
            //    {                    
            //        Point currentPoint = figure.Points[i];
            //        currentPoint.X += e.X;
            //        currentPoint.Y += e.Y;
            //        figure.Points[i] = currentPoint;
            //    }
            //}
            //}
        }

        public void MouseUp(Point e)
        {
            IsTapped = false;
            foreach (IFigure figure in CoreUML.SelectedFigures)
            {
                CoreUML.Figures.Add(figure);
            }
            CoreUML.UpdPicture();
            CoreUML.DrawSelectionOfFigures();
            CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
        }
    }
}
