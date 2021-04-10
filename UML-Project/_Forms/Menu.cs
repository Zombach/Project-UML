using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Project._Core;

namespace UML_Project._Forms
{
    public partial class Menu : Form
    {
        public Menu()
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
            Loading loading = new Loading();
            Enabled = false;
            loading.Show();
        }
    }
}
