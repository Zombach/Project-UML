using Project_UML.Core.DataProject.Serialize;
using Project_UML.Core.DataProject.Serialize.Interfaces;
using Project_UML.Core.Interfaces;
using System.Collections.Generic;
using System.Drawing;

namespace Project_UML.Core.DataProject.Deserialize
{
    public class ReadData
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private List<IBase> _iBase;
        private List<ILogs> _iLogs;
        private List<IFigure> _figure;
        private List<LogActs> _logs;
        private float _defaultWidth;
        private Color _defaultColor;
        private Font _defaultFont;
        private float _defaultSize;


        public ReadData(WriteData writeData)
        {
            _iBase = writeData.Base;
            _logs = writeData.Logs;
            _defaultWidth = writeData.DefaultWidth;
            _defaultColor = writeData.DefaultColor;
            _defaultFont = writeData.DefaultFont;
            _defaultSize = writeData.DefaultSize;
            _figure = CreateListFigure();
            _logs = CreateListLogs();
        }

        public void LoadingData(ReadData readData)
        {
            _coreUML.Figures = readData._figure;
            _coreUML.Logs = readData._logs;
            _coreUML.DefaultWidth = readData._defaultWidth;
            _coreUML.DefaultColor = readData._defaultColor;
            _coreUML.DefaultFont = readData._defaultFont;
            _coreUML.DefaultSize = readData._defaultSize;
        }
        private List<IFigure> CreateListFigure()
        {
            _figure = new List<IFigure>();
            for (int i = 0; i < _iBase.Count; i++)
            {
                //if (Figures[i] is AbstractArrow)
                //{
                //    _arrow = new StructArrow(Figures[i]);
                //    _figure.Add(_arrow);
                //}
                //if (Figures[i] is AbstractBox)
                //{
                //    _box = new StructBox(Figures[i]);
                //    _figure.Add(_box);
                //}
            }
            return _figure;
        }
        private List<LogActs> CreateListLogs()
        {
            List<LogActs> logs = new List<LogActs>();

            return logs;
        }
    }
}
