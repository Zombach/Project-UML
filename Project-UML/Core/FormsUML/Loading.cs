using Project_UML.Core.DataProject;
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
            SerializeData data = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "../../Save";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CoreUML coreUML = CoreUML.GetCoreUML();
                    BinaryConversion binary = new BinaryConversion();
                    coreUML.MyPath = openFileDialog.FileName;
                    data = binary.DeserializationDictionary();
                    MessageBox.Show("Загрузка успешно завершена");
                    coreUML.IsLoading = true;
                }
            }
            NewProject newProject = new NewProject(data);
            Hide();
            newProject.Show();
        }
    }
}
