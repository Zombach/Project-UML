using Project_UML.Core.Arrows;
using Project_UML.Core.Forms;
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
        public Point FirstPoint { get; set; }
        public Point LastPoint { get; set; }
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



        public void Write(Point point, bool isFirstPoint, object sender)
        {
            if (isFirstPoint)
            {                
                FirstBox = (IFigure)sender;                
                FirstPoint = point;
            }
            else
            {                
                LastBox = (IFigure)sender;                
                LastPoint = point;
            }
        }
    }
}
