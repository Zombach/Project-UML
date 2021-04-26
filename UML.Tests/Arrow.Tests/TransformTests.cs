using NUnit.Framework;
using Project_UML.Core.Arrows;
using System.Drawing;
using System.Collections;
using Project_UML.Core;

namespace Transform.Tests
{
    public class TransformTests
    {
        [TestCaseSource(typeof(TransformTestSource))]
        public void Transformr_WhenAlways_ShouldTransform(AggregationArrow arrow, ZoneType zone, Point x, AggregationArrow expected)
        {
            arrow.SelectedZone = new ZoneOfArrow();
            arrow.SelectedZone.ZoneType = zone;
            arrow.Transform(x);
            AggregationArrow actual = arrow;
            Assert.AreEqual(expected, actual);
        }
    }
    public class TransformTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {
                new AggregationArrow(new Point(0,1),new Point(10,20),Axis.X,Axis.X),
                ZoneType.LastPoint,
                new Point(100,50),
                new AggregationArrow(new Point(0,1),new Point(100,50),Axis.X,Axis.X)
            };
            yield return new object[] {
                new AggregationArrow(new Point(0,1),new Point(10,20),Axis.X,Axis.X),
                ZoneType.FirstPoint,
                new Point(100,50),
                new AggregationArrow(new Point(100,50),new Point(10,20),Axis.X,Axis.X)
            };
            //yield return new object[] {
            //    new AggregationArrow(new Point(0,1),new Point(10,20),Axis.X,Axis.X),
            //    ZoneType.MiddleLink,
            //    new Point(100,50),
            //    new AggregationArrow(new Point(0,1),new Point(10,20),Axis.X,Axis.X)
            //};
        }
    }
}