using System;

namespace _9.Trapezoids_Area
{
    class TrapezoidsArea
    {
        static void Main()
        {
            Console.Write("Enter side a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter height:");
            double height = double.Parse(Console.ReadLine());

            double area = height * ((a + b) / 2);
            Console.WriteLine("the area of the trapezoid is:{0}", area);
            Main();
        }
    }
}
