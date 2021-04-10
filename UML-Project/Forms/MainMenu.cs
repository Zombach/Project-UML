using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Project.CoreFolders;

namespace UML_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            License licenseAgreement = new License();
            this.Hide();
            licenseAgreement.Show();
        }

        private void LoadProject_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            //Loading loading = new Loading();
        }
    }
}
