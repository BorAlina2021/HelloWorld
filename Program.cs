﻿namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            name = "Alina";
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.WriteLine($"{Environment.NewLine}{currentDate:t} Where do you live now, {name}?");
            Console.WriteLine($"{Environment.NewLine}{name}, explain me the difference between dogs and cats.");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);

            Console.ReadLine();
            Console.WriteLine(MethodSum(4, 9));

        }

        static int MethodSum(int x, int y)
        {
            return x + y;
        }
    }
}