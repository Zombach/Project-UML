using Project_UML.Core.DataProject.Binary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.FormsUML
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Loading : Form
    {
        private Form _menu;
        private PreparationData _data;
        private Load _load;
        public Loading(Form menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void Explorer_Click(object sender, EventArgs e)
        {
            _load = new Load();
            _data = _load.LoadingData();
            NewProject newProject = new NewProject(_menu, _data);
            newProject.Show();
            Close();
        }
    }
}
