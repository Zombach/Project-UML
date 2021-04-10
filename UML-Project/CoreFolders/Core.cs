using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Project.Interfaces;

namespace UML_Project.CoreFolders
{
    public static class Core
    {
        public static Dictionary<string, IFigure> Figures;
        public static string Index;

        static Core()
        {
            Figures = new Dictionary<string, IFigure>();
            Index = "0";
        }

        public static bool SaveDate()
        {
            BinaryConversion.SerializationDictionary(Figures);
            return true;
        }

        public static bool LoadData()
        {
            Figures = (Dictionary<string, IFigure>)BinaryConversion.DeserializationDictionary();
            return true;
        }
    }
}
