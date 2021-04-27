using System.Collections.Generic;
using System.Drawing;

namespace Project_UML.Core.DataProject.Interfaces
{
    public interface IBox
    {        
        /// <summary>
        /// Тип бокса записаный в тексте
        /// </summary>
        string Type { get; set; }
        /// <summary>
        /// Список списков текста
        /// </summary>
        List<DataText> DataText { get; set; }
        /// <summary>
        /// Шрифт текста боксов
        /// </summary>
        Font[] Font { get; set; }
    }
}
