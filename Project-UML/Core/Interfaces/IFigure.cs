﻿using System;
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
    public interface IFigure
    {
        Point Location { get; set; }
        int GetWidth();
        int GetHeight();

        void Move(int deltaX, int deltaY);
        void Select(Graphics graphics);
        void Draw(Graphics graphics);
        void IsHovered(Point point);
        void ChangeColor(Color color);
        void ChangeWidth(int width);
    }
}
