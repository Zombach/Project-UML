using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.DataProject.Binary
{
    public class GetPathAs
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private string _tmpPath;

        public void GetPathData()
        {
            _tmpPath = null;
            GetPath();
            _coreUML.MyPath = _tmpPath;
        }

        public void GetPathEncrypt()
        {
            _tmpPath = null;
            GetPath();
            _coreUML.MyPathEncrypt = _tmpPath;
        }

        private void GetPath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "../../Save";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _tmpPath = openFileDialog.FileName;
                }
            }
        }
    }
}
