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

        
    }
}
