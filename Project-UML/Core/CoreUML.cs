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
    /// <summary>
    /// 
    /// </summary>
    public static class CoreUML
    {
        public static List<IFigure> Figures { get; set; } = new List<IFigure>();
        public static string MyPath { get; set; } = "";

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
