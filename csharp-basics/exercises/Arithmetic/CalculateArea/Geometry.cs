using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(int radius)
        {
            if (radius <= 0) throw new ArgumentException();
            double area = Math.PI * radius * radius;
            return Math.Round(area, 2);
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return (double)length * width;
        }

        public static double AreaOfTriangle(double ground, double height)
        {
            return (ground * height) / 2;
        }
    }
}
