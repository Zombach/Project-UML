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

        public LogActs()
        {
            Previous = null;
            New = null;
        }
        public void GetNew(IFigure figure, bool isNew = true)
        {
            if(isNew)
            {
                Previous = figure;
            }
            else
            {
                Previous = null;
            }
        }

        public void GetPrevious(LogActs log, IFigure figure, bool isNew = true)
        {
            if (isNew)
            {
                log.New = figure;
            }
            else
            {
                log.Previous = figure;
            }
        }
    }
}
