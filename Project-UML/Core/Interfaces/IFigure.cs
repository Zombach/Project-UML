using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFigure : IFigureLogics, IFigureDraws, IGetParametr
    {
        Point Location { get; set; }
        int GetHeight();
        void Select(Graphics graphics);
        bool CheckSelection(Point startPoint, Point endPoint, int inaccuracy = 0);
        List<Point> Points { get; set; }
        List<DataCommon> DataCommon { get; set; }
    }
}
