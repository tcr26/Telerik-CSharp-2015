using System;

namespace _11.Numbers_in_Interval_Dividable_by_Given_Number
{
    class NumbersinIntervalDividablebyGivenNumber
    {
        static void Main()
        {
            Console.Write("Enter min border number: ");
            uint number1 = uint.Parse(Console.ReadLine());
            Console.Write("Enter max border number: ");
            uint number2 = uint.Parse(Console.ReadLine());

            for (uint i = number1; i <= number2; i += 1)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                    Console.WriteLine();
                }
            }
            Main();
        }
    }
}
