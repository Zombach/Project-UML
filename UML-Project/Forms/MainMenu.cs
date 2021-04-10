using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Project
{
    public partial class MainMenu : Form
    {
        public static MainMenu Main { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            Main = this;
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            License licenseAgreement = new License();
            Main.Hide();
            licenseAgreement.Show();
        }
    }
}
