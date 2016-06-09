using System;

namespace _8.Prime_Check
{
    class PrimeCheck
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(num));
            Main();
        }

        private static bool isPrime(int n)
        {
            if (n < 0 || n == 0)
            {
                return false;
            }

            if (n == 1)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
