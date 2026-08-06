using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Polymorphism
{
    internal class Lion : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Roar!");

            string filename = "./Polymorphism/sounds/lion.mp3";

            using (var audioFile = new AudioFileReader(filename))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
