using System.Collections.Generic;
using System.Drawing;

namespace Project_UML.Core.DataProject.Serialize.Interfaces
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
