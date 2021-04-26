using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.DataProject.Binary
{
    public class Deserialize
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        public PreparationData DeserializationDictionary()
        {
            using (FileStream fileStream = new FileStream(_coreUML.MyPath, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                BinaryFormatter binary = new BinaryFormatter();
                PreparationData data = null;
                try
                {
                    data = (PreparationData)binary.Deserialize(fileStream);
                }
                catch
                {
                    MessageBox.Show("Не корректная дата, выберите другое сохранение");
                }
                fileStream.Close();
                return data;
            }
        }
    }
}
