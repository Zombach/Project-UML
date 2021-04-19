using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Serialize.InterfacesSerialize
{
    public interface IDataCommon
    {
        int FirstBox { get; set; }
        int LastBox { get; set; }
        int Arrow { get; set; }
        int FirstPoint_X { get; set; }
        int FirstPoint_Y { get; set; }
        int LastPoint_X { get; set; }
        int LastPoint_Y { get; set; }

    }
}
