using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Shape shape in CreateShapes())
            {
                shape.PrintSurface();
            }

            Console.ReadKey();
        }

        public static Shape[] CreateShapes()
        {
            Point p1 = new Point(0, 0);

            Rectangle r1 = new Rectangle(p1, 20, 10);
            Rectangle r2 = new Rectangle(p1, 20, 20);
            Triangle t1 = new Triangle(p1, 20, 10);
            Circle c1 = new Circle(p1, 20);
            Circle c2 = new Circle(p1, 10);

            Shape[] arrShapes = new Shape[5];
            arrShapes[0] = r1;
            arrShapes[1] = r2;
            arrShapes[2] = t1;
            arrShapes[3] = c1;
            arrShapes[4] = c2;

            return arrShapes;
        }
    }
}
