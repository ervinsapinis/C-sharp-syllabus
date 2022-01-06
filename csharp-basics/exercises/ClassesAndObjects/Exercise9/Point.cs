using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    internal class Point
    {
        private int _x;
        private int _y;

        public Point(int xValue, int yValue)
        {
            _x = xValue;
            _y = yValue;
        }

        public int X
        {
            get => _x;
            set => _x = value;
        }

        public int Y
        {
            get => _y;
            set => _y = value;
        }
    }
}
