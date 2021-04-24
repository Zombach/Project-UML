using Project_UML.Core.DataProject.Binary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.FormsUML
{
    public partial class Menu : Form
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private Form _menu;
        private Form _project;
        private PreparationData _data;
        private Deserialize _deserializer;
        private Load _load;
        private bool _isEncrypt = false;
        public Menu(Form menu, Form project)
        {
            InitializeComponent();
            _menu = menu;
            _project = project;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            _menu.Show();            
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            _project.Enabled = true;
            Close();
        }

        private void LoadAs_Click(object sender, EventArgs e)
        {
            _load = new Load();
            _data = _load.LoadingData();
            _project.Enabled = true;
            _project.Close();
            _project = new NewProject(_menu, _data);
            _project.Show();
            Close();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            _isEncrypt = !_isEncrypt;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {

        }

        private void LoadLast_Click(object sender, EventArgs e)
        {
            if (_coreUML.MyPath == "")
            {
                MessageBox.Show("Последнее сохранение не определено, повторите попытку, после создания нового сохранения");
            }
            else
            {
                _deserializer = new Deserialize();
                _data = _deserializer.DeserializationDictionary();
            }
        }

        private void EncryptAs_Click(object sender, EventArgs e)
        {

        }
    }
}
