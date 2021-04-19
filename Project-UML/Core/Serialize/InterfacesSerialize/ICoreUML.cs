using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces;

namespace Project_UML.Core.Serialize.InterfacesSerialize
{
    public interface ICoreUML
    {
        List<IBase> Base { get; set; }
        List<LogActs> Logs { get; set; }
        int DefaultWidth { get; set; }
        Color DefaultColor { get; set; }
        Font DefaultFont { get; set; }        
        float DefaultSize { get; set; }
    }
}
