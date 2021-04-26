using NUnit.Framework;
using Project_UML.Core.Arrows;
using System.Drawing;
using System.Collections;
using Project_UML.Core;

namespace ChangeColor.Tests
{
    public class ChangeColorTests
    {
        [TestCaseSource(typeof(ChangeColorTestSource))]
        public void ChangeColor_WhenAlways_ShouldChangeColor(AggregationArrow Arrow, Color newColor, Color expected)
        {
            Arrow.ChangeColor(newColor);
            Color actual = Arrow.GetColor();
            Assert.AreEqual(expected, actual);
        }
    }
    public class ChangeColorTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {
                new AggregationArrow(Color.Black,1),
                Color.Red,
                Color.Red
            };
            yield return new object[] {
                new AggregationArrow(Color.Black,1),
                Color.Green,
                Color.Green
            };
            yield return new object[] {
                new AggregationArrow(Color.Black,1),
                Color.Orange,
                Color.Orange
            };
        }
    }
}