using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_UML._Core;

namespace Project_UML._Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void EnabledMenu()
        {
            Show();
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            License licenseAgreement = new License();
            Hide();
            licenseAgreement.Show();
        }

        private void LoadProject_Click(object sender, EventArgs e)
        {
            Loading loading = new Loading();
            Hide();
            loading.Show();
        }
    }
}
