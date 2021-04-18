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
        public List<string> Text { get; set; }
        public Font Font { get; set; }
        public List<DataCommon> Data { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public float Size { get; set; }

        public StructBox(AbstractBox box)
        {
            Text = null;
            Font = null;
            Data = null;
            Color = Color.Black;
            Width = 1;
            Size = 1f;
        }
    }
}
