namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("What is your name?");
            // var name = Console.ReadLine();
            // name = "Alina";
            // var currentDate = DateTime.Now;
            // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            // Console.WriteLine($"{Environment.NewLine}{currentDate:t} Where do you live now, {name}?");
            // Console.WriteLine($"{Environment.NewLine}{name}, explain me the difference between dogs and cats.");
            // Console.Write($"{Environment.NewLine}Press any key to exit...");
            // Console.ReadKey(true);

            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine(MethodSum(4, 9));
            // Console.ReadLine();
            // Console.WriteLine(MethodDivision(16.56, 3.13));
            // Console.WriteLine();

            // int firstNum = 5;
            // int secondNum = 6;
            // Console.WriteLine("Value of FirstNum and SecondNum before swapping:");
            // Console.WriteLine();
            // SwapNum(firstNum, secondNum);

            // Console.WriteLine();
            // double fahrenheit;
            // double kelvin;
            // double celsius = 18;
            // Console.WriteLine("Converting degrees: Celsius to Fahrenheit:");
            // Console.WriteLine("Celsius:" + celsius);
            // fahrenheit = (celsius * 9) / 5 + 32;
            // Console.WriteLine("Fahrenheit:" + fahrenheit);
            // Console.WriteLine("Converting degrees: Celsius to Kelvin:");
            // Console.WriteLine("Celsius:" + celsius);
            // kelvin = celsius + 273.15;
            // Console.WriteLine("Kelvin:" + kelvin);
            // Console.ReadLine();

            // Console.WriteLine(remove_char("w3resource", 1));
            // Console.WriteLine(remove_char("w3resource", 9));
            // Console.WriteLine(remove_char("w3resource", 0));

            string str = "w3resource";
            ReplaceLetter(str);
            string str2 = "Python";
            ReplaceLetter(str2);
            string myStr = "The quick brown fox jumps over the lazy dog.";
            AddFirstLetter(myStr);
            string myStr2 = "Who are you?";
            AddFirstLetter(myStr2);

        }

        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
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
            Console.WriteLine("firstNum=" + " " + firstNum);
            Console.WriteLine("secondNum=" + " " + secondNum);
            int g = firstNum;
            firstNum = secondNum;
            secondNum = g;
            Console.WriteLine("Value of FirstNum and SecondNum after swapping:");
            Console.WriteLine("firstNum=" + " " + firstNum);
            Console.WriteLine("secondNum=" + " " + secondNum);
        }

        static void AddFirstLetter(string myStr)
        {
            char myChar = myStr[0];
            myStr = myChar + myStr + myChar;
            Console.WriteLine($"What we receive after adding '{myChar}' to the string: " + myStr);

        }

        static void ReplaceLetter(string str)
        {
            Console.WriteLine("Given string: " + str);
            char firstLetter = str[0];
            char lastLetter = str[str.Length - 1];
            str = str.Substring(1, str.Length - 2);
            string finalLetter = lastLetter + str + firstLetter;
            Console.WriteLine("The outcome: " + finalLetter);
        }

    }
}