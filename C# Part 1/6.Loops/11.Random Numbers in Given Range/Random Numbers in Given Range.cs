using System;

namespace _11.Random_Numbers_in_Given_Range
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.Write("Enter range of numbers:");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter min number:");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Ente max number:");
            int max = int.Parse(Console.ReadLine());

            Random random = new Random();


            for (int i = 0; i < n; i += 1)
            {
                int realRandom = random.Next(min, max + 1);
                Console.WriteLine(realRandom);
            }
            Main();
        }
    }
}
