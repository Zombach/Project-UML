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
            _currentArrow = new AggregationArrow();
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isTapped) _bitmap = _bitmapTmp;
            _isTapped = false;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
