using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.IO;
using System;

namespace Project_UML.Core.DataProject
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
            using (FileStream fileStream = new FileStream(_coreUML.MyPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                SerializeData writeData = new SerializeData();
                binaryFormatter.Serialize(fileStream, writeData);
                fileStream.Close();
                return true;
            }
        }
        public SerializeData DeserializationDictionary()
        {
            using (FileStream fileStream = new FileStream(_coreUML.MyPath, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                SerializeData writeData = (SerializeData)binaryFormatter.Deserialize(fileStream);
                fileStream.Close();
                return writeData;
            }
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
