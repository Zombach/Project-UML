using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.DataProject
{
    public class Load
    {
        private CoreUML _coreUML;
        private SerializeData _serializeData;

        public SerializeData LoadingData()
        {
            _coreUML = CoreUML.GetCoreUML();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "../../Save";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    BinaryConversion binary = new BinaryConversion();
                    _coreUML.MyPath = openFileDialog.FileName;
                    _serializeData = binary.DeserializationDictionary();
                    MessageBox.Show("Загрузка успешно завершена");
                    _coreUML.IsLoading = true;
                }
            }
            return _serializeData;
        }
    }
}
