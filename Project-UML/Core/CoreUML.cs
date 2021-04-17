using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Arrows;
using Project_UML.Core.Serialize;

namespace Project_UML.Core
{
    /// <summary>
    /// Singletone Core, ядро програмы управляющее всем
    /// </summary>
    public class CoreUML
    {
        /// <summary>
        /// Объект класса
        /// </summary>
        private static CoreUML _coreUML;
        /// <summary>
        /// Общий лист всех фигур, стрелок на холсте
        /// </summary>
        public List<IFigure> Figures { get; set; }
        /// <summary>
        /// Временный лист выделенных фигур, стрелок на холсте
        /// </summary>
        public List<IFigure> SelectedFigures { get; set; }
        /// <summary>
        /// лист действий с фигурами, стрелками на холсте, для отмены действий.
        /// </summary>
        public List<int> LogActs { get; set; }
        public Bitmap BitmapMain { get; set; }
        public Bitmap BitmapTmp { get; set; }
        public Graphics Graphics { get; set; }
        /// <summary>
        /// Толщина линий
        /// </summary>
        public int Width { get; set; }
        public Color Color { get; set; }
        public Font Font { get; set; }
        /// <summary>
        /// Размер объектов для zoom.
        /// </summary>
        public float Size { get; set; }
        public string MyPath { get; set; }


        public static CoreUML GetCoreUML()
        {
            if (_coreUML is null)
            {
                _coreUML = new CoreUML();
            }
            return _coreUML;
        }

        private CoreUML()
        {
            Figures = new List<IFigure>();
            SelectedFigures = new List<IFigure>();
            LogActs = new List<int>();
            BitmapMain = new Bitmap(0, 0);
            BitmapTmp = new Bitmap(0, 0);
            Graphics = Graphics.FromImage(BitmapMain);
            Width = 1;
            Color = Color.Black;
            Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            Size = 1;
            MyPath = "";
        }








        public static bool SaveDate()
        {
            //BinaryConversion.SerializationDictionary();
            return true;
        }

        public static bool LoadData()
        {
            //BinaryConversion.DeserializationDictionary();
            return true;
        }
    }
}
