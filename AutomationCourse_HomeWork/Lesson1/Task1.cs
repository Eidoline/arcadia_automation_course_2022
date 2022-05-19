using System;

namespace AutomationCourse_HomeWork
{
    class Task1
    {
        public static bool isAnyNumber(double x)
        {
            return true;
        }

        public static bool isNotNegativeNumber(double y)
        {
            return y >= 0;
        }

        public static bool isPositiveNumber(double z)
        {
            return z > 0;
        }
        public static double readNumber(string varName, Func<double, bool> validateNumber)
        {
            double parsedNumber;
            while (true)
            {
                Console.Write($"{varName} = ");
                string number = Console.ReadLine();
                if (double.TryParse(number, out parsedNumber) && validateNumber(parsedNumber))
                    break;
                Console.WriteLine("Invalid value, try again.");
            }
            return parsedNumber;
        }
        static void Main()
        {
            Console.WriteLine("Please add three arguments for the futher operations:");
            double x = readNumber("x", isAnyNumber);
            double y = readNumber("y", isNotNegativeNumber);
            double z = readNumber("z", isPositiveNumber);

            double result1 = (x + y) * (1 + Math.Sqrt(z));
            Console.WriteLine($"First expression result: {result1}");          

            double result2 = (x % z - 1) * Math.Sqrt(y);
            Console.WriteLine($"Second expression result: {result2}");

            double result3 = (x * y + y * z) / Math.Pow(z, 3);
            Console.WriteLine($"Third expression result: {result3}");
        }
    }
}