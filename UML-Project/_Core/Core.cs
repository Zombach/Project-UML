using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Project.Interfaces;

namespace UML_Project._Core
{
    public static class Core
    {
        public static Dictionary<string, IFigure> Figures;
        public static string _myPath;
        public static string Index;

        static Core()
        {
            Figures = new Dictionary<string, IFigure>();
            Index = "0";
            _myPath = "";
        }

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
