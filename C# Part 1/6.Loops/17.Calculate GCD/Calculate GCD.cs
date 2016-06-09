using System;

namespace _17.Calculate_GCD
{
    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("Enter number a:");
            int a = Math.Abs(int.Parse(Console.ReadLine()));
            Console.Write("Enter number b:");
            int b = Math.Abs(int.Parse(Console.ReadLine()));
            GCD(a, b);
            Main();
        }

        private static long GCD(long a, long b)
        {
            while (b != 0)
            {
                long tmp = b;
                b = a % b;
                a = tmp;
            }
            Console.WriteLine(a);
            return a;
        }
    }
}
