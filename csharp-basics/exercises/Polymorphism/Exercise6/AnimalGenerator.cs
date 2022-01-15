﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Exercise6
{
    public class AnimalGenerator

    {
        public Mammal CreateAnimal(string type, string name, double weight, string region)
        {
            switch (type.ToLower())
            {
                case "tiger":
                    return new Tiger(name, type, weight, region);
                case "mouse":
                    return new Mouse(name, type, weight, region);
                case "zebra":
                    return new Zebra(name, type, weight, region);
                default:
                    throw new ArgumentException();
            }
        }
        public Cat CreateCat(string type, string name, double weight, string region, string breed)
        {
            if (type.ToLower() != "cat")
                throw new ArgumentException();
            return new Cat(name, type, weight, region, breed);
        }
    }
}