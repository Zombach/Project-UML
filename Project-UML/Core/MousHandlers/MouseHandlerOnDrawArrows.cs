using Project_UML.Core.Arrows;
using Project_UML.Core.Boxes;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.Forms;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Interfaces.Get;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.MousHandlers
{
    public class MouseHandlerOnDrawArrows : IMouseHandler
    {
        private bool _isTapped;
        private Point startPoint;
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private AbstractArrow _newArrow;
        IFigureFactory FigureFactory { get; set; }
        //private DataCommon _dataCommon = new DataCommon();
        public MouseHandlerOnDrawArrows(IFigureFactory figureFactory)
        {
            _isTapped = false;
            FigureFactory = figureFactory;


        }

        public void MouseDown(Point e)
        {
            if (!_isTapped)
            {
                startPoint = new Point(e.X, e.Y);
                _isTapped = true;
                _newArrow = (AbstractArrow)FigureFactory.GetFigure(_coreUML.DefaultColor, (int)_coreUML.DefaultWidth);
                _newArrow.DataCommon.Add(new DataCommon(_newArrow));
                _newArrow.DataCommon[0].FirstPoint = e;
                foreach (IFigure figure in _coreUML.Figures)
                {
                    if (figure is AbstractBox)
                    {
                        if (figure.CheckSelection(e, e, 0))
                        {
                            _newArrow.DataCommon[0].FirstBox = figure;

                            break;
                        }
                    }
                }


                //_dataCommon.Write(e, true, sender);
            }

        }

        public void MouseMove(Point e)
        {
            if (_isTapped)
            {
                if (!(_newArrow.DataCommon[0].FirstBox is null))
                {
                    ConnectionPoint startConnectionPoint = _newArrow.DataCommon[0].FirstBox.GetConnectionPoint(e);
                    _newArrow.DataCommon[0].FirstPoint = startConnectionPoint.Point;
                    _newArrow.StartDirectionAxis = startConnectionPoint.Axis;
                }
                _coreUML.SwitchToDrawInTmp();

                foreach (IFigure figure in _coreUML.Figures)
                {
                    if (figure is AbstractBox && figure != _newArrow.DataCommon[0].FirstBox)
                    {
                        if (figure.CheckSelection(e, e, 0))
                        {
                            _newArrow.DataCommon[0].LastBox = figure;
                            ConnectionPoint endConnectionPoint = figure.GetConnectionPoint(_newArrow.DataCommon[0].FirstPoint);
                            _newArrow.DataCommon[0].LastPoint = endConnectionPoint.Point;
                            _newArrow.EndDirectionAxis = endConnectionPoint.Axis;
                            break;
                        }
                    }
                    _newArrow.DataCommon[0].LastBox = null;
                }
                if (_newArrow.DataCommon[0].LastBox == null)
                {
                    _newArrow.DataCommon[0].LastPoint = e;
                }
                _newArrow.GetPoints(_newArrow.DataCommon[0].FirstPoint, _newArrow.DataCommon[0].LastPoint);
                _newArrow.Draw(_coreUML.Graphics);
                _coreUML.PictureBox.Image = _coreUML.BitmapTmp;
            }
        }

        public void MouseUp(Point e)
        {
            if (_isTapped)
                if (startPoint.X != e.X || startPoint.Y != e.Y)
                {
                    if (!(_newArrow.DataCommon[0].FirstBox is null))
                    {
                        _newArrow.DataCommon[0].FirstBox.DataCommon.Add(_newArrow.DataCommon[0]);
                    }
                    if (!(_newArrow.DataCommon[0].LastBox is null))
                    {
                        _newArrow.DataCommon[0].LastBox.DataCommon.Add(_newArrow.DataCommon[0]);
                    }
                    _coreUML.BitmapMain = (Bitmap)_coreUML.BitmapTmp.Clone();
                    _coreUML.Figures.Add(_newArrow);
                    _coreUML.SelectedFigures.Clear();
                    _coreUML.SelectedFigures.Add(_newArrow);
                    _coreUML.DrawSelectionOfFigures();
                    //_dataCommon.Write(e, false, sender);
                    //AddArrowToListCommonPoints();
                    _isTapped = false;
                    _coreUML.PictureBox.Invalidate();
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
            throw new NotImplementedException();
        }
    }
}
