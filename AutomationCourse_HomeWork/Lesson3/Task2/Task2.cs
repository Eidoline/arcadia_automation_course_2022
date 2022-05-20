using System;

namespace Task2
{
    public class Rectangle
    {
        private double side1 { set; get; }
        private double side2 { set; get; }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
    }
    class Task2
    {
        static void Main()
        {
            Console.WriteLine("Please enter the measurements for rectangle:");
            Console.Write("Side 1 = ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 2 = ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle myRectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Area =  { myRectangle.AreaCalculator()} Perimeter = {myRectangle.PerimeterCalculator()}");
        }
    }
}
