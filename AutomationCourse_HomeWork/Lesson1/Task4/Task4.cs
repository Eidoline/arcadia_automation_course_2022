using System;

namespace AutomationCourse_HomeWork
{
    class Task4
    {
        static void Main()
        {
            Console.WriteLine("Write down two strings and char:");
            string stringFirst = Console.ReadLine();
            string stringSecond = Console.ReadLine();
            string charValue = Console.ReadLine();
            string resultString = stringFirst + stringSecond;
            int result = resultString.LastIndexOf(charValue);
            Console.WriteLine($"Index of {charValue} in {resultString}: {result}");
        }
    }
}
