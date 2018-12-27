using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(Point basePoint, int width, int height) : base(basePoint)
        {
            this.Width = width;
            this.Height = height;
        }

        public override decimal CalculateSurface()
        {
            return (decimal)this.Width * this.Height / 2;
        }

        public override string GetShapeType()
        {
            return "Triangle";
        }
    }
}
