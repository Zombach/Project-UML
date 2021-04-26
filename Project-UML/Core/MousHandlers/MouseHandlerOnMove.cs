using Project_UML.Core.Arrows;
using Project_UML.Core.Boxes;
using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.MousHandlers
{
    class MouseHandlerOnMove : IMouseHandler
    {
        public bool IsTapped { get; set; }
        public CoreUML CoreUML { get; set; } = CoreUML.GetCoreUML();
        public Point StartPoint { get; set; }

        private List<AbstractArrow> _tmpArrows = new List<AbstractArrow>();

        public void MouseDown(Point e)
        {
            StartPoint = e;
            foreach (IFigure figure in CoreUML.SelectedFigures)
            {
                CoreUML.Figures.Remove(figure);
                if (figure is AbstractArrow)
                {
                    _tmpArrows.Remove((AbstractArrow)figure);
                }
                if (figure is AbstractBox)
                {
                    foreach (DataCommon dataCommon in figure.DataCommon)
                    {
                        if (CoreUML.Figures.Remove(dataCommon.Arrow))
                        {
                            _tmpArrows.Add((AbstractArrow)dataCommon.Arrow);
                        }
                    }
                }
                IsTapped = true;

            }
            if (IsTapped)
            {
                CoreUML.UpdPicture();
                CoreUML.SwitchToDrawInTmp();
                foreach (IFigure figure in CoreUML.SelectedFigures)
                {
                    figure.Draw(CoreUML.Graphics);
                    figure.Select(CoreUML.Graphics);
                }
            }
        }

        public void MouseHover(Point e)
        {
            throw new NotImplementedException();
        }

        public void MouseMove(Point e)
        {
            if (IsTapped)
            {
                CoreUML.SwitchToDrawInTmp();
                foreach (IFigure figure in CoreUML.SelectedFigures)
                {
                    figure.Move(e.X - StartPoint.X, e.Y - StartPoint.Y);
                    figure.Draw(CoreUML.Graphics);
                    figure.Select(CoreUML.Graphics);
                }
                foreach (AbstractArrow arrow in _tmpArrows)
                {
                    arrow.Draw(CoreUML.Graphics);
                }
                StartPoint = e;
                CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
            }
        }

        public void MouseUp(Point e)
        {
            if (IsTapped)
            {
                CoreUML.SwitchToDrawInTmp();
                foreach (IFigure figure in CoreUML.SelectedFigures)
                {
                    CoreUML.Figures.Add(figure);
                    figure.Draw(CoreUML.Graphics);
                }
                foreach (AbstractArrow arrow in _tmpArrows)
                {
                    CoreUML.Figures.Add(arrow);
                    arrow.Draw(CoreUML.Graphics);
                }
                CoreUML.BitmapMain = CoreUML.BitmapTmp;
                CoreUML.DrawSelectionOfFigures();
                IsTapped = false;
            }
        }
    }
}
