using Project_UML.Core.DataProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.DataProject.Structure
{
    public struct StructPoints : IPoint
    {
        public int Point_X { get; set; }
        public int Point_Y { get; set; }

        public StructPoints(Point pont)
        {
            Point_X = pont.X;
            Point_Y = pont.Y;
        }
    }
}
