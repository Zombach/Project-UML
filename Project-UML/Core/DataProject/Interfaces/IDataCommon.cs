namespace Project_UML.Core.DataProject.Interfaces
{
    public interface IDataCommon
    {
        /// <summary>
        /// 
        /// </summary>
        int FirstBox { get; set; }
        int LastBox { get; set; }
        int Arrow { get; set; }
        ConnectionPoint FirstPoint { get; set; }
        ConnectionPoint LastPoint { get; set; }
    }
}
