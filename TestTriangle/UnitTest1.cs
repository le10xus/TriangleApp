using TriangleLib;

namespace TestTriangle
{
    public class Tests
    {
        private Triangle acuteTriangle;
        private Triangle rightTriangle;
        private Triangle obtuseTriangle;


        [SetUp]
        public void Setup()
        {
            acuteTriangle = new Triangle(3.2, 2, 3.2);
            rightTriangle = new Triangle(3, 2, 3.6);
            obtuseTriangle = new Triangle(3.2, 2, 4.2);
        }

        [Test]
        public void HandlesArgumentExeptionOnTriangleParameter()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 2, 3));
        }

        [Test]
        public void TestAcuteType()
        {
            var type = acuteTriangle.GetTriangleType();
            Assert.That(type, Is.EqualTo(TriangleType.Acute));
        }

        [Test]
        public void TestRightType()
        {
            var type = rightTriangle.GetTriangleType();
            Assert.That(type, Is.EqualTo(TriangleType.Right));
        }

        [Test]
        public void TestObtuseType()
        {
            var type = obtuseTriangle.GetTriangleType();
            Assert.That(type, Is.EqualTo(TriangleType.Obtuse));
        }
    }
}