using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UML_Project
{
    public static class BinaryConversion
    {
        private static string _myPath;

        public static void SaveOperandsDictionary(Dictionary<string, string/*IFigure*/> data)
        {
            DateTime _dateTime = DateTime.Now;
            string _tmpName = $"../../Save/Save_{_dateTime}.dat";
            Regex regex = new Regex(":");
            _tmpName = regex.Replace(_tmpName, ".");
            _myPath = Path.GetFullPath(_tmpName);
            FileStream fileStream = new FileStream(_myPath, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, data);
            fileStream.Close();

        }
        public static Dictionary<string, string/*IFigure*/> LoadOperandsDictionary()
        {
            FileStream fileStream = new FileStream(_myPath, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Dictionary<string, string/*IFigure*/> obj = (Dictionary<string, string/*IFigure*/>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return obj;
        }
    }
}
