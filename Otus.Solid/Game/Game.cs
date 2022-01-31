using Otus.Solid.Abstractions;

namespace Otus.Solid.Game
{
    public abstract class Game
    {
        protected GameReader Reader { get; init; }
        protected GamePrinter Printer { get; init; }
        protected GameSettings Setting { get; init; }

        public Game(IReader reader, IPrinter printer, GameSettings settings)
        {
            Reader = new GameReader(reader);
            Printer = new GamePrinter(printer);
            Setting = settings;
        }

        public abstract void Start();
    }
}
