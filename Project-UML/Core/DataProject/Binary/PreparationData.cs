using Project_UML.Core.DataProject.Interfaces;
using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.Interfaces;
using System.Collections.Generic;
using Project_UML.Core.Arrows;
using Project_UML.Core.Boxes;
using System.Drawing;
using System;

namespace Project_UML.Core.DataProject.Binary
{
    /// <summary>
    /// Подготовка Даты Сериализации
    /// </summary>
    [Serializable]
    public class PreparationData : ICoreUML
    {
        #region Переменные
        /// <summary>
        /// Список структурных фигур
        /// </summary>
        public List<IBase> Base { get; set; }
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
        public PreparationData()
        {
            CoreUML coreUML = CoreUML.GetCoreUML();
            List<IFigure> Figures = coreUML.Figures;
            Base = new List<IBase>();
            Base = CreateStructFigure(Figures);
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
        #endregion
    }
}
