using lab1_2_TTriangle;

namespace TestPrizm
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
            TTrianglePrizm prizm = new TTrianglePrizm();

            Assert.AreEqual(0, prizm.H);
        }

        [Test]
        public void CorrectH()
        {
            TTrianglePrizm triangle = new TTrianglePrizm(3, 4, 5, 5);

            Assert.AreEqual(5, triangle.H);
        }

        [Test]
        public void NotCorrectH()
        {
            Assert.Throws<ArgumentException>(() => new TTrianglePrizm(3, 4, 5, -2));
        }

        [Test]
        public void CopyConstructor()
        {
            TTriangle originalTriangle = new TTriangle(5, 3, 4);
            double h = 5;
            TTrianglePrizm originalPrizm = new TTrianglePrizm(originalTriangle, h);

            TTrianglePrizm newPrizm = new TTrianglePrizm(originalTriangle, h);

            Assert.AreEqual(originalPrizm.H, newPrizm.H);
        }

        [Test]
        public void SetH_PositiveSides()
        {
            TTrianglePrizm prizm = new TTrianglePrizm();

            double newSideH = 10;

            prizm.H = newSideH;

            Assert.AreEqual(newSideH, prizm.H);
        }

        [Test]
        public void SetH_NotPositiveSides()
        {
            TTrianglePrizm prizm = new TTrianglePrizm();

            Assert.Throws<ArgumentException>(() => prizm.H = -5);
        }

        [Test]
        public void GetValue()
        {
            double h = 6;

            TTriangle triangle = new TTriangle(3, 4, 5);

            double p = (triangle.A + triangle.B + triangle.C) / 2;
            double expectedArea = Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));
            double expectedVolume = h * expectedArea;

            TTrianglePrizm prizm = new TTrianglePrizm(3, 4, 5, 6);

            double volume = prizm.GetVolume();

            Assert.AreEqual(expectedVolume, volume);

        }

        [Test]
        public void Operator_Multiply_Prizm_and_Number()
        {
            TTrianglePrizm prizm = new TTrianglePrizm(8, 10, 6, 7);

            double multiplier = 2;

            double expectedSideH = prizm.H * multiplier;

            var result = prizm * multiplier;

            Assert.AreEqual(expectedSideH, result.H);
        }

        [Test]
        public void Operator_Multiply_Number_and_Prizm()
        {
            TTrianglePrizm prizm = new TTrianglePrizm(8, 10, 6, 7);

            double multiplier = 2;

            double expectedSideH = multiplier * prizm.H;

            var result = multiplier * prizm;

            Assert.AreEqual(expectedSideH, result.H);
        }
    }
}