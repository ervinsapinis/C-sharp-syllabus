using System;
using System.Runtime.CompilerServices;

namespace Exercise8
{
    internal class Program
    {
        static void Main()
        {
            string[] wordList =
            {
                "Archipelago", "Astrophysics", "Reptilian", "Processor"
            };

            var rnd = new Random();

            string word = wordList[rnd.Next(wordList.Length)];
            char[] wordChars = word.ToCharArray();

            string guessableWord = new string(c:'_', word.Length);
            char[] guessableWordArr = guessableWord.ToCharArray();

            char[] misses = new char[5];
            var missCounter = 0;

            while (Array.IndexOf(guessableWordArr, '_') != -1)
            {
                Console.WriteLine("Word: {0}", string.Join(" ", guessableWordArr));
                Console.WriteLine("Misses: {0}", string.Join(" ", misses));
                var input = Console.ReadKey();
                var guess = input.KeyChar;
                Console.WriteLine();
                Console.Write($"Guess: {guess}");

                if (DoesContainLetter(word, guess))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word.ToLower()[i] == guess)
                        {
                            guessableWordArr[i] = wordChars[i];
                        }
                    }
                }
                else
                {
                    misses[missCounter] = guess;
                    missCounter++;
                }

                if (missCounter > 4)
                {
                    Console.Clear();
                    Console.WriteLine("You lost!");
                    break;
                }
                else if (Array.IndexOf(guessableWordArr, '_') == -1)
                {
                    Console.Clear();
                    Console.WriteLine("YOU GOT IT!");
                    Console.WriteLine($"The word was: {word}");
                    break;
                }
            }

            Console.WriteLine("Play again? Y/N");
            char restartChar = Console.ReadKey().KeyChar;
            Restart(restartChar);
        }

        private static void Restart(char input)
        {
            if (input == 'y')
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Bye!");
            }
        }

        private static bool DoesContainLetter(string word, char guess)
        {
            return word.ToLower().IndexOf(guess) > -1;
        }
    }
}
