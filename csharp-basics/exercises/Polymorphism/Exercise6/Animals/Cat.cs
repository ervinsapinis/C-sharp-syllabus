using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Cat : Feline
    {
        public Cat(string name, string type, double weight, string livingRegion, string breed)
            : base(name, type, weight, livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get; set; }

        public override string MakeSound()
        {
            return "Meow.";
        }

        public override void Eat(Food food)
        {
            FoodEaten += food.Quantity;
        }

    }
}
