using System;

namespace _6.Print_a_Sequence
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            short number = short.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * -1);
                }
            }
        }
    }
}
