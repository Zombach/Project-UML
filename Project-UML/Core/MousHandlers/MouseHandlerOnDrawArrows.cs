using Project_UML.Core.FigureFactory;
using Project_UML.Core.Forms;
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
        private Point _point;
        public NewProject Form;
        IFigureFactory FigureFabric { get; set; }
        public MouseHandlerOnDrawArrows(IFigureFactory figureFabric, NewProject form)
        {
            _isTapped = false;
            FigureFabric = figureFabric;
            Form = form;
        }

        public void MouseDown(Point e)
        {
            _point = new Point(e.X, e.Y);
            _isTapped = true;
            FigureFabric.GetFigure(Form.butt;
        }

        public void MouseMove(Point e)
        {
            throw new NotImplementedException();
        }

        public void MouseUp(Point e)
        {
            throw new NotImplementedException();
        }
    }
}
