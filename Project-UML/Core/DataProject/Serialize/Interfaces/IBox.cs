using System.Collections.Generic;
using System.Drawing;

namespace Project_UML.Core.DataProject.Serialize.Interfaces
{
    public interface IBox
    {
        List<DataText> DataText { get; set; }
        Font Font { get; set; }
    }
}
