using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML._Core._Serialize
{
    /// <summary>
    /// Класс для преобразования объекта box, в объект пригодный для сохранения
    /// </summary>
    public class BoxsSerialize
    {
        public void ReconstructionBox(/*AbstractBox box*/)
        {
            StructSerialize structSerialize = new StructSerialize();
            //structSerialize.color = box.Color;

            structSerialize.Points = new List<SerializePoints>();
            //for (int i = 0; i < box.Points.Count; i++)
            //{
            //    SerializePoints points = new SerializePoints(box.Points[i].X, box.Points[i].Y);
            //    structSerialize.Points.Add(points);
            //}
        }
    }
}
