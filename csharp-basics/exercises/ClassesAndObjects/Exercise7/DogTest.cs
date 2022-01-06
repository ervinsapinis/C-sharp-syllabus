using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class DogTest
    {
        public static void Run()
        {
            Dog maxDog = new Dog("Max", "male");
            Dog rockyDog = new Dog("Rocky", "male");
            Dog sparkyDog = new Dog("Sparky", "male");
            Dog busterDog = new Dog("Buster", "male");
            Dog samdDog = new Dog("Sam", "male");

            Dog ladyDog = new Dog("Lady", "female");
            Dog mollyDog = new Dog("Molly", "female");
            Dog cocoDog = new Dog("Coco", "female");

            maxDog.MotherDog = ladyDog;
            maxDog.FatherDog = rockyDog;
            cocoDog.MotherDog = mollyDog;
            cocoDog.FatherDog = busterDog;
            rockyDog.MotherDog = mollyDog;
            rockyDog.FatherDog = samdDog;
            busterDog.MotherDog = ladyDog;
            busterDog.FatherDog = sparkyDog;

            Console.WriteLine(cocoDog.FathersName());
            Console.WriteLine(sparkyDog.FathersName());
            Console.WriteLine(cocoDog.HasSameMotherAs(rockyDog));

        }
    }
}
