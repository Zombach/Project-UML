using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Arrows;
using System.Drawing;
using System.Windows.Forms;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.DataProject;
using Project_UML.Core.Boxes;

namespace Project_UML.Core
{
    /// <summary>
    /// Singletone Core, ядро програмы управляющее всем
    /// </summary>
    public class CoreUML
    {
        //God класс
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
        public int DefaultSize { get; set; }
        public string MyPath { get; set; }

        /// <summary>
        /// Временные поля (заглушки)
        /// </summary>
        public Axises AxisStart = Axises.X;
        public Axises AxisEnd = Axises.X;

        public bool IsLoading { get; set; } = false;


        private CoreUML()
        {
            Figures = new List<IFigure>();
            SelectedFigures = new List<IFigure>();
            Logs = new List<LogActs>();
            DefaultWidth = 1;
            DefaultColor = Color.Black;
            DefaultFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            DefaultSize = 0;
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
            double dd = GC.GetTotalMemory(true);
            if (GC.GetTotalMemory(true) > 9999073741824)
            {
                GC.Collect();
            }
        }

        public void ChangeColorInSelectedFigures(Color color )
        {
            foreach (IFigure figure in SelectedFigures)
            {
                figure.ChangeColor(color);
            }
        }
        public void ChangeWidthInSelectedFigures(int width )
        {
            foreach (IFigure figure in SelectedFigures)
            {
                figure.ChangeWidth(width);
            }
        }

        public void UpdPicture()
        {
            Graphics = Graphics.FromImage(BitmapMain);
            Graphics.Clear(Color.White);
            foreach (IFigure figure in Figures) figure.Draw(Graphics);
            if (SelectedFigures.Count != 0)
            {
                SwitchToDrawInTmp();
                DrawSelectionOfFigures();
                PictureBox.Image = BitmapTmp;
            }
            else
            {
                PictureBox.Image = BitmapMain;
            }
            Graphics = Graphics.FromImage(BitmapMain);
        }

        public void DrawSelectionOfFigures()
        {
            foreach (IFigure figure in SelectedFigures)
            {
                figure.Select(Graphics);
            }
        }

        public void ScrollSize(bool isIncrease)
        {
            foreach (IFigure  figure in Figures)
            {
                if (figure is AbstractArrow arrow)
                {
                    for(int i = 0; i < arrow.Points.Count; i++)
                    {
                        Point point = Scroll(arrow.Points[i], isIncrease);
                        arrow.Points[i] = point;
                    }
                }
                if (figure is AbstractBox box)
                {
                    for (int i = 0; i < box.Points.Count; i++)
                    {
                        Point point = Scroll(box.Points[i], isIncrease);
                        box.Points[i] = point;
                    }
                }
            }
        }

        public Point Scroll(Point point, bool isIncrease)
        {
            double X , Y;
            if (isIncrease)
            {
                X = Math.Round(point.X + point.X * 0.01);
                Y = Math.Round(point.Y + point.Y * 0.01);
            }
            else
            {
                X = Math.Round(point.X - point.X * 0.00990099);
                Y = Math.Round(point.Y - point.Y * 0.00990099);
            }
            Point newPoint = new Point((int)X, (int)Y);
            return newPoint;
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
