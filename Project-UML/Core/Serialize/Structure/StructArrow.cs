using Project_UML.Core.Arrows;
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
        public ArrowType ArrowType { get; set; }
        public List<DataCommon> Data { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }
        public float Size { get; set; }

        public StructArrow(AbstractArrow arrow)
        {
            ArrowType = arrow.GetArrowType();
            Data = arrow.DataCommon;
            Color = arrow.GetColor();
            Width = arrow.GetWidth();
            Size = arrow.GetSize();
        }
    }
}
