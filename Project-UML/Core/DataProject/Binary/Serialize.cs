using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.DataProject.Binary
{
    public class Serialize
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        public void SerializationDictionary()
        {
            SetMyPath path = new SetMyPath();
            path.MyPath();
            using (FileStream fileStream = new FileStream(_coreUML.MyPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                PreparationData data = new PreparationData();
                binaryFormatter.Serialize(fileStream, data);
                fileStream.Close();
            }
        }
    }
}
