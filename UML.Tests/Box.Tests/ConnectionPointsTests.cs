using NUnit.Framework;
using Project_UML.Core.Arrows;
using System.Drawing;
using System.Collections;
using Project_UML.Core;
using Project_UML.Core.Boxes;

namespace ConnectionPoints.Tests
{
    public class ConnectionPointsTests
    {
        [TestCaseSource(typeof(ConnectionPointsTestSource1))]
        public void ConnectionPoints_WhenAlways_ShouldCreateConnectionPoints(RectangleClass box, Point startPoint, Point crntPoint, Point oppositePoint, ConnectionPoint expected)
        {
            box.AddPoints(startPoint);
            box.crntZone = new BoxZones();
            box.crntZone = BoxZones.Top;
            ConnectionPoint actual = box.GetConnectionPoint(crntPoint, oppositePoint);
            Assert.AreEqual(expected, actual);
        }
    }
    public class ConnectionPointsTestSource1 : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {
                new RectangleClass(Color.Black,1),
                new Point(0,0),
                new Point(1,1),
                new Point(5,5),
                new ConnectionPoint(Axis.Y,new BoxZones(),5)
            };
        }
    }
}