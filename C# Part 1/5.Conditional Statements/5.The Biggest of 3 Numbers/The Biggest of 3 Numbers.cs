using System;

namespace _5.The_Biggest_of_3_Numbers
{
    class TheBiggestof3Numbers
    {
        static void Main()
        {
            Console.Write("Enter first number:");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            double number2 = double.Parse(Console.ReadLine());
            Console.Write("Enter third number:");
            double number3 = double.Parse(Console.ReadLine());

            double tempMax = Math.Max(number1, number2);
            double result = Math.Max(tempMax, number3);
            Console.WriteLine("the biggest number from {0} {1} {2} is {3}", number1, number2, number3, result);
            Main();
        }
    }
}
