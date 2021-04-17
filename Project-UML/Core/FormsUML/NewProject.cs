using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Project_UML.Core.Arrows;
using Project_UML.Core;
using Project_UML.Core.Boxes;
using Project_UML.Core.MousHandlers;
using Project_UML.Core.FigureFactory;

namespace Project_UML.Core.Forms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class NewProject : Form
    {
        CoreUML _core = CoreUML.GetCoreUML();
        Point _point;
        Bitmap _bitmap;
        Bitmap _bitmapTmp;
        Graphics _graphics;
        bool _isTapped;
        AbstractArrow _currentArrow;
        Axises _startAxis = Axises.X;
        Axises _endAxis = Axises.X;
        List<AbstractArrow> _arrows = new List<AbstractArrow>();
        Act _act = Act.Aggregation;
        AbstractBox _currentBox;
        IMouseHandler _crntMH;

        public NewProject()
        {
            InitializeComponent();
            //FixUpdate();            
        }

        private void NewProject_Load(object sender, EventArgs e)
        {
            //_bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //_graphics = Graphics.FromImage(_bitmap);
            //_graphics.Clear(Color.White);
            //pictureBox1.Image = _bitmap;
            //pictureBox1.Image = _bitmap;
            _core.BitmapMain = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _core.BitmapTmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _core.Graphics = Graphics.FromImage(_core.BitmapMain);
            _core.Graphics.Clear(Color.White);
            _core.PictureBox = pictureBox1;
            pictureBox1.Image = _core.BitmapMain;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(_crntMH is null)) _crntMH.MouseDown(e.Location);
            //_crntMH = 
            //_point = new Point(e.X, e.Y);
            //_isTapped = true;
            //switch (_act)
            //{
            //    case Act.Aggregation:
            //        _currentArrow = new AggregationArrow(ButtonColor.BackColor, trackBar1.Value);
            //        break;
            //    case Act.Composition:
            //        _currentArrow = new CompositionArrow(ButtonColor.BackColor, trackBar1.Value);
            //        break;
            //    case Act.Inheritance:
            //        _currentArrow = new InheritanceArrow();
            //        break;
            //    case Act.Select:
            //        bool selected;
            //        foreach (AbstractArrow arrow in _arrows)
            //        {
            //            selected = arrow.CheckSelection(_point);
            //            if (selected)
            //            {
            //                _arrows.Remove(arrow);
            //                UpdPicture();
            //                _currentArrow = arrow;
            //                SwitchToDrawInTmp();
            //                arrow.Draw(_graphics);
            //                arrow.Select(_graphics);
            //                pictureBox1.Image = _bitmapTmp;
            //                break;
            //            }
            //            _currentArrow = null;
            //            pictureBox1.Image = _bitmap;
            //        }
            //        break;
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
            //    case Act.Implementation:
            //        _currentArrow = new ImplementationArrow();
            //        break;
            //    case Act.Association:
            //        _currentArrow = new AssociationArrow();
            //        break;
            //    case Act.Rectangle:
            //        _currentBox = new BestRectangles(e.X, e.Y);
            //        _currentBox.Draw(_graphics);
            //        break;
            //}
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(_crntMH is null)) _crntMH.MouseUp(e.Location);
            //switch (_act)
            //{
            //    case Act.Aggregation:
            //        if (_isTapped) _bitmap = (Bitmap)_bitmapTmp.Clone();
            //        _arrows.Add(_currentArrow);
            //        _currentArrow.Select(_graphics);
            //        pictureBox1.Invalidate();
            //        break;
            //    case Act.Composition:
            //        if (_isTapped) _bitmap = (Bitmap)_bitmapTmp.Clone();
            //        _arrows.Add(_currentArrow);
            //        _currentArrow.Select(_graphics);
            //        pictureBox1.Invalidate();
            //        break;
            //    case Act.Inheritance:
            //        if (_isTapped) _bitmap = (Bitmap)_bitmapTmp.Clone();
            //        _arrows.Add(_currentArrow);
            //        _currentArrow.Select(_graphics);
            //        pictureBox1.Invalidate();
            //        break;
            //    case Act.Select:
            //        if (!(_currentArrow == null))
            //        {
            //            _arrows.Add(_currentArrow);
            //            _graphics = Graphics.FromImage(_bitmap);
            //            _currentArrow.Draw(_graphics);
            //            _bitmapTmp = (Bitmap)_bitmap.Clone();
            //            _graphics = Graphics.FromImage(_bitmapTmp);
            //            _currentArrow.Select(_graphics);
            //            pictureBox1.Image = _bitmapTmp;
            //            _graphics = Graphics.FromImage(_bitmap);
            //        }
            //        break;
            //    case Act.Implementation:
            //        if (_isTapped) _bitmap = (Bitmap)_bitmapTmp.Clone();
            //        _arrows.Add(_currentArrow);
            //        _currentArrow.Select(_graphics);
            //        pictureBox1.Invalidate();
            //        break;
            //    case Act.Association:
            //        if (_isTapped) _bitmap = (Bitmap)_bitmapTmp.Clone();
            //        _arrows.Add(_currentArrow);
            //        _currentArrow.Select(_graphics);
            //        pictureBox1.Invalidate();
            //        break;
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
            if (!(_crntMH is null)) _crntMH.MouseMove(e.Location);
            //if (_isTapped)
            //{
            //    if (_act == Act.Aggregation || _act == Act.Composition || _act == Act.Inheritance || _act == Act.Implementation || _act == Act.Association)
            //    {
            //        SwitchToDrawInTmp();
            //        _currentArrow.StartDirectionAxis = _startAxis;
            //        _currentArrow.EndDirectionAxis = _endAxis;
            //        _currentArrow.GetPoints(_point, e.Location);
            //        _currentArrow.Draw(_graphics);
            //        pictureBox1.Image = _bitmapTmp;
            //    }
            //    else if (_act == Act.Select && !(_currentArrow is null))
            //    {
            //        SwitchToDrawInTmp();
            //        _currentArrow.Move(e.X - _point.X, e.Y - _point.Y);
            //        _point = e.Location;
            //        _currentArrow.Draw(_graphics);
            //        _currentArrow.Select(_graphics);
            //        pictureBox1.Image = _bitmapTmp;
            //    }
            //}
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _core.AxisStart = Axises.X;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _core.AxisStart = Axises.Y;
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            _core.AxisEnd = Axises.X;
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            _core.AxisEnd = Axises.Y;
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ButtonColor.BackColor = colorDialog1.Color;
            if (!(_currentArrow is null))
            {
                _currentArrow.ChangeColor(colorDialog1.Color);
                UpdPicture();
            }
        }

        private void ButtonAggregation_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawArrows( new AggregationArrowFactory());
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
            _act = Act.Select;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            _act = Act.Clear;
            if (!(_currentArrow is null))
            {
                _arrows.Remove(_currentArrow);
                _currentArrow = null;
                UpdPicture();
            }
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            CoreUML.SaveDate();
            MessageBox.Show("Сохранено");
        }

        private void UpdPicture()
        {
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.White);
            foreach (AbstractArrow arr in _arrows) arr.Draw(_graphics);
            if (!(_currentArrow is null))
            {
                SwitchToDrawInTmp();
                _currentArrow.Select(_graphics);
                pictureBox1.Image = _bitmapTmp;
            }
            else
            {
                pictureBox1.Image = _bitmap;
            }
            _graphics = Graphics.FromImage(_bitmap);
        }

        private void SwitchToDrawInTmp()
        {
            _bitmapTmp = (Bitmap)_bitmap.Clone();
            _graphics = Graphics.FromImage(_bitmapTmp);
        }

        private void TrackBar1_Scroll_1(object sender, EventArgs e)
        {
            if (!(_currentArrow is null))
            {
                _currentArrow.ChangeWidth(trackBar1.Value);
                UpdPicture();
            }
        }

        private void ButtonImplementation_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawArrows(new ImplementationArrowFactory());
        }

        private void ButtonAssociation_Click(object sender, EventArgs e)
        {
            _crntMH = new MouseHandlerOnDrawArrows(new AssociationArrowFactory());
        }

        private void ButtonRectangle_Click(object sender, EventArgs e)
        {
            _act = Act.Rectangle;
        }

    }
}