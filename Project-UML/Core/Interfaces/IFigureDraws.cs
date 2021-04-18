using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces.Draws;

namespace Project_UML.Core.Interfaces
{
    public interface IFigureDraws : IDraw, IChangeColor, IChangeWidth
    {
    }
}
