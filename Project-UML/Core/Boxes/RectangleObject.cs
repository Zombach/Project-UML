using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Boxes
{
    /// <summary>
    /// 
    /// </summary>
    public class RectangleObject : AbstractBox
    {
        public RectangleObject(Color color, int width) : base(color, width)
        {
        }

        public RectangleObject(StructBox box) : base(box)
        {
        }


        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, Points[0].X, Points[0].Y, RectangleWidth, RectangleHeight);            
        }        
    }
}
