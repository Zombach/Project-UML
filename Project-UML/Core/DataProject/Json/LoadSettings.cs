using Newtonsoft.Json;
using Project_UML.Core.DataProject.Structure;
using System.IO;

namespace Project_UML.Core.DataProject.Json
{
    public class LoadSettings
    {
        private Deserialize _deserializer = new Deserialize();
        public StructSettings ReadSettings()
        {
            StructSettings settings;
            using (FileStream fileStream = new FileStream(CoreUML.GetCoreUML().MyPathSettings, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    settings = _deserializer.DeserializerSetting(streamReader.ReadToEnd());
                    streamReader.Close();
                }
                fileStream.Close();
            }
            return settings;
        }
    }
}
