using Otus.Solid.Abstractions;
using System;

namespace Otus.Solid.Game
{
    public class GameReader
    {
        private IReader Reader { get; init; }

        public GameReader(IReader reader)
        {
            Reader = reader;
        }

        public int Read()
        {
            var str = Reader.Read();

            if (!int.TryParse(str, out var res)) throw new Exception("Введено неккоректное значение!");

            return res;
        }
    }
}
