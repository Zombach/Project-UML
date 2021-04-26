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

        public void SetPathData()
        {
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
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
