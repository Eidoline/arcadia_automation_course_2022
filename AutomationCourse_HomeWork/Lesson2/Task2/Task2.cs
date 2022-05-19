using System;

namespace Task2
{
    class Task2
    {
        static Func<double, double, double> Addition = (x, y) => (x + y);
        static Func<double, double, double> Subtraction = (x, y) => (x - y);
        static Func<double, double, double> Division = (x, y) => (x / y);
        static Func<double, double, double> Multiplication = (x, y) => (x * y);
        static Func<double, double, double> Exponentiation = (x, y) => Math.Pow(x, y);

        public static double ReadOperand()
        {
            double parsedNumber;
            while (true)
            {
                string userOperand = Console.ReadLine();
                if (double.TryParse(userOperand, out parsedNumber)) break;
                Console.WriteLine("Not valid value, try again:");
            }
            return parsedNumber;
        }
       static public Func<double, double, double> ReadOperator()
        {
            string userOperator;
            while(true)
            {
                userOperator = Console.ReadLine();
                switch (userOperator)
                {
                    case "+":
                        return Addition;
                    case "-":
                        return Subtraction;
                    case "/":
                        return Division;
                    case "*":
                        return Multiplication;
                    case "^":
                        return Exponentiation;
                    default:
                        Console.WriteLine("Not valid value, try again:");
                        break;
                }

            }
        }
        static void Main()
        {
            Console.Write("Enter the first operand: ");
            double operand1 = ReadOperand();
            Console.Write("Enter the second operand: ");
            double operand2 = ReadOperand();
            Console.Write("Enter the operator: ");
            Func<double, double, double> action = ReadOperator();
            double result = action(operand1, operand2);
            Console.WriteLine($"The result for your operation: {result}");
        }
    }
}
