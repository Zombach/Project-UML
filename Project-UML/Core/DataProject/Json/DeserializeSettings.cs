using Newtonsoft.Json;
using Project_UML.Core.DataProject.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.DataProject.Json
{
    public class DeserializeSettings
    {
        public StructSettings DeserializerSetting()
        {
            return JsonConvert.DeserializeObject<StructSettings>("");
        }
    }
}
