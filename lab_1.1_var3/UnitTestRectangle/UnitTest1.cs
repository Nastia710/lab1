using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestRectangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructor()
        {
            Rectangle rectangle = new Rectangle(5, 10);

            Assert.AreEqual(5, rectangle.A);
            Assert.AreEqual(10, rectangle.B);
        }

        [TestMethod]
        public void TestIndex()
        {
            Rectangle rectangle = new Rectangle(3, 4);

            Assert.AreEqual(3, rectangle[0]);
            Assert.AreEqual(4, rectangle[1]);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            Rectangle rectangle = new Rectangle(5, 7);

            double perimeter = rectangle.GetPerimeter();

            Assert.AreEqual(24, perimeter);
        }

        [TestMethod]
        public void TestArea()
        {
            Rectangle rectangle = new Rectangle(5, 7);

            double area = rectangle.GetArea();

            Assert.AreEqual(35, area);
        }
    }
}
