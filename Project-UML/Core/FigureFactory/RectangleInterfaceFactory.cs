using Project_UML.Core.Boxes;
using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.FigureFactory
{
    public class RectangleInterfaceFactory : IFigureFactory
    {
        public IFigure GetFigure(Color color, int width)
        {
            return new RectangleInterface(color, width);
        }
    }
}
