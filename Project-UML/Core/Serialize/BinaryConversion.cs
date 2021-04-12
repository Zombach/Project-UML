using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces;
using Project_UML.Core;
using Project_UML.Core.Arrows;


namespace Project_UML.Core.Serialize
{
    /// <summary>
    /// 
    /// </summary>
    public static class BinaryConversion
    {
        public static bool SerializationDictionary()
        {
            SetMyPath();
            FileStream fileStream = new FileStream(CoreUML.MyPath, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, CoreUML.Figures);
            fileStream.Close();
            return true;
        }
        public static bool DeserializationDictionary()
        {
            FileStream fileStream = new FileStream(CoreUML.MyPath, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            CoreUML.Figures = (List<IFigure>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return true;
        }

        private static void SetMyPath()
        {
            DateTime _dateTime = DateTime.Now;
            string _tmpName = $"../../Save/Save_{_dateTime}.Мы-Програмист";
            Regex regex = new Regex(":");
            _tmpName = regex.Replace(_tmpName, ".");
            CoreUML.MyPath = Path.GetFullPath(_tmpName);
        }
    }
}
