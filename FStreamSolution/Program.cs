using System;

namespace FStreamSolution
{




    class Program
    {


        static void Main(string[] args)
        {
            ILogger l = new ConsoleLogger();
            l = new FileLogger("log.txt");
            l.Log("Foo");
            //Solution s = new Solution();
            //s.Run();
        }
    }
}
