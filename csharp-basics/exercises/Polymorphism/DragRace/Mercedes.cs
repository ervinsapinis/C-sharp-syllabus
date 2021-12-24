using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    internal class Mercedes : ICar, IBoostable

    {
    private int currentSpeed = 0;

    public void SpeedUp()
    {
        currentSpeed+=20;
    }

    public void SlowDown()
    {
        currentSpeed-=20;
    }

    public string ShowCurrentSpeed()
    {
        return currentSpeed.ToString();
    }

    public void StartEngine()
    {
        Console.WriteLine("eeeeee BRRBRBRBRBRBRBRBR...");
    }

        public void UseNitrousOxideEngine()
        {
            currentSpeed+=25;
        }
    }
}
