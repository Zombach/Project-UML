using Project_UML.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.Serialize
{
    public class ReadData
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private Type[] _types = new[] { typeof(List<IFigure>), typeof(List<LogActs>), typeof(int), typeof(Color), typeof(Font), typeof(float)};
        private List<object> _objects;

        public ReadData(List <object> objects)
        {
            _objects = objects;
        }

        public void ReadAll()
        {
            for(int i = 0; i < _objects.Count; i++)
            {
                foreach (Type type in _types)
                {
                    if (_objects[i].GetType() == typeof(List<IFigure>))
                    {
                        _coreUML.Figures = (List<IFigure>)_objects[i];
                        MessageBox.Show(_objects[i].ToString());
                        break;
                    }
                    if (_objects[i].GetType() == typeof(List<LogActs>))
                    {
                        _coreUML.Logs = (List<LogActs>)_objects[i];
                        MessageBox.Show(_objects[i].ToString());
                        break;
                    }
                    if (_objects[i].GetType() == typeof(int))
                    {
                        _coreUML.DefaultWidth = (int)_objects[i];
                        MessageBox.Show(_objects[i].ToString());
                        break;
                    }
                    if (_objects[i].GetType() == typeof(Color))
                    {
                        _coreUML.DefaultColor = (Color)_objects[i];
                        MessageBox.Show(_objects[i].ToString());
                        break;
                    }
                    if (_objects[i].GetType() == typeof(Font))
                    {
                        _coreUML.DefaultFont = (Font)_objects[i];
                        MessageBox.Show(_objects[i].ToString());
                        break;
                    }
                    if (_objects[i].GetType() == typeof(float))
                    {
                        _coreUML.DefaultSize = (float)_objects[i];
                        MessageBox.Show(_objects[i].ToString());
                        break;
                    }
                }
            }
        }

        //public 
    }
}
