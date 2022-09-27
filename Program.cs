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

            // Console.WriteLine();
            // string sentence1 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.";
            // Console.WriteLine(sentence1.ToLower());

            // Console.WriteLine();
            // int num1;
            // int num2;
            // Console.WriteLine("\nGiven first number:");
            // num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Given second number:");
            // num2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(num1 == 20 || num2 == 20 || (num1 + num2 == 20));

            // Console.WriteLine();
            // double n = 20.243D;
            // double m = 15.5756D;
            //Console.WriteLine($"What we input: {n} and {m}");
            // Console.WriteLine(AbsValue(n, m));

            // OddNum();
            // MultElem();
            // ReverseWords("Display the pattern like pyramid using the alphabet.");
            // ReverseWords("Vasyl love Alina");
            // BuildNumber();
            // SumDigits(12);

            // int x = 15;
            // CheckEvenOdd(x);

            // int y = 14;
            // CheckPositiveNegative(y);

            // int z = 21;
            // CheckIfCandidateCanVote(z);

            // int a = 135;
            // CategorizeByHeight(a);

            // int b = -5;
            // DisplayValue(b);

            // int c = 25;
            // int d = 63;
            // int e = 10;
            // FindLargestNumber(c, d, e);

            // int f = 3;
            // int g = 4;
            // CoordinatePoint(f, g);

            // double a = 784;
            // string b = "James";
            // double c = 70;
            // double d = 80;
            // double e = 90;
            // SubjectsToCalculatePercentageDivision(a, b, c, d, e);

            // Console.WriteLine();
            // SumAverageNumbers();

            // double n = 3;
            // SumAverageNumbersWithN(n);

            // DisplayAndReverseArray();

            // SumElementsArray();

            // CopyElementsToArray();

            // int x = 3;
            // ArrayFindBiggestNumber(x);

            // int n = 3;
            // ArrayFindLowestNumber(n);

            // int n = 3;
            // ArrayRepetitionNumber(n);


            ArrayEvenNumbers();

            ArrayOddNumbers();
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

        static void OddNum()
        {
            for (int x = 1; x < 100; x++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
            }
        }

        static void MultElem()
        {
            int[] firstarr = { 1, 3, -5, 4 };
            int[] secondarr = { 1, 4, -5, -2 };
            Console.WriteLine("The First Array: [{0}]", string.Join(", ", firstarr));
            Console.WriteLine("The Second Array: [{0}]", string.Join(", ", secondarr));
            Console.WriteLine("What we receive after multiplying corresponding elements of arrays: ");
            for (int i = 0; i < firstarr.Length; i++)
            {
                Console.Write(firstarr[i] * secondarr[i] + " ");
            }
        }

        static void ReverseWords(string str)
        {
            Console.WriteLine($"An original string: \n {str}");
            string[] sentence = str.Split(' ');
            string[] sentence1 = new string[sentence.Length];
            Console.WriteLine("The modified string: ");
            for (int i = 0, j = sentence.Length - 1; i < sentence.Length && j >= 0; i++, j--)
            {
                sentence1[j] = sentence[i];
            }
            Console.WriteLine(string.Join(" ", sentence1));
        }

        static void BuildNumber()
        {
            var numbersArray = new int[] { 3, 8, 0, 9, 9, 3, 0, 2, 8, 2, 0, 2 };
            string number = string.Join("", numbersArray);
            Console.WriteLine(number);
        }

        static void SumDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int lastDigit = number % 10;
                sum = sum + lastDigit;
                number = number / 10;
            }
            Console.WriteLine($"Sum of digits({number}) = {sum}");
        }

        static void CheckEvenOdd(int x)
        {
            Console.WriteLine($"\nGiven number: {x}");
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is an odd integer");
            }
            else if (x % 2 != 0)
            {
                Console.WriteLine($"{x} is an even integer");
            }
            else
            {
                Console.WriteLine($"{x} equals to 0");
            }
        }

        static void CheckPositiveNegative(int x)
        {
            Console.WriteLine($"\nGiven number: {x}");
            if (x > 0)
            {
                Console.WriteLine($"{x} is a positive number");
            }
            else if (x < 0)
            {
                Console.WriteLine($"{x} is a negative number");
            }
            else
            {
                Console.WriteLine($"{x} number equals to 0");
            }
        }

        static void CheckIfCandidateCanVote(int x)
        {
            Console.WriteLine($"\nThe candidate is able to vote if his/her age is 21 or more");
            if (x >= 21)
            {
                Console.WriteLine($"The candidate's age is {x}, so he/she is able to vote.");
            }
            else
            {
                Console.WriteLine($"The candidate's age is {x}, so he/she is not able to vote.");
            }
        }

        static void CategorizeByHeight(int x)
        {
            Console.WriteLine("\nCategorizing people's height: \n1.Dwarf; \n2.An avarage height; \n3.Tall");
            if (x <= 135)
            {
                Console.WriteLine($"The person's height is {x}, so he/she is Dwarf.");
            }
            else if (136 <= x && x <= 170)
            {
                Console.WriteLine($"The person's height is {x}, so he/she is an avarage height.");
            }
            else
            {
                Console.WriteLine($"The person's height is {x}, so he/she is tall.");
            }
        }

        static void DisplayValue(int m)
        {
            Console.WriteLine($"\nInput number: {m}");
            int n;
            if (m > 0)
            {
                n = 1;
            }
            else if (m == 0)
            {
                n = 0;
            }
            else
            {
                n = -1;
            }
            Console.WriteLine($"Output number: {n}");
        }

        static void FindLargestNumber(int x, int y, int z)
        {
            Console.WriteLine($"\nInput the 1st number: {x}; \nInput the 2nd number: {y}; \nInput the 3rd number: {z}");
            if (x > y && x > z)
            {
                Console.WriteLine("The 1st Number is the greatest among three.");
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("The 2nd Number is the greatest among three.");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three.");
            }
        }

        static void CoordinatePoint(int x, int y)
        {
            Console.WriteLine($"\nIn which quadrant lies the coordinate point ({x},{y})?");
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"\nThe coordinate point ({x},{y}) lies in 1st quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"\nThe coordinate point ({x},{y}) lies in 2nd quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"\nThe coordinate point ({x},{y}) lies in 3rd quadrant.");
            }
            else
            {
                Console.WriteLine($"\nThe coordinate point ({x},{y}) lies in 4th quadrant.");
            }
        }

        static void SubjectsToCalculatePercentageDivision(double a, string b, double c, double d, double e)
        {
            Console.WriteLine($"Roll No: {a}");
            Console.WriteLine($"Name of Student: {b}");
            Console.WriteLine($"Marks in Physics: {c}");
            Console.WriteLine($"Marks in Chemistry: {d}");
            Console.WriteLine($"Marks in Computer Application: {e}");
            double sum = c + d + e;
            Console.WriteLine($"Total Marks = {sum}");
            double percentage = sum / 3.0;
            Console.WriteLine($"Percentage = {percentage}");
            string division;
            if (percentage >= 65)
            {
                division = "First";
            }
            else if (percentage < 65 && percentage >= 45)
            {
                division = "Second";
            }
            else if (percentage < 45 && percentage > 36)
            {
                division = "Pass";
            }
            else
            {
                division = "Fail";
            }
            Console.WriteLine($"Division = {division}");
        }

        static void SumAverageNumbers()
        {
            int sum = 0;
            int number;
            double average;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Number-{0} :", i);
                number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine("\nThe sum of 10 numbers are: {0}", sum);
            average = sum / 10.0;
            Console.WriteLine("\nThe average is: {0}", average);
        }

        static void SumAverageNumbersWithN(double n)
        {
            double sum = 0;
            double number = 0;
            double average;
            for (double i = 1; i <= n; i++)
            {

                Console.WriteLine("Number-{0} :", i);
                number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine("\nThe sum of n numbers are: {0}", sum);
            average = sum / n;
            Console.WriteLine("\nThe average is: {0}", average);
        }

        static void DisplayAndReverseArray()
        {
            int i;
            int n = 3;
            int[] array = new int[n];
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("element - {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nThe values store into the array are:");
            for (i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("\nThe values store into the array in reverse are:");
            for (i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", array[i]);
            }

        }

        static void SumElementsArray()
        {
            int i;
            int sum = 0;
            int n = 3;
            int[] array = new int[n];
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("element - {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sum of all elements stored in the array is:");
            for (i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }

        static void CopyElementsToArray()
        {
            int i;
            int n = 3;
            int[] array = new int[n];
            int[] array1 = new int[n];
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("element - {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                array1[i] = array[i];
            }
            Console.Write("\nThe elements stored in the first array are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array[i]);
            }
            Console.Write("\nThe elements copied into the second array are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array1[i]);
            }
        }

        static void ArrayFindBiggestNumber(int n)
        {
            int i;
            int biggestNumber;
            int[] array = new int[n];
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("element - {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            biggestNumber = array[0];
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] > biggestNumber)
                {
                    biggestNumber = array[i];
                }
            }
            Console.WriteLine($"The biggest number in the array is {biggestNumber}");
        }

        static void ArrayFindLowestNumber(int n)
        {
            int i;
            int lowestNumber;
            int[] array = new int[n];
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("element - {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            lowestNumber = array[0];
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < lowestNumber)
                {
                    lowestNumber = array[i];
                }
            }
            Console.WriteLine($"The lowest number in the array is {lowestNumber}");
        }

        static void ArrayRepetitionNumber(int n)
        {
            int i;
            int[] array = new int[] { 2, 3, 2, 3, 3, 1, 5 };

            Console.WriteLine("The array: [{0}]", string.Join(", ", array));
            int count = 0;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine("The occurrence number {0} in array is " + count, n);
        }

        static void ArrayEvenNumbers()
        {
            int i;
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("The array: [{0}]", string.Join(", ", array));
            int count = 0;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.Write($"Even numbers are {count}");
        }

        static void ArrayOddNumbers()
        {
            int i;
            int[] array = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine("\nThe array: [{0}]", string.Join(", ", array));
            int count = 0;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.Write($"Odd numbers are {count}");
        }
    }
}
