using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Abstraction
{
    internal class AbstractionSample
    {
        public static void Run()
        {
            List<Shape> toyBox = new List<Shape>();

            Shape toy = new Triangle(5, 10);
            toyBox.Add(toy);

            toy = new Square(8);
            toyBox.Add(toy);

            toy = new Rectangle(15, 8);
            toyBox.Add(toy);

            toy = new Circle(40);
            toyBox.Add(toy);

            toy = new Rhombus(80, 100);
            toyBox.Add(toy);

            toy = new FancyRhombus(new Triangle(10,12), new Triangle(10,12));
            toyBox.Add(toy);


            double totalArea = 0;

            foreach (Shape shape in toyBox)
            {
                double area = shape.GetArea();

                Console.WriteLine($"{shape.GetType().Name}: {shape.GetArea()}");

                totalArea += totalArea + shape.GetArea();
            }

            Console.WriteLine($"Total Area of ALL Shapes: {totalArea}");

           // Console.WriteLine($"Total Area of Shapes in Toy Box: {toyBox.Sum(x => x.GetArea())}");

        }
    }
}


           /* Square square = new Square(6);

            double areaOfSquare = square.GetArea();

            Console.WriteLine($"Area Of Square: {areaOfSquare}");


            Rectangle rect = new Rectangle(4, 2);

            double areaOfRectangle = rect.GetArea();

            Console.WriteLine($"Area of Recrangle: {areaOfRectangle}");


            Triangle tri = new Triangle(5, 10);

            double areaOfTriangle = tri.GetArea();

            Console.WriteLine($"Area of Recrangle: {areaOfTriangle}");

            Shape newShape = new Circle();
            
             
            
        }

    }
}
           */

    

