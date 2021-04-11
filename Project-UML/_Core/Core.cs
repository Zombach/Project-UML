using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Interfaces;
using Project_UML.Arrows;

namespace Project_UML._Core
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
