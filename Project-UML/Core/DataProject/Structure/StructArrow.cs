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
        public string ArrowType { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }
        public float Size { get; set; }

        public List<IDataCommon> Data { get; set; }
        
        public StructArrow(IFigure figure)
        {
            AbstractArrow arrow = (AbstractArrow)figure;
            ArrowType = arrow.GetType().FullName;
            Color = arrow.GetColor();
            Width = arrow.GetWidth();
            Size = arrow.GetSize();

            Data = null;
            for (int i = 0; i < arrow.DataCommon.Count; i++)
            {
                Data = new List<IDataCommon>();
                StructDataCommon structData = new StructDataCommon(arrow.DataCommon[i]);
                Data.Add(structData);
            }
        }        
    }
}
