using Project_UML.Core.DataProject.Serialize.Interfaces;
using Project_UML.Core.DataProject.Serialize.Structure;
using Project_UML.Core.Interfaces;
using System.Collections.Generic;
using Project_UML.Core.Arrows;
using Project_UML.Core.Boxes;
using System.Drawing;
using System;

namespace Project_UML.Core.DataProject.Serialize
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
        public List<IBase> Base { get; set; }
        public List<LogActs> Logs { get; set; }
        public int DefaultWidth { get; set; }
        public Color DefaultColor { get; set; }
        public Font DefaultFont { get; set; }
        public float DefaultSize { get; set; }

        public WriteData()
        {
            CoreUML coreUML = CoreUML.GetCoreUML();
            List<IFigure> Figures = coreUML.Figures;
            Base = new List<IBase>();
            Base = CreateObjectsFigure(Figures);

            Logs = new List<LogActs>();
            Logs = CreateObjectsLogs();

            DefaultWidth = (int)coreUML.DefaultWidth;
            DefaultColor = coreUML.DefaultColor;
            DefaultFont = coreUML.DefaultFont;
            DefaultSize = coreUML.DefaultSize;
        }

        private List<IBase> CreateObjectsFigure(List<IFigure> Figures)
        {
            List<IBase> figure = new List<IBase>();
            for (int i = 0; i < Figures.Count; i++)
            {
                if (Figures[i] is AbstractArrow)
                {
                    _arrow = new StructArrow(Figures[i]);
                    figure.Add(_arrow);
                }
                if (Figures[i] is AbstractBox)
                {
                    _box = new StructBox(Figures[i]);
                    figure.Add(_box);
                }
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
