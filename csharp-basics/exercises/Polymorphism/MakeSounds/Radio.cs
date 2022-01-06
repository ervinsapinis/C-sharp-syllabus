using System;

namespace MakeSounds
{
    public class Radio : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("--static--khhhh-static---");
        }
    }
}