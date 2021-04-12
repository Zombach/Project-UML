using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Project_UML.Core.Arrows;

namespace Project_UML.Core.Serialize
{
    /// <summary>
    /// Класс для преобразования объекта стрелы, в объект пригодный для сохранения
    /// </summary>
    public class ArrowsSerialize
    {
        public void ReconstructionArrow(AbstractArrow arrow)
        {
            StructSerialize structSerialize = new StructSerialize();
            //structSerialize.color = arrow.Color;

            structSerialize.Points = new List<SerializePoints>();
            for (int i = 0; i < arrow.Points.Count; i++)
            {
                SerializePoints points = new SerializePoints(arrow.Points[i].X, arrow.Points[i].Y);
                structSerialize.Points.Add(points);
            }
        }
    }
}
