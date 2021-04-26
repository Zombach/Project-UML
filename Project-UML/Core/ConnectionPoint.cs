using Project_UML.Core.Arrows;
using Project_UML.Core.Boxes;
using Project_UML.Core.Interfaces.Get;
using Project_UML.Core.Enum;
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
        public Axis Axis { get; set; }
        public BoxZones Zone { get; set; }
        public int DistanceInPercents { get; set; }

        public ConnectionPoint()
        {
        }

        public ConnectionPoint(Axis axis, BoxZones zone, int distanceInPercents)
        {
            Axis = axis;
            Zone = zone;
            DistanceInPercents = distanceInPercents;
        }
        public override bool Equals(object obj)
        {
            ConnectionPoint ConnectionPoint = (ConnectionPoint)obj;

            if (this.Axis != ConnectionPoint.Axis
                || this.Zone != ConnectionPoint.Zone
                || this.DistanceInPercents != ConnectionPoint.DistanceInPercents)
            {
                return false;
            }
            return true;
        }
    }
}
