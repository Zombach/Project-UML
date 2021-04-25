using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core
{
    public class LogActs
    {
        public IFigure Previous { get; set; }
        public IFigure New { get; set;}
        
        public LogActs(IFigure figure)
        {
                Previous = figure;
                New = null;            
        }

        public void GetPrevious(LogActs log, IFigure figure)
        {
            log.New = figure;
        }
    }
}
