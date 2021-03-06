using Project_UML.Core.DataProject.Structure;
using Project_UML.Core.DataProject.Interfaces;
using Project_UML.Core.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using Project_UML.Core.FigureFactory;
using Project_UML.Core.Arrows;
using System;
using System.Reflection;
using Project_UML.Core.Boxes;

namespace Project_UML.Core.DataProject.Binary
{
    /// <summary>
    /// Развертывает дату десериализации
    /// </summary>
    public class ProcessingData
    {
        /// <summary>
        /// Получение ядра
        /// </summary>
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        /// <summary>
        /// Список Структурированых объектов
        /// </summary>
        private List<IBase> _iBase;
        /// <summary>
        /// Список Фигур
        /// </summary>
        private List<IFigure> _iFigure;
        /// <summary>
        /// Фигура
        /// </summary>
        private IFigure _figure;
        /// <summary>
        /// Массив полных названий классов стрел
        /// </summary>
        private string[] _typeArrow = new string[5]
        {
            "Project_UML.Core.Arrows.AggregationArrow",
            "Project_UML.Core.Arrows.AssociationArrow",
            "Project_UML.Core.Arrows.CompositionArrow",
            "Project_UML.Core.Arrows.ImplementationArrow",
            "Project_UML.Core.Arrows.InheritanceArrow"
        };
        /// <summary>
        /// Массив полных названий классов боксов
        /// </summary>
        private string[] _typeBox = new string[4]
        {
            "Project_UML.Core.Boxes.RectangleClass",
            "Project_UML.Core.Boxes.RectangleEnum",
            "Project_UML.Core.Boxes.RectangleInterface",
            "Project_UML.Core.Boxes.RectangleObject"
        };

        /// <summary>
        /// Чтение записаной даты
        /// </summary>
        /// <param name="data"></param>
        public ProcessingData(PreparationData data)
        {
            _iBase = data.Base;
            _iFigure = CreateListFigure();
        }

        /// <summary>
        /// Загрузка списка фигур
        /// </summary>
        /// <param name="data"></param>
        public void LoadingData(ProcessingData data)
        {
            _coreUML.Figures = data._iFigure;
        }
            
        /// <summary>
        /// Создания листа фигур
        /// </summary>
        /// <returns></returns>
        private List<IFigure> CreateListFigure() 
        {
            _iFigure = new List<IFigure>();
            for (int i = 0; i < _iBase.Count; i++)
            {
                IFigure figure = GetFigure(_iBase[i]);
                _iFigure.Add(figure);
            }
            WriteDataCommon();
            return _iFigure;
        }

        private void WriteDataCommon()
        {
            for (int i = 0; i < _iFigure.Count; i++)
            {
                IFigure tmp = _iFigure[i];
                for (int j = 0; j < tmp.IDataCommon.Count; j++)
                {
                    DataCommon data = new DataCommon();
                    if (tmp.IDataCommon[j].Arrow != -1)
                    {
                        data.Arrow = _iFigure[tmp.IDataCommon[j].Arrow];
                    }
                    if (tmp.IDataCommon[j].FirstPoint != null)
                    {
                        data.FirstPoint = tmp.IDataCommon[j].FirstPoint;
                    }
                    if (tmp.IDataCommon[j].LastPoint != null)
                    {
                        data.LastPoint = tmp.IDataCommon[j].LastPoint;
                    }
                    if (tmp.IDataCommon[j].FirstBox != -1)
                    {
                        data.FirstBox = _iFigure[tmp.IDataCommon[j].FirstBox];
                    }
                    if (tmp.IDataCommon[j].LastBox != -1)
                    {
                        data.LastBox = _iFigure[tmp.IDataCommon[j].LastBox];
                    }
                    tmp.DataCommon.Add(data);
                }
            }
        }
        /// <summary>
        /// Определение типа хранимых данных
        /// </summary>
        /// <param name="iBase">Список структурированых объектов</param>        
        /// <returns></returns>
        private IFigure GetFigure(IBase iBase)
        {
            if (iBase is StructArrow arrow)
            {
                _figure = CreateFigureArrow(arrow);
            }
            if (iBase is StructBox box)
            {
                _figure = CreateFigureBox(box);
            }
            return _figure;
        }

        /// <summary>
        /// Создание фигуры стрелы на базе структуры
        /// </summary>
        /// <param name="arrow">Структура стрелы</param>
        /// <returns></returns>
        private IFigure CreateFigureArrow(StructArrow arrow)
        {
            foreach (string typeName in _typeArrow)
            {
                if (arrow.Type == typeName)
                {
                    var myClassType = Activator.CreateInstance(Type.GetType(arrow.Type), arrow);
                    _figure = (IFigure)myClassType;
                    break;
                }
                #region Альтернатива, но для неё нужно переделать Type c FullName на Name
                //if (arrow.Type == "AggregationArrow")
                //{
                //    AggregationArrow _figure = new AggregationArrow(arrow);
                //}
                //if (arrow.Type == "AssociationArrow")
                //{
                //    AssociationArrow _figure = new AssociationArrow(arrow);
                //}
                //if (arrow.Type == "CompositionArrow")
                //{
                //    CompositionArrow _figure = new CompositionArrow(arrow);
                //}
                //if (arrow.Type == "ImplementationArrow")
                //{
                //    ImplementationArrow _figure = new ImplementationArrow(arrow);
                //}
                //if (arrow.Type == "InheritanceArrow")
                //{
                //    InheritanceArrow _figure = new InheritanceArrow(arrow);
                //}
                #endregion
            }
            return _figure;
        }
        /// <summary>
        /// Создание фигуры бокса на базе структуры
        /// </summary>
        /// <param name="box">Структура бокса</param>
        /// <returns></returns>
        private IFigure CreateFigureBox(StructBox box)
        {
            foreach (string typeName in _typeBox)
            {
                if (box.Type == typeName)
                {
                    var myClassType = Activator.CreateInstance(Type.GetType(box.Type), box);
                    _figure = (IFigure)myClassType;
                    break;
                }
            }
            return _figure;
        }
    }
}