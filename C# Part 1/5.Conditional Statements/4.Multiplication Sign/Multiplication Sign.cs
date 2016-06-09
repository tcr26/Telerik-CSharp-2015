using System;

namespace _4.Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Console.Write("Enter number a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number c:");
            double c = double.Parse(Console.ReadLine());

            double multiplication = (a * b * c);

            if (multiplication == 0)
            {
                Console.WriteLine("0");
            }
            else if (multiplication < 0)
            {
                Console.WriteLine("-");
            }
            else if (multiplication > 0)
            {
                Console.WriteLine("+");
            }
            Main();
        }
    }
}
