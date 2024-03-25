using square_app.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_app.Figures
{
    public class Triangle : Figure
    {
        private Figure _figure;

        public Figure Figure => _figure;

        public Triangle(float a, float b, float c)
        {
            bool isRight = false;
            float[] sides = new float[] { a, b, c };
            int[] indeces = new int[3] { 0, 1, 2 };
            for (int i = 0; i < sides.Length; i++)
            {
                int[] otherSidesIndeces = indeces.Except(new int[] { i }).ToArray();
                float side1 = sides[otherSidesIndeces[0]];
                float side2 = sides[otherSidesIndeces[1]];
                float side = sides[i];
                if (side >= side1 + side2)
                {
                    throw new InvalidFigureException("Triangle with such sides doesn't exist.");
                }

                if (MathF.Pow(side, 2) == MathF.Pow(side1, 2) + MathF.Pow(side2, 2))
                {
                    _figure = new RightTriangle(side1, side2);
                    isRight = true;
                    break;
                }
            }

            if (!isRight)
            {
                _figure = new NotRightTriangle(a, b, c);
            }
        }

        public override float Square()
        {
            return _figure.Square();
        }

        public override string ToString()
        {
            return _figure.ToString();
        }
    }
}
