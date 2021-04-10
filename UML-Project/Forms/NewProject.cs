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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
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
                    foreach(AbstractArrow arrow in _arrows)
                    {
                        selected = arrow.CheckSelection(_point);
                    if (selected)
                        {
                            arrow.ViewSelection(_graphics);
                            pictureBox1.Invalidate();
                        }
                    }
                    break;
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isTapped)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _startAxis = Axises.X;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _startAxis = Axises.Y;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            _endAxis = Axises.X;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            _endAxis = Axises.Y;
        }

        private void radioButtonAggregation_CheckedChanged(object sender, EventArgs e)
        {
            _act = Act.Aggregation;
        }

        private void radioButtonComposition_CheckedChanged(object sender, EventArgs e)
        {
            _act = Act.Composition;
        }

        private void radioButtonInheritance_CheckedChanged(object sender, EventArgs e)
        {
            _act = Act.Inheritance;
        }

        private void radioButtonSelect_CheckedChanged(object sender, EventArgs e)
        {
            _act = Act.Select;
        }

        private void radioButtonClear_CheckedChanged(object sender, EventArgs e)
        {
            _act = Act.Clear;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _width = trackBar1.Value;
        }
    }
}
