using System;

namespace Task_2
{
    class Task_2
    {
        static void Main()
        {
            Console.WriteLine("Please add three dimensions of the box for the futher operations:");
            Console.Write("Width: ");
            double width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length: ");
            double length = Convert.ToInt32(Console.ReadLine());

            double diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine($"The length of the diagonal: {diagonal}");
        }
    }
}
