using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeSounds
{
    internal class Parrot : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine($"kwaaaa chew chew");
        }
    }
}
