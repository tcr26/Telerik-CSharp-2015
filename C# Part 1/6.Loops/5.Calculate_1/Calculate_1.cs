using System;

namespace _5.Calculate_1
{
    class Calculate_1
    {
        static void Main()
        {
            //1 + 1!/X + 2!/X^2 + … + N!/X^N

            Console.WriteLine("Enter n number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x number:");
            int x = int.Parse(Console.ReadLine());

            int factorial = 1;
            double sum = 1;
            double result = 0;

            for (int i = 1; i <= n; i += 1)
            {
                factorial *= i;
                sum += (factorial / Math.Pow(x, i));
            }
            Console.WriteLine("{0:f5}", sum);
            Main();
        }
    }
}
