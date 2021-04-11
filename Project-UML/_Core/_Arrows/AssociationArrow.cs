using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML._Core._Arrows
{
    public class AssociationArrow : AbstractArrow
    {
        public AssociationArrow()
        {
            _pen = new Pen(Color.Black, 1);
            _pen.EndCap = LineCap.ArrowAnchor;
        }

        public AssociationArrow(Color color, int width)
        {
            _pen = new Pen(color, width);
            _pen.EndCap = LineCap.ArrowAnchor;

        }
        public AssociationArrow(Point startPoint, Point endPoint, Axises startDirectionAxis, Axises endDirectionAxis)
        {
            _pen = new Pen(Color.Black, 1);
            _pen.EndCap = LineCap.ArrowAnchor;

            Points = GetPoints(startPoint, endPoint);
            StartDirectionAxis = startDirectionAxis;
            EndDirectionAxis = endDirectionAxis;
        }

        public override void ChangeWidth(int width)
        {
            _pen.Width = width;
        }
    }
}
