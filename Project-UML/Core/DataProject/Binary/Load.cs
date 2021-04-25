using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.DataProject.Binary
{
    public class Load
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();

        public void GetPathData()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "../../Save";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _coreUML.MyPath = openFileDialog.FileName;
                }
            }
        }
    }
}
