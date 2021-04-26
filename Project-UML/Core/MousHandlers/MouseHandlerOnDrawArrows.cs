using Project_UML.Core.Arrows;
using Project_UML.Core.Boxes;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.Interfaces;
using System;
using System.Drawing;

namespace Project_UML.Core.MousHandlers
{
    public class MouseHandlerOnDrawArrows : IMouseHandler
    {
        public bool IsTapped { get; set; }
        public CoreUML CoreUML { get; set; } = CoreUML.GetCoreUML();
        public Point StartPoint { get; set; }
        private AbstractArrow _newArrow;
        IFigureFactory FigureFactory { get; set; }

        public MouseHandlerOnDrawArrows(IFigureFactory figureFactory)
        {
            IsTapped = false;
            FigureFactory = figureFactory;
        }

        public void MouseDown(Point e)
        {
            if (!IsTapped)
            {
                StartPoint = new Point(e.X, e.Y);
                IsTapped = true;
                _newArrow = (AbstractArrow)FigureFactory.GetFigure(CoreUML.DefaultColor, CoreUML.DefaultWidth);
                _newArrow.GetPoints(e, e);
                _newArrow.HookStartPointToFigure(e);
            }

        }

        public void MouseMove(Point e)
        {
            if (IsTapped)
            {
                CoreUML.SwitchToDrawInTmp();
                _newArrow.HookEndPointToFigure(e);
                _newArrow.Draw(CoreUML.Graphics);
                if (!(_newArrow.DataCommon[0].LastBox is null))
                {
                    AbstractBox box = (AbstractBox)_newArrow.DataCommon[0].LastBox;
                    AbstractBox.DrawConnectionPoint(CoreUML.Graphics, box.GetCordinatsOfConnectionPoint(_newArrow.DataCommon[0].LastPoint));
                }
                CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
            }
            else if (_newArrow is null)
            {
                foreach (IFigure figure in CoreUML.Figures)
                {
                    if (figure is AbstractBox box && figure.CheckSelection(e, e, 7))
                    {
                        CoreUML.DrawSelectionOfFigures();
                        AbstractBox.DrawConnectionPoint(CoreUML.Graphics, box.GetCordinatsOfConnectionPoint(box.GetConnectionPoint(e, e)));
                        break;
                    }
                }
                CoreUML.DrawSelectionOfFigures();
                CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
            }
        }

        public void MouseUp(Point e)
        {
            if (IsTapped)
            {
                if (StartPoint.X != e.X || StartPoint.Y != e.Y)
                {
                    if (!(_newArrow.DataCommon[0].FirstBox is null))
                    {
                        _newArrow.DataCommon[0].FirstBox.DataCommon.Add(_newArrow.DataCommon[0]);
                    }
                    if (!(_newArrow.DataCommon[0].LastBox is null))
                    {
                        _newArrow.DataCommon[0].LastBox.DataCommon.Add(_newArrow.DataCommon[0]);
                    }
                    CoreUML.BitmapMain = CoreUML.BitmapTmp;
                    CoreUML.WriteLogs(null, false);
                    CoreUML.Figures.Add(_newArrow);
                    CoreUML.WriteLogs(_newArrow, true);
                    CoreUML.SelectedFigures.Clear();
                    CoreUML.SelectedFigures.Add(_newArrow);
                    CoreUML.DrawSelectionOfFigures();
                    IsTapped = false;
                    CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
                    _newArrow = null;
                }
            }
        }

        /// <summary>
        /// Необходимо перезаписать в CoreUML.List<IFigure> Figures
        /// </summary>
        /// <param name="dataPoints"></param>
        //private void AddArrowToListCommonPoints()
        //{
        //    if (_dataCommon.FirstBox != null)
        //    {
        //        AbstractBox FirstBox = (AbstractBox)_dataCommon.FirstBox;
        //        FirstBox.DataCommon.Add(_dataCommon);
        //    }

        //    if (_dataCommon.LastBox != null)
        //    {
        //        AbstractBox LastBox = (AbstractBox)_dataCommon.LastBox;
        //        LastBox.DataCommon.Add(_dataCommon);
        //    }

        //    AbstractArrow arrow = (AbstractArrow)_dataCommon.Arrow;
        //    //arrow.DataCommon.Add(_dataCommon);
        //}

        public void MouseHover(Point e)
        {
        }
    }
}
