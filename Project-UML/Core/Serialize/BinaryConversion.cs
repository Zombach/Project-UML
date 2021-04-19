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
    public class BinaryConversion
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();

        public bool SerializationDictionary()
        {
            SetMyPath();
            FileStream fileStream = new FileStream(_coreUML.MyPath, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            WriteData writeData = new WriteData();
            binaryFormatter.Serialize(fileStream, writeData);
            fileStream.Close();
            return true;
        }
        public bool DeserializationDictionary()
        {
            FileStream fileStream = new FileStream(_coreUML.MyPath, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            WriteData writeData = (WriteData)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            ReadData readData = new ReadData(writeData);
            readData.ReadAll();
            return true;
        }

        private void SetMyPath()
        {
            DateTime _dateTime = DateTime.Now;
            string _tmpName = $"../../Save/Save_{_dateTime}.Мы-Програмист";
            Regex regex = new Regex(":");
            _tmpName = regex.Replace(_tmpName, ".");
            _coreUML.MyPath = Path.GetFullPath(_tmpName);
            //Microsoft.Win32.Registry.SetValue("HKEY_CLASSES_ROOT\\.Мы-Програмист", "", "UML Manager");
            //Microsoft.Win32.Registry.SetValue("HKEY_CLASSES_ROOT\\UML Manager\\DefaultIcon", "", "C:\\WINDOWS\\explorer.exe" + ",1");

        }
    }
}
