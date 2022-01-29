using Otus.Solid.Abstractions;
using System;

namespace Otus.Solid.Game
{
    public class GamePrinter
    {
        private IPrinter Printer { get; init; }

        public GamePrinter(IPrinter printer)
        {
            Printer = printer;
        }

        public void PrintGreeting(int numberAttempts, int minNumber, int maxNumber)
        {
            Printer.Print("Добро пожаловать в игру \"Угадай число\"");
            Printer.Print($"Угадайте число от {minNumber} до {maxNumber}");
            Printer.Print($"На это у вас есть {numberAttempts} попыток");
        }

        public void PrintFailureMessage(int remainingAttempts, bool isGreater)
        {
            Printer.Print(isGreater ?
                "Ваше число больше загаданного" :
                "Ваше число меньше загаданного");
            Printer.Print($"У вас осталось {remainingAttempts} попыток");
        }

        public void PrintVictoryMessage(int numberAttempts)
        {
            Printer.Print($"Ура! Это победа!");
            Printer.Print($"Вы потратили на это {numberAttempts} попыток");
        }

        public void PrintDefeatMessage()
        {
            Printer.Print($"Неужели вы проиграли? В следущий раз все получится)");
        }

        public void PrintException(Exception exc)
        {
            Printer.Print(exc.Message);
        }
    }
}
