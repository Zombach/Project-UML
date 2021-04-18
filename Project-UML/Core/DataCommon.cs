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
    public class DataCommon
    {
        public IFigure Arrow { get; set; }
        public Point FirstPoint { get; set; }
        public Point LastPoint { get; set; }
        public IFigure FirstBox { get; set; }
        public IFigure LastBox { get; set; }

        public DataCommon(object sender, MouseEventArgs e, bool isFirstPoint)
        {
            //if (isFirstPoint)
            //{
            //    FirstBox = (IFigure)sender;
            //    FirstPoint = new Point(e.X, e.Y);
            //    LastBox = null;
            //    LastPoint = new Point();
            //}
            //else
            //{
            //    FirstBox = null;
            //    FirstPoint = new Point();
            //    LastBox = (IFigure)sender;
            //    LastPoint = new Point(e.X, e.Y);
            //}
        }
    }
}
