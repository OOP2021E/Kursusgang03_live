using System;

namespace ConsoleApp31
{
    class StudentManagerApp
    {
        IDatabase db { get; }
        public ILogger Logger { get; private set; } //= new ConsoleLogger();

        

        public StudentManagerApp(ILogger logger, IDatabase db)
        {
            Logger = logger;
            this.db = db;
        }
        public void LogError(string message)
        {
            Console.WriteLine(message);
        }

        public void Start()
        {
            Console.WriteLine("Hello");
            while (true)
            {
                ConsoleKeyInfo ch = Console.ReadKey();
                switch (ch.Key)
                {
                    case ConsoleKey.N:
                        Logger = new NetworkLogger();
                        break;
                    case ConsoleKey.T:
                        Logger = new ConsoleLogger();
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.Q:
                        return;
                    default:
                        break;
                }
            }
        }

        public StudentManagerApp()
        {

        }
    }
}
