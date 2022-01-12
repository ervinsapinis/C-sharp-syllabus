using System;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
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

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            _currentSpeed+=50;
        }

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}