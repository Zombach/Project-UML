using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_UML.Core.DataProject.Binary;
using Project_UML.Core.DataProject.Json;
using Project_UML.Core.Encrypting;

namespace Project_UML.Core.FormsUML
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainMenu : Form
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private PreparationData _data;
        private GetPathAs _getPathAs;
        public MainMenu()
        {
            //Шифрование данных, необходимо вставить в моменте сохранения. Encrypt en = new Encrypt();
            InitializeComponent();
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            if(!_coreUML.IsLicense)
            {
                License licenseAgreement = new License(this);
                Hide();
                licenseAgreement.Show();
            }
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs(this);
            Hide();
            aboutUs.Show();
        }
        private void Continue_Click(object sender, EventArgs e)
        {
            _data = _coreUML.LoadData(this);
            if (_data != null)
            {
                Hide();
            }
        }

        private void LoadAs_Click(object sender, EventArgs e)
        {
            _getPathAs = new GetPathAs();
            _getPathAs.GetPathData();
            if (_coreUML.MyPath != "")
            {
                _data = _coreUML.LoadData(this);
                if (_data != null)
                {
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл сохранения");
            }

            
        }

        private void ExitProgramm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainMenu_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (_coreUML.IsLoading)
            {
                SaveSettings save = new SaveSettings();
                save.WriteSettings();
            }     
        }

    }
}
