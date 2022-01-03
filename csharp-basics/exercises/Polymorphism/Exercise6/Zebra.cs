using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Zebra : Mammal
    {
        public Zebra(string name, string type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("~~~~confused zebra noises~~~");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
                FoodEaten += food.Quantity;
            else
            {
                Console.WriteLine("This animal can't eat that.");
                FoodEaten = 0;
            }
        }

    }
}
