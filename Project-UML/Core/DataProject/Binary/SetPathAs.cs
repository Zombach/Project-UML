using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.DataProject.Binary
{
    public class SetPathAs
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private string _tmpPath;

        public void SetPathImage()
        {
            _tmpPath = null;
            SetPath();
            _coreUML.MyPathImage = _tmpPath;
        }

        public void SetPathData()
        {
            _tmpPath = null;
            SetPath();
            _coreUML.MyPath = _tmpPath;
        }

        private void SetPath()
        {
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
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
