using System.Collections.Generic;
using System.Drawing;


namespace Project_UML.Core.DataProject.Interfaces
{
    /// <summary>
    /// Общая база сохроняемых полей из IFigure
    /// </summary>
    public interface IBase
    {
        /// <summary>
        /// Список общий хранимой информации
        /// </summary>
        List<IDataCommon> Data { get; set; }
        /// <summary>
        /// Цвет фигуры
        /// </summary>
        Color Color { get; set; }
        /// <summary>
        /// Толщина линий фигуры
        /// </summary>
        float Width { get; set; }
        /// <summary>
        /// Размер фигуры для зумирования
        /// </summary>
        float Size { get; set; }
    }
}
