using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Tiger : Feline
    {

        public Tiger(string name, string type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!"); }

        public override void Eat(Food food)
        {
            if (food is Meat)
                FoodEaten += food.Quantity;
            else
            {
                Console.WriteLine("This animal can't eat that.");
                FoodEaten = 0;
            }
        }
    }
}
