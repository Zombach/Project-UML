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
    public static class SerializeDictionary
    {
        ////private static Dictionary<string, OperandBox> _tmpData = new Dictionary<string, OperandBox>();
        //private static string _myPath;
        //private static string _tmpName;
        //private static DateTime _dateTime;

        //public static void SaveOperandsDictionary(Dictionary<string, SaveObjectOperand> data)
        //{
        //    _dateTime = DateTime.Now;
        //    _tmpName = $"../../Save/Save_{_dateTime}.dat";
        //    Regex regex = new Regex(":");
        //    _tmpName = regex.Replace(_tmpName, ".");
        //    _myPath = Path.GetFullPath(_tmpName);
        //    FileStream fileStream = new FileStream(_myPath, FileMode.Create, FileAccess.Write, FileShare.None);
        //    BinaryFormatter binaryFormatter = new BinaryFormatter();
        //    binaryFormatter.Serialize(fileStream, data);
        //    fileStream.Close();
            
        // }
        //public static Dictionary<string, SaveObjectOperand> LoadOperandsDictionary()
        //{
        //    FileStream fileStream = new FileStream(_myPath, FileMode.Open, FileAccess.Read, FileShare.None);
        //    BinaryFormatter binaryFormatter = new BinaryFormatter();
        //    Dictionary<string, SaveObjectOperand> obj = (Dictionary<string, SaveObjectOperand>)binaryFormatter.Deserialize(fileStream);
        //    fileStream.Close();
        //    return obj;
        //}
    }
}
