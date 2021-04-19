using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Serialize.InterfacesSerialize;

namespace Project_UML.Core.Serialize.Structure
{
    [Serializable]
    public struct StructDataCommon :IDataCommon
    {
        public int FirstBox { get; set; }
        public int LastBox { get; set; }
        public int Arrow { get; set; }
        public int FirstPoint_X { get; set; }
        public int FirstPoint_Y { get; set; }
        public int LastPoint_X { get; set; }
        public int LastPoint_Y { get; set; }

        public StructDataCommon(DataCommon data)
        {
            CoreUML coreUML = CoreUML.GetCoreUML();
            FirstBox = coreUML.Figures.IndexOf(data.FirstBox);
            LastBox = coreUML.Figures.IndexOf(data.LastBox);
            Arrow = coreUML.Figures.IndexOf(data.Arrow);
            FirstPoint_X = data.FirstPoint.X;
            FirstPoint_Y = data.FirstPoint.Y;
            LastPoint_X = data.LastPoint.X;
            LastPoint_Y = data.LastPoint.Y;
        }
    }
}
