using System;

namespace Exercise4
{
    class Program
    {
        //TODO: print all vowels using for and foreach
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            for (int i = 0; i < vowels.Length; i++) 
            {
                Console.Write(" "+vowels[i]);
            }

            Console.WriteLine();

            foreach (var vowel in vowels)
            {
                Console.Write(" " + vowel);
            }

            Console.WriteLine();
        }
    }
}
