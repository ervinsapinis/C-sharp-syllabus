using System;

namespace DragRace
{
    public class Tesla : ICar

    {
    private int _currentSpeed = 0;

    public void SpeedUp()
    {
        _currentSpeed+=35;
    }

    public void SlowDown()
    {
        _currentSpeed-=35;
    }

    public string Show_currentSpeed()
    {
        return _currentSpeed.ToString();
    }

    public string StartEngine()
    {
        return "-- silence ---";
    }
    }
}