using Project_UML.Core.Boxes;
using Project_UML.Core.FigureFactory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.MousHandlers
{
    public class MouseHandlerOnDrawRectangle : IMouseHandler
    {
        private bool _isTapped;
        private Point startPoint;
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private AbstractBox _newBox;
        IFigureFactory FigureFactory { get; set; }
        public MouseHandlerOnDrawRectangle(IFigureFactory factory)
        {
            FigureFactory = factory;
        }
        public void MouseDown(Point e)
        {
            _newBox = (AbstractBox)FigureFactory.GetFigure(_coreUML.DefaultColor, (int)_coreUML.DefaultWidth);
            _newBox.AddPoints(e);
            _coreUML.Figures.Add(_newBox);
            _coreUML.SwitchToDrawInTmp();
            _newBox.Draw(_coreUML.Graphics);
            _coreUML.BitmapMain = (Bitmap)_coreUML.BitmapTmp.Clone();
            _coreUML.SelectedFigures.Clear();
            _coreUML.SelectedFigures.Add(_newBox);
            _coreUML.DrawSelectionOfFigures();
            _coreUML.PictureBox.Image = _coreUML.BitmapTmp;

        }

        public void MouseHover(Point e)
        {
            throw new NotImplementedException();
        }

        public void MouseMove(Point e)
        {
          
        }

        public void MouseUp(Point e)
        {
          
        }
    }
}
