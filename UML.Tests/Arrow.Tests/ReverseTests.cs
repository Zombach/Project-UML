using NUnit.Framework;
using Project_UML.Core.Arrows;
using System.Drawing;
using System.Collections;
using Project_UML.Core;

namespace ReverseTests.Tests
{
    public class ReverseTestsTests
    {
        [TestCaseSource(typeof(ReverseTestsTestSource))]
        public void Reverse_WhenAlways_ShouldReverse(AggregationArrow Arrow, AggregationArrow expected)
        {
            Arrow.Reverse();
            AggregationArrow actual = Arrow;
            Assert.AreEqual(expected, actual);
        }
    }
    public class ReverseTestsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {
                new AggregationArrow(new Point(0,1),new Point(10,20),Axis.X,Axis.X),
                new AggregationArrow(new Point(10,20),new Point(0,1),Axis.X,Axis.X)
            };
            yield return new object[] {
                new AggregationArrow(new Point(15,27),new Point(33,44),Axis.X,Axis.X),
                new AggregationArrow(new Point(33,44),new Point(15,27),Axis.X,Axis.X)
            };
            yield return new object[] {
                new AggregationArrow(new Point(11,15),new Point(100,200),Axis.X,Axis.X),
                new AggregationArrow(new Point(100,200),new Point(11,15),Axis.X,Axis.X)
            };
        }
    }
}