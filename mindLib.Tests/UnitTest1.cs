using NUnit.Framework;

namespace mindLib.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void isNotStraightTrinagleNotStraight()
        {
            // ARRANGE
            var trinagle = new Triangle(5, 6, 7);

            // ACT
            var result = trinagle.IsStraight();

            // ASSERT
            Assert.IsFalse(result);
        }

        [Test]
        public void exceptedAreaValue()
        {
            // ARRANGE
            var triangle = new Triangle(3, 4, 5);
            double excepted = 6;

            // ACT
            var result = triangle.Area();

            // ASSERT
            Assert.AreEqual(excepted, result);
        }
    }

    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CircleArea100()
        {
            // ARRANGE
            var circle = new Circle(5.641895);
            var excepted = 100;

            // ACT
            var result = circle.Area();

            // ASSERT
            Assert.AreEqual(result, excepted);
        }
    }
}