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

        //private DataCommon _dataCommon = new DataCommon();
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
                //_newArrow.DataCommon.Add(new DataCommon(_newArrow));
                //_newArrow.DataCommon[0].FirstPoint = e;
                //foreach (IFigure figure in CoreUML.Figures)
                //{
                //    if (figure is AbstractBox)
                //    {
                //        if (figure.CheckSelection(e, e, 0))
                //        {
                //            _newArrow.DataCommon[0].FirstBox = figure;
                //            break;
                //        }
                //    }
                //}
            }

        }

        public void MouseMove(Point e)
        {
            if (IsTapped)
            {
                //if (!(_newArrow.DataCommon[0].FirstBox is null))
                //{
                //    ConnectionPoint startConnectionPoint = _newArrow.DataCommon[0].FirstBox.GetConnectionPoint(e);
                //    _newArrow.DataCommon[0].FirstPoint = startConnectionPoint.Point;
                //    _newArrow.StartDirectionAxis = startConnectionPoint.Axis;
                //}
                CoreUML.SwitchToDrawInTmp();
                _newArrow.UpdStartPoint(e);
                _newArrow.HookEndPointToFigure(e);
                //foreach (IFigure figure in CoreUML.Figures)
                //{
                //    if (figure is AbstractBox && figure != _newArrow.DataCommon[0].FirstBox)
                //    {
                //        if (figure.CheckSelection(e, e, 0))
                //        {
                //            _newArrow.DataCommon[0].LastBox = figure;
                //            ConnectionPoint endConnectionPoint = figure.GetConnectionPoint(_newArrow.DataCommon[0].FirstPoint);
                //            _newArrow.DataCommon[0].LastPoint = endConnectionPoint.Point;
                //            _newArrow.EndDirectionAxis = endConnectionPoint.Axis;
                //            break;
                //        }
                //    }
                //    _newArrow.DataCommon[0].LastBox = null;
                //}
                //if (_newArrow.DataCommon[0].LastBox == null)
                //{
                //    _newArrow.DataCommon[0].LastPoint = e;
                //}
                //_newArrow.GetPoints(_newArrow.DataCommon[0].FirstPoint, _newArrow.DataCommon[0].LastPoint);
                _newArrow.Draw(CoreUML.Graphics);
                CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
            }
        }

        public void MouseUp(Point e)
        {
            if (IsTapped)
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
                    CoreUML.WriteLogsActs(null, false);
                    CoreUML.Figures.Add(_newArrow);
                    CoreUML.WriteLogsActs(_newArrow, true);
                    CoreUML.SelectedFigures.Clear();
                    CoreUML.SelectedFigures.Add(_newArrow);
                    CoreUML.DrawSelectionOfFigures();
                    //_dataCommon.Write(e, false, sender);
                    //AddArrowToListCommonPoints();
                    IsTapped = false;
                    CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
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
