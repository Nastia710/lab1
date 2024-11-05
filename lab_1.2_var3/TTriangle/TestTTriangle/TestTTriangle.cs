using lab1_2_TTriangle;

namespace TestTTriangle
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DefaultConstructor()
        {
            TTriangle tr = new TTriangle();

            Assert.AreEqual(0, tr.A);
            Assert.AreEqual(0, tr.B);
            Assert.AreEqual(0, tr.C);
        }

        [Test]
        public void CorrectSides()
        {
            TTriangle triangle = new TTriangle(3, 4, 5);

            Assert.AreEqual(3, triangle.A);
            Assert.AreEqual(4, triangle.B);
            Assert.AreEqual(5, triangle.C);
        }

        [Test]
        public void NotCorrectSides()
        {
            Assert.Throws<ArgumentException>(() => new TTriangle(-3, -4, 0));
        }

        [Test]
        public void CopyConstructor()
        {
            TTriangle originalTriangle = new TTriangle(5, 3, 4);

            TTriangle newTriangle = new TTriangle(originalTriangle);

            Assert.AreEqual(originalTriangle.A, newTriangle.A);
            Assert.AreEqual(originalTriangle.B, newTriangle.B);
            Assert.AreEqual(originalTriangle.C, newTriangle.C);
        }

        [Test]
        public void TriangleNotExist()
        {
            Assert.Throws<ArgumentException>(() => new TTriangle(1, 2, 4));
        }

        [Test]
        public void GetPerimeter()
        {
            TTriangle triangle = new TTriangle(3, 4, 5);

            double expectedPerimeter = triangle.A + triangle.B + triangle.C;
            double p = triangle.GetPerimeter();

            Assert.AreEqual(expectedPerimeter, p);
        }

        [Test]
        public void GetArea()
        {
            TTriangle triangle = new TTriangle(3, 4, 5);

            double p = (triangle.A + triangle.B + triangle.C) / 2;
            double expectedArea = Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));

            double area = triangle.GetArea();

            Assert.AreEqual(expectedArea, area);

        }

        [Test]
        public void SetA_and_B_and_C_PositiveSides()
        {
            TTriangle triangle = new TTriangle(3, 4, 5);

            double newSideA = 6;
            double newSideB = 8;
            double newSideC = 10;

            triangle.A = newSideA;
            triangle.B = newSideB;
            triangle.C = newSideC;

            Assert.AreEqual(newSideA, triangle.A);
            Assert.AreEqual(newSideB, triangle.B);
            Assert.AreEqual(newSideC, triangle.C);
        }

        [Test]
        public void SetA_and_B_and_C_NotPositiveSides()
        {
            TTriangle triangle = new TTriangle();

            Assert.Throws<ArgumentException>(() => triangle.A = -5);
            Assert.Throws<ArgumentException>(() => triangle.B = -3);
            Assert.Throws<ArgumentException>(() => triangle.C = -4);
        }

        [Test]
        public void CompareTo()
        {
            TTriangle tr1 = new TTriangle(6, 8, 10);
            TTriangle tr2 = new TTriangle(6, 8, 10);
            Assert.AreEqual(true, tr1.IsEqual(tr2));
        }

        [Test]
        public void Operator_Multiply_Triangle_and_Number()
        {
            TTriangle tr = new TTriangle(8, 10, 6);

            double multiplier = 2;

            double expectedSideA = tr.A * multiplier;
            double expectedSideB = tr.B * multiplier;
            double expectedSideC = tr.C * multiplier;

            var result = tr * multiplier;

            Assert.AreEqual(expectedSideA, result.A);
            Assert.AreEqual(expectedSideB, result.B);
            Assert.AreEqual(expectedSideC, result.C);
        }

        [Test]
        public void Operator_Multiply_Number_and_Triangle()
        {
            TTriangle tr = new TTriangle(8, 10, 6);

            double multiplier = 4;

            double expectedSideA = multiplier * tr.A;
            double expectedSideB = multiplier * tr.B;
            double expectedSideC = multiplier * tr.C;

            TTriangle result = multiplier * tr;

            Assert.AreEqual(expectedSideA, result.A);
            Assert.AreEqual(expectedSideB, result.B);
            Assert.AreEqual(expectedSideC, result.C);
        }
    }
}