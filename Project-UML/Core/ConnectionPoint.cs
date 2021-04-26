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
#pragma warning disable CS0659 // Тип переопределяет Object.Equals(object o), но не переопределяет Object.GetHashCode()
    public class ConnectionPoint
#pragma warning restore CS0659 // Тип переопределяет Object.Equals(object o), но не переопределяет Object.GetHashCode()
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
            ConnectionPoint connectionPoint = (ConnectionPoint)obj;
            if (this.Axis != connectionPoint.Axis
            || this.Zone != connectionPoint.Zone
            || this.DistanceInPercents != connectionPoint.DistanceInPercents)
            {
                return false;
            }
            return true;
        }
    }
}
