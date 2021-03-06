using Project_UML.Core.Interfaces.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.FormsUML
{
    public partial class AboutUs : Form
    {
        private Form _menu;
        public AboutUs(Form menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void MainMenu(object sender, EventArgs e)
        {
            _menu.Show();
            Dispose();
            Close();
        }
        private void AboutUs_FormClosing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _menu.Show();
            Dispose();
        }

        private void KeyDown_Control(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    PressEscape();
                    return;
            }
        }
        private void PressEscape()
        {
            _menu.Show();
            Dispose();
        }
    }
}
