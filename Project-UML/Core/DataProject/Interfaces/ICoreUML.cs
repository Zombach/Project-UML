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
        
    }
}
