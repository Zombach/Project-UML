using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core
{
    public class Step
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Step(int x)
        {
            X = x;
            Y = X;
        }
        public Step(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Step(Step step)
        {
            X = step.X;
            Y = step.Y;
        }
    }
}
