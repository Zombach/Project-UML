using System.Collections.Generic;
using System.Drawing;

namespace Project_UML.Core.DataProject.Interfaces
{
    public interface ICoreUML
    {
        List<IBase> Base { get; set; }
        List<ILogs> Logs { get; set; }
        int DefaultWidth { get; set; }
        Color DefaultColor { get; set; }
        Font DefaultFont { get; set; }        
        float DefaultSize { get; set; }
    }
}
