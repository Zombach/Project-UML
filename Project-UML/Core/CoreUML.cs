﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Arrows;
using System.Drawing;
using System.Windows.Forms;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.DataProject.Binary;
using Project_UML.Core.Boxes;
using Project_UML.Core.DataProject.Structure;

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
        public List<IFigure> TmpFigures { get; set; }
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
        public int DefaultWidth { get; set; }
        /// <summary>
        /// Размер объектов для zoom.
        /// </summary>
        public int DefaultSize { get; set; }
        public Step DefaultStep { get; set; }
        public string MyPath { get; set; }
        public string MyPathSettings { get; set; }

        /// <summary>
        /// Временные поля (заглушки)
        /// </summary>
        public Axis AxisStart = Axis.X;
        public Axis AxisEnd = Axis.X;

        public bool IsLoading { get; set; } = false;


        private CoreUML()
        {
            Figures = new List<IFigure>();
            SelectedFigures = new List<IFigure>();
            TmpFigures = new List<IFigure>();
            Logs = new List<LogActs>();
            DefaultWidth = 1;
            DefaultColor = Color.Black;
            DefaultFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            DefaultSize = 0;
            DefaultStep = new Step(5, 5);
            MyPath = "";
            MyPathSettings = @"../../Core/Settings.txt";
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
            if (GC.GetTotalMemory(true) > 9999073741824)
            {
                GC.Collect();
            }
        }
        public void ChangeFontInSelectedFigures(Font font)
        {
            foreach (IFigure figure in SelectedFigures)
            {
                if(figure is AbstractBox box)
                {
                    box.ChangeFont(font);
                }
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
            SwitchToDrawInTmp();
            foreach (IFigure figure in SelectedFigures)
            {
                figure.Select(Graphics);
            }
        }

        public void ScrollSize(bool isIncrease, int multi = 1)
        {
            foreach (IFigure  figure in Figures)
            {
                if (figure is AbstractArrow arrow)
                {
                    for(int i = 0; i < arrow.Points.Count; i++)
                    {
                        Point point = Scroll(arrow.Points[i], isIncrease, multi);
                        arrow.Points[i] = point;
                    }
                }
                if (figure is AbstractBox box)
                {
                    for (int i = 0; i < box.Points.Count; i++)
                    {
                        Point point = Scroll(box.Points[i], isIncrease, multi);
                        box.Points[i] = point;
                    }
                    box.RectangleHeight = box.SizeHeight();
                    box.RectangleWidth = box.SizeWidth();
                }
            }
            UpdPicture();
        }

        public Point Scroll(Point point, bool isIncrease, int multi = 1)
        {
            double X = point.X;
            double Y = point.Y;
            for (int i = 0; i < multi; i++)
            {
                if (isIncrease)
                {
                    X = Math.Round(X + X * 0.01);
                    Y = Math.Round(Y + Y * 0.01);
                }
                else
                {
                    X = Math.Round(X - X * 0.00990099);
                    Y = Math.Round(Y - Y * 0.00990099);
                }
            }
            Point newPoint = new Point((int)X, (int)Y);
            return newPoint;
        }

        public void MoveByKey(Keys key)
        {
            Step tmpStep = new Step(DefaultStep);
            if (SelectedFigures.Count == 0)
            {
                SelectedFigures.AddRange(Figures);
            }
            
            switch (key)
            {
                case Keys.Left:
                    tmpStep = SetStep(tmpStep, 1, 0);
                    break;
                case Keys.Right:
                    tmpStep = SetStep(tmpStep, -1, 0);
                    break;
                case Keys.Up:
                    tmpStep = SetStep(tmpStep, 0, 1);
                    break;
                case Keys.Down:
                    tmpStep = SetStep(tmpStep, 0, -1);
                    break;
            }

            foreach (IFigure figure in SelectedFigures)
            {
                if (figure is AbstractArrow arrow)
                {
                    for (int i = 0; i < arrow.Points.Count; i++)
                    {
                        Point point = new Point(arrow.Points[i].X - tmpStep.X, arrow.Points[i].Y - tmpStep.Y);
                        arrow.Points[i] = point;
                    }
                }
                if (figure is AbstractBox box)
                {
                    for (int i = 0; i < box.Points.Count; i++)
                    {
                        Point point = new Point(box.Points[i].X - tmpStep.X, box.Points[i].Y - tmpStep.Y);
                        box.Points[i] = point;
                    }
                }
            }
            UpdPicture();
        }

        public void SaveTmpFigure()
        {
            TmpFigures.Clear();
            foreach (IFigure figure in SelectedFigures)
            {
                var copyFigure = Activator.CreateInstance(Type.GetType(figure.GetType().FullName), figure);
                TmpFigures.Add((IFigure)copyFigure);
            }
        }

        public void LoadTmpFigure()
        {
            SelectedFigures.Clear();
            foreach (IFigure figure in TmpFigures)
            {
                var copyFigure = Activator.CreateInstance(Type.GetType(figure.GetType().FullName), figure);
                SelectedFigures.Add((IFigure)copyFigure);
            }
            MoveByKey(Keys.Left);
            MoveByKey(Keys.Up);
            Figures.AddRange(SelectedFigures);
            UpdPicture();
        }

        public void ReverseArrow()
        {
            foreach (IFigure figure in SelectedFigures)
            {
                if (figure is AbstractArrow arrow)
                {
                    arrow.Reverse();
                }
            }
            UpdPicture();
        }

        public static bool SaveDate()
        {
            Serialize serializer = new Serialize();
            serializer.SerializationDictionary();
            return true;
        }

        public void LoadData(ProcessingData data)
        {
            Deserialize deserializer = new Deserialize();
            deserializer.DeserializationDictionary();
        }

        public void LoadCoreUML(StructSettings setting)
        {
            _coreUML.DefaultColor = setting.DefaultColor;
            _coreUML.DefaultFont = setting.DefaultFont;
            _coreUML.DefaultSize = setting.DefaultSize;
            _coreUML.DefaultStep = setting.DefaultStep;
            _coreUML.DefaultWidth = setting.DefaultWidth;
        }
        private Step SetStep(Step step, int x, int y)
        {
            step.X *= x;
            step.Y *= y;
            return step;
        }

        public void ChangeName(string name)
        {
            foreach (IFigure figure in SelectedFigures)
                if (figure is AbstractBox box)
                    {
                        box.Name[0] = name;
                        UpdPicture();
                    }
        }
    }
}
