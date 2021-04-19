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
        public string ArrowType { get; set; }
        public List<DataCommon> Data { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }
        public float Size { get; set; }

        public StructArrow(AbstractArrow arrow)
        {
            string tmp = "";
            if (arrow is AssociationArrow)
            {
                tmp = "Association";
            }
            if (arrow is AggregationArrow)
            {
                tmp = "Aggregation";
            }
            if (arrow is CompositionArrow)
            {
                tmp = "Composition";
            }
            if (arrow is ImplementationArrow)
            {
                tmp = "Implementation";
            }
            if (arrow is InheritanceArrow)
            {
                tmp = "Inheritance";
            }
            ArrowType = tmp;
            Data = arrow.DataCommon;
            Color = arrow.GetColor();
            Width = arrow.GetWidth();
            Size = arrow.GetSize();
        }
    }
}
