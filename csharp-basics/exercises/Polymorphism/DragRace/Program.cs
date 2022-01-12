using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        private static void Main(string[] args)
        {
            var carList = new List<ICar>();
            var results = new List<int>();
            var audiA4 = new Audi();
            var zhurka = new Bmw();
            var roadster = new Tesla();
            var lexus = new Lexus();
            var corolla = new Toyota();
            var w219amg = new Mercedes();
            carList.Add(audiA4);
            carList.Add(zhurka);
            carList.Add(roadster);
            carList.Add(lexus);
            carList.Add(corolla);
            carList.Add(w219amg);

            Console.WriteLine("Gentlemen, start your engines!");

            for (int i = 1; i <= 10; i++)
            {
                foreach (var car in carList)
                {
                    if (i == 1)
                        Console.WriteLine(car.StartEngine());
                    else if (i % 3 == 0)
                        if (car is IBoostable)
                            ((IBoostable) car).UseNitrousOxideEngine();
                    car.SpeedUp();
                }
            }

            for (int i = 0; i < carList.Count; i++)
            {
                results.Add(int.Parse(carList[i].ShowCurrentSpeed()));
            }

            var winner = carList.Find(car => results.Max() == int.Parse(car.ShowCurrentSpeed()));

            Console.WriteLine("ZOOOOM!!!!");
            Console.WriteLine("WHOOSH!!!!");
            Console.WriteLine("RRRRRRRRRRRRRRRROOOOOM!!!!");
            Console.WriteLine("PHEEEEEEW!!!!");

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.GetType().Name} finished with a speed of {car.ShowCurrentSpeed()}");
            }

            Console.WriteLine();
            Console.WriteLine($"And the winner is {winner.GetType().Name} with a speed of {results.Max()}");
            Console.ReadKey();
        }
    }
}