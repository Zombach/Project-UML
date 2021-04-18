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
using Project_UML.Core.Serialize;

namespace Project_UML.Core.Forms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Explorer_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "../../Save";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CoreUML coreUML = CoreUML.GetCoreUML();
                    BinaryConversion binary = new BinaryConversion();
                    coreUML.MyPath = openFileDialog.FileName;
                    binary.DeserializationDictionary();
                    MessageBox.Show("Загрузка успешно завершена");
                    coreUML.isLoading = true;
                }
            }
            //int s = CoreUML.Figures[0];
            //int s1 = CoreUML.Figures[1];
            //int s2 = CoreUML.Figures[2];
            //int s3 = CoreUML.Figures[3];
            //MessageBox.Show($"s = {s} s1 = {s1} s2 = {s2} s3 = {s3}");
            NewProject newProject = new NewProject();
            Hide();
            newProject.Show();
        }
    }
}
