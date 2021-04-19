using System.Collections.Generic;
using System.Drawing;


namespace Project_UML.Core.DataProject.Serialize.Interfaces
{
    public interface IBase
    {
        List<IDataCommon> Data { get; set; }
        Color Color { get; set; }
        float Width { get; set; }        
        float Size { get; set; }
    }
}
