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
    /// Сереализация
    /// </summary>
    [Serializable]
    public class SerializeData : ICoreUML
    {
        #region Переменные
        /// <summary>
        /// Список структурных фигур
        /// </summary>
        public List<IBase> Base { get; set; }
        /// <summary>
        /// Список структурных действий с фигурами
        /// </summary>
        public List<ILogs> Logs { get; set; }
        /// <summary>
        /// Цвет по умоолчанию
        /// </summary>
        public Color DefaultColor { get; set; }
        /// <summary>
        /// Шрифт по умолчанию
        /// </summary>
        public Font DefaultFont { get; set; }
        /// <summary>
        /// Ширина по умолчанию
        /// </summary>
        public int DefaultWidth { get; set; }
        /// <summary>
        /// Размер фигур по умолчанию для скролла
        /// </summary>
        public float DefaultSize { get; set; }
        /// <summary>
        /// Структура Стрелы
        /// </summary>
        private StructArrow _arrow;
        /// <summary>
        /// Структура Бокса
        /// </summary>
        private StructBox _box;
        #endregion

        #region Методы
        /// <summary>
        /// Сереализация ядра и объектов програмы
        /// </summary>
        public SerializeData()
        {
            CoreUML coreUML = CoreUML.GetCoreUML();
            List<IFigure> Figures = coreUML.Figures;
            Base = new List<IBase>();
            Base = CreateStructFigure(Figures);

            Logs = new List<ILogs>();
            Logs = CreateObjectsLogs();

            DefaultWidth = (int)coreUML.DefaultWidth;
            DefaultColor = coreUML.DefaultColor;
            DefaultFont = coreUML.DefaultFont;
            DefaultSize = coreUML.DefaultSize;
        }

        /// <summary>
        /// Создание списка структур на базе списка фигур
        /// </summary>
        /// <param name="Figures">Список фигур</param>
        /// <returns></returns>
        private List<IBase> CreateStructFigure(List<IFigure> Figures)
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

        /// <summary>
        /// Создание списка структурных действий с фигурами
        /// </summary>
        /// <returns></returns>
        private List<ILogs> CreateObjectsLogs()
        {
            List<ILogs> logs = new List<ILogs>();
            return logs;
        }
        #endregion
    }
}
