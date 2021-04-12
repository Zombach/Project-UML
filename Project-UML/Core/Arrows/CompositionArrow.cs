﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Arrows
{
    public class CompositionArrow : AbstractArrow
    {
        public CompositionArrow()
        {
            _pen = new Pen(Color.Black, 1);
            SetEndCap();
        }

        public CompositionArrow(Color color, int width)
        {
            _pen = new Pen(color, width);
            SetEndCap();
        }
        public CompositionArrow(Point startPoint, Point endPoint, Axises startDirectionAxis, Axises endDirectionAxis)
        {
            _pen = new Pen(Color.Black, 1);
            Points = GetPoints(startPoint, endPoint);
            StartDirectionAxis = startDirectionAxis;
            EndDirectionAxis = endDirectionAxis;
            SetEndCap();
        }

        private void SetEndCap()
        {
            int tmp;
            if (_pen.Width == 1)
            {
                tmp = 2;
            }
            else
            {
                tmp = 1;
            }
            GraphicsPath _graphicsPath = new GraphicsPath();
            _graphicsPath.AddLine(new Point(0, 0), new Point(8/tmp, -12 / tmp));
            _graphicsPath.AddLine(new Point(8 / tmp, -12 / tmp), new Point(0, -24 / tmp));
            _graphicsPath.AddLine(new Point(0, -24 / tmp), new Point(-8 / tmp, -12 / tmp));
            _graphicsPath.AddLine(new Point(-8 / tmp, -12 / tmp), new Point(0, 0));
            _pen.CustomEndCap = new CustomLineCap(_graphicsPath, null, LineCap.Custom, 24);
        }

        public override void ChangeWidth(int width)
        {
            _pen.Width = width;
            SetEndCap();
        }
    }
}