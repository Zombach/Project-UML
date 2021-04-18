using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core
{
    public class DataCommon
    {
        public IFigure Arrow { get; set; }
        public Point FirstPoint { get; set; }
        public Point LastPoint { get; set; }
        public IFigure FirstBox { get; set; }
        public IFigure LastBox { get; set; }
    }
}
