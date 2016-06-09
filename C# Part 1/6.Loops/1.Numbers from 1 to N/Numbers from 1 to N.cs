using System;

namespace _1.Numbers_from_1_to_N
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            uint input = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.Write("{0}", i + " ");
            }
            Console.WriteLine();
            Main();
        }
    }
}
