using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Arrows;

namespace Project_UML.Core.Serialize
{
    /// <summary>
    /// 
    /// </summary>
    /// <summary>
    /// Структура для сериализации объекта, для сохранения данных
    /// </summary>
    public struct StructSerialize
    {
        public List<SerializePoints> Points;
        public ArrowType Type;
        public Color Color;
        public int Width;
    }
}
