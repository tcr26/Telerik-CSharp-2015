using System;

namespace _1.Sum_of_3_Numbers
{
    class Sumof3Numbers
    {
        static void Main()
        {
            Console.Write("Enter first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter third number:");
            double thirdNumber = double.Parse(Console.ReadLine());

            double result = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine(result);
            Main();
        }
    }
}
