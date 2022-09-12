namespace HelloWorld
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
            Console.ReadLine();
            Console.WriteLine(MethodSum(4, 9));
            Console.ReadLine();
            Console.WriteLine(MethodDivision(16.56, 3.13));
            Console.ReadLine();

            int firstNum = 5;
            int secondNum = 6;
            Console.WriteLine("Value of FirstNum and SecondNum before swapping:");
            Console.WriteLine();
            Console.WriteLine("firstNum=" + " " + firstNum);
            Console.WriteLine("secondNum=" + " " + secondNum);
            SwapNum(firstNum, secondNum);
            Console.WriteLine();
            Console.WriteLine("Value of FirstNum and SecondNum after swapping:");
            Console.WriteLine();
            Console.WriteLine("firstNum=" + " " + secondNum);
            Console.WriteLine("secondNum=" + " " + firstNum);
            Console.WriteLine();
        }

        static int MethodSum(int x, int y)
        {
            return x + y;
        }

        static double MethodDivision(double a, double b)
        {
            return a / b;
        }

        static void SwapNum(int firstNum, int secondNum)
        {
            int g = firstNum;
            firstNum = secondNum;
            firstNum = g;
        }
    }
}