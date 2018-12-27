using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        private const decimal pi = (decimal)Math.PI;

        public Circle(Point basePoint, int width) : base(basePoint)
        {
            this.Width = width;
            this.Height = width;
        }

        public override decimal CalculateSurface()
        {
            return pi * (this.Width / 2) * (this.Width / 2);
        }

        public override string GetShapeType()
        {
            return "Circle";
        }
    }
}
