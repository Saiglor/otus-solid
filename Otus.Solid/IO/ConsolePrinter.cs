using Otus.Solid.Abstractions;
using System;

namespace Otus.Solid.IO
{
    internal class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
