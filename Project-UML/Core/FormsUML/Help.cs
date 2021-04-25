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

namespace Project_UML.Core.FormsUML
{
    public partial class Help : Form
    {
        private string _myPath = Path.GetFullPath("../../Resources/txt/Help.txt");
        public Help()
        {
            InitializeComponent();
            using (StreamReader sReader = new StreamReader(_myPath))
            {
                string line;
                while ((line = sReader.ReadLine()) != null)
                {
                    HelpText.Items.Add(line);
                }                
                sReader.Close();
            }
        }
        private void KeyDown_Control(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    Press_Escape();
                    return;
            }
        }
        private void Press_Escape()
        {
            Dispose();
        }
    }
}
