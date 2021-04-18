using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Serialize.InterfacesSerialize
{
    public interface IBox
    {
        List<DataText> DataText { get; set; }
        Font Font { get; set; }
    }
}
