﻿using Project_UML.Core.Arrows;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Serialize.InterfacesSerialize;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Serialize.Structure
{
    [Serializable]
    public struct StructArrow : IArrow, IBase
    {
        public Type ArrowType { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }
        public float Size { get; set; }

        public List<IDataCommon> Data { get; set; }
        
        public StructArrow(IFigure figure)
        {
            AbstractArrow arrow = (AbstractArrow)figure;
            ArrowType = arrow.GetType();
            Color = arrow.GetColor();
            Width = arrow.GetWidth();
            Size = 1f;//arrow.GetSize();

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
