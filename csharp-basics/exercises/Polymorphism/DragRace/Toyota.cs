﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    internal class Toyota : ICar
    {
        private int currentSpeed = 0;
        public void SpeedUp()
        {
            currentSpeed+=25;
        }

        public void SlowDown()
        {
            currentSpeed-=25;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("krrrr-wroooom.");
        }
    }
}
