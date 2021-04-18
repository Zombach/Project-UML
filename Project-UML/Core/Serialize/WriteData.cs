using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Arrows;
using Project_UML.Core.Boxes;
using System.Reflection;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Serialize.InterfacesSerialize;
using Project_UML.Core.Serialize.Structure;

namespace Project_UML.Core.Serialize
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class WriteData : ICoreUML
    {
        private StructArrow _arrow;
        private StructBox _box;
        /// <summary>
        /// Сериализация Ядра
        /// </summary>
        public List<IFigure> Figures { get; set; }
        public List<LogActs> Logs { get; set; }
        public int DefaultWidth { get; set; }
        public Color DefaultColor { get; set; }
        public Font DefaultFont { get; set; }
        public float DefaultSize { get; set; }

        public WriteData()
        {
            CoreUML coreUML = CoreUML.GetCoreUML();
            Figures = new List<IFigure>();
            Figures = CreateObjectsFigure();

            Logs = new List<LogActs>();
            Logs = CreateObjectsLogs();

            DefaultWidth = (int)coreUML.DefaultWidth;
            DefaultColor = coreUML.DefaultColor;
            DefaultFont = coreUML.DefaultFont;
            DefaultSize = coreUML.DefaultSize;
        }

        private List<IFigure> CreateObjectsFigure()
        {
            List<IFigure> figure = new List<IFigure>();
            for (int i = 0; i < Figures.Count; i++)
            {
                if (Figures[i].GetType() == typeof(AbstractArrow))
                {
                    _arrow = new StructArrow((AbstractArrow)Figures[i]);
                }
                if (Figures[i].GetType() == typeof(AbstractBox))
                {
                    _box = new StructBox((AbstractBox)Figures[i]);
                }
                figure.Add(Figures[i]);
            }
            return figure;
        }

        private List<LogActs> CreateObjectsLogs()
        {
            List<LogActs> logs = new List<LogActs>();
            return logs;
        }

    }
}
