using Newtonsoft.Json;
using Project_UML.Core.DataProject.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.DataProject.Json
{
    public class Deserialize
    {
        public StructSettings DeserializerSetting(string data)
        {
            StructSettings settings;
            try
            {
                settings = JsonConvert.DeserializeObject<StructSettings>(data);
            }
            catch
            {
                settings = null;
            }
            return settings;
        }
    }
}
