using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Project.Core
{
    public static class Core
    {
        public static Dictionary<string, string/*IFigure*/> Figures;
        public static string Index;

        static Core()
        {
            Figures = new Dictionary<string, string/*IFigure*/>();
            Index = "0";
        }

        public static bool Serialization()
        {

            return true;
        }

        public static bool Deserialization()
        {

            return true;
        }
    }
}
