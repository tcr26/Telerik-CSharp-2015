using System;

namespace _13.Comparing_Floats
{
    class ComparingFloats
    {
        static void Main()
        {
            Console.Write("Enter number a:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter number b:");
            double num2 = double.Parse(Console.ReadLine());

            double eps = 0.000001D;

            bool checkNumber = Math.Abs(num1 - num2) < eps;

            if (checkNumber)
            {
                Console.WriteLine(checkNumber);
            }
            else
            {
                Console.WriteLine(checkNumber);
            }
            Main();
        }
    }
}
