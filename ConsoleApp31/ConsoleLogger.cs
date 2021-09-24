using System;

namespace ConsoleApp31
{
    class ConsoleLogger : ILogger
    {
        public void Critical(string m) => Console.WriteLine(m);
    }
}
