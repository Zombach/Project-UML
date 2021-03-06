using NUnit.Framework;
using Project_UML.Core.Arrows;
using System.Drawing;
using System.Collections;
using Project_UML.Core;

namespace ChangeWidth.Tests
{
    public class ChangeWidthTests
    {
        [TestCaseSource(typeof(ChangeWidthTestSource))]
        public void ChangeWidth_WhenAlways_ShouldChangeWidth(AggregationArrow arrow, int newWidth, float expected)
        {
            arrow.ChangeWidth(newWidth);
            float actual = arrow.GetWidth();
            Assert.AreEqual(expected, actual);
        }
    }
    public class ChangeWidthTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {
                new AggregationArrow(Color.Black,1),
                2,
                2
            };
            yield return new object[] {
                new AggregationArrow(Color.Black,1),
                3,
                3
            };
            yield return new object[] {
                new AggregationArrow(Color.Black,1),
                4,
                4
            };
        }
    }
}