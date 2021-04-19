using Project_UML.Core.Arrows;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.Forms;
using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.MousHandlers
{
    public class MouseHandlerOnDrawArrows : IMouseHandler
    {
        private bool _isTapped;
        private Point startPoint;
        public CoreUML CoreUML = CoreUML.GetCoreUML();
        private AbstractArrow _newArrow;
        IFigureFactory FigureFactory { get; set; }
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
                _newArrow = (AbstractArrow)FigureFactory.GetFigure(CoreUML.Color, CoreUML.Width);
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
                    _isTapped = false;
                    CoreUML.PictureBox.Invalidate();
                }
        }

        public void MouseHover(Point e)
        {
            throw new NotImplementedException();
        }
    }
}
