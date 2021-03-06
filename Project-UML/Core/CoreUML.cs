using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_UML.Core.Interfaces;
using Project_UML.Core.Arrows;
using Project_UML.Core.Enum;
using System.Drawing;
using System.Windows.Forms;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.DataProject.Binary;
using Project_UML.Core.Boxes;
using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.FormsUML;
using System.Drawing.Imaging;

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
        private PreparationData _data;
        private Deserialize _deserializer;
        private LogActs _log = new LogActs();
        public bool IsLoading { get; set; } = false;
        public bool IsLicense { get; set; }
        public int DefaultWidth { get; set; }
        /// <summary>
        /// Размер объектов для zoom.
        /// </summary>
        public int DefaultSize { get; set; }
        public string MyPath { get; set; }
        public string MyPathEncrypt { get; set; }
        public string MyPathEncryptSave { get; set; }
        public string MyPathSettings { get; set; }
        public string MyPathImage { get; set; }
        public string TmpKeyEncript { get; set; }

        /// <summary>
        /// Общий лист всех фигур, стрелок на холсте
        /// </summary>
        public List<IFigure> Figures { get; set; }
        /// <summary>
        /// Временный лист выделенных фигур, стрелок на холсте
        /// </summary>
        public List<IFigure> SelectedFigures { get; set; }
        public List<IFigure> TmpFigures { get; set; }
        public List<IFigure> TempFig { get; set; }
        /// <summary>
        /// лист действий с фигурами, стрелками на холсте, для отмены действий.
        /// </summary>
        public List<LogActs> Logs { get; set; }
        public List<LogActs> LogsBack { get; set; }
        public Bitmap BitmapMain { get; set; }
        public Bitmap BitmapTmp { get; set; }
        public Graphics Graphics { get; set; }
        public PictureBox PictureBox { get; set; }
        /// <summary>
        /// Толщина линий
        /// </summary>
        public Color DefaultColor { get; set; }
        public Font DefaultFont { get; set; }
        public Step DefaultStep { get; set; }


        private CoreUML()
        {
            Figures = new List<IFigure>();
            SelectedFigures = new List<IFigure>();
            TmpFigures = new List<IFigure>();
            Logs = new List<LogActs>();
            LogsBack = new List<LogActs>();
            DefaultWidth = 1;
            DefaultColor = Color.Black;
            DefaultFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            DefaultSize = 0;
            DefaultStep = new Step(5, 5);
            MyPath = "";            
            MyPathSettings = @"../../Resources/txt/Settings.txt";
            MyPathEncryptSave = @"../../Save/Encrypt/";
            MyPathImage = @"../../Save/Image/";
            TmpKeyEncript = "";
            IsLicense = false;
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
                    WriteLogs(box, false);
                    box.ChangeFont(font);
                    WriteLogs(box, true);
                }
            }
        }

        public void ChangeColorInSelectedFigures(Color color )
        {
            foreach (IFigure figure in SelectedFigures)
            {
                WriteLogs(figure, false);
                figure.ChangeColor(color);
                WriteLogs(figure, true);
            }
        }

        public void ChangeWidthInSelectedFigures(int width )
        {
            foreach (IFigure figure in SelectedFigures)
            {
                WriteLogs(figure, false);
                figure.ChangeWidth(width);
                WriteLogs(figure, true);
            }
        }

        public void UpdPicture()
        {
            Graphics = Graphics.FromImage(BitmapMain);
            Graphics.Clear(Color.White);
            foreach (IFigure figure in Figures)
            {
                if (figure != null)
                {
                    figure.Draw(Graphics);
                }
            }
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
            CheckCountLogs();
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
                    WriteLogs(arrow, false);
                    for (int i = 0; i < arrow.Points.Count; i++)
                    {
                        Point point = Scroll(arrow.Points[i], isIncrease, multi);
                        arrow.Points[i] = point;
                    }
                    WriteLogs(arrow, true);
                }
                if (figure is AbstractBox box)
                {
                    WriteLogs(box, false);
                    for (int i = 0; i < box.Points.Count; i++)
                    {
                        Point point = Scroll(box.Points[i], isIncrease, multi);
                        box.Points[i] = point;
                    }
                    box.RectangleHeight = box.SizeHeight();
                    box.RectangleWidth = box.SizeWidth();
                    WriteLogs(box, true);
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
                    WriteLogs(arrow, false);
                    for (int i = 0; i < arrow.Points.Count; i++)
                    {
                        Point point = new Point(arrow.Points[i].X - tmpStep.X, arrow.Points[i].Y - tmpStep.Y);
                        arrow.Points[i] = point;
                    }
                    WriteLogs(arrow, true);
                }
                if (figure is AbstractBox box)
                {
                    WriteLogs(box, false);
                    for (int i = 0; i < box.Points.Count; i++)
                    {
                        Point point = new Point(box.Points[i].X - tmpStep.X, box.Points[i].Y - tmpStep.Y);
                        box.Points[i] = point;
                    }
                    WriteLogs(box, true);
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
                WriteLogs(null, false);
                var copyFigure = Activator.CreateInstance(Type.GetType(figure.GetType().FullName), figure);
                WriteLogs((IFigure)copyFigure, true);
                SelectedFigures.Add((IFigure)copyFigure);
            }
            Figures.AddRange(SelectedFigures);
            UpdPicture();
        }

        public void ReverseArrow()
        {
            foreach (IFigure figure in SelectedFigures)
            {
                if (figure is AbstractArrow arrow)
                {
                    WriteLogs(arrow, false);
                    arrow.Reverse();
                    WriteLogs(arrow, true);
                }
            }
            UpdPicture();
        }

        public void SwapTypeArrow()
        {
            string[] typeArrow = new string[5]
            {
                "Project_UML.Core.Arrows.AggregationArrow",
                "Project_UML.Core.Arrows.AssociationArrow",
                "Project_UML.Core.Arrows.CompositionArrow",
                "Project_UML.Core.Arrows.ImplementationArrow",
                "Project_UML.Core.Arrows.InheritanceArrow"
            };
            IFigure newFigure = null;
            TempFig = new List<IFigure>();
            foreach (IFigure figure in SelectedFigures)
            {
                if (figure is AbstractArrow arrow)
                {
                    WriteLogs(arrow, false);                    

                    for (int i = 0; i < typeArrow.Length; i++)
                    {
                        if (typeArrow[i] == arrow.GetType().FullName)
                        {
                            int tmp = i + 1;
                            if (tmp == 5)
                            {
                                tmp = 1;
                            }
                            var newArrow = Activator.CreateInstance(Type.GetType(typeArrow[tmp]), (IFigure)arrow);
                            newFigure = (AbstractArrow)newArrow;
                            break;
                        }
                    }
                    WriteLogs(newFigure, true);
                    TempFig.Add(newFigure);
                    Figures.Remove(arrow);
                    Figures.Add(newFigure);
                }
                else
                {
                    TempFig.Add(figure);
                }
            }
            SelectedFigures.Clear();
            SelectedFigures.AddRange(TempFig);
            UpdPicture();
        }

        public void SaveImagePrepaire(bool isAs = false)
        {
            if (!isAs)
            {
                SetMyPath pathImage = new SetMyPath();
                pathImage.MyPathImage();
            }
            else
            {
                SetPathAs setPathAs = new SetPathAs();
                setPathAs.SetPathImage();
            }
            if (_coreUML.MyPathImage != "" && _coreUML.MyPathImage != null)
            {
                _coreUML.SaveImage();
                MessageBox.Show("Изображение сохранено");
            }
            else
            {
                MessageBox.Show("Не удалось сохранить изображение");
            }
        }
        

        public static bool SaveDate()
        {
            SetMyPath path = new SetMyPath();
            path.MyPath();
            Serialize serializer = new Serialize();
            serializer.SerializationDictionary();
            return true;
        }

        public PreparationData LoadData(Form menu)
        {
            if (_coreUML.MyPath == "")
            {
                MessageBox.Show("Последнее сохранение не определено, повторите попытку, после создания нового сохранения");
                _data = null;
            }
            else
            {
                SelectedFigures.Clear();
                Figures.Clear();
                _deserializer = new Deserialize();
                _data = _deserializer.DeserializationDictionary();
                if (_data != null)
                {
                    Loading(menu);
                }
            }
            return _data;
        }
        
        public void LoadCoreUML(StructSettings setting)
        {
            if (setting != null)
            {
                StructSettings EqSetting = SettingEquals(setting);
                DefaultColor = EqSetting.DefaultColor;
                DefaultFont = EqSetting.DefaultFont;
                //DefaultSize = EqSetting.DefaultSize;
                DefaultStep = EqSetting.DefaultStep;
                DefaultWidth = EqSetting.DefaultWidth;
                MyPath = EqSetting.Path;
            }
        }                

        private Step SetStep(Step step, int x, int y)
        {
            step.X *= x;
            step.Y *= y;
            return step;
        }

        public void ChangeName(string text, int index, string name)
        {            
            foreach (IFigure figure in SelectedFigures)
            {
                if (figure is AbstractBox box)
                {
                    WriteLogs(box, false);
                    box.ChangeFont(_coreUML.DefaultFont, name);
                    //box.ChangeColorText(_coreUML.DefaultColor, name);
                    box.RectangleText[index] = text;
                    WriteLogs(box, true);
                }
            }
            UpdPicture();
        }

        public string GetName(int index)
        {
            string name = "";
            foreach (IFigure figure in SelectedFigures)
                if (figure is AbstractBox box)
                {
                    WriteLogs(box, false);
                    name = box.RectangleText[index];
                    WriteLogs(box, true);
                }
            return name;
        }
        
        public void WriteLogs(IFigure figure, bool isNew)
        {
            if (!isNew)
            {
                WriteActsPrevious(figure, true);
            }
            else
            {
                _log.GetPrevious(_log, figure);
                Logs.Add(_log);
                _log = new LogActs();
            }
        }
        public void WriteLogsBack(IFigure figure, bool isNew)
        {
            if (!isNew)
            {
                WriteActsPrevious(figure, false);
            }
            else
            {
                _log.GetPrevious(_log, figure, false);
                LogsBack.Add(_log);
                _log = new LogActs();
            }
        }

        public void CheckCountLogs()
        {
            if (_coreUML.Logs.Count > 100)
            {
                List<LogActs> tmp = new List<LogActs>();
                int tmpIndex = _coreUML.Logs.Count - 1;
                int tmpCount = tmpIndex - 99;
                for (int i = tmpIndex; i >= tmpCount; i--)
                {
                    tmp.Add(_coreUML.Logs[i]);

                }
                _coreUML.Logs.Clear();
                for (int i = tmp.Count - 1; i >= 0; i--)
                {
                    _coreUML.Logs.Add(tmp[i]);
                }
                CheckCountLogs();
            }
        }

        private void WriteActsPrevious(IFigure figure, bool isNew)
        {
            IFigure previous = null;
            if (!(figure is null))
            {
                var newFigure = Activator.CreateInstance(Type.GetType(figure.GetType().FullName), figure);
                previous = (IFigure)newFigure;
            }            
            _log.GetNew(previous, isNew);
        }

        private void Loading(Form menu)
        {
            NewProject project = new NewProject(menu);
            _coreUML.SelectedFigures.Clear();
            project.Show();
            project.Loading(_data);
        }

        private void SaveImage()
        {
            _coreUML.BitmapMain.Save(MyPathImage, ImageFormat.Jpeg);
        }

        private StructSettings SettingEquals(StructSettings setting)
        {
            if (setting.DefaultColor == null)
            {
                setting.DefaultColor = Color.Black;
            }
            if (setting.DefaultFont is null)
            {
                setting.DefaultFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            }
            //if (setting.DefaultSize < -20 || setting.DefaultSize > 20)
            //{
            //    setting.DefaultSize = 0;
            //}
            if (setting.DefaultStep == null)
            {
                setting.DefaultStep = new Step(5);
            }
            if (setting.DefaultWidth <= 0 || setting.DefaultWidth > 5)
            {
                setting.DefaultWidth = 1;
            }
            if (setting.Path is null)
            {
                setting.Path = "";
            }
            return setting;
        }        
    }
}