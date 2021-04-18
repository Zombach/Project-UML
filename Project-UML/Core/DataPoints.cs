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
        public object FirstSender { get; set; }
        public object EndSender { get; set; }
        public Point FirstPoint { get; set; }
        public Point EndPoint { get; set; }

        public DataPoints(object sender, MouseEventArgs e, bool isFirstPoint)
        {
            if (isFirstPoint)
            {
                FirstSender = sender;
                FirstPoint = new Point(e.X, e.Y);
                EndSender = null;
                EndPoint = new Point();
            } 
            else
            {
                FirstSender = null;
                FirstPoint = new Point();
                EndSender = sender;
                EndPoint = new Point(e.X, e.Y);
            }
        }
    }
}
