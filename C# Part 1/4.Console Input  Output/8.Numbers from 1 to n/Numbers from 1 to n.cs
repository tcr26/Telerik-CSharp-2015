using System;

namespace _8.Numbers_from_1_to_n
{
    class Numbersfrom1ton
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            uint number = uint.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine(1);
            }

            for (uint i = 1; i < number; i += 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
