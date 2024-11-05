using lab_1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetPerimeter()
        {
            Rectangle rect = new Rectangle(5, 10);

            double expectedPerimeter = 2 * (rect.A + rect.B);
            double perimeter = rect.GetPerimeter();

            Assert.AreEqual(expectedPerimeter, perimeter);
        }

        [Test]
        public void GerArea()
        {
            Rectangle rect = new Rectangle(5, 10);

            double expectedArea = rect.A * rect.B;
            double area = rect.GetArea();

            Assert.AreEqual(expectedArea, area);
        }

        [Test]
        public void CorrectIndex()
        {
            Rectangle rect = new Rectangle(5, 10);

            Assert.AreEqual(5, rect[0]);
            Assert.AreEqual(10, rect[1]);
        }

        [Test]
        public void NotCorrectIndex()
        {
            Rectangle rect = new Rectangle(5, 10);

            Assert.Throws<IndexOutOfRangeException>(() => { var value = rect[2]; });
        }

        [Test]
        public void SetA_and_B_PositiveSides()
        {
            Rectangle rect = new Rectangle(1, 1);

            rect.A = 5;
            rect.B = 10;

            Assert.AreEqual(5, rect.A);
            Assert.AreEqual(10, rect.B);
        }

        [Test]
        public void SetA_and_B_NotPositiveSides()
        {
            Rectangle rect = new Rectangle(1, 1);

            rect.A = -5;
            rect.B = -10;

            Assert.AreEqual(1, rect.A);
            Assert.AreEqual(1, rect.B);
        }
    }
}