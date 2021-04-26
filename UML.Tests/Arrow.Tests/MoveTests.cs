using NUnit.Framework;
using Project_UML.Core.Arrows;
using System.Drawing;
using System.Collections;
using Project_UML.Core;

namespace Move.Tests
{
    public class MoveTests
    {
        [TestCaseSource(typeof(MoveTestSource))]
        public void Move_WhenAlways_ShouldMove(AggregationArrow Arrow, int x, int y, AggregationArrow expected)
        {
            Arrow.Move(x,y);
            AggregationArrow actual = Arrow;
            Assert.AreEqual(expected, actual);

        }
    }
    public class MoveTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {
                new AggregationArrow(new Point(0,1),new Point(10,20),Axis.X,Axis.X),
                50,
                50,
                new AggregationArrow(new Point(50,51),new Point(60,70),Axis.X,Axis.X)
            };
            yield return new object[] {
                new AggregationArrow(new Point(15,27),new Point(33,44),Axis.X,Axis.X),
                10,
                20,
                new AggregationArrow(new Point(25,47),new Point(43,64),Axis.X,Axis.X)
            };
            yield return new object[] {
                new AggregationArrow(new Point(33,44),new Point(60,70),Axis.X,Axis.X),
                100,
                30,
                new AggregationArrow(new Point(133,74),new Point(160,100),Axis.X,Axis.X)
            };
        }
    }
}