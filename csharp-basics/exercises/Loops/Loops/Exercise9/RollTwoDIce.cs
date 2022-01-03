using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    internal class RollTwoDIce
    {
        public static void DiceRoll()
        {
            Console.WriteLine("please input desired sum (1-12):");
            int desiredSum = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            while (true)
            {
                int dice, dice2, sum;
                dice = rnd.Next(1, 6);
                dice2 = rnd.Next(1, 6);
                sum = dice + dice2;
                Console.WriteLine($"{dice} and {dice2} = {sum}");
                if (sum == desiredSum)
                {
                    break;
                }
            }
        }
    }
}
