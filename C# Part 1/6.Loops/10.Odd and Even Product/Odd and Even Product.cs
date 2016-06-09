using System;

namespace _10.Odd_and_Even_Product
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.Write("Enter n integers:");
            string[] numbers = Console.ReadLine().Split(' ');
            int even = 1;
            int odd = 1;

            for (int i = 0; i < numbers.Length; i += 1)
            {
                int num = int.Parse(numbers[i]);

                if (i % 2 == 0 || i == 0)
                {
                    even *= num;
                }
                else
                {
                    odd *= num;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Main();
        }
    }
}
