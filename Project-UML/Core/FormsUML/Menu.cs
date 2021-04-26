using Project_UML.Core.DataProject.Binary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.FormsUML
{
    public partial class Menu : Form
    {
        private bool _isProject = true;
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private Form _menu;
        private Form _project;
        private PreparationData _data;
        private GetPathAs _getPathAs;
        private SetPathAs _setPathAs;
        private bool _isEncrypt = false;
        public Menu(Form menu, Form project)
        {
            InitializeComponent();
            _menu = menu;
            _project = project;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            _isProject = false;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            _project.Enabled = true;
            Close();
        }

        private void LoadAs_Click(object sender, EventArgs e)
        {
            _getPathAs = new GetPathAs();
            _getPathAs.GetPathData();
            _data = _coreUML.LoadData(_menu);
            if (_data != null)
            {
                _project.Dispose();
                Dispose();
            }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            _isEncrypt = !_isEncrypt;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            CoreUML.SaveDate();
            MessageBox.Show("Сохранено");
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            _setPathAs = new SetPathAs();
            _setPathAs.SetPathData();
        }

        private void LoadLast_Click(object sender, EventArgs e)
        {
            _data = _coreUML.LoadData(_menu);
            if (_data != null)
            {
                _project.Dispose();
                Dispose();
            }
        }

        private void EncryptAs_Click(object sender, EventArgs e)
        {
            _getPathAs = new GetPathAs();
            _getPathAs.GetPathEncrypt();
            string sss = _coreUML.MyPathEncrypt;
        }
        private void Menu_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (_isProject)
            {
                _project.Enabled = true;
            }
            else
            {
                _menu.Show();
                _project.Dispose();

            }
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
            _project.Enabled = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _coreUML.SaveImagePrepaire(true);
        }
    }
}
