using System.Collections.Generic;
using System.Drawing;

namespace Project_UML.Core.DataProject.Interfaces
{
    public interface IBox
    {
        string Type { get; set; }
        List<DataText> DataText { get; set; }
        Font Font { get; set; }
    }
}
