using System.Collections.Generic;
using System.Drawing;

namespace Project_UML.Core.DataProject.Interfaces
{
    /// <summary>
    /// Для сериализации ядра
    /// </summary>
    public interface ICoreUML
    {
        /// <summary>
        /// Список структур фигур
        /// </summary>
        List<IBase> Base { get; set; }
        /// <summary>
        /// Список структурированых действий
        /// </summary>
        List<ILogs> Logs { get; set; }
        /// <summary>
        /// Цвет по умолчанию
        /// </summary>
        Color DefaultColor { get; set; }
        /// <summary>
        /// Шрифт по умолчанию
        /// </summary>
        Font DefaultFont { get; set; } 
        /// <summary>
        /// Ширина по умолчанию
        /// </summary>
        float DefaultWidth { get; set; }
        /// <summary>
        /// Размер для зумирования по умолчанию
        /// </summary>
        float DefaultSize { get; set; }
    }
}
