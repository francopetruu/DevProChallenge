using static Logger;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------LOGGING FUNCTIONALITY------");
            LogMessage("application.log", "User logged in", LogLevel.INFO);
            LogMessage("application.log", "User logged out", LogLevel.INFO);
            LogMessage("application.log", "INCORRECT PASSWORD", LogLevel.WARN);
        }
    }

