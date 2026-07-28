using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Abstraction
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(double diameter)
        {
            this.radius = diameter / 2;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}
