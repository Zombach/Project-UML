using Project_UML.Core.DataProject.Interfaces;
using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.Interfaces;
using System.Collections.Generic;
using Project_UML.Core.Arrows;
using Project_UML.Core.Boxes;
using System.Drawing;
using System;

namespace Project_UML.Core.DataProject
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class SerializeData : ICoreUML
    {
        private StructArrow _arrow;
        private StructBox _box;
        /// <summary>
        /// Сериализация Ядра
        /// </summary>
        public List<IBase> Base { get; set; }
        public List<ILogs> Logs { get; set; }
        public int DefaultWidth { get; set; }
        public Color DefaultColor { get; set; }
        public Font DefaultFont { get; set; }
        public float DefaultSize { get; set; }

        public SerializeData()
        {
            CoreUML coreUML = CoreUML.GetCoreUML();
            List<IFigure> Figures = coreUML.Figures;
            Base = new List<IBase>();
            Base = CreateObjectsFigure(Figures);

            Logs = new List<ILogs>();
            Logs = CreateObjectsLogs();

            DefaultWidth = (int)coreUML.DefaultWidth;
            DefaultColor = coreUML.DefaultColor;
            DefaultFont = coreUML.DefaultFont;
            DefaultSize = coreUML.DefaultSize;
        }

        private List<IBase> CreateObjectsFigure(List<IFigure> Figures)
        {
            List<IBase> iBase = new List<IBase>();
            for (int i = 0; i < Figures.Count; i++)
            {
                if (Figures[i] is AbstractArrow)
                {
                    _arrow = new StructArrow(Figures[i]);
                    iBase.Add(_arrow);
                }
                if (Figures[i] is AbstractBox)
                {
                    _box = new StructBox(Figures[i]);
                    iBase.Add(_box);
                }
            }
            return iBase;
        }

        private List<ILogs> CreateObjectsLogs()
        {
            List<ILogs> logs = new List<ILogs>();
            return logs;
        }

    }
}
