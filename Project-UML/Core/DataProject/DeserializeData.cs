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
    /// <summary>
    /// Развертывает дату десериализации
    /// </summary>
    public class DeserializeData
    {
        #region Переменные
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
        /// Список структурированых действий
        /// </summary>
        private List<ILogs> _iLogs;
        /// <summary>
        /// Список действий с объектами
        /// </summary>
        private List<LogActs> _logs;
        /// <summary>
        /// Фигура
        /// </summary>
        private IFigure _figure;
        /// <summary>
        /// Массив полных названий классов стрел
        /// </summary>
        private string[] _typeArrow;
        /// <summary>
        /// Массив полных названий классов боксов
        /// </summary>
        private string[] _typeBox;
        #endregion

        #region Методы
        /// <summary>
        /// Чтение записаной даты
        /// </summary>
        /// <param name="writeData"></param>
        public DeserializeData(SerializeData writeData)
        {
            _iBase = writeData.Base;
            _iLogs = writeData.Logs;
            _iFigure = CreateListFigure();
            _logs = CreateListLogs();
            _typeArrow = new string[5]
        {
            "Project_UML.Core.Arrows.AggregationArrow",
            "Project_UML.Core.Arrows.AssociationArrow",
            "Project_UML.Core.Arrows.CompositionArrow",
            "Project_UML.Core.Arrows.ImplementationArrow",
            "Project_UML.Core.Arrows.InheritanceArrow"
        };
            _typeBox = new string[4]
        {
            "Project_UML.Core.Boxes.BaseBox",
            "Project_UML.Core.Boxes.ClassBox",
            "Project_UML.Core.Boxes.MethodBox",
            "Project_UML.Core.Boxes.PropertyBox"
        };
        }

        /// <summary>
        /// Загрузка глобальных параметров фаормы.
        /// </summary>
        /// <param name="readData"></param>
        public void LoadingData(DeserializeData readData)
        {
            _coreUML.Figures = readData._iFigure;
            _coreUML.Logs = readData._logs;
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
            return _iFigure;
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

        /// <summary>
        /// Заготовка для сохранения логирования действий с объектами
        /// </summary>
        /// <returns></returns>
        private List<LogActs> CreateListLogs()
        {
            List<LogActs> logs = new List<LogActs>();

            return logs;
        }
        #endregion
    }
}