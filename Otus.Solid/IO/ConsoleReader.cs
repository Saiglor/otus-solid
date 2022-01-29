using Otus.Solid.Abstractions;
using System;

namespace Otus.Solid.IO
{
    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
