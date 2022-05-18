using System;

namespace AutomationCourse_HomeWork
{
    class Task3
    {
        static void Main()
        {
            Console.WriteLine("Write down three strings:");
            string first = Console.ReadLine().ToUpper();
            string second = Console.ReadLine().ToUpper();
            string third = Console.ReadLine().ToUpper();
            Console.WriteLine($"String {first} starts from {second}: {first.StartsWith(second)}");
            Console.WriteLine($"String {first} ends with {third}: {first.EndsWith(third)}");
        }
    }
}
