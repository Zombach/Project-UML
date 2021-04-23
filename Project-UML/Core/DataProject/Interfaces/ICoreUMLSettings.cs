using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.DataProject.Interfaces
{
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
        float DefaultWidth { get; set; }
        /// <summary>
        /// Размер для зумирования по умолчанию
        /// </summary>
        int DefaultSize { get; set; }
    }
}
