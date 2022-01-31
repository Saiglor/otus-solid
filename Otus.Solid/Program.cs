using Otus.Solid.Abstractions;
using Otus.Solid.Game;
using Otus.Solid.IO;

namespace Otus.Solid
{
    internal class Program
    {
        static void Main()
        {
            IReader reader = new ConsoleReader();
            IPrinter printer = new ConsolePrinter();

            var settings = new GameSettings()
                .SetTotatNumberAttempts(3)
                .SetMinNumber(50)
                .SetMaxNumber(100);

            var game = new GuessNumberGame(reader, printer, settings);
            game.Start();
        }
    }
}
