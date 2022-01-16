using System;

namespace DragRace
{
    public class Bmw : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed+=20;
        }

        public void SlowDown() 
        {
            _currentSpeed-=20;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}