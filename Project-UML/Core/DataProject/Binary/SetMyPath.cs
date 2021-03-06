using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project_UML.Core.DataProject.Binary
{
    public class SetMyPath
    {
        private DateTime _dateTime;
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        public void MyPath()
        {
            _dateTime = DateTime.Now;
            string _tmpName = $"../../Save/Save_{_dateTime}.Мы-Програмист";
            Regex regex = new Regex(":");
            _tmpName = regex.Replace(_tmpName, ".");
            _coreUML.MyPath = Path.GetFullPath(_tmpName);
            //Microsoft.Win32.Registry.SetValue("HKEY_CLASSES_ROOT\\.Мы-Програмист", "", "UML Manager");
            //Microsoft.Win32.Registry.SetValue("HKEY_CLASSES_ROOT\\UML Manager\\DefaultIcon", "", "C:\\WINDOWS\\explorer.exe" + ",1");
        }

        public void MyPathImage()
        {
            _dateTime = DateTime.Now;
            string _tmpName = $"../../Save/Image/Image_{_dateTime}.jpg";
            Regex regex = new Regex(":");
            _tmpName = regex.Replace(_tmpName, ".");
            _coreUML.MyPathImage = Path.GetFullPath(_tmpName);
        }

        public void MyPathEncrypt()
        {
            _dateTime = DateTime.Now;
            string _tmpName = $"../../Save/Encrypt/Encry{_dateTime}.key";
            Regex regex = new Regex(":");
            _tmpName = regex.Replace(_tmpName, ".");
            _coreUML.MyPathEncryptSave = Path.GetFullPath(_tmpName);
        }
    }
}
