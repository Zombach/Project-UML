using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.Forms
{
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();
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
            NewProject newProject = new NewProject();
            this.Close();
            newProject.Show();
            //MainMenu.Main.Visible = true; Это строка кода для отображения главноего меню
        }
    }
}
