using System;

namespace ExceptionalHaandelingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To excetion Handling!");
            Console.WriteLine("=========================================================================================\n");
            DivideByZeroErrorException.divideByeZeroError();
            Console.WriteLine("\n=========================================================================================");
        }
    }
}
