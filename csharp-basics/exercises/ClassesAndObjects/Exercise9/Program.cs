using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            SwapPoints(p1, p2);
            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
        }

        static void SwapPoints(Point firstPoint, Point secondPoint)
        {
            var value1 = firstPoint.X;
            var value2 = secondPoint.X;
            firstPoint.X = value2;
            secondPoint.X = value1;
            var value3 = firstPoint.Y;
            var value4 = secondPoint.Y;
            firstPoint.Y = value4;
            secondPoint.Y = value3;
        }
    }
}
