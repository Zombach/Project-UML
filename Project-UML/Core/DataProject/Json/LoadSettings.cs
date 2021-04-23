using Newtonsoft.Json;
using Project_UML.Core.DataProject.Structure;
using System.IO;

namespace Project_UML.Core.DataProject.Json
{
    public class LoadSettings
    {
        
        private DeserializeSettings _deserializer = new DeserializeSettings();
        public void WriteSettings()
        {
            using (FileStream fileStream = new FileStream(CoreUML.GetCoreUML().MyPathSettings, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    streamReader.ReadToEnd();
                    streamReader.Close();
                }
                fileStream.Close();
            }
        }
    }
}
