using System;

namespace DragRace
{
    public class Tesla : ICar

    {
    private int currentSpeed = 0;

    public void SpeedUp()
    {
        currentSpeed+=35;
    }

    public void SlowDown()
    {
        currentSpeed-=35;
    }

    public string ShowCurrentSpeed()
    {
        return currentSpeed.ToString();
    }

    public void StartEngine()
    {
        Console.WriteLine("-- silence ---");
    }
    }
}