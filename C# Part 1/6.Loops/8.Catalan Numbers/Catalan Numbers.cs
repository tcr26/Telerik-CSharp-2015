using System;
using System.Numerics;
namespace _8.Catalan_Numbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.WriteLine("enter n number:");
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            BigInteger factorialN2 = 1;
            BigInteger factorialPlus1 = 1;

            if (n <= 1)
            {
                return;
            }

            for (int i = 1; i <= 2 * n; i += 1)
            {
                factorialN2 *= i;
                if (i <= n)
                {
                    factorial *= i;
                }
            }

            for (int i = 1; i <= n + 1; i += 1)
            {
                factorialPlus1 *= i;
            }

            BigInteger result = factorialN2 / (factorial * factorialPlus1);
            Console.WriteLine(result);
            Main();
        }
    }
}
