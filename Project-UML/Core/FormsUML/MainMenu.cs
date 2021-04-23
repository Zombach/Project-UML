using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_UML.Core.DataProject.Json;
using Project_UML.Core.Encrypting;

namespace Project_UML.Core.FormsUML
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            SaveSettings sss = new SaveSettings();;
            sss.WriteSettings();
            //Шифрование данных, необходимо вставить в моменте сохранения. Encrypt en = new Encrypt();
            InitializeComponent();
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            License licenseAgreement = new License(this);
            Hide();
            licenseAgreement.Show();
        }

        private void LoadProject_Click(object sender, EventArgs e)
        {
            Loading loading = new Loading(this);
            Hide();
            loading.Show();
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs(this);
            Hide();
            aboutUs.Show();
        }

        private void ExitProgramm_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
