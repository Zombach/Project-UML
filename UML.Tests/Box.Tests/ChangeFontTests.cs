using NUnit.Framework;
using Project_UML.Core.Arrows;
using System.Drawing;
using System.Collections;
using Project_UML.Core;
using Project_UML.Core.Boxes;

namespace ChangeFont.Tests
{
    public class ChangeFontTests
    {
        [TestCaseSource(typeof(ChangeFontTestSource1))]
        public void ChangeFont_WhenAlways_ShouldChangeFont(RectangleClass box, Font font, Font expected)
        {
            box.ChangeFont(font);
            Font actual = box.GetFont();
            Assert.AreEqual(expected, actual);
        }
    }
    public class ChangeFontTestSource1 : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {
                new RectangleClass(Color.Black,1),
                new Font("Microsoft YaHei", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                new Font("Microsoft YaHei", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)))
            };
            yield return new object[] {
                new RectangleClass(Color.Black,1),
                new Font("Yu Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                new Font("Yu Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)))
            };
            yield return new object[] {
                new RectangleClass(Color.Black,1),
                new Font("Gadugi", 16.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                new Font("Gadugi", 16.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)))
            };
        }
    }
}