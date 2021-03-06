using Project_UML.Core.DataProject.Interfaces;
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
        List<Point> Points { get; set; }
        List<DataCommon> DataCommon { get; set; }
        List<IDataCommon> IDataCommon { get; set; }
        void Select(Graphics graphics);
        bool CheckSelection(Point startPoint, Point endPoint, int inaccuracy = 0);

        void Transform(Point e);

        Point GetMiddlePoint();
    }
}
