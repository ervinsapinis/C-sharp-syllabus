using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    internal class Mercedes : ICar, IBoostable

    {
    private int _currentSpeed = 0;

    public void SpeedUp()
    {
        _currentSpeed+=28;
    }

    public void SlowDown()
    {
        _currentSpeed-=20;
    }

    public string Show_currentSpeed()
    {
        return _currentSpeed.ToString();
    }

    public void StartEngine()
    {
        Console.WriteLine("eeeeee BRRBRBRBRBRBRBRBR...");
    }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed+=25;
        }
    }
}
