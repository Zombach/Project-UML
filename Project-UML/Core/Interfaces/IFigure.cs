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
        int GetWidth();
        int GetHeight();

        void Move(int deltaX, int deltaY);
        void Select(Graphics graphics);
        void Draw(Graphics graphics);
        bool IsHovered(Point point);
        bool CheckSelection(Point startPoint, Point endPoint, int inaccuracy = 0);
        void ChangeColor(Color color);
        void ChangeWidth(int width);
        List<Point> Points { get; set; }
        List<DataCommon> DataCommon { get; set; }
    }
}
