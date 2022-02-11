using System;

namespace AutomationCourse_HomeWork
{
    class Task_1
    {
        static void Main()
        {
            Console.WriteLine("Please add three arguments for the futher operations:");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("z = ");
            int z = Convert.ToInt32(Console.ReadLine());

            double result1 = (x + y) * (1 + Math.Sqrt(z));
            Console.WriteLine($"The result of the first statement: {result1}");          

            double result2 = (x % z - 1) * Math.Sqrt(y);
            Console.WriteLine($"The result of the second statement: {result2}");

            double result3 = (x * y + y * z) / Math.Pow(z, 3);
            Console.WriteLine($"The result of the third statement: {result3}");
        }
    }
}
