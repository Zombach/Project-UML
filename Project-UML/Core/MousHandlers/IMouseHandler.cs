using System.Drawing;

namespace Project_UML.Core.MousHandlers
{
    public interface IMouseHandler
    {
        bool IsTapped { get; set; }
        CoreUML CoreUML { get; set; }
        Point StartPoint { get; set; }
        void MouseDown(Point e);
        void MouseUp(Point e);
        void MouseMove(Point e);
        void MouseHover(Point e);
    }
}
