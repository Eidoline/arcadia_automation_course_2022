using System;

namespace Lesson3
{
    class Task1
    {
        static void Main()
        {
            Console.WriteLine("Enter the dimension for matrix: ");
            int dim = Convert.ToInt32(Console.ReadLine());
            double[,] randomMatrix = new double[dim, dim];
            Random random = new Random();
            Console.WriteLine("Here is your matrix:");
            for(int i = 0; i < dim; i++)
            {
                for(int j = 0; j < dim; j++)
                {
                    randomMatrix[i, j] = Math.Round(random.NextDouble(), 2);
                    Console.Write($"{ randomMatrix[i, j]}  ");
                }
                Console.WriteLine();
            }
            double trace = 0;
            for(int i = 0; i < dim; i++)
            {
                trace += randomMatrix[i, i];
            }
            Console.WriteLine($"Here is matrix trace: {trace}");
        }
    }
}
