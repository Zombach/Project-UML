using Project_UML.Core.Arrows;
using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.FigureFactory
{
    public class CompositionArrowFactory : IFigureFactory
    {
        public IFigure GetFigure(Color color, int width)
        {
            return new CompositionArrow(color, width);
        }
    }
}
