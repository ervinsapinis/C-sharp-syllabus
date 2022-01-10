using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public abstract class Animal
    {
        public Animal(string name, string type, double weight)
        {
            Name = name;
            Type = type;
            Weight = weight;
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public virtual string MakeSound()
        {
            return "silence";
        }

        public virtual void Eat(Food food)
        {
        }
    }
}
