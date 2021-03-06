using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using UML_Project.Arrows;

namespace UML_Project
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
        int _width = 1;
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
                    _currentArrow = new AggregationArrow();
                    _currentArrow.ChangeWidth(_width);
                    break;
                case Act.Composition:
                    _currentArrow = new CompositionArrow();
                    _currentArrow.ChangeWidth(_width);
                    break;
                case Act.Inheritance:
                    _currentArrow = new InheritanceArrow();
                    _currentArrow.ChangeWidth(_width);
                    break;
                case Act.Select:
                    bool selected;
                    foreach (AbstractArrow arrow in _arrows)
                    {
                        selected = arrow.CheckSelection(_point);
                        if (selected)
                        {
                            _graphics.Clear(Color.White);
                            arrow.Reverse();
                            foreach (AbstractArrow arrow2 in _arrows)
                            {
                                arrow2.Draw(_graphics);
                            }
                            pictureBox1.Invalidate();
                            break;
                        }
                    }
                    break;
            }

        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (_act)
            {
                case Act.Aggregation:
                    if (_isTapped) _bitmap = _bitmapTmp;
                    _arrows.Add(_currentArrow);
                    break;
                case Act.Composition:
                    if (_isTapped) _bitmap = _bitmapTmp;
                    _arrows.Add(_currentArrow);
                    break;
                case Act.Inheritance:
                    if (_isTapped) _bitmap = _bitmapTmp;
                    _arrows.Add(_currentArrow);
                    break;
                case Act.Select:
                    break;
            }

            _isTapped = false;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isTapped && (_act == Act.Aggregation || _act == Act.Composition || _act == Act.Inheritance))
            {
                _bitmapTmp = (Bitmap)_bitmap.Clone();
                _graphics = Graphics.FromImage(_bitmapTmp);
                _currentArrow.StartDirectionAxis = _startAxis;
                _currentArrow.EndDirectionAxis = _endAxis;
                _currentArrow.GetPoints(_point, e.Location);
                _currentArrow.Draw(_graphics);
                pictureBox1.Image = _bitmapTmp;
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _width = trackBar1.Value;
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ButtonColor.BackColor = colorDialog1.Color;
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
        }
    }
}
