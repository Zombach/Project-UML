using Project_UML.Core.Arrows;
using Project_UML.Core.DataProject.Interfaces;
using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Project_UML.Core.DataProject.Structure
{
    [Serializable]
    public struct StructArrow : IArrow, IBase
    {
        public List<IPoint> Points { get; set; }
        public string Type { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }

        public List<IDataCommon> Data { get; set; }
        
        public StructArrow(IFigure figure)
        {
            AbstractArrow arrow = (AbstractArrow)figure;
            Type = arrow.GetType().FullName;
            Color = arrow.GetColor();
            Width = arrow.GetWidth();
            Points = new List<IPoint>();
            for (int i = 0; i < arrow.Points.Count; i++)
            {
                StructPoints structPoints = new StructPoints(arrow.Points[i]);
                Points.Add(structPoints);
            }
            Data = new List<IDataCommon>();
            for (int i = 0; i < arrow.DataCommon.Count; i++)
            {
                StructDataCommon structData = new StructDataCommon(arrow.DataCommon[i]);
                Data.Add(structData);
            }
        }        
    }
}
