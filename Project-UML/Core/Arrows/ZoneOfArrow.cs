using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Enum;

namespace Project_UML.Core.Arrows
{
    public class ZoneOfArrow
    {
        public ZoneType ZoneType;
        public int IndexOfStartPoint;
        public int IndexOfEndPoint;
        public Axis Axis;

        public ZoneOfArrow()
        {
        }

        public ZoneOfArrow(ZoneType zoneType)
        {
            ZoneType = zoneType;
        }

        public ZoneOfArrow(int indexOfStartPoint, int indexOfEndPoint, Axis axis, ZoneType zoneType)
        {
            IndexOfStartPoint = indexOfStartPoint;
            IndexOfEndPoint = indexOfEndPoint;
            Axis = axis;
            ZoneType = zoneType;
        }
    }
}

