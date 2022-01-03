using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public abstract class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;

        protected Animal(string name, string type, double weight)
        {
            _animalName = name;
            _animalType = type;
            _animalWeight = weight;
        }

        public string Name
        {
            get { return _animalName; }
            set { _animalName = value; }
        }

        public string Type
        {
            get { return _animalType;}
            set { _animalType = value; }
        }

        public double Weight
        {
            get { return _animalWeight; }
            set { _animalWeight = value; }
        }

        public int FoodEaten
        {
            get { return _foodEaten; }
            set { _foodEaten = value; }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("silence");
        }

        public virtual void Eat(Food food)
        {
        }
    }
}
