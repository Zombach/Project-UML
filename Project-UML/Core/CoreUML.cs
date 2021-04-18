using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Arrows;
using Project_UML.Core.Serialize;
using System.Drawing;
using System.Windows.Forms;
using Project_UML.Core.FigureFactory;

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
        public List<LogActs> Logs { get; set; }
        public Bitmap BitmapMain { get; set; }
        public Bitmap BitmapTmp { get; set; }
        public Graphics Graphics { get; set; }

        public PictureBox PictureBox { get; set; }
        /// <summary>
        /// Толщина линий
        /// </summary>
        public Color DefaultColor { get; set; }
        public Font DefaultFont { get; set; }
        public float DefaultWidth { get; set; }
        /// <summary>
        /// Размер объектов для zoom.
        /// </summary>
        public float DefaultSize { get; set; }
        public string MyPath { get; set; }

        /// <summary>
        /// Временные поля (заглушки)
        /// </summary>
        public Axises AxisStart = Axises.X;
        public Axises AxisEnd = Axises.X;

        public bool isLoading { get; set; } = false;


        private CoreUML()
        {
            Figures = new List<IFigure>();
            SelectedFigures = new List<IFigure>();
            Logs = new List<LogActs>();
            DefaultWidth = 1;
            DefaultColor = Color.Black;
            DefaultFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            DefaultSize = 1F;
            MyPath = "";
        }


        public static CoreUML GetCoreUML()
        {
            if (_coreUML is null)
            {
                _coreUML = new CoreUML();
            }
            return _coreUML;
        }

        public void SwitchToDrawInTmp()
        {
            BitmapTmp = (Bitmap)BitmapMain.Clone();
            Graphics = Graphics.FromImage(BitmapTmp);
        }

        private void UpdPicture()
        {
            Graphics = Graphics.FromImage(BitmapTmp);
            Graphics.Clear(Color.White);
            foreach (IFigure figure in Figures) figure.Draw(Graphics);
            if (SelectedFigures.Count != 0)
            {
                SwitchToDrawInTmp();
                foreach (IFigure selectedFigure in SelectedFigures)
                {
                    selectedFigure.Select(/*Graphics*/);
                }
                PictureBox.Image = BitmapTmp;
            }
            else
            {
                PictureBox.Image = BitmapMain;
            }
            Graphics = Graphics.FromImage(BitmapMain);
        }








        public static bool SaveDate()
        {
            BinaryConversion binaryConversion = new BinaryConversion();
            binaryConversion.SerializationDictionary();
            return true;
        }

        public static bool LoadData()
        {
            BinaryConversion binaryConversion = new BinaryConversion();
            binaryConversion.DeserializationDictionary();
            return true;
        }
    }
}
