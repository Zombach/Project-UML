using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core
{
    public class DataText
    {
        public string Name { get; set; }
        public List <string> Class { get; set; }
        public List<string> Methods { get; set; }
        public List<string> Properties { get; set; }

        public DataText()
        {
            Name = "";
            Class = new List<string>();
            Methods = new List<string>();
            Properties = new List<string>();
        }
        public DataText(string name)
        {
            Name = name;
            Class = new List<string>();
            Methods = new List<string>();
            Properties = new List<string>();
        }
    }
}
