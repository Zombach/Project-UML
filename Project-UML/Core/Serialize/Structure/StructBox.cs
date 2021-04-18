using Project_UML.Core.Boxes;
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
    public struct StructBox : IBox, IBase
    {
        public List<DataText> DataText { get; set; }
        public List<DataCommon> Data { get; set; }
        public Font Font { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }
        public float Size { get; set; }

        public StructBox(AbstractBox box)
        {
            DataText = box.DataText;
            Data = box.DataCommon;
            Font = box.GetFont();
            Color = box.GetColor();
            Width = box.GetWidth();
            Size = box.GetSize();
        }
    }
}
