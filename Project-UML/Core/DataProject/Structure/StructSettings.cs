using Project_UML.Core.DataProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.DataProject.Structure
{
    public class StructSettings : ICoreUMLSettings
    {
        public Color DefaultColor { get; set; }
        public Font DefaultFont { get; set; }
        public int DefaultWidth { get; set; }
        public int DefaultSize { get; set; }
        public Step DefaultStep { get; set; }

        public StructSettings()
        {
            CoreUML coreUML = CoreUML.GetCoreUML();
            DefaultColor = coreUML.DefaultColor;
            DefaultFont = coreUML.DefaultFont;
            DefaultWidth = coreUML.DefaultWidth;
            DefaultSize = coreUML.DefaultSize;
            DefaultStep = new Step(coreUML.DefaultStep);
        }
    }
}
