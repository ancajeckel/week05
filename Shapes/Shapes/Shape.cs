using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape : IShape
    {
        public Point Point { get; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Shape(Point point)
        {
            this.Point = point;
        }


        public abstract decimal CalculateSurface();

        public virtual void PrintSurface()
        {
            Console.WriteLine($"{this.GetShapeType()} area: {this.CalculateSurface()}");
        }

        public abstract string GetShapeType();
    }
}
