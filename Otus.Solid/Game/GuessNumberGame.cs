using Otus.Solid.Abstractions;
using System;

namespace Otus.Solid.Game
{
    public class GuessNumberGame : Game
    {
        private int hiddenNumber;
        private int numberAttempts = 0;

        public GuessNumberGame(IReader reader, IPrinter printer, GameSettings settings)
            : base(reader, printer, settings)
        { }

        public override void Start()
        {
            MakeGuess();

            Console.WriteLine($"Загаданное число: {hiddenNumber}");

            Printer.PrintGreeting(Setting.TotalNumberAttempts, Setting.MinNumber, Setting.MaxNumber);

            do
            {
                var guess = ReadGuess();

                if (guess == -1) continue;

                numberAttempts++;

                CheckGuess(guess);

                if (guess == hiddenNumber) return;
            }
            while (numberAttempts < Setting.TotalNumberAttempts);

            Printer.PrintDefeatMessage();

            return;
        }

        private void MakeGuess()
        {
            var rnd = new Random();
            hiddenNumber = rnd.Next(Setting.MinNumber, Setting.MaxNumber);
        }

        private void CheckGuess(int guess)
        {
            if (guess < hiddenNumber) Printer.PrintFailureMessage(GetRemainingAttempts(), false);

            if (guess > hiddenNumber) Printer.PrintFailureMessage(GetRemainingAttempts(), true);

            if (guess == hiddenNumber) Printer.PrintVictoryMessage(numberAttempts);
        }

        private int GetRemainingAttempts() => Setting.TotalNumberAttempts - numberAttempts;

        public int ReadGuess()
        {
            try
            {
                var guess = Reader.Read();

                if (guess < Setting.MinNumber) throw new Exception("Введено число меньше минимального");

                if (guess > Setting.MaxNumber) throw new Exception("Введено число больше максимального");

                return guess; 
            }
            catch (Exception e)
            {
                Printer.PrintException(e);
                return -1;
            }
        }
    }
}
