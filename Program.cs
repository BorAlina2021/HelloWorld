namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.WriteLine($"{Environment.NewLine}{currentDate:t}Where do you live now, {name}?");
            Console.WriteLine($"{Environment.NewLine}{name}, explain me the difference between dogs and cats.");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            Console.WriteLine("Vasyl changes");
        }
    }
}