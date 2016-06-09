using System;

namespace _2.Numbers_Not_Divisible_by_3_and_7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            Console.Write("Enter a possitive number:");
            uint input = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i += 1)
            {
                if (!(i % 3 == 0) && !(i % 7 == 0))
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Main();
        }
    }
}
