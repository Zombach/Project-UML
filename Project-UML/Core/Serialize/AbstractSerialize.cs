using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Arrows;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Serialize.InterfacesSerialize;

namespace Project_UML.Core.Serialize
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractSerialize : ICoreUML, IFigures 
    {
        /// <summary>
        /// Сериализация Ядра
        /// </summary>
        public List<IFigure> Figure { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> LogActs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DefaultWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Color DefaultColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Font DefaultFont { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float DefaultSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Сериализация объектов
        /// </summary>
        public List<DataCommon> Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Color Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Font Font { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ArrowType ArrowType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
