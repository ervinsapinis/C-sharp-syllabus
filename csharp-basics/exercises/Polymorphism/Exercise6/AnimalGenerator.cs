using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Exercise6
{
    public class AnimalGenerator

    {
        public Mammal CreateAnimal(AnimalEnums type, string name, double weight, string region)
        {
            switch (type)
            {
                case AnimalEnums.Tiger:
                    return new Tiger(name, type, weight, region);
                case AnimalEnums.Mouse:
                    return new Mouse(name, type, weight, region);
                case AnimalEnums.Zebra:
                    return new Zebra(name, type, weight, region);
                default:
                    throw new ArgumentException();
            }
        }
        public Cat CreateCat(AnimalEnums type, string name, double weight, string region, string breed)
        {
            return new Cat(name, type, weight, region, breed);
        }
    }
}