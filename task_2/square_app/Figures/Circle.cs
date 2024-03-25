using square_app.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_app.Figures
{
    public class Circle : Figure
    {
        private float _radius;
        public Circle(float radius)
        {
            _radius = radius;
            if (radius <= 0)
            {
                throw new InvalidFigureException("Radius cannot be zero or negative. Please enter positive number.");
            }
        }

        public override float Square()
        {
            return MathF.PI * MathF.Pow(_radius, 2);
        }

        public override string ToString()
        {
            return "circle";
        }
    }
}
