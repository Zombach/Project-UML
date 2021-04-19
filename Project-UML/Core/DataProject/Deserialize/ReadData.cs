using Project_UML.Core.DataProject.Serialize;

namespace Project_UML.Core.DataProject.Deserialize
{
    public class ReadData
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private WriteData _writeData;

        public ReadData(WriteData writeData)
        {
            _writeData = writeData;
        }

        public void ReadAll()
        {
            //_coreUML.Base = _writeData.Base;
            _coreUML.Logs = _writeData.Logs;
            _coreUML.DefaultWidth = _writeData.DefaultWidth;
            _coreUML.DefaultColor = _writeData.DefaultColor;
            _coreUML.DefaultFont = _writeData.DefaultFont;
            _coreUML.DefaultSize = _writeData.DefaultSize;
        }
    }
}
