using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Interfaces.Draws
{
    public interface IChangeFont
    {
        void ChangeFont(Font font, string name = "Name");
    }
}
