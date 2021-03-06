using Project_UML.Core.Boxes;
using Project_UML.Core.DataProject.Interfaces;
using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.DataProject.Structure
{
    [Serializable]
    public struct StructBox : IBox, IBase
    {
        public List<IPoint> Points { get; set; }
        public List<IDataCommon> Data { get; set; }
        public List<DataText> DataText { get; set; }
        public string Type { get; set; }
        public Font[] Font { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }

        public StructBox(IFigure figure)
        {
            AbstractBox box = (AbstractBox)figure;
            Type = box.GetType().FullName;
            DataText = box.DataText;
            Font = box.GetFont();
            Color = box.GetColor();
            Width = box.GetWidth();
            Points = new List<IPoint>();
            for (int i = 0; i < box.Points.Count; i++)
            {
                StructPoints structPoints = new StructPoints(box.Points[i]);
                Points.Add(structPoints);
            }
            Data = new List<IDataCommon>();
            for (int i = 0; i < box.DataCommon.Count; i++)
            {
                StructDataCommon structData = new StructDataCommon(box.DataCommon[i]);
                Data.Add(structData);
            }
        }
    }
}
