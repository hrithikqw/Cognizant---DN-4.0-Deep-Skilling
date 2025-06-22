using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("This is the first log message.");
        logger2.Log("This is the second log message.");

        if (ReferenceEquals(logger1, logger2))
        {
            Console.WriteLine("Both logger1 and logger2 are the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton pattern failed. Different instances detected.");
        }
    }
}