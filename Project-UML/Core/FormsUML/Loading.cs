using Project_UML.Core.DataProject.Binary;
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
    /// <summary>
    /// 
    /// </summary>
    public partial class Loading : Form
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private Form _menu;
        private PreparationData _data;
        private GetPathAs _load;
        public Loading(Form menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void Explorer_Click(object sender, EventArgs e)
        {
            _load = new GetPathAs();
            _load.GetPathData();
            _data = _coreUML.LoadData(_menu);
            if (_data != null)
            {
                Dispose();
            }
            else
            {
                MessageBox.Show("Не возможно прочитать дат файл");
            }
            
        }

        private void Loading_FormClosing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _menu.Show();
            Dispose();
        }
    }
}
