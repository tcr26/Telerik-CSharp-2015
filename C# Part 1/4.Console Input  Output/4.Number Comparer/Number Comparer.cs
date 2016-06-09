using System;

namespace _4.Number_Comparer
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double number = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("{0} is bigger", number);
            Main();
        }
    }
}
