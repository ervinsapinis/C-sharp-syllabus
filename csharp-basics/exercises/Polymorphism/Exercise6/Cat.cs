using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Cat : Feline
    {
        private string _breed;
        public Cat(string name, string type, double weight, string livingRegion, string breed)
            : base(name, type, weight, livingRegion)
        {
            _breed = breed;
        }

        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow.");
        }

        public override void Eat(Food food)
        {
            FoodEaten += food.Quantity;
        }

    }
}
