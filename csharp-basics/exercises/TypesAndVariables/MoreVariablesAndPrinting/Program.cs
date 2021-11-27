using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, eyes, teeth, hair;
            int age, height, weight;
            double heightInCm, weightInKilos;

            name = "Zed A. Shaw";
            age = 35;
            height = 74;  // inches
            weight = 180; // lbs
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";
            heightInCm = Math.Round((double)height * 2.54, 2);
            weightInKilos = Math.Round((double)weight * 0.453592, 2);

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height + " inches tall. Which is " + heightInCm + " in cm.");
            Console.WriteLine("He's " + weight + " pounds heavy. Which is " + weightInKilos + " in kg.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight
                               + " I get " + (age + height + weight) + ".");
             
            Console.ReadKey();
        }
    }
}