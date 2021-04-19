using Project_UML.Core.Arrows;
using Project_UML.Core.Interfaces.Get;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core
{
    public class ConnectionPoint
    {
        public Point Point { get; set; }
        public Axises Axis { get; set; }

        public ConnectionPoint()
        {
        }

        public ConnectionPoint(Point point, Axises axis)
        {
            Point = point;
            Axis = axis;
        }
    }
}
