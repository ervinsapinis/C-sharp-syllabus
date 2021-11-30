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
            double area = Math.PI * radius * radius;
            return Math.Round(area, 2);
        }

        public static double AreaOfRectangle(double length, double width)
        {
            double area = (double)length * width;
            return area;
        }

        public static double AreaOfTriangle(double ground, double height)
        {
            double area = (ground * height) / 2;
            return area;
        }
    }
}
