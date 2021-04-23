using Newtonsoft.Json;
using Project_UML.Core.DataProject.Structure;

namespace Project_UML.Core.DataProject.Json
{
    public class SerializeSettings
    {
        private StructSettings _setting = new StructSettings();
        public string Serializer()
        {
            return JsonConvert.SerializeObject(_setting, Formatting.Indented,
                new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });
        }
    }
}
