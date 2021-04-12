using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Arrows;
using Project_UML.Core.Serialize;

namespace Project_UML.Core
{
    public static class Core
    {
        public static List<int> Figures = new List<int>();
        public static string _myPath = "";
        public static string Index = "0";

        public static bool SaveDate()
        {
            BinaryConversion.SerializationDictionary();
            return true;
        }

        public static bool LoadData()
        {
            BinaryConversion.DeserializationDictionary();
            return true;
        }
    }
}
