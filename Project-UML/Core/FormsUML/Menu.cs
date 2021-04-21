using Project_UML.Core.DataProject;
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
    public partial class Menu : Form
    {
        private Form _menu;
        private Form _project;
        private SerializeData _data;
        private Load _load;
        public Menu(Form menu, Form project)
        {
            InitializeComponent();
            _menu = menu;
            _project = project;
        }

        private void MainMenu(object sender, EventArgs e)
        {
            _menu.Show();            
            Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            _project.Enabled = true;
            Close();
        }

        private void LoadindAs(object sender, EventArgs e)
        {
            _load = new Load();
            _data = _load.LoadingData();
            _project.Enabled = true;
            _project.Close();
            _project = new NewProject(_menu, _data);
            _project.Show();
            Close();


        }
    }
}
