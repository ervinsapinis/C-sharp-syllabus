using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var soundList = new List<ISound>();
            soundList.Add(new Radio());
            soundList.Add(new Parrot());
            soundList.Add(new Cowboy());
            soundList.Add(new Firework());
            soundList.Add(new Latvian());


            foreach (var soundingObject in soundList)
            {
                soundingObject.PlaySound();
            }

        }
    }
}