using Project_UML.Core.DataProject.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Arrows
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class AssociationArrow : AbstractArrow
    {
        public AssociationArrow() : base()
        {
        }

        public AssociationArrow(Color color, int width) : base(color, width)
        {
        }

        public AssociationArrow(Point startPoint, Point endPoint, Axis startDirectionAxis
            , Axis endDirectionAxis) : base(startPoint, endPoint, startDirectionAxis, endDirectionAxis)
        {           
        }
        public AssociationArrow(StructArrow arrow) : base(arrow)
        {

        }

        public override void SetEndCap()
        {
            int tmp;
            if (_pen.Width == 1)
            {
                tmp = 2;
            }
            else
            {

                tmp = 1;
            }
            GraphicsPath _graphicsPath = new GraphicsPath();
            _graphicsPath.AddLine(new Point(0, 0), new Point(10 / tmp, -24 / tmp));
            _graphicsPath.AddLine(new Point(10 / tmp, -24 / tmp), new Point(0, 0));
            _graphicsPath.AddLine(new Point(0, 0), new Point(-10 / tmp, -24 / tmp));
            _graphicsPath.AddLine(new Point(-10 / tmp, -24 / tmp), new Point(0, 0));
            _pen.CustomEndCap = new CustomLineCap(null, _graphicsPath, LineCap.Custom);
        }

        public override void ChangeWidth(int width)
        {
            _pen.Width = width;
        }
    }
}
