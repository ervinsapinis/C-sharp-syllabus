namespace DragRace
{
    public interface ICar
    {
        void SpeedUp();
        void SlowDown();
        string Show_currentSpeed();
        void StartEngine();
    }
}