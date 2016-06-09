using System;

namespace _14.Decimal_to_Binary_Number
{
    class DecimalToBinaryNumber
    {
        static void Main()
        {
            Console.Write("Enter number:");
            long input = long.Parse(Console.ReadLine());
            string result = "";

            if (input == 0)
            {
                Console.Write("0");
            }

            while (input != 0)
            {
                int remainder = (int)input % 2;
                input /= 2;
                result = remainder + result;
            }

            Console.WriteLine(result);
            Main();
        }
    }
}
