using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Polymorphism
{
    internal class Hyena : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("HEHEHE!");
        }
    }
}
