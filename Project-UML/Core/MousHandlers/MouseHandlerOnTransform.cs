using Project_UML.Core.Arrows;
using Project_UML.Core.Boxes;
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
            StartPoint = e;
            CoreUML.SelectedFigures.Clear();
            for (int i = 0; i < CoreUML.Figures.Count; i++)
            {
                if (CoreUML.Figures[i].CheckSelection(e, e, 2))
                {
                    IsTapped = true;
                    CoreUML.SelectedFigures.Add(CoreUML.Figures[i]);
                    CoreUML.Figures.Remove(CoreUML.Figures[i]);
                    break;
                }
            }
            if (IsTapped)
            {
                CoreUML.UpdPicture();
                CoreUML.SwitchToDrawInTmp();
                foreach (IFigure figure in CoreUML.SelectedFigures)
                {
                    figure.Draw(CoreUML.Graphics);
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
                CoreUML.SwitchToDrawInTmp();
                foreach (IFigure figure in CoreUML.SelectedFigures)
                {
                    figure.Transform(e);
                    figure.Draw(CoreUML.Graphics);
                    if (figure is AbstractArrow arrow)
                    {
                        if (arrow.SelectedZone.ZoneType == ZoneType.FirstPoint && !(arrow.DataCommon[0].FirstBox is null))
                        {
                            AbstractBox.DrawConnectionPoint(CoreUML.Graphics, arrow.Points[0]);
                        }
                        else if (arrow.SelectedZone.ZoneType == ZoneType.LastPoint && !(arrow.DataCommon[0].LastBox is null))
                        {
                            AbstractBox.DrawConnectionPoint(CoreUML.Graphics, arrow.Points[arrow.Points.Count - 1]);
                        }
                    }
                    CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
                }
            }
        }

        public void MouseUp(Point e)
        {
            if (IsTapped)
            {
                foreach (IFigure figure in CoreUML.SelectedFigures)
                {
                    CoreUML.Figures.Add(figure);
                }
                CoreUML.UpdPicture();
                CoreUML.DrawSelectionOfFigures();
                CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
                IsTapped = false;
            }
        }
    }
}
