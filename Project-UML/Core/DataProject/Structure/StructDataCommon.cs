using Project_UML.Core.DataProject.Interfaces;
using System;

namespace Project_UML.Core.DataProject.Structure
{
    [Serializable]
    public struct StructDataCommon :IDataCommon
    {
        public int FirstBox { get; set; }
        public int LastBox { get; set; }
        public int Arrow { get; set; }
        public ConnectionPoint FirstPoint { get; set; }
        public ConnectionPoint LastPoint { get; set; }

        public StructDataCommon(DataCommon data)
        {
            CoreUML coreUML = CoreUML.GetCoreUML();
            FirstBox = coreUML.Figures.IndexOf(data.FirstBox);
            LastBox = coreUML.Figures.IndexOf(data.LastBox);
            Arrow = coreUML.Figures.IndexOf(data.Arrow);
            FirstPoint = data.FirstPoint;
            LastPoint = data.LastPoint;
        }
    }
}
