using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML._Core._Serialize
{
    public class SerializePoints
    {
        public int Point_X { get; set; }
        public int Point_Y { get; set; }

        public SerializePoints(int point_X, int point_Y)
        {
            Point_X = point_X;
            Point_Y = point_Y;
        }
    }
}
