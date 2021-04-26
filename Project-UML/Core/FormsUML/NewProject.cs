using System;
using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.DataProject.Binary;
using Project_UML.Core.DataProject.Json;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.MousHandlers;
using Project_UML.Core.Interfaces;
using System.Collections.Generic;
using Project_UML.Core.Arrows;
using Project_UML.Core.Enum;
using System.Windows.Forms;
using System.Drawing;
using Project_UML.Core.Boxes;


namespace Project_UML.Core.FormsUML
{
    /// <summary>
    /// 
    /// </summary>
    public partial class NewProject : Form
    {
        private Help _help;
        private bool isHelp = false;
        private PreparationData _data;
        private Font _fontBold;
        private Font _fontUnderline;
        private Font _fontItalic;
        private Font _fontSize;
        private Form _menu;
        private bool _isControlKeyOn = false;
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private IMouseHandler _crntMH = new MouseHandlerOnSelection();
        private IMouseHandler _tmpCrntMH;
        private bool _isUndo;
        private bool _isClearLog;
        private bool _isClearLogBack;


        public NewProject(Form menu)
        {
            InitializeComponent();
            LoadSettings load = new LoadSettings();
            StructSettings settings = load.ReadSettings();
            if (settings != null)
            {
                _coreUML.LoadCoreUML(settings);
            }
            _coreUML.IsLoading = true;
            UpdateSettingsForm();
            _menu = menu;
        }
        public void Loading(PreparationData data)
        {
            ProcessingData deserializeData = new ProcessingData(data);
            deserializeData.LoadingData(deserializeData);
            TrackBarOfWidth.Value = _coreUML.DefaultWidth;
            ButtonColor.BackColor = _coreUML.DefaultColor;
            int tmp;
            switch(_coreUML.DefaultStep.X)
            {
                case 5:
                    tmp = 1;
                    break;
                case 10:
                    tmp = 2;
                    break;
                case 15:
                    tmp = 3;
                    break;
                case 20:
                    tmp = 4;
                    break;
                case 25:
                    tmp = 5;
                    break;
                default:
                    tmp = 1;
                    break;
            }
            trackBarOfStep.Value = tmp;
            _coreUML.UpdPicture();
        }

        private void UpdateSettingsForm()
        {
            ButtonColor.BackColor = _coreUML.DefaultColor;
            TrackBarOfWidth.Value = _coreUML.DefaultWidth;
            int tmp;
            switch (_coreUML.DefaultStep.X)
            {
                case 5:
                    tmp = 1;
                    break;
                case 10:
                    tmp = 2;
                    break;
                case 15:
                    tmp = 3;
                    break;
                case 20:
                    tmp = 4;
                    break;
                case 25:
                    tmp = 5;
                    break;
                default:
                    tmp = 1;
                    break;
            }
            trackBarOfStep.Value = tmp;
            PreparationFont();
        }

        private void PreparationFont()
        {
            FontChange.Font = _coreUML.DefaultFont;
            FontChange.Text = _coreUML.DefaultFont.Name;
            FontChange.Font = new Font(FontChange.Font.FontFamily, 8);

            _fontBold = FontChange.Font;
            _fontItalic = FontChange.Font;
            _fontUnderline = FontChange.Font;
            _fontSize = FontChange.Font;

            FontBold.Font = new Font(_fontBold, FontStyle.Regular);
            if (_coreUML.DefaultFont.Bold)
            {
                FontBold.Font = new Font(_fontBold, FontStyle.Bold);
            }

            FontItalic.Font = new Font(_fontItalic, FontStyle.Regular);
            if (_coreUML.DefaultFont.Italic)
            {
                FontItalic.Font = new Font(_fontItalic, FontStyle.Italic);
            }

            FontUnderline.Font = new Font(_fontUnderline, FontStyle.Regular);
            if (_coreUML.DefaultFont.Underline)
            {
                FontUnderline.Font = new Font(_fontUnderline, FontStyle.Underline);
            }

            _fontSize = new Font(_fontSize.FontFamily, 8);
            FontSize.Text = _coreUML.DefaultFont.Size.ToString();
        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            if (_isControlKeyOn)
            {
                if (e.Delta > 0)
                {
                    ScrollSizeUp();
                }
                else
                {
                    ScrollSizeDown();
                }
            }
        }
        private void ScrollSizeUp()
        {
            if (_coreUML.DefaultSize < 20)
            {
                _coreUML.DefaultSize++;
                _coreUML.ScrollSize(true);
            }
        }
        private void ScrollSizeDown()
        {
            if (_coreUML.DefaultSize > -20)
            {
                _coreUML.DefaultSize--;
                _coreUML.ScrollSize(false);
            }
        }
        private void ScrollSizeBase()
        {
            if (_coreUML.DefaultSize != 0)
            {
                if (_coreUML.DefaultSize > 0)
                {
                    _coreUML.ScrollSize(false, _coreUML.DefaultSize);
                }
                else
                {
                    _coreUML.ScrollSize(true, -_coreUML.DefaultSize);
                }
                _coreUML.DefaultSize = 0;
            }
        }

