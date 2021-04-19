using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.MousHandlers
{
    public class MouseHandlerOnMove : IMouseHandler
    {
        private bool _isTapped;
        private Point startPoint;
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        public void MouseDown(Point e)
        {
            _isTapped = true;
            startPoint = e;
        }

        public void MouseHover(Point e)
        {
            throw new NotImplementedException();
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
