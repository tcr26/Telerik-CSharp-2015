using System;

namespace _6._2
{
    class Calculate_2
    {
        static void Main()
        {
            //n! / k! for given n and k (1 < k < n < 100).

            Console.WriteLine("enter n number:");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine("enter k number");
            ulong k = ulong.Parse(Console.ReadLine());

            ulong factorialN = 1;
            ulong factorialK = 1;
            double sum;

            for (ulong i = 1; i <= n; i += 1)
            {
                factorialN *= i;

                if (i <= k)
                {
                    factorialK *= i;
                }
            }

            sum = factorialN / factorialK;
            Console.WriteLine(sum);
            Main();
        }
    }
}
