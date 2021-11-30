using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's menu choice.
            GetMenu();
        }

        public static int GetMenu()
        {

            int userChoice ;
            

            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            // get input from use
            userChoice = int.Parse(keyboard.KeyChar.ToString());
            // validate input

            if (userChoice == 1)
            {
                CalculateCircleArea();
            }
            else if (userChoice == 2)
            {
                CalculateRectangleArea();
            }
            else if (userChoice == 3)
            {
                CalculateTriangleArea(); 
            }
            else if (userChoice == 4)
            {
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            int radius = int.Parse(Console.ReadLine());
             
            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            double length;
            double width;

            // Get input from user

            // Get length
            Console.WriteLine("Enter length? ");
            length = double.Parse(Console.ReadLine());
            // Get width
            Console.WriteLine("Enter width? ");
            width = double.Parse(Console.ReadLine());

            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            double ground;
            double height;

            // Get input from user

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            ground = double.Parse(Console.ReadLine());
            //read key value

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            height = double.Parse(Console.ReadLine());
            //read key value

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