        private void NewProject_Load(object sender, EventArgs e)
        {
            _coreUML.BitmapMain = new Bitmap(Canvas.Width, Canvas.Height);
            _coreUML.BitmapTmp = new Bitmap(Canvas.Width, Canvas.Height);
            _coreUML.Graphics = Graphics.FromImage(_coreUML.BitmapMain);
            _coreUML.Graphics.Clear(Color.White);
            _coreUML.PictureBox = Canvas;
            Canvas.Image = _coreUML.BitmapMain;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _crntMH.MouseDown(e.Location);
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _crntMH.MouseUp(e.Location);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _crntMH.MouseMove(e.Location);
        }


        private void ButtonColor_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            _coreUML.DefaultColor = ColorDialog.Color;
            ButtonColor.BackColor = ColorDialog.Color;
            if (_coreUML.SelectedFigures.Count > 0)
            {
                _coreUML.ChangeColorInSelectedFigures(ColorDialog.Color);
                _coreUML.UpdPicture();
            }
        }

        private void ButtonAggregation_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawArrows(new AggregationArrowFactory());
        }

        private void ButtonComposition_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawArrows(new CompositionArrowFactory());
        }

        private void ButtonInheritance_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawArrows(new InheritanceArrowFactory());
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnSelection();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            //_act = Act.Clear;
            //if (!(_currentArrow is null))
            //{
            //    _arrows.Remove(_currentArrow);
            //    _currentArrow = null;
            //UpdPicture();
            //}
            foreach (IFigure figure in _coreUML.SelectedFigures)
            {
                _coreUML.WriteLogs(figure, false);
                _coreUML.Figures.Remove(figure);
                _coreUML.WriteLogs(null, true);
            }
            _coreUML.SelectedFigures.Clear();
            _coreUML.UpdPicture();
            _crntMH = new MouseHandlerOnSelection();
        }

        private void TrackBarOfWidth_Scroll(object sender, EventArgs e)
        {
            _coreUML.DefaultWidth = TrackBarOfWidth.Value;
            if (_coreUML.SelectedFigures.Count > 0)
            {
                _coreUML.ChangeWidthInSelectedFigures(TrackBarOfWidth.Value);
                _coreUML.UpdPicture();
            }
            _coreUML.DefaultWidth = TrackBarOfWidth.Value;
        }
        private void TrackBarOfStep_Scroll(object sender, EventArgs e)
        {
            _coreUML.DefaultStep = new Step(5 * trackBarOfStep.Value);
        }

        private void ButtonImplementation_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawArrows(new ImplementationArrowFactory());
        }

        private void ButtonAssociation_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawArrows(new AssociationArrowFactory());
        }

        private void ButtonRectangleObject_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawRectangle(new RectangleObjectFactory());
        }

        private void ButtonRectangleEnum_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawRectangle(new RectangleEnumFactory());
        }

        private void ButtonRectangleInterface_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawRectangle(new RectangleInterfaceFactory());
        }

        private void ButtonRectangleClass_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawRectangle(new RectangleClassFactory());
        }

        /// <summary>
        /// KeyCode управления нажатий клавиши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region KeyCode
        private void KeyDown_Control(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch(e.KeyCode)
                {
                    case Keys.Delete:
                        ButtonClear_Click(sender, e);
                        return;
                    case Keys.Oemplus:
                        ScrollSizeUp();
                        return;
                    case Keys.OemMinus:
                        ScrollSizeDown();
                        return;
                    case Keys.D0:
                        ScrollSizeBase();
                        return;
                    case Keys.Up:
                        _coreUML.MoveByKey(e.KeyCode);
                        return;
                    case Keys.Down:
                        _coreUML.MoveByKey(e.KeyCode);
                        return;
                    case Keys.Left:
                        _coreUML.MoveByKey(e.KeyCode);
                        return;
                    case Keys.Right:
                        _coreUML.MoveByKey(e.KeyCode);
                        return;
                    case Keys.A:
                        Highlighting();                        
                        return;
                    case Keys.C:
                        _coreUML.SaveTmpFigure();
                        return;
                    case Keys.V:
                        _coreUML.LoadTmpFigure();
                        return;
                    case Keys.Z:
                        Press_Z(_coreUML.Logs);
                        return;
                    case Keys.R:
                        _coreUML.ReverseArrow();
                        return;
                    case Keys.S:
                        CoreUML.SaveDate();
                        MessageBox.Show("Сохранено");
                        return;
                    case Keys.L:
                        Press_L();                        
                        return;
                    case Keys.P:
                        _coreUML.SaveImage();
                        MessageBox.Show("Изображение сохранено");
                        return;
                } 
            }

            if(e.Alt)
            {
                switch (e.KeyCode)
                {
                    case Keys.Z:
                        Press_Revert_Z(_coreUML.LogsBack);
                        return;
                }
            }

            switch(e.KeyCode)
            {
                case Keys.ControlKey:
                    _isControlKeyOn = true;
                    return;
                case Keys.Escape:
                    Press_Escape();
                    return;
                case Keys.F1:
                    Press_F1();
                    return;
            }
        }

        private void Press_Revert_Z(List<LogActs> logs)
        {
            if (_isClearLog)
            {
                _coreUML.Logs.Clear();
            }
            _isClearLog = false;
            _isClearLogBack = true;
            _isUndo = false;
            if (logs.Count > 0)
            {
                
                UndoAct(logs[logs.Count - 1], logs);
            }
            else
            {
                MessageBox.Show("Нет действий для отмены");
            }
            
        }
        private void Press_Z(List<LogActs> logs)
        {
            if (_isClearLogBack)
            {
                _coreUML.LogsBack.Clear();
                _isClearLogBack = false;
            }
            _isClearLog = true;
            _isUndo = true;
            _coreUML.CheckCountLogs();
            if (logs.Count > 0)
            {                
                UndoAct(logs[logs.Count - 1], logs);
            }
            else
            {
                MessageBox.Show("Сохраненых предыдущих дейстий нет");
            }
        }

        private void UndoAct(LogActs log, List<LogActs> list)
        {
            if (!(log.New is null))
            {
                if (_isUndo)
                {
                    _coreUML.WriteLogsBack(log.New, true);
                }
                else
                {
                    _coreUML.WriteLogs(log.New, false);
                }
                int index = _coreUML.Figures.IndexOf(log.New);
                if (!(log.Previous is null))
                {
                    if (_isUndo)
                    {
                        _coreUML.WriteLogsBack(log.Previous, false);
                    }
                    else
                    {
                        _coreUML.WriteLogs(log.Previous, true);
                    }
                    LogNewFigureIsNull(index, log, list);
                }
                else
                {
                    if (_isUndo)
                    {
                        _coreUML.WriteLogsBack(null, false);
                    }
                    else
                    {
                        _coreUML.WriteLogs(null, true);
                    }
                    if (index != -1)
                    {
                        _coreUML.Figures.RemoveAt(index);
                    }
                }
            }
            else
            {
                if (_isUndo)
                {
                    _coreUML.WriteLogsBack(null, true);
                }
                else
                {
                    _coreUML.WriteLogs(null, false);
                }
                _coreUML.Figures.Add(log.Previous);
                if (_isUndo)
                {
                    _coreUML.WriteLogsBack(log.Previous, false);
                }
                else
                {
                    _coreUML.WriteLogs(log.Previous, true);
                }
            }
            _coreUML.SelectedFigures.Clear();
            
            list.RemoveAt(list.Count - 1);
            _coreUML.UpdPicture();
        }
        private void LogNewFigureIsNull(int index, LogActs log, List<LogActs> list)
        {
            foreach (LogActs act in list)
            {
                if (act.New == _coreUML.Figures[index])
                {
                    act.New = log.Previous;
                }
            }
            _coreUML.Figures[index] = log.Previous;
        }
        
        private void Press_L()
        {
            _data = _coreUML.LoadData(_menu);
            if (_data != null)
            {
                Dispose();
            }
            if (_coreUML.MyPath == "")
            {
                MessageBox.Show("Последнее сохранение не определено, повторите попытку, после создания нового сохранения");
            }
            else
            {
                MessageBox.Show("Загружено");
            }
        }
        private void Press_F1()
        {
            if (isHelp)
            {
                _help.Dispose();
            }
            else
            {
                _help = new Help();
                _help.Show();
            }
            isHelp = !isHelp;
        }
        private void Press_Escape()
        {
            Enabled = false;
            Menu menu = new Menu(_menu, this);
            menu.Show();
        }
        private void Highlighting()
        {
            _tmpCrntMH = _crntMH;
            _crntMH = new MouseHandlerOnSelection();
            _coreUML.SelectedFigures.Clear();
            _coreUML.SelectedFigures.AddRange(_coreUML.Figures);
            _crntMH.MouseUp(new Point(0, 0));
            _crntMH = _tmpCrntMH;
        }

        /// <summary>
        /// KeyCode управления отпускания клавиши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyUpControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                _isControlKeyOn = false;
            }
        }

        /// <summary>
        /// KeyCode управления клавишами по их имени/символу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyPressControl(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == '=' && _isControlKeyOn)
            //{
            //    string sss = "";
            //}
            //if (e.KeyChar == '-' && _isControlKeyOn)
            //{
            //    string sss = "";
            //}
        }
        #endregion

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnTransform();
        }

        private void ButtonMove_Click_1(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnMove();
        }
               

        private void UpdateRectText_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && _crntMH.CoreUML.SelectedFigures != null)
            {
                string selectedArea = comboBox1.SelectedItem.ToString();

                string areaText = richTextBox1.Text;
                switch (selectedArea)
                    {
                        case "Name":                            
                            _coreUML.ChangeName(areaText, 0);
                        break;
                        case "Field":
                            _coreUML.ChangeName(areaText, 1);
                            break;
                        case "Property":
                            _coreUML.ChangeName(areaText, 2);
                            break;
                        case "Methods":
                            _coreUML.ChangeName(areaText, 3);
                            break;
                    }
            }
        }
        private void GetCurrentText_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && _crntMH.CoreUML.SelectedFigures != null)
            {
                string selectedArea = comboBox1.SelectedItem.ToString();
                
                switch (selectedArea)
                {
                    case "Name":
                        richTextBox1.Text = _coreUML.GetName(0);
                        break;
                    case "Field":
                        richTextBox1.Text = _coreUML.GetName(1);
                        break;
                    case "Property":
                        richTextBox1.Text = _coreUML.GetName(2);
                        break;
                    case "Methods":
                        richTextBox1.Text = _coreUML.GetName(3);
                        break;
                }
            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            FontDialog.ShowDialog();
            _coreUML.DefaultFont = FontDialog.Font;
            FontChange.Text = FontDialog.Font.Name;
            if (_coreUML.SelectedFigures.Count > 0)
            {
                _coreUML.ChangeColorInSelectedFigures(ColorDialog.Color);
                _coreUML.UpdPicture();
            }
            PreparationFont();
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            SetMyPath pathImage = new SetMyPath();
            pathImage.MyPathImage();
            if (_coreUML.MyPathImage != "")
            {
                _coreUML.SaveImage();
                MessageBox.Show("Изображение сохранено");
            }
            else
            {
                MessageBox.Show("Не удалось сохранить изображение");
            }
        }
        private void NewProject_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (!(_help is null))
            {
                _help.Dispose();
            }            
            _menu.Close();
        }

    }
}