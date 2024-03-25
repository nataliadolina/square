using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_app.Figures
{
    /// <summary>
    /// НЕ прямоугольный треугольник. Вычисляет площадь по формуле Герона
    /// </summary>
    public class NotRightTriangle : Figure
    {
        private float _a;
        private float _b;
        private float _c;

        public NotRightTriangle(float a, float b, float c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override float Square()
        {
            float p = (_a + _b + _c) / 2;
            return MathF.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public override string ToString()
        {
            return "triangle";
        }
    }
}
