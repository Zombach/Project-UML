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
using UML_Project._Core;

namespace UML_Project._Forms
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Explorer_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //if (Path.GetExtension(ofd.FileName).Equals("*.Мы.Програмист", StringComparison.CurrentCultureIgnoreCase))
                    //{
                    Core._myPath = ofd.FileName;
                    Menu menu = new Menu();
                    menu.Show();
                    menu.Enabled = true;
                    MessageBox.Show("Загрузка успешно завершена");
                    this.Close();
                    //}
                }
            }

        }
    }
}
