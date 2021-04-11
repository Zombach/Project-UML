using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UML_Project.Interfaces;
using UML_Project._Core;
using UML_Project.Arrows;


namespace UML_Project
{
    public static class BinaryConversion
    {
        public static bool SerializationDictionary()
        {
            SetMyPath();
            FileStream fileStream = new FileStream(Core._myPath, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, Core.Figures);
            fileStream.Close();
            return true;
        }
        public static bool DeserializationDictionary()
        {
            FileStream fileStream = new FileStream(Core._myPath, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Core.Figures = (List<int>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return true;
        }

        private static void SetMyPath()
        {
            DateTime _dateTime = DateTime.Now;
            string _tmpName = $"../../Save/Save_{_dateTime}.Мы-Програмист";
            Regex regex = new Regex(":");
            _tmpName = regex.Replace(_tmpName, ".");
            Core._myPath = Path.GetFullPath(_tmpName);
        }
    }
}
