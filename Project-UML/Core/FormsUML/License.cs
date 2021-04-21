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
    public partial class License : Form
    {
        private Form _menu;
        private string _myPath = Path.GetFullPath("../../Resources/txt/License.txt");

        public License(Form menu)
        {
            InitializeComponent();
            _menu = menu;
            StreamReader sr = new StreamReader(_myPath);
            LicenseText.Items.Add(sr.ReadLine());
        }
        private void CheckBox_License_CheckedChanged(object sender, EventArgs e)
        {
            if (License_CheckBox.Checked == true)
            {
                CreateProject_Button.Enabled = true;
            }
            else
            {
                CreateProject_Button.Enabled = false;
            }
        }
        private void CreateNewProject_Button_Click(object sender, EventArgs e)
        {
            NewProject newProject = new NewProject(_menu);
            this.Close();
            newProject.Show();
            //MainMenu.Main.Visible = true; Это строка кода для отображения главноего меню
        }
    }
}
