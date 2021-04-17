using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.MousHandlers
{
    interface IMouseHandler
    {
        void MouseDown(Point e);
        void MouseUp(Point e);
        void MouseMove(Point e);
        void MouseHover(Point e);
    }
}
