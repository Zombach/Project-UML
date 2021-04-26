using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Project_UML.Core.Enum;
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
        public AssociationArrow(IFigure figure) : base(figure)
        {

        }

        public override void SetEndCap()
        {
            int tmp= (int)_pen.Width;
            GraphicsPath _graphicsPath = new GraphicsPath();
            _graphicsPath.AddLine(new Point(0, 0), new Point(12 / tmp, -16 / tmp));
            _graphicsPath.AddLine(new Point(12 / tmp, -16 / tmp), new Point(0, 0));
            _graphicsPath.AddLine(new Point(0, 0), new Point(-12 / tmp, -16 / tmp));
            _graphicsPath.AddLine(new Point(-12 / tmp, -16 / tmp), new Point(0, 0));
            _pen.CustomEndCap = new CustomLineCap(null, _graphicsPath, LineCap.Custom);

            #region OLD CODE
            //if (_pen.Width == 1)
            //{
            //    tmp = 1;
            //    _graphicsPath.AddLine(new Point(0, 0), new Point(12 / tmp, -30 / tmp));
            //    _graphicsPath.AddLine(new Point(12 / tmp, -30 / tmp), new Point(0, 0));
            //    _graphicsPath.AddLine(new Point(0, 0), new Point(-12 / tmp, -30 / tmp));
            //    _graphicsPath.AddLine(new Point(-12 / tmp, -30 / tmp), new Point(0, 0));
            //}
            //else
            //{
            //    tmp = 2;
            //    _graphicsPath.AddLine(new Point(0, 0), new Point(12 / tmp, -30 / tmp));
            //    _graphicsPath.AddLine(new Point(12 / tmp, -30 / tmp), new Point(0, 0));
            //    _graphicsPath.AddLine(new Point(0, 0), new Point(-12 / tmp, -30 / tmp));
            //    _graphicsPath.AddLine(new Point(-12 / tmp, -30 / tmp), new Point(0, 0));

            //}
            //_pen.CustomEndCap = new CustomLineCap(null, _graphicsPath, LineCap.Custom);
            #endregion
        }

        public override void ChangeWidth(int width)
        {
            _pen.Width = width;
            SetEndCap();
        }
    }
}
