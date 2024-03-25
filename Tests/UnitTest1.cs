using square_app.Exceptions;
using square_app.Figures;
namespace Tests
{
    public class Tests
    {
        [TestCase(1, MathF.PI)]
        [TestCase(3, 9*MathF.PI)]
        [TestCase(2, 4*MathF.PI)]
        public void TestCircleSquare(float radius, float square)
        {
            Figure figure = new Circle(radius);
            Assert.That(square, Is.EqualTo(figure.Square()));
        }

        [TestCase(2, 2 ,2)]
        [TestCase(5, 6, 7)]
        [TestCase(7, 6, 5)]
        [TestCase(12, 2, 13)]
        [TestCase(9, 3, 7)]
        [TestCase(3, 4, 5)]
        public void TestTriangleSquare(float a, float b, float c)
        {
            float p = (a + b + c)/2;
            float heronSquare = MathF.Sqrt(p*(p - a)*(p-b)*(p-c));
            Figure figure = new Triangle(a, b, c);
            Assert.That(heronSquare, Is.EqualTo(figure.Square()));
        }

        [TestCase(3, 4, 5)]
        [TestCase(4, 5, 3)]
        [TestCase(5, 4, 3)]
        [TestCase(3, 5, 4)]
        [TestCase(5, 12, 13)]
        [TestCase(73, 55, 48)]
        public void TestTriangleIsRight(float a, float b, float c)
        {
            Triangle figure = new Triangle(a, b, c);
            Assert.That(figure.Figure, Is.TypeOf(typeof(RightTriangle)));
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 1)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 45, 3)]
        [TestCase(-2, -3, -2)]
        public void TestTriangleDoesnotExist(float a, float b, float c)
        {
            Assert.That(() => new Triangle(a, b, c), Throws.InstanceOf<InvalidFigureException>());
        }

        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(-3)]
        public void TestCircleIsDoesNotExist(float radius)
        {
            Assert.That(() => new Circle(radius), Throws.InstanceOf<InvalidFigureException>());
        }
    }
}