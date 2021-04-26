using Project_UML.Core.Boxes;
using Project_UML.Core.FigureFactory;
using System;
using System.Drawing;

namespace Project_UML.Core.MousHandlers
{
    public class MouseHandlerOnDrawRectangle : IMouseHandler
    {
        private AbstractBox _newBox;
        public bool IsTapped { get; set; }
        public CoreUML CoreUML { get; set; } = CoreUML.GetCoreUML();
        public Point StartPoint { get; set; }
        public IFigureFactory FigureFactory { get; set; }
        public MouseHandlerOnDrawRectangle(IFigureFactory factory)
        {
            FigureFactory = factory;
        }
        public void MouseDown(Point e)
        {
            _newBox = (AbstractBox)FigureFactory.GetFigure(CoreUML.DefaultColor, (int)CoreUML.DefaultWidth);
            _newBox.AddPoints(e);
            CoreUML.Figures.Add(_newBox);
            CoreUML.SwitchToDrawInTmp();
            _newBox.Draw(CoreUML.Graphics);
            CoreUML.BitmapMain = (Bitmap)CoreUML.BitmapTmp.Clone();
            CoreUML.SelectedFigures.Clear();
            CoreUML.SelectedFigures.Add(_newBox);
            CoreUML.DrawSelectionOfFigures();
            CoreUML.PictureBox.Image = CoreUML.BitmapTmp;
        }

        public void MouseHover(Point e)
        { 

        }

        public void MouseMove(Point e)
        {
          
        }

        public void MouseUp(Point e)
        {
          
        }
    }
}
