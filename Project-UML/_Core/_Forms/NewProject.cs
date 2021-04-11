using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Project_UML._Core._Arrows;
using Project_UML._Core;
using Project_UML._Core._Boxes;

namespace Project_UML._Core._Forms
{
    public partial class NewProject : Form
    {
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

        public NewProject()
        {
            InitializeComponent();
            //FixUpdate();            
        }

        private void NewProject_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _bitmap;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _point = new Point(e.X, e.Y);
            _isTapped = true;
            switch (_act)
            {
                case Act.Aggregation:
                    _currentArrow = new AggregationArrow(ButtonColor.BackColor, trackBar1.Value);
                    break;
                case Act.Composition:
                    _currentArrow = new CompositionArrow(ButtonColor.BackColor, trackBar1.Value);
                    break;
                case Act.Inheritance:
                    _currentArrow = new InheritanceArrow();
                    break;
                case Act.Select:
                    bool selected;
                    foreach (AbstractArrow arrow in _arrows)
                    {
                        selected = arrow.CheckSelection(_point);
                        if (selected)
                        {
                            _arrows.Remove(arrow);
                            UpdPicture();
                            _currentArrow = arrow;
                            SwitchToDrawInTmp();
                            arrow.Draw(_graphics);
                            arrow.Select(_graphics);
                            pictureBox1.Image = _bitmapTmp;
                            break;
                        }
                        _currentArrow = null;
                        pictureBox1.Image = _bitmap;
                    }
                    break;
                case Act.Clear:
                    foreach (AbstractArrow arrow in _arrows)
                    {
                        selected = arrow.CheckSelection(_point);
                        if (selected)
                        {
                            _arrows.Remove(arrow);
                            UpdPicture();
                            break;
                        }
                    }
                    break;
                case Act.Rectangle:
                    _currentBox = new BestRectangles(e.X, e.Y);
                    _currentBox.Draw(_graphics);
                    break;
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (_act)
            {
                case Act.Aggregation:
                    if (_isTapped) _bitmap = (Bitmap)_bitmapTmp.Clone();
                    _arrows.Add(_currentArrow);
                    _currentArrow.Select(_graphics);
                    pictureBox1.Invalidate();
                    break;
                case Act.Composition:
                    if (_isTapped) _bitmap = (Bitmap)_bitmapTmp.Clone();
                    _arrows.Add(_currentArrow);
                    _currentArrow.Select(_graphics);
                    pictureBox1.Invalidate();
                    break;
                case Act.Inheritance:
                    if (_isTapped) _bitmap = (Bitmap)_bitmapTmp.Clone();
                    _arrows.Add(_currentArrow);
                    _currentArrow.Select(_graphics);
                    pictureBox1.Invalidate();
                    break;
                case Act.Select:
                    if (!(_currentArrow == null))
                    {
                        _arrows.Add(_currentArrow);
                        _graphics = Graphics.FromImage(_bitmap);
                        _currentArrow.Draw(_graphics);
                        _bitmapTmp = (Bitmap)_bitmap.Clone();
                        _graphics = Graphics.FromImage(_bitmapTmp);
                        _currentArrow.Select(_graphics);
                        pictureBox1.Image = _bitmapTmp;
                        _graphics = Graphics.FromImage(_bitmap);
                    }
                    break;
                //case Act.Rectangle:
                case Act.Rectangle:
                    if (_isTapped) _bitmap = (Bitmap)_bitmapTmp.Clone();
                    //_arrows.Add(_currentArrow);
                    //_currentBox.Select(_graphics);
                    pictureBox1.Invalidate();
                    break;

            }
            Core.Figures.Add(_currentArrow.Points[0].X);
            Core.Figures.Add(_currentArrow.Points[0].Y);
            Core.Figures.Add(_currentArrow.Points[_currentArrow.Points.Count - 1].X);
            Core.Figures.Add(_currentArrow.Points[_currentArrow.Points.Count - 1].Y);
            _isTapped = false;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isTapped)
            {
                if (_act == Act.Aggregation || _act == Act.Composition || _act == Act.Inheritance)
                {
                    SwitchToDrawInTmp();
                    _currentArrow.StartDirectionAxis = _startAxis;
                    _currentArrow.EndDirectionAxis = _endAxis;
                    _currentArrow.GetPoints(_point, e.Location);
                    _currentArrow.Draw(_graphics);
                    pictureBox1.Image = _bitmapTmp;
                }
                else if (_act == Act.Select && !(_currentArrow is null))
                {
                    SwitchToDrawInTmp();
                    _currentArrow.Move(e.X - _point.X, e.Y - _point.Y);
                    _point = e.Location;
                    _currentArrow.Draw(_graphics);
                    _currentArrow.Select(_graphics);
                    pictureBox1.Image = _bitmapTmp;
                }
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _startAxis = Axises.X;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _startAxis = Axises.Y;
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            _endAxis = Axises.X;
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            _endAxis = Axises.Y;
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
            _act = Act.Aggregation;
        }

        private void ButtonComposition_Click(object sender, EventArgs e)
        {
            _act = Act.Composition;
        }

        private void ButtonInheritance_Click(object sender, EventArgs e)
        {
            _act = Act.Inheritance;
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
            Core.SaveDate();
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

        private void ButtonRectangle_Click(object sender, EventArgs e)
        {
            _act = Act.Rectangle;
        }
    }
}