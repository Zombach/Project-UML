using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.DataProject.Interfaces;
using Project_UML.Core.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.Arrows;
using System;
using System.Reflection;

namespace Project_UML.Core.DataProject
{
    public class DeserializeData
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private List<IBase> _iBase;
        private List<IFigure> _figure;
        private List<ILogs> _iLogs;
        private List<LogActs> _logs;
        private float _defaultWidth;
        private Color _defaultColor;
        private Font _defaultFont;
        private float _defaultSize;
        private StructArrow _arrow;
        private StructBox _box;
        private string[] _typeNameArrow = new string[5] { "Project_UML.Core.Arrows.AggregationArrow", "Project_UML.Core.Arrows.AssociationArrow",
            "Project_UML.Core.Arrows.CompositionArrow", "Project_UML.Core.Arrows.ImplementationArrow", "Project_UML.Core.Arrows.InheritanceArrow" };
        private string[] _typeNameBox = new string[4] { "Project_UML.Core.Boxes.BaseBox", "Project_UML.Core.Boxes.ClassBox",
            "Project_UML.Core.Boxes.MethodBox", "Project_UML.Core.Boxes.PropertyBox" };
        IFigureFactory _figureFactory { get; set; }

        public DeserializeData(SerializeData writeData)
        {
            _iBase = writeData.Base;
            _iLogs = writeData.Logs;
            _figure = CreateListFigure();
            _logs = CreateListLogs();
            _defaultWidth = writeData.DefaultWidth;
            _defaultColor = writeData.DefaultColor;
            _defaultFont = writeData.DefaultFont;
            _defaultSize = writeData.DefaultSize;
        }

        public void LoadingData(DeserializeData readData)
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
                if (_iBase[i] is StructArrow)
                {
                    _arrow = (StructArrow)_iBase[i];
                    foreach (string typeName in _typeNameArrow)
                    {
                        if (_arrow.ArrowType == typeName)
                        {
                            var myClassType = Activator.CreateInstance(Type.GetType(_arrow.ArrowType));
                            if (myClassType is AggregationArrow)
                            {
                                AggregationArrow test = (AggregationArrow)myClassType;
                            }
                        }
                           
                    }
                }
                if (_iBase[i] is StructBox)
                {
                    _box = (StructBox)_iBase[i];
                    foreach (string typeName in _typeNameBox)
                    {
                        if (_box.BoxType == typeName)
                        {
                            //на этом этапе, я знаю, что нужно создать бокс + знаю его тип. 
                        }
                    }

                }
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
