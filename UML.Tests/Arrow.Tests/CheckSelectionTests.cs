using NUnit.Framework;
using Project_UML.Core.Arrows;
using System.Drawing;
using System.Collections;
using Project_UML.Core;
using Project_UML.Core.Enum;

namespace CheckSelection.Tests
{
    public class CheckSelectionTests
    {
        [TestCaseSource(typeof(CheckSelectionTestSource))]
        public void CheckSelection_WhenPointNotNull_ShouldReturnBool(AbstractArrow Arrow, Point startpoint, Point endpoint, bool expected)
        {
            bool actual = Arrow.CheckSelection(startpoint, endpoint);
            Assert.AreEqual(expected, actual);
        }
    }
    public class CheckSelectionTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 
                new AggregationArrow(new Point(0,1),new Point(10,20),Axis.X,Axis.X),
                new Point(0,0),
                new Point(100,100),
                true
                };
            yield return new object[] { 
                new AggregationArrow(new Point(0,1),new Point(10,20),Axis.X,Axis.X),
                new Point(0,0),
                new Point(10,10),
                true
                }; 
            yield return new object[] { 
                new AggregationArrow(new Point(11,15),new Point(100,200),Axis.X,Axis.X),
                new Point(0,0),
                new Point(10,10),
                false
                };
        }
    }
}