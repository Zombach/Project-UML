using Project_UML.Core.DataProject.Json;
using Project_UML.Core.DataProject.Structure;
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
using Project_UML.Core.FormsUML;

namespace Project_UML.Core.FormsUML
{
    /// <summary>
    /// 
    /// </summary>
    public partial class License : Form
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private bool isMenu = true;
        private Form _menu;
        private string _myPath = Path.GetFullPath("../../Resources/txt/License.txt");

        public License(MainMenu menu)
        {
            InitializeComponent();
            _menu = menu;
            using (StreamReader sReader = new StreamReader(_myPath))
            {
                string line;
                while ((line = sReader.ReadLine()) != null)
                {
                    LicenseText.Items.Add(line);
                }
                sReader.Close();
            }
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
            isMenu = false;
            NewProject newProject = new NewProject(_menu);
            Dispose();
            newProject.Show();
        }
        private void License_FormClosing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (isMenu)
            {
                _menu.Show();
            }
            else
            {
                isMenu = true;
            }
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
