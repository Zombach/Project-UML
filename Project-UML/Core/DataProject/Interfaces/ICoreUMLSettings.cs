using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.DataProject.Interfaces
{
    /// <summary>
    /// Для сериализации настроек по умолчанию 
    /// </summary>
    public interface ICoreUMLSettings
    {
        Color DefaultColor { get; set; }
        /// <summary>
        /// Шрифт по умолчанию
        /// </summary>
        Font DefaultFont { get; set; }
        /// <summary>
        /// Ширина по умолчанию
        /// </summary>
        int DefaultWidth { get; set; }
        /// <summary>
        /// Размер для зумирования по умолчанию
        /// </summary>
        //int DefaultSize { get; set; }
        /// <summary>
        /// Шаг для сдвижения
        /// </summary>
        Step DefaultStep { get; set; }
        /// <summary>
        /// Путь последнего сохранения
        /// </summary>
        string Path { get; set; }
    }
}
