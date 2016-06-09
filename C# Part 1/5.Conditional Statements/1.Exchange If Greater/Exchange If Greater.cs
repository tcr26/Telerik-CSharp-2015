using System;

namespace _1.Exchange_If_Greater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("Enter number a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b:");
            double b = double.Parse(Console.ReadLine());
            double temp = a;

            if (a > b)
            {
                a = b;
                b = temp;
                Console.WriteLine("{0} {1}", a, b);
            }
            else if (a < b)
            {
                Console.WriteLine("{0} {1}", a, b);
            }
            Main();
        }
    }
}
