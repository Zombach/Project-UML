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
using Project_UML.Core.Interfaces;

namespace Project_UML.Core.Forms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class NewProject : Form
    {
        CoreUML _core = CoreUML.GetCoreUML();
        AbstractArrow _currentArrow;
        List<AbstractArrow> _arrows = new List<AbstractArrow>();
        //AbstractBox _currentBox;
        IMouseHandler _crntMH = new MouseHandlerOnSelection();

        public NewProject()
        {
            InitializeComponent();
            //FixUpdate();            
        }

        private void NewProject_Load(object sender, EventArgs e)
        {
            _core.BitmapMain = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _core.BitmapTmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _core.Graphics = Graphics.FromImage(_core.BitmapMain);
            _core.Graphics.Clear(Color.White);
            _core.PictureBox = pictureBox1;
            pictureBox1.Image = _core.BitmapMain;
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
            colorDialog.ShowDialog();
            _core.Color = colorDialog.Color;
            ButtonColor.BackColor = colorDialog.Color;
            if (_core.SelectedFigures.Count > 0)
            {
                _core.ChangeColorInSelectedFigures(colorDialog.Color);
                _core.UpdPicture();
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
            foreach(IFigure figure in _core.SelectedFigures)
            {
                _core.Figures.Remove(figure);
            }
            _core.SelectedFigures.Clear();
            _core.UpdPicture();
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            CoreUML.SaveDate();
            MessageBox.Show("Сохранено");
        }


        private void TrackBarOfWidth_Scroll(object sender, EventArgs e)
        {
            _core.Width = trackBarOfWidth.Value;
            if (_core.SelectedFigures.Count > 0)
            {
                _core.ChangeWidthInSelectedFigures(trackBarOfWidth.Value);
                _core.UpdPicture();
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
            //_act = Act.Rectangle;
        }

    }
}