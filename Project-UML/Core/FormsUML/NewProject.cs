using System;
using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.DataProject.Binary;
using Project_UML.Core.DataProject.Json;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.MousHandlers;
using Project_UML.Core.Interfaces;
using System.Collections.Generic;
using Project_UML.Core.Arrows;
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
        private Font _fontBold;
        private Font _fontUnderline;
        private Font _fontItalic;
        private Form _menu;
        private bool _isControlKeyOn = false;
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private List<AbstractArrow>  _arrows = new List<AbstractArrow>();
        private IMouseHandler _crntMH = new MouseHandlerOnSelection();
        private IMouseHandler _tmpCrntMH;
        

        public NewProject(Form menu)
        {
            InitializeComponent();
            LoadSettings load = new LoadSettings();
            StructSettings settings = load.ReadSettings();
            _coreUML.LoadCoreUML(settings);
            UpdateSettingsForm();
            _menu = menu;
        }
        public void Loading(PreparationData data)
        {
            ProcessingData deserializeData = new ProcessingData(data);
            deserializeData.LoadingData(deserializeData);
            TrackBarOfWidth.Value = _coreUML.DefaultWidth;
            ButtonColor.BackColor = _coreUML.DefaultColor;
            trackBarOfStep.Value = _coreUML.DefaultStep.X;
            _coreUML.UpdPicture();
        }

        public void UpdateSettingsForm()
        {
            ButtonColor.BackColor = _coreUML.DefaultColor;
            TrackBarOfWidth.Value = _coreUML.DefaultWidth;
            trackBarOfStep.Value = 1;
            FontChange.Text = _coreUML.DefaultFont.Name;
            FontChange.Font = _coreUML.DefaultFont;

            PreparationFont();

            if (_coreUML.DefaultFont.Bold)
            {
                FontBold.Font = new Font(_fontBold, FontStyle.Bold);
            }

            if (_coreUML.DefaultFont.Italic)
            {
                FontItalic.Font = new Font(_fontItalic, FontStyle.Italic);
            }

            if (_coreUML.DefaultFont.Underline)
            {
                FontUnderline.Font = new Font(_fontUnderline, FontStyle.Underline);
            }

            FontSize.Font = new Font(_coreUML.DefaultFont.FontFamily, _coreUML.DefaultFont.Size);

        }

        private void PreparationFont()
        {
            _fontBold = _coreUML.DefaultFont;
            _fontItalic = _coreUML.DefaultFont;
            _fontUnderline = _coreUML.DefaultFont;
            _fontBold = new Font(_fontBold, FontStyle.Regular);
            _fontItalic = new Font(_fontItalic, FontStyle.Regular);
            _fontUnderline = new Font(_fontUnderline, FontStyle.Regular);
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

            //    case Act.Clear:
            //        foreach (AbstractArrow arrow in _arrows)
            //        {
            //            selected = arrow.CheckSelection(_point);
            //            if (selected)
            //            {
            //                _arrows.Remove(arrow);
            //                UpdPicture();
            //                break;
            //            }
            //        }
            //        break;
            //    case Act.Rectangle:
            //        _currentBox = new BestRectangles(e.X, e.Y);
            //        _currentBox.Draw(_graphics);
            //        break;
            //}
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _crntMH.MouseUp(e.Location);
            //switch (_act)
            //{
            //    
            //    //case Act.Rectangle:
            //    case Act.Rectangle:
            //        if (_isTapped) _bitmap = (Bitmap)_bitmapTmp.Clone();
            //        //_boxes.Add(_currentBox);
            //        //_currentBox.Select(_graphics);
            //        pictureBox1.Invalidate();
            //        break;

            //}
            ////CoreUML.Figures.Add(_currentArrow.Points[0].X);
            ////CoreUML.Figures.Add(_currentArrow.Points[0].Y);
            ////CoreUML.Figures.Add(_currentArrow.Points[_currentArrow.Points.Count - 1].X);
            ////CoreUML.Figures.Add(_currentArrow.Points[_currentArrow.Points.Count - 1].Y);
            //_isTapped = false;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _crntMH.MouseMove(e.Location);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _coreUML.AxisStart = Axis.X;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _coreUML.AxisStart = Axis.Y;
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            _coreUML.AxisEnd = Axis.X;
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            _coreUML.AxisEnd = Axis.Y;
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
                _coreUML.Figures.Remove(figure);
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

        #region KeyCode
        /// <summary>
        /// KeyCode управления нажатий клавиши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyDown_Control(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                _isControlKeyOn = true;
            }            
        }

        private void KeyDown_Esc(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Menu menu = new Menu(_menu, this);
                Enabled = false;
                menu.Show();
            }
        }
        private void KeyDown_Del(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Control)
            {
                ButtonClear_Click(sender, e);
            }
        }
        private void KeyDown_Plus(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemplus && e.Control)
            {
                ScrollSizeUp();
            }
        }
        private void KeyDown_Minus(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemMinus && e.Control)
            {
                ScrollSizeDown();
            }
        }
        private void KeyDown_Zero(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 && e.Control)
            {
                ScrollSizeBase();
            }
        }
        private void KeyDown_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && e.Control)
            {
                _coreUML.MoveByKey(e.KeyCode);
            }
        }
        private void KeyDown_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && e.Control)
            {
                _coreUML.MoveByKey(e.KeyCode);
            }
        }
        private void KeyDown_Left(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && e.Control)
            {
                _coreUML.MoveByKey(e.KeyCode);
            }
        }
        private void KeyDown_Right(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && e.Control)
            {
                _coreUML.MoveByKey(e.KeyCode);
            }
        }
        private void KeyDown_A(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                _tmpCrntMH = _crntMH;
                _crntMH = new MouseHandlerOnSelection();
                _coreUML.SelectedFigures.Clear();
                _coreUML.SelectedFigures.AddRange(_coreUML.Figures);
                _crntMH.MouseUp(new Point(0, 0));
                _crntMH = _tmpCrntMH;
            }
        }
        private void KeyDown_C(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Control)
            {
                _coreUML.SaveTmpFigure();
            }
            
        }
        private void KeyDown_V(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Control)
            {
                _coreUML.LoadTmpFigure();
            }
        }
        private void KeyDown_Z(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && e.Control)
            {
            }
        }
        private void KeyDown_R(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && e.Control)
            {
                _coreUML.ReverseArrow();
            }
        }
        private void KeyDown_S(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S && e.Control)
            {
                CoreUML.SaveDate();
                MessageBox.Show("Сохранено");
            }
        }
        private void KeyDown_L(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L && e.Control)
            {

                MessageBox.Show("Загружено");
            }
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
        
        private void NewProject_FormClosing(Object sender, FormClosingEventArgs e)
        {
            SaveSettings sss = new SaveSettings();
            sss.WriteSettings();
        }

        private void buttonUpdateRectText_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && _crntMH.CoreUML.SelectedFigures != null)
            {
                string selectedArea = comboBox1.SelectedItem.ToString();

                string areaText = richTextBox1.Text;
                foreach (IFigure figure in _coreUML.SelectedFigures)
                {
                    switch (selectedArea)
                    {
                        case "Name":
                            _coreUML.ChangeName(areaText);
                        break;
                        case "Field":

                            break;
                        case "Property":

                            break;
                        case "Methods":

                            break;
                    }
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
        }
    }
}