using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core
{
    public class DataPoints
    {
        public object FirstSendler { get; set; }
        public object EndSendler { get; set; }
        public Point FirstPoint { get; set; }
        public Point EndPoint { get; set; }

        public DataPoints()
        {
            FirstSendler = null;
            EndSendler = null;
            FirstPoint = new Point();
            EndPoint = new Point();
        }
        public DataPoints(object sendler, MouseEventArgs e, bool isFirstPoint)
        {
            if (isFirstPoint)
            {
                FirstSendler = sendler;
                FirstPoint = new Point(e.X, e.Y);
            } 
            else
            {
                EndSendler = sendler;
                EndPoint = new Point(e.X, e.Y);
            }
        }
    }
}
