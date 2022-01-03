using System;

namespace DragRace
{
    public class Audi : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed+=15;
        }

        public void SlowDown() 
        {
            _currentSpeed-=15;
        }

        public string Show_currentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }

    }
}