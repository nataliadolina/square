using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_app.Figures
{
    /// <summary>
    /// Прямоугольный треугольник. Вычисляет площадь по высоте и основанию
    /// </summary>
    public class RightTriangle : Figure
    {
        private float _a;
        private float _h;

        public RightTriangle(float a, float h)
        {
            _a = a;
            _h = h;
        }
        public override float Square()
        {
            return _a * _h * 0.5f;
        }

        public override string ToString()
        {
            return "right triangle";
        }
    }
}
