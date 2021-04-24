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
        private PreparationData _data;

        public PreparationData LoadingData()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "../../Save";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    Deserialize deserializer = new Deserialize();
                    _coreUML.MyPath = openFileDialog.FileName;
                    _data = deserializer.DeserializationDictionary();
                    MessageBox.Show("Загрузка успешно завершена");
                    _coreUML.IsLoading = true;
                }
            }
            return _data;
        }
    }
}
