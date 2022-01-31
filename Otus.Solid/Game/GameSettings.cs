using System;

namespace Otus.Solid.Game
{
    public class GameSettings
    {
        public int TotalNumberAttempts { get; private set; } = 5;
        public int MinNumber { get; private set; } = 0;
        public int MaxNumber { get; private set; } = 100;

        public GameSettings SetTotatNumberAttempts(int value)
        {
            TotalNumberAttempts = value;
            return this;
        }

        public GameSettings SetMinNumber(int value)
        {
            if (value >= MaxNumber) throw new Exception("Минимальное число равно или больше максимального");
            MinNumber = value;
            return this;
        }

        public GameSettings SetMaxNumber(int value)
        {
            if (value <= MinNumber) throw new Exception("Максимальное число равно или меньше минимального");
            MaxNumber = value;
            return this;
        }
    }
}
