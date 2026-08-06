using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ObjectOrientationClassExercises.Polymorphism
{
    internal class Cow : Animal
    {
            
        public override void MakeNoise()
        {
            Console.WriteLine("Moo!");

            PlaySound("cow.mp3");
        }
    }

}

