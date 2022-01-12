using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    public class Toyota : ICar
    {
        private int _currentSpeed = 0;
        public void SpeedUp()
        {
            _currentSpeed+=25;
        }

        public void SlowDown()
        {
            _currentSpeed-=25;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "krrrr-wroooom.";
        }
    }
}
