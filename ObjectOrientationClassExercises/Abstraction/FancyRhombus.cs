using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Abstraction
{
    internal class FancyRhombus : Shape
    {
        private Shape firstTriangle;
        private Shape secondTriangle;

        public FancyRhombus(Triangle firstTriangle, Triangle secondTriangle)
        {
            this.firstTriangle = firstTriangle;
            this.secondTriangle = secondTriangle; 
        }            

        public override double GetArea()
        {
            return firstTriangle.GetArea() + secondTriangle.GetArea();
        }
    }
}
