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

            // Console.WriteLine();
            // Console.WriteLine("Given string: w3resource");
            // string str = "w3resource";
            // char firstLetter = str[0];
            // char lastLetter = str[str.Length - 1];
            // firstLetter = str[str.Length - 1];
            // lastLetter = str[0];
            // string str1 = str.Substring(1, str.Length - 2);
            // Console.WriteLine("The outcome: " + firstLetter + str1 + lastLetter);
            // Console.WriteLine();

            // Console.WriteLine("Given string: Python");
            // string str2 = "Python";
            // char firstChar = str2[0];
            // char lastChar = str2[str2.Length - 1];
            // firstChar = str2[str2.Length - 1];
            // lastChar = str2[0];
            // string str3 = str2.Substring(1, str2.Length - 2);
            // Console.WriteLine("The outcome: " + firstChar + str3 + lastChar);
            // Console.WriteLine();

            // char[] myChar = new Char[] { 'T' };
            // string StrChar = new string(myChar);
            // string myStr = "The quick brown fox jumps over the lazy dog.";
            // Console.WriteLine("What we receive after adding 'T' to the string: " + StrChar + myStr + StrChar);

            // int x = 25;
            // int y = -5;
            // Console.WriteLine($"Input first integer: {x}");
            // Console.WriteLine($"Input second integer: {y}");
            // Console.WriteLine("Check if one is negative and one is positive: ");
            // Console.WriteLine(CheckInt(x, y));
            // Console.WriteLine();

            // int c = 5;
            // int d = 6;
            // Console.WriteLine(SumInt(c, d));

            // int a = 8;
            // int b = 8;
            // Console.WriteLine(SumInt(a, b));

            // Console.WriteLine();
            // Console.WriteLine("I print numbers from 1 to 99:");
            // int i;
            // for (i = 1; i <= 99; i++)
            // {
            //      Console.WriteLine(i);
            // }

            // Console.WriteLine();
            // Console.WriteLine("Given string: It is a string with smallest and largest word");
            // string sentence = "It is a string with smallest and largest word";
            // string[] splittowords = sentence.Split(' ');
            // string MaxWord = "";
            // int Max = 0;

            // foreach (string words in splittowords)
            // {
            //      if (Max < words.Length)
            //    {
            //      MaxWord = words;
            //    }
            // }
            //Console.WriteLine(MaxWord);

            Console.WriteLine();
            string sentence1 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.";
            Console.WriteLine(sentence1.ToLower());

            Console.WriteLine();
            int num1;
            int num2;
            Console.WriteLine("\nGiven first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Given second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 == 20 || num2 == 20 || (num1 + num2 == 20));

            Console.WriteLine();
            double n = 20.243D;
            double m = 15.5756D;
            Console.WriteLine($"What we input: {n} and {m}");
            Console.WriteLine(AbsValue(n, m));

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

        static Boolean CheckInt(int Number, int Number1)
        {
            if (0 < Number && Number1 < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int SumInt(int x, int y)
        {
            int sum = x + y;
            if (x == y)
            {
                return (sum * 3);
            }
            else
            {
                return (sum);
            }
        }


        static double AbsValue(double x, double y)
        {
            double subtraction = x - y;
            if (x > y)
            {
                return (Math.Abs(subtraction) * 2);
            }
            return (y - x);
        }
    }
}
}