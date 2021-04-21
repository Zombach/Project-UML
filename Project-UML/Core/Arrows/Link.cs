using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Arrows
{
    public class Link
    {
        public int IndexOfStartPoint;
        public int IndexOfEndPoint;
        public Axis Axis;
        public LinkType LinkType;

        public Link()
        { }

        public Link(int indexOfStartPoint, int indexOfEndPoint, Axis axis, LinkType linkType)
        {
            IndexOfStartPoint = indexOfStartPoint;
            IndexOfEndPoint = indexOfEndPoint;
            Axis = axis;
            LinkType = linkType;
        }
    }
}

