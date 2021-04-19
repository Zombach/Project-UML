using Project_UML.Core.Arrows;
using Project_UML.Core.Boxes;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.Forms;
using Project_UML.Core.Interfaces;
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
        public CoreUML CoreUML = CoreUML.GetCoreUML();
        private AbstractArrow _newArrow;
        IFigureFactory FigureFactory { get; set; }
        private DataCommon _dataCommon = new DataCommon();
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
                _newArrow = (AbstractArrow)FigureFactory.GetFigure(CoreUML.DefaultColor, (int)CoreUML.DefaultWidth);
                //_dataCommon.Write(e, true, sender);
            }

        }

        public void MouseMove(Point e)
        {
            if (_isTapped)
            {
                CoreUML.SwitchToDrawInTmp();
                _newArrow.StartDirectionAxis = CoreUML.AxisStart;
                _newArrow.EndDirectionAxis = CoreUML.AxisEnd;
                _newArrow.GetPoints(startPoint, e);
                _newArrow.Draw(CoreUML.Graphics);
                CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
            }
        }

        public void MouseUp(Point e)
        {
            if (_isTapped)
                if (startPoint.X != e.X || startPoint.Y != e.Y)
                {
                    CoreUML.BitmapMain = (Bitmap)CoreUML.BitmapTmp.Clone();
                    CoreUML.Figures.Add(_newArrow);
                    CoreUML.SelectedFigures.Clear();
                    CoreUML.SelectedFigures.Add(_newArrow);
                    CoreUML.DrawSelectionOfFigures();
                    //_dataCommon.Write(e, false, sender);
                    AddArrowToListCommonPoints();
                    _isTapped = false;
                    CoreUML.PictureBox.Invalidate();
                }
        }

        /// <summary>
        /// Необходимо перезаписать в CoreUML.List<IFigure> Figures
        /// </summary>
        /// <param name="dataPoints"></param>
        private void AddArrowToListCommonPoints()
        {
            if (_dataCommon.FirstBox != null)
            {
                AbstractBox FirstBox = (AbstractBox)_dataCommon.FirstBox;
                FirstBox.DataCommon.Add(_dataCommon);
            }

            if (_dataCommon.LastBox != null)
            {
                AbstractBox LastBox = (AbstractBox)_dataCommon.LastBox;
                LastBox.DataCommon.Add(_dataCommon);
            }

            AbstractArrow arrow = (AbstractArrow)_dataCommon.Arrow;
            //arrow.DataCommon.Add(_dataCommon);
        }

        public void MouseHover(Point e)
        {
            throw new NotImplementedException();
        }
    }
}
