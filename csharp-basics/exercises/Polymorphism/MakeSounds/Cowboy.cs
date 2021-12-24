using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeSounds
{
    internal class Cowboy : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("HEEEEEEEEEEEEEE HAAAAAAW");
        }
    }
}
