using System;

namespace AutomationCourse_HomeWork
{
    class Task2
    {
        public static double readMeasurement(string nameMeasurement)
        {
            string measurement;
            double validMeasurement;
            while (true)
            {
                Console.Write($"{nameMeasurement}: ");
                measurement = Console.ReadLine();
                if (double.TryParse(measurement, out validMeasurement) && validMeasurement > 0)
                    break;
                Console.WriteLine("Invalid value, try again.");
            }
            return validMeasurement;
        }
        static void Main()
        {
            Console.WriteLine("Please add three dimensions of the box for the futher operations:");
            double width = readMeasurement("Width");
            double height = readMeasurement("Height");
            double length = readMeasurement("Length");

            double diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine($"The length of the diagonal: {diagonal}");
        }
    }
}
