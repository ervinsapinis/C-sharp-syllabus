using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Zebra : Mammal
    {
        public Zebra(string name, AnimalEnums type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "~~~~confused zebra noises~~~";
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
                FoodEaten += food.Quantity;
            else
            {
                AppMessages.InvalidFoodGiven();
                FoodEaten = 0;
            }
        }
    }
}
