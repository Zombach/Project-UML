using Project_UML.Core.Arrows;
using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core
{
    [Serializable]
    public class DataCommon
    {
        public IFigure Arrow { get; set; }
        public ConnectionPoint FirstPoint { get; set; }
        public ConnectionPoint LastPoint { get; set; }
        public IFigure FirstBox { get; set; }
        public IFigure LastBox { get; set; }

        public DataCommon()
        {
            Arrow = null;
            FirstBox = null;
            LastBox = null;
        }
        public DataCommon(AbstractArrow arrow)
        {
            Arrow = arrow;
            FirstBox = null;
            LastBox = null;
        }

    }
}
