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

        public DataPoints(object sender, MouseEventArgs e, bool isFirstPoint)
        {
            if (isFirstPoint)
            {
                FirstSendler = sender;
                FirstPoint = new Point(e.X, e.Y);
                EndSendler = null;
                EndPoint = new Point();
            } 
            else
            {
                FirstSendler = null;
                FirstPoint = new Point();
                EndSendler = sender;
                EndPoint = new Point(e.X, e.Y);
            }
        }
    }
}
