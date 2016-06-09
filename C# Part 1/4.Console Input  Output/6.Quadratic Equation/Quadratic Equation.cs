using System;

namespace _6.Quadratic_Equation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("enter coefficients a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter coefficients b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter coefficients c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);

            if (a != 0)
            {
                if (discriminant > 0)
                {
                    double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("x1 = {0} x2 = {1}", x1, x2);
                }
                else if (discriminant == 0)
                {
                    double x1Andx2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("x1 and x2 = {0}", x1Andx2);
                }
                else if (discriminant < 0)
                {
                    Console.WriteLine("No real roots");
                }
            }
            Main();
        }
    }
}
