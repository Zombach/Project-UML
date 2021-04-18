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
    public class WriteData : ICoreUML, IFigures 
    {
        /// <summary>
        /// Сериализация Ядра
        /// </summary>
        public List<IFigure> Figures { get; set; }
        public List<LogActs> Logs { get; set; }
        public int DefaultWidth { get; set; }
        public Color DefaultColor { get; set; }
        public Font DefaultFont { get; set; }
        public float DefaultSize { get; set; }

        public WriteData()
        {
            CoreUML coreUML = CoreUML.GetCoreUML();
            Figures = coreUML.Figures;
            Logs = coreUML.Logs;
            DefaultWidth = coreUML.DefaultWidth;
            DefaultColor = coreUML.DefaultColor;
            DefaultFont = coreUML.DefaultFont;
            DefaultSize = coreUML.DefaultSize;
        }
        public List <object> WriteAll()
        {
            List<object> Objects = new List<object>();
            Objects.Add(Figures);
            Objects.Add(Logs);
            Objects.Add(DefaultWidth);
            Objects.Add(DefaultColor);
            Objects.Add(DefaultFont);
            Objects.Add(DefaultSize);
            return Objects;
        }
        public object SerelizeIFigure()
        {
            return new object();
        }


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
