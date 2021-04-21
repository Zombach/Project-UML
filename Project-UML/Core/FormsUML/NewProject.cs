using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Project_UML.Core.Arrows;
using Project_UML.Core.MousHandlers;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.Interfaces;
using Project_UML.Core.DataProject;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Project_UML.Core.Forms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class NewProject : Form
    {
        private bool _isControlKeyOn = false;
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        List<AbstractArrow> _arrows = new List<AbstractArrow>();
        IMouseHandler _crntMH = new MouseHandlerOnSelection();
        public NewProject(SerializeData data)
        {
            InitializeComponent();
            if (_coreUML.IsLoading)
            {
                DeserializeData deserializeData = new DeserializeData(data);
                deserializeData.LoadingData(deserializeData);
                trackBarOfWidth.Value = (int)_coreUML.DefaultWidth;
                ButtonColor.BackColor = _coreUML.DefaultColor;
                _coreUML.IsLoading = false;
            }
        }

        public NewProject()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(OnMouseWheel);

        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            if(_isControlKeyOn)
            {
                if (e.Delta > 0)
                {
                    if (_coreUML.DefaultSize < 20)
                    {
                        _coreUML.DefaultSize++;
                        ScrollSize(true);
                    }
                }
                else
                {
                    if (_coreUML.DefaultSize > -20)
                    {
                        _coreUML.DefaultSize--;
                        ScrollSize(false);
                    }
                }
            }
        }
        private void ScrollSize(bool isIncrease)
        {
            _coreUML.ScrollSize(isIncrease);
            _coreUML.UpdPicture();
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
            _coreUML.AxisStart = Axises.X;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _coreUML.AxisStart = Axises.Y;
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            _coreUML.AxisEnd = Axises.X;
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            _coreUML.AxisEnd = Axises.Y;
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            _coreUML.DefaultColor = colorDialog.Color;
            ButtonColor.BackColor = colorDialog.Color;
            if (_coreUML.SelectedFigures.Count > 0)
            {
                _coreUML.ChangeColorInSelectedFigures(colorDialog.Color);
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
            foreach(IFigure figure in _coreUML.SelectedFigures)
            {
                _coreUML.Figures.Remove(figure);
            }
            _coreUML.SelectedFigures.Clear();
            _coreUML.UpdPicture();
            _crntMH = new MouseHandlerOnSelection();
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            CoreUML.SaveDate();
            MessageBox.Show("Сохранено");
        }


        private void TrackBarOfWidth_Scroll(object sender, EventArgs e)
        {
            _coreUML.DefaultWidth = trackBarOfWidth.Value;
            if (_coreUML.SelectedFigures.Count > 0)
            {
                _coreUML.ChangeWidthInSelectedFigures(trackBarOfWidth.Value);
                _coreUML.UpdPicture();
            }
            _coreUML.DefaultWidth = trackBarOfWidth.Value;
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
        private void KeyDownControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Control)
            {
            }
            if (e.KeyCode == Keys.Delete && e.Control)
            {
            }
            if (e.KeyCode == Keys.A && e.Control)
            {
            }

            if (e.KeyCode == Keys.ControlKey)
            {
                _isControlKeyOn = true;                
            }

            if (e.KeyCode == Keys.C && e.Control)
            {
            }
            if (e.KeyCode == Keys.V && e.Control)
            {

            }

            if (e.KeyCode == Keys.Oemplus && e.Control)
            {
            }
            if (e.KeyCode == Keys.OemMinus && e.Control)
            {
            }
            if (e.KeyCode == Keys.D0 && e.Control)
            {
            }

            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) && e.Control)
            {
               
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


    }
}